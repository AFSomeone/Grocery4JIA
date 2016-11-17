using BLL.Com;
using DAL.Com;
using Model.Entity;
using Model.VO;
using System.Collections.Generic;

namespace BLL.Proxy
{
    class CustomerManager : BaseManager, ICustomerManager
    {
        CustomerService service;
        public CustomerManager(int connectorId)
        {
            service = base.CreateService(typeof(CustomerService), connectorId) as CustomerService;
        }

        public List<Customer> LoadData(Customer cust, PageVO page)
        {
            if (null == cust)
                return null;
            return service.LoadData(cust, page);
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public int Save(Customer cust)
        {
            if (null == cust)
                return 0;
            return service.Save(cust);
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public int Update(Customer cust)
        {
            if (null == cust)
                return 0;
            return service.Update(cust);
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public int AddGoods(List<SupplyInfo> list)
        {
            if (null == list)
                return 0;
            return service.AddGoods(list);
        }

        public List<GoodsVO> LoadSupplyGoods(int custId, PageVO page)
        {
            if (0 == custId)
                return null;
            return service.LoadSupplyGoods(custId, page);
        }

        public List<GoodsVO> LoadNotSupplyGoods(Goods goods, int supplierId, PageVO page)
        {
            return service.LoadNotSupplyGoods(goods, supplierId, page);
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public int DeleteSupplyGoods(int custId, int gId)
        {
            if (0 == custId || 0 == gId)
                return 0;
            return service.DeleteSupplyGoods(custId, gId);
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public int AddCustAcnt(CustAcnt acnt)
        {
            if (null == acnt)
                return 0;
            return service.AddCustAcnt(acnt);
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public int UpdateAcnt(CustAcnt acnt)
        {
            if (null == acnt)
                return 0;
            return service.UpdateAcnt(acnt);
        }

        public List<CustAcnt> LoadCustAcnt(int custId, bool withInvalid = false)
        {
            if (custId == 0)
                return null;
            return service.LoadCustAcnt(custId, withInvalid);
        }
    }
}
