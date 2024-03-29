﻿namespace EventsUnlimited
{
    partial class FrmCustomer
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
            this.PnlCustomerLabels = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlCustomerInput = new System.Windows.Forms.Panel();
            this.TbxCustomerPhoneNumber = new EventsUnlimited.ValidationTextBox();
            this.TbxCustomerAddress = new EventsUnlimited.ValidationTextBox();
            this.TbxCustomerName = new EventsUnlimited.ValidationTextBox();
            this.LblCustomerID = new System.Windows.Forms.Label();
            this.PnlCustomerLabels.SuspendLayout();
            this.PnlCustomerInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlCustomerLabels
            // 
            this.PnlCustomerLabels.Controls.Add(this.label4);
            this.PnlCustomerLabels.Controls.Add(this.label3);
            this.PnlCustomerLabels.Controls.Add(this.label2);
            this.PnlCustomerLabels.Controls.Add(this.label1);
            this.PnlCustomerLabels.Location = new System.Drawing.Point(260, 174);
            this.PnlCustomerLabels.Name = "PnlCustomerLabels";
            this.PnlCustomerLabels.Size = new System.Drawing.Size(218, 375);
            this.PnlCustomerLabels.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // PnlCustomerInput
            // 
            this.PnlCustomerInput.Controls.Add(this.TbxCustomerPhoneNumber);
            this.PnlCustomerInput.Controls.Add(this.TbxCustomerAddress);
            this.PnlCustomerInput.Controls.Add(this.TbxCustomerName);
            this.PnlCustomerInput.Controls.Add(this.LblCustomerID);
            this.PnlCustomerInput.Enabled = false;
            this.PnlCustomerInput.Location = new System.Drawing.Point(510, 174);
            this.PnlCustomerInput.Name = "PnlCustomerInput";
            this.PnlCustomerInput.Size = new System.Drawing.Size(220, 375);
            this.PnlCustomerInput.TabIndex = 7;
            // 
            // TbxCustomerPhoneNumber
            // 
            this.TbxCustomerPhoneNumber.Field = "Customer Phone Number";
            this.TbxCustomerPhoneNumber.LettersOnly = false;
            this.TbxCustomerPhoneNumber.Location = new System.Drawing.Point(21, 170);
            this.TbxCustomerPhoneNumber.MaxSize = 15;
            this.TbxCustomerPhoneNumber.MinSize = 9;
            this.TbxCustomerPhoneNumber.Name = "TbxCustomerPhoneNumber";
            this.TbxCustomerPhoneNumber.NumbersOnly = true;
            this.TbxCustomerPhoneNumber.Required = true;
            this.TbxCustomerPhoneNumber.Size = new System.Drawing.Size(173, 26);
            this.TbxCustomerPhoneNumber.TabIndex = 7;
            // 
            // TbxCustomerAddress
            // 
            this.TbxCustomerAddress.Field = "Customer Address";
            this.TbxCustomerAddress.LettersOnly = false;
            this.TbxCustomerAddress.Location = new System.Drawing.Point(21, 122);
            this.TbxCustomerAddress.MaxSize = 100;
            this.TbxCustomerAddress.MinSize = 1;
            this.TbxCustomerAddress.Name = "TbxCustomerAddress";
            this.TbxCustomerAddress.NumbersOnly = false;
            this.TbxCustomerAddress.Required = true;
            this.TbxCustomerAddress.Size = new System.Drawing.Size(173, 26);
            this.TbxCustomerAddress.TabIndex = 6;
            // 
            // TbxCustomerName
            // 
            this.TbxCustomerName.Field = "Customer Name";
            this.TbxCustomerName.LettersOnly = true;
            this.TbxCustomerName.Location = new System.Drawing.Point(21, 70);
            this.TbxCustomerName.MaxSize = 100;
            this.TbxCustomerName.MinSize = 1;
            this.TbxCustomerName.Name = "TbxCustomerName";
            this.TbxCustomerName.NumbersOnly = false;
            this.TbxCustomerName.Required = true;
            this.TbxCustomerName.Size = new System.Drawing.Size(173, 26);
            this.TbxCustomerName.TabIndex = 5;
            // 
            // LblCustomerID
            // 
            this.LblCustomerID.AutoSize = true;
            this.LblCustomerID.Location = new System.Drawing.Point(17, 23);
            this.LblCustomerID.Name = "LblCustomerID";
            this.LblCustomerID.Size = new System.Drawing.Size(99, 20);
            this.LblCustomerID.TabIndex = 1;
            this.LblCustomerID.Text = "Customer ID";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.PnlCustomerInput);
            this.Controls.Add(this.PnlCustomerLabels);
            this.Name = "FrmCustomer";
            this.Text = "Customer";
            this.Controls.SetChildIndex(this.PnlCustomerLabels, 0);
            this.Controls.SetChildIndex(this.PnlCustomerInput, 0);
            this.PnlCustomerLabels.ResumeLayout(false);
            this.PnlCustomerLabels.PerformLayout();
            this.PnlCustomerInput.ResumeLayout(false);
            this.PnlCustomerInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCustomerLabels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlCustomerInput;
        private System.Windows.Forms.Label LblCustomerID;
        private ValidationTextBox TbxCustomerName;
        private ValidationTextBox TbxCustomerAddress;
        private ValidationTextBox TbxCustomerPhoneNumber;
    }
}