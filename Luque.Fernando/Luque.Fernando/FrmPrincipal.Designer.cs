namespace Luque.Fernando
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rojoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amarilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naranjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDeLosPadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDeLosDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDeLosNoDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.cargarPruebaToolStripMenuItem,
            this.videosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(846, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeDocenteToolStripMenuItem,
            this.altaNoDocenteToolStripMenuItem,
            this.altaDeAlumnoToolStripMenuItem,
            this.altaDeAulaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altaDeDocenteToolStripMenuItem
            // 
            this.altaDeDocenteToolStripMenuItem.Name = "altaDeDocenteToolStripMenuItem";
            this.altaDeDocenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeDocenteToolStripMenuItem.Text = "Alta de Docente";
            this.altaDeDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDeDocenteToolStripMenuItem_Click);
            // 
            // altaNoDocenteToolStripMenuItem
            // 
            this.altaNoDocenteToolStripMenuItem.Name = "altaNoDocenteToolStripMenuItem";
            this.altaNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaNoDocenteToolStripMenuItem.Text = "Alta no Docente";
            this.altaNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaNoDocenteToolStripMenuItem_Click);
            // 
            // altaDeAlumnoToolStripMenuItem
            // 
            this.altaDeAlumnoToolStripMenuItem.Name = "altaDeAlumnoToolStripMenuItem";
            this.altaDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeAlumnoToolStripMenuItem.Text = "Alta de Alumno";
            this.altaDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaDeAlumnoToolStripMenuItem_Click);
            // 
            // altaDeAulaToolStripMenuItem
            // 
            this.altaDeAulaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rojoToolStripMenuItem,
            this.amarilloToolStripMenuItem,
            this.verdeToolStripMenuItem,
            this.naranjaToolStripMenuItem});
            this.altaDeAulaToolStripMenuItem.Name = "altaDeAulaToolStripMenuItem";
            this.altaDeAulaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeAulaToolStripMenuItem.Text = "Alta de Aula";
            // 
            // rojoToolStripMenuItem
            // 
            this.rojoToolStripMenuItem.Name = "rojoToolStripMenuItem";
            this.rojoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rojoToolStripMenuItem.Text = "Rojo";
            this.rojoToolStripMenuItem.Click += new System.EventHandler(this.rojoToolStripMenuItem_Click);
            // 
            // amarilloToolStripMenuItem
            // 
            this.amarilloToolStripMenuItem.Name = "amarilloToolStripMenuItem";
            this.amarilloToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.amarilloToolStripMenuItem.Text = "Amarillo";
            this.amarilloToolStripMenuItem.Click += new System.EventHandler(this.amarilloToolStripMenuItem_Click);
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.verdeToolStripMenuItem.Text = "Verde";
            this.verdeToolStripMenuItem.Click += new System.EventHandler(this.verdeToolStripMenuItem_Click);
            // 
            // naranjaToolStripMenuItem
            // 
            this.naranjaToolStripMenuItem.Name = "naranjaToolStripMenuItem";
            this.naranjaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.naranjaToolStripMenuItem.Text = "Naranja";
            this.naranjaToolStripMenuItem.Click += new System.EventHandler(this.naranjaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDeLosPadresToolStripMenuItem,
            this.sueldoDeLosDocentesToolStripMenuItem,
            this.sueldoDeLosNoDocentesToolStripMenuItem,
            this.recaudacionToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reporteToolStripMenuItem.Text = "Reportes";
            // 
            // informacionDeLosPadresToolStripMenuItem
            // 
            this.informacionDeLosPadresToolStripMenuItem.Name = "informacionDeLosPadresToolStripMenuItem";
            this.informacionDeLosPadresToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.informacionDeLosPadresToolStripMenuItem.Text = "Informacion de los padres";
            this.informacionDeLosPadresToolStripMenuItem.Click += new System.EventHandler(this.informacionDeLosPadresToolStripMenuItem_Click);
            // 
            // sueldoDeLosDocentesToolStripMenuItem
            // 
            this.sueldoDeLosDocentesToolStripMenuItem.Name = "sueldoDeLosDocentesToolStripMenuItem";
            this.sueldoDeLosDocentesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.sueldoDeLosDocentesToolStripMenuItem.Text = "Sueldo de los docentes";
            this.sueldoDeLosDocentesToolStripMenuItem.Click += new System.EventHandler(this.sueldoDeLosDocentesToolStripMenuItem_Click);
            // 
            // sueldoDeLosNoDocentesToolStripMenuItem
            // 
            this.sueldoDeLosNoDocentesToolStripMenuItem.Name = "sueldoDeLosNoDocentesToolStripMenuItem";
            this.sueldoDeLosNoDocentesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.sueldoDeLosNoDocentesToolStripMenuItem.Text = "Sueldo de los no docentes";
            this.sueldoDeLosNoDocentesToolStripMenuItem.Click += new System.EventHandler(this.sueldoDeLosNoDocentesToolStripMenuItem_Click);
            // 
            // recaudacionToolStripMenuItem
            // 
            this.recaudacionToolStripMenuItem.Name = "recaudacionToolStripMenuItem";
            this.recaudacionToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.recaudacionToolStripMenuItem.Text = "Recaudacion ";
            this.recaudacionToolStripMenuItem.Click += new System.EventHandler(this.recaudacionDeCadaAulaToolStripMenuItem_Click);
            // 
            // cargarPruebaToolStripMenuItem
            // 
            this.cargarPruebaToolStripMenuItem.Name = "cargarPruebaToolStripMenuItem";
            this.cargarPruebaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.cargarPruebaToolStripMenuItem.Text = "Cargar prueba";
            this.cargarPruebaToolStripMenuItem.Click += new System.EventHandler(this.cargarPruebaToolStripMenuItem_Click);
            // 
            // videosToolStripMenuItem
            // 
            this.videosToolStripMenuItem.Name = "videosToolStripMenuItem";
            this.videosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.videosToolStripMenuItem.Text = "Videos";
            this.videosToolStripMenuItem.Click += new System.EventHandler(this.videosToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 476);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDeLosPadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDeLosDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDeLosNoDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rojoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amarilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naranjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPruebaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videosToolStripMenuItem;
    }
}

