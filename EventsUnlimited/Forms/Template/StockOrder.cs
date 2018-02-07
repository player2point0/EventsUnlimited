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

            index = 0;
            newOrder = false;
        }

        private void FrmStockOrder_Load(object sender, EventArgs e)
        {
            Stock.ReadTable();
            Stock.PopulateComboBox(ref CbxStock);

            Staff.ReadTable();
            Staff.PopulateComboBox(ref CbxStaffID);
            
            StockOrder.ReadTable();
            StockOrderStock.ReadTable();

            Print(StockOrder.ShowTable(ref index, ref StockOrderControls));
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
        private bool StaffOrStockEmpty()
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
            if (StaffOrStockEmpty()) return;

            string StockOrderId = LblStockOrderID.Text;
            string StaffId = (CbxStaffID.SelectedItem as Container).Id;
            
            //save a new StockOrder
            Print(StockOrder.AddRow(new string[] { StockOrderId, DtpStockOrderDate.Value.ToString(), StaffId }));
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
            StockOrderStock.DeleteAllWith("StockOrderId", stockOrderId);
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

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FrmStockOrderReport report = new FrmStockOrderReport();
            report.Show();
        }
        private void BtnOverview_Click(object sender, EventArgs e)
        {
            //REFACTOR

            string[] columns = new string[] { "StockOrderId", "StaffId", "StaffName", "StockOrderDate", "StockId", "StockName", "StockQuantity" };

            //StockOrderId - get from form
            string StockOrderId = LblStockOrderID.Text;
            string staffId;
            string staffName;
            string stockOrderDate;
            List<string> stockId;

            if (newOrder)
            {
                if (StaffOrStockEmpty()) return;

                staffId = (CbxStaffID.SelectedItem as Container).Id;
                stockId = StockIdToAdd;
                stockOrderDate = DtpStockOrderDate.Value.ToString();
            }

            else
            {
                //get staffId from the stockOrder table
                staffId = StockOrder.GetData(new string[] { StockOrderId }, new string[] { "StaffId" })[0];
                //get the stockIds from the stockOrderStock table
                stockId = StockOrderStock.GetAllValues("StockOrderId", StockOrderId, "StockId");
                //get the stockOrderDate from the stockOrder table
                stockOrderDate = StockOrder.GetData(new string[] { StockOrderId }, new string[] { "StockOrderDate" })[0];
            }

            FrmOverview overview = new FrmOverview(columns);
            overview.Show();

            //staffName - get from staff table
            staffName = Staff.GetData(new string[] { staffId }, new string[] { "StaffName" })[0];

            for (int i = 0; i < stockId.Count; i++)
            {
                //StockName - get from stock table
                string stockName = Stock.GetData(new string[] { stockId[i] }, new string[] { "StockName" })[0];
                //stockQuantity - get from stockOrderStock table
                string stockQuantity = StockOrderStock.GetData(new string[] { StockOrderId, stockId[i] }, new string[] { "StockQuantity" })[0];

                overview.Add(new string[] { StockOrderId, staffId, staffName, stockOrderDate, stockId[i], stockName, stockQuantity });
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
            //test
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

            }
        }

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
