namespace EventsUnlimited
{
    partial class FrmMenu
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlCustomerOrderActions = new System.Windows.Forms.Panel();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnCustomerOrder = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.PnlStockOrderActions = new System.Windows.Forms.Panel();
            this.btnStockOrder = new System.Windows.Forms.Button();
            this.PnlSharedActions = new System.Windows.Forms.Panel();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlCustomerOrderActions.SuspendLayout();
            this.PnlStockOrderActions.SuspendLayout();
            this.PnlSharedActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnExit.Location = new System.Drawing.Point(121, 569);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(239, 112);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Tag = "";
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlCustomerOrderActions
            // 
            this.PnlCustomerOrderActions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlCustomerOrderActions.BackColor = System.Drawing.Color.White;
            this.PnlCustomerOrderActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCustomerOrderActions.Controls.Add(this.btnCard);
            this.PnlCustomerOrderActions.Controls.Add(this.btnCustomerOrder);
            this.PnlCustomerOrderActions.Controls.Add(this.btnCustomer);
            this.PnlCustomerOrderActions.Location = new System.Drawing.Point(121, 242);
            this.PnlCustomerOrderActions.Name = "PnlCustomerOrderActions";
            this.PnlCustomerOrderActions.Size = new System.Drawing.Size(379, 269);
            this.PnlCustomerOrderActions.TabIndex = 1;
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(190, 22);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(140, 80);
            this.btnCard.TabIndex = 2;
            this.btnCard.Tag = "";
            this.btnCard.Text = "Card";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnCustomerOrder
            // 
            this.btnCustomerOrder.Location = new System.Drawing.Point(23, 108);
            this.btnCustomerOrder.Name = "btnCustomerOrder";
            this.btnCustomerOrder.Size = new System.Drawing.Size(140, 80);
            this.btnCustomerOrder.TabIndex = 1;
            this.btnCustomerOrder.Tag = "";
            this.btnCustomerOrder.Text = "CustomerOrder";
            this.btnCustomerOrder.UseVisualStyleBackColor = true;
            this.btnCustomerOrder.Click += new System.EventHandler(this.btnCustomerOrder_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(23, 22);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(140, 80);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Tag = "";
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // PnlStockOrderActions
            // 
            this.PnlStockOrderActions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlStockOrderActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlStockOrderActions.Controls.Add(this.btnStockOrder);
            this.PnlStockOrderActions.Location = new System.Drawing.Point(680, 242);
            this.PnlStockOrderActions.Name = "PnlStockOrderActions";
            this.PnlStockOrderActions.Size = new System.Drawing.Size(379, 269);
            this.PnlStockOrderActions.TabIndex = 3;
            // 
            // btnStockOrder
            // 
            this.btnStockOrder.Location = new System.Drawing.Point(26, 22);
            this.btnStockOrder.Name = "btnStockOrder";
            this.btnStockOrder.Size = new System.Drawing.Size(140, 80);
            this.btnStockOrder.TabIndex = 0;
            this.btnStockOrder.Tag = "";
            this.btnStockOrder.Text = "StockOrder";
            this.btnStockOrder.UseVisualStyleBackColor = true;
            this.btnStockOrder.Click += new System.EventHandler(this.btnStockOrder_Click);
            // 
            // PnlSharedActions
            // 
            this.PnlSharedActions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlSharedActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlSharedActions.Controls.Add(this.btnStock);
            this.PnlSharedActions.Controls.Add(this.btnSupplier);
            this.PnlSharedActions.Controls.Add(this.btnStaff);
            this.PnlSharedActions.Location = new System.Drawing.Point(431, 562);
            this.PnlSharedActions.Name = "PnlSharedActions";
            this.PnlSharedActions.Size = new System.Drawing.Size(628, 119);
            this.PnlSharedActions.TabIndex = 4;
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(409, 24);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(140, 80);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(243, 24);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(140, 80);
            this.btnSupplier.TabIndex = 1;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(77, 22);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(140, 80);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(676, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Tag = "f1";
            this.label1.Text = "Stock Actions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(117, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 6;
            this.label2.Tag = "f1";
            this.label2.Text = "Customer Actions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 6;
            this.label3.Tag = "f1";
            this.label3.Text = "Shared Actions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::EventsUnlimited.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(332, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 172);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 778);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlSharedActions);
            this.Controls.Add(this.PnlStockOrderActions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PnlCustomerOrderActions);
            this.Controls.Add(this.BtnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "FrmMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "b2";
            this.Text = "Events Unlimited";
            this.PnlCustomerOrderActions.ResumeLayout(false);
            this.PnlStockOrderActions.ResumeLayout(false);
            this.PnlSharedActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PnlCustomerOrderActions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlStockOrderActions;
        private System.Windows.Forms.Panel PnlSharedActions;
        private System.Windows.Forms.Button btnStockOrder;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnCustomerOrder;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

