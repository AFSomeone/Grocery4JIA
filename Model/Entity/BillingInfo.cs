namespace Model.Entity
{
    public class BillingInfo
    {
        public readonly string __table = "BILLING_INFO";

        private long? id__PK;
        private string billNO;
        private string orderNO;

        public long? ID__PK
        {
            get
            {
                return id__PK;
            }

            set
            {
                id__PK = value;
            }
        }

        public string BillNO
        {
            get
            {
                return billNO;
            }

            set
            {
                billNO = value;
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
