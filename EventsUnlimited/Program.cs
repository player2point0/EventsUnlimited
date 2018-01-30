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

        public static void SetColors(ref Control.ControlCollection controls)
        {
            foreach(Control c in controls)
            {
                Log(c.Name);

                if(c.HasChildren)
                {
                    //recursion
                    Control.ControlCollection _controls = c.Controls;
                    SetColors(ref _controls);
                }

                try
                {
                    string tag = c.Tag.ToString();
                    char type = tag[0];
                    char color = tag[1];

                    switch (color)
                    {
                        case '1':
                            if (type == 'f') c.ForeColor = Properties.Settings.Default.color1;
                            else c.BackColor = Properties.Settings.Default.color1;
                            break;
                        case '2':
                            if (type == 'f') c.ForeColor = Properties.Settings.Default.color2;
                            else c.BackColor = Properties.Settings.Default.color2;
                            break;
                        case '3':
                            if (type == 'f') c.ForeColor = Properties.Settings.Default.color3;
                            else c.BackColor = Properties.Settings.Default.color3;
                            break;
                        case '4':
                            if (type == 'f') c.ForeColor = Properties.Settings.Default.color4;
                            else c.BackColor = Properties.Settings.Default.color4;
                            break;
                        case '5':
                            if (type == 'f') c.ForeColor = Properties.Settings.Default.color5;
                            else c.BackColor = Properties.Settings.Default.color5;
                            break;
                    }
                }

                catch
                {
                    //DO NOTHING
                }

            }
        }

    }
}
