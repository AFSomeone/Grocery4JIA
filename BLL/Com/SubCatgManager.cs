using DAL.Com;
using Model.Entity;
using Model.VO;
using System.Collections.Generic;

namespace BLL.Com
{
    public class SubCatgManager
    {
        SubCatgService service;
        public SubCatgManager()
        {
            service = new SubCatgService();
        }

        public List<SubCatgVO> LoadData(bool withInvalid)
        {
            return service.LoadData(withInvalid);
        }

        public int Update(SubCategory catg)
        {
            return service.Update(catg);
        }

        public int Save(SubCategory catg)
        {
            return service.Save(catg);
        }

        public int GenCatgCount(string cname)
        {
            return service.GenCatgCount(cname);
        }
    }
}
