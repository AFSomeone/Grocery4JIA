using Model.Entity;

namespace Model.VO
{
    public class SubCatgVO : SubCategory
    {
        private string superName;

        public string SuperName
        {
            get
            {
                return superName;
            }

            set
            {
                superName = value;
            }
        }
    }
}
