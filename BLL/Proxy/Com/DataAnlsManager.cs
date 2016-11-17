using BLL.Com;
using Model.VO;
using DAL.Com;
using System;

namespace BLL.Proxy
{
    class DataAnlsManager : BaseManager, IDataAnlsManager
    {
        private DataAnlsService service;
        public DataAnlsManager(int connectorId)
        {
            service = base.CreateService(typeof(DataAnlsService), connectorId) as DataAnlsService;
        }

        public AnlsRsltVO ProfitStatsByMonth(int year, short? subCatgId, int? goodsId)
        {
            return service.ProfitStatsByMonth(year, subCatgId, goodsId);
        }

        public AnlsRsltVO ProfitStatsByUsr(DateTime beginDt, DateTime endDt)
        {
            return service.ProfitStatsByUsr(beginDt, endDt);
        }
    }
}
