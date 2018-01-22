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
        private SQLManager sqlManager;
        private int index;
        private Control[] controls;

        public FrmStaff()
        {
            InitializeComponent();
        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            string name = "Staff";
            string[] primaryKeys = new string[] { "StaffId"};
            string[] fields = new string[] { "StaffId", "StaffName", "StaffAddress", "StaffPhoneNumber"};

            sqlManager = new SQLManager(name, primaryKeys, fields);

            sqlManager.ReadTable();

            index = 0;
            controls = new Control[] {LblStaffID, TbxStaffName, TbxStaffAddress, TbxStaffPhoneNumber };

            sqlManager.ShowTable(ref index, ref controls);
        }

        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
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
