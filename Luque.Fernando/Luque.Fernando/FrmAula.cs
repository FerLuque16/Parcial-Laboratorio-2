using Entidades;
using Excepciones;
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
        List<Docente> listaDocentesTarde;
        List<Docente> listaDocentesMañana;
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

            listaAlumnosSinAula = new List<Alumno>();
            listaAlumnosDelAula = new List<Alumno>();
        }

        private void FrmAula_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lbProfesores.SelectedIndex == -1 || String.IsNullOrEmpty(cmbTurno.Text))
            {
                MessageBox.Show("Debe seleccionar profesor , turno y asignar alumnos al aula", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                //int index;
                //index = lbProfesores.SelectedIndex;

                try
                {
                    aula = new Aula(this.color, saberTurno(cmbTurno.Text), listaDocentes[lbProfesores.SelectedIndex]);
                    

                    
                    aula.Alumnos = listaAlumnosDelAula;
                    listaDocentes.RemoveAt(lbProfesores.SelectedIndex);
                    this.DialogResult = DialogResult.OK;

                }
                catch(AulaVaciaException error)
                {
                    MessageBox.Show(error.Message);
                }

                #region Codigo antiguo
                /*foreach (Alumno alumno in listaAlumnosDelAula)
                    {
                        if(!(aula + alumno))
                        {
                            this.DialogResult = DialogResult.Abort;
                        }
                    }*/
                /*aula = new Aula(this.color, saberTurno(cmbTurno.Text), listaDocentes[lbProfesores.SelectedIndex]);
                listaDocentes.RemoveAt(lbProfesores.SelectedIndex);
                aula.Alumnos = listaAlumnosDelAula;*/
                //eliminarAlumnosAsignado(listaAlumnosDelAula);

                /*foreach ( Alumno alumno in listaAlumnosDelAula )
                {
                    if (!(aula + alumno))
                    {
                        this.DialogResult = DialogResult.Abort;
                    }
                    
                }*/

                #endregion


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
            if(lbAlumnosAula.Items.Count<30 && lbAlumnosSinAula.SelectedIndex !=-1)
            {
                lbAlumnosAula.Items.Add(mostrarDatos(listaAlumnosSinAula[index]));//Agrego el alumno seleccionado al listbox del aula
                lbAlumnosSinAula.Items.Remove(lbAlumnosSinAula.SelectedItem);//Remuevo el alumno seleccionado del listbox de alumnos sin aula

                listaAlumnosDelAula.Add(listaAlumnosSinAula[index]);//Agrego a la lista del aula el alumno seleccionado pero sacandolo de la lista de alumnos
                

                //foreach (Alumno alumno in listaAlumnos)
                //{
                    //if (listaAlumnosSinAula[index] == alumno)
                      //  listaAlumnos.Remove(alumno);
                //}

                for (int i = 0; i < listaAlumnos.Count; i++)
                {
                    if (listaAlumnosSinAula[index] == listaAlumnos[i])

                    {
                        listaAlumnos.Remove(listaAlumnos[i]);
                        break;
                    }

                
                }
                listaAlumnosSinAula.RemoveAt(index);

                //Remuevo el alumno asignado al aula
            }
            else if(lbAlumnosSinAula.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un alumno", "ERROR", MessageBoxButtons.OK);
            }
            else if (lbAlumnosAula.Items.Count>30)
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
        /*public void cargarAlumnos()
        {

            foreach (Alumno alumno in listaAlumnosSinAula)
            {
                lbAlumnosSinAula.Items.Add(mostrarDatos(alumno));
            }              

        }*/

        public void cargarAlumnos()
        {

            foreach (Alumno alumno in listaAlumnos)
            {
                if (alumno.ColorSala == this.color)
                {
                    lbAlumnosSinAula.Items.Add(mostrarDatos(alumno));
                }
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
                listaDocentes = listaDocentesMañana;

               
                 foreach (Docente docente in listaDocentesMañana)
                 {
                     lbProfesores.Items.Add(mostrarDatos(docente));
                 }

                //lbProfesores.DataSource = listaDocentes;

            }
            else if(cmbTurno.Text=="tarde")
            {
                listaDocentes = listaDocentesTarde;
                 foreach (Docente docente in listaDocentesTarde)
                 {
                     lbProfesores.Items.Add(mostrarDatos(docente));
                 }

                //lbProfesores.DataSource = listaDocentes;
            }
                
            
        }

        /*public void eliminarAlumnosAsignado(List<Alumno> lista)
        {
            foreach (Alumno alumno in listaAlumnos)
            {
                foreach(Alumno alumno2 in lista)
                {
                    if (alumno == alumno2)
                        listaAlumnos.Remove(alumno);
                }
            }
        }*/

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

        /*public List<Docente> ListaDocentesTarde
        {

        }*/

      

        public List<Docente> ListaDocentesTarde
        {
            get 
            { 
                return listaDocentesTarde; 
            }
            set 
            { 
                listaDocentesTarde = value; 
            }
        }

        public List<Docente> ListaDocentesMañana
        {
            get
            {
                return listaDocentesMañana;
            }
            set
            {
                listaDocentesMañana = value;
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
