namespace EventsUnlimited
{
    partial class FrmSupplier
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
            this.PnlSupplierLabels = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PnlSupplierInput = new System.Windows.Forms.Panel();
            this.TbxSupplierPhoneNumber = new System.Windows.Forms.TextBox();
            this.TbxSupplierAddress = new System.Windows.Forms.TextBox();
            this.TbxSupplierName = new System.Windows.Forms.TextBox();
            this.LblSupplierID = new System.Windows.Forms.Label();
            this.PnlSupplierLabels.SuspendLayout();
            this.PnlSupplierInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSupplierLabels
            // 
            this.PnlSupplierLabels.Controls.Add(this.Label4);
            this.PnlSupplierLabels.Controls.Add(this.Label1);
            this.PnlSupplierLabels.Controls.Add(this.Label3);
            this.PnlSupplierLabels.Controls.Add(this.Label2);
            this.PnlSupplierLabels.Location = new System.Drawing.Point(250, 161);
            this.PnlSupplierLabels.Name = "PnlSupplierLabels";
            this.PnlSupplierLabels.Size = new System.Drawing.Size(247, 439);
            this.PnlSupplierLabels.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(22, 157);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(177, 20);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Supplier Phone Number";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(22, 112);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(130, 20);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Supplier Address";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(22, 63);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(113, 20);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Supplier Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(22, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 20);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Supplier ID";
            // 
            // PnlSupplierInput
            // 
            this.PnlSupplierInput.Controls.Add(this.TbxSupplierPhoneNumber);
            this.PnlSupplierInput.Controls.Add(this.TbxSupplierAddress);
            this.PnlSupplierInput.Controls.Add(this.TbxSupplierName);
            this.PnlSupplierInput.Controls.Add(this.LblSupplierID);
            this.PnlSupplierInput.Location = new System.Drawing.Point(517, 161);
            this.PnlSupplierInput.Name = "PnlSupplierInput";
            this.PnlSupplierInput.Size = new System.Drawing.Size(261, 439);
            this.PnlSupplierInput.TabIndex = 7;
            // 
            // TbxSupplierPhoneNumber
            // 
            this.TbxSupplierPhoneNumber.Location = new System.Drawing.Point(36, 157);
            this.TbxSupplierPhoneNumber.Name = "TbxSupplierPhoneNumber";
            this.TbxSupplierPhoneNumber.Size = new System.Drawing.Size(100, 26);
            this.TbxSupplierPhoneNumber.TabIndex = 4;
            // 
            // TbxSupplierAddress
            // 
            this.TbxSupplierAddress.Location = new System.Drawing.Point(36, 112);
            this.TbxSupplierAddress.Name = "TbxSupplierAddress";
            this.TbxSupplierAddress.Size = new System.Drawing.Size(100, 26);
            this.TbxSupplierAddress.TabIndex = 3;
            // 
            // TbxSupplierName
            // 
            this.TbxSupplierName.Location = new System.Drawing.Point(36, 56);
            this.TbxSupplierName.Name = "TbxSupplierName";
            this.TbxSupplierName.Size = new System.Drawing.Size(100, 26);
            this.TbxSupplierName.TabIndex = 2;
            // 
            // LblSupplierID
            // 
            this.LblSupplierID.AutoSize = true;
            this.LblSupplierID.Location = new System.Drawing.Point(32, 18);
            this.LblSupplierID.Name = "LblSupplierID";
            this.LblSupplierID.Size = new System.Drawing.Size(88, 20);
            this.LblSupplierID.TabIndex = 1;
            this.LblSupplierID.Text = "Supplier ID";
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.PnlSupplierInput);
            this.Controls.Add(this.PnlSupplierLabels);
            this.Name = "FrmSupplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.FrmSupplier_Load);
            this.Controls.SetChildIndex(this.PnlSupplierLabels, 0);
            this.Controls.SetChildIndex(this.PnlSupplierInput, 0);
            this.PnlSupplierLabels.ResumeLayout(false);
            this.PnlSupplierLabels.PerformLayout();
            this.PnlSupplierInput.ResumeLayout(false);
            this.PnlSupplierInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSupplierLabels;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Panel PnlSupplierInput;
        private System.Windows.Forms.TextBox TbxSupplierPhoneNumber;
        private System.Windows.Forms.TextBox TbxSupplierAddress;
        private System.Windows.Forms.TextBox TbxSupplierName;
        private System.Windows.Forms.Label LblSupplierID;
    }
}