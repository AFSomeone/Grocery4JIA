using Castle.DynamicProxy;
using DAL.Helper;
using Model.Entity;
using Model.Exception;
using Model.Util;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;

namespace BLL.Proxy
{
    public static class InterfaceProxyGenerator
    {
        public static TInterface CreateInterfaceProxy<TInterface>(Usr usr) where TInterface : class
        {
            ProxyGenerator generator = new ProxyGenerator();
            string tname = typeof(TInterface).Name;
            NameValueCollection mgrs = (NameValueCollection)ConfigurationManager.GetSection("ManagerGroup/Interface");
            string implName = mgrs[tname];
            if (StringUtil.isEmpty(implName))
            {
                implName = tname.Substring(1);
            }
            string nms = ConfigurationManager.AppSettings["mgrImplNamespace"];
            string implFullName = nms +"."+ implName;
            int? connId = ConnectorFactory.GenConnector();
            if (null == connId)
                return null;
            TInterface target = (TInterface)Activator.CreateInstance(Type.GetType(implFullName),new object[] { connId });
            return generator.CreateInterfaceProxyWithTarget<TInterface>(target, new MgrInterceptor(connId, implFullName));
        }
    }

    class MgrInterceptor : IInterceptor
    {
        int connId;
        string mgrNm;
        public MgrInterceptor(int? connId , string mgrNm)
        {
            this.connId = (int)connId;
            this.mgrNm = mgrNm;
        }
        public void Intercept(IInvocation invocation)
        {
            string level = null;
            try
            {
                
                foreach (Attribute attr in Attribute.GetCustomAttributes(invocation.MethodInvocationTarget))
                {
                    if (attr.GetType() == typeof(TransAttr))
                    {
                        level = ((TransAttr)attr).TransLevel;
                    }
                }

                if (TRANS_LEVEL.MANDATORY == level)
                    ConnectorFactory.ProceedInTransaction(invocation, connId);
                else
                    invocation.Proceed();
            }
            catch (JException je)
            {
                throw je;
            }
            catch (Exception e)
            {
                string mthod = invocation.Method.Name;
                //记录日志
                Trace.TraceError("【"+mgrNm+"."+mthod+"】 " + e.StackTrace);
                JException je = new JException();
                je.JCode = "JE-000";
                throw je;
            }
        }
    }
}