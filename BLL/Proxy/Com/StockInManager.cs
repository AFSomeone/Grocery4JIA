using BLL.Com;
using DAL.Com;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;

namespace BLL.Proxy
{
    class StockInManager : BaseManager, IStockInManager
    {
        StockInService service;
        OrderService orderService;

        public StockInManager(int connectorId)
        {
            service = base.CreateService(typeof(StockInService), connectorId) as StockInService;
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public string Stockin(StockInOrderVO orderVO)
        {
            if (null == orderVO || orderVO._StockinList.Count == 0)
                return string.Empty;
            return service.Stockin(orderVO);
        }

        public List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt, PageVO page)
        {
            if (null == order)
                return null;
            if (null == orderService)
                orderService = base.CreateService(typeof(OrderService), ConnectorId) as OrderService;
            return orderService.LoadOrders(order, startDt, endDt, page);
        }

        public List<StockInOrderDetailVO> LoadOrderDetail(string orderNO, PageVO page)
        {
            if (StringUtil.isEmpty(orderNO))
                return null;
            return service.LoadOrderDetail(orderNO, page);
        }
    }
}
