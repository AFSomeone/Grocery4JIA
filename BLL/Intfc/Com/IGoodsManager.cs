using Model.Entity;
using Model.VO;
using System.Collections.Generic;

namespace BLL.Com
{
    public interface IGoodsManager : IBaseManager
    {
        List<GoodsVO> LoadData(Goods goods, PageVO page, int? supplierId = null);

        List<Goods> LoadDataByKeyWords(string term, int? supplierId = null);

        List<StockGoodsVO> LoadInStockGoodsByKeyWords(string term, int? supplierId = null);

        List<StockGoodsVO> LoadSoldGoodsByKeyWords(string term, int? resellerId = null);

        int Save(Goods goods, int? supplierId);

        int Update(Goods goods);
    }
}
