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
    public partial class FrmAula : Form
    {

        List<Docente> listaDocentes;
        List<Alumno> listaAlumnos;
        List<Alumno> listaAlumnosSinAula;
        List<Alumno> listaAlumnosDelAula;
       
        Aula aula;
      
        EColores color;

        #region Propiedades
        public EColores Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
            }
        }

        public List<Alumno> ListaAlumnos
        {
            get
            {
                return listaAlumnos;
            }
            set
            {
                listaAlumnos = value;
            }
        }

        public List<Alumno> ListaAlumnosDelAula
        {
            get
            {
                return listaAlumnosDelAula;
            }
            set
            {
                listaAlumnosDelAula = value;
            }
        }


        public List<Alumno> ListaAlumnosSinAula
        {
            get
            {
                return listaAlumnosSinAula;
            }
            set
            {
                listaAlumnosSinAula = value;
            }
        }

        #endregion


        public FrmAula()
        {
            InitializeComponent();           
        }

        private void FrmAula_Load(object sender, EventArgs e)
        {
            listaAlumnosSinAula = new List<Alumno>();
            listaAlumnosDelAula = new List<Alumno>();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lbProfesores.SelectedIndex == -1 || String.IsNullOrEmpty(cmbTurno.Text) || listaAlumnosDelAula.Count==0)
            {
                MessageBox.Show("Debe seleccionar profesor , turno y asignar alumnos al aula", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                //int index;
                //index = lbProfesores.SelectedIndex;

                
                aula = new Aula(this.color, saberTurno(cmbTurno.Text), listaDocentes[lbProfesores.SelectedIndex]);
                listaDocentes.RemoveAt(lbAlumnosAula.SelectedIndex);
                aula.Alumnos = listaAlumnosDelAula;

                foreach ( Alumno alumno in listaAlumnosDelAula )
                {
                    if (!(aula + alumno))
                    {
                        this.DialogResult = DialogResult.Abort;
                    }
                    
                }
                this.DialogResult = DialogResult.OK;

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            int index = lbAlumnosSinAula.SelectedIndex;


            //lbAlumnosAula.Items.Add(listaAlumnosSinAula[index].ToString());
            if(lbAlumnosAula.Items.Count<30)
            {
                lbAlumnosAula.Items.Add(mostrarDatos(listaAlumnosSinAula[index]));//Agrego el alumno seleccionado al listbox del aula
                lbAlumnosSinAula.Items.Remove(lbAlumnosSinAula.SelectedItem);//Remuevo el alumno seleccionado del listbox de alumnos sin aula

                listaAlumnosDelAula.Add(listaAlumnosSinAula[index]);//Agrego a la lista del aula el alumno seleccionado pero sacandolo de la lista de alumnos
                listaAlumnosSinAula.RemoveAt(index);//Remuevo el alumno asignado al aula
            }
            else
            {
                MessageBox.Show("No puede asignar mas de 30 alumnos al aula", "ERROR", MessageBoxButtons.OK);
            }


        }


        private void btnCargaLista_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbTurno.Text))
            {

                MessageBox.Show("Debe seleccionar el turno para cargar la lista", "ERROR", MessageBoxButtons.OK);

            }
            else
            {
                filtrarAlumnos();//Filtro la lista recibida desde FrmPrincipal
                cargarAlumnos();//Cargo el filtrado en el listbox
                cargarDocentes();//Cargo los docentes
                             
            }

        }


        



        

        /// <summary>
        /// Retorna el enumerado turno que se selecciona en el combobox
        /// </summary>
        /// <param name="turno"></param>
        /// <returns></returns>
        private Eturno saberTurno(string turno)
        {
            Eturno auxTurno = 0;

            if (turno == "mañana")
                auxTurno = Eturno.mañana;

            else
                auxTurno = Eturno.tarde;

            return auxTurno;
        }


        /// <summary>
        /// Carga los alumnos ya filtrados en el listbox
        /// </summary>
        public void cargarAlumnos()
        {

            foreach (Alumno alumno in listaAlumnosSinAula)
            {
                lbAlumnosSinAula.Items.Add(mostrarDatos(alumno));
            }              

        }


        /// <summary>
        /// Filtra los alumnos acorde al color de aula que se esta por asignar
        /// </summary>
        public void filtrarAlumnos()
        {
            foreach (Alumno alumno in listaAlumnos)
            {
                if(alumno.ColorSala ==this.color)
                {
                    listaAlumnosSinAula.Add(alumno);
                }
            }
           
        }

        /// <summary>
        ///  Carga los docentes al listbox dependiendo del turno que tenga
        /// </summary>
        public void cargarDocentes()
        {
            lbProfesores.Items.Clear();


            if(cmbTurno.Text=="mañana")
            {
                listaDocentes = FrmPrincipal.DocentesMañana;
                 foreach (Docente docente in listaDocentes)
                 {
                     lbProfesores.Items.Add(mostrarDatos(docente));
                 }

                //lbProfesores.DataSource = listaDocentes;

            }
            else if(cmbTurno.Text=="tarde")
            {
                listaDocentes = FrmPrincipal.DocentesTarde;
                 foreach (Docente docente in listaDocentes)
                 {
                     lbProfesores.Items.Add(mostrarDatos(docente));
                 }

                //lbProfesores.DataSource = listaDocentes;
            }
                
            
        }

        /// <summary>
        /// Retorna un string con los datos de la persona para asignar al listbox
        /// </summary>
        /// <param name="item">Persona de donde saco los datos</param>
        /// <returns>String con los datos de la persona</returns>
        private string mostrarDatos(Persona item)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(item.Nombre);
            sb.AppendLine(" ");
            sb.AppendLine(item.Apellido);
            return sb.ToString();
        }




       

       




        public Aula Aula
        {
            get 
            { 
                return aula;
            }
            
        }



        /* public List<Alumno> setearListasColor(List<Alumno>,EColores color)
         {

         }*/

        // public 

        /* private string mostrarDatosalumno(Alumno alumno)
         {
             StringBuilder sb = new StringBuilder();
             sb.AppendLine(alumno.Nombre);
             sb.AppendLine(" ");
             sb.AppendLine(alumno.Apellido);
             return sb.ToString();
         }*/




    }
}
