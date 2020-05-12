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
    public partial class FrmAltaResponsable : FrmDatos
    {

        /*     

                private void btnConfirmar_Click(object sender, EventArgs e)
                {
                    if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || !(int.TryParse(txtDni.Text, out this.dni)) || !(double.TryParse(txtTelefono.Text,out this.telefonoParse)))

                    {
                        Form1.mensajeError();
                        //MessageBox.Show("Debe llenar todos los campos", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        this.nombre = txtNombre.Text;
                        this.apellido = txtApellido.Text;
                        this.telefono = txtTelefono.Text;
                        this.esFemenino = false;
                        this.parentesco = EParentesco.Padre;

                        responsable = new Responsable(txtNombre.Text, txtApellido.Text, this.dni, false, EParentesco.Padre, txtTelefono.Text);
                        this.DialogResult = DialogResult.OK;



                    }
                }

                private void btnCancelar_Click(object sender, EventArgs e)
                {
                    this.DialogResult = DialogResult.Cancel;
                }


                /*public Responsable devolverResponsable()
                {

                    Responsable responsable = new Responsable(this.nombre, this.apellido, this.dni, this.esFemenino, this.parentesco, this.telefono);

                    return responsable; 
                }*/



        
        


        private double telefonoParse;
        //private  int dni,nombre, apellido;     
        private EParentesco parentesco;
        private Responsable responsable;

        public FrmAltaResponsable()
        {
            InitializeComponent();
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || !(int.TryParse(txtDni.Text, out this.dni))
              //   || int.TryParse(txtNombre.Text, out this.nombre) || int.TryParse(txtApellido.Text, out this.apellido)|| !(double.TryParse(txtTelefono.Text,out telefonoParse)))

            if(!(base.validarDatos()) || !(double.TryParse(txtTelefono.Text, out telefonoParse)))
            {
                FrmPrincipal.mensajeError();
            }
            else
            {
                responsable = new Responsable(txtNombre.Text, txtApellido.Text,int.Parse(txtDni.Text), base.esFemenino(cmbSexo.Text), saberParentesco(cmbParentezco.Text), txtTelefono.Text);
                this.DialogResult = DialogResult.OK;

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public Responsable Responsable
        {
            get
            {
                return this.responsable;
            }

        }

        private EParentesco saberParentesco(string parentesco)
        {
            EParentesco aux = 0;

            switch(parentesco)
            {
                case "Madre":
                    aux = EParentesco.Madre;               
                    break;

                case "Padre":
                    aux = EParentesco.Padre;
                    break;

                case "Tio":
                    aux = EParentesco.Tio;
                    break;

                case "Tia":
                    aux = EParentesco.Tia;
                    break;

                case "Abuelo":
                    aux = EParentesco.Abuelo;
                    break;

                case "Abuela":
                    aux = EParentesco.Abuela;
                    break;

                case "Otro":
                    aux = EParentesco.Otro;
                    break;
                    
            }

            return aux;
        }

    }
}
