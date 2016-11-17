using DAL.Helper;

namespace DAL
{
    public class BaseService
    {
        private DbConnector _connector;
        private int connectorId;

        internal DbConnector Connector
        {
            get
            {
                _connector = ConnectorFactory.GetConnector(connectorId);
                return _connector;
            }

            set
            {
                _connector = value;
            }
        }

        public int ConnectorId
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
    }
}
