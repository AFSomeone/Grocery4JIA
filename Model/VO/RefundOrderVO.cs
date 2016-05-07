using Model.Entity;
using System.Collections.Generic;

namespace Model.VO
{
    public class RefundOrderVO : Order
    {
        private List<Refund> _refundList;

        public List<Refund> _RefundList
        {
            get
            {
                return _refundList;
            }

            set
            {
                _refundList = value;
            }
        }
    }
}
