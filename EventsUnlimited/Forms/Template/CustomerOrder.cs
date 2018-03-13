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

            DtpOrderDate.MinDate = DateTime.Now;

            CustomerOrder = new SQLManager("CustomerOrder", new string[] { "OrderId" }, new string[] { "OrderId", "OrderPaid", "OrderNotes", "OrderAddress", "OrderDate", "CustomerId", "CardId", "StaffId" });
            CustomerOrderControls = new Control[] { LblOrderID, CbxOrderPaid, TbxOrderNotes, TbxOrderAddress, DtpOrderDate, CbxCustomerID, CbxCardID, CbxStaffID};

            Staff = new SQLManager("Staff", new string[] { "StaffId" }, new string[] { "StaffId", "StaffName", "StaffAddress", "StaffPhoneNumber" });
            Customer = new SQLManager("Customer", new string[] { "CustomerId"}, new string[] { "CustomerId", "CustomerName", "CustomerAddress", "CustomerPhoneNumber" });
            Card = new SQLManager("CustomerCard", new string[] { "CardId" }, new string[] { "CardId", "CardNumber", "cardExpiryDate", "CardHolderName", "CardSecurityCode" });
            Stock = new SQLManager("Stock", new string[] { "StockId" }, new string[] { "StockId", "StockName" });
            CustomerOrderStock = new SQLManager("CustomerOrderStock", new string[] { "OrderId", "StockId" }, new string[] { "OrderId", "StockId", "StockQuantity" });

            StockIdToAdd = new List<string>();
            QuantityToAdd = new List<string>();
            index = 0;
            newOrder = false;
            base.SetHelpFileName("OrderHelp.txt");
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            Staff.PopulateComboBox(ref CbxStaffID);
            Customer.PopulateComboBox(ref CbxCustomerID);
            Card.PopulateComboBox(ref CbxCardID);
            Stock.PopulateComboBox(ref CbxStock);

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
            CbxOrderPaid.Checked = false;
            DtpOrderDate.Value = DateTime.Now;
            TbxOrderAddress.ResetText();
            TbxOrderNotes.ResetText();
        }
        public bool EmptyFields()
        {
            bool staff = CbxStaffID.SelectedItem == null;
            bool customer = CbxCustomerID.SelectedItem == null;
            bool card = CbxCardID.SelectedItem == null;
            bool stock = StockIdToAdd.Count <= 0;

            if (stock) Print("Please add stock");
            if (staff) Print("Please select a member of staff");
            if (customer) Print("Please select a customer");
            if (card) Print("Please select a card");

            return stock || staff || customer || card;
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
            if (EmptyFields()) return;

            string CustomerOrderId = LblOrderID.Text;

            if (!newOrder)
            {
                string edit = CustomerOrder.EditRow(new string[] { CustomerOrderId }, ref CustomerOrderControls);

                if (edit == "") return;

                CustomerOrderStock.DeleteAllWith("OrderId", CustomerOrderId);

                for (int i = 0; i < StockIdToAdd.Count; i++)
                {
                    CustomerOrderStock.AddRow(new string[] { CustomerOrderId, StockIdToAdd[i], QuantityToAdd[i] });
                }

                Print(edit);

                return;
            }

            Print(CustomerOrder.AddRow(ref CustomerOrderControls));

            for(int i = 0;i<StockIdToAdd.Count;i++)
            {
                CustomerOrderStock.AddRow(new string[] { CustomerOrderId, StockIdToAdd[i], QuantityToAdd[i] });
            }

            newOrder = false;
        }
        protected override void BtnDelete_Click(object sender, EventArgs e)
        {
            string CustomerOrderId = LblOrderID.Text;

            Print(CustomerOrderStock.DeleteAllWith("OrderId", CustomerOrderId));
            Print(CustomerOrder.DeleteRow(new string[] { CustomerOrderId }));

            index--;
            CustomerOrder.ShowTable(ref index, ref CustomerOrderControls);

            newOrder = false;
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
        
        private void BtnOverview_Click(object sender, EventArgs e)
        {   
            string[] columns = new string[] { "OrderId", "StaffName", "CustomerName", "CardNumber", "OrderPaid", "OrderAddress", "OrderDate", "StockName", "StockQuantity" };

            string CustomerOrderId = LblOrderID.Text;
            string staffId;
            string customerId;
            string cardId;
            string orderPaid;
            string orderAddress;
            string OrderDate;

            if(newOrder)
            {
                if (EmptyFields()) return;

                staffId = (CbxStaffID.SelectedItem as Container).Id;
                customerId = (CbxCustomerID.SelectedItem as Container).Id;
                cardId = (CbxCardID.SelectedItem as Container).Id;

                orderPaid = CbxOrderPaid.Checked.ToString();
                orderAddress = TbxOrderAddress.ToString();
                OrderDate = DtpOrderDate.Value.ToString();
            }

            else
            {
                //NEED TO PASS IN CUSTOMER ORDER ID AND USE IN QUERY
                FrmCustomerOrderReport report = new FrmCustomerOrderReport(CustomerOrderId);
                report.Show();
                return;
            }

            FrmOverview overview = new FrmOverview(columns);
            overview.Show();

            string staffName = Staff.GetData(new string[] { staffId }, new string[] { "StaffName" })[0];
            string customerName = Customer.GetData(new string[] { customerId }, new string[] { "CustomerName" })[0];
            string cardNumber = Card.GetData(new string[] { cardId }, new string[] { "CardNumber" })[0];

            for (int i = 0; i < StockIdToAdd.Count; i++)
            {
                string stockName = Stock.GetData(new string[] { StockIdToAdd[i] }, new string[] { "StockName" })[0];

                overview.Add(new string[] { CustomerOrderId, staffName, customerName, cardNumber, orderPaid, orderAddress, OrderDate, stockName, QuantityToAdd[i]});
            }
        }
        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            Container current = (Container)CbxStock.SelectedItem;
            string name = current.Id;
            string value = NudStockQuantity.Value.ToString();

            StockIdToAdd.Add(name);
            QuantityToAdd.Add(value);

            Print(value + " " + current.ToString() + " added");
        }
        private void BtnRemoveStock_Click(object sender, EventArgs e)
        {
            try
            {
                Container current = (Container)CbxStock.SelectedItem;
                string name = current.Id;
                int index = StockIdToAdd.IndexOf(name);

                StockIdToAdd.RemoveAt(index);
                QuantityToAdd.RemoveAt(index);
                Print(current.ToString() + " removed");
            }

            catch
            {
                Print("No stock selected");
            }
        }
        //PREVENTS TYPING IN THE COMBO BOXES
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
