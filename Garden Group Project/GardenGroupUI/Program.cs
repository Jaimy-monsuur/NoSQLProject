using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace GardenGroupUI
{
    static class Program
    {      
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static User loggedInUser;
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());            
        }
    }
}
