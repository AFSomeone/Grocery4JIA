using Model.Util;
using System.Collections.Specialized;
using System.Configuration;

namespace Model.Exception
{
    public class JException : System.Exception
    {
        private string jcode;
        private string jmsg;

        public JException(string jcode)
        {
            this.jcode = jcode;
        }

        public JException() {}

        public string JCode
        {
            get
            {
                return jcode;
            }

            set
            {
                jcode = value;
            }
        }

        public override string Message
        {
            get
            {
                try
                {
                    NameValueCollection jcodeSection = (NameValueCollection)ConfigurationManager.GetSection("JCodeGroup/JCode");
                    jmsg = jcodeSection[jcode];
                }
                catch
                { }
                if (StringUtil.isEmpty(jmsg))
                    jmsg = jcode;
                return jmsg;
            }
        }
    }
}
