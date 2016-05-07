using DAL.Com;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;

namespace BLL.Com
{
    public class StockInManager
    {
        StockInService service;
        OrderService orderService;
        public StockInManager()
        {
            service = new StockInService();
        }

        public string Stockin(StockInOrderVO orderVO)
        {
            if (null == orderVO || orderVO._StockinList.Count == 0)
                return string.Empty;
            return service.Stockin(orderVO);
        }

        public List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt)
        {
            if (null == order)
                return null;
            if (null == orderService)
                orderService = new OrderService();
            return orderService.LoadOrders(order, startDt, endDt);
        }

        public List<StockInOrderDetailVO> LoadOrderDetail(string orderNO)
        {
            if (StringUtil.isEmpty(orderNO))
                return null;
            return service.LoadOrderDetail(orderNO);
        }
    }
}
