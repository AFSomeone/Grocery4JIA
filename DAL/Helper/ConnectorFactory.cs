using Castle.DynamicProxy;
using Model.Exception;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Threading;

namespace DAL.Helper
{
    public class ConnectorFactory
    {
        static Dictionary<int?, DbConnector> connectorsMap = null;
        internal static DbConnector GetConnector(int connId)
        {
            DbConnector dbConnector = null;
            if (null != connectorsMap && connectorsMap.ContainsKey(connId))
                dbConnector = connectorsMap[connId];
            return dbConnector;
        }

        public static int? GenConnector(int? connId = null)
        {
            if (null == connId)
                connId = Thread.CurrentThread.GetHashCode();
            if (null == connectorsMap)
                connectorsMap = new Dictionary<int?, DbConnector>();
            if (connectorsMap.ContainsKey(connId))
                return connId;
            else
            {
                string dbTypeStr = ConfigurationManager.AppSettings["dbType"];
                if (dbTypeStr == "mysql")
                {
                    IDbHelper dbHelper = new MySqlHelper();
                    DbConnector dbConnector = new DbConnector(dbHelper);
                    dbConnector.ConnectorId = connId;
                    connectorsMap.Add(connId, dbConnector);
                    return connId;
                }
                else
                    return null;
            }
        }

        public static void CloseConnector(int connId)
        {
            DbConnector dbConnector = GetConnector(connId);
            if(null != dbConnector)
                dbConnector.CloseConnection();
            if (connectorsMap.ContainsKey(connId))
                connectorsMap.Remove(connId);
        }

        public static void ProceedInTransaction(IInvocation invocation, int connId)
        {
            DbConnector dbConnector = GetConnector(connId);
            if (null == dbConnector)
                throw new JException("JE-100");
            try
            {
                dbConnector.DbHelper.BeginTransaction(false);
                invocation.Proceed();
                dbConnector.DbHelper.CommitTransaction();
            }
            catch(Exception e)
            {
                dbConnector.DbHelper.RollbackTransaction();
                throw e;
            }
        }

        public static void ProceedInNewTransaction(IInvocation invocation, int connId)
        {
            DbTransaction _trans = null;
            DbConnector dbConnector = GetConnector(connId);
            if (null == dbConnector)
                throw new JException("JE-100");
            try
            {
                _trans = dbConnector.DbHelper.BeginTransaction(true);
                invocation.Proceed();
                dbConnector.DbHelper.CommitTransaction(_trans);
            }
            catch (Exception e)
            {
                dbConnector.DbHelper.RollbackTransaction(_trans);
                throw e;
            }
        }

    }
}
