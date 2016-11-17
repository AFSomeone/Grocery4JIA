using Model.Entity;
using Model.VO;
using System.Collections.Generic;

namespace BLL.Com
{
    public interface IInventoryManager : IBaseManager
    {
        List<StockGoodsVO> LoadGoodsInStock(Order order, int catgId, int minInvNum, PageVO page);

        /// <summary>
        /// 查询在库商品信息
        /// </summary>
        /// <param name="order">订单信息</param>
        /// <param name="catgId">分类Id</param>
        /// <param name="gNmId">商品Id/名称</param>
        /// <param name="minInvNum">最低库存量</param>
        /// <param name="page">分页信息</param>
        /// <returns></returns>
        List<StockGoodsVO> LoadGoodsInStock(Order order, int catgId, string gNmId, int minInvNum, PageVO page);

        List<StockGoodsVO> LoadSoldGoods(Order order, int catgId, PageVO page);

        int UpdateInvNum(long invID, int bfNum, int num, Usr oprtUsr);

        List<InvOprtChldVO> LoadOprtChld(long invId);
    }
}
