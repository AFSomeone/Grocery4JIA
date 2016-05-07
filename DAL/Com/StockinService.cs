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
        public string Stockin(StockInOrderVO vo)
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
        /// 加载入库单明细
        /// </summary>
        /// <param name="orderNO"></param>
        /// <returns></returns>
        public List<StockInOrderDetailVO> LoadOrderDetail(string orderNO)
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
            return Connector.LoadModels<StockInOrderDetailVO>(sql,values);
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
