using Model.Entity;
using Model.VO;
using System.Collections.Generic;

namespace BLL.Com
{
    public interface ICustomerManager : IBaseManager
    {
        List<Customer> LoadData(Customer cust, PageVO page);

        int Save(Customer cust);

        int Update(Customer cust);

        int AddGoods(List<SupplyInfo> list);

        List<GoodsVO> LoadSupplyGoods(int custId, PageVO page);

        List<GoodsVO> LoadNotSupplyGoods(Goods goods, int supplierId, PageVO page);

        int DeleteSupplyGoods(int custId, int gId);

        int AddCustAcnt(CustAcnt acnt);

        int UpdateAcnt(CustAcnt acnt);

        List<CustAcnt> LoadCustAcnt(int custId, bool withInvalid = false);
    }
}
