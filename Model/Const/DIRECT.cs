
using System.Collections.Generic;

namespace Model.Const
{
    public class DIRECT
    {
        /// <summary>
        /// 存库
        /// </summary>
        public const string STOCK_IN = "1";

        /// <summary>
        /// 退回供应商
        /// </summary>
        public const string REFUND2SUPPLIER = "-1";

        /// <summary>
        /// 出库
        /// </summary>
        public const string STOCK_OUT = "2";

        /// <summary>
        /// 分销商退货
        /// </summary>
        public const string RESELLER_REFUND = "-2";

        /// <summary>
        /// 盘点修正
        /// </summary>
        public const string STOCKTAKING = "0";

        public static readonly Dictionary<string, string> DIRECT_MAP = new Dictionary<string, string>
        {
            {DIRECT.STOCK_IN, "进货"},
            {DIRECT.STOCK_OUT, "出货"},
            {DIRECT.REFUND2SUPPLIER, "退货"},
            {DIRECT.RESELLER_REFUND, "回收"},
            {DIRECT.STOCKTAKING, "盘点"}
        };
    }
}
