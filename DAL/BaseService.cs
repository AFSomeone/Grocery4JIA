using DAL.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
