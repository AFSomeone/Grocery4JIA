using Model.Entity;

namespace Model.VO
{
    public class StockinOrderDetailVO : StockIn
    {
        private string gName;
        private string specs;
        private string shelfLife;

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
    }
}
