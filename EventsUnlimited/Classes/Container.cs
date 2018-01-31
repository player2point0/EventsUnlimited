using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsUnlimited
{
    class Container
    {
        private string displaydata;
        private string id;

        public Container(string _id, string _displayData)
        {
            id = _id;
            displaydata = _displayData;
        }

        public string Id
        {
            get { return id; }
        }

        public override string ToString()
        {
            return displaydata;
        }
    }
}
