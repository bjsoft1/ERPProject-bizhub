using ERPProject.App.Forms;
using ERPProject.App.Utilities;
using System;
using System.Windows.Forms;

namespace ERPProject.App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //TODO: make dynamic.
            ERPSqlHelper.SetConnectionString("Data Source=DESKTOP-MQ6OS8O\\SQLEXPRESS;Initial Catalog=ERP_Inventory;Integrated Security=True;TrustServerCertificate=True");

            //TODO: Make Log in form
            Application.Run(new AddUpdateOrder());
        }
    }
}
