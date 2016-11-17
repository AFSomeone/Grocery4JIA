using System;

namespace Model.Entity
{
    public class Order
    {
        public readonly string __table = "ORDERS";

        private string orderNO__PK;
        private int? custID;
        private string custName;
        private decimal? amount;
        private string direct;
        private DateTime? crtTmst;
        private DateTime? uptTmst;
        private string crtUID;
        private string uptUID;
        private string handled;

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

        public DateTime? UptTmst
        {
            get
            {
                return uptTmst;
            }

            set
            {
                uptTmst = value;
            }
        }

        public string CrtUID
        {
            get
            {
                return crtUID;
            }

            set
            {
                crtUID = value;
            }
        }

        public string UptUID
        {
            get
            {
                return uptUID;
            }

            set
            {
                uptUID = value;
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

        public string OrderNO__PK
        {
            get
            {
                return orderNO__PK;
            }

            set
            {
                orderNO__PK = value;
            }
        }

        public string Handled
        {
            get
            {
                return handled;
            }

            set
            {
                handled = value;
            }
        }
    }
}
