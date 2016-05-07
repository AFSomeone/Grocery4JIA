using DAL.Com;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;

namespace BLL.Com
{
    public class RefundManager
    {
        RefundService service;
        OrderService orderService;
        public RefundManager()
        {
            service = new RefundService();
        }

        public List<InStockGoodsVO> LoadGoodsInStock(Order order, int catgId)
        {
            return service.LoadGoodsInStock(order, catgId);
        }

        public string Refund(RefundOrderVO refundVO)
        {
            return service.Refund(refundVO);
        }

        public List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt)
        {
            if (null == order)
                return null;
            if (null == orderService)
                orderService = new OrderService();
            return orderService.LoadOrders(order, startDt, endDt);
        }

        public List<RefundOrderDetailVO> LoadOrderDetail(string orderNO)
        {
            if (StringUtil.isEmpty(orderNO))
                return null;
            return service.LoadOrderDetail(orderNO);
        }
    }
}
