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
    public partial class FrmCustomerOrder : FrmTemplate
    {

        private SQLManager CustomerOrder;
        private Control[] CustomerOrderControls;
        private SQLManager Staff;
        private Control[] StaffControls;
        private SQLManager Customer;
        private Control[] CustomerControls;
        private SQLManager Card;
        private Control[] CardControls;
        private SQLManager CustomerOrderStock;
        private Control[] CustomerOrderStockControls;
        
        private int index;

        private List<string> StockIdToAdd;
        private List<string> QuantityToAdd;
        private bool newOrder;

        public FrmCustomerOrder()
        {
            InitializeComponent();

            CustomerOrder = new SQLManager("OrderId", new string[] { "OrderId" }, new string[] { "OrderId", "OrderPaid", "OrderNotes", "OrderAddress", "OrderDate", "CustomerId", "CardId", "StaffId" });
            CustomerOrderControls = new Control[] { };


            index = 0;
            newOrder = false;
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {

        }

        
        public void ClearControls()
        {
            
        }

        protected override void BtnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
            PnlOrderInput.Enabled = !PnlOrderInput.Enabled;
        }
        protected override void BtnSave_Click(object sender, EventArgs e)
        {
        }
        protected override void BtnDelete_Click(object sender, EventArgs e)
        {
        }

        protected override void BtnNext_Click(object sender, EventArgs e)
        {
        }
        protected override void BtnPrevious_Click(object sender, EventArgs e)
        {
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FrmCustomerOrderReport report = new FrmCustomerOrderReport();
            report.Show();
        }
        private void BtnOverview_Click(object sender, EventArgs e)
        {

        }
        private void BtnAddStock_Click(object sender, EventArgs e)
        {

        }
        private void BtnRemoveStock_Click(object sender, EventArgs e)
        {

        }

        private void CbxStaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void CbxCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void CbxCardID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void CbxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
