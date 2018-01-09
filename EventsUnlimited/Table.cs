using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsUnlimited
{
    class Table
    {
        private string name;
        private string[] primaryKeys;
        private bool compositeKey;
        private string[] fields;

        public Table(string _name, string[] _primaryKeys, bool _compositeKey, string[] _fields)
        {
            name = _name;
            primaryKeys = _primaryKeys;
            compositeKey = _compositeKey;
            fields = _fields;
        }




    }
}
