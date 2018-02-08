﻿using System;
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
        private SQLManager Customer;
        private SQLManager Card;
        private SQLManager Stock;
        private SQLManager CustomerOrderStock;
        
        private int index;

        private List<string> StockIdToAdd;
        private List<string> QuantityToAdd;
        private bool newOrder;

        public FrmCustomerOrder()
        {
            InitializeComponent();

            CustomerOrder = new SQLManager("CustomerOrder", new string[] { "OrderId" }, new string[] { "OrderId", "OrderPaid", "OrderNotes", "OrderAddress", "OrderDate", "CustomerId", "CardId", "StaffId" });
            CustomerOrderControls = new Control[] { LblOrderID, CbxOrderPaid, TbxOrderNotes, TbxOrderAddress, DtpOrderDate, CbxCustomerID, CbxCardID, CbxStaffID};

            Staff = new SQLManager("Staff", new string[] { "StaffId" }, new string[] { "StaffId", "StaffName", "StaffAddress", "StaffPhoneNumber" });
            Customer = new SQLManager("Customer", new string[] { "CustomerId"}, new string[] { "CustomerId", "CustomerName", "CustomerAddress", "CustomerPhoneNumber" });
            Card = new SQLManager("CustomerCard", new string[] { "CardId" }, new string[] { "CardId", "CardNumber", "cardExpiryDate", "CardHolderName", "CardSecurityCode" });
            Stock = new SQLManager("Stock", new string[] { "StockId" }, new string[] { "StockId", "StockName" });
            CustomerOrderStock = new SQLManager("CustomerOrderStock", new string[] { "OrderId", "StockId" }, new string[] { "OrderId", "StockId", "StockQuantity" });
 
            index = 0;
            newOrder = false;
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            Staff.ReadTable();
            Staff.PopulateComboBox(ref CbxStaffID);

            Customer.ReadTable();
            Customer.PopulateComboBox(ref CbxCustomerID);

            Card.ReadTable();
            Card.PopulateComboBox(ref CbxCardID);

            Stock.ReadTable();
            Stock.PopulateComboBox(ref CbxStock);

            CustomerOrder.ReadTable();
            Print(CustomerOrder.ShowTable(ref index, ref CustomerOrderControls));
        }
        
        protected override void ClearControls()
        {
            LblOrderID.Text = CustomerOrder.GenerateNewPrimaryKey().ToString();

            StockIdToAdd = new List<string>();
            QuantityToAdd = new List<string>();

            CbxStaffID.ResetText();
            CbxCustomerID.ResetText();
            CbxCardID.ResetText();
            CbxStock.ResetText();
            NudStockQuantity.Value = 1;
            CbxOrderPaid.ResetText();
            DtpOrderDate.Value = DateTime.Now;
            TbxOrderAddress.ResetText();
            TbxOrderNotes.ResetText();
        }

        protected override void BtnNew_Click(object sender, EventArgs e)
        {
            base.BtnNew_Click(sender, e);
            newOrder = true;
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
            index++;
            Print(CustomerOrder.ShowTable(ref index, ref CustomerOrderControls));
            newOrder = false;
        }
        protected override void BtnPrevious_Click(object sender, EventArgs e)
        {
            index--;
            Print(CustomerOrder.ShowTable(ref index, ref CustomerOrderControls));
            newOrder = false;
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
