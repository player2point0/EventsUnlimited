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

        private void StockOrderReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EventsUnlimitedDataSet.StockOrder' table. You can move, or remove it, as needed.
            this.StockOrderTableAdapter.Fill(this.EventsUnlimitedDataSet.StockOrder);

            this.reportViewer.RefreshReport();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
