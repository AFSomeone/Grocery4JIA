
namespace Model.Entity
{
    public class StockOut
    {
        public readonly string __table = "STOCKOUT";

        private long? sID__PK;
        private string orderNO;
        private long? invID;
        private int? num;
        private int? rfNum;
        private decimal? price;

        public long? SID__PK
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

        public int? RfNum
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
    }
}
