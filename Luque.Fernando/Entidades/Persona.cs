using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int dni;
        private bool femenino;

        public string Apellido
        {
            get            
            { 
                return this.apellido; 
            }
            set 
            {
                //ValidarApellido(value);
                this.apellido = value; 
            }
        }

        public string Nombre
        {
            get
            { 
                return this.nombre; 
            }
            set 
            {
                //ValidarNombre(value);
                this.nombre = value; 
            }
        }


        public int Dni
        {
            get 
            { 
                return this.dni; 
            }
            set 
            {
                //ValidarPersonaSinDNI(value);
                this.dni = value; 
            }
        }

        public bool Femenino
        {
            get 
            { 
                return this.femenino; 
            }
            set 
            {
                this.femenino = value;
            }
        }

        protected Persona(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }

        protected Persona(string nombre, string apellido, int dni, bool femenino):this(nombre,apellido,dni)
        {
            this.femenino = femenino;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + nombre);
            sb.AppendLine("Apellido: " + apellido);
            sb.AppendLine("Dni: " + dni);
            if(femenino==true)
            {
                sb.AppendLine("Sexo: Femenino");
            }
            else
            {
                sb.AppendLine("Sexo: Masculino");
            }


            return sb.ToString();
        }


       /* public void ValidarPersonaSinDNI(int value)
        {
            if(value <1000000)
            {
                throw new AlumnoSinDniException("DNI No Valido");
            }
        }

        public void ValidarNombre(string value)
        {
            if (value == string.Empty)
            {
                throw new NombreVacioException("Nombre vacio");
            }
        }

        public void ValidarApellido(string value)
        {
            if(value == string.Empty)
            {
                throw new ApellidoVacioException("Apellido vacio");
            }
        }*/

        
    }
}
