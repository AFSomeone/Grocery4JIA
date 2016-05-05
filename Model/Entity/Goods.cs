
namespace Model.Entity
{
    /// <summary>
    /// 商品信息
    /// </summary>
    public class Goods
    {
        public readonly string __table = "GOODS";
        public readonly int __baseId = 50000;

        private int gID__PK;
        private string gName;
        private string abbr;
        private string specs;
        private short subCatgID;
        private string shelfLife;
        private string st;
        private string remark;

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

        public string Abbr
        {
            get
            {
                return abbr;
            }

            set
            {
                abbr = value;
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

        public short SubCatgID
        {
            get
            {
                return subCatgID;
            }

            set
            {
                subCatgID = value;
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

        public int GID__PK
        {
            get
            {
                return gID__PK;
            }

            set
            {
                gID__PK = value;
            }
        }
    }
}
