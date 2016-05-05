using System;
using System.Configuration;

namespace DAL.Helper
{
    class ConnectorFactory
    {
        public static DbConnector CreatConnector()
        {
            IDbHelper dbHelper;
            String dbTypeStr = ConfigurationManager.AppSettings["dbType"];
            if (dbTypeStr == "mysql")
                dbHelper = new MySqlHelper();
            else
                dbHelper = null;
            DbConnector dbConnector = new DbConnector(dbHelper);
            
            return dbConnector;
        }
    }
}
