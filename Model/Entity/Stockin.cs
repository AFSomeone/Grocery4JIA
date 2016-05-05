using System;

namespace Model.Entity
{
    public class StockIn
    {
        public readonly string __table = "STOCKIN";

        private long sID__PK;
        private string orderNO;
        private int gID;
        private int num;
        private decimal price;
        private DateTime mfDt;
        private DateTime expDt;
        private string st;

        public long SID__PK
        {
            get
            {
                return sID__PK;
            }

            set
            {
                sID__PK = value;
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
  
        public int Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public DateTime MfDt
        {
            get
            {
                return mfDt;
            }

            set
            {
                mfDt = value;
            }
        }

        public DateTime ExpDt
        {
            get
            {
                return expDt;
            }

            set
            {
                expDt = value;
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

        public string OrderNO
        {
            get
            {
                return orderNO;
            }

            set
            {
                orderNO = value;
            }
        }
    }
}
