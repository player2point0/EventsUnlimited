using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EventsUnlimited
{
    public partial class FrmHelp : Form
    {
        private string helpFileName;

        public FrmHelp(string _helpFileName)
        {
            InitializeComponent();

            Control.ControlCollection controls = this.Controls;
            Program.SetColors(ref controls);

            helpFileName = _helpFileName;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHelp_Load(object sender, EventArgs e)
        {
            TbxHelpText.Text = File.ReadAllText("Help Text\\"+helpFileName);
        }
    }
}
