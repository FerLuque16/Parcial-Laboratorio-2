namespace Luque.Fernando
{
    partial class FrmVideos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVideos));
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnShark = new System.Windows.Forms.Button();
            this.btnPeppa = new System.Windows.Forms.Button();
            this.btnBloopers = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpVideo
            // 
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(4, 3);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(769, 406);
            this.wmpVideo.TabIndex = 0;
            // 
            // btnShark
            // 
            this.btnShark.Location = new System.Drawing.Point(23, 465);
            this.btnShark.Name = "btnShark";
            this.btnShark.Size = new System.Drawing.Size(143, 50);
            this.btnShark.TabIndex = 1;
            this.btnShark.Text = "Video Baby Shark";
            this.btnShark.UseVisualStyleBackColor = true;
            this.btnShark.Click += new System.EventHandler(this.btnShark_Click);
            // 
            // btnPeppa
            // 
            this.btnPeppa.Location = new System.Drawing.Point(199, 465);
            this.btnPeppa.Name = "btnPeppa";
            this.btnPeppa.Size = new System.Drawing.Size(146, 50);
            this.btnPeppa.TabIndex = 2;
            this.btnPeppa.Text = "Video Peppa Pig";
            this.btnPeppa.UseVisualStyleBackColor = true;
            this.btnPeppa.Click += new System.EventHandler(this.btnPeppa_Click);
            // 
            // btnBloopers
            // 
            this.btnBloopers.Location = new System.Drawing.Point(378, 465);
            this.btnBloopers.Name = "btnBloopers";
            this.btnBloopers.Size = new System.Drawing.Size(143, 50);
            this.btnBloopers.TabIndex = 3;
            this.btnBloopers.Text = "Video Bloopers";
            this.btnBloopers.UseVisualStyleBackColor = true;
            this.btnBloopers.Click += new System.EventHandler(this.btnBloopers_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(559, 465);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(157, 50);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 562);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBloopers);
            this.Controls.Add(this.btnPeppa);
            this.Controls.Add(this.btnShark);
            this.Controls.Add(this.wmpVideo);
            this.Name = "FrmVideos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Videos";
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Button btnShark;
        private System.Windows.Forms.Button btnPeppa;
        private System.Windows.Forms.Button btnBloopers;
        private System.Windows.Forms.Button btnSalir;
    }
}