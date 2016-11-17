
using System;

namespace Model.Entity
{
    /// <summary>
    /// 商品大类
    /// </summary>
    public class Category
    {
        public readonly string __table = "CATEGORY";
        public readonly short __baseId = 10;

        private short? cId__PK;
        private string cName;
        private string st;

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
