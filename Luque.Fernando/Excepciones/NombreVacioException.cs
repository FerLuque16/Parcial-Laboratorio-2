using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NombreVacioException : Exception
    {

        public NombreVacioException(string message, Exception innerException) : base(message, innerException)
        { }          

        public NombreVacioException(string message):base(message)
        { }
    }
}
