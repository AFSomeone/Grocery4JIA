using Model.Entity;
using System.Collections.Generic;

namespace Model.VO
{
    public class StockOutOrderVO : Order
    {
        private List<StockOut> _stockOutList;

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
    }
}
