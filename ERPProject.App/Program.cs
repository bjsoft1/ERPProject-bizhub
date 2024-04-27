using ERPProject.App.Forms;
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
            //TODO: Make Log in form
            Application.Run(new Dashboard());
        }
    }
}
