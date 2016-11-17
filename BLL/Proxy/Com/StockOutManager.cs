
using BLL.Com;
using DAL.Com;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;

namespace BLL.Proxy
{
    class StockOutManager : BaseManager, IStockOutManager
    {
        StockOutService service;
        OrderService orderService;

        public StockOutManager(int connectorId)
        {
            service = base.CreateService(typeof(StockOutService), connectorId) as StockOutService;
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public string StockOut(StockOutOrderVO vo)
        {
            if (null == vo)
                return string.Empty;
            return service.StockOut(vo);
        }

        public List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt, PageVO page)
        {
            if (null == order)
                return null;
            if (null == orderService)
                orderService = base.CreateService(typeof(OrderService), ConnectorId) as OrderService;
            return orderService.LoadOrders(order, startDt, endDt, page);
        }

        public List<StockOutOrderDetailVO> LoadOrderDetail(string orderNO, PageVO page)
        {
            if (StringUtil.isEmpty(orderNO))
                return null;
            return service.LoadOrderDetail(orderNO, page);
        }
    }
}
