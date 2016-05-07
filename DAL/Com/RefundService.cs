using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;

namespace DAL.Com
{
    public class RefundService : BaseService
    {
        /// <summary>
        /// 加载在库的商品信息
        /// </summary>
        /// <param name="order">订单信息</param>
        /// <param name="catgId">分类Id</param>
        /// <returns></returns>
        public List<InStockGoodsVO> LoadGoodsInStock(Order order, int catgId)
        {
            string sql = "SELECT odr.OrderNO,"
                       + "odr.CustID,"
                       + "odr.CustName,"
                       + "si.GID,"
                       + "si.ExpDt,"
                       + "si.Price,"
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
                       + "AND si.ST=@st "
                       + "AND inv.Num>0 ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("direct", DIRECT.STOCK_IN);
            values.Add("st", ST.VALID);
            if (catgId != 0)
            {
                sql += "AND g.SubCatgID=@catgId ";
                values.Add("catgId", catgId);
            }
            if (order.CustID != 0)
            {
                sql += "AND odr.CustID=@custId ";
                values.Add("custId", order.CustID);
            }
            if (!StringUtil.isEmpty(order.OrderNO))
            {
                sql += "AND odr.OrderNO LIKE @OrderNO ";
                values.Add("OrderNO", "%" + order.OrderNO + "%");
            }
            sql += "ORDER BY si.ExpDt";
            return Connector.LoadModels<InStockGoodsVO>(sql, values);
        }

        public List<RefundOrderDetailVO> LoadOrderDetail(string orderNO)
        {
            string sql = "SELECT r.RID,"
                        + "r.OrderNO,"
                        + "r.InvID,"
                        + "r.Num,"
                        + "r.Price,"
                        + "r.Direct,"
                        + "inv.OrderNO as SinOrderNO,"
                        + "g.GID,"
                        + "g.GName,"
                        + "g.Specs "
                        + "FROM REFUNDS r,INVENTORY inv, GOODS g "
                        + "WHERE r.InvID=inv.InvID "
                        + "AND inv.GID=g.GID "
                        + "AND r.OrderNO=@OrderNO "
                        + "ORDER BY r.RID";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("OrderNO", orderNO);
            return Connector.LoadModels<RefundOrderDetailVO>(sql, values);
        }

        /// <summary>
        /// 退货
        /// </summary>
        /// <param name="RefundOrderVO"></param>
        /// <returns>退货单号</returns>
        public string Refund(RefundOrderVO refundVO)
        {
            string orderNO = string.Empty;
            DateTime now = DateTime.Now;
            if (null == refundVO)
                return orderNO;
            try
            {
                Connector.DbHelper.BeginTransaction();
                decimal amount = 0;
                int direct = 0;
                string uptSql = "UPDATE INVENTORY SET Num=Num-@rfNum,Tmst=@tmst WHERE InvID=@invID";
                if (DIRECT.REFUND2SUPPLIER == refundVO.Direct)
                    direct = 1;
                else if (DIRECT.RESELLER_REFUND == refundVO.Direct)
                    direct = -1;
                else
                    return orderNO;
                orderNO = GenOrderNO(string.Format("{0:yyyyMMdd}", now), refundVO.Direct);
                foreach (Refund rf in refundVO._RefundList)
                {
                    rf.OrderNO = orderNO;
                    amount += rf.Price * rf.Num;
                    Connector.Save<Refund>(rf, true);
                    //记录流水
                    AddChld(rf.InvID, refundVO.CrtUID, rf.Num, refundVO.Direct);
                    Dictionary<string, object> values = new Dictionary<string, object>();
                    values.Add("rfNum", rf.Num*direct);
                    values.Add("tmst", now);
                    values.Add("invID", rf.InvID);
                    Connector.DbHelper.ExecuteSql(uptSql, values);
                }

                Order order = new Order();
                order.CustID = refundVO.CustID;
                order.CustName = refundVO.CustName;
                order.Direct = refundVO.Direct;
                order.UptUID = refundVO.UptUID;
                order.CrtUID = refundVO.CrtUID;
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
        /// 生成退货单号
        /// </summary>
        /// <param name="dtStr">日期（yyyyMMdd）</param>
        /// <param name="direct">方向标记（DIRECT）</param>
        /// <returns></returns>
        private string GenOrderNO(string dtStr, string direct)
        {
            string orderNO = null;
            string preStr = "";
            if (DIRECT.REFUND2SUPPLIER == direct)
                preStr = ORDERNO_PREF.SIN_REFUND;
            else if (DIRECT.RESELLER_REFUND == direct)
                preStr = ORDERNO_PREF.SOUT_REFUND;
            else
                return orderNO;
            string sql = "SELECT MAX(OrderNO) FROM ORDERS WHERE OrderNO LIKE @today";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("today", preStr + dtStr + "%");
            orderNO = Connector.ScalarStr(sql, values);
            if (null == orderNO)
                orderNO = preStr + dtStr + "00001";
            else
            {
                long no = long.Parse(orderNO.Replace(preStr, ""));
                orderNO = preStr + (no + 1);
            }
            return orderNO;
        }

        private void AddChld(long invId, string usrId, int num, string direct)
        {
            string sql = "INSERT INTO INVENTORY_CHLD(InvID,OrderNO,GID,BefNum,Num,OprtDirect,OprtUsrId)"
                       + "SELECT InvID,OrderNO,GID,Num,@oprtNum,@direct,@oprtUId "
                       + "FROM INVENTORY WHERE InvID=@InvID";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("oprtNum", num);
            values.Add("direct", direct);
            values.Add("oprtUId", usrId);
            values.Add("InvID", invId);
            Connector.DbHelper.ExecuteSql(sql, values);
        }
    }
}
