using Model.Const;
using Model.Entity;
using System.Collections.Generic;

namespace DAL.Com
{
    public class CatgService : BaseService
    {
        public List<Category> LoadData(bool withInvalid)
        {
            string sql = "SELECT CID,CNAME,ST FROM CATEGORY ";
            Dictionary<string, object> values = null;
            if (!withInvalid)
            {
                sql += "WHERE ST=@ST ";
                values = new Dictionary<string, object>();
                values.Add("ST", ST.VALID);
            }
            sql += "ORDER BY CID";
            return Connector.LoadModels<Category>(sql, values);
        }

        public int Update(Category catg)
        {
            if (null == catg)
                return 0;
            return Connector.Update<Category>(catg);
        }

        public int Save(Category catg)
        {
            if (null == catg)
                return 0;
            return Connector.Save<Category>(catg, true);
        }

        public int genCatgCount(string cname)
        {
            int cnt = 0;
            if (null == cname || cname == string.Empty)
                return cnt;
            string sql = "SELECT COUNT(1) FROM CATEGORY WHERE CNAME=@NAME";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("NAME", cname.Trim());
            cnt = Connector.ScalarInt(sql, values);
            return cnt;

        }

        public int genValidCount(short cId)
        {
            string sql = "SELECT COUNT(1) FROM CATEGORY WHERE CID=@CID AND ST=@ST";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("CID", cId);
            values.Add("ST", ST.VALID);
            return Connector.ScalarInt(sql, values);

        }
    }
}
