using Model.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace DAL
{
    abstract class BaseConnector
    {
        /// <summary>
        /// 根据数据行构造泛型实体
        /// </summary>
        /// <typeparam name="T">返回的实体类型</typeparam>
        /// <param name="row">数据行</param>
        /// <returns>已赋值的Model实体对象</returns>
        public T RowToModel<T>(DataRow row) where T : new()
        {
            T result = default(T);
            Type rstType = typeof(T);
            PropertyInfo[] properties = rstType.GetProperties();
            foreach (var item in properties)
            {
                string pName = item.Name;
                if (pName.StartsWith("_"))
                    pName = pName.Substring(1);
                if (pName.EndsWith("__PK"))
                    pName = pName.Replace("__PK", "");

                if (!row.Table.Columns.Contains(pName))
                    continue;

                if ((Convert.ToString(row[pName])+"").Length ==0)
                    continue;

                if (EqualityComparer<T>.Default.Equals(result, default(T)))
                    result = new T();

                /*
                //字符串类型
                if (item.PropertyType == typeof(string))
                    item.SetValue(result, row[pName], null);
                //短整型
                else if (item.PropertyType == typeof(short) || item.PropertyType == typeof(short?))
                    item.SetValue(result, row[pName], null);
                //整型
                else if (item.PropertyType == typeof(int) || item.PropertyType == typeof(int?))
                    item.SetValue(result, row[pName], null);
                //长整型
                else if (item.PropertyType == typeof(long) || item.PropertyType == typeof(long?))
                    item.SetValue(result, row[pName], null);
                //时间
                else if (item.PropertyType == typeof(DateTime) || item.PropertyType == typeof(DateTime?))
                {
                    DateTime outtime;
                    string datetime = row[pName].ToString();
                    DateTime.TryParse(datetime, out outtime);
                    item.SetValue(result, outtime, null);
                }
                //双精度
                else if (item.PropertyType == typeof(double) || item.PropertyType == typeof(double?))
                    item.SetValue(result, row[pName], null);
                //十进制实数
                else if (item.PropertyType == typeof(decimal) || item.PropertyType == typeof(decimal?))
                    item.SetValue(result, row[pName], null);
                */

                if (item.PropertyType == typeof(DateTime) || item.PropertyType == typeof(DateTime?))
                {
                    DateTime outtime;
                    string datetime = row[pName].ToString();
                    DateTime.TryParse(datetime, out outtime);
                    item.SetValue(result, outtime, null);
                }
                else
                    item.SetValue(result, row[pName], null);
            }
            return result;
        }

        /// <summary>
        /// 获取insert操作的sql&parameters
        /// </summary>
        /// <typeparam name="T">泛型实体类型</typeparam>
        /// <param name="t">实例</param>
        /// <param name="sqlStr">自动拼接sql串</param>
        /// <returns>sql参数列表</returns>
        public Dictionary<String, object> GenSaveModelSqlStr<T>(T t, out string sqlStr) where T : new()
        {
            string tablename = string.Empty;
            Type type = typeof(T);
            StringBuilder fieldsStrbr = new StringBuilder();
            StringBuilder valuesStrbr = new StringBuilder();
            foreach (FieldInfo info in type.GetFields())
            {
                if ("__table" == info.Name)
                {
                    tablename = info.GetValue(t).ToString();
                    break;
                }
            }

            Dictionary<String, object> values = new Dictionary<string, object>();
            foreach (PropertyInfo info in type.GetProperties())
            {
                string pName = info.Name;
                if (pName.StartsWith("_"))
                    continue;
                else if (pName.EndsWith("__PK"))
                    pName = pName.Replace("__PK", "");

                if (null != info.GetValue(t, null))
                {
                    if (fieldsStrbr.Length == 0)
                    {
                        fieldsStrbr.Append(info.Name);
                        valuesStrbr.AppendFormat("@{0}", info.Name);
                    }
                    else
                    {
                        fieldsStrbr.AppendFormat(",{0}", info.Name);
                        valuesStrbr.AppendFormat(",@{0}", info.Name);
                    }
                    values.Add(info.Name, info.GetValue(t, null));
                }
            }
            if (fieldsStrbr.Length == 0)
                sqlStr = string.Empty;
            else
                sqlStr = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", tablename, fieldsStrbr.ToString(), valuesStrbr.ToString());
            return values;
        }

        /// <summary>
        /// 获取insert操作的sql&parameters（自带计算主键ID（max+1））
        /// </summary>
        /// <typeparam name="T">model 类型</typeparam>
        /// <param name="t">model 实例</param>
        /// <param name="sqlStr">自动拼接sql</param>
        /// <returns>sql参数</returns>
        public Dictionary<String, object> GenAutoCalcIDSaveModelSqlStr<T>(T t, out string sqlStr) where T : new()
        {
            string tablename = string.Empty;
            int baseId = 1;
            Type type = typeof(T);
            StringBuilder fieldsStrbr = new StringBuilder();
            StringBuilder valuesStrbr = new StringBuilder();
            foreach (FieldInfo info in type.GetFields())
            {
                if ("__table" == info.Name)
                {
                    tablename = info.GetValue(t).ToString();
                }

                if ("__baseId" == info.Name)
                {
                    baseId = StringUtil.Obj2Int(info.GetValue(t));
                }

            }

            Dictionary<String, object> values = new Dictionary<string, object>();
            foreach (PropertyInfo info in type.GetProperties())
            {
                string pName = info.Name;
                bool isPk = false;
                if (pName.StartsWith("_"))
                    continue;
                else if (pName.EndsWith("__PK"))
                {
                    pName = pName.Replace("__PK", "");
                    isPk = true;
                    bool typeFlag = false;
                    if (info.PropertyType.Equals(typeof(short)) || info.PropertyType.Equals(typeof(short?)))
                        typeFlag = true;
                    else if (info.PropertyType.Equals(typeof(int)) || info.PropertyType.Equals(typeof(int?)))
                        typeFlag = true;
                    else if (info.PropertyType.Equals(typeof(long)) || info.PropertyType.Equals(typeof(long?)))
                        typeFlag = true;

                    if(!typeFlag)
                        throw new Exception(info.Name + " must be typeof int!");
                }
                    

                if (null != info.GetValue(t, null))
                {
                    if (fieldsStrbr.Length == 0)
                    {
                        fieldsStrbr.Append(pName);
                        if (isPk)
                        {
                            valuesStrbr.AppendFormat("CASE WHEN MAX({0}) IS NULL THEN @baseId ELSE MAX({1})+1 END", pName, pName);
                            values.Add("baseId", baseId);
                        }
                        else
                            valuesStrbr.AppendFormat("@{0}", pName);
                    }
                    else
                    {
                        fieldsStrbr.AppendFormat(",{0}", pName);
                        if (isPk)
                        {
                            valuesStrbr.AppendFormat(",CASE WHEN MAX({0}) IS NULL THEN @baseId ELSE MAX({1})+1 END", pName, pName);
                            values.Add("baseId", baseId);
                        }
                        else
                            valuesStrbr.AppendFormat(",@{0}", pName);
                    }
                    values.Add(pName, info.GetValue(t, null));
                }
            }
            if (fieldsStrbr.Length == 0)
                sqlStr = string.Empty;
            else
                sqlStr = string.Format("INSERT INTO {0} ({1}) SELECT {2} FROM {3}", tablename, fieldsStrbr.ToString(), valuesStrbr.ToString(), tablename);
            return values;
        }

        /// <summary>
        /// 获取update操作的sql&parameters
        /// </summary>
        /// <typeparam name="T">model 类型</typeparam>
        /// <param name="t">model 实例</param>
        /// <param name="sqlStr">自动拼接sql</param>
        /// <returns>sql参数</returns>
        public Dictionary<string, object> GenUpdateModelSqlStr<T>(T t, out string sqlStr) where T : new()
        {
            string tablename = string.Empty;
            Type type = typeof(T);
            StringBuilder setStrbr = new StringBuilder();
            StringBuilder whereStrbr = new StringBuilder();
            foreach (FieldInfo info in type.GetFields())
            {
                if ("__table" == info.Name)
                {
                    tablename = info.GetValue(t).ToString();
                    break;
                }
            }

            Dictionary<string, object> values = new Dictionary<string, object>();
            foreach (PropertyInfo info in type.GetProperties())
            {
                string pName = info.Name;
                bool isPk = false;
                if (pName.StartsWith("_"))
                    pName = pName.Substring(1);
                if (pName.EndsWith("__PK"))
                {
                    pName = pName.Replace("__PK", "");
                    isPk = true;
                }

                if (null != info.GetValue(t, null))
                {
                    if (isPk)
                    {
                        if (whereStrbr.Length == 0)
                            whereStrbr.AppendFormat("{0}=@{1} ", pName, pName);
                        else
                            whereStrbr.AppendFormat("AND {0}=@{1}", pName, pName);
                    }
                    else
                    {
                        if (setStrbr.Length == 0)
                            setStrbr.AppendFormat("{0}=@{1}", pName, pName);
                        else
                            setStrbr.AppendFormat(",{0}=@{1}", pName, pName);

                    }
                    values.Add(pName, info.GetValue(t, null));
                }
            }
            if (setStrbr.Length == 0)
                sqlStr = string.Empty;
            else
                sqlStr = string.Format("UPDATE {0} SET {1} WHERE {2}", tablename, setStrbr, whereStrbr.ToString());
            return values;
        }
    }
}