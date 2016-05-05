using DAL.Com;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;

namespace BLL.Com
{
    public class StockinManager
    {
        StockInService service;
        public StockinManager()
        {
            service = new StockInService();
        }

        public string Stockin(StockinOrderVO orderVO)
        {
            if (null == orderVO || orderVO._StockinList.Count == 0)
                return string.Empty;
            return service.Stockin(orderVO);
        }

        public List<StockinOrderVO> LoadOrders(Order order)
        {
            if (null == order)
                return null;
            return service.LoadOrders(order);
        }

        public List<StockinOrderDetailVO> LoadOrderDetail(string orderNO)
        {
            if (StringUtil.isEmpty(orderNO))
                return null;
            return service.LoadOrderDetail(orderNO);
        }
    }
}
