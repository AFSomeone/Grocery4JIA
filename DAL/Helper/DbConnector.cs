using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Helper
{
    class DbConnector : BaseConnector
    {
        private IDbHelper dbHelper;

        public IDbHelper DbHelper
        {
            get { return dbHelper; }
        }

        public DbConnector(IDbHelper helper)
        {
            dbHelper = helper;
        }

        #region methods
        /// <summary>
        /// T实例保存入库
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns>执行结果</returns>
        public int Save<T>(T t, bool autoCalcID = false, bool closeFlag = true) where T : new()
        {
            string sqlStr = string.Empty;
            List<IDataParameter> paramList = new List<IDataParameter>();
            Dictionary<String, object> values;
            if (autoCalcID)
                values = GenAutoCalcIDSaveModelSqlStr(t, out sqlStr);
            else
                values = GenSaveModelSqlStr(t, out sqlStr);
            if (sqlStr == string.Empty)
                return 0;
            return dbHelper.ExecuteSql(sqlStr, values, closeFlag);
        }

        public int Update<T>(T t, bool closeFlag = true) where T : new()
        {
            string sqlStr = string.Empty;
            List<IDataParameter> paramList = new List<IDataParameter>();
            Dictionary<String, object> values = GenUpdateModelSqlStr(t, out sqlStr);
            if (sqlStr == string.Empty)
                return 0;
            return dbHelper.ExecuteSql(sqlStr, values, closeFlag);
        }

        /// <summary>
        /// 执行sql自动封装返回T的List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="values">参数</param>
        /// <returns>model列表</returns>
        public List<T> LoadModels<T>(String sql, Dictionary<String,object> values, bool closeFlag = true) where T : new()
        {
            List<T> models = new List<T>();
            DataTable dt = dbHelper.GetData(sql, values, closeFlag);
            foreach (DataRow row in dt.Rows)
            {
                models.Add(RowToModel<T>(row));
            }

            return models;
        }

        /// <summary>
        /// 执行sql获取第一个返回值
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="values">sql语句参数</param>
        /// <returns>查询结果的第一行第一列值</returns>
        public string ScalarStr(string sql, Dictionary<String, object> values, bool closeFlag = true)
        {
            object obj = dbHelper.GetScalar(sql, values, closeFlag);
            if (DBNull.Value == obj)
                return null;
            return obj.ToString();
        }

        public int ScalarInt(string sql, Dictionary<String, object> values, bool closeFlag = true)
        {
            object obj = dbHelper.GetScalar(sql, values, closeFlag);
            if (DBNull.Value == obj)
                return 0;
            return int.Parse(obj.ToString());
        }

        public long ScalarLong(string sql, Dictionary<String, object> values, bool closeFlag = true)
        {
            object obj = dbHelper.GetScalar(sql, values, closeFlag);
            if (DBNull.Value == obj)
                return 0;
            return long.Parse(obj.ToString());
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        public void CloseConnection()
        {
            dbHelper.CloseConnection();
        }

        public void Dispose()
        {
            dbHelper.Dispose();
            dbHelper = null;
        }
        #endregion
    }
}
