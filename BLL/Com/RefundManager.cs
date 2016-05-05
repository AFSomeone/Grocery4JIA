using DAL.Com;
using Model.Const;
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

        public List<RefundOrderVO> LoadOrders(Order order)
        {
            if (null == order)
                return null;
            return service.LoadOrders(order);
        }

        public List<RefundOrderDetailVO> LoadOrderDetail(string orderNO)
        {
            if (StringUtil.isEmpty(orderNO))
                return null;
            return service.LoadOrderDetail(orderNO);
        }
    }
}
