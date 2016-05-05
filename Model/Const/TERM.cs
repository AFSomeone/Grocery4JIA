using System.Collections.Generic;

namespace Model.Const
{
    public class TERM
    {
        /// <summary>
        /// 年
        /// </summary>
        public const string YEAR = "Y";

        /// <summary>
        /// 月
        /// </summary>
        public const string MONTH = "M";

        /// <summary>
        /// 日
        /// </summary>
        public const string DAY = "D";

        public static readonly Dictionary<string, string> TERM_MAP = new Dictionary<string, string> { { TERM.YEAR, "年" }, { TERM.MONTH, "月" }, { TERM.DAY, "天" } };
    }
}
