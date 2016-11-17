
using System;

namespace Model.Entity
{
    /// <summary>
    /// 商品细类
    /// </summary>
    public class SubCategory
    {
        public readonly string __table = "SUB_CATEGORY";
        public readonly short __baseId = 2000;

        private short? cId__PK;
        private short? superId;
        private string cName;
        private string abbr;
        private string pinYin;
        private string st;

        public short? SuperId
        {
            get
            {
                return superId;
            }

            set
            {
                superId = value;
            }
        }

        public string CName
        {
            get
            {
                return cName;
            }

            set
            {
                cName = value;
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

        public string PinYin
        {
            get
            {
                return pinYin;
            }

            set
            {
                pinYin = value;
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

        public short? CId__PK
        {
            get
            {
                return cId__PK;
            }

            set
            {
                cId__PK = value;
            }
        }
    }
}
