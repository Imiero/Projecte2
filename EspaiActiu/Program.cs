using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EspaiActiu
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
            FormLogin login = new FormLogin();

            Application.Run(login);
            
            if (FormLogin.correcto)
            {
                Application.Run(new FormInicio());
            }
            else
            {
                Application.Exit();
            }
        
        }

    }
}
