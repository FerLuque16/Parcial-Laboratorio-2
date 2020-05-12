namespace Luque.Fernando
{
    partial class FrmPersonal
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
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.cmbEntrada = new System.Windows.Forms.ComboBox();
            this.cmbSalida = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(187, 538);
            this.btnConfirmar.Size = new System.Drawing.Size(127, 31);
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(330, 538);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(23, 334);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(84, 13);
            this.lblEntrada.TabIndex = 11;
            this.lblEntrada.Text = "Hora de entrada";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(22, 385);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(75, 13);
            this.lblSalida.TabIndex = 13;
            this.lblSalida.Text = "Hora de salida";
            // 
            // cmbEntrada
            // 
            this.cmbEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntrada.FormattingEnabled = true;
            this.cmbEntrada.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "13:00"});
            this.cmbEntrada.Location = new System.Drawing.Point(158, 331);
            this.cmbEntrada.Name = "cmbEntrada";
            this.cmbEntrada.Size = new System.Drawing.Size(209, 21);
            this.cmbEntrada.TabIndex = 15;
            // 
            // cmbSalida
            // 
            this.cmbSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalida.FormattingEnabled = true;
            this.cmbSalida.Items.AddRange(new object[] {
            "12:00",
            "16:00",
            "17:00"});
            this.cmbSalida.Location = new System.Drawing.Point(158, 382);
            this.cmbSalida.Name = "cmbSalida";
            this.cmbSalida.Size = new System.Drawing.Size(209, 21);
            this.cmbSalida.TabIndex = 16;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(23, 438);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 17;
            this.lblCargo.Text = "Cargo";
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Porteria",
            "Cocina",
            "Secretaria",
            "Tesoria",
            "Direccion"});
            this.cmbCargo.Location = new System.Drawing.Point(158, 430);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(209, 21);
            this.cmbCargo.TabIndex = 18;
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Location = new System.Drawing.Point(22, 489);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(73, 13);
            this.lblValorHora.TabIndex = 19;
            this.lblValorHora.Text = "Valor por hora";
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(158, 488);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(209, 20);
            this.txtValorHora.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Personal";
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.cmbSalida);
            this.Controls.Add(this.cmbEntrada);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Name = "FrmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonal";
            this.Controls.SetChildIndex(this.cmbSexo, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.lblDni, 0);
            this.Controls.SetChildIndex(this.lblSexo, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.btnConfirmar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblEntrada, 0);
            this.Controls.SetChildIndex(this.lblSalida, 0);
            this.Controls.SetChildIndex(this.cmbEntrada, 0);
            this.Controls.SetChildIndex(this.cmbSalida, 0);
            this.Controls.SetChildIndex(this.lblCargo, 0);
            this.Controls.SetChildIndex(this.cmbCargo, 0);
            this.Controls.SetChildIndex(this.lblValorHora, 0);
            this.Controls.SetChildIndex(this.txtValorHora, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.ComboBox cmbEntrada;
        private System.Windows.Forms.ComboBox cmbSalida;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblValorHora;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCargo;
    }
}