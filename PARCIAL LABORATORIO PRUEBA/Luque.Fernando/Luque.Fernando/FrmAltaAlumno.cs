using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Luque.Fernando
{
    public partial class FrmAltaAlumno : FrmDatos
    {
        private int legajo;
        private float precioCuota;
        EColores colorSala;
        private Alumno alumno;
      
        public FrmAltaAlumno()
        {     
            InitializeComponent();

            
        }

        

        private void btnConfirmar_Click(object sender, EventArgs e)
        { 
          // if(String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || !(int.TryParse(txtDni.Text,out this.dni)) 
            //  || !(int.TryParse(txtLegajo.Text,out this.legajo)) || !(float.TryParse(txtCuota.Text,out this.precioCuota)) || int.TryParse(txtNombre.Text, out this.nombre) || int.TryParse(txtApellido.Text,out this.apellido))
           if(!(base.validarDatos()) || String.IsNullOrEmpty(cmbColorSala.Text)||!(int.TryParse(txtLegajo.Text, out this.legajo)) || !(float.TryParse(txtCuota.Text, out this.precioCuota)))
            {
                FrmPrincipal.mensajeError();

            }
            else
            {
            
                alumno = new Alumno(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), base.esFemenino(cmbSexo.Text), this.precioCuota);
                alumno.Legajo = this.legajo;
                alumno.ColorSala = colorDeSala(cmbColorSala.Text);

                FrmAltaResponsable altaResponsable = new FrmAltaResponsable();

                this.Hide();
                DialogResult resultado=altaResponsable.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                   
                    alumno.Responsable = altaResponsable.Responsable;
                    this.DialogResult = DialogResult.OK;

                   
                }
                else
                {
                    MessageBox.Show("No se ha agregado al responsable");
                    this.DialogResult = DialogResult.Cancel;
                }
               

            }
        }
       

        public Alumno Alumno
        {
            get
            { 
                return this.alumno;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private EColores colorDeSala(string stringColor)
        {
            EColores auxColor=0;

            switch (stringColor)
            {
                case "Naranja":
                    auxColor = EColores.Naranja;
                    break;

                case "Amarillo":
                    auxColor = EColores.Amarillo;
                    break;

                case "Rojo":
                    auxColor = EColores.Rojo;
                    break;

                case "Verde":
                    auxColor = EColores.Verde;
                    break;

            }

            return auxColor;

        }

    }
}
