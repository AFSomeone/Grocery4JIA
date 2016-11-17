using Model.VO;
using System;

namespace BLL.Com
{
    public interface IDataAnlsManager : IBaseManager
    {
        AnlsRsltVO ProfitStatsByMonth(int year, short? subCatgId, int? goodsId);

        AnlsRsltVO ProfitStatsByUsr(DateTime beginDt, DateTime endDt);
    }
}