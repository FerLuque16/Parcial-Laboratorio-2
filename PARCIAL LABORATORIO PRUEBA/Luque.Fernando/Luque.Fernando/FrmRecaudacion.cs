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


                recaudacionTotal = recaudacionTotal +recaudacionAula(aula);

                listView1.Items.Add(lista);
            }

            lblRecaudacionTotal.Text = recaudacionTotal.ToString();
            
        }


        
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

        public List<Aula> ListaAulas
        {
            
            set
            {
                listaAulas = value; 
            }
        }

        

        /*public List<Alumno> AlumnosAula
        {
            get { return alumno; }
            
        }*/


    }
}
