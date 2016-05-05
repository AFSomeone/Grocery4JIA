
namespace Model.VO
{
    public class OrderGoodsVO
    {
        private int gID;
        private string gName;
        private int num;
        private decimal price;

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
    }
}
