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
            this.PnlStockOrderInput = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblStockOrderID = new System.Windows.Forms.Label();
            this.PnlStockOrderLabels.SuspendLayout();
            this.PnlStockOrderInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlStockOrderLabels
            // 
            this.PnlStockOrderLabels.Controls.Add(this.label4);
            this.PnlStockOrderLabels.Controls.Add(this.label3);
            this.PnlStockOrderLabels.Controls.Add(this.label2);
            this.PnlStockOrderLabels.Controls.Add(this.label1);
            this.PnlStockOrderLabels.Location = new System.Drawing.Point(255, 174);
            this.PnlStockOrderLabels.Name = "PnlStockOrderLabels";
            this.PnlStockOrderLabels.Size = new System.Drawing.Size(236, 409);
            this.PnlStockOrderLabels.TabIndex = 6;
            // 
            // PnlStockOrderInput
            // 
            this.PnlStockOrderInput.Controls.Add(this.LblStockOrderID);
            this.PnlStockOrderInput.Location = new System.Drawing.Point(519, 174);
            this.PnlStockOrderInput.Name = "PnlStockOrderInput";
            this.PnlStockOrderInput.Size = new System.Drawing.Size(252, 409);
            this.PnlStockOrderInput.TabIndex = 7;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff ID";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock";
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
    }
}