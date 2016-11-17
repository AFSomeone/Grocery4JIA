using System;

namespace Model.Entity
{
    public class BillingChld
    {
        public readonly string __table = "BILLING_CHLD";

        private long? id__PK;
        private string billNO;
        private decimal? amount;
        private string payMode;
        private long? acntId;
        private string oprtUsrId;
        private DateTime? oprtTmst;

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

        public decimal? Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public string PayMode
        {
            get
            {
                return payMode;
            }

            set
            {
                payMode = value;
            }
        }

        public long? AcntId
        {
            get
            {
                return acntId;
            }

            set
            {
                acntId = value;
            }
        }

        public string OprtUsrId
        {
            get
            {
                return oprtUsrId;
            }

            set
            {
                oprtUsrId = value;
            }
        }

        public DateTime? OprtTmst
        {
            get
            {
                return oprtTmst;
            }

            set
            {
                oprtTmst = value;
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
