
namespace Model.Entity
{
    public class CustAcnt
    {
        public readonly string __table = "CUST_ACNT";

        private long? id__PK;
        private int? custID;
        private string acntNO;
        private string acntType;
        private string platform;
        private string st;

        public long? ID__PK
        {
            get
            {
                return id__PK;
            }

            set
            {
                id__PK = value;
            }
        }

        public int? CustID
        {
            get
            {
                return custID;
            }

            set
            {
                custID = value;
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

        public string St
        {
            get
            {
                return st;
            }

            set
            {
                st = value;
            }
        }
    }
}
