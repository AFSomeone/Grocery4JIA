using Model.Const;
using Model.Entity;
using Model.VO;
using System;
using System.Collections.Generic;

namespace DAL.Com
{
    public class RefundService : BaseService
    {
        public List<RefundOrderDetailVO> LoadOrderDetail(string orderNO, string direct, PageVO page)
        {
            string sql = null;
            if (DIRECT.REFUND2SUPPLIER == direct)
            {
                sql = "SELECT r.RID,"
                    + "r.OrderNO,"
                    + "r.InvID,"
                    + "r.Num,"
                    + "r.Price,"
                    + "r.Direct,"
                    + "inv.OrderNO as TgtOrderNO,"
                    + "g.GID,"
                    + "g.GName,"
                    + "g.Specs "
                    + "FROM REFUNDS r,INVENTORY inv, GOODS g "
                    + "WHERE r.InvID=inv.InvID "
                    + "AND inv.GID=g.GID "
                    + "AND r.OrderNO=@OrderNO "
                    + "ORDER BY r.RID";
            }
            else if (DIRECT.RESELLER_REFUND == direct)
            {
                sql = "SELECT r.RID,"
                    + "r.OrderNO,"
                    + "r.InvID,"
                    + "r.Num,"
                    + "r.Price,"
                    + "r.Direct,"
                    + "s.OrderNO as TgtOrderNO,"
                    + "g.GID,"
                    + "g.GName,"
                    + "g.Specs "
                    + "FROM REFUNDS r,STOCKOUT s, INVENTORY inv, GOODS g "
                    + "WHERE r.TgtSID=s.SID "
                    + "AND s.InvID=inv.InvID "
                    + "AND inv.GID=g.GID "
                    + "AND r.OrderNO=@OrderNO "
                    + "ORDER BY r.RID";
            }
            else
                return null;
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("OrderNO", orderNO);

            if (null == page)
                return Connector.LoadModels<RefundOrderDetailVO>(sql, values);
            else
                return Connector.LoadModelsByPage<RefundOrderDetailVO>(sql, values, page);
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

            decimal amount = 0;
            int direct = 0;
            string uptInvSql = "UPDATE INVENTORY SET Num=Num-@rfNum,Tmst=@tmst WHERE InvID=@invID";
            string uptSOutSql = null;
            if (DIRECT.REFUND2SUPPLIER == refundVO.Direct)
                direct = 1;
            else if (DIRECT.RESELLER_REFUND == refundVO.Direct)
            {
                uptSOutSql = "UPDATE STOCKOUT SET RfNum=RfNum+@num WHERE SID=@sId";
                direct = -1;
            }
            else
                return orderNO;
            orderNO = GenOrderNO(string.Format("{0:yyyyMMdd}", now), refundVO.Direct);
            foreach (Refund rf in refundVO._RefundList)
            {
                rf.OrderNO = orderNO;
                amount += (decimal)rf.Price * (int)rf.Num;
                Connector.Save<Refund>(rf, true);
                //记录流水
                AddChld((long)rf.InvID, refundVO.CrtUID, (int)rf.Num, refundVO.Direct);
                Dictionary<string, object> values = new Dictionary<string, object>();
                values.Add("rfNum", rf.Num * direct);
                values.Add("tmst", now);
                values.Add("invID", rf.InvID);
                Connector.DbHelper.ExecuteSql(uptInvSql, values);
                //回收
                if (DIRECT.RESELLER_REFUND == refundVO.Direct)
                {
                    values = new Dictionary<string, object>();
                    values.Add("num", rf.Num);
                    values.Add("sId", rf.TgtSID);
                    Connector.DbHelper.ExecuteSql(uptSOutSql, values);
                }
            }

            Order order = new Order();
            order.CustID = refundVO.CustID;
            order.CustName = refundVO.CustName;
            order.Direct = refundVO.Direct;
            order.UptUID = refundVO.UptUID;
            order.CrtUID = refundVO.CrtUID;
            order.CrtTmst = now;
            order.UptTmst = now;
            order.OrderNO__PK = orderNO;
            order.Amount = amount;
            Connector.Save<Order>(order);
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
                orderNO = preStr + dtStr + "001";
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
