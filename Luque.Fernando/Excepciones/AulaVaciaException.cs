using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AulaVaciaException : Exception
    {

        public AulaVaciaException(string message, Exception innerException):base(message,innerException)
        {

        }

        public AulaVaciaException(string message):base (message)
        {

        }
    }
}
