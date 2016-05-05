using Model.Entity;

namespace Model.VO
{
    public class GoodsVO : Goods
    {
        private string catgName;

        public string CatgName
        {
            get
            {
                return catgName;
            }

            set
            {
                catgName = value;
            }
        }
    }
}
