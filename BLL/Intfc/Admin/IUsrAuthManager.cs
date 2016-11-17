using Model.Entity;
using System.Collections.Generic;

namespace BLL.Admin
{
    public interface IUsrAuthManager : IBaseManager
    {
        List<UsrAuth> LoadUsrAuth(string uId);

        int SetAuth(List<UsrAuth> authList);
    }
}