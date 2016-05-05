using DAL.Com;
using Model.Entity;
using Model.VO;
using System.Collections.Generic;

namespace BLL.Com
{
    public class CustomerManager
    {
        CustomerService service;
        public CustomerManager()
        {
            service = new CustomerService();
        }

        public List<Customer> LoadData(Customer cust)
        {
            if (null == cust)
                return null;
            return service.LoadData(cust);
        }

        public int Save(Customer cust)
        {
            if (null == cust)
                return 0;
            return service.Save(cust);
        }

        public int Update(Customer cust)
        {
            if (null == cust)
                return 0;
            return service.Update(cust);
        }

        public int AddGoods(List<SupplyInfo> list)
        {
            if (null == list)
                return 0;
            return service.AddGoods(list);
        }

        public List<GoodsVO> LoadSupplyGoods(int custId)
        {
            if (0 == custId)
                return null;
            return service.LoadSupplyGoods(custId);
        }

        public int DeleteSupplyGoods(int custId, int gId)
        {
            if (0 == custId || 0 == gId)
                return 0;
            return service.DeleteSupplyGoods(custId, gId);
        }
    }
}
