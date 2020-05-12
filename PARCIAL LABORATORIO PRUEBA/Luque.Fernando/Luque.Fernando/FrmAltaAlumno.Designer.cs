namespace Luque.Fernando
{
    partial class FrmAltaAlumno
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblCuota = new System.Windows.Forms.Label();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.lblColorSala = new System.Windows.Forms.Label();
            this.cmbColorSala = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 81);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(157, 148);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(157, 213);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(135, 516);
            this.btnConfirmar.Size = new System.Drawing.Size(137, 31);
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(303, 516);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Alumno";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(27, 342);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(82, 13);
            this.lblLegajo.TabIndex = 12;
            this.lblLegajo.Text = "Ingrese legajo : ";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(159, 339);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(208, 20);
            this.txtLegajo.TabIndex = 13;
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Location = new System.Drawing.Point(22, 400);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(136, 13);
            this.lblCuota.TabIndex = 14;
            this.lblCuota.Text = "Ingrese precio de la cuota :";
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(173, 397);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(194, 20);
            this.txtCuota.TabIndex = 15;
            // 
            // lblColorSala
            // 
            this.lblColorSala.AutoSize = true;
            this.lblColorSala.Location = new System.Drawing.Point(22, 452);
            this.lblColorSala.Name = "lblColorSala";
            this.lblColorSala.Size = new System.Drawing.Size(134, 13);
            this.lblColorSala.TabIndex = 16;
            this.lblColorSala.Text = "Seleccione el color de sala";
            // 
            // cmbColorSala
            // 
            this.cmbColorSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorSala.FormattingEnabled = true;
            this.cmbColorSala.Items.AddRange(new object[] {
            "Naranja",
            "Rojo",
            "Amarillo",
            "Verde"});
            this.cmbColorSala.Location = new System.Drawing.Point(173, 449);
            this.cmbColorSala.Name = "cmbColorSala";
            this.cmbColorSala.Size = new System.Drawing.Size(192, 21);
            this.cmbColorSala.TabIndex = 17;
            // 
            // FrmAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 620);
            this.Controls.Add(this.cmbColorSala);
            this.Controls.Add(this.lblColorSala);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.lblCuota);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAltaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de alumno";
            this.Controls.SetChildIndex(this.cmbSexo, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.lblDni, 0);
            this.Controls.SetChildIndex(this.lblSexo, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.btnConfirmar, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblLegajo, 0);
            this.Controls.SetChildIndex(this.txtLegajo, 0);
            this.Controls.SetChildIndex(this.lblCuota, 0);
            this.Controls.SetChildIndex(this.txtCuota, 0);
            this.Controls.SetChildIndex(this.lblColorSala, 0);
            this.Controls.SetChildIndex(this.cmbColorSala, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Label lblColorSala;
        private System.Windows.Forms.ComboBox cmbColorSala;
    }
}