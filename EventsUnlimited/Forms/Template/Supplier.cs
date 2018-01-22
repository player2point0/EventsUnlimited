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
        private SQLManager sqlManager;
        private int index;
        private Control[] controls;

        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            string name = "Supplier";
            string[] primaryKeys = new string[] { "SupplierId"};
            string[] fields = new string[] { "SupplierId", "SupplierName", "SupplierAddress", "SupplierPhoneNumber" };

            sqlManager = new SQLManager(name, primaryKeys, fields);

            sqlManager.ReadTable();

            index = 0;
            controls = new Control[] {LblSupplierID, TbxSupplierName, TbxSupplierAddress, TbxSupplierPhoneNumber };

            sqlManager.ShowTable(ref index, ref controls);
        }

        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
        }

        protected override void BtnNew_Click(object sender, EventArgs e)
        {
        }

        protected override void BtnSave_Click(object sender, EventArgs e)
        {
        }

        protected override void BtnDelete_Click(object sender, EventArgs e)
        {
        }

        protected override void BtnClear_Click(object sender, EventArgs e)
        {
        }

        protected override void BtnNext_Click(object sender, EventArgs e)
        {
            index++;
            string message = sqlManager.ShowTable(ref index, ref controls);
            Print(message);
        }

        protected override void BtnPrevious_Click(object sender, EventArgs e)
        {
            index--;
            string message = sqlManager.ShowTable(ref index, ref controls);
            Print(message);
        }
    }
}
