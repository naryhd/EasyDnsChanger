using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyDnsChanger
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;

        /* If you want only one instnce of this app to run uncomment the commented  lines */

        //[DllImport("user32.dll")]
        //private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        //[DllImport("user32.dll", EntryPoint = "FindWindow")]
        //private static extern IntPtr FindWindow(string lp1, string lp2);
        //[STAThread]
        //static void Main()
        //{
        //Application.EnableVisualStyles();
        //Application.SetCompatibleTextRenderingDefault(false);
        //bool createdNew;
        //System.Threading.Mutex appMutex = new System.Threading.Mutex(true, Application.ProductName, out createdNew);
        //if (createdNew)
        //{
        //    Application.Run(new Main());
        //    appMutex.ReleaseMutex();
        //}
        //}


        /* If you uncomment mentioned lines, comment below lines */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
