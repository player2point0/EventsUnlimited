namespace EventsUnlimited
{
    partial class FrmStock
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
            this.PnlStockLabels = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlStockInput = new System.Windows.Forms.Panel();
            this.TbxStockDeliveryTime = new EventsUnlimited.ValidationTextBox();
            this.TbxStockShelfLife = new EventsUnlimited.ValidationTextBox();
            this.TbxStockCost = new EventsUnlimited.ValidationTextBox();
            this.TbxStockAmount = new EventsUnlimited.ValidationTextBox();
            this.TbxStockName = new EventsUnlimited.ValidationTextBox();
            this.LblStockID = new System.Windows.Forms.Label();
            this.TbxSupplierID = new EventsUnlimited.ValidationTextBox();
            this.PnlStockLabels.SuspendLayout();
            this.PnlStockInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlStockLabels
            // 
            this.PnlStockLabels.Controls.Add(this.label7);
            this.PnlStockLabels.Controls.Add(this.label6);
            this.PnlStockLabels.Controls.Add(this.label5);
            this.PnlStockLabels.Controls.Add(this.label4);
            this.PnlStockLabels.Controls.Add(this.label3);
            this.PnlStockLabels.Controls.Add(this.label2);
            this.PnlStockLabels.Controls.Add(this.label1);
            this.PnlStockLabels.Location = new System.Drawing.Point(260, 174);
            this.PnlStockLabels.Name = "PnlStockLabels";
            this.PnlStockLabels.Size = new System.Drawing.Size(241, 409);
            this.PnlStockLabels.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Supplier ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stock Delivery Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock Shelf Life";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock ID";
            // 
            // PnlStockInput
            // 
            this.PnlStockInput.Controls.Add(this.TbxSupplierID);
            this.PnlStockInput.Controls.Add(this.TbxStockDeliveryTime);
            this.PnlStockInput.Controls.Add(this.TbxStockShelfLife);
            this.PnlStockInput.Controls.Add(this.TbxStockCost);
            this.PnlStockInput.Controls.Add(this.TbxStockAmount);
            this.PnlStockInput.Controls.Add(this.TbxStockName);
            this.PnlStockInput.Controls.Add(this.LblStockID);
            this.PnlStockInput.Location = new System.Drawing.Point(528, 174);
            this.PnlStockInput.Name = "PnlStockInput";
            this.PnlStockInput.Size = new System.Drawing.Size(254, 409);
            this.PnlStockInput.TabIndex = 7;
            // 
            // TbxStockDeliveryTime
            // 
            this.TbxStockDeliveryTime.Field = "Stock Delivery Time";
            this.TbxStockDeliveryTime.LettersOnly = false;
            this.TbxStockDeliveryTime.Location = new System.Drawing.Point(23, 244);
            this.TbxStockDeliveryTime.MaxSize = 100;
            this.TbxStockDeliveryTime.MinSize = 1;
            this.TbxStockDeliveryTime.Name = "TbxStockDeliveryTime";
            this.TbxStockDeliveryTime.NumbersOnly = false;
            this.TbxStockDeliveryTime.Required = true;
            this.TbxStockDeliveryTime.Size = new System.Drawing.Size(100, 26);
            this.TbxStockDeliveryTime.TabIndex = 11;
            // 
            // TbxStockShelfLife
            // 
            this.TbxStockShelfLife.Field = "Stock Shelf Life";
            this.TbxStockShelfLife.LettersOnly = false;
            this.TbxStockShelfLife.Location = new System.Drawing.Point(23, 203);
            this.TbxStockShelfLife.MaxSize = 100;
            this.TbxStockShelfLife.MinSize = 1;
            this.TbxStockShelfLife.Name = "TbxStockShelfLife";
            this.TbxStockShelfLife.NumbersOnly = false;
            this.TbxStockShelfLife.Required = true;
            this.TbxStockShelfLife.Size = new System.Drawing.Size(100, 26);
            this.TbxStockShelfLife.TabIndex = 10;
            // 
            // TbxStockCost
            // 
            this.TbxStockCost.Field = "Stock Cost";
            this.TbxStockCost.LettersOnly = false;
            this.TbxStockCost.Location = new System.Drawing.Point(23, 155);
            this.TbxStockCost.MaxSize = 100;
            this.TbxStockCost.MinSize = 1;
            this.TbxStockCost.Name = "TbxStockCost";
            this.TbxStockCost.NumbersOnly = true;
            this.TbxStockCost.Required = true;
            this.TbxStockCost.Size = new System.Drawing.Size(100, 26);
            this.TbxStockCost.TabIndex = 9;
            // 
            // TbxStockAmount
            // 
            this.TbxStockAmount.Field = "Stock Amount";
            this.TbxStockAmount.LettersOnly = false;
            this.TbxStockAmount.Location = new System.Drawing.Point(23, 103);
            this.TbxStockAmount.MaxSize = 100;
            this.TbxStockAmount.MinSize = 1;
            this.TbxStockAmount.Name = "TbxStockAmount";
            this.TbxStockAmount.NumbersOnly = false;
            this.TbxStockAmount.Required = true;
            this.TbxStockAmount.Size = new System.Drawing.Size(100, 26);
            this.TbxStockAmount.TabIndex = 8;
            // 
            // TbxStockName
            // 
            this.TbxStockName.Field = "Stock Name";
            this.TbxStockName.LettersOnly = true;
            this.TbxStockName.Location = new System.Drawing.Point(23, 68);
            this.TbxStockName.MaxSize = 100;
            this.TbxStockName.MinSize = 1;
            this.TbxStockName.Name = "TbxStockName";
            this.TbxStockName.NumbersOnly = false;
            this.TbxStockName.Required = true;
            this.TbxStockName.Size = new System.Drawing.Size(100, 26);
            this.TbxStockName.TabIndex = 7;
            // 
            // LblStockID
            // 
            this.LblStockID.AutoSize = true;
            this.LblStockID.Location = new System.Drawing.Point(19, 29);
            this.LblStockID.Name = "LblStockID";
            this.LblStockID.Size = new System.Drawing.Size(71, 20);
            this.LblStockID.TabIndex = 0;
            this.LblStockID.Text = "Stock ID";
            // 
            // TbxSupplierID
            // 
            this.TbxSupplierID.Field = "Supplier ID";
            this.TbxSupplierID.LettersOnly = false;
            this.TbxSupplierID.Location = new System.Drawing.Point(23, 283);
            this.TbxSupplierID.MaxSize = 100;
            this.TbxSupplierID.MinSize = 1;
            this.TbxSupplierID.Name = "TbxSupplierID";
            this.TbxSupplierID.NumbersOnly = true;
            this.TbxSupplierID.Required = true;
            this.TbxSupplierID.Size = new System.Drawing.Size(100, 26);
            this.TbxSupplierID.TabIndex = 12;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.PnlStockInput);
            this.Controls.Add(this.PnlStockLabels);
            this.Name = "FrmStock";
            this.Text = "Stock";
            this.Controls.SetChildIndex(this.PnlStockLabels, 0);
            this.Controls.SetChildIndex(this.PnlStockInput, 0);
            this.PnlStockLabels.ResumeLayout(false);
            this.PnlStockLabels.PerformLayout();
            this.PnlStockInput.ResumeLayout(false);
            this.PnlStockInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlStockLabels;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlStockInput;
        private System.Windows.Forms.Label LblStockID;
        private ValidationTextBox TbxStockName;
        private ValidationTextBox TbxStockAmount;
        private ValidationTextBox TbxStockCost;
        private ValidationTextBox TbxStockShelfLife;
        private ValidationTextBox TbxStockDeliveryTime;
        private ValidationTextBox TbxSupplierID;
    }
}