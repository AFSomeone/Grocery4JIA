using Model.Entity;
using Model.VO;
using System;
using System.Collections.Generic;

namespace BLL.Com
{
    public interface IResellerRefundManager : IBaseManager
    {
        string Refund(RefundOrderVO refundVO);

        List<OrderVO> LoadOrders(Order order, DateTime? startDt, DateTime? endDt, PageVO page);

        List<RefundOrderDetailVO> LoadOrderDetail(string orderNO, PageVO page);
    }
}
