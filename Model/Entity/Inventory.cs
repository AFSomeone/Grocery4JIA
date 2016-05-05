using System;

namespace Model.Entity
{
    public class Inventory
    {
        public readonly string __table = "INVENTORY";

        private long invID__PK;
        private string orderNO;
        private int gID;
        private int num;
        private DateTime tmst;

        public long InvID__PK
        {
            get
            {
                return invID__PK;
            }

            set
            {
                invID__PK = value;
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
