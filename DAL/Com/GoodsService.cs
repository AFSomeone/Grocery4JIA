using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System.Collections.Generic;

namespace DAL.Com
{
    public class GoodsService : BaseService
    {
        public List<GoodsVO> LoadData(Goods goods, int? supplierId)
        {
            string sql = "SELECT g.GID,"
                       + "g.GName,"
                       + "g.Abbr,"
                       + "g.Specs,"
                       + "g.SubCatgID,"
                       + "g.ShelfLife,"
                       + " g.Remark,"
                       + " g.ST,"
                       + "catg.CName as CatgName "
                       + "FROM GOODS g,SUB_CATEGORY catg ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            if (null != supplierId)
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
            if (0 != goods.GID__PK)
            {
                sql += "AND g.GID LIKE @GID ";
                values.Add("GID", "%"+goods.GID__PK+"%");
            }
            if (!StringUtil.isEmpty(goods.GName))
            {
                sql += "AND(g.GName LIKE @GName OR g.Abbr LIKE @GName) ";
                values.Add("GName", "%" + goods.GName + "%");
            }
            if (0 != goods.SubCatgID)
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
            return Connector.LoadModels<GoodsVO>(sql, values);
        }

        public List<Goods> LoadDataByKeyWords(string term, int? supplierId)
        {
            string sql = "SELECT * FROM GOODS g ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            if (null != supplierId)
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
            return Connector.LoadModels<Goods>(sql, values);
        }

        public List<InStockGoodsVO> LoadInStockGoodsByKeyWords(string term, int? supplierId)
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
            if (null != supplierId)
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
            return Connector.LoadModels<InStockGoodsVO>(sql, values);
        }

        public int Update(Goods goods)
        {
            return Connector.Update<Goods>(goods);
        }

        public int Save(Goods goods)
        {
            return Connector.Save<Goods>(goods,true);
        }
    }
}
