using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Const
{
    public class ST
    {
        /// <summary>
        /// 正常
        /// </summary>
        public const string VALID = "1";

        /// <summary>
        /// 废弃
        /// </summary>
        public const string INVALID = "0";

        /// <summary>
        /// 分类状态
        /// </summary>
        public static readonly Dictionary<string, string> CATG_MAP = new Dictionary<string, string> { { ST.VALID, "有效" }, { ST.INVALID, "废弃" } };

        /// <summary>
        /// 用户状态
        /// </summary>
        public static readonly Dictionary<string, string> USR_MAP = new Dictionary<string, string> { { ST.VALID, "可用" }, { ST.INVALID, "锁定" } };

        /// <summary>
        /// 商品状态
        /// </summary>
        public static readonly Dictionary<string, string> GOODS_MAP = new Dictionary<string, string> { { ST.VALID, "有效" }, { ST.INVALID, "下架" } };

        /// <summary>
        /// 客户状态
        /// </summary>
        public static readonly Dictionary<string, string> CUST_MAP = new Dictionary<string, string> { { ST.VALID, "可用" }, { ST.INVALID, "废弃" } };
    }
}
