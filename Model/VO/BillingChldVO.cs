using Model.Entity;

namespace Model.VO
{
    public class BillingChldVO : BillingChld
    {
        private string oprtUsrName;
        private string acntNO;
        private string acntType;
        private string platform;

        public string OprtUsrName
        {
            get
            {
                return oprtUsrName;
            }

            set
            {
                oprtUsrName = value;
            }
        }

        public string AcntNO
        {
            get
            {
                return acntNO;
            }

            set
            {
                acntNO = value;
            }
        }

        public string AcntType
        {
            get
            {
                return acntType;
            }

            set
            {
                acntType = value;
            }
        }

        public string Platform
        {
            get
            {
                return platform;
            }

            set
            {
                platform = value;
            }
        }
    }
}
