namespace EventsUnlimited
{
    partial class FrmStaff
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
            this.PnlStaffLabels = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlStaffInput = new System.Windows.Forms.Panel();
            this.LblStaffID = new System.Windows.Forms.Label();
            this.TbxStaffName = new EventsUnlimited.ValidationTextBox();
            this.TbxStaffAddress = new EventsUnlimited.ValidationTextBox();
            this.TbxStaffPhoneNumber = new EventsUnlimited.ValidationTextBox();
            this.PnlStaffLabels.SuspendLayout();
            this.PnlStaffInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlStaffLabels
            // 
            this.PnlStaffLabels.Controls.Add(this.label4);
            this.PnlStaffLabels.Controls.Add(this.label3);
            this.PnlStaffLabels.Controls.Add(this.label2);
            this.PnlStaffLabels.Controls.Add(this.label1);
            this.PnlStaffLabels.Location = new System.Drawing.Point(258, 169);
            this.PnlStaffLabels.Name = "PnlStaffLabels";
            this.PnlStaffLabels.Size = new System.Drawing.Size(240, 368);
            this.PnlStaffLabels.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Staff Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Staff Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID";
            // 
            // PnlStaffInput
            // 
            this.PnlStaffInput.Controls.Add(this.TbxStaffPhoneNumber);
            this.PnlStaffInput.Controls.Add(this.TbxStaffAddress);
            this.PnlStaffInput.Controls.Add(this.TbxStaffName);
            this.PnlStaffInput.Controls.Add(this.LblStaffID);
            this.PnlStaffInput.Location = new System.Drawing.Point(526, 169);
            this.PnlStaffInput.Name = "PnlStaffInput";
            this.PnlStaffInput.Size = new System.Drawing.Size(264, 374);
            this.PnlStaffInput.TabIndex = 7;
            // 
            // LblStaffID
            // 
            this.LblStaffID.AutoSize = true;
            this.LblStaffID.Location = new System.Drawing.Point(26, 20);
            this.LblStaffID.Name = "LblStaffID";
            this.LblStaffID.Size = new System.Drawing.Size(65, 20);
            this.LblStaffID.TabIndex = 0;
            this.LblStaffID.Text = "Staff ID";
            // 
            // TbxStaffName
            // 
            this.TbxStaffName.LettersOnly = true;
            this.TbxStaffName.Location = new System.Drawing.Point(30, 61);
            this.TbxStaffName.MaxSize = 100;
            this.TbxStaffName.MinSize = 1;
            this.TbxStaffName.Name = "TbxStaffName";
            this.TbxStaffName.NumbersOnly = false;
            this.TbxStaffName.Required = true;
            this.TbxStaffName.Size = new System.Drawing.Size(100, 26);
            this.TbxStaffName.TabIndex = 4;
            // 
            // TbxStaffAddress
            // 
            this.TbxStaffAddress.LettersOnly = false;
            this.TbxStaffAddress.Location = new System.Drawing.Point(30, 104);
            this.TbxStaffAddress.MaxSize = 100;
            this.TbxStaffAddress.MinSize = 1;
            this.TbxStaffAddress.Name = "TbxStaffAddress";
            this.TbxStaffAddress.NumbersOnly = false;
            this.TbxStaffAddress.Required = true;
            this.TbxStaffAddress.Size = new System.Drawing.Size(100, 26);
            this.TbxStaffAddress.TabIndex = 5;
            // 
            // TbxStaffPhoneNumber
            // 
            this.TbxStaffPhoneNumber.LettersOnly = false;
            this.TbxStaffPhoneNumber.Location = new System.Drawing.Point(30, 159);
            this.TbxStaffPhoneNumber.MaxSize = 15;
            this.TbxStaffPhoneNumber.MinSize = 9;
            this.TbxStaffPhoneNumber.Name = "TbxStaffPhoneNumber";
            this.TbxStaffPhoneNumber.NumbersOnly = true;
            this.TbxStaffPhoneNumber.Required = true;
            this.TbxStaffPhoneNumber.Size = new System.Drawing.Size(100, 26);
            this.TbxStaffPhoneNumber.TabIndex = 6;
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.PnlStaffInput);
            this.Controls.Add(this.PnlStaffLabels);
            this.Name = "FrmStaff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            this.Controls.SetChildIndex(this.PnlStaffLabels, 0);
            this.Controls.SetChildIndex(this.PnlStaffInput, 0);
            this.PnlStaffLabels.ResumeLayout(false);
            this.PnlStaffLabels.PerformLayout();
            this.PnlStaffInput.ResumeLayout(false);
            this.PnlStaffInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlStaffLabels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlStaffInput;
        private System.Windows.Forms.Label LblStaffID;
        private ValidationTextBox TbxStaffName;
        private ValidationTextBox TbxStaffAddress;
        private ValidationTextBox TbxStaffPhoneNumber;
    }
}