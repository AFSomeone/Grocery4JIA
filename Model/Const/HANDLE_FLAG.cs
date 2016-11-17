
using System.Collections.Generic;

namespace Model.Const
{
    public class HANDLE_FLAG
    {
        /// <summary>
        /// 已处理
        /// </summary>
        public const string HANDLED = "1";

        /// <summary>
        /// 未处理
        /// </summary>
        public const string UNHANDLED = "0";

        public static readonly Dictionary<string, string> HANDLE_MAP = new Dictionary<string, string>
        {
            {HANDLE_FLAG.HANDLED, "已入账"},
            {HANDLE_FLAG.UNHANDLED, "未入账"}
        };
    }
}
