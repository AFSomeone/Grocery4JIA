using System;
namespace BLL.Proxy
{
    public class TransAttr : Attribute
    {
        private string transLevel = TRANS_LEVEL.UNNEEDED;

        public string TransLevel
        {
            get
            {
                return transLevel;
            }

            set
            {
                transLevel = value;
            }
        }
    }

    public class TRANS_LEVEL
    {
        /// <summary>
        /// 无事务
        /// </summary>
        public const string UNNEEDED = "0";

        /// <summary>
        /// 当前事务
        /// </summary>
        public const string MANDATORY = "1";
    }
}