using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ApellidoVacioException : Exception
    {

        public ApellidoVacioException(string message, Exception innerException):base(message,innerException)
        { }

        public ApellidoVacioException(string message):base(message)
        { }


    }
}
