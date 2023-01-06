using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Common;

namespace WinFormsApp
{
    static class Program
    {
        public static IConfiguration Configuration;



        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            CommonConstant.ConfigureAppSettings();
            
            Application.Run(new FormMain());


        }
    }
}
