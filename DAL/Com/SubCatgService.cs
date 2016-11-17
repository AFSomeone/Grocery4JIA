using Model.Const;
using Model.Entity;
using Model.VO;
using System.Collections.Generic;

namespace DAL.Com
{
    public class SubCatgService : BaseService
    {
        public List<SubCatgVO> LoadData(bool withInvalid, PageVO page)
        {
            string sql = "SELECT sub.CID,"
                       + "sub.CNAME,"
                       + "sub.PinYin,"
                       + "sub.Abbr,"
                       + "sub.ST,"
                       + "sub.SuperID,"
                       + "catg.CName AS SuperName "
                       + "FROM SUB_CATEGORY sub, CATEGORY catg "
                       + "WHERE sub.SuperID = catg.CID ";
            Dictionary<string, object> values = null;
            if (!withInvalid)
            {
                sql += "AND sub.ST=@ST ";
                values = new Dictionary<string, object>();
                values.Add("ST", ST.VALID);
            }
            sql += "ORDER BY sub.CID";

            if(null == page)
                return Connector.LoadModels<SubCatgVO>(sql, values);
            else
                return Connector.LoadModelsByPage<SubCatgVO>(sql, values, page);
        }

        public int Update(SubCategory catg)
        {
            if (null == catg)
                return 0;
            return Connector.Update<SubCategory>(catg);
        }

        public int Save(SubCategory catg)
        {
            if (null == catg)
                return 0;
            return Connector.Save<SubCategory>(catg, true);
        }

        public int GenCatgCount(string cname)
        {
            if (null == cname || cname == string.Empty)
                return 0;
            string sql = "SELECT COUNT(1) FROM SUB_CATEGORY WHERE CNAME=@NAME";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("NAME", cname.Trim());
            return Connector.ScalarInt(sql, values);
        }
    }
}
