using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luque.Fernando
{
    public partial class FrmPersonal : FrmDatos
    {

        double valorHora;
        ECargo cargo;

        Docente docente;
        Administrativo noDocente;
        public FrmPersonal()
        {
            InitializeComponent();
        }

        

        public bool Habilitar
        {
           
            set { cmbCargo.Enabled = value; }
        }
        public string SetDocente
        {
            set
            {
                cmbCargo.Text = value;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.cmbCargo.Text == "Docente")
            {
                if (!(base.validarDatos()) || !(double.TryParse(txtValorHora.Text, out this.valorHora)) || String.IsNullOrEmpty(cmbEntrada.Text) || String.IsNullOrEmpty(cmbSalida.Text))
                {
                    FrmPrincipal.mensajeError();
                }

                else
                {
                    docente = new Docente(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), esFemenino(cmbSexo.Text), DateTime.Parse(cmbEntrada.Text), DateTime.Parse(cmbSalida.Text),this.valorHora);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                if(!(base.validarDatos()) || String.IsNullOrEmpty(cmbEntrada.Text) || String.IsNullOrEmpty(cmbSalida.Text) || String.IsNullOrEmpty(cmbCargo.Text))
                {
                    FrmPrincipal.mensajeError();
                }

                else
                {
                    noDocente = new Administrativo(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), esFemenino(cmbSexo.Text), DateTime.Parse(cmbEntrada.Text), DateTime.Parse(cmbSalida.Text), saberCargo(cmbCargo.Text));
                    this.DialogResult = DialogResult.OK;
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }



        public System.Windows.Forms.ComboBoxStyle setDropDown
        {
           
            set
            { 
                this.cmbCargo.DropDownStyle = value;
            }
        }

        

        public Docente Docente
        {
            get
            { 
                return this.docente; 
            }
           
        }

        

        public Administrativo NoDocente
        {
            get 
            { 
                return this.noDocente; 
            }
            
        }

        private ECargo saberCargo(string stringCargo)
        {
            ECargo auxCargo=0;

            switch(stringCargo)
            {
                case "Porteria":
                    auxCargo = ECargo.Porteria;
                    break;

                case "Cocina":
                    auxCargo = ECargo.Cocina;
                    break;

                case "Secretaria":
                    auxCargo = ECargo.Secretaria;
                    break;

                case "Tesoreria":
                    auxCargo = ECargo.Tesoreria;
                    break;

                case "Direccion":
                    auxCargo = ECargo.Direccion;
                    break;
            }

            return auxCargo;

        }

       
    }
}
