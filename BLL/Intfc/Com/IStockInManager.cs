using Model.Entity;
using Model.VO;
using System;
using System.Collections.Generic;

namespace BLL.Com
{
    public interface IStockInManager : IBaseManager
    {
        string Stockin(StockInOrderVO orderVO);

        List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt, PageVO page);

        List<StockInOrderDetailVO> LoadOrderDetail(string orderNO, PageVO page);
    }
}
