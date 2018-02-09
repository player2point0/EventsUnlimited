namespace EventsUnlimited
{
    partial class FrmStockOrderReport
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EventsUnlimitedDataSet = new EventsUnlimited.EventsUnlimitedDataSet();
            this.StockOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockOrderTableAdapter = new EventsUnlimited.EventsUnlimitedDataSetTableAdapters.StockOrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EventsUnlimitedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(441, 429);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(128, 51);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "StockOrder";
            reportDataSource1.Value = this.StockOrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EventsUnlimited.StockOrder.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(996, 410);
            this.reportViewer1.TabIndex = 1;
            // 
            // EventsUnlimitedDataSet
            // 
            this.EventsUnlimitedDataSet.DataSetName = "EventsUnlimitedDataSet";
            this.EventsUnlimitedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StockOrderBindingSource
            // 
            this.StockOrderBindingSource.DataMember = "StockOrder";
            this.StockOrderBindingSource.DataSource = this.EventsUnlimitedDataSet;
            // 
            // StockOrderTableAdapter
            // 
            this.StockOrderTableAdapter.ClearBeforeFill = true;
            // 
            // FrmStockOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 530);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.BtnClose);
            this.Name = "FrmStockOrderReport";
            this.Text = "StockOrderReport";
            this.Load += new System.EventHandler(this.FrmStockOrderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventsUnlimitedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StockOrderBindingSource;
        private EventsUnlimitedDataSet EventsUnlimitedDataSet;
        private EventsUnlimitedDataSetTableAdapters.StockOrderTableAdapter StockOrderTableAdapter;
    }
}