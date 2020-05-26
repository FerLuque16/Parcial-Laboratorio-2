using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SumaAlumnoException : Exception
    {

        public SumaAlumnoException(string message, Exception innerException):base(message,innerException)
        {

        }
        public SumaAlumnoException(string message):base(message)
        {

        }
    }
}
