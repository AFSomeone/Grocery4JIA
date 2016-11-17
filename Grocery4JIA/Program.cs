using JLog;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using UI;

namespace Grocery4JIA
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //清除系统监听器(就是输出到Console的那个)
            Trace.Listeners.Clear(); 
            Trace.Listeners.Add(new JTraceListener());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
