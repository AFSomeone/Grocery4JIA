using Model.Entity;
using Model.VO;
using System.Collections.Generic;

namespace BLL.Com
{
    public interface ISubCatgManager : IBaseManager
    {
        List<SubCatgVO> LoadData(bool withInvalid, PageVO page);

        int Update(SubCategory catg);

        int Save(SubCategory catg);

        int GenCatgCount(string cname);
    }
}
