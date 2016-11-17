using System.Collections.Generic;

namespace Model.Const
{
    public class PAY_MODE
    {
        /// <summary>
        /// 现金
        /// </summary>
        public const string CASH = "0";

        /// <summary>
        /// 银行转账
        /// </summary>
        public const string BANK_TRANSFER = "1";

        /// <summary>
        /// 第三方平台
        /// </summary>
        public const string THIRD_PLATFORM = "2";

        public static readonly Dictionary<string, string> MODE_MAP = new Dictionary<string, string>
        {
            {PAY_MODE.CASH, "现金"},
            {PAY_MODE.BANK_TRANSFER, "银行转账"},
            {PAY_MODE.THIRD_PLATFORM, "第三方支付平台"}
        };
    }
}
