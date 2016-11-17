
namespace Model.Entity
{
    public class Customer
    {
        public readonly string __table = "CUSTOMERS";
        public readonly int __baseId = 3000;

        private int? cID__PK;
        private string cName;
        private string address;
        private string tel;
        private string phone;
        private string fax;
        private string email;
        private string grade;
        private string remark;
        private string st;
        private string linkMan;

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

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
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

        public string Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
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

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
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

        public string LinkMan
        {
            get
            {
                return linkMan;
            }

            set
            {
                linkMan = value;
            }
        }

        public int? CID__PK
        {
            get
            {
                return cID__PK;
            }

            set
            {
                cID__PK = value;
            }
        }
    }
}
