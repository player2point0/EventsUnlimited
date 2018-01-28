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
        private SQLManager sqlManager;
        private int index;
        private Control[] controls;
        public int newPrimaryKey;

        public FrmTemplate()
        {
            InitializeComponent();
        }

        public void Initialise(string _name, string[] _primaryKeys, string[] _fields, Control[] _controls)
        {
            sqlManager = new SQLManager(_name, _primaryKeys, _fields);
            controls = _controls;
            index = 0;
            newPrimaryKey = -1;
        }

        private void Template_Load(object sender, EventArgs e)
        {
            this.Height = 550;//NEED TO FIX SCALE PROBLEM
            sqlManager.ReadTable();
            sqlManager.ShowTable(ref index, ref controls);
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
            BtnNew.Enabled = !BtnNew.Enabled;
            BtnSave.Enabled = !BtnSave.Enabled;
            BtnDelete.Enabled = !BtnDelete.Enabled;
            BtnClear.Enabled = !BtnClear.Enabled;
        }

        protected virtual void BtnSave_Click(object sender, EventArgs e)
        {
            string message;

            //if a new record then use the new primary key
            if (newPrimaryKey > -1)
            {
                message = sqlManager.AddRow(ref controls);
            }
            //else edit the record
            else
            {
                string[] key = new string[] { controls[0].Text };//PRIMARY KEY

                message = sqlManager.EditRow(key, ref controls);
            }

            Print(message);
        }
        protected virtual void BtnDelete_Click(object sender, EventArgs e)
        {
            string currentId = controls[0].Text;//PRIMARY KEY
            string deleteMessage = sqlManager.DeleteRow(new string[] { currentId });
            Print(deleteMessage);
            index--;
            sqlManager.ShowTable(ref index, ref controls);
        }

        protected virtual void ClearControls()
        {
            foreach (var c in controls)
            {
                c.Text = "";
            }

            sqlManager.SetLastIndex(ref index);
            newPrimaryKey = sqlManager.GenerateNewPrimaryKey();
            controls[0].Text = newPrimaryKey.ToString();//PRIMARY KEY
        }
        protected virtual void BtnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        protected virtual void BtnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        protected virtual void BtnNext_Click(object sender, EventArgs e)
        {
            index++;
            string message = sqlManager.ShowTable(ref index, ref controls);
            Print(message);
        }
        protected virtual void BtnPrevious_Click(object sender, EventArgs e)
        {
            index--;
            string message = sqlManager.ShowTable(ref index, ref controls);
            Print(message);
        }
    }
}
