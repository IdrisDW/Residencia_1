namespace ProyectoResInv_1
{
    partial class FrmCompuesto
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
            this.components = new System.ComponentModel.Container();
            this.btnLimpiarProd = new System.Windows.Forms.Button();
            this.btnLimpiarProv = new System.Windows.Forms.Button();
            this.txtBuscarMed = new System.Windows.Forms.TextBox();
            this.txtBuscarComp = new System.Windows.Forms.TextBox();
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxCargarTodo = new System.Windows.Forms.CheckBox();
            this.Unidades = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblInfoSubtitulo = new System.Windows.Forms.Label();
            this.lblAgregarTitulo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSet11 = new ProyectoResInv_1.DataSet1();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicineTableAdapter = new ProyectoResInv_1.DataSet1TableAdapters.MedicineTableAdapter();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedSelected = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caducidad_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPres_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosQuant_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidadesdosis_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarProd
            // 
            this.btnLimpiarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarProd.Location = new System.Drawing.Point(411, 386);
            this.btnLimpiarProd.Name = "btnLimpiarProd";
            this.btnLimpiarProd.Size = new System.Drawing.Size(84, 41);
            this.btnLimpiarProd.TabIndex = 43;
            this.btnLimpiarProd.Text = "Limpiar";
            this.btnLimpiarProd.UseVisualStyleBackColor = true;
            this.btnLimpiarProd.Click += new System.EventHandler(this.btnLimpiarProd_Click);
            // 
            // btnLimpiarProv
            // 
            this.btnLimpiarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarProv.Location = new System.Drawing.Point(293, 140);
            this.btnLimpiarProv.Name = "btnLimpiarProv";
            this.btnLimpiarProv.Size = new System.Drawing.Size(60, 24);
            this.btnLimpiarProv.TabIndex = 41;
            this.btnLimpiarProv.Text = "Limpiar";
            this.btnLimpiarProv.UseVisualStyleBackColor = true;
            this.btnLimpiarProv.Click += new System.EventHandler(this.btnLimpiarProv_Click);
            // 
            // txtBuscarMed
            // 
            this.txtBuscarMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMed.Location = new System.Drawing.Point(149, 170);
            this.txtBuscarMed.Name = "txtBuscarMed";
            this.txtBuscarMed.Size = new System.Drawing.Size(204, 22);
            this.txtBuscarMed.TabIndex = 39;
            this.txtBuscarMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedicamento_KeyPress);
            // 
            // txtBuscarComp
            // 
            this.txtBuscarComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarComp.Location = new System.Drawing.Point(177, 395);
            this.txtBuscarComp.Name = "txtBuscarComp";
            this.txtBuscarComp.Size = new System.Drawing.Size(204, 22);
            this.txtBuscarComp.TabIndex = 38;
            // 
            // dgvMedicamento
            // 
            this.dgvMedicamento.AllowUserToAddRows = false;
            this.dgvMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agregar,
            this.Id_c,
            this.Nombre_c,
            this.Caducidad_c,
            this.Cantidad_c,
            this.CantidadPres_c,
            this.Unidades_c,
            this.tipo_c,
            this.DosQuant_c,
            this.Unidadesdosis_c,
            this.Proveedor_c});
            this.dgvMedicamento.Location = new System.Drawing.Point(31, 201);
            this.dgvMedicamento.Name = "dgvMedicamento";
            this.dgvMedicamento.Size = new System.Drawing.Size(331, 128);
            this.dgvMedicamento.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 433);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 36;
            // 
            // cbxCargarTodo
            // 
            this.cbxCargarTodo.AutoSize = true;
            this.cbxCargarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCargarTodo.Location = new System.Drawing.Point(517, 398);
            this.cbxCargarTodo.Name = "cbxCargarTodo";
            this.cbxCargarTodo.Size = new System.Drawing.Size(184, 20);
            this.cbxCargarTodo.TabIndex = 34;
            this.cbxCargarTodo.Text = "Ver todos los registros";
            this.cbxCargarTodo.UseVisualStyleBackColor = true;
            this.cbxCargarTodo.CheckedChanged += new System.EventHandler(this.cbxCargarTodo_CheckedChanged);
            // 
            // Unidades
            // 
            this.Unidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unidades.Location = new System.Drawing.Point(622, 75);
            this.Unidades.Name = "Unidades";
            this.Unidades.Size = new System.Drawing.Size(166, 22);
            this.Unidades.TabIndex = 33;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(214, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 22);
            this.txtNombre.TabIndex = 31;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Location = new System.Drawing.Point(704, 335);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 41);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(570, 335);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 41);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamento.Location = new System.Drawing.Point(40, 170);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(90, 16);
            this.lblMedicamento.TabIndex = 28;
            this.lblMedicamento.Text = "Medicamento";
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidades.Location = new System.Drawing.Point(501, 78);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(67, 16);
            this.lblUnidades.TabIndex = 27;
            this.lblUnidades.Text = "Unidades";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(56, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(146, 16);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre de compuesto";
            // 
            // lblInfoSubtitulo
            // 
            this.lblInfoSubtitulo.AutoSize = true;
            this.lblInfoSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoSubtitulo.Location = new System.Drawing.Point(27, 43);
            this.lblInfoSubtitulo.Name = "lblInfoSubtitulo";
            this.lblInfoSubtitulo.Size = new System.Drawing.Size(231, 20);
            this.lblInfoSubtitulo.TabIndex = 23;
            this.lblInfoSubtitulo.Text = "Informacion de compuestos";
            // 
            // lblAgregarTitulo
            // 
            this.lblAgregarTitulo.AutoSize = true;
            this.lblAgregarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAgregarTitulo.Location = new System.Drawing.Point(67, 9);
            this.lblAgregarTitulo.Name = "lblAgregarTitulo";
            this.lblAgregarTitulo.Size = new System.Drawing.Size(194, 24);
            this.lblAgregarTitulo.TabIndex = 22;
            this.lblAgregarTitulo.Text = "Agregar compuesto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(394, 201);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 41);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Medicamentos seleccionados";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(149, 144);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(113, 20);
            this.checkBox2.TabIndex = 94;
            this.checkBox2.Text = "Filtrar por ID";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuitar.Location = new System.Drawing.Point(394, 288);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(84, 41);
            this.btnQuitar.TabIndex = 95;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "Compuesto";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataMember = "Medicine";
            this.medicineBindingSource.DataSource = this.dataSet11;
            // 
            // medicineTableAdapter
            // 
            this.medicineTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Proveedor";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Unidades Dosis";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Cantidad Dosis";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Tipo de unidades";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Unidades";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad Presentacion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Caducidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dgvMedSelected
            // 
            this.dgvMedSelected.AllowUserToAddRows = false;
            this.dgvMedSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvMedSelected.Location = new System.Drawing.Point(504, 201);
            this.dgvMedSelected.Name = "dgvMedSelected";
            this.dgvMedSelected.Size = new System.Drawing.Size(331, 128);
            this.dgvMedSelected.TabIndex = 97;
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "Agregar";
            this.Agregar.Name = "Agregar";
            // 
            // Id_c
            // 
            this.Id_c.HeaderText = "Id";
            this.Id_c.Name = "Id_c";
            // 
            // Nombre_c
            // 
            this.Nombre_c.HeaderText = "Nombre";
            this.Nombre_c.Name = "Nombre_c";
            // 
            // Caducidad_c
            // 
            this.Caducidad_c.HeaderText = "Caducidad";
            this.Caducidad_c.Name = "Caducidad_c";
            // 
            // Cantidad_c
            // 
            this.Cantidad_c.HeaderText = "Cantidad";
            this.Cantidad_c.Name = "Cantidad_c";
            // 
            // CantidadPres_c
            // 
            this.CantidadPres_c.HeaderText = "Presentacion";
            this.CantidadPres_c.Name = "CantidadPres_c";
            // 
            // Unidades_c
            // 
            this.Unidades_c.HeaderText = "Unidades";
            this.Unidades_c.Name = "Unidades_c";
            // 
            // tipo_c
            // 
            this.tipo_c.HeaderText = "Tipo Unidad";
            this.tipo_c.Name = "tipo_c";
            // 
            // DosQuant_c
            // 
            this.DosQuant_c.HeaderText = "Cantidad Dosis";
            this.DosQuant_c.Name = "DosQuant_c";
            // 
            // Unidadesdosis_c
            // 
            this.Unidadesdosis_c.HeaderText = "Unidades Dosis";
            this.Unidadesdosis_c.Name = "Unidadesdosis_c";
            // 
            // Proveedor_c
            // 
            this.Proveedor_c.HeaderText = "Proveedor";
            this.Proveedor_c.Name = "Proveedor_c";
            // 
            // FrmCompuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 595);
            this.Controls.Add(this.dgvMedSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiarProd);
            this.Controls.Add(this.btnLimpiarProv);
            this.Controls.Add(this.txtBuscarMed);
            this.Controls.Add(this.txtBuscarComp);
            this.Controls.Add(this.dgvMedicamento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxCargarTodo);
            this.Controls.Add(this.Unidades);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblMedicamento);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblInfoSubtitulo);
            this.Controls.Add(this.lblAgregarTitulo);
            this.Name = "FrmCompuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compuesto";
            this.Load += new System.EventHandler(this.FrmCompuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarProd;
        private System.Windows.Forms.Button btnLimpiarProv;
        private System.Windows.Forms.TextBox txtBuscarMed;
        private System.Windows.Forms.TextBox txtBuscarComp;
        private System.Windows.Forms.DataGridView dgvMedicamento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbxCargarTodo;
        private System.Windows.Forms.TextBox Unidades;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblInfoSubtitulo;
        private System.Windows.Forms.Label lblAgregarTitulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private DataSet1TableAdapters.MedicineTableAdapter medicineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvMedSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caducidad_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPres_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosQuant_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidadesdosis_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor_c;
    }
}