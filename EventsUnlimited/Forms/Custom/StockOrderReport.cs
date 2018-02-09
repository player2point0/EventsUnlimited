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
    public partial class FrmStockOrderReport : Form
    {
        public FrmStockOrderReport()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStockOrderReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EventsUnlimitedDataSet.StockOrder' table. You can move, or remove it, as needed.
            try
            {
                this.StockOrderTableAdapter.Fill(this.EventsUnlimitedDataSet.StockOrder);
            }

            catch
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
