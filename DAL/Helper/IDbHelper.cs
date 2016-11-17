using Model.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace DAL.Helper
{
    interface IDbHelper
    {
        object GetScalar(string sql, Dictionary<String, object> values);

        int ExecuteSql(string sql, Dictionary<String, object> values);

        DataTable GetData(string sql, Dictionary<String, object> values);

        DataTable GetDataByPage(string sql, Dictionary<string, object> values, PageVO page);

        DbTransaction BeginTransaction(bool beginNewTans = false);

        void RollbackTransaction();

        void RollbackTransaction(DbTransaction trans);

        void CommitTransaction();

        void CommitTransaction(DbTransaction trans);

        void CloseConnection();
    }
}
