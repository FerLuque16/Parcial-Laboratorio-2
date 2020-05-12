using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrativo : Personal
    {
        private ECargo cargo;
        static double salarioBase;

        public ECargo Cargo
        {
            get 
            { 
                return this.cargo ; 
            }
            set 
            { 
                this.cargo = value;
            }
        }

        public Administrativo(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, ECargo cargo):base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            /*this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Femenino = femenino;
            this.HoraEntrada = horaEntrada;
            this.HoraSalida = horaSalida;*/
            this.cargo = cargo;
            
        }
        static Administrativo()
        {
            salarioBase = 30000;
        }

        public override double CalcularSalario()
        {
            double salario=0;

            switch(this.cargo)
            {
                case ECargo.Cocina:
                    salario = salarioBase * 1.10;
                    break;

                case ECargo.Direccion:
                    salario = salarioBase * 1.80;
                    break;

                case ECargo.Porteria:
                    salario = salarioBase * 1;
                    break;

                case ECargo.Secretaria:
                    salario = salarioBase * 1.40;
                    break;

                case ECargo.Tesoreria:
                    salario = salarioBase * 2.40;
                    break;

            }

            return salario;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Salario base: " + salarioBase);

            return sb.ToString();
        }
    }
}
