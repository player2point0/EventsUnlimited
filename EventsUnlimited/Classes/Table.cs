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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string[] PrimaryKeys
        {
            get { return primaryKeys; }
            set { primaryKeys = value; }
        }
        public bool CompositeKey
        {
            get { return compositeKey; }
            set { compositeKey = value; }
        }
        public string[] Fields
        {
            get { return fields; }
            set { fields = value; }
        }
    }
}
