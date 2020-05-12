namespace Luque.Fernando
{
    partial class FrmAula
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlumnosAula = new System.Windows.Forms.Label();
            this.lbAlumnosAula = new System.Windows.Forms.ListBox();
            this.lblAlumnosSinAuls = new System.Windows.Forms.Label();
            this.lbAlumnosSinAula = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbProfesores = new System.Windows.Forms.ListBox();
            this.btnCargaLista = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "tarde",
            "mañana"});
            this.cmbTurno.Location = new System.Drawing.Point(21, 86);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(155, 21);
            this.cmbTurno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profesores disponibles";
            // 
            // lblAlumnosAula
            // 
            this.lblAlumnosAula.AutoSize = true;
            this.lblAlumnosAula.Location = new System.Drawing.Point(429, 19);
            this.lblAlumnosAula.Name = "lblAlumnosAula";
            this.lblAlumnosAula.Size = new System.Drawing.Size(90, 13);
            this.lblAlumnosAula.TabIndex = 4;
            this.lblAlumnosAula.Text = "Alumnos del aula ";
            // 
            // lbAlumnosAula
            // 
            this.lbAlumnosAula.FormattingEnabled = true;
            this.lbAlumnosAula.Location = new System.Drawing.Point(432, 54);
            this.lbAlumnosAula.Name = "lbAlumnosAula";
            this.lbAlumnosAula.Size = new System.Drawing.Size(482, 121);
            this.lbAlumnosAula.TabIndex = 5;
            // 
            // lblAlumnosSinAuls
            // 
            this.lblAlumnosSinAuls.AutoSize = true;
            this.lblAlumnosSinAuls.Location = new System.Drawing.Point(429, 252);
            this.lblAlumnosSinAuls.Name = "lblAlumnosSinAuls";
            this.lblAlumnosSinAuls.Size = new System.Drawing.Size(86, 13);
            this.lblAlumnosSinAuls.TabIndex = 6;
            this.lblAlumnosSinAuls.Text = "Alumnos sin aula";
            // 
            // lbAlumnosSinAula
            // 
            this.lbAlumnosSinAula.FormattingEnabled = true;
            this.lbAlumnosSinAula.Location = new System.Drawing.Point(432, 302);
            this.lbAlumnosSinAula.Name = "lbAlumnosSinAula";
            this.lbAlumnosSinAula.Size = new System.Drawing.Size(482, 121);
            this.lbAlumnosSinAula.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(432, 478);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 37);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(618, 478);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 37);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbProfesores
            // 
            this.lbProfesores.FormattingEnabled = true;
            this.lbProfesores.Location = new System.Drawing.Point(21, 252);
            this.lbProfesores.Name = "lbProfesores";
            this.lbProfesores.Size = new System.Drawing.Size(208, 212);
            this.lbProfesores.TabIndex = 10;
            // 
            // btnCargaLista
            // 
            this.btnCargaLista.Location = new System.Drawing.Point(21, 147);
            this.btnCargaLista.Name = "btnCargaLista";
            this.btnCargaLista.Size = new System.Drawing.Size(139, 28);
            this.btnCargaLista.TabIndex = 11;
            this.btnCargaLista.Text = "Cargar listas";
            this.btnCargaLista.UseVisualStyleBackColor = true;
            this.btnCargaLista.Click += new System.EventHandler(this.btnCargaLista_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(676, 206);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(166, 46);
            this.btnAsignar.TabIndex = 12;
            this.btnAsignar.Text = "Asignar alumno al aula";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // FrmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(927, 544);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnCargaLista);
            this.Controls.Add(this.lbProfesores);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbAlumnosSinAula);
            this.Controls.Add(this.lblAlumnosSinAuls);
            this.Controls.Add(this.lbAlumnosAula);
            this.Controls.Add(this.lblAlumnosAula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de aula";
            this.Load += new System.EventHandler(this.FrmAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlumnosAula;
        private System.Windows.Forms.ListBox lbAlumnosAula;
        private System.Windows.Forms.Label lblAlumnosSinAuls;
        private System.Windows.Forms.ListBox lbAlumnosSinAula;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox lbProfesores;
        private System.Windows.Forms.Button btnCargaLista;
        private System.Windows.Forms.Button btnAsignar;
    }
}