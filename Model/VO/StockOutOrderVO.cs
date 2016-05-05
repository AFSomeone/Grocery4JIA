using Model.Entity;
using System.Collections.Generic;

namespace Model.VO
{
    public class StockOutOrderVO : Order
    {
        private string crtUName;
        private string uptUName;
        private List<StockOut> _stockOutList;

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

        public List<StockOut> _StockOutList
        {
            get
            {
                return _stockOutList;
            }

            set
            {
                _stockOutList = value;
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
