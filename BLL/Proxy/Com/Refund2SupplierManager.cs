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
    class Refund2SupplierManager : BaseManager, IRefund2SupplierManager
    {
        RefundService service;
        OrderService orderService;

        public Refund2SupplierManager(int connectorId)
        {
            service = base.CreateService(typeof(RefundService), connectorId) as RefundService;
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public string Refund(RefundOrderVO refundVO)
        {
            if (null != refundVO)
                refundVO.Direct = DIRECT.REFUND2SUPPLIER;
            return service.Refund(refundVO);
        }

        public List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt, PageVO page)
        {
            if (null == order)
                return null;
            if (null == orderService)
                orderService = base.CreateService(typeof(OrderService),  ConnectorId) as  OrderService;
            order.Direct = DIRECT.REFUND2SUPPLIER;
            return orderService.LoadOrders(order, startDt, endDt, page);
        }

        public List<RefundOrderDetailVO> LoadOrderDetail(string orderNO, PageVO page)
        {
            if (StringUtil.isEmpty(orderNO))
                return null;
            return service.LoadOrderDetail(orderNO, DIRECT.REFUND2SUPPLIER, page);
        }
    }
}
