using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTP4
{
    public class ConexionSQLException : Exception
    {
        public ConexionSQLException(string message) : base(message)
        {
        }

        public ConexionSQLException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
