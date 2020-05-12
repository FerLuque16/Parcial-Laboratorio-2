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
       /* List<Alumno> listaAlumnosRojo;
        List<Alumno> listaAlumnosAmarillo;
        List<Alumno> listaAlumnosVerde;
        List<Alumno> alumnosNaranja;*/
        Aula aula;
        Alumno alumno;
        EColores color;

        
        public FrmAula()
        {
            InitializeComponent();
            //cmbTurno.DataSource=
            //listaAlumnosSinAula = FrmPrincipal.ListaAlumnos;        
            //cargarAlumnos();
            //listaDocentes = FrmPrincipal.Docentes;
            // = FrmPrincipal.Alumnos;


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
                int index;
                index = lbProfesores.SelectedIndex;


                //listaDocentes[index].ToString();
                aula = new Aula(this.color, saberTurno(cmbTurno.Text), listaDocentes[lbProfesores.SelectedIndex]);
                aula.Alumnos = listaAlumnosDelAula;





            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            int index = lbAlumnosSinAula.SelectedIndex;

            /*if(aula + listaAlumnosSinAula[index])
            {
                listaAlumnosSinAula.Remove(listaAlumnosSinAula[index]);
                lbAlumnosAula.DataSource = aula.Alumnos;
                
            }*/
           

            //lbAlumnosAula.Items.Add(listaAlumnosSinAula[index].ToString());//Agrego el alumno seleccionado al listbox del aula
            if(lbAlumnosAula.Items.Count<30)
            {
                lbAlumnosAula.Items.Add(mostrarDatos(listaAlumnosSinAula[index]));
                lbAlumnosSinAula.Items.Remove(lbAlumnosSinAula.SelectedItem);//Remuevo el alumno seleccionado del listbox de alumnos sin aula

                listaAlumnosDelAula.Add(listaAlumnosSinAula[index]);
                listaAlumnosSinAula.RemoveAt(index);//Remuevo el alumno asignado al aula
            }
            else
            {
                MessageBox.Show("No puede asignar mas de 30 alumnos al aula", "ERROR", MessageBoxButtons.OK);
            }
            

            //listaAlumnosDelAula = listaAlumnosRojo;
            //listaAlumnosDelAula.Add(listaAlumnosRojo[index]);



        }


        private void btnCargaLista_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbTurno.Text))
            {

                MessageBox.Show("Debe seleccionar el turno para cargar la lista", "ERROR", MessageBoxButtons.OK);

            }
            else
            {
                setearAlumnos();
                cargarAlumnos();
                //lbProfesores.Items.Clear();
                cargarDocentes();
                /*if (cmbTurno.Text == "mañana")
                {
                    lbProfesores.Items.Clear();
                    listaDocentes = FrmPrincipal.DocentesMañana;
                    foreach (Docente docente in listaDocentes)
                    {

                        lbProfesores.Items.Add(mostrarDatos(docente));

                    }
                }
                else if (cmbTurno.Text == "tarde")
                {
                    lbProfesores.Items.Clear();
                    listaDocentes = FrmPrincipal.DocentesTarde;
                    foreach (Docente docente in listaDocentes)
                    {

                        lbProfesores.Items.Add(mostrarDatos(docente));

                    }
                }*/




            }

        }


        private Eturno saberTurno(string turno)
        {
            Eturno auxTurno = 0;

            if (turno == "mañana")
                auxTurno = Eturno.mañana;

            else
                auxTurno = Eturno.tarde;

            return auxTurno;
        }



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

       public void cargarAlumnos()
        {

            foreach (Alumno alumno in listaAlumnosSinAula)
            {
                /* if(alumno.ColorSala==this.color)
                 {
                     listaAlumnosRojo.Add(alumno);
                     lbAlumnosSinAula.Items.Add(mostrarDatos(alumno));


                 }*/

                lbAlumnosSinAula.Items.Add(mostrarDatos(alumno));
            }

            //lbAlumnosAula.DataSource=aula.Alumnos;

        }

        public void setearAlumnos()
        {
            foreach (Alumno alumno in listaAlumnos)
            {
                if(alumno.ColorSala ==this.color)
                {
                    listaAlumnosSinAula.Add(alumno);
                }
            }
           
        }

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


        private string mostrarDatos(Persona item)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(item.Nombre);
            sb.AppendLine(" ");
            sb.AppendLine(item.Apellido);
            return sb.ToString();
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
