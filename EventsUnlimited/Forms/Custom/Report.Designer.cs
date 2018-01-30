namespace EventsUnlimited
{
    partial class FrmReport
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
            this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.eventsUnlimitedDataSet = new EventsUnlimited.EventsUnlimitedDataSet();
            this.customerCardTableAdapter = new EventsUnlimited.EventsUnlimitedDataSetTableAdapters.CustomerCardTableAdapter();
            this.customerTableAdapter = new EventsUnlimited.EventsUnlimitedDataSetTableAdapters.CustomerTableAdapter();
            this.CustomerCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventsUnlimitedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerCardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(424, 551);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(174, 53);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ReportViewer
            // 
            reportDataSource1.Name = "CardList";
            reportDataSource1.Value = this.CustomerCardBindingSource;
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer.LocalReport.ReportEmbeddedResource = "EventsUnlimited.Reports.Card.rdlc";
            this.ReportViewer.Location = new System.Drawing.Point(13, 13);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.ServerReport.BearerToken = null;
            this.ReportViewer.Size = new System.Drawing.Size(998, 532);
            this.ReportViewer.TabIndex = 2;
            // 
            // eventsUnlimitedDataSet
            // 
            this.eventsUnlimitedDataSet.DataSetName = "EventsUnlimitedDataSet";
            this.eventsUnlimitedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerCardTableAdapter
            // 
            this.customerCardTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerCardBindingSource
            // 
            this.CustomerCardBindingSource.DataMember = "CustomerCard";
            this.CustomerCardBindingSource.DataSource = this.eventsUnlimitedDataSet;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 642);
            this.Controls.Add(this.ReportViewer);
            this.Controls.Add(this.BtnClose);
            this.Name = "FrmReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsUnlimitedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerCardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnClose;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
        private EventsUnlimitedDataSet eventsUnlimitedDataSet;
        private EventsUnlimitedDataSetTableAdapters.CustomerCardTableAdapter customerCardTableAdapter;
        private EventsUnlimitedDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource CustomerCardBindingSource;
    }
}