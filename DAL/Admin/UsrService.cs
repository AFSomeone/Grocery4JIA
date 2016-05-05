using Model.Entity;
using System.Collections.Generic;

namespace DAL.Admin
{
    public class UsrService : BaseService
    {
        public Usr loadUsr(string loginId, string pwd)
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
    }
}
