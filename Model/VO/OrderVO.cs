using Model.Entity;

namespace Model.VO
{
    public class OrderVO : Order
    {
        private string crtUName;
        private string uptUName;
        private string billNO;

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

        public string BillNO
        {
            get
            {
                return billNO;
            }

            set
            {
                billNO = value;
            }
        }
    }
}
