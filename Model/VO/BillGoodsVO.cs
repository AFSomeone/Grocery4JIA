using Model.Entity;
using System.Collections.Generic;

namespace Model.VO
{
    public class BillGoodsVO : Billing
    {
        private List<OrderGoodsVO> _orderGoods;

        public List<OrderGoodsVO> _OrderGoods
        {
            get
            {
                return _orderGoods;
            }

            set
            {
                _orderGoods = value;
            }
        }
    }
}
