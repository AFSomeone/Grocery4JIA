using Model.Const;
using Model.Entity;
using Model.Util;
using System;
using System.Collections.Generic;

namespace DAL.Admin
{
    public class AuthService : BaseService
    {
        public bool GenUsrAuth(string uId, string funcId)
        {
            string sql = "SELECT COUNT(1) FROM USR_AUTH WHERE UID=@uId AND FuncID=@fnId AND ST=@st";
            Dictionary<string, object> valeus = new Dictionary<string, object>();
            valeus.Add("uId", uId);
            valeus.Add("fnId", funcId);
            valeus.Add("st", ST.VALID);
            int cnt = Connector.ScalarInt(sql, valeus);
            if (cnt>0)
                return true ;
            else
                return false;
        }

        public List<UsrAuth> LoadUsrAuth(string uId)
        {
            string sql = "SELECT * FROM USR_AUTH WHERE UID=@uId AND ST=@st";
            Dictionary<string, object> valeus = new Dictionary<string, object>();
            valeus.Add("uId", uId);
            valeus.Add("st", ST.VALID);
            return Connector.LoadModels<UsrAuth>(sql, valeus);
        }

        public int SetAuth(List<UsrAuth> authList)
        {
            int cnt = 0;
            foreach (UsrAuth auth in authList)
            {
                int rslt = Connector.Update<UsrAuth>(auth);
                if (rslt < 1)
                    cnt += Connector.Save<UsrAuth>(auth);
                else
                    cnt += rslt;
            }
            return cnt;
        }
    }
}
