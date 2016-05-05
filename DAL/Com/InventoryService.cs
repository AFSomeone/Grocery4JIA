using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System.Collections.Generic;

namespace DAL.Com
{
    public class InventoryService : BaseService
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
                       + "AND inv.Num>0 ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("direct", DIRECT.STOCK_IN);
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
    }
}
