using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

   /* public enum ECargo
    {
        Porteria = 100,
        Cocina = 110,
        Secretaria = 140,
        Tesoreria = 240,
        Direccion = 180

    }*/


    public abstract class Personal : Persona
    {
        private DateTime horaEntrada;
        private DateTime horaSalida;


        public DateTime HoraEntrada
        {
            get 
            { 
                return this.horaEntrada; 
            }
            set
            { 
                this.horaEntrada = value; 
            }
        }

        public DateTime HoraSalida
        {
            get 
            { 
                return this.horaSalida;
            }
            set 
            { 
                this.horaSalida = value; 
            }
        }

       

        public double Salario
        {
            get 
            { 
                return this.CalcularSalario();
            }
            
        }

        protected Personal(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida):base(nombre,apellido,dni,femenino)
        {
            /*this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Femenino = femenino;*/
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
        }

        public abstract double CalcularSalario();

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Hora de entrada: " + horaEntrada);
            sb.AppendLine("Hora de salida: " + horaSalida);

            return sb.ToString();
        }
    }
}
