using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Alumno : Persona
    {
        private EColores colorSala;
        private int legajo;
        private float precioCuota;
        private Responsable responsable;



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


        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {

                this.legajo = value;
            }
        }


        public float PrecioCuota
        {
            get
            {

                return this.precioCuota;
            }
            set
            {
                this.precioCuota = value;
            }
        }


        public Responsable Responsable
        {
            get
            {
                return this.responsable;
            }
            set
            {
                this.responsable = value;
            }
        }

        public Alumno(string nombre, string apellido, int dni, bool femenino, float precioCuota) : base(nombre, apellido, dni, femenino)
        {
            /*this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Femenino = femenino;*/
            this.precioCuota = precioCuota;
        }

       
        public static bool operator ==(Alumno a1, Alumno a2)
        {
            
            return a1.legajo == a2.legajo && (Responsable)a1 == (Responsable)a2; 
        }

        public static bool operator  !=(Alumno a1,Alumno a2)
        {
            return !(a1==a2);
        }

        public static implicit operator Responsable(Alumno al)
        {
            
            return al.responsable;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Color de la sala: "+this.colorSala);
            sb.AppendLine($"Legajo del Alumno: " +this.legajo);
            sb.AppendLine($"Precio de la couta: " + this.precioCuota);
            sb.AppendLine($"Responsable: \n" +this.responsable.ToString());


            return sb.ToString();
        }

    }
}
