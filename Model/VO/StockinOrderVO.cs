using Model.Entity;
using System.Collections.Generic;

namespace Model.VO
{
    public class StockinOrderVO : Order
    {
        private string crtUName;
        private string uptUName;
        private List<StockIn> _stockinList;

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

        public List<StockIn> _StockinList
        {
            get
            {
                return _stockinList;
            }

            set
            {
                _stockinList = value;
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
