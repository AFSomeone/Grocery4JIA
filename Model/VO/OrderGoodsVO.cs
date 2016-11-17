
using System;

namespace Model.VO
{
    public class OrderGoodsVO
    {
        private int gID;
        private string gName;
        private int num;
        private decimal price;
        private string specs;

        private string orderNO;
        private string direct;
        private DateTime tmst;

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

        public DateTime Tmst
        {
            get
            {
                return tmst;
            }

            set
            {
                tmst = value;
            }
        }
    }
}
