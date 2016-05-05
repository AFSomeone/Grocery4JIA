
namespace Model.Entity
{
    public class SupplyInfo
    {
        public readonly string __table = "SUPPLY_INFO";

        private int spID__PK;
        private int custID;
        private int gID;
        private string st;

        public int SpID__PK
        {
            get
            {
                return spID__PK;
            }

            set
            {
                spID__PK = value;
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
    }
}
