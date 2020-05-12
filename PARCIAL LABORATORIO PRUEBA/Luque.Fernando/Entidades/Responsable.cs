using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
   


    public class Responsable : Persona
    {
        private EParentesco parentesco;
        private string telefono;

        

        public EParentesco Parentezco
        {
            get 
            { 
                
                return this.parentesco;
            }
            set
            { 
                this.parentesco = value; 
            }
        }

        

        public string Telefono
        {
            get 
            { 
            
                return telefono; 
            }
            set 
            {
                telefono = value; 
            }
        }

        public Responsable(string nombre, string apellido, int dni, bool femenino, EParentesco parentesco, string telefono):base(nombre, apellido, dni, femenino)
        {
            /*this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Femenino = femenino;*/
            this.parentesco = parentesco;
            this.telefono = telefono;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Parentesco: " +parentesco);
            sb.AppendLine("Telefono: " +telefono);
            
            return sb.ToString();
        }
    }
}
