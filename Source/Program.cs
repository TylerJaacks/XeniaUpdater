using System;
using System.Windows.Forms;
using XeniaUpdater.Forms;
using XeniaUpdater.Source;

namespace XeniaUpdater
{
    public static class Program
    {
        public static Settings Settings = new Settings();


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
