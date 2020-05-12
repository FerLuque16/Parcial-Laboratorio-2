using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Personal
    {
        private double valorHora;

		public int HorasMensuales
		{
			get 
			{

				
				int horasDiarias;

				horasDiarias = this.HoraSalida.Hour - this.HoraEntrada.Hour;

				return horasDiarias*20; 
			}
			
		}


		public double ValorHora
		{
			get 
			{ 
				return this.valorHora; 
			}
			set 
			{ 
				this.valorHora = value; 
			}
		}

		public Docente(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, double valorHora):base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
		{
			/*this.Nombre = nombre;
			this.Apellido = apellido;
			this.Dni = dni;
			this.Femenino = femenino;
			this.HoraEntrada = horaEntrada;
			this.HoraSalida = horaSalida;*/
			this.valorHora = valorHora;

		}



		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(base.ToString());
			sb.AppendLine("Valor por hora: " + this.valorHora);

			return sb.ToString();
		}


		public override double CalcularSalario()
		{
			DateTime entrada = this.HoraEntrada;
			DateTime salida = this.HoraSalida;

			int horaEntrada;
			int horaSalida;
			int horasDiarias;

			horaEntrada = entrada.Hour;
			horaSalida = salida.Hour;

			horasDiarias = horaSalida - horaEntrada;

			return this.valorHora * horasDiarias * 20;

		
		}

	}
}
