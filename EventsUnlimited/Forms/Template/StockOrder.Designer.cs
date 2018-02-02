namespace EventsUnlimited
{
    partial class FrmStockOrder
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
            this.PnlStockOrderLabels = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlStockOrderInput = new System.Windows.Forms.Panel();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnOverview = new System.Windows.Forms.Button();
            this.BtnRemoveStock = new System.Windows.Forms.Button();
            this.BtnAddStock = new System.Windows.Forms.Button();
            this.NudStockQuantity = new System.Windows.Forms.NumericUpDown();
            this.CbxStock = new System.Windows.Forms.ComboBox();
            this.DtpStockOrderDate = new System.Windows.Forms.DateTimePicker();
            this.CbxStaffID = new System.Windows.Forms.ComboBox();
            this.LblStockOrderID = new System.Windows.Forms.Label();
            this.PnlStockOrderLabels.SuspendLayout();
            this.PnlStockOrderInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudStockQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlStockOrderLabels
            // 
            this.PnlStockOrderLabels.Controls.Add(this.label5);
            this.PnlStockOrderLabels.Controls.Add(this.label4);
            this.PnlStockOrderLabels.Controls.Add(this.label3);
            this.PnlStockOrderLabels.Controls.Add(this.label2);
            this.PnlStockOrderLabels.Controls.Add(this.label1);
            this.PnlStockOrderLabels.Location = new System.Drawing.Point(255, 174);
            this.PnlStockOrderLabels.Name = "PnlStockOrderLabels";
            this.PnlStockOrderLabels.Size = new System.Drawing.Size(236, 409);
            this.PnlStockOrderLabels.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock Order Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Order ID";
            // 
            // PnlStockOrderInput
            // 
            this.PnlStockOrderInput.Controls.Add(this.BtnReport);
            this.PnlStockOrderInput.Controls.Add(this.BtnOverview);
            this.PnlStockOrderInput.Controls.Add(this.BtnRemoveStock);
            this.PnlStockOrderInput.Controls.Add(this.BtnAddStock);
            this.PnlStockOrderInput.Controls.Add(this.NudStockQuantity);
            this.PnlStockOrderInput.Controls.Add(this.CbxStock);
            this.PnlStockOrderInput.Controls.Add(this.DtpStockOrderDate);
            this.PnlStockOrderInput.Controls.Add(this.CbxStaffID);
            this.PnlStockOrderInput.Controls.Add(this.LblStockOrderID);
            this.PnlStockOrderInput.Enabled = false;
            this.PnlStockOrderInput.Location = new System.Drawing.Point(519, 174);
            this.PnlStockOrderInput.Name = "PnlStockOrderInput";
            this.PnlStockOrderInput.Size = new System.Drawing.Size(252, 409);
            this.PnlStockOrderInput.TabIndex = 7;
            // 
            // BtnReport
            // 
            this.BtnReport.Location = new System.Drawing.Point(39, 319);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(176, 34);
            this.BtnReport.TabIndex = 8;
            this.BtnReport.Text = "Report";
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnOverview
            // 
            this.BtnOverview.Location = new System.Drawing.Point(39, 264);
            this.BtnOverview.Name = "BtnOverview";
            this.BtnOverview.Size = new System.Drawing.Size(176, 38);
            this.BtnOverview.TabIndex = 7;
            this.BtnOverview.Text = "Overview";
            this.BtnOverview.UseVisualStyleBackColor = true;
            this.BtnOverview.Click += new System.EventHandler(this.BtnOverview_Click);
            // 
            // BtnRemoveStock
            // 
            this.BtnRemoveStock.Location = new System.Drawing.Point(126, 199);
            this.BtnRemoveStock.Name = "BtnRemoveStock";
            this.BtnRemoveStock.Size = new System.Drawing.Size(89, 35);
            this.BtnRemoveStock.TabIndex = 6;
            this.BtnRemoveStock.Text = "Remove";
            this.BtnRemoveStock.UseVisualStyleBackColor = true;
            this.BtnRemoveStock.Click += new System.EventHandler(this.BtnRemoveStock_Click);
            // 
            // BtnAddStock
            // 
            this.BtnAddStock.Location = new System.Drawing.Point(39, 199);
            this.BtnAddStock.Name = "BtnAddStock";
            this.BtnAddStock.Size = new System.Drawing.Size(66, 35);
            this.BtnAddStock.TabIndex = 5;
            this.BtnAddStock.Text = "Add";
            this.BtnAddStock.UseVisualStyleBackColor = true;
            this.BtnAddStock.Click += new System.EventHandler(this.BtnAddStock_Click);
            // 
            // NudStockQuantity
            // 
            this.NudStockQuantity.Location = new System.Drawing.Point(39, 154);
            this.NudStockQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudStockQuantity.Name = "NudStockQuantity";
            this.NudStockQuantity.Size = new System.Drawing.Size(120, 26);
            this.NudStockQuantity.TabIndex = 4;
            this.NudStockQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CbxStock
            // 
            this.CbxStock.FormattingEnabled = true;
            this.CbxStock.Location = new System.Drawing.Point(39, 119);
            this.CbxStock.Name = "CbxStock";
            this.CbxStock.Size = new System.Drawing.Size(121, 28);
            this.CbxStock.TabIndex = 3;
            this.CbxStock.SelectedIndexChanged += new System.EventHandler(this.CbxStock_SelectedIndexChanged);
            this.CbxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxStock_KeyPress);
            // 
            // DtpStockOrderDate
            // 
            this.DtpStockOrderDate.Location = new System.Drawing.Point(39, 86);
            this.DtpStockOrderDate.Name = "DtpStockOrderDate";
            this.DtpStockOrderDate.Size = new System.Drawing.Size(200, 26);
            this.DtpStockOrderDate.TabIndex = 2;
            // 
            // CbxStaffID
            // 
            this.CbxStaffID.FormattingEnabled = true;
            this.CbxStaffID.Location = new System.Drawing.Point(39, 50);
            this.CbxStaffID.Name = "CbxStaffID";
            this.CbxStaffID.Size = new System.Drawing.Size(121, 28);
            this.CbxStaffID.TabIndex = 1;
            this.CbxStaffID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxStaffID_KeyPress);
            // 
            // LblStockOrderID
            // 
            this.LblStockOrderID.AutoSize = true;
            this.LblStockOrderID.Location = new System.Drawing.Point(35, 16);
            this.LblStockOrderID.Name = "LblStockOrderID";
            this.LblStockOrderID.Size = new System.Drawing.Size(115, 20);
            this.LblStockOrderID.TabIndex = 0;
            this.LblStockOrderID.Text = "Stock Order ID";
            // 
            // FrmStockOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.PnlStockOrderInput);
            this.Controls.Add(this.PnlStockOrderLabels);
            this.Name = "FrmStockOrder";
            this.Text = "StockOrder";
            this.Load += new System.EventHandler(this.FrmStockOrder_Load);
            this.Controls.SetChildIndex(this.PnlStockOrderLabels, 0);
            this.Controls.SetChildIndex(this.PnlStockOrderInput, 0);
            this.PnlStockOrderLabels.ResumeLayout(false);
            this.PnlStockOrderLabels.PerformLayout();
            this.PnlStockOrderInput.ResumeLayout(false);
            this.PnlStockOrderInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudStockQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlStockOrderLabels;
        private System.Windows.Forms.Panel PnlStockOrderInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblStockOrderID;
        private System.Windows.Forms.ComboBox CbxStock;
        private System.Windows.Forms.DateTimePicker DtpStockOrderDate;
        private System.Windows.Forms.ComboBox CbxStaffID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAddStock;
        private System.Windows.Forms.NumericUpDown NudStockQuantity;
        private System.Windows.Forms.Button BtnRemoveStock;
        private System.Windows.Forms.Button BtnOverview;
        private System.Windows.Forms.Button BtnReport;
    }
}