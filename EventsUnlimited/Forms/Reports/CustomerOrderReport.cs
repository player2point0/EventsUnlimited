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
        private int id;

        public FrmCustomerOrderReport(string _id)
        {
            InitializeComponent();
            id = int.Parse(_id);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustomerOrderReport_Load(object sender, EventArgs e)
        {
            try
            {
                this.CustomerOrderTableAdapter.Fill(this.EventsUnlimitedDataSet.CustomerOrder, id);
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
