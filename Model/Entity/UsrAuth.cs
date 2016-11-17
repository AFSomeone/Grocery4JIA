namespace Model.Entity
{
    public class UsrAuth
    {
        public readonly string __table = "USR_AUTH";

        private string uID__PK;
        private string funcID__PK;
        private string st;

        public string UID__PK
        {
            get
            {
                return uID__PK;
            }

            set
            {
                uID__PK = value;
            }
        }

        public string FuncID__PK
        {
            get
            {
                return funcID__PK;
            }

            set
            {
                funcID__PK = value;
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
