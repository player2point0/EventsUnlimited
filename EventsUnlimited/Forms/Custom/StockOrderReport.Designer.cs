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
            this.StockOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EventsUnlimitedDataSet = new EventsUnlimited.EventsUnlimitedDataSet();
            this.BtnClose = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StockOrderTableAdapter = new EventsUnlimited.EventsUnlimitedDataSetTableAdapters.StockOrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StockOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsUnlimitedDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // StockOrderBindingSource
            // 
            this.StockOrderBindingSource.DataMember = "StockOrder";
            this.StockOrderBindingSource.DataSource = this.EventsUnlimitedDataSet;
            // 
            // EventsUnlimitedDataSet
            // 
            this.EventsUnlimitedDataSet.DataSetName = "EventsUnlimitedDataSet";
            this.EventsUnlimitedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(506, 673);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(141, 49);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "StockOrderList";
            reportDataSource1.Value = this.StockOrderBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "EventsUnlimited.Reports.StockOrder.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(13, 13);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1153, 622);
            this.reportViewer.TabIndex = 1;
            // 
            // StockOrderTableAdapter
            // 
            this.StockOrderTableAdapter.ClearBeforeFill = true;
            // 
            // FrmStockOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.BtnClose);
            this.Name = "FrmStockOrderReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockOrderReport";
            this.Load += new System.EventHandler(this.StockOrderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsUnlimitedDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource StockOrderBindingSource;
        private EventsUnlimitedDataSet EventsUnlimitedDataSet;
        private EventsUnlimitedDataSetTableAdapters.StockOrderTableAdapter StockOrderTableAdapter;
    }
}