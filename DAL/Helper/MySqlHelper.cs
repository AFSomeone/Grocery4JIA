using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

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
                    String connectionString = ConfigurationManager.AppSettings["grocery_mysql"];
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

        public int ExecuteSql(string sql, Dictionary<String, object> values, bool closeFlag = true)
        {
            MySqlCommand command = InitCmd(sql, values);
            int rslt = command.ExecuteNonQuery();
            Close(closeFlag);
            return rslt;
        }

        public object GetScalar(string sql, Dictionary<String, object> values, bool closeFlag = true)
        {
            MySqlCommand command = InitCmd(sql, values);
            object obj = command.ExecuteScalar();
            Close(closeFlag);
            return obj;
        }

        public DataTable GetData(string sql, Dictionary<String, object> values, bool closeFlag = true)
        {
            MySqlCommand command = InitCmd(sql, values);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Close(closeFlag);
            return dt;
        }

        public void BeginTransaction()
        {
            _transaction = Connection.BeginTransaction();
        }

        public void RollbackTransaction()
        {
            if (null != _transaction)
            {
                _transaction.Rollback();
                _transaction = null;
                CloseConnection();
            }
        }

        public void CommitTransaction()
        {
            _transaction.Commit();
            _transaction = null;
            CloseConnection();
        }
 
        public void CloseConnection()
        {
            if (null != connection && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        public void Dispose()
        {
            if (null != connection)
                connection.Dispose();
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
