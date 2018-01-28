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
        public FrmCustomer()
        {
            InitializeComponent();

            string name = "Customer";
            string[] primaryKeys = new string[] { "CustomerId" };
            string[] fields = new string[] { "CustomerId", "CustomerName", "CustomerAddress", "CustomerPhoneNumber" };
            Control[] controls = new Control[] { LblCustomerID, TbxCustomerName, TbxCustomerAddress, TbxCustomerPhoneNumber };

            base.Initialise(name, primaryKeys, fields, controls);
        }

        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
            PnlCustomerInput.Enabled = !PnlCustomerInput.Enabled;
        }
    }
}
