
using BLL.Com;
using DAL.Com;
using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;

namespace BLL.Proxy
{
    class SupplierBillingManager :BaseManager, ISupplierBillingManager
    {
        OrderService orderService;
        BillingService service;
        public SupplierBillingManager(int connectorId)
        {
            service = base.CreateService(typeof(BillingService), connectorId) as BillingService;
            orderService = base.CreateService(typeof(OrderService), connectorId) as OrderService;
        }

        public List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt, PageVO page)
        {
            if (null == order)
                return null;  
            return orderService.LoadOrders(order, startDt, endDt, page);
        }

        public List<OrderGoodsVO> LoadOrderGoods(int supplierId, List<string> orderNOList, PageVO page)
        {
            if (null == orderNOList || orderNOList.Count == 0)
                return null;
            return orderService.LoadSupplierOrderGoods(supplierId, orderNOList, page);
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public string Entry(BilliingVO vo)
        {
            if (null == vo || null == vo._OrderNOList || vo._OrderNOList.Count < 1)
                return string.Empty;
            vo.Direct = PYMNT_DIRECT.PAY;
            return service.Entry(vo);
        }

        public List<BilliingVO> LoadBills(Billing bill, bool? settled, DateTime? startDt, DateTime? endDt, PageVO page)
        {
            if (null == bill)
                bill = new Billing();
            bill.Direct = PYMNT_DIRECT.PAY;
            return service.LoadBills(bill, settled, startDt, endDt, page);
        }

        public BillGoodsVO LoadBillGoods(string billNO, int supplierId, PageVO page)
        {
            BillGoodsVO billGoods = null;
            if (StringUtil.isEmpty(billNO))
                return billGoods;
            BilliingVO billVO = service.LoadBill(billNO, supplierId, page);
            if (null != billVO)
            {
                billGoods = new BillGoodsVO();
                billGoods.BillNO__PK = billVO.BillNO__PK;
                billGoods.Amount = billVO.Amount;
                billGoods.CrtTmst = billVO.CrtTmst;
                billGoods.CrtUsrId = billVO.CrtUsrId;
                billGoods.CustID = billVO.CustID;
                billGoods.CustName = billVO.CustName;
                billGoods.Direct = billVO.Direct;
                billGoods.FactAmount = billVO.FactAmount;
                List<OrderGoodsVO> orderGoodsList = orderService.LoadSupplierOrderGoods(supplierId, billVO._OrderNOList, page);
                billGoods._OrderGoods = orderGoodsList;
            }
            return billGoods;
        }

        public List<BillingChldVO> LoadBillingChld(string billNO, PageVO page)
        {
            return service.LoadBillingChld(billNO, page);
        }

        public List<CustAcnt> LoadCustAcntByKeywords(int supplierId, string acntType, string platform, string term)
        {
            if (StringUtil.isEmpty(term))
                return null;
            return service.LoadCustAcntByKeywords(supplierId, acntType, platform, term);
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public int Pay(BillingChld chld, CustAcnt acnt)
        {
            if (null == chld)
                return 0;
            return service.UpdateAmount(chld, acnt);
        }
    }
}
