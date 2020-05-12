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
    public partial class FrmDatosResponsable : Form
    {
        static List<Aula> aulas;
        public FrmDatosResponsable()
        {
            InitializeComponent();
        }

        private void FrmDatosResponsable_Load(object sender, EventArgs e)
        {
            setComboBox();
        }
        

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (!(String.IsNullOrEmpty(cmbColorSala.Text)) || !(String.IsNullOrEmpty(cmbTurno.Text)))
            {
                //listView1.Items.Clear();
                cargarResponsable();
            }

            else
                MessageBox.Show("Debe seleccionar color y turno de sala", "ERROR", MessageBoxButtons.OK);


        }

        private void cargarResponsable()
        {
            if (cmbColorSala.Text == "Rojo")
            {
                foreach (Aula aula in aulas)
                {
                    if (aula.Turno.ToString() == cmbTurno.Text && aula.ColorSala.ToString()=="Rojo")
                        cargarDatos(aula);
                    //cargarDatos(aula,"Rojo");

                }
            }

            else if (cmbColorSala.Text == "Amarillo")
            {
                foreach (Aula aula in aulas)
                {
                    if (aula.Turno.ToString() == cmbTurno.Text && aula.ColorSala.ToString()=="Amarillo")
                        cargarDatos(aula);
                    // cargarDatos(aula,"Amarillo");

                }
            }

            else if (cmbColorSala.Text == "Verde")
            {
                foreach (Aula aula in aulas)
                {
                    if (aula.Turno.ToString() == cmbTurno.Text && aula.ColorSala.ToString()=="Verde")
                        cargarDatos(aula);
                    //cargarDatos(aula,"Verde");

                }
            }

            else if (cmbColorSala.Text == "Naranja")
            {
                foreach (Aula aula in aulas)
                {
                    if(aula.Turno.ToString()==cmbTurno.Text && aula.ColorSala.ToString()=="Naranja")
                       
                    cargarDatos(aula);
                    // cargarDatos(aula,"Naranja");
                }
            }
        }

        /// <summary>
        ///  Cargo los datos de cada alumno del aula 
        /// </summary>
        /// <param name="aula">Aula de donde saca la lista de alumnos</param>
      // private void cargarDatos(Aula aula,string color)
        private void cargarDatos(Aula aula)
        {
            List<Alumno> listaAlumnos=aula.Alumnos;

            foreach (Alumno alumno in listaAlumnos)
            {
               // if (alumno.ColorSala.ToString() == color)
                //{
                    ListViewItem lista = new ListViewItem(alumno.Responsable.Nombre);
                    lista.SubItems.Add(alumno.Responsable.Apellido);
                    lista.SubItems.Add(alumno.Responsable.Telefono);

                    listView1.Items.Add(lista);
                //}
                
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void setComboBox()
        {
            cmbColorSala.Items.Add(EColores.Amarillo);
            cmbColorSala.Items.Add(EColores.Naranja);
            cmbColorSala.Items.Add(EColores.Verde);
            cmbColorSala.Items.Add(EColores.Rojo);
            cmbTurno.Items.Add(Eturno.mañana);
            cmbTurno.Items.Add(Eturno.tarde);
        }

        public List<Aula> ListaAulas
        {

            set
            {
                aulas = value;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
