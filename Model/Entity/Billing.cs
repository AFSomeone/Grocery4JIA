using System;

namespace Model.Entity
{
    public class Billing
    {
        public readonly string __table = "BILLING";

        private string billNO__PK;
        //支付方向
        private string direct;
        private decimal? amount;
        private decimal? factAmount;
        private int? custID;
        private string custName;
        private string crtUsrId;
        private DateTime? crtTmst;

        public string Direct
        {
            get
            {
                return direct;
            }

            set
            {
                direct = value;
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

        public decimal? FactAmount
        {
            get
            {
                return factAmount;
            }

            set
            {
                factAmount = value;
            }
        }

        public string CrtUsrId
        {
            get
            {
                return crtUsrId;
            }

            set
            {
                crtUsrId = value;
            }
        }

        public DateTime? CrtTmst
        {
            get
            {
                return crtTmst;
            }

            set
            {
                crtTmst = value;
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

        public string CustName
        {
            get
            {
                return custName;
            }

            set
            {
                custName = value;
            }
        }

        public string BillNO__PK
        {
            get
            {
                return billNO__PK;
            }

            set
            {
                billNO__PK = value;
            }
        }
    }
}
