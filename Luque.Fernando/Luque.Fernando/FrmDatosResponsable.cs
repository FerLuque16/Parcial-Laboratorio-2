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

        public List<Aula> ListaAulas
        {

            set
            {
                aulas = value;
            }
        }



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
                
                cargarResponsable();
            }

            else
                MessageBox.Show("Debe seleccionar color y turno de sala", "ERROR", MessageBoxButtons.OK);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Verifica el turno y el color seleccionado y acorde a esto, llama al metodo cargar datos, y busca en cada aula
        /// con estos atributos, los responsables de cada alumno
        /// </summary>
        private void cargarResponsable()
        {
            if (cmbColorSala.Text == "Rojo")
            {
                foreach (Aula aula in aulas)
                {
                    if (aula.Turno.ToString() == cmbTurno.Text && aula.ColorSala.ToString() == "Rojo")
                        cargarDatos(aula);
                    

                }
            }

            else if (cmbColorSala.Text == "Amarillo")
            {
                foreach (Aula aula in aulas)
                {
                    if (aula.Turno.ToString() == cmbTurno.Text && aula.ColorSala.ToString() == "Amarillo")
                        cargarDatos(aula);
                   

                }
            }

            else if (cmbColorSala.Text == "Verde")
            {
                foreach (Aula aula in aulas)
                {
                    if (aula.Turno.ToString() == cmbTurno.Text && aula.ColorSala.ToString() == "Verde")
                        cargarDatos(aula);
                    

                }
            }

            else if (cmbColorSala.Text == "Naranja")
            {
                foreach (Aula aula in aulas)
                {
                    if(aula.Turno.ToString()==cmbTurno.Text && aula.ColorSala.ToString() == "Naranja")
                       
                    cargarDatos(aula);
                    
                }
            }
        }

        /// <summary>
        ///  Cargo los datos de cada responsable del alumno del aula 
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
        /// Setea los enumerados en los combobox
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

       
        
    }
}
