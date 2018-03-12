using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsUnlimited
{
    class ValidationException : Exception
    {
        private string message;
        private string value;

        public ValidationException(string _message, string _value)
        {
            message = _message;
            value = _value;
        }

        public ValidationException(string _message)
        {
            message = _message;
            value = "";
        }

        public override string ToString()
        {
            return message+" : "+value;
        }
    }
}
