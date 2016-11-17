using Model.Entity;

namespace Model.VO
{
    public class RefundOrderDetailVO : Refund
    {
        private string tgtOrderNO;
        private int gID;
        private string gName;
        private string specs;

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

        public string TgtOrderNO
        {
            get
            {
                return tgtOrderNO;
            }

            set
            {
                tgtOrderNO = value;
            }
        }
    }
}
