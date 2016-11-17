
using System.Collections.Generic;

namespace Model.Const
{
    public class ACNT_TYPE
    {
        /// <summary>
        /// 银行账户
        /// </summary>
        public const string BANCK_NO = "1";

        /// <summary>
        /// 第三方平台
        /// </summary>
        public const string THIRD_PLATFORM = "2";

        public static readonly Dictionary<string, string> ACNT_MAP = new Dictionary<string, string> { { ACNT_TYPE.BANCK_NO, "银行账户" }, { ACNT_TYPE.THIRD_PLATFORM, "第三方支付平台" } };
    }
}
