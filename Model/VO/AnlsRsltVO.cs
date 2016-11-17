using System.Collections.Generic;

namespace Model.VO
{
    public class AnlsRsltVO
    {
        private List<object> xdata;
        private List<decimal> ydata;

        public List<object> Xdata
        {
            get
            {
                return xdata;
            }

            set
            {
                xdata = value;
            }
        }

        public List<decimal> Ydata
        {
            get
            {
                return ydata;
            }

            set
            {
                ydata = value;
            }
        }
    }
}
