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
    public partial class FrmCard : FrmTemplate
    {
        private SQLManager sqlManager;
        private int index;
        private Control[] controls;
        private int newPrimaryKey;

        public FrmCard()
        {
            InitializeComponent();

            string name = "CustomerCard";
            string[] primaryKeys = new string[] { "CardId" };
            string[] fields = new string[] { "CardId", "CardNumber", "cardExpiryDate", "CardHolderName", "CardSecurityCode" };

            sqlManager = new SQLManager(name, primaryKeys, fields);

            index = 0;
            newPrimaryKey = -1;
            controls = new Control[] { LblCardID, TbxCardNumber, DtpCardExpiryDate, TbxCardHolderName, TbxCardSecurityCode };
        }

        private void FrmCard_Load(object sender, EventArgs e)
        {            
            sqlManager.ReadTable();            
            sqlManager.ShowTable(ref index, ref controls);
        }

        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
            PnlCardInput.Enabled = !PnlCardInput.Enabled;
        }

        protected override void BtnSave_Click(object sender, EventArgs e)
        {
            //if a new record then use the new primary key
            if(newPrimaryKey > -1)
            {

            }
            //else edit the record
            else
            {

            }
        }

        protected override void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        public void ClearControls()
        {
            foreach(var c in controls)
            {
                c.Text = "";
            }
        }

        protected override void BtnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
            //generate a new unique primary key
            newPrimaryKey = sqlManager.GenerateNewPrimaryKey();
            LblCardID.Text = newPrimaryKey.ToString();
        }
        protected override void BtnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
            newPrimaryKey = -1;
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
