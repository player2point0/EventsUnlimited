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
    public partial class FrmTemplate : Form
    {
        public FrmTemplate()
        {
            InitializeComponent();
        }

        private void Template_Load(object sender, EventArgs e)
        {
            this.Height = 550;//NEED TO FIX SCALE PROBLEM
        }

        public void Print(string message)
        {
            if (message == "" || message == null) return;

            LsvMessageBox.Items.Add(message);
            //scroll to bottom
            LsvMessageBox.Items[LsvMessageBox.Items.Count - 1].EnsureVisible();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu Menu = new FrmMenu();
            Menu.Show();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            FrmHelp Help = new FrmHelp();
            Help.Show();
        }

        protected virtual void BtnEdit_Click(object sender, EventArgs e)
        {
        }

        protected virtual void BtnNew_Click(object sender, EventArgs e)
        {
        }

        protected virtual void BtnSave_Click(object sender, EventArgs e)
        {
        }

        protected virtual void BtnDelete_Click(object sender, EventArgs e)
        {
        }

        protected virtual void BtnClear_Click(object sender, EventArgs e)
        {
        }

        protected virtual void BtnNext_Click(object sender, EventArgs e)
        {
        }

        protected virtual void BtnPrevious_Click(object sender, EventArgs e)
        {
        }
    }
}
