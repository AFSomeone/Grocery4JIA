
using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;

namespace DAL.Com
{
    public class StockOutService : BaseService
    {
        public string StockOut(StockOutOrderVO vo)
        {
            string orderNO = string.Empty;
            DateTime now = DateTime.Now;
            if (null == vo)
                return orderNO;
            try
            {
                Connector.DbHelper.BeginTransaction();
                decimal amount = 0;
                string uptSql = "UPDATE INVENTORY SET Num=Num-@outNum,Tmst=@tmst WHERE InvID=@invID";
                orderNO = GenOrderNO(string.Format("{0:yyyyMMdd}", now));
                foreach (StockOut sout in vo._StockOutList)
                {
                    sout.OrderNO = orderNO;
                    amount += sout.Price * sout.Num;
                    Connector.Save<StockOut>(sout, true);
                    //记录流水
                    AddChld(sout.InvID, vo.CrtUID, sout.Num);
                    Dictionary<string, object> values = new Dictionary<string, object>();
                    values.Add("outNum", sout.Num);
                    values.Add("tmst", now);
                    values.Add("invID", sout.InvID);
                    Connector.DbHelper.ExecuteSql(uptSql, values);
                }

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

        public List<StockOutOrderDetailVO> LoadOrderDetail(string orderNO)
        {
            string sql = "SELECT s.SID,"
                        + "S.OrderNO,"
                        + "S.InvID,"
                        + "S.Num,"
                        + "S.Price,"
                        + "inv.OrderNO as SinOrderNO,"
                        + "g.GID,"
                        + "g.GName,"
                        + "g.Specs "
                        + "FROM STOCKOUT s,INVENTORY inv, GOODS g "
                        + "WHERE s.InvID=inv.InvID "
                        + "AND inv.GID=g.GID "
                        + "AND s.OrderNO=@OrderNO "
                        + "ORDER BY s.SID";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("OrderNO", orderNO);
            return Connector.LoadModels<StockOutOrderDetailVO>(sql, values);
        }

        private string GenOrderNO(string dtStr)
        {
            string orderNO = null;
            string sql = "SELECT MAX(OrderNO) FROM ORDERS WHERE OrderNO LIKE @today";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("today", ORDERNO_PREF.STOCK_OUT + dtStr + "%");
            orderNO = Connector.ScalarStr(sql, values);
            if (null == orderNO)
                orderNO = ORDERNO_PREF.STOCK_OUT + dtStr + "00001";
            else
            {
                long no = long.Parse(orderNO.Replace(ORDERNO_PREF.STOCK_OUT, ""));
                orderNO = ORDERNO_PREF.STOCK_OUT + (no + 1);
            }
            return orderNO;
        }

        private void AddChld(long invId, string usrId, int num)
        {
            string sql = "INSERT INTO INVENTORY_CHLD(InvID,OrderNO,GID,BefNum,Num,OprtDirect,OprtUsrId)"
                       + "SELECT InvID,OrderNO,GID,Num,@oprtNum,@direct,@oprtUId "
                       + "FROM INVENTORY WHERE InvID=@InvID";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("oprtNum", num);
            values.Add("direct", DIRECT.STOCK_OUT);
            values.Add("oprtUId", usrId);
            values.Add("InvID", invId);
            Connector.DbHelper.ExecuteSql(sql, values);
        }
    }
}
