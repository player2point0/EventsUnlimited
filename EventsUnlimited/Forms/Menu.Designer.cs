namespace EventsUnlimited
{
    partial class Menu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlStockOrderActions = new System.Windows.Forms.Panel();
            this.btnStockOrder = new System.Windows.Forms.Button();
            this.PnlSharedActions = new System.Windows.Forms.Panel();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnCustomerOrder = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.PnlCustomerOrderActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlStockOrderActions.SuspendLayout();
            this.PnlSharedActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Location = new System.Drawing.Point(103, 488);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(239, 112);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlCustomerOrderActions
            // 
            this.PnlCustomerOrderActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCustomerOrderActions.Controls.Add(this.btnCard);
            this.PnlCustomerOrderActions.Controls.Add(this.btnCustomerOrder);
            this.PnlCustomerOrderActions.Controls.Add(this.btnCustomer);
            this.PnlCustomerOrderActions.Location = new System.Drawing.Point(103, 226);
            this.PnlCustomerOrderActions.Name = "PnlCustomerOrderActions";
            this.PnlCustomerOrderActions.Size = new System.Drawing.Size(357, 221);
            this.PnlCustomerOrderActions.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EventsUnlimited.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(294, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 154);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PnlStockOrderActions
            // 
            this.PnlStockOrderActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlStockOrderActions.Controls.Add(this.btnStockOrder);
            this.PnlStockOrderActions.Location = new System.Drawing.Point(692, 226);
            this.PnlStockOrderActions.Name = "PnlStockOrderActions";
            this.PnlStockOrderActions.Size = new System.Drawing.Size(303, 221);
            this.PnlStockOrderActions.TabIndex = 3;
            // 
            // btnStockOrder
            // 
            this.btnStockOrder.Location = new System.Drawing.Point(22, 18);
            this.btnStockOrder.Name = "btnStockOrder";
            this.btnStockOrder.Size = new System.Drawing.Size(109, 40);
            this.btnStockOrder.TabIndex = 0;
            this.btnStockOrder.Text = "StockOrder";
            this.btnStockOrder.UseVisualStyleBackColor = true;
            // 
            // PnlSharedActions
            // 
            this.PnlSharedActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlSharedActions.Controls.Add(this.btnStock);
            this.PnlSharedActions.Controls.Add(this.btnSupplier);
            this.PnlSharedActions.Controls.Add(this.btnStaff);
            this.PnlSharedActions.Location = new System.Drawing.Point(367, 488);
            this.PnlSharedActions.Name = "PnlSharedActions";
            this.PnlSharedActions.Size = new System.Drawing.Size(628, 119);
            this.PnlSharedActions.TabIndex = 4;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(23, 18);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(104, 40);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnCustomerOrder
            // 
            this.btnCustomerOrder.Location = new System.Drawing.Point(23, 65);
            this.btnCustomerOrder.Name = "btnCustomerOrder";
            this.btnCustomerOrder.Size = new System.Drawing.Size(145, 34);
            this.btnCustomerOrder.TabIndex = 1;
            this.btnCustomerOrder.Text = "CustomerOrder";
            this.btnCustomerOrder.UseVisualStyleBackColor = true;
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(23, 116);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(83, 34);
            this.btnCard.TabIndex = 2;
            this.btnCard.Text = "Card";
            this.btnCard.UseVisualStyleBackColor = true;
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(120, 24);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(86, 39);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(247, 24);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(105, 39);
            this.btnSupplier.TabIndex = 1;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(393, 24);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(113, 39);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 678);
            this.ControlBox = false;
            this.Controls.Add(this.PnlSharedActions);
            this.Controls.Add(this.PnlStockOrderActions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PnlCustomerOrderActions);
            this.Controls.Add(this.BtnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Menu";
            this.Text = "Events Unlimited";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.PnlCustomerOrderActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlStockOrderActions.ResumeLayout(false);
            this.PnlSharedActions.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

