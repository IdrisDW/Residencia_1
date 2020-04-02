namespace ProyectoResInv_1.Agenda
{
    partial class FrmDoctores
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
            this.lblAgregarTitulo = new System.Windows.Forms.Label();
            this.lblInfoSubtitulo = new System.Windows.Forms.Label();
            this.btnSiguienteD = new System.Windows.Forms.Button();
            this.comboxDoctores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAgregarTitulo
            // 
            this.lblAgregarTitulo.AutoSize = true;
            this.lblAgregarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAgregarTitulo.Location = new System.Drawing.Point(85, 18);
            this.lblAgregarTitulo.Name = "lblAgregarTitulo";
            this.lblAgregarTitulo.Size = new System.Drawing.Size(153, 24);
            this.lblAgregarTitulo.TabIndex = 49;
            this.lblAgregarTitulo.Text = "Escoger doctor";
            // 
            // lblInfoSubtitulo
            // 
            this.lblInfoSubtitulo.AutoSize = true;
            this.lblInfoSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoSubtitulo.Location = new System.Drawing.Point(45, 52);
            this.lblInfoSubtitulo.Name = "lblInfoSubtitulo";
            this.lblInfoSubtitulo.Size = new System.Drawing.Size(184, 20);
            this.lblInfoSubtitulo.TabIndex = 50;
            this.lblInfoSubtitulo.Text = "Opciones de doctores";
            // 
            // btnSiguienteD
            // 
            this.btnSiguienteD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiguienteD.Location = new System.Drawing.Point(464, 286);
            this.btnSiguienteD.Name = "btnSiguienteD";
            this.btnSiguienteD.Size = new System.Drawing.Size(84, 41);
            this.btnSiguienteD.TabIndex = 52;
            this.btnSiguienteD.Text = "Siguiente";
            this.btnSiguienteD.UseVisualStyleBackColor = true;
            this.btnSiguienteD.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // comboxDoctores
            // 
            this.comboxDoctores.FormattingEnabled = true;
            this.comboxDoctores.Location = new System.Drawing.Point(49, 97);
            this.comboxDoctores.Name = "comboxDoctores";
            this.comboxDoctores.Size = new System.Drawing.Size(159, 21);
            this.comboxDoctores.TabIndex = 53;
            this.comboxDoctores.SelectedIndexChanged += new System.EventHandler(this.ComboxDoctores_SelectedIndexChanged);
            // 
            // FrmDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 350);
            this.Controls.Add(this.comboxDoctores);
            this.Controls.Add(this.btnSiguienteD);
            this.Controls.Add(this.lblInfoSubtitulo);
            this.Controls.Add(this.lblAgregarTitulo);
            this.Name = "FrmDoctores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctores";
            this.Load += new System.EventHandler(this.FrmDoctores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarTitulo;
        private System.Windows.Forms.Label lblInfoSubtitulo;
        private System.Windows.Forms.Button btnSiguienteD;
        private System.Windows.Forms.ComboBox comboxDoctores;
    }
}