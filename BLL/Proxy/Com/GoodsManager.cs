using BLL.Com;
using DAL.Com;
using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System.Collections.Generic;

namespace BLL.Proxy
{
    class GoodsManager : BaseManager, IGoodsManager
    {
        GoodsService service;
        CustomerService custService;

        public GoodsManager(int connectorId)
        {
            service = base.CreateService(typeof(GoodsService), connectorId) as GoodsService;
        }

        public List<GoodsVO> LoadData(Goods goods, PageVO page, int? supplierId = null)
        {
            if (null == goods)
                goods = new Goods ();
            return service.LoadData(goods, supplierId, page);
        }

        public List<Goods> LoadDataByKeyWords(string term, int? supplierId = null)
        {
            if (StringUtil.isEmpty(term))
                return null;
            return service.LoadDataByKeyWords(term, supplierId);
        }

        public List<StockGoodsVO> LoadInStockGoodsByKeyWords(string term, int? supplierId = null)
        {
            if (StringUtil.isEmpty(term))
                return null;
            return service.LoadInStockGoodsByKeyWords(term, supplierId);
        }

        public List<StockGoodsVO> LoadSoldGoodsByKeyWords(string term, int? resellerId = null)
        {
            if (StringUtil.isEmpty(term))
                return null;
            return service.LoadSoldGoodsByKeyWords(term, resellerId);
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public int Save(Goods goods, int? supplierId)
        {
            int cnt = 0;
            if (null == goods)
                return 0;
            if (null != supplierId)
            {
                int rslt = 0;
                int? gId = service.GenGoodsId();
                if(null == custService)
                    custService = base.CreateService(typeof(CustomerService), ConnectorId) as CustomerService;
                if (null == gId)
                    gId = goods.__baseId;
                goods.GID__PK = gId;
                rslt += service.Save(goods);
                SupplyInfo spInfo = new SupplyInfo();
                spInfo.CustID = supplierId;
                spInfo.GID = goods.GID__PK;
                spInfo.St = ST.VALID;
                rslt += custService.AddGoods(new List<SupplyInfo>() {spInfo});
                if (rslt > 1)
                    cnt = 1;
            }
            else
                cnt += service.Save(goods);
            return cnt;
        }

        [TransAttr(TransLevel = TRANS_LEVEL.MANDATORY)]
        public int Update(Goods goods)
        {
            if (null == goods)
                return 0;
            return service.Update(goods);
        }
    }
}
