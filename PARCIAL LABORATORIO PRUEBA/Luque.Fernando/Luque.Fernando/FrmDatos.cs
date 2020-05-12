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

   
    public partial class FrmDatos : Form
    {
       

        public FrmDatos()
        {
            InitializeComponent();
            
        }

       public bool validarDatos()
        {
            int nombre,apellido,dni;
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || !(int.TryParse(txtDni.Text, out dni))
                 || int.TryParse(txtNombre.Text, out nombre) || int.TryParse(txtApellido.Text, out apellido) || String.IsNullOrEmpty(cmbSexo.Text))
            {
                return false;
            }
            else
                return true;
        }

        

        public bool esFemenino(string sexo)
        {
            bool retorno = false;

            if (sexo == "Femenino")
                retorno=true;

            return retorno;

        }

        

    }
}
