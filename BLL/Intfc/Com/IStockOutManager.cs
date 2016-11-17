using Model.Entity;
using Model.VO;
using System;
using System.Collections.Generic;

namespace BLL.Com
{
    public interface IStockOutManager : IBaseManager
    {
        string StockOut(StockOutOrderVO vo);

        List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt, PageVO page);

        List<StockOutOrderDetailVO> LoadOrderDetail(string orderNO, PageVO page);
    }
}
