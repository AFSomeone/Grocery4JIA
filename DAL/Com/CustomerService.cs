using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System.Collections.Generic;

namespace DAL.Com
{
    public class CustomerService : BaseService
    {
        public List<Customer> LoadData(Customer cust)
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

            return Connector.LoadModels<Customer>(sql, values);
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
            try
            {
                Connector.DbHelper.BeginTransaction();
                string sql = "UPDATE SUPPLY_INFO SET ST=@ST WHERE CustID=@CustID AND GID=@GID";
                Dictionary<string, object> values = new Dictionary<string, object>();
                foreach (SupplyInfo sinfo in list)
                {
                    values.Clear();
                    values.Add("ST",ST.VALID);
                    values.Add("CustID", sinfo.CustID);
                    values.Add("GID", sinfo.GID);
                    int uptCnt = Connector.DbHelper.ExecuteSql(sql, values);
                    if (uptCnt < 1)
                        cnt += Connector.Save<SupplyInfo>(sinfo, true);
                    else
                        cnt += uptCnt;
                }
                Connector.DbHelper.CommitTransaction();
            }
            catch
            {
                Connector.DbHelper.RollbackTransaction();
                cnt = 0;
            }
            return cnt;
        }

        public List<GoodsVO> LoadSupplyGoods(int custId)
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
                       + "AND info.ST=@ST ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("CustId", custId);
            values.Add("ST", ST.VALID);
            return Connector.LoadModels<GoodsVO>(sql,values);
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
    }
}
