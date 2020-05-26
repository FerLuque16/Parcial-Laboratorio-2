using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlumnoSinDniException : Exception
    {


        public AlumnoSinDniException(string message, Exception innerException):base(message,innerException)
        {

        }

        public AlumnoSinDniException(string message):base(message)
        {

        }
    }
}
