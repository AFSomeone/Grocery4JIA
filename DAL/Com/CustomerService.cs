using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System.Collections.Generic;

namespace DAL.Com
{
    public class CustomerService : BaseService
    {
        public List<Customer> LoadData(Customer cust, PageVO page)
        {
            string sql = "SELECT * FROM CUSTOMERS cs WHERE 1=1 ";
            Dictionary<string, object> values = null;
            if (!StringUtil.isEmpty(cust.CName))
            {
                if (null == values)
                    values = new Dictionary<string, object>();
                sql += "AND cs.CName LIKE @CName ";
                values.Add("CName", "%"+cust.CName+"%");
            }
            if (!StringUtil.isEmpty(cust.LinkMan))
            {
                if (null == values)
                    values = new Dictionary<string, object>();
                sql += "AND cs.LinkMan LIKE @LinkMan ";
                values.Add("LinkMan", "%" + cust.LinkMan + "%");
            }
            if (!StringUtil.isEmpty(cust.St))
            {
                if (null == values)
                    values = new Dictionary<string, object>();
                sql += "AND cs.ST=@ST ";
                values.Add("ST", cust.St);
            }
            if (!StringUtil.isEmpty(cust.Grade))
            {
                if (null == values)
                    values = new Dictionary<string, object>();
                sql += "AND cs.Grade=@GRADE ";
                values.Add("GRADE", cust.Grade);
            }
            sql += "ORDER BY cs.CID";

            if(null == page)
                return Connector.LoadModels<Customer>(sql, values);
            else
                return Connector.LoadModelsByPage <Customer>(sql, values, page);
        }

        public int Save(Customer cust)
        {
            return Connector.Save<Customer>(cust, true);
        }

        public int Update(Customer cust)
        {
            return Connector.Update<Customer>(cust);
        }

        public int AddGoods(List<SupplyInfo> list)
        {
            int cnt = 0;
            if (null == list || list.Count == 0)
                return cnt;
            string sql = "UPDATE SUPPLY_INFO SET ST=@ST WHERE CustID=@CustID AND GID=@GID";
            Dictionary<string, object> values = new Dictionary<string, object>();
            foreach (SupplyInfo sinfo in list)
            {
                values.Clear();
                values.Add("ST", ST.VALID);
                values.Add("CustID", sinfo.CustID);
                values.Add("GID", sinfo.GID);
                int uptCnt = Connector.DbHelper.ExecuteSql(sql, values);
                if (uptCnt < 1)
                    cnt += Connector.Save<SupplyInfo>(sinfo, true);
                else
                    cnt += uptCnt;
            }
            return cnt;
        }

        public List<GoodsVO> LoadSupplyGoods(int custId, PageVO page)
        {
            string sql = "SELECT g.GID,"
                       + "g.GName,"
                       + "g.Specs,"
                       + "g.ShelfLife,"
                       + "g.Remark,"
                       + "scatg.CName as CatgName "
                       + "FROM SUPPLY_INFO info,"
                       + "GOODS g,"
                       + "SUB_CATEGORY scatg "
                       + "WHERE info.GID = g.GID "
                       + "AND g.SubCatgID = scatg.CID "
                       + "AND info.CustID = @CustId "
                       + "AND info.ST=@ST "
                       + "ORDER BY g.GID";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("CustId", custId);
            values.Add("ST", ST.VALID);
            if(null == page)
                return Connector.LoadModels<GoodsVO>(sql,values);
            else
                return Connector.LoadModelsByPage<GoodsVO>(sql, values, page);
        }

        public List<GoodsVO> LoadNotSupplyGoods(Goods goods, int supplierId, PageVO page)
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
                       + "FROM GOODS g,SUB_CATEGORY catg "
                       + "WHERE g.SubCatgID=catg.CID "
                       + "AND g.ST=@g_st "
                       + "AND g.GID NOT IN(SELECT GID FROM SUPPLY_INFO WHERE ST=@sinfo_st AND CustID=@custID) ";

            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("g_st", ST.VALID);
            values.Add("sinfo_st", ST.VALID);
            values.Add("custID", supplierId);
           
            if (null != goods.GID__PK && goods.GID__PK != 0)
            {
                sql += "AND g.GID LIKE @GID ";
                values.Add("GID", "%" + goods.GID__PK + "%");
            }
            if (!StringUtil.isEmpty(goods.GName))
            {
                sql += "AND(g.GName LIKE @GName OR g.Abbr LIKE @GName) ";
                values.Add("GName", "%" + goods.GName + "%");
            }
            if (null != goods.SubCatgID && goods.SubCatgID != 0)
            {
                sql += "AND g.SubCatgID=@SID ";
                values.Add("SID", goods.SubCatgID);
            }
            sql += "ORDER BY g.GID";

            if (null == page)
                return Connector.LoadModels<GoodsVO>(sql, values);
            else
                return Connector.LoadModelsByPage<GoodsVO>(sql, values, page);
        }

        public int DeleteSupplyGoods(int custId, int gId)
        {
            string sql = "UPDATE SUPPLY_INFO SET ST=@ST WHERE CustID=@CustID AND GID=@GID";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("ST", ST.INVALID);
            values.Add("CustID", custId);
            values.Add("GID", gId);
            return Connector.DbHelper.ExecuteSql(sql, values);
        }

        public List<CustAcnt> LoadCustAcnt(int custId, bool withInvalid)
        {
            string sql = "SELECT ID,"
                       + "AcntNO,"
                       + "AcntType,"
                       + "CustID,"
                       + "Platform,"
                       + "ST "
                       + "FROM CUST_ACNT "
                       + "WHERE CustID=@custId ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("custId", custId);
            if (!withInvalid)
            {
                sql += "AND ST=@St ";
                values.Add("St", ST.VALID);
            }
            sql += "ORDER BY AcntType,Platform,AcntNO";
            return Connector.LoadModels<CustAcnt>(sql, values);
        }

        public int AddCustAcnt(CustAcnt acnt)
        {
            return Connector.Save<CustAcnt>(acnt);
        }

        public int UpdateAcnt(CustAcnt acnt)
        {
            return Connector.Update<CustAcnt>(acnt);
        }
    }
}
