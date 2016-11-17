using BLL.Com;
using DAL.Com;
using Model.Entity;
using System.Collections.Generic;

namespace BLL.Proxy
{
    class CatgManager : BaseManager, ICatgManager
    {
        private CatgService service;

        public CatgManager(int connectorId)
        {
            service = base.CreateService(typeof(CatgService), connectorId) as CatgService;
        }

        public List<Category> LoadData(bool withInvalid)
        {
            return service.LoadData(withInvalid);
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public int Update(Category catg)
        {
            return service.Update(catg);
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
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
