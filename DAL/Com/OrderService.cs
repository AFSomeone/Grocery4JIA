using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;

namespace DAL.Com
{
    public class OrderService : BaseService
    {
        /// <summary>
        /// 加载入库单信息
        /// </summary>
        /// <param name="order"></param>
        /// <returns>入库单列表</returns>
        public List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt)
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
            Dictionary<string, object> values = new Dictionary<string, object>(); ;
            if (!StringUtil.isEmpty(order.Direct))
            {
                sql += "AND od.Direct=@Direct ";
                values.Add("Direct", order.Direct);
            }
            if (!StringUtil.isEmpty(order.OrderNO))
            {
                sql += "AND od.OrderNO LIKE @OrderNO ";
                values.Add("OrderNO", "%" + order.OrderNO + "%");

            }
            if (order.CustID != 0)
            {
                sql += "AND od.CustID=@CustID ";
                values.Add("CustID", order.CustID);
            }
            if (null != startDt && null == endDt)
                endDt = ((DateTime)startDt).AddMonths(1);
            else if (null == startDt && null != endDt)
                startDt = ((DateTime)endDt).AddMonths(-1);
            else if (null == startDt && null == endDt)
            {
                endDt = DateTime.Parse(DateTime.Now.ToShortDateString());
                startDt = ((DateTime)endDt).AddMonths(-3);
            }
            endDt = ((DateTime)endDt).AddDays(1);
            sql += "AND od.CrtTmst>=@StDt AND od.CrtTmst<@EndDt ";
            values.Add("StDt", startDt);
            values.Add("EndDt", endDt);
            sql += "ORDER BY od.OrderNO DESC";
            return Connector.LoadModels<OrderVO>(sql, values);
        }
    }
}
