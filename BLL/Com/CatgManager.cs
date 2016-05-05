using DAL.Com;
using Model.Entity;
using System.Collections.Generic;

namespace BLL.Com
{
    public class CatgManager
    {
        private CatgService service;

        public CatgManager()
        {
            service = new CatgService();
        }

        public List<Category> LoadData(bool withInvalid)
        {
            return service.LoadData(withInvalid);
        }

        public int Update(Category catg)
        {
            return service.Update(catg);
        }

        public int Save(Category catg)
        {
            return service.Save(catg);
        }

        public int GenCatgCount(string cname)
        {
            return service.genCatgCount(cname);
        }

        public bool isValid(short cId)
        {
            int cnt = service.genValidCount(cId);
            if (cnt > 0)
                return true;
            return false;
        }
    }
}
