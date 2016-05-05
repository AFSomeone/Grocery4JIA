using System.Collections.Generic;

namespace Model.Const
{
    public class GRADE
    {
        /// <summary>
        /// 上游（供应）
        /// </summary>
        public const string SUPPLIER = "0";

        /// <summary>
        /// 下游（分销）
        /// </summary>
        public const string RESELLER = "1";

        public static readonly Dictionary<string, string> GRADE_MAP = new Dictionary<string, string> { { GRADE.SUPPLIER, "上游" }, { GRADE.RESELLER, "下游" } };
    }
}
