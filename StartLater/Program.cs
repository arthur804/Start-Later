using System;
using System.Threading;
using System.Windows.Forms;

namespace StartLater
{
    static class Program
    {
        public static ArthurTimerData Timer { get; internal set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            if(Timer != null)
            {
                Thread.Sleep(Timer.Millseconds);
                Timer.Action.Invoke(Timer.text);
            }
        }
    }
}
