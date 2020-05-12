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
    public partial class FrmVideos : Form
    {
        public FrmVideos()
        {
            InitializeComponent();
        }

        private void btnShark_Click(object sender, EventArgs e)
        {
            this.wmpVideo.URL = "https://examenprog.000webhostapp.com/Tiburoncito.mp4";
        }

        private void btnPeppa_Click(object sender, EventArgs e)
        {
            this.wmpVideo.URL = "https://examenprog.000webhostapp.com/Silbar.mp4";
        }

        private void btnBloopers_Click(object sender, EventArgs e)
        {
            this.wmpVideo.URL = "https://examenprog.000webhostapp.com/BloopersTS2.mp4";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
