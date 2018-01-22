namespace EventsUnlimited
{
    partial class FrmCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PnlCardLabels = new System.Windows.Forms.Panel();
            this.PnlCardInput = new System.Windows.Forms.Panel();
            this.TbxCardSecurityCode = new System.Windows.Forms.TextBox();
            this.TbxCardHolderName = new System.Windows.Forms.TextBox();
            this.DtpCardExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.TbxCardNumber = new System.Windows.Forms.TextBox();
            this.LblCardID = new System.Windows.Forms.Label();
            this.PnlCardLabels.SuspendLayout();
            this.PnlCardInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Card ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Card Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Card Expiry Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Card Holder\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Card Security Code";
            // 
            // PnlCardLabels
            // 
            this.PnlCardLabels.Controls.Add(this.label1);
            this.PnlCardLabels.Controls.Add(this.label5);
            this.PnlCardLabels.Controls.Add(this.label2);
            this.PnlCardLabels.Controls.Add(this.label4);
            this.PnlCardLabels.Controls.Add(this.label3);
            this.PnlCardLabels.Location = new System.Drawing.Point(257, 176);
            this.PnlCardLabels.Name = "PnlCardLabels";
            this.PnlCardLabels.Size = new System.Drawing.Size(209, 338);
            this.PnlCardLabels.TabIndex = 11;
            // 
            // PnlCardInput
            // 
            this.PnlCardInput.Controls.Add(this.TbxCardSecurityCode);
            this.PnlCardInput.Controls.Add(this.TbxCardHolderName);
            this.PnlCardInput.Controls.Add(this.DtpCardExpiryDate);
            this.PnlCardInput.Controls.Add(this.TbxCardNumber);
            this.PnlCardInput.Controls.Add(this.LblCardID);
            this.PnlCardInput.Enabled = false;
            this.PnlCardInput.Location = new System.Drawing.Point(517, 176);
            this.PnlCardInput.Name = "PnlCardInput";
            this.PnlCardInput.Size = new System.Drawing.Size(224, 338);
            this.PnlCardInput.TabIndex = 12;
            // 
            // TbxCardSecurityCode
            // 
            this.TbxCardSecurityCode.Location = new System.Drawing.Point(20, 179);
            this.TbxCardSecurityCode.Name = "TbxCardSecurityCode";
            this.TbxCardSecurityCode.Size = new System.Drawing.Size(174, 26);
            this.TbxCardSecurityCode.TabIndex = 4;
            // 
            // TbxCardHolderName
            // 
            this.TbxCardHolderName.Location = new System.Drawing.Point(20, 137);
            this.TbxCardHolderName.Name = "TbxCardHolderName";
            this.TbxCardHolderName.Size = new System.Drawing.Size(174, 26);
            this.TbxCardHolderName.TabIndex = 3;
            // 
            // DtpCardExpiryDate
            // 
            this.DtpCardExpiryDate.Location = new System.Drawing.Point(20, 94);
            this.DtpCardExpiryDate.Name = "DtpCardExpiryDate";
            this.DtpCardExpiryDate.Size = new System.Drawing.Size(174, 26);
            this.DtpCardExpiryDate.TabIndex = 2;
            // 
            // TbxCardNumber
            // 
            this.TbxCardNumber.Location = new System.Drawing.Point(20, 52);
            this.TbxCardNumber.Name = "TbxCardNumber";
            this.TbxCardNumber.Size = new System.Drawing.Size(100, 26);
            this.TbxCardNumber.TabIndex = 1;
            // 
            // LblCardID
            // 
            this.LblCardID.AutoSize = true;
            this.LblCardID.Location = new System.Drawing.Point(16, 21);
            this.LblCardID.Name = "LblCardID";
            this.LblCardID.Size = new System.Drawing.Size(60, 20);
            this.LblCardID.TabIndex = 0;
            this.LblCardID.Text = "CardID";
            // 
            // FrmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.PnlCardInput);
            this.Controls.Add(this.PnlCardLabels);
            this.Name = "FrmCard";
            this.Text = "Card";
            this.Load += new System.EventHandler(this.FrmCard_Load);
            this.Controls.SetChildIndex(this.PnlCardLabels, 0);
            this.Controls.SetChildIndex(this.PnlCardInput, 0);
            this.PnlCardLabels.ResumeLayout(false);
            this.PnlCardLabels.PerformLayout();
            this.PnlCardInput.ResumeLayout(false);
            this.PnlCardInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PnlCardLabels;
        private System.Windows.Forms.Panel PnlCardInput;
        private System.Windows.Forms.TextBox TbxCardSecurityCode;
        private System.Windows.Forms.TextBox TbxCardHolderName;
        private System.Windows.Forms.DateTimePicker DtpCardExpiryDate;
        private System.Windows.Forms.TextBox TbxCardNumber;
        private System.Windows.Forms.Label LblCardID;
    }
}