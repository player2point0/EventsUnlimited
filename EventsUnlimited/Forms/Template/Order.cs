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
    public partial class FrmOrder : FrmTemplate
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {

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
        }

        protected override void BtnPrevious_Click(object sender, EventArgs e)
        {
        }

    }
}
