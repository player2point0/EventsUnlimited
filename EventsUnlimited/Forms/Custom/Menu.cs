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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            FrmCard Card = new FrmCard();
            Card.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer Customer = new FrmCustomer();
            Customer.Show();
            this.Hide();
        }

        private void btnCustomerOrder_Click(object sender, EventArgs e)
        {
            FrmCustomerOrder Order = new FrmCustomerOrder();
            Order.Show();
            this.Hide();
        }

        private void btnStockOrder_Click(object sender, EventArgs e)
        {
            FrmStockOrder StockOrder = new FrmStockOrder();
            StockOrder.Show();
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            FrmStaff Staff = new FrmStaff();
            Staff.Show();
            this.Hide();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FrmSupplier Supplier = new FrmSupplier();
            Supplier.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FrmStock Stock = new FrmStock();
            Stock.Show();
            this.Hide();
        }
    }
}
