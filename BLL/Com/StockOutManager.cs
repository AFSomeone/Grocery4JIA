
using DAL.Com;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;

namespace BLL.Com
{
    public class StockOutManager
    {
        StockOutService service;
        OrderService orderService;
        public StockOutManager()
        {
            service = new StockOutService();
        }

        public string StockOut(StockOutOrderVO vo)
        {
            if (null == vo)
                return string.Empty;
            return service.StockOut(vo);
        }

        public List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt)
        {
            if (null == order)
                return null;
            if (null == orderService)
                orderService = new OrderService();
            return orderService.LoadOrders(order, startDt, endDt);
        }

        public List<StockOutOrderDetailVO> LoadOrderDetail(string orderNO)
        {
            if (StringUtil.isEmpty(orderNO))
                return null;
            return service.LoadOrderDetail(orderNO);
        }
    }
}
