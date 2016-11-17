using Model.Const;
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
        public List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt, PageVO page)
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
                       + "od.Handled,"
                       + "binfo.BillNO,"
                       + "u1.UName as crtUName,"
                       + "u2.UName as uptUName "
                       + "FROM ORDERS od "
                       + "LEFT JOIN BILLING_INFO binfo ON(od.OrderNO=binfo.OrderNO) "
                       + "JOIN USR u1 ON(od.CrtUID=u1.UID) "
                       + "JOIN USR u2  ON(od.UptUID=u2.UID) ";
            Dictionary<string, object> values = new Dictionary<string, object>();
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
            sql += "WHERE od.CrtTmst>=@StDt AND od.CrtTmst<@EndDt ";
            values.Add("StDt", startDt);
            values.Add("EndDt", endDt);
            if (!StringUtil.isEmpty(order.Handled))
            {
                sql += "AND od.Handled=@handled ";
                values.Add("handled", order.Handled);
            }
            if (!StringUtil.isEmpty(order.Direct))
            {
                sql += "AND od.Direct=@Direct ";
                values.Add("Direct", order.Direct);
            }
            if (!StringUtil.isEmpty(order.OrderNO__PK))
            {
                sql += "AND od.OrderNO LIKE @OrderNO ";
                values.Add("OrderNO", "%" + order.OrderNO__PK + "%");

            }
            if (null != order.CustID && order.CustID != 0)
            {
                sql += "AND od.CustID=@CustID ";
                values.Add("CustID", order.CustID);
            }
            sql += "ORDER BY od.Handled,od.OrderNO DESC";

            if(null == page)
                return Connector.LoadModels<OrderVO>(sql, values);
            else
                return Connector.LoadModelsByPage<OrderVO>(sql, values, page);
        }

        public List<OrderGoodsVO> LoadSupplierOrderGoods(int custId, List<string> orderNOList, PageVO page)
        {
            string sinSql = "SELECT g.GID,"
                       + "g.GName,"
                       + "g.Specs,"
                       + "s.Num,"
                       + "s.Price,"
                       + "s.OrderNO,"
                       + "od.Direct,"
                       + "od.CrtTmst as Tmst "
                       + "FROM STOCKIN s, GOODS g, ORDERS od "
                       + "WHERE s.GID = g.GID "
                       + "AND s.OrderNO = od.OrderNO "
                       + "AND od.CustID = @custId "
                       + "AND od.Direct = @sinDirect "
                       + "AND od.OrderNO IN(@sinOrderNOs)";

            string rfSql = "SELECT g.GID,"
                       + "g.GName,"
                       + "g.Specs,"
                       + "r.Num,"
                       + "r.Price,"
                       + "r.OrderNO,"
                       + "od.Direct,"
                       + "od.CrtTmst as Tmst "
                       + "FROM REFUNDS r, INVENTORY inv, GOODS g, ORDERS od "
                       + "WHERE r.InvID = inv.InvID "
                       + "AND inv.GID = g.GID "
                       + "AND r.OrderNO = od.OrderNO "
                       + "AND od.CustID = @custId "
                       + "AND od.Direct = @rfDirect "
                       + "AND od.OrderNO IN(@rfOrderNOs)";

            string sinOrderNOs = "", rfOrderNOs="";
            Dictionary<string, object> values = new Dictionary<string, object>();
            foreach (string orderNO in orderNOList)
            {
                if (orderNO.StartsWith(ORDERNO_PREF.STOCK_IN))
                    sinOrderNOs += "," + orderNO + "";
                else if (orderNO.StartsWith(ORDERNO_PREF.SIN_REFUND))
                    rfOrderNOs += "," + orderNO + "";
                else
                    return null;
            }
            string sql = string.Empty;
            if (sinOrderNOs.Length > 0)
            {
                sinOrderNOs = sinOrderNOs.Substring(1);
                sql = sinSql;
                values.Add("custId", custId);
                values.Add("sinOrderNOs", sinOrderNOs);
                values.Add("sinDirect", DIRECT.STOCK_IN);
            }
            if (rfOrderNOs.Length > 0)
            {
                rfOrderNOs = rfOrderNOs.Substring(1);
                if (sql.Length > 0)
                    sql += "UNION ALL ";
                else
                    values.Add("custId", custId);
                sql += rfSql;
                values.Add("rfOrderNOs", rfOrderNOs);
                values.Add("rfDirect", DIRECT.REFUND2SUPPLIER);
            }

            if (sql.Length > 0)
            {
                if(null == page)
                    return Connector.LoadModels<OrderGoodsVO>(sql, values);
                else
                    return Connector.LoadModelsByPage<OrderGoodsVO>(sql, values, page);
            }
            else
                return null; 
        }

        public List<OrderGoodsVO> LoadResellerOrderGoods(int custId, List<string> orderNOList, PageVO page)
        {
            string outSql = "SELECT g.GID,"
                       + "g.GName,"
                       + "g.Specs,"
                       + "s.Num,"
                       + "s.Price,"
                       + "s.OrderNO,"
                       + "od.Direct,"
                       + "od.CrtTmst as Tmst "
                       + "FROM STOCKOUT s,INVENTORY inv, GOODS g, ORDERS od "
                       + "WHERE s.InvID=inv.InvID "
                       + "AND inv.GID = g.GID "
                       + "AND s.OrderNO = od.OrderNO "
                       + "AND od.CustID = @custId "
                       + "AND od.Direct = @outDirect "
                       + "AND od.OrderNO IN(@outOrderNOs)";

            string rfSql = "SELECT g.GID,"
                       + "g.GName,"
                       + "g.Specs,"
                       + "r.Num,"
                       + "r.Price,"
                       + "r.OrderNO,"
                       + "od.Direct,"
                       + "od.CrtTmst as Tmst "
                       + "FROM REFUNDS r, INVENTORY inv, GOODS g, ORDERS od "
                       + "WHERE r.InvID = inv.InvID "
                       + "AND inv.GID = g.GID "
                       + "AND r.OrderNO = od.OrderNO "
                       + "AND od.CustID = @custId "
                       + "AND od.Direct = @rfDirect "
                       + "AND od.OrderNO IN(@rfOrderNOs)";

            string outOrderNOs = "", rfOrderNOs = "";
            Dictionary<string, object> values = new Dictionary<string, object>();
            foreach (string orderNO in orderNOList)
            {
                if (orderNO.StartsWith(ORDERNO_PREF.STOCK_OUT))
                    outOrderNOs += "," + orderNO + "";
                else if (orderNO.StartsWith(ORDERNO_PREF.SOUT_REFUND))
                    rfOrderNOs += "," + orderNO + "";
                else
                    return null;
            }
            string sql = string.Empty;
            if (outOrderNOs.Length > 0)
            {
                outOrderNOs = outOrderNOs.Substring(1);
                sql = outSql;
                values.Add("custId", custId);
                values.Add("outDirect", DIRECT.STOCK_OUT);
                values.Add("outOrderNOs", outOrderNOs);
            }
            if (rfOrderNOs.Length > 0)
            {
                rfOrderNOs = rfOrderNOs.Substring(1);
                if (sql.Length > 0)
                    sql += "UNION ALL ";
                else
                    values.Add("custId", custId);
                sql += rfSql;
                values.Add("rfOrderNOs", rfOrderNOs);
                values.Add("rfDirect", DIRECT.RESELLER_REFUND);
            }

            if (sql.Length > 0)
            {
                if(null == page)
                    return Connector.LoadModels<OrderGoodsVO>(sql, values);
                else
                    return Connector.LoadModelsByPage<OrderGoodsVO>(sql, values, page);
            }                
            else
                return null;
        }
    }
}
