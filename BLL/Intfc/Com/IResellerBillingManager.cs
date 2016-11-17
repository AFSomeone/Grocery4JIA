using Model.Entity;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Com
{
    public interface IResellerBillingManager : IBaseManager
    {
        List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt, PageVO page);

        List<OrderGoodsVO> LoadOrderGoods(int resellerId, List<string> orderNOList, PageVO page);

        BillGoodsVO LoadBillGoods(string billNO, int supplierId, PageVO page);

        List<BilliingVO> LoadBills(Billing bill, bool? settled, DateTime? startDt, DateTime? endDt, PageVO page);

        List<BillingChldVO> LoadBillingChld(string billNO, PageVO page);

        List<CustAcnt> LoadCustAcntByKeywords(int resellerId, string acntType, string platfrom, string term);

        string Entry(BilliingVO vo);

        int Rcv(BillingChld chld, CustAcnt acnt);
    }
}
