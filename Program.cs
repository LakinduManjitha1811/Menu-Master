using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MENU_MASTER_RESTAURENT;

namespace MENU_MASTER_RESTAURENT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Loginform LF = new Loginform();
            LF.Show();
            Application.Run();
        }
    }
}
