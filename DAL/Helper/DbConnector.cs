using Model.VO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Helper
{
    class DbConnector : BaseConnector
    {
        private IDbHelper dbHelper;
        private int? connectorId;

        public IDbHelper DbHelper
        {
            get { return dbHelper; }
        }

        public DbConnector(IDbHelper helper)
        {
            dbHelper = helper;
        }

        public int? ConnectorId
        {
            get
            {
                return connectorId;
            }

            set
            {
                connectorId = value;
            }
        }

        #region methods
        /// <summary>
        /// T实例保存入库
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns>执行结果</returns>
        public int Save<T>(T t, bool autoCalcID = false) where T : new()
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
            return dbHelper.ExecuteSql(sqlStr, values);
        }

        public int Update<T>(T t) where T : new()
        {
            string sqlStr = string.Empty;
            List<IDataParameter> paramList = new List<IDataParameter>();
            Dictionary<String, object> values = GenUpdateModelSqlStr(t, out sqlStr);
            if (sqlStr == string.Empty)
                return 0;
            return dbHelper.ExecuteSql(sqlStr, values);
        }

        /// <summary>
        /// 执行sql自动封装返回T的List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="values">参数</param>
        /// <returns>model列表</returns>
        public List<T> LoadModels<T>(String sql, Dictionary<String,object> values) where T : new()
        {
            List<T> models = new List<T>();
            DataTable dt = dbHelper.GetData(sql, values);
            foreach (DataRow row in dt.Rows)
            {
                models.Add(RowToModel<T>(row));
            }

            return models;
        }

        /// <summary>
        /// 执行sql自动封装返回T的List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="values">参数</param>
        /// <param name="page">分页参数</param>
        /// <returns>model列表</returns>
        public List<T> LoadModelsByPage<T>(String sql, Dictionary<String, object> values, PageVO page) where T : new()
        {
            List<T> models = new List<T>();
            DataTable dt = dbHelper.GetDataByPage(sql, values, page);
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
        public string ScalarStr(string sql, Dictionary<String, object> values)
        {
            object obj = dbHelper.GetScalar(sql, values);
            if (DBNull.Value == obj)
                return null;
            return obj+"";
        }

        public int ScalarInt(string sql, Dictionary<String, object> values)
        {
            object obj = dbHelper.GetScalar(sql, values);
            if (DBNull.Value == obj)
                return 0;
            return int.Parse(obj.ToString());
        }

        public long ScalarLong(string sql, Dictionary<String, object> values)
        {
            object obj = dbHelper.GetScalar(sql, values);
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
        #endregion
    }
}
