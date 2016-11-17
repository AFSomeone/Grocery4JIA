using Model.Entity;
using System.Collections.Generic;

namespace Model.VO
{
    public class BilliingVO : Billing
    {
        private string crtUsrName;
        private List<string> _orderNOList;

        public string CrtUsrName
        {
            get
            {
                return crtUsrName;
            }

            set
            {
                crtUsrName = value;
            }
        }

        public List<string> _OrderNOList
        {
            get
            {
                return _orderNOList;
            }

            set
            {
                _orderNOList = value;
            }
        }
    }
}
