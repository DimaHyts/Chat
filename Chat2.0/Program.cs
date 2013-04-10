using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
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
            
            if (new LogOnForm().ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(new UserUI(ServerConnection.Connect.GetCurrentUser())));
            }
        }
    }
}
