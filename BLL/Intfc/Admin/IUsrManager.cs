using Model.Entity;
using System.Collections.Generic;

namespace BLL.Admin
{
    public interface IUsrManager : IBaseManager
    {
        Usr Login(Usr usr);

        List<Usr> LoadUsrs();

        List<Usr> LoadUsrs(Usr usr);

        int AddUsr(Usr usr);

        int Update(Usr usr);

        int LoadUsrCnt(string uId);
    }
}
