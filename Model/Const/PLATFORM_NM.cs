using System.Collections.Generic;

namespace Model.Const
{
    public class PLATFORM_NM
    {
        /// <summary>
        /// 其他
        /// </summary>
        public const string OTHER = "0";

        /// <summary>
        /// 支付宝
        /// </summary>
        public const string ALIPAY = "1";

        /// <summary>
        /// 财付通
        /// </summary>
        public const string TENPAY = "2";

        /// <summary>
        /// apple pay
        /// </summary>
        public const string APPLEPAY = "3";

        /// <summary>
        /// 99bill 快钱
        /// </summary>
        public const string BILL99 = "4";

        /// <summary>
        /// 京东钱包
        /// </summary>
        public const string JDPAY = "5";

        public static readonly Dictionary<string, string> PLATFORM_MAP = new Dictionary<string, string>
        {
            {PLATFORM_NM.OTHER, "其他"},
            {PLATFORM_NM.ALIPAY, "支付宝"},
            {PLATFORM_NM.TENPAY, "微信"},
            {PLATFORM_NM.APPLEPAY, "苹果支付"},
            {PLATFORM_NM.BILL99, "快钱"},
            {PLATFORM_NM.JDPAY, "京东支付"}
        };
    }
}
