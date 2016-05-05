using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Helper
{
    interface IDbHelper
    {
        object GetScalar(string sql, Dictionary<String, object> values, bool closeFlag = true);
        int ExecuteSql(string sql, Dictionary<String, object> values, bool closeFlag = true);
        DataTable GetData(string sql, Dictionary<String, object> values, bool closeFlag = true);
        void BeginTransaction();
        void RollbackTransaction();
        void CommitTransaction();
        void CloseConnection();
        void Dispose();
    }
}
