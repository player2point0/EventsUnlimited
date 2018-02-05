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

        private List<string> StockIdToAdd;
        private List<string> QuantityToAdd;

        public FrmStockOrder()
        {
            InitializeComponent();

            Stock = new SQLManager("Stock", new string[] { "StockId" }, new string[] { "StockId", "StockName" });
            StockControls = new Control[] { CbxStock };

            Staff = new SQLManager("Staff", new string[] { "StaffId" }, new string[] { "StaffId", "StaffName" });
            StaffControls = new Control[] { CbxStaffID };

            StockOrder = new SQLManager("StockOrder", new string[] { "StockOrderId" }, new string[] { "StockOrderId", "StockOrderDate", "StaffId" });
            StockOrderControls = new Control[] { LblStockOrderID, DtpStockOrderDate , CbxStaffID};

            StockOrderStock = new SQLManager("StockOrderStock", new string[] { "StockOrderId", "StockId" }, new string[] { "StockOrderId", "StockId", "StockQuantity" });
            StockOrderStockControls = new Control[] { NudStockQuantity };

            index = 0;
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
        
        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
            PnlStockOrderInput.Enabled = !PnlStockOrderInput.Enabled;
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

            string StockOrderId = LblStockOrderID.Text;
            string StaffId = (CbxStaffID.SelectedItem as Container).Id;
            
            //save a new StockOrder
            Print(StockOrder.AddRow(new string[] { StockOrderId, DtpStockOrderDate.Value.ToString(), StaffId }));
            //save each item of stock in the StockOrderStock table
            for (int i = 0;i< StockIdToAdd.Count;i++)
            {
                StockOrderStock.AddRow(new string[] { StockOrderId, StockIdToAdd[i], QuantityToAdd[i]});
            }
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
        }

        protected override void BtnNext_Click(object sender, EventArgs e)
        {
            index++;
            Print(StockOrder.ShowTable(ref index, ref StockOrderControls));
        }
        protected override void BtnPrevious_Click(object sender, EventArgs e)
        {
            index--;
            Print(StockOrder.ShowTable(ref index, ref StockOrderControls));
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
