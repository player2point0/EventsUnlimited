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
        private int id;

        public FrmStockOrderReport(string _id)
        {
            InitializeComponent();
            id = int.Parse(_id);
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
                this.StockOrderTableAdapter.Fill(this.EventsUnlimitedDataSet.StockOrder, id);
            }

            catch
            {
            }

            finally
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
