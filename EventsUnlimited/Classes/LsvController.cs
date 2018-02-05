using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EventsUnlimited
{
    class LsvController
    {
        public LsvController(ref ListView display, string[] columns)
        {
            for (int i = 0; i < columns.Length; i++)
            {
                display.Columns.Add(columns[i]);
            }   
        }

        public void AddRow(ref ListView display, string[] values)
        {
            if (values.Length == 0) return;

            ListViewItem item = new ListViewItem(values[0]);

            for (int i = 1; i < values.Length; i++)
            {
                item.SubItems.Add(values[i]);
            }

            display.Items.Add(item);
        }
    }
}
