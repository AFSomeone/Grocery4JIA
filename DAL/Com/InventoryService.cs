using Model.Const;
using Model.Entity;
using Model.Exception;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;

namespace DAL.Com
{
    public class InventoryService : BaseService
    {
        public List<StockGoodsVO> LoadGoodsInStock(Order order, int catgId, int minInvNum, PageVO page)
        {
            return LoadGoodsInStock(order, catgId, null, minInvNum, page);
        }

        /// <summary>
        /// 加载在库的商品信息
        /// </summary>
        /// <param name="order">订单信息</param>
        /// <param name="catgId">分类Id</param>
        /// <param name="gNmId">商品Id/名称</param>
        /// <param name="minInvNum">最低库存量</param>
        /// <returns></returns>
        public List<StockGoodsVO> LoadGoodsInStock(Order order, int catgId, string gNmId, int minInvNum, PageVO page)
        {
            string sql = "SELECT odr.OrderNO,"
                       + "odr.CustID,"
                       + "odr.CustName,"
                       + "si.GID,"
                       + "si.ExpDt,"
                       + "si.Price,"
                       + "si.SID as TgtSID,"
                       + "g.GName,"
                       + "g.Specs,"
                       + "inv.Num,"
                       + "inv.InvID,"
                       + "g.Remark "
                       + "FROM ORDERS odr,"
                       + "STOCKIN si,"
                       + "INVENTORY inv,"
                       + "GOODS g "
                       + "WHERE odr.OrderNO=si.OrderNO "
                       + "AND odr.OrderNO = inv.OrderNO "
                       + "AND si.GID = inv.GID "
                       + "AND si.GID = g.GID "
                       + "AND odr.Direct=@direct "
                       + "AND inv.Num>=@minNum ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("direct", DIRECT.STOCK_IN);
            values.Add("minNum", minInvNum);
            if (catgId != 0)
            {
                sql += "AND g.SubCatgID=@catgId ";
                values.Add("catgId", catgId);
            }
            if (null != order.CustID && order.CustID != 0)
            {
                sql += "AND odr.CustID=@custId ";
                values.Add("custId", order.CustID);
            }
            if (!StringUtil.isEmpty(order.OrderNO__PK))
            {
                sql += "AND odr.OrderNO LIKE @OrderNO ";
                values.Add("OrderNO", "%" + order.OrderNO__PK + "%");
            }
            if (!StringUtil.isEmpty(gNmId))
            {
                sql += "AND(g.GID LIKE @gNmId OR g.GName LIKE @gNmId) ";
                values.Add("gNmId", "%" + gNmId + "%");
            }
            sql += "ORDER BY odr.OrderNO DESC,si.ExpDt,g.GID";
            if(null == page)
                return Connector.LoadModels<StockGoodsVO>(sql, values);
            else
                return Connector.LoadModelsByPage<StockGoodsVO>(sql, values, page);
        }

        public List<StockGoodsVO> LoadSoldGoods(Order order, int catgId, PageVO page)
        {
            string sql = "SELECT odr.OrderNO,"
                       + "odr.CustID,"
                       + "odr.CustName,"
                       + "si.ExpDt,"
                       + "g.GID,"     
                       + "g.GName,"
                       + "g.Specs,"
                       + "g.Remark,"
                       + "so.Num,"
                       + "so.RfNum,"
                       + "so.Price,"
                       + "so.SID as TgtSID,"
                       + "inv.InvID "
                       + "FROM ORDERS odr,"
                       + "STOCKOUT so,"
                       + "STOCKIN si,"
                       + "INVENTORY inv,"
                       + "GOODS g "
                       + "WHERE odr.OrderNO=so.OrderNO "
                       + "AND inv.InvID = so.InvID "
                       + "AND si.OrderNO = inv.OrderNO "
                       + "AND si.GID = inv.GID "
                       + "AND si.GID = g.GID "
                       + "AND odr.Direct=@direct "
                       + "AND (so.Num-so.rfNum)>0 ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("direct", DIRECT.STOCK_OUT);
            if (catgId != 0)
            {
                sql += "AND g.SubCatgID=@catgId ";
                values.Add("catgId", catgId);
            }
            if (null != order.CustID && order.CustID != 0)
            {
                sql += "AND odr.CustID=@custId ";
                values.Add("custId", order.CustID);
            }
            if (!StringUtil.isEmpty(order.OrderNO__PK))
            {
                sql += "AND odr.OrderNO LIKE @OrderNO ";
                values.Add("OrderNO", "%" + order.OrderNO__PK + "%");
            }
            sql += "ORDER BY si.ExpDt,g.GID";

            if (null == page)
                return Connector.LoadModels<StockGoodsVO>(sql, values);
            else
                return Connector.LoadModelsByPage<StockGoodsVO>(sql, values, page);
        }

        public int UpdateInvNum(long invID, int bfNum, int num, Usr oprtUsr)
        {
            int cnt = 0;
            string sql = "SELECT InvID,OrderNO,GID,Num FROM INVENTORY WHERE InvID=@invId";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("invId", invID);
            List<Inventory> list = Connector.LoadModels<Inventory>(sql, values);
            if (null != list && list.Count > 0)
            {
                DateTime now = DateTime.Now;
                Inventory _inv = list[0];
                if (bfNum != _inv.Num)
                {
                    throw new JException("JE-700");
                }
                try
                {
                    Connector.DbHelper.BeginTransaction();
                    InventoryChld chld = new InventoryChld();
                    chld.BefNum = bfNum;
                    chld.GID = _inv.GID;
                    chld.OrderNO = _inv.OrderNO;
                    chld.InvID = invID;
                    chld.Num = num;
                    chld.OprtDirect = DIRECT.STOCKTAKING;
                    chld.OprtUsrId = oprtUsr.UId__PK;
                    chld.OprtTmst = now;

                    cnt += Connector.Save<InventoryChld>(chld);

                    Inventory inv = new Inventory();
                    inv.InvID__PK = invID;
                    inv.Num = num;
                    inv.Tmst = now;

                    cnt += Connector.Update<Inventory>(inv);
                    Connector.DbHelper.CommitTransaction();
                }
                catch
                {
                    Connector.DbHelper.RollbackTransaction();
                }
            }
            else
                throw new JException("JE-001");
            return cnt;
        }

        public List<InvOprtChldVO> LoadOprtChld(long invId)
        {
            string sql = "SELECT chld.ChldID,"
                        + "chld.InvID,"
                        + "chld.OrderNO,"
                        + "chld.GID,"
                        + "chld.BefNum,"
                        + "chld.Num,"
                        + "chld.OprtDirect,"
                        + "chld.OprtUsrId,"
                        + "chld.OprtTmst,"                
                        + "u.UName "
                        + "FROM INVENTORY_CHLD chld,USR u "
                        + "WHERE chld.OprtUsrId=u.UID "
                        + "AND chld.InvID=@invId "
                        + "ORDER BY chld.ChldID";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("invId", invId);
            return Connector.LoadModels<InvOprtChldVO>(sql, values);
        }
    }
}
