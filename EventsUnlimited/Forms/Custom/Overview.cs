using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsUnlimited
{
    public partial class LsvDisplay : Form
    {
        public LsvDisplay()
        {
            InitializeComponent();

            Control.ControlCollection controls = this.Controls;
            Program.SetColors(ref controls);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
