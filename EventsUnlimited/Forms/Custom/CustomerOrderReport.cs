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
    public partial class FrmCustomerOrderReport : Form
    {
        public FrmCustomerOrderReport()
        {
            InitializeComponent();
        }

        private void CustomerOrderReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EventsUnlimitedDataSet.CustomerOrder' table. You can move, or remove it, as needed.
            this.CustomerOrderTableAdapter.Fill(this.EventsUnlimitedDataSet.CustomerOrder);

            this.reportViewer1.RefreshReport();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
