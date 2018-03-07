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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

            Control.ControlCollection controls = this.Controls;
            Program.SetColors(ref controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            Open(new FrmCard());
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Open(new FrmCustomer());
        }
        private void btnCustomerOrder_Click(object sender, EventArgs e)
        {
            Open(new FrmCustomerOrder());
        }
        private void btnStockOrder_Click(object sender, EventArgs e)
        {
            Open(new FrmStockOrder());
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            Open(new FrmStaff());
        }
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Open(new FrmSupplier());
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            Open(new FrmStock());
        }

        private void Open(Form form)
        {
            form.Show();
            this.Hide();
        }
    }
}
