using System;

namespace Model.Entity
{
    public class Refund
    {
        public readonly string __table = "REFUNDS";

        private long? rID__PK;
        private string orderNO;
        private long? invID;
        private int? num;
        private decimal? price;
        private string direct;
        private long? tgtSID;

        public long? RID__PK
        {
            get
            {
                return rID__PK;
            }

            set
            {
                rID__PK = value;
            }
        }

        public int? Num
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

        public long? InvID
        {
            get
            {
                return invID;
            }

            set
            {
                invID = value;
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

        public decimal? Price
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

        public long? TgtSID
        {
            get
            {
                return tgtSID;
            }

            set
            {
                tgtSID = value;
            }
        }
    }
}
