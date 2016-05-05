
namespace Model.Entity
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class Usr
    {
        //表名
        public readonly string __table = "USR";

        private string uId__PK;
        private string pwd;
        private string uName;
        private string tel;
        private string qq;
        private string st;
        private string remark;

        public string UId__PK
        {
            get
            {
                return uId__PK;
            }

            set
            {
                uId__PK = value;
            }
        }

        public string Pwd
        {
            get
            {
                return pwd;
            }

            set
            {
                pwd = value;
            }
        }

        public string UName
        {
            get
            {
                return uName;
            }

            set
            {
                uName = value;
            }
        }

        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }

        public string QQ
        {
            get
            {
                return qq;
            }

            set
            {
                qq = value;
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
    }
}