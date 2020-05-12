using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luque.Fernando
{
    public partial class FrmRecaudacion : Form
    {
        static List<Aula> listaAulas;


        public List<Aula> ListaAulas
        {

            set
            {
                listaAulas = value;
            }
        }


        public FrmRecaudacion()
        {
            InitializeComponent();
        }

        private void FrmRecaudacion_Load(object sender, EventArgs e)
        {
            

            float recaudacionTotal = 0;
            foreach (Aula aula in listaAulas)
            {
                ListViewItem lista = new ListViewItem(aula.ColorSala.ToString());
                lista.SubItems.Add(aula.Turno.ToString());
                lista.SubItems.Add(recaudacionAula(aula).ToString());


                recaudacionTotal +=recaudacionAula(aula);//Va sumando la recaudacion de cada aula de la lista de aulas

                listView1.Items.Add(lista);
            }

            lblTotal.Text = recaudacionTotal.ToString();
            
        }


        /// <summary>
        /// Hace el calculo y retorna el valor de la recaudacion del aula que se pasa como parametro
        /// </summary>
        /// <param name="aula">Es el aula de donde sacaremos la recaudacion</param>
        /// <returns>Retorna la recaudacion total del aula</returns>
        private float recaudacionAula(Aula aula)
        {

            List<Alumno> listaAlumnos;
            float recaudacion=0;

            
                listaAlumnos = aula.Alumnos;

                foreach (Alumno alumno in listaAlumnos)
                {

                    recaudacion += alumno.PrecioCuota;
                }
            

            return recaudacion;
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }



        /*public List<Alumno> AlumnosAula
        {
            get { return alumno; }
            
        }*/


    }
}
