using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsUnlimited
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
            Application.Run(new FrmMenu());
        }

        public static string GetConnectionString()
        {
            return Properties.Settings.Default.ClientDatabaseConnection;
        }

        public static void Log(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}
