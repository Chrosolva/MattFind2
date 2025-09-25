using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master;
using Master.Controller;

namespace WBPOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("id-ID");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Master.FormLogin().ShowDialog();
            //Application.Run(new WBPOS.View.MainMDI());
            Application.Run(new WBPOS.View.ModernMainMDI());
        }
    }
}
