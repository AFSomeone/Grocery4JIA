using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;

namespace DAL.Com
{
    public class StockInService : BaseService
    {
        /// <summary>
        /// 入库操作
        /// </summary>
        /// <param name="vo"></param>
        /// <returns>入库单号</returns>
        public string Stockin(StockinOrderVO vo)
        {
            string orderNO = string.Empty;
            DateTime now = DateTime.Now;
            if (null == vo)
                return orderNO;
            try
            {
                Connector.DbHelper.BeginTransaction();
                decimal amount = 0;
                orderNO = GenOrderNO(string.Format("{0:yyyyMMdd}", now));
                foreach (StockIn sin in vo._StockinList)
                {
                    sin.OrderNO = orderNO;
                    amount += sin.Price * sin.Num;
                    Connector.Save<StockIn>(sin, true);

                    Inventory inv = new Inventory();
                    inv.GID = sin.GID;
                    inv.OrderNO = orderNO;
                    inv.Num = sin.Num;
                    inv.Tmst = now;
                    Connector.Save<Inventory>(inv, true);
                }
                //入库流水
                AddChld(orderNO, vo.CrtUID);

                Order order = new Order();
                order.CustID = vo.CustID;
                order.CustName = vo.CustName;
                order.Direct = vo.Direct;
                order.UptUID = vo.UptUID;
                order.CrtUID = vo.CrtUID;
                order.CrtTmst = now;
                order.UptTmst = now;
                order.OrderNO = orderNO;
                order.Amount = amount;
                Connector.Save<Order>(order);
                Connector.DbHelper.CommitTransaction();
            }
            catch
            {
                Connector.DbHelper.RollbackTransaction();
                orderNO = string.Empty;
            }
            return orderNO;
        }

        /// <summary>
        /// 加载入库单信息
        /// </summary>
        /// <param name="order"></param>
        /// <returns>入库单列表</returns>
        public List<StockinOrderVO> LoadOrders(Order order)
        {
            string sql = "SELECT od.OrderNO,"
                       + "od.Amount,"
                       + "od.CustID,"
                       + "od.CustName,"
                       + "od.Direct,"
                       + "od.UptTmst,"
                       + "od.CrtTmst,"
                       + "od.UptUID,"
                       + "od.CrtUID,"
                       + "u1.UName as crtUName,"
                       + "u2.UName as uptUName "
                       + "FROM ORDERS od,"
                       + "USR u1,"
                       + "USR u2 "
                       + "WHERE od.CrtUID=u1.UID "
                       + "AND od.UptUID=u2.UID ";
            Dictionary<string, object> values = null;
            if (!StringUtil.isEmpty(order.Direct))
            {
                if (null == values)
                    values = new Dictionary<string, object>();
                sql += "AND od.Direct=@Direct ";
                values.Add("Direct",order.Direct);
            }
            if (null != order.CrtTmst)
            {
                DateTime startDt = ((DateTime)order.CrtTmst).AddDays(-1);
                DateTime endDt = ((DateTime)order.CrtTmst).AddDays(1);
                sql += "AND od.CrtTmst>=@StDt AND od.CrtTmst<=@EndDt ";
                if (null == values)
                    values = new Dictionary<string, object>();
                values.Add("StDt", startDt);
                values.Add("EndDt", endDt);
            }
            if (!StringUtil.isEmpty(order.OrderNO))
            {
                sql += "AND od.OrderNO LIKE @OrderNO ";
                if (null == values)
                    values = new Dictionary<string, object>();
                values.Add("OrderNO", "%" + order.OrderNO + "%");

            }
            if (order.CustID != 0)
            {
                sql += "AND od.CustID=@CustID ";
                if (null == values)
                    values = new Dictionary<string, object>();
                values.Add("CustID", order.CustID);
            }
            sql += "ORDER BY od.OrderNO DESC";
            return Connector.LoadModels<StockinOrderVO>(sql, values);
        }

        /// <summary>
        /// 加载入库单明细
        /// </summary>
        /// <param name="orderNO"></param>
        /// <returns></returns>
        public List<StockinOrderDetailVO> LoadOrderDetail(string orderNO)
        {
            string sql = "SELECT s.SID,"
                        +"s.GID,"
                        +"g.GName,"
                        +"g.Specs,"
                        +"g.ShelfLife,"
                        +"s.Num,"
                        +"s.Price,"
                        +"s.MfDt,"
                        +"s.ExpDt "
                        +"FROM STOCKIN s,GOODS g "
                        +"WHERE s.GID=g.GID "
                        +"AND s.OrderNO=@OrderNO "
                        +"ORDER BY s.SID";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("OrderNO", orderNO);
            return Connector.LoadModels<StockinOrderDetailVO>(sql,values);
        }

        /// <summary>
        /// 生成入库单号
        /// </summary>
        /// <param name="dtStr">日期（yyyyMMdd）</param>
        /// <returns></returns>
        private string GenOrderNO(string dtStr)
        {
            string orderNO = null;
            string sql = "SELECT MAX(OrderNO) FROM ORDERS WHERE OrderNO LIKE @today";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("today", ORDERNO_PREF.STOCK_IN + dtStr + "%");
            orderNO = Connector.ScalarStr(sql, values);
            if (null == orderNO)
                orderNO = ORDERNO_PREF.STOCK_IN + dtStr + "00001";
            else
            {
                long no = long.Parse(orderNO.Replace(ORDERNO_PREF.STOCK_IN,""));
                orderNO = ORDERNO_PREF.STOCK_IN + (no+1);
            }
            return orderNO;
        }

        private void AddChld(string orderNO, string usrId)
        {
            string sql = "INSERT INTO INVENTORY_CHLD(InvID,OrderNO,GID,BefNum,Num,OprtDirect,OprtUsrId)"
                       + "SELECT InvID,OrderNO,GID,0,Num,@direct,@oprtUId "
                       + "FROM INVENTORY WHERE OrderNO=@orderNo";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("direct", DIRECT.STOCK_IN);
            values.Add("oprtUId", usrId);
            values.Add("orderNo", orderNO);
            Connector.DbHelper.ExecuteSql(sql, values);
        }
    }
}
