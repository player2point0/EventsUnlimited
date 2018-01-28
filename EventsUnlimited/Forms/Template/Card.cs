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
        public FrmCard()
        {
            //NOT THE MOST READABLE WAY
            InitializeComponent();

            string name = "CustomerCard";
            string[] primaryKey = new string[] { "CardId" };
            string[] fields = new string[] { "CardId", "CardNumber", "cardExpiryDate", "CardHolderName", "CardSecurityCode" };
            Control[] controls = new Control[] { LblCardID, TbxCardNumber, DtpCardExpiryDate, TbxCardHolderName, TbxCardSecurityCode };

            base.Initialise(name, primaryKey, fields, controls);
        }

        protected override void BtnEdit_Click(object sender, EventArgs e)
        {
            base.BtnEdit_Click(sender, e);
            PnlCardInput.Enabled = !PnlCardInput.Enabled;
        }
    }
}
