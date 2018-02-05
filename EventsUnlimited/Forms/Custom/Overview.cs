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
        private string id;
        private string[] columnNames;
        

        public FrmOverview(string _id, string[] _columnNames)
        {
            InitializeComponent();

            id = _id;
            columnNames = _columnNames;




        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
