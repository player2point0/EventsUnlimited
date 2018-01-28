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
    public partial class FrmStaff : FrmTemplate
    {
        public FrmStaff()
        {
            InitializeComponent();

            string name = "Staff";
            string[] primaryKeys = new string[] { "StaffId" };
            string[] fields = new string[] { "StaffId", "StaffName", "StaffAddress", "StaffPhoneNumber" };
            Control[] controls = new Control[] { LblStaffID, TbxStaffName, TbxStaffAddress, TbxStaffPhoneNumber };

            base.Initialise(name, primaryKeys, fields, controls, "StaffHelp.txt");
        }

        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
            PnlStaffInput.Enabled = !PnlStaffInput.Enabled;
        }
    }
}
