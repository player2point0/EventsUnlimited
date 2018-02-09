using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsUnlimited
{
    public partial class MultiTableTemplate : FrmTemplate
    {
        private int index;

        private List<string> StockIdToAdd;
        private List<string> QuantityToAdd;
        private bool newOrder;


        public MultiTableTemplate()
        {
            InitializeComponent();
        }
    }
}
