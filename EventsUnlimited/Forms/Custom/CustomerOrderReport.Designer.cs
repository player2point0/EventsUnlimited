﻿namespace EventsUnlimited
{
    partial class FrmCustomerOrderReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CustomerOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EventsUnlimitedDataSet = new EventsUnlimited.EventsUnlimitedDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CustomerOrderTableAdapter = new EventsUnlimited.EventsUnlimitedDataSetTableAdapters.CustomerOrderTableAdapter();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsUnlimitedDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerOrderBindingSource
            // 
            this.CustomerOrderBindingSource.DataMember = "CustomerOrder";
            this.CustomerOrderBindingSource.DataSource = this.EventsUnlimitedDataSet;
            // 
            // EventsUnlimitedDataSet
            // 
            this.EventsUnlimitedDataSet.DataSetName = "EventsUnlimitedDataSet";
            this.EventsUnlimitedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "CustomerOrderList";
            reportDataSource1.Value = this.CustomerOrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EventsUnlimited.Reports.CustomerOrder.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1140, 645);
            this.reportViewer1.TabIndex = 0;
            // 
            // CustomerOrderTableAdapter
            // 
            this.CustomerOrderTableAdapter.ClearBeforeFill = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(506, 681);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(174, 51);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmCustomerOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmCustomerOrderReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOrderReport";
            this.Load += new System.EventHandler(this.CustomerOrderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsUnlimitedDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CustomerOrderBindingSource;
        private EventsUnlimitedDataSet EventsUnlimitedDataSet;
        private EventsUnlimitedDataSetTableAdapters.CustomerOrderTableAdapter CustomerOrderTableAdapter;
        private System.Windows.Forms.Button BtnClose;
    }
}