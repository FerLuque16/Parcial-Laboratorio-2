using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*public enum EColores
    {
        Naranja, Rojo, Amarillo, Verde
    }*/

    public class Aula
    {
        private List<Alumno> alumnos;
        private EColores colorSala;
        private Docente docente;
        private Eturno turno;


        public List<Alumno> Alumnos
        {
            get
            { 
                return this.alumnos;
            }
            set 
            { 
                this.alumnos = value; 
            }
        }


        public EColores ColorSala
        {
            get 
            { 
                return this.colorSala; 
            }
            set 
            { 
                this.colorSala = value; 
            }
        }


        public Docente Docente
        {
            get 
            { 
                return this.docente; 
            }
            set 
            { 
                this.docente = value; 
            }
        }

        public Eturno Turno
        {
            get 
            { 
                return this.turno; 
            }
            set 
            { 
                this.turno = value; 
            }
        }

        public Aula(EColores colorSala, Eturno turno, Docente docente)
        {
            this.colorSala = colorSala;
            this.turno = turno;
            this.docente = docente;
        }

        public static bool operator +(Aula aula, Alumno alumno)
        {

            if(aula.alumnos.Count >=0 && aula.alumnos.Count<30)
            {
                if (alumno.ColorSala == aula.ColorSala)
                {
                    aula.alumnos.Add(alumno);
                    return true;
                }
            }           

            return false; 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
           
            sb.AppendLine("Color de la sala: " + this.colorSala);
            sb.AppendLine("Turno: " + this.turno);
            sb.AppendLine(this.docente.Nombre);
            return sb.ToString();
        }


    }
}
