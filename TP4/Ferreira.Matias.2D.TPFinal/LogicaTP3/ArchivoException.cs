using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTP4
{
    class ArchivoException : Exception
    {
        public ArchivoException(string message) : base(message)
        {
        }

        public ArchivoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
