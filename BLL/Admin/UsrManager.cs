using DAL.Admin;
using Model.Const;
using Model.Entity;

namespace BLL.Admin
{
    public class UsrManager
    {
        private UsrService service;

        public UsrManager()
        {
            service = new UsrService();
        }

        public Usr login(Usr usr, out string responseTxt)
        {
            responseTxt = string.Empty;
            Usr loginUsr = null;
            if (null == usr)
            {
                responseTxt = "请输入登录信息";
            }
            else if (usr.UId__PK == string.Empty || usr.Pwd == string.Empty)
            {
                responseTxt = "请输入登录名/密码";
            }
            else
            {
                loginUsr = service.loadUsr(usr.UId__PK, usr.Pwd);
                if (null == loginUsr)
                    responseTxt = "登录名或密码错误";
                else if (loginUsr.St == ST.INVALID)
                {
                    responseTxt = "账户已被冻结";
                    loginUsr = null;
                }  
            }
            return loginUsr;
        }
    }
}
