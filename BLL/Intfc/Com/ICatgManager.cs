using Model.Entity;
using System.Collections.Generic;

namespace BLL.Com
{
    public interface ICatgManager : IBaseManager
    {
        List<Category> LoadData(bool withInvalid);

        int Update(Category catg);

        int Save(Category catg);

        int GenCatgCount(string cname);

        bool isValid(short cId);
    }
}
