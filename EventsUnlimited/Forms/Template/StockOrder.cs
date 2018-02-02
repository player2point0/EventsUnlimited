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
        private Control[] StockControls;
        private SQLManager Staff;
        private Control[] StaffControls;
        private SQLManager StockOrder;
        private Control[] StockOrderControls;
        private SQLManager StockOrderStock;
        private Control[] StockOrderStockControls;

        private int index;

        private List<string> StockId;
        private List<string> Quantity;

        public FrmStockOrder()
        {
            InitializeComponent();

            Stock = new SQLManager("Stock", new string[] { "StockId" }, new string[] { "StockId", "StockName" });
            StockControls = new Control[] { CbxStock };

            Staff = new SQLManager("Staff", new string[] { "StaffId" }, new string[] { "StaffId", "StaffName" });
            StaffControls = new Control[] { CbxStaffID };

            StockOrder = new SQLManager("StockOrder", new string[] { "StockOrderId" }, new string[] { "StockOrderId", "StockOrderDate", "staffId" });
            StockOrderControls = new Control[] { LblStockOrderID, DtpStockOrderDate , CbxStaffID};

            StockOrderStock = new SQLManager("StockOrderStock", new string[] { "StockOrderId", "StockId" }, new string[] { "StockOrderId", "StockId", "StockQuantity" });
            StockOrderStockControls = new Control[] { NudStockQuantity };

            index = 0;
            StockId = new List<string>();
            Quantity = new List<string>();
        }

        private void FrmStockOrder_Load(object sender, EventArgs e)
        {
            Stock.ReadTable();
            Print(Stock.ShowTable(ref index, ref StockControls));
            Stock.PopulateComboBox(ref CbxStock);

            Staff.ReadTable();
            Staff.PopulateComboBox(ref CbxStaffID);
            
            StockOrder.ReadTable();
            Print(StockOrder.ShowTable(ref index, ref StockOrderControls));

            StockOrderStock.ReadTable();
            Print(StockOrderStock.ShowTable(ref index, ref StockOrderStockControls));
        }

        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
            PnlStockOrderInput.Enabled = !PnlStockOrderInput.Enabled;
        }

        protected override void ClearControls()
        {
            LblStockOrderID.Text = StockOrder.GenerateNewPrimaryKey().ToString();

            StockId = new List<string>();
            Quantity = new List<string>();

            NudStockQuantity.Value = 1;
            CbxStaffID.ResetText();
            CbxStock.ResetText();
            DtpStockOrderDate.Value = DateTime.Now;
        }

        protected override void BtnSave_Click(object sender, EventArgs e)
        {
            if(CbxStaffID.SelectedItem == null)
            {
                Print("Please select a member of staff");
                return;
            }

            if(CbxStock.SelectedItem == null)
            {
                Print("Please add stock");
                return;
            }

            //save a new StockOrder
            StockOrder.AddRow(ref StockOrderControls);
            //save each item of stock in the StockOrderStock table
            string StockOrderId = LblStockOrderID.Text;

            Program.Log(StockOrderId);

            for (int i = 0;i<StockId.Count;i++)
            {
                StockOrderStock.AddRow(new string[] { StockOrderId, StockId[i], Quantity[i]});
            }
        }

        protected override void BtnDelete_Click(object sender, EventArgs e)
        {
            string stockId = LblStockOrderID.Text;

            //delete all in StockOrderStock with the stock id
            StockOrderStock.DeleteAllWith("StockId", stockId);
            //delete record in StockOrder with the stock id
            StockOrder.DeleteRow(new string[] { stockId });
        }

        protected override void BtnNext_Click(object sender, EventArgs e)
        {
            index++;
            Print(Stock.ShowTable(ref index, ref StockControls));
            Print(Staff.ShowTable(ref index, ref StaffControls));
            Print(StockOrder.ShowTable(ref index, ref StockOrderControls));
            Print(StockOrderStock.ShowTable(ref index, ref StockOrderStockControls));

            StockId = new List<string>();
            Quantity = new List<string>();
        }

        protected override void BtnPrevious_Click(object sender, EventArgs e)
        {
            index--;
            Print(Stock.ShowTable(ref index, ref StockControls));
            Print(Staff.ShowTable(ref index, ref StaffControls));
            Print(StockOrder.ShowTable(ref index, ref StockOrderControls));
            Print(StockOrderStock.ShowTable(ref index, ref StockOrderStockControls));

            StockId = new List<string>();
            Quantity = new List<string>();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FrmStockOrderReport report = new FrmStockOrderReport();
            report.Show();
        }
        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            Container current = (Container) CbxStock.SelectedItem;
            string name = current.Id;
            string value = NudStockQuantity.Value.ToString();

            StockId.Add(name);
            Quantity.Add(value);

            Print(value + " " + current.ToString() + " added");
        }
        private void BtnRemoveStock_Click(object sender, EventArgs e)
        {
            try
            {
                Container current = (Container)CbxStock.SelectedItem;
                string name = current.Id;
                int index = StockId.IndexOf(name);

                StockId.RemoveAt(index);
                Quantity.RemoveAt(index);
                Print(current.ToString() + " removed");
            }

            catch
            {

            }
        }
        private void BtnOverview_Click(object sender, EventArgs e)
        {
            FrmOverview overview = new FrmOverview();
            overview.Show();
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
