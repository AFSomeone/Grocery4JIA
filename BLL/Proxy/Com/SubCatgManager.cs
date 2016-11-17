using BLL.Com;
using DAL.Com;
using Model.Entity;
using Model.VO;
using System.Collections.Generic;

namespace BLL.Proxy
{
    class SubCatgManager : BaseManager, ISubCatgManager
    {
        SubCatgService service;
        public SubCatgManager(int connectorId)
        {
            service = base.CreateService(typeof(SubCatgService), connectorId) as SubCatgService;
        }

        public List<SubCatgVO> LoadData(bool withInvalid, PageVO page)
        {
            return service.LoadData(withInvalid, page);
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public int Update(SubCategory catg)
        {
            return service.Update(catg);
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
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
