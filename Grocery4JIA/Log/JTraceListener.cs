using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace JLog
{
    public class JTraceListener : TraceListener
    {
        public override void Write(string message)
        {
            WriteLine(message);
        }

        public override void WriteLine(string message)
        {
            string exeDir = Application.StartupPath;
            string logDir = exeDir + "\\Logs";
            Directory.CreateDirectory(logDir);
            string logfile = logDir+"\\"+DateTime.Now.ToString("yyyyMMdd")+".log";
            string msg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss     ") + message + Environment.NewLine;
            if (!File.Exists(logfile))
            {
                using (StreamWriter sw = File.CreateText(logfile))
                {
                    sw.WriteLine(msg);
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(logfile))
                {
                    sw.WriteLine(msg);
                    sw.Close();
                }
            }
        }
    }
}
