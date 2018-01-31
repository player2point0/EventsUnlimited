namespace EventsUnlimited
{
    partial class FrmOverview
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
            this.LstDisplay = new System.Windows.Forms.ListView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstDisplay
            // 
            this.LstDisplay.Location = new System.Drawing.Point(33, 26);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(1119, 598);
            this.LstDisplay.TabIndex = 0;
            this.LstDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(475, 653);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(229, 79);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LstDisplay);
            this.Name = "FrmOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LstDisplay;
        private System.Windows.Forms.Button BtnClose;
    }
}