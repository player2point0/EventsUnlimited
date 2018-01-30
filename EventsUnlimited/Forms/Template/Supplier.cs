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
    public partial class FrmSupplier : FrmTemplate
    {
        public FrmSupplier()
        {
            InitializeComponent();

            Control.ControlCollection _controls = this.Controls;
            Program.SetColors(ref _controls);

            string name = "Supplier";
            string[] primaryKeys = new string[] { "SupplierId" };
            string[] fields = new string[] { "SupplierId", "SupplierName", "SupplierAddress", "SupplierPhoneNumber" };
            Control[] controls = new Control[] { LblSupplierID, TbxSupplierName, TbxSupplierAddress, TbxSupplierPhoneNumber };

            base.Initialise(name, primaryKeys, fields, controls, "SupplierHelp.txt");
        }

        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
            PnlSupplierInput.Enabled = !PnlSupplierInput.Enabled;
        }
    }
}
