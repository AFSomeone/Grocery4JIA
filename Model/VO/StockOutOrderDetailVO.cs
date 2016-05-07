
using Model.Entity;

namespace Model.VO
{
    public class StockOutOrderDetailVO : StockOut
    {
        private string sinOrderNO;
        private int gID;
        private string gName;
        private string specs;

        public string SinOrderNO
        {
            get
            {
                return sinOrderNO;
            }

            set
            {
                sinOrderNO = value;
            }
        }

        public int GID
        {
            get
            {
                return gID;
            }

            set
            {
                gID = value;
            }
        }

        public string GName
        {
            get
            {
                return gName;
            }

            set
            {
                gName = value;
            }
        }

        public string Specs
        {
            get
            {
                return specs;
            }

            set
            {
                specs = value;
            }
        }
    }
}
