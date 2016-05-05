
namespace Model.Util
{
    public class StringUtil
    {
        public static string Obj2Str(object obj)
        {
            return (obj + "").Trim();
        }

        public static short Obj2Short(object obj)
        {
            return short.Parse((obj+"").Trim());
        }

        public static int Obj2Int(object obj)
        {
            return int.Parse((obj + "").Trim());
        }

        public static long Obj2Long(object obj)
        {
            return long.Parse((obj + "").Trim());
        }

        public static decimal Obj2Decimal(object obj)
        {
            return decimal.Parse((obj + "").Trim());
        }

        public static bool isEmpty(string str)
        {
            if (null == str || string.Empty == str.Trim())
                return true;
            return false;
        }
    }
}
