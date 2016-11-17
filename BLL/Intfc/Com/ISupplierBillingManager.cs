using Model.Entity;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Com
{
    public interface ISupplierBillingManager : IBaseManager
    {
        List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt, PageVO page);

        List<OrderGoodsVO> LoadOrderGoods(int supplierId, List<string> orderNOList, PageVO page);

        string Entry(BilliingVO vo);

        List<BilliingVO> LoadBills(Billing bill, bool? settled, DateTime? startDt, DateTime? endDt, PageVO page);

        BillGoodsVO LoadBillGoods(string billNO, int supplierId, PageVO page);

        List<BillingChldVO> LoadBillingChld(string billNO, PageVO page);

        List<CustAcnt> LoadCustAcntByKeywords(int supplierId, string acntType, string platform, string term);

        int Pay(BillingChld chld, CustAcnt acnt);
    }
}
