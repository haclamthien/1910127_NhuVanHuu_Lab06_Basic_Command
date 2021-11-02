using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_Basic_Command
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
            //Application.Run(new BillForm());
            //Application.Run(new Form1());
            //Application.Run(new AccountManagementForm());
            //Application.Run(new TableForm());
            //Application.Run(new BillFrom2());
            Application.Run(new AdminForm());
        }
    }
}
