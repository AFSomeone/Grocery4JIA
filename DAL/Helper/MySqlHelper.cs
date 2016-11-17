using Model.VO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Text.RegularExpressions;

namespace DAL.Helper
{
    class MySqlHelper : IDbHelper
    {
        private MySqlConnection connection;
        private MySqlTransaction _transaction;

        public MySqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    string preNm = ConfigurationManager.AppSettings["conPreName"];
                    string connectionString = ConfigurationManager.ConnectionStrings[preNm+"_mysql"].ConnectionString.ToString();
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }
        }

        public int ExecuteSql(string sql, Dictionary<string, object> values)
        {
            MySqlCommand command = InitCmd(sql, values);
            int rslt = command.ExecuteNonQuery();
            return rslt;
        }

        public object GetScalar(string sql, Dictionary<string, object> values)
        {
            MySqlCommand command = InitCmd(sql, values);
            object obj = command.ExecuteScalar();
            return obj;
        }

        public DataTable GetData(string sql, Dictionary<string, object> values)
        {
            MySqlCommand command = InitCmd(sql, values);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetDataByPage(string sql, Dictionary<string, object> values, PageVO page)
        {
            string totalSql = "SELECT COUNT(1) ";
            sql = sql.ToUpper();
            int findex = sql.IndexOf("FROM");
            int oindex = Regex.Replace(sql, @"ORDER\s+BY", "ORDER BY").LastIndexOf("ORDER BY");
            if (oindex > 0)
                totalSql += sql.Substring(findex, oindex - findex);
            else
                totalSql += sql.Substring(findex);
            MySqlCommand command = InitCmd(totalSql, values);
            object obj = command.ExecuteScalar();
            int total = int.Parse(obj.ToString());
            page.TotalNum = total;

            sql += " LIMIT @startNo,@pageSize";
            if (null == values)
                values = new Dictionary<string, object>();
            if (page.PageNo < 1)
                page.PageNo = 1;
            values.Add("startNo",(page.PageNo-1)*page.PageSize);
            values.Add("pageSize", page.PageSize);
            command = InitCmd(sql, values);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DbTransaction BeginTransaction(bool beginNewTrans = false)
        {
            if(beginNewTrans)
                return Connection.BeginTransaction();
            if (null == _transaction)
                _transaction = Connection.BeginTransaction();
            return _transaction;
        }

        public void RollbackTransaction(DbTransaction trans)
        {
            if (null != trans)
            {
                trans.Rollback();
                trans = null;
            }
        }

        public void RollbackTransaction()
        {
            if (null != _transaction)
            {
                _transaction.Rollback();
                _transaction = null;
            }
        }

        public void CommitTransaction(DbTransaction trans)
        {
            if (null != trans)
            {
                trans.Commit();
                trans= null;
            }
        }

        public void CommitTransaction()
        {
            if (null != _transaction)
            {
                _transaction.Commit();
                _transaction = null;
            }
        }

        public void CloseConnection()
        {
            if (null != connection && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private MySqlCommand InitCmd(string sql, Dictionary<string, object> values)
        {
            List<IDataParameter> paramList = GenParamList(values);
            MySqlCommand command = new MySqlCommand(sql, Connection);
            if (null != paramList)
                command.Parameters.AddRange(paramList.ToArray());
            if (null != _transaction)
                command.Transaction = _transaction;
            return command;
        }

        private List<IDataParameter> GenParamList(Dictionary<string, object> values)
        {
            List<IDataParameter> paramList = null;
            if (null != values)
            {
                paramList = new List<IDataParameter>();
                foreach (string key in values.Keys)
                {
                    MySqlParameter param = new MySqlParameter(key, values[key]);
                    paramList.Add(param);
                }   
            }
            return paramList;
        }

        private void Close(bool? closeFlag)
        {
            if (_transaction != null)
                return;
            if (null == closeFlag)
                closeFlag = true;
            if (closeFlag.Value)
                CloseConnection();
        }
    }
}
