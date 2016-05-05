using DAL.Com;
using Model.Entity;
using Model.VO;
using System.Collections.Generic;

namespace BLL.Com
{
    public class InventoryManager
    {
        InventoryService service;
        public InventoryManager()
        {
            service = new InventoryService();
        }

        public List<InStockGoodsVO> LoadGoodsInStock(Order order, int catgId)
        {
            return service.LoadGoodsInStock(order, catgId);
        }
    }
}
