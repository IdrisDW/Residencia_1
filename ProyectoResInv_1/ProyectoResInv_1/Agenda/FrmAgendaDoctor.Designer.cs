namespace ProyectoResInv_1.Agenda
{
    partial class FrmAgendaDoctor
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
            this.btnBuscarMaterial = new System.Windows.Forms.Button();
            this.lblAgregarTitulo = new System.Windows.Forms.Label();
            this.mCalendarAgendaDoc = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDieciseis = new System.Windows.Forms.Button();
            this.btnQuince = new System.Windows.Forms.Button();
            this.btnCatorce = new System.Windows.Forms.Button();
            this.btnTrece = new System.Windows.Forms.Button();
            this.btnDoce = new System.Windows.Forms.Button();
            this.btnOnce = new System.Windows.Forms.Button();
            this.btnDiez = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.dataGViewReservation = new System.Windows.Forms.DataGridView();
            this.btnActualiza = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarMaterial
            // 
            this.btnBuscarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMaterial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarMaterial.Location = new System.Drawing.Point(89, 243);
            this.btnBuscarMaterial.Name = "btnBuscarMaterial";
            this.btnBuscarMaterial.Size = new System.Drawing.Size(105, 44);
            this.btnBuscarMaterial.TabIndex = 43;
            this.btnBuscarMaterial.Text = "Nueva";
            this.btnBuscarMaterial.UseVisualStyleBackColor = true;
            this.btnBuscarMaterial.Click += new System.EventHandler(this.BtnBuscarMaterial_Click);
            // 
            // lblAgregarTitulo
            // 
            this.lblAgregarTitulo.AutoSize = true;
            this.lblAgregarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAgregarTitulo.Location = new System.Drawing.Point(85, 18);
            this.lblAgregarTitulo.Name = "lblAgregarTitulo";
            this.lblAgregarTitulo.Size = new System.Drawing.Size(154, 24);
            this.lblAgregarTitulo.TabIndex = 44;
            this.lblAgregarTitulo.Text = "Agenda doctor:";
            // 
            // mCalendarAgendaDoc
            // 
            this.mCalendarAgendaDoc.Location = new System.Drawing.Point(27, 51);
            this.mCalendarAgendaDoc.Name = "mCalendarAgendaDoc";
            this.mCalendarAgendaDoc.TabIndex = 45;
            this.mCalendarAgendaDoc.TodayDate = new System.DateTime(2020, 3, 17, 0, 0, 0, 0);
            this.mCalendarAgendaDoc.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MCalendarAgendaDoc_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDieciseis);
            this.groupBox1.Controls.Add(this.btnQuince);
            this.groupBox1.Controls.Add(this.btnCatorce);
            this.groupBox1.Controls.Add(this.btnTrece);
            this.groupBox1.Controls.Add(this.btnDoce);
            this.groupBox1.Controls.Add(this.btnOnce);
            this.groupBox1.Controls.Add(this.btnDiez);
            this.groupBox1.Controls.Add(this.btnNueve);
            this.groupBox1.Location = new System.Drawing.Point(863, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 470);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horas";
            // 
            // btnDieciseis
            // 
            this.btnDieciseis.Location = new System.Drawing.Point(24, 401);
            this.btnDieciseis.Name = "btnDieciseis";
            this.btnDieciseis.Size = new System.Drawing.Size(189, 47);
            this.btnDieciseis.TabIndex = 7;
            this.btnDieciseis.Text = "16:00 am                |                            ";
            this.btnDieciseis.UseVisualStyleBackColor = true;
            this.btnDieciseis.Click += new System.EventHandler(this.BtnDieciseis_Click);
            // 
            // btnQuince
            // 
            this.btnQuince.Location = new System.Drawing.Point(24, 348);
            this.btnQuince.Name = "btnQuince";
            this.btnQuince.Size = new System.Drawing.Size(189, 47);
            this.btnQuince.TabIndex = 6;
            this.btnQuince.Text = "15:00 am                |                            ";
            this.btnQuince.UseVisualStyleBackColor = true;
            this.btnQuince.Click += new System.EventHandler(this.BtnQuince_Click);
            // 
            // btnCatorce
            // 
            this.btnCatorce.Location = new System.Drawing.Point(24, 295);
            this.btnCatorce.Name = "btnCatorce";
            this.btnCatorce.Size = new System.Drawing.Size(189, 47);
            this.btnCatorce.TabIndex = 5;
            this.btnCatorce.Text = "14:00 am                |                            ";
            this.btnCatorce.UseVisualStyleBackColor = true;
            this.btnCatorce.Click += new System.EventHandler(this.BtnCatorce_Click);
            // 
            // btnTrece
            // 
            this.btnTrece.Location = new System.Drawing.Point(24, 242);
            this.btnTrece.Name = "btnTrece";
            this.btnTrece.Size = new System.Drawing.Size(189, 47);
            this.btnTrece.TabIndex = 4;
            this.btnTrece.Text = "13:00 am                |                            ";
            this.btnTrece.UseVisualStyleBackColor = true;
            this.btnTrece.Click += new System.EventHandler(this.BtnTrece_Click);
            // 
            // btnDoce
            // 
            this.btnDoce.Location = new System.Drawing.Point(24, 189);
            this.btnDoce.Name = "btnDoce";
            this.btnDoce.Size = new System.Drawing.Size(189, 47);
            this.btnDoce.TabIndex = 3;
            this.btnDoce.Text = "12:00 am                |                            ";
            this.btnDoce.UseVisualStyleBackColor = true;
            this.btnDoce.Click += new System.EventHandler(this.BtnDoce_Click);
            // 
            // btnOnce
            // 
            this.btnOnce.Location = new System.Drawing.Point(24, 136);
            this.btnOnce.Name = "btnOnce";
            this.btnOnce.Size = new System.Drawing.Size(189, 47);
            this.btnOnce.TabIndex = 2;
            this.btnOnce.Text = "11:00 am                |                            ";
            this.btnOnce.UseVisualStyleBackColor = true;
            this.btnOnce.Click += new System.EventHandler(this.BtnOnce_Click);
            // 
            // btnDiez
            // 
            this.btnDiez.Location = new System.Drawing.Point(24, 83);
            this.btnDiez.Name = "btnDiez";
            this.btnDiez.Size = new System.Drawing.Size(189, 47);
            this.btnDiez.TabIndex = 1;
            this.btnDiez.Text = "10:00 am                |                            ";
            this.btnDiez.UseVisualStyleBackColor = true;
            this.btnDiez.Click += new System.EventHandler(this.BtnDiez_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Location = new System.Drawing.Point(24, 30);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(189, 47);
            this.btnNueve.TabIndex = 0;
            this.btnNueve.Text = "9:00 am                 |                            ";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.BtnNueve_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(245, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 24);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "name";
            // 
            // dataGViewReservation
            // 
            this.dataGViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGViewReservation.Location = new System.Drawing.Point(287, 62);
            this.dataGViewReservation.Name = "dataGViewReservation";
            this.dataGViewReservation.Size = new System.Drawing.Size(560, 225);
            this.dataGViewReservation.TabIndex = 48;
            // 
            // btnActualiza
            // 
            this.btnActualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualiza.Location = new System.Drawing.Point(89, 309);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(105, 44);
            this.btnActualiza.TabIndex = 49;
            this.btnActualiza.Text = "Actualizar";
            this.btnActualiza.UseVisualStyleBackColor = true;
            this.btnActualiza.Click += new System.EventHandler(this.BtnActualiza_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnElimina.Location = new System.Drawing.Point(395, 329);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(105, 44);
            this.btnElimina.TabIndex = 50;
            this.btnElimina.Text = "Eliminar";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.BtnElimina_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(601, 329);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 44);
            this.btnEditar.TabIndex = 51;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // FrmAgendaDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 531);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnActualiza);
            this.Controls.Add(this.dataGViewReservation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mCalendarAgendaDoc);
            this.Controls.Add(this.lblAgregarTitulo);
            this.Controls.Add(this.btnBuscarMaterial);
            this.Name = "FrmAgendaDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FrmAgendaDoctor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarMaterial;
        private System.Windows.Forms.Label lblAgregarTitulo;
        private System.Windows.Forms.MonthCalendar mCalendarAgendaDoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDieciseis;
        private System.Windows.Forms.Button btnQuince;
        private System.Windows.Forms.Button btnCatorce;
        private System.Windows.Forms.Button btnTrece;
        private System.Windows.Forms.Button btnDoce;
        private System.Windows.Forms.Button btnOnce;
        private System.Windows.Forms.Button btnDiez;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataGViewReservation;
        private System.Windows.Forms.Button btnActualiza;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnEditar;
    }
}