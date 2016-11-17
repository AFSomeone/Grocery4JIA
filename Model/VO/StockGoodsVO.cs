using System;

namespace Model.VO
{
    public class StockGoodsVO
    {
        private long invID;
        private string orderNO;
        private int custID;
        private string custName;
        private int gID;
        private string gName;
        private string specs;
        private int num;
        private decimal price;
        private DateTime expDt;
        private string shelfLife;
        private string remark;
        //已退回量
        private int rfNum;
        private long? tgtSID;

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

        public int CustID
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

        public string ShelfLife
        {
            get
            {
                return shelfLife;
            }

            set
            {
                shelfLife = value;
            }
        }

        public string Remark
        {
            get
            {
                return remark;
            }

            set
            {
                remark = value;
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

        public long InvID
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

        public int RfNum
        {
            get
            {
                return rfNum;
            }

            set
            {
                rfNum = value;
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
