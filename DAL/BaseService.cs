using DAL.Helper;

namespace DAL
{
    public class BaseService
    {
        private DbConnector _connector;

        public BaseService()
        {
            if (null == Connector)
                Connector = ConnectorFactory.CreatConnector();
        }

        internal DbConnector Connector
        {
            get
            {
                return _connector;
            }

            set
            {
                _connector = value;
            }
        }
    }
}
