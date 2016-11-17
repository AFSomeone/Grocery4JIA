using Model.Entity;

namespace Model.VO
{
    public class InvOprtChldVO : InventoryChld
    {
        private string uName;

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
    }
}
