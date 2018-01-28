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
        public FrmStock()
        {
            InitializeComponent();

            string name = "Stock";
            string[] primaryKeys = new string[] { "StockId" };
            string[] fields = new string[] { "StockId", "StockName", "StockAmount", "StockCost", "StockShelfLife", "StockDeliveryTime", "SupplierId" };
            Control[] controls = new Control[] { LblStockID, TbxStockName, TbxStockAmount, TbxStockCost, TbxStockShelfLife, TbxStockDeliveryTime, CbxSupplierID };

            base.Initialise(name, primaryKeys, fields, controls, "StockHelp.txt");
        }

        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
            PnlStockInput.Enabled = !PnlStockInput.Enabled;
        }
    }
}
