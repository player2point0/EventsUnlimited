﻿namespace EventsUnlimited
{
    partial class FrmCustomerOrder
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
            this.PnlOrderLabels = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlOrderInput = new System.Windows.Forms.Panel();
            this.TbxOrderAddress = new EventsUnlimited.ValidationTextBox();
            this.NudStockQuantity = new System.Windows.Forms.NumericUpDown();
            this.TbxOrderNotes = new System.Windows.Forms.TextBox();
            this.BtnRemoveStock = new System.Windows.Forms.Button();
            this.BtnAddStock = new System.Windows.Forms.Button();
            this.CbxStock = new System.Windows.Forms.ComboBox();
            this.DtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.CbxOrderPaid = new System.Windows.Forms.CheckBox();
            this.CbxCardID = new System.Windows.Forms.ComboBox();
            this.CbxCustomerID = new System.Windows.Forms.ComboBox();
            this.CbxStaffID = new System.Windows.Forms.ComboBox();
            this.LblOrderID = new System.Windows.Forms.Label();
            this.BtnOverview = new System.Windows.Forms.Button();
            this.PnlOrderLabels.SuspendLayout();
            this.PnlOrderInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudStockQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlOrderLabels
            // 
            this.PnlOrderLabels.Controls.Add(this.label10);
            this.PnlOrderLabels.Controls.Add(this.label9);
            this.PnlOrderLabels.Controls.Add(this.label8);
            this.PnlOrderLabels.Controls.Add(this.label7);
            this.PnlOrderLabels.Controls.Add(this.label6);
            this.PnlOrderLabels.Controls.Add(this.label5);
            this.PnlOrderLabels.Controls.Add(this.label4);
            this.PnlOrderLabels.Controls.Add(this.label3);
            this.PnlOrderLabels.Controls.Add(this.label2);
            this.PnlOrderLabels.Controls.Add(this.label1);
            this.PnlOrderLabels.Location = new System.Drawing.Point(261, 177);
            this.PnlOrderLabels.Name = "PnlOrderLabels";
            this.PnlOrderLabels.Size = new System.Drawing.Size(245, 498);
            this.PnlOrderLabels.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Stock Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Order Notes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Order Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Order Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order Paid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Card ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID";
            // 
            // PnlOrderInput
            // 
            this.PnlOrderInput.Controls.Add(this.TbxOrderAddress);
            this.PnlOrderInput.Controls.Add(this.NudStockQuantity);
            this.PnlOrderInput.Controls.Add(this.TbxOrderNotes);
            this.PnlOrderInput.Controls.Add(this.BtnRemoveStock);
            this.PnlOrderInput.Controls.Add(this.BtnAddStock);
            this.PnlOrderInput.Controls.Add(this.CbxStock);
            this.PnlOrderInput.Controls.Add(this.DtpOrderDate);
            this.PnlOrderInput.Controls.Add(this.CbxOrderPaid);
            this.PnlOrderInput.Controls.Add(this.CbxCardID);
            this.PnlOrderInput.Controls.Add(this.CbxCustomerID);
            this.PnlOrderInput.Controls.Add(this.CbxStaffID);
            this.PnlOrderInput.Controls.Add(this.LblOrderID);
            this.PnlOrderInput.Enabled = false;
            this.PnlOrderInput.Location = new System.Drawing.Point(530, 177);
            this.PnlOrderInput.Name = "PnlOrderInput";
            this.PnlOrderInput.Size = new System.Drawing.Size(264, 483);
            this.PnlOrderInput.TabIndex = 7;
            // 
            // TbxOrderAddress
            // 
            this.TbxOrderAddress.Field = "Order Address";
            this.TbxOrderAddress.LettersOnly = false;
            this.TbxOrderAddress.Location = new System.Drawing.Point(30, 186);
            this.TbxOrderAddress.MaxSize = 100;
            this.TbxOrderAddress.MinSize = 1;
            this.TbxOrderAddress.Name = "TbxOrderAddress";
            this.TbxOrderAddress.NumbersOnly = false;
            this.TbxOrderAddress.Required = true;
            this.TbxOrderAddress.Size = new System.Drawing.Size(201, 26);
            this.TbxOrderAddress.TabIndex = 13;
            // 
            // NudStockQuantity
            // 
            this.NudStockQuantity.Location = new System.Drawing.Point(31, 307);
            this.NudStockQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudStockQuantity.Name = "NudStockQuantity";
            this.NudStockQuantity.Size = new System.Drawing.Size(200, 26);
            this.NudStockQuantity.TabIndex = 12;
            this.NudStockQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TbxOrderNotes
            // 
            this.TbxOrderNotes.Location = new System.Drawing.Point(30, 386);
            this.TbxOrderNotes.Multiline = true;
            this.TbxOrderNotes.Name = "TbxOrderNotes";
            this.TbxOrderNotes.Size = new System.Drawing.Size(201, 88);
            this.TbxOrderNotes.TabIndex = 10;
            // 
            // BtnRemoveStock
            // 
            this.BtnRemoveStock.Location = new System.Drawing.Point(144, 339);
            this.BtnRemoveStock.Name = "BtnRemoveStock";
            this.BtnRemoveStock.Size = new System.Drawing.Size(87, 38);
            this.BtnRemoveStock.TabIndex = 9;
            this.BtnRemoveStock.Text = "Remove";
            this.BtnRemoveStock.UseVisualStyleBackColor = true;
            this.BtnRemoveStock.Click += new System.EventHandler(this.BtnRemoveStock_Click);
            // 
            // BtnAddStock
            // 
            this.BtnAddStock.Location = new System.Drawing.Point(31, 339);
            this.BtnAddStock.Name = "BtnAddStock";
            this.BtnAddStock.Size = new System.Drawing.Size(86, 38);
            this.BtnAddStock.TabIndex = 8;
            this.BtnAddStock.Text = "Add";
            this.BtnAddStock.UseVisualStyleBackColor = true;
            this.BtnAddStock.Click += new System.EventHandler(this.BtnAddStock_Click);
            // 
            // CbxStock
            // 
            this.CbxStock.FormattingEnabled = true;
            this.CbxStock.Location = new System.Drawing.Point(30, 270);
            this.CbxStock.Name = "CbxStock";
            this.CbxStock.Size = new System.Drawing.Size(201, 28);
            this.CbxStock.TabIndex = 7;
            this.CbxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxStock_KeyPress);
            // 
            // DtpOrderDate
            // 
            this.DtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpOrderDate.Location = new System.Drawing.Point(31, 235);
            this.DtpOrderDate.Name = "DtpOrderDate";
            this.DtpOrderDate.Size = new System.Drawing.Size(200, 26);
            this.DtpOrderDate.TabIndex = 6;
            // 
            // CbxOrderPaid
            // 
            this.CbxOrderPaid.AutoSize = true;
            this.CbxOrderPaid.Location = new System.Drawing.Point(31, 149);
            this.CbxOrderPaid.Name = "CbxOrderPaid";
            this.CbxOrderPaid.Size = new System.Drawing.Size(22, 21);
            this.CbxOrderPaid.TabIndex = 4;
            this.CbxOrderPaid.UseVisualStyleBackColor = true;
            // 
            // CbxCardID
            // 
            this.CbxCardID.FormattingEnabled = true;
            this.CbxCardID.Location = new System.Drawing.Point(30, 108);
            this.CbxCardID.Name = "CbxCardID";
            this.CbxCardID.Size = new System.Drawing.Size(201, 28);
            this.CbxCardID.TabIndex = 3;
            this.CbxCardID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxCardID_KeyPress);
            // 
            // CbxCustomerID
            // 
            this.CbxCustomerID.FormattingEnabled = true;
            this.CbxCustomerID.Location = new System.Drawing.Point(30, 78);
            this.CbxCustomerID.Name = "CbxCustomerID";
            this.CbxCustomerID.Size = new System.Drawing.Size(201, 28);
            this.CbxCustomerID.TabIndex = 2;
            this.CbxCustomerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxCustomerID_KeyPress);
            // 
            // CbxStaffID
            // 
            this.CbxStaffID.FormattingEnabled = true;
            this.CbxStaffID.Location = new System.Drawing.Point(30, 47);
            this.CbxStaffID.Name = "CbxStaffID";
            this.CbxStaffID.Size = new System.Drawing.Size(201, 28);
            this.CbxStaffID.TabIndex = 1;
            this.CbxStaffID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxStaffID_KeyPress);
            // 
            // LblOrderID
            // 
            this.LblOrderID.AutoSize = true;
            this.LblOrderID.Location = new System.Drawing.Point(26, 16);
            this.LblOrderID.Name = "LblOrderID";
            this.LblOrderID.Size = new System.Drawing.Size(70, 20);
            this.LblOrderID.TabIndex = 0;
            this.LblOrderID.Text = "Order ID";
            // 
            // BtnOverview
            // 
            this.BtnOverview.Location = new System.Drawing.Point(561, 666);
            this.BtnOverview.Name = "BtnOverview";
            this.BtnOverview.Size = new System.Drawing.Size(200, 34);
            this.BtnOverview.TabIndex = 11;
            this.BtnOverview.Text = "Overview";
            this.BtnOverview.UseVisualStyleBackColor = true;
            this.BtnOverview.Click += new System.EventHandler(this.BtnOverview_Click);
            // 
            // FrmCustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.PnlOrderInput);
            this.Controls.Add(this.PnlOrderLabels);
            this.Controls.Add(this.BtnOverview);
            this.Name = "FrmCustomerOrder";
            this.Text = "CustomerOrder";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.Controls.SetChildIndex(this.BtnOverview, 0);
            this.Controls.SetChildIndex(this.PnlOrderLabels, 0);
            this.Controls.SetChildIndex(this.PnlOrderInput, 0);
            this.PnlOrderLabels.ResumeLayout(false);
            this.PnlOrderLabels.PerformLayout();
            this.PnlOrderInput.ResumeLayout(false);
            this.PnlOrderInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudStockQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlOrderLabels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlOrderInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnOverview;
        private System.Windows.Forms.TextBox TbxOrderNotes;
        private System.Windows.Forms.Button BtnRemoveStock;
        private System.Windows.Forms.Button BtnAddStock;
        private System.Windows.Forms.ComboBox CbxStock;
        private System.Windows.Forms.DateTimePicker DtpOrderDate;
        private System.Windows.Forms.CheckBox CbxOrderPaid;
        private System.Windows.Forms.ComboBox CbxCardID;
        private System.Windows.Forms.ComboBox CbxCustomerID;
        private System.Windows.Forms.ComboBox CbxStaffID;
        private System.Windows.Forms.Label LblOrderID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NudStockQuantity;
        private ValidationTextBox TbxOrderAddress;
    }
}