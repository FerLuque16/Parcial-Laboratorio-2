namespace Luque.Fernando
{
    partial class FrmRecaudacion
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
            this.columnaColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTurno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaRecaudacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRecaudacionTexto = new System.Windows.Forms.Label();
            this.lblRecaudacionTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaColor,
            this.columnaTurno,
            this.columnaRecaudacion});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(315, 207);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnaColor
            // 
            this.columnaColor.Text = "Color";
            this.columnaColor.Width = 98;
            // 
            // columnaTurno
            // 
            this.columnaTurno.Text = "Turno";
            this.columnaTurno.Width = 95;
            // 
            // columnaRecaudacion
            // 
            this.columnaRecaudacion.Text = "Recaudacion";
            this.columnaRecaudacion.Width = 102;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(151, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(187, 57);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblRecaudacionTexto
            // 
            this.lblRecaudacionTexto.AutoSize = true;
            this.lblRecaudacionTexto.Location = new System.Drawing.Point(45, 290);
            this.lblRecaudacionTexto.Name = "lblRecaudacionTexto";
            this.lblRecaudacionTexto.Size = new System.Drawing.Size(145, 13);
            this.lblRecaudacionTexto.TabIndex = 2;
            this.lblRecaudacionTexto.Text = "Recaudacion total del jardin :";
            // 
            // lblRecaudacionTotal
            // 
            this.lblRecaudacionTotal.AutoSize = true;
            this.lblRecaudacionTotal.Location = new System.Drawing.Point(369, 290);
            this.lblRecaudacionTotal.Name = "lblRecaudacionTotal";
            this.lblRecaudacionTotal.Size = new System.Drawing.Size(0, 13);
            this.lblRecaudacionTotal.TabIndex = 3;
            // 
            // FrmRecaudacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 485);
            this.Controls.Add(this.lblRecaudacionTotal);
            this.Controls.Add(this.lblRecaudacionTexto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRecaudacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recaudacion";
            this.Load += new System.EventHandler(this.FrmRecaudacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnaColor;
        private System.Windows.Forms.ColumnHeader columnaTurno;
        private System.Windows.Forms.ColumnHeader columnaRecaudacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRecaudacionTexto;
        private System.Windows.Forms.Label lblRecaudacionTotal;
    }
}