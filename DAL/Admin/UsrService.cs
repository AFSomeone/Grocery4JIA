using Model.Const;
using Model.Entity;
using Model.Util;
using System.Collections.Generic;

namespace DAL.Admin
{
    public class UsrService : BaseService
    {
        public Usr LoadUsr(string loginId, string pwd)
        {
            Usr usr = null;
            if (loginId == string.Empty || pwd == string.Empty)
                return usr;
            string sql = "SELECT * FROM USR WHERE UID=@UID AND PWD=@PWD";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("UID",loginId);
            values.Add("PWD",pwd);
            List<Usr> usrs = Connector.LoadModels<Usr>(sql, values);
            if (null != usrs && usrs.Count > 0)
                usr = usrs[0];
            return usr;
        }

        public List<Usr> LoadUsrs(Usr usr)
        {
            string sql = "SELECT UID,UName,Tel,QQ,St,Remark FROM USR WHERE 1=1 ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            if (!StringUtil.isEmpty(usr.UId__PK))
            {
                sql += "AND UID LIKE @uId ";
                values.Add("uId", "%"+usr.UId__PK+"%");
            }
            if (!StringUtil.isEmpty(usr.UName))
            {
                sql += "AND UName LIKE @uName ";
                values.Add("uName", "%" + usr.UName + "%");
            }
            if (!StringUtil.isEmpty(usr.St))
            {
                sql += "AND ST=@St ";
                values.Add("St", usr.St);
            }
            sql += "ORDER BY UID";
            return Connector.LoadModels<Usr>(sql, values);
        }

        public int Save(Usr usr)
        {
            return Connector.Save<Usr>(usr);
        }

        public int Update(Usr usr)
        {
            if (null == usr || usr.UId__PK == null)
                return 0;
            return Connector.Update<Usr>(usr);
        }

        public int LoadUsrCnt(string uId)
        {
            string sql = "SELECT COUNT(1) FROM USR WHERE UID=@id";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("id",uId);
            return Connector.ScalarInt(sql,values);
        }
    }
}
