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
    public partial class FrmOverview : Form
    {
        private LsvController display;

        public FrmOverview(string[] _columnNames)
        {
            InitializeComponent();
            
            display = new LsvController(ref LsvDisplay, _columnNames);
        }

        public void Add(string[] values)
        {
            display.AddRow(ref LsvDisplay, values);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
