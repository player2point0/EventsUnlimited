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
    public partial class FrmStock : FrmTemplate
    {
        SQLManager Supplier;

        public FrmStock()
        {
            InitializeComponent();

            Supplier = new SQLManager("Supplier", new string[] { "SupplierId" }, new string[] { "SupplierId", "SupplierName", "SupplierAddress", "SupplierPhoneNumber" });

            string name = "Stock";
            string[] primaryKeys = new string[] { "StockId" };
            string[] fields = new string[] { "StockId", "StockName", "StockAmount", "StockCost", "StockShelfLife", "StockDeliveryTime", "SupplierId" };
            Control[] controls = new Control[] { LblStockID, TbxStockName, TbxStockAmount, TbxStockCost, TbxStockShelfLife, TbxStockDeliveryTime, TbxSupplierID };

            base.Initialise(name, primaryKeys, fields, controls, "StockHelp.txt");
        }

        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
            PnlStockInput.Enabled = !PnlStockInput.Enabled;
        }
        
        protected override void BtnSave_Click(object sender, EventArgs e)
        {
            //check that the supplier exists before saving
            try
            {
                string supplierId = TbxSupplierID.ToString();

                if (!Supplier.Contains(new string[] { supplierId }))
                {
                    Print("Please enter an existing supplier id");
                    return;
                }

                base.BtnSave_Click(sender, e);
            }

            catch (Exception ex)
            {
                Print(ex.ToString());
            }
        }

    }
}
