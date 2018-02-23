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
    public partial class FrmStockOrder : FrmTemplate
    {
        private SQLManager Stock;
        private SQLManager Staff;
        private SQLManager StockOrder;
        private SQLManager StockOrderStock;
        private Control[] StockOrderControls;

        private int index;

        private List<string> StockIdToAdd;
        private List<string> QuantityToAdd;
        private bool newOrder;

        public FrmStockOrder()
        {
            InitializeComponent();

            Stock = new SQLManager("Stock", new string[] { "StockId" }, new string[] { "StockId", "StockName" });
            StockOrderStock = new SQLManager("StockOrderStock", new string[] { "StockOrderId", "StockId" }, new string[] { "StockOrderId", "StockId", "StockQuantity" });
            Staff = new SQLManager("Staff", new string[] { "StaffId" }, new string[] { "StaffId", "StaffName" });

            StockOrder = new SQLManager("StockOrder", new string[] { "StockOrderId" }, new string[] { "StockOrderId", "StockOrderDate", "StaffId" });
            StockOrderControls = new Control[] { LblStockOrderID, DtpStockOrderDate , CbxStaffID};

            StockIdToAdd = new List<string>();
            QuantityToAdd = new List<string>();
            index = 0;
            newOrder = false;
            base.SetHelpFileName("StockOrderHelp.txt");
        }

        private void FrmStockOrder_Load(object sender, EventArgs e)
        {
            Stock.PopulateComboBox(ref CbxStock);
            Staff.PopulateComboBox(ref CbxStaffID);

            Print(StockOrder.ShowTable(ref index, ref StockOrderControls));
            base.SetHelpFileName("StockOrderHelp.txt");
        }

        protected override void ClearControls()
        {
            LblStockOrderID.Text = StockOrder.GenerateNewPrimaryKey().ToString();

            StockIdToAdd = new List<string>();
            QuantityToAdd = new List<string>();

            NudStockQuantity.Value = 1;
            CbxStaffID.ResetText();
            CbxStock.ResetText();
            DtpStockOrderDate.Value = DateTime.Now;
        }
        private bool EmptyFields()
        {
            if (CbxStaffID.SelectedItem == null) Print("Please select a member of staff");
            if (StockIdToAdd.Count <= 0) Print("Please add stock");

            return (CbxStaffID.SelectedItem == null) || (StockIdToAdd.Count <= 0);
        }

        protected override void BtnNew_Click(object sender, EventArgs e)
        {
            base.BtnNew_Click(sender, e);
            newOrder = true;
        }
        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
            PnlStockOrderInput.Enabled = !PnlStockOrderInput.Enabled;
        }

        protected override void BtnSave_Click(object sender, EventArgs e)
        {
            if (EmptyFields()) return;

            string StockOrderId = LblStockOrderID.Text;

            if (!newOrder)
            {
                string edit = StockOrder.EditRow(new string[] { StockOrderId }, ref StockOrderControls);

                if (edit == "") return;

                StockOrderStock.DeleteAllWith("StockOrderId", StockOrderId);

                for (int i = 0; i < StockIdToAdd.Count; i++)
                {
                    StockOrderStock.AddRow(new string[] { StockOrderId, StockIdToAdd[i], QuantityToAdd[i] });
                }

                Print(edit);

                return;
            }
            
            //save a new StockOrder
            Print(StockOrder.AddRow(ref StockOrderControls));
            //save each item of stock in the StockOrderStock table
            for (int i = 0;i< StockIdToAdd.Count;i++)
            {
                StockOrderStock.AddRow(new string[] { StockOrderId, StockIdToAdd[i], QuantityToAdd[i]});
            }

            newOrder = false;
        }
        protected override void BtnDelete_Click(object sender, EventArgs e)
        {
            string stockOrderId = LblStockOrderID.Text;

            //delete all in StockOrderStock with the stock id
            Print(StockOrderStock.DeleteAllWith("StockOrderId", stockOrderId));
            //delete record in StockOrder with the stock id
            Print(StockOrder.DeleteRow(new string[] { stockOrderId }));
            index--;
            StockOrder.ShowTable(ref index, ref StockOrderControls);
            
            newOrder = false;
        }

        protected override void BtnNext_Click(object sender, EventArgs e)
        {
            index++;
            Print(StockOrder.ShowTable(ref index, ref StockOrderControls));
            newOrder = false;
        }
        protected override void BtnPrevious_Click(object sender, EventArgs e)
        {
            index--;
            Print(StockOrder.ShowTable(ref index, ref StockOrderControls));
            newOrder = false;
        }

        private void BtnOverview_Click(object sender, EventArgs e)
        {
            string[] columns = new string[] { "StockOrderId", "StaffName", "StockOrderDate", "StockName", "StockQuantity" };

            string StockOrderId = LblStockOrderID.Text;
            string staffId;
            string staffName;
            string stockOrderDate;

            if (newOrder)
            {
                if (EmptyFields()) return;

                staffId = (CbxStaffID.SelectedItem as Container).Id;
                staffName = Staff.GetData(new string[] { staffId }, new string[] { "StaffName" })[0];
                stockOrderDate = DtpStockOrderDate.Value.ToString();
            }

            else
            {
                //NEED TO PASS IN STOCK ORDER ID AND USE IN QUERY
                FrmStockOrderReport report = new FrmStockOrderReport(StockOrderId);
                report.Show();
                return;
            }

            FrmOverview overview = new FrmOverview(columns);
            overview.Show();
            
            for (int i = 0; i < StockIdToAdd.Count; i++)
            {
                string stockName = Stock.GetData(new string[] { StockIdToAdd[i] }, new string[] { "StockName" })[0];

                overview.Add(new string[] { StockOrderId, staffName, stockOrderDate, stockName, QuantityToAdd[i] });
            }
        }
        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            Container current = (Container) CbxStock.SelectedItem;
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
        private void CbxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void CbxStaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
