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
    public partial class FrmCustomerOrder : FrmTemplate
    {
        private SQLManager sqlManager;
        private int index;
        private Control[] controls;

        public FrmCustomerOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {

        }

        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
            PnlOrderInput.Enabled = !PnlOrderInput.Enabled;
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
        }

        protected override void BtnPrevious_Click(object sender, EventArgs e)
        {
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FrmCustomerOrderReport report = new FrmCustomerOrderReport();
            report.Show();
        }
    }
}
