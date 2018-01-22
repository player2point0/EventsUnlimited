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
    public partial class FrmCustomer : FrmTemplate
    {
        private SQLManager sqlManager;
        private int index;
        private Control[] controls;

        public FrmCustomer()
        {
            InitializeComponent();

            string name = "Customer";
            string[] primaryKeys = new string[] { "CustomerId" };
            string[] fields = new string[] { "CustomerId", "CustomerName", "CustomerAddress", "CustomerPhoneNumber" };

            sqlManager = new SQLManager(name, primaryKeys, fields);

            index = 0;
            controls = new Control[] { LblCustomerID, TbxCustomerName, TbxCustomerAddress, TbxCustomerPhoneNumber };
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            sqlManager.ReadTable();
            sqlManager.ShowTable(ref index, ref controls);
        }

        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
            PnlCustomerInput.Enabled = !PnlCustomerInput.Enabled;
        }

        public void ClearControls()
        {
            foreach (var c in controls)
            {
                c.Text = "";
            }
        }

        protected override void BtnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        protected override void BtnSave_Click(object sender, EventArgs e)
        {
        }

        protected override void BtnDelete_Click(object sender, EventArgs e)
        {
        }

        protected override void BtnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
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
