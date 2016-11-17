using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System.Collections.Generic;

namespace DAL.Com
{
    public class GoodsService : BaseService
    {
        public List<GoodsVO> LoadData(Goods goods, int? supplierId, PageVO page)
        {
            string sql = "SELECT g.GID,"
                       + "g.GName,"
                       + "g.Abbr,"
                       + "g.Specs,"
                       + "g.SubCatgID,"
                       + "g.ShelfLife,"
                       + "g.Remark,"
                       + "g.ST,"
                       + "catg.CName as CatgName "
                       + "FROM GOODS g,SUB_CATEGORY catg ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            if (null != supplierId && supplierId != 0)
            {
                sql += ",SUPPLY_INFO sinfo "
                      +"WHERE g.SubCatgID=catg.CID "
                      +"AND g.GID=sinfo.GID "
                      +"AND sinfo.ST=@sinfo_ST "
                      +"AND sinfo.CustID=@CustID ";
                values.Add("sinfo_ST", ST.VALID);
                values.Add("CustID", supplierId);
            }
            else
            {
                sql += "WHERE g.SubCatgID=catg.CID ";
            }
            if (null != goods.GID__PK && goods.GID__PK !=0)
            {
                sql += "AND g.GID LIKE @GID ";
                values.Add("GID", "%"+goods.GID__PK+"%");
            }
            if (!StringUtil.isEmpty(goods.GName))
            {
                sql += "AND(g.GName LIKE @GName OR g.Abbr LIKE @GName) ";
                values.Add("GName", "%" + goods.GName + "%");
            }
            if (null != goods.SubCatgID && goods.SubCatgID !=0)
            {
                sql += "AND g.SubCatgID=@SID ";
                values.Add("SID", goods.SubCatgID);
            }
            if (!StringUtil.isEmpty(goods.St))
            {
                sql += "AND g.ST=@g_ST ";
                values.Add("g_ST", goods.St);
            }
            sql += "ORDER BY g.GID";

            if(null == page)
                return Connector.LoadModels<GoodsVO>(sql, values);
            else
                return Connector.LoadModelsByPage<GoodsVO>(sql, values, page);
        }

        public List<Goods> LoadDataByKeyWords(string term, int? supplierId)
        {
            string sql = "SELECT * FROM GOODS g ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            if (null != supplierId && supplierId !=0)
            {
                sql += ",SUPPLY_INFO sinfo "
                      +"WHERE g.GID=sinfo.GID "
                      +"AND sinfo.ST=@sinfo_ST "
                      +"AND sinfo.CustID=@CustID "
                      +"AND(g.GName LIKE @term OR g.Abbr LIKE @term OR g.GID LIKE @term )";
                values.Add("sinfo_ST", ST.VALID);
                values.Add("CustID", supplierId);
                values.Add("term", "%" + term + "%");
            }
            else
            {
                sql += "WHERE g.GName LIKE @term OR g.Abbr LIKE @term OR g.GID LIKE @term ";
                values.Add("term", "%" + term + "%");
            }
            sql += "ORDER BY g.GName ";

            PageVO page = new PageVO();
            page.PageNo = 1;
            page.PageSize = 30;
            return Connector.LoadModelsByPage<Goods>(sql, values, page);
        }

        public List<StockGoodsVO> LoadInStockGoodsByKeyWords(string term, int? supplierId)
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
                      + "AND inv.Num>0 ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("direct", DIRECT.STOCK_IN);
            if (null != supplierId && supplierId !=0)
            {
                sql += "AND odr.CustID=@custId ";
                values.Add("custId", supplierId);
            }
            if (!StringUtil.isEmpty(term))
            {
                sql += "AND (g.GName LIKE @term OR g.Abbr LIKE @term OR g.GID LIKE @term) ";
                values.Add("term", "%" + term + "%");
            }
            sql += "ORDER BY g.GName";

            PageVO page = new PageVO();
            page.PageNo = 1;
            page.PageSize = 30;
            return Connector.LoadModelsByPage<StockGoodsVO>(sql, values, page);
        }

        public List<StockGoodsVO> LoadSoldGoodsByKeyWords(string term, int? resellerId)
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
            if (null != resellerId && resellerId !=0)
            {
                sql += "AND odr.CustID=@custId ";
                values.Add("custId", resellerId);
            }
            if (!StringUtil.isEmpty(term))
            {
                sql += "AND (g.GName LIKE @term OR g.Abbr LIKE @term OR g.GID LIKE @term) ";
                values.Add("term", "%" + term + "%");
            }
            sql += "ORDER BY g.GName";

            PageVO page = new PageVO();
            page.PageNo = 1;
            page.PageSize = 30;
            return Connector.LoadModelsByPage<StockGoodsVO>(sql, values, page);
        }

        public int Update(Goods goods)
        {
            return Connector.Update<Goods>(goods);
        }

        public int Save(Goods goods)
        {
            if(null == goods.GID__PK)
                return Connector.Save<Goods>(goods,true);
            else
                return Connector.Save<Goods>(goods, false);
        }

        public int? GenGoodsId()
        {
            string sql = "select MAX(GID) from GOODS";
            int maxId = Connector.ScalarInt(sql, null);
            if (maxId == 0)
                return null;
            return maxId+1;
        }
    }
}
