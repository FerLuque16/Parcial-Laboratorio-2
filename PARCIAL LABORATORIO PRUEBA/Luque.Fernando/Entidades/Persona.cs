using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
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
    }
}
