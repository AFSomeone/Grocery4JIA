
using DAL.Com;
using Model.VO;

namespace BLL.Com
{
    public class StockOutManager
    {
        StockOutService service;
        public StockOutManager()
        {
            service = new StockOutService();
        }

        public string StockOut(StockOutOrderVO vo)
        {
            if (null == vo)
                return string.Empty;
            return service.StockOut(vo);
        }
    }
}
