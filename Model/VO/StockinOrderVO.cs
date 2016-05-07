using Model.Entity;
using System.Collections.Generic;

namespace Model.VO
{
    public class StockInOrderVO : Order
    {
        private List<StockIn> _stockinList;

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
    }
}
