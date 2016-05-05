using Model.Entity;
using System.Collections.Generic;

namespace Model.VO
{
    public class RefundOrderVO : Order
    {
        private string crtUName;
        private string uptUName;
        private List<Refund> _refundList;

        public string CrtUName
        {
            get
            {
                return crtUName;
            }

            set
            {
                crtUName = value;
            }
        }

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

        public string UptUName
        {
            get
            {
                return uptUName;
            }

            set
            {
                uptUName = value;
            }
        }
    }
}
