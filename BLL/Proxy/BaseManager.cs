using DAL;
using DAL.Helper;
using System;

namespace BLL.Proxy
{
    public class BaseManager
    {
        int connectorId;

        internal int ConnectorId
        {
            get
            {
                return connectorId;
            }
        }

        internal BaseService CreateService(Type T, int connectorId)
        {
            BaseService _service = (BaseService)T.GetConstructors()[0].Invoke(null);
            _service.ConnectorId = connectorId;
            this.connectorId = connectorId;
            return _service;
        }

        public void close()
        {
            ConnectorFactory.CloseConnector(connectorId);
        }

    }
}
