using DAL.Com;
using Model.Entity;
using Model.Util;
using Model.VO;
using System.Collections.Generic;

namespace BLL.Com
{
    public class GoodsManager
    {
        GoodsService service;
        public GoodsManager()
        {
            service = new GoodsService();
        }

        public List<GoodsVO> LoadData(Goods goods, int? supplierId = null)
        {
            if (null == goods)
                goods = new Goods ();
            return service.LoadData(goods, supplierId);
        }

        public List<Goods> LoadDataByKeyWords(string term, int? supplierId = null)
        {
            if (StringUtil.isEmpty(term))
                return null;
            return service.LoadDataByKeyWords(term, supplierId);
        }

        public List<InStockGoodsVO> LoadInStockGoodsByKeyWords(string term, int? supplierId = null)
        {
            if (StringUtil.isEmpty(term))
                return null;
            return service.LoadInStockGoodsByKeyWords(term, supplierId);
        }

        public int Save(Goods goods)
        {
            if (null == goods)
                return 0;
            return service.Save(goods);
        }

        public int Update(Goods goods)
        {
            if (null == goods)
                return 0;
            return service.Update(goods);
        }
    }
}
