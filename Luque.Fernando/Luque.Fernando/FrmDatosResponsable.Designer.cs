namespace Luque.Fernando
{
    partial class FrmDatosResponsable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnaNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbColorSala = new System.Windows.Forms.ComboBox();
            this.lblColorSala = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.lblTurno = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaNombre,
            this.columnaApellido,
            this.columnaTelefono});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(57, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(328, 342);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnaNombre
            // 
            this.columnaNombre.Text = "Nombre";
            this.columnaNombre.Width = 142;
            // 
            // columnaApellido
            // 
            this.columnaApellido.Text = "Apellido";
            this.columnaApellido.Width = 107;
            // 
            // columnaTelefono
            // 
            this.columnaTelefono.Text = "Telefono";
            this.columnaTelefono.Width = 75;
            // 
            // cmbColorSala
            // 
            this.cmbColorSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorSala.FormattingEnabled = true;
            this.cmbColorSala.Location = new System.Drawing.Point(57, 39);
            this.cmbColorSala.Name = "cmbColorSala";
            this.cmbColorSala.Size = new System.Drawing.Size(117, 21);
            this.cmbColorSala.TabIndex = 1;
            // 
            // lblColorSala
            // 
            this.lblColorSala.AutoSize = true;
            this.lblColorSala.Location = new System.Drawing.Point(54, 9);
            this.lblColorSala.Name = "lblColorSala";
            this.lblColorSala.Size = new System.Drawing.Size(145, 13);
            this.lblColorSala.TabIndex = 2;
            this.lblColorSala.Text = "Seleccione el color de la sala";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(263, 39);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(122, 21);
            this.cmbTurno.TabIndex = 3;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(71, 510);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(128, 50);
            this.btnCargarDatos.TabIndex = 4;
            this.btnCargarDatos.Text = "Cargar datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(260, 9);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(98, 13);
            this.lblTurno.TabIndex = 5;
            this.lblTurno.Text = "Seleccione el turno";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(243, 510);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 50);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmDatosResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(443, 620);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lblColorSala);
            this.Controls.Add(this.cmbColorSala);
            this.Controls.Add(this.listView1);
            this.Name = "FrmDatosResponsable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatosResponsable";
            this.Load += new System.EventHandler(this.FrmDatosResponsable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnaNombre;
        private System.Windows.Forms.ColumnHeader columnaApellido;
        private System.Windows.Forms.ColumnHeader columnaTelefono;
        private System.Windows.Forms.ComboBox cmbColorSala;
        private System.Windows.Forms.Label lblColorSala;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Button btnSalir;
    }
}