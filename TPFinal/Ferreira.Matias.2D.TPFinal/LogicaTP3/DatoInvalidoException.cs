using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTP3
{
    public class DatoInvalidoException : Exception
    {
        public DatoInvalidoException(string message) : base(message)
        {
        }

        public DatoInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
