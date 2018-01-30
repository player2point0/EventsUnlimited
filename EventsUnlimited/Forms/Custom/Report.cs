using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace EventsUnlimited
{
    public partial class FrmReport : Form
    {
        //LOAD REPORT DYNAMICALLY

        public FrmReport()
        {
            InitializeComponent();

            Control.ControlCollection controls = this.Controls;
            Program.SetColors(ref controls);
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventsUnlimitedDataSet.CustomerCard' table. You can move, or remove it, as needed.
            this.customerCardTableAdapter.Fill(this.eventsUnlimitedDataSet.CustomerCard);
            this.customerTableAdapter.Fill(this.eventsUnlimitedDataSet.Customer);

            //this.customerCardTableAdapter.Fill(this.eventsUnlimitedDataSet.CustomerCard);

            this.ReportViewer.RefreshReport();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
