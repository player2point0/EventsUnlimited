﻿namespace EventsUnlimited
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
            this.LsvDisplay = new System.Windows.Forms.ListView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LsvDisplay
            // 
            this.LsvDisplay.Location = new System.Drawing.Point(12, 12);
            this.LsvDisplay.Name = "LsvDisplay";
            this.LsvDisplay.Size = new System.Drawing.Size(1154, 635);
            this.LsvDisplay.TabIndex = 0;
            this.LsvDisplay.UseCompatibleStateImageBehavior = false;
            this.LsvDisplay.View = System.Windows.Forms.View.Details;
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
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.ControlBox = false;
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LsvDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LsvDisplay;
        private System.Windows.Forms.Button BtnClose;
    }
}