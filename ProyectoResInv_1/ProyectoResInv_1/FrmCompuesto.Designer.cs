﻿namespace ProyectoResInv_1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLimpiarProd = new System.Windows.Forms.Button();
            this.btnLimpiarProv = new System.Windows.Forms.Button();
            this.txtBuscarMed = new System.Windows.Forms.TextBox();
            this.txtBuscarComp = new System.Windows.Forms.TextBox();
            this.dgvCompuesto = new System.Windows.Forms.DataGridView();
            this.cbxCargarTodo = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblInfoSubtitulo = new System.Windows.Forms.Label();
            this.lblAgregarTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.medicineDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idMedicineDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineExpDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineQuantityDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineQuantityPresDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineUnitsDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineUnitsTypeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineDosQuanDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineDosUnitsDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSupplierDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.analisisResidenciaDataSet = new ProyectoResInv_1.AnalisisResidenciaDataSet();
            this.medicineTableAdapter1 = new ProyectoResInv_1.AnalisisResidenciaDataSetTableAdapters.MedicineTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Selecciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineQuantityPres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineUnitsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineDosQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineDosUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompoundQuantityUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.BS_Test = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new ProyectoResInv_1.DataSet1();
            this.medicineBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicineTableAdapter = new ProyectoResInv_1.DataSet1TableAdapters.MedicineTableAdapter();
            this.compoundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compoundTableAdapter = new ProyectoResInv_1.DataSet1TableAdapters.CompoundTableAdapter();
            this.compoundTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisisResidenciaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compoundBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compoundTableAdapterBindingSource)).BeginInit();
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
            // 
            // btnLimpiarProv
            // 
            this.btnLimpiarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarProv.Location = new System.Drawing.Point(266, 108);
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
            this.txtBuscarMed.Location = new System.Drawing.Point(122, 138);
            this.txtBuscarMed.Name = "txtBuscarMed";
            this.txtBuscarMed.Size = new System.Drawing.Size(204, 22);
            this.txtBuscarMed.TabIndex = 39;
            this.txtBuscarMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarMed_KeyPress);
            // 
            // txtBuscarComp
            // 
            this.txtBuscarComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarComp.Location = new System.Drawing.Point(177, 395);
            this.txtBuscarComp.Name = "txtBuscarComp";
            this.txtBuscarComp.Size = new System.Drawing.Size(204, 22);
            this.txtBuscarComp.TabIndex = 38;
            this.txtBuscarComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarComp_KeyPress);
            // 
            // dgvCompuesto
            // 
            this.dgvCompuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompuesto.Location = new System.Drawing.Point(59, 433);
            this.dgvCompuesto.Name = "dgvCompuesto";
            this.dgvCompuesto.Size = new System.Drawing.Size(745, 150);
            this.dgvCompuesto.TabIndex = 36;
            // 
            // cbxCargarTodo
            // 
            this.cbxCargarTodo.AutoSize = true;
            this.cbxCargarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCargarTodo.Location = new System.Drawing.Point(74, 369);
            this.cbxCargarTodo.Name = "cbxCargarTodo";
            this.cbxCargarTodo.Size = new System.Drawing.Size(184, 20);
            this.cbxCargarTodo.TabIndex = 34;
            this.cbxCargarTodo.Text = "Ver todos los registros";
            this.cbxCargarTodo.UseVisualStyleBackColor = true;
            this.cbxCargarTodo.CheckedChanged += new System.EventHandler(this.cbxCargarTodo_CheckedChanged);
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
            this.btnActualizar.Location = new System.Drawing.Point(677, 317);
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
            this.btnGuardar.Location = new System.Drawing.Point(540, 317);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 41);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamento.Location = new System.Drawing.Point(13, 138);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(90, 16);
            this.lblMedicamento.TabIndex = 28;
            this.lblMedicamento.Text = "Medicamento";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Medicamentos seleccionados";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(122, 112);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(113, 20);
            this.checkBox2.TabIndex = 94;
            this.checkBox2.Text = "Filtrar por ID";
            this.checkBox2.UseVisualStyleBackColor = true;
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
            // medicineDataTableBindingSource
            // 
            this.medicineDataTableBindingSource.DataSource = typeof(ProyectoResInv_1.DataSet1.MedicineDataTable);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.idMedicineDataGridViewTextBoxColumn2,
            this.medicineNameDataGridViewTextBoxColumn2,
            this.medicineExpDateDataGridViewTextBoxColumn2,
            this.medicineQuantityDataGridViewTextBoxColumn2,
            this.medicineQuantityPresDataGridViewTextBoxColumn2,
            this.medicineUnitsDataGridViewTextBoxColumn2,
            this.medicineUnitsTypeDataGridViewTextBoxColumn2,
            this.medicineDosQuanDataGridViewTextBoxColumn2,
            this.medicineDosUnitsDataGridViewTextBoxColumn2,
            this.idSupplierDataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.medicineBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(12, 166);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(350, 139);
            this.dataGridView2.TabIndex = 103;
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Seleccionar";
            this.Seleccion.Name = "Seleccion";
            // 
            // idMedicineDataGridViewTextBoxColumn2
            // 
            this.idMedicineDataGridViewTextBoxColumn2.DataPropertyName = "id_Medicine";
            this.idMedicineDataGridViewTextBoxColumn2.HeaderText = "id_Medicine";
            this.idMedicineDataGridViewTextBoxColumn2.Name = "idMedicineDataGridViewTextBoxColumn2";
            this.idMedicineDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // medicineNameDataGridViewTextBoxColumn2
            // 
            this.medicineNameDataGridViewTextBoxColumn2.DataPropertyName = "MedicineName";
            this.medicineNameDataGridViewTextBoxColumn2.HeaderText = "MedicineName";
            this.medicineNameDataGridViewTextBoxColumn2.Name = "medicineNameDataGridViewTextBoxColumn2";
            // 
            // medicineExpDateDataGridViewTextBoxColumn2
            // 
            this.medicineExpDateDataGridViewTextBoxColumn2.DataPropertyName = "MedicineExpDate";
            this.medicineExpDateDataGridViewTextBoxColumn2.HeaderText = "MedicineExpDate";
            this.medicineExpDateDataGridViewTextBoxColumn2.Name = "medicineExpDateDataGridViewTextBoxColumn2";
            // 
            // medicineQuantityDataGridViewTextBoxColumn2
            // 
            this.medicineQuantityDataGridViewTextBoxColumn2.DataPropertyName = "MedicineQuantity";
            this.medicineQuantityDataGridViewTextBoxColumn2.HeaderText = "MedicineQuantity";
            this.medicineQuantityDataGridViewTextBoxColumn2.Name = "medicineQuantityDataGridViewTextBoxColumn2";
            // 
            // medicineQuantityPresDataGridViewTextBoxColumn2
            // 
            this.medicineQuantityPresDataGridViewTextBoxColumn2.DataPropertyName = "MedicineQuantityPres";
            this.medicineQuantityPresDataGridViewTextBoxColumn2.HeaderText = "MedicineQuantityPres";
            this.medicineQuantityPresDataGridViewTextBoxColumn2.Name = "medicineQuantityPresDataGridViewTextBoxColumn2";
            // 
            // medicineUnitsDataGridViewTextBoxColumn2
            // 
            this.medicineUnitsDataGridViewTextBoxColumn2.DataPropertyName = "MedicineUnits";
            this.medicineUnitsDataGridViewTextBoxColumn2.HeaderText = "MedicineUnits";
            this.medicineUnitsDataGridViewTextBoxColumn2.Name = "medicineUnitsDataGridViewTextBoxColumn2";
            // 
            // medicineUnitsTypeDataGridViewTextBoxColumn2
            // 
            this.medicineUnitsTypeDataGridViewTextBoxColumn2.DataPropertyName = "MedicineUnitsType";
            this.medicineUnitsTypeDataGridViewTextBoxColumn2.HeaderText = "MedicineUnitsType";
            this.medicineUnitsTypeDataGridViewTextBoxColumn2.Name = "medicineUnitsTypeDataGridViewTextBoxColumn2";
            // 
            // medicineDosQuanDataGridViewTextBoxColumn2
            // 
            this.medicineDosQuanDataGridViewTextBoxColumn2.DataPropertyName = "MedicineDosQuan";
            this.medicineDosQuanDataGridViewTextBoxColumn2.HeaderText = "MedicineDosQuan";
            this.medicineDosQuanDataGridViewTextBoxColumn2.Name = "medicineDosQuanDataGridViewTextBoxColumn2";
            // 
            // medicineDosUnitsDataGridViewTextBoxColumn2
            // 
            this.medicineDosUnitsDataGridViewTextBoxColumn2.DataPropertyName = "MedicineDosUnits";
            this.medicineDosUnitsDataGridViewTextBoxColumn2.HeaderText = "MedicineDosUnits";
            this.medicineDosUnitsDataGridViewTextBoxColumn2.Name = "medicineDosUnitsDataGridViewTextBoxColumn2";
            // 
            // idSupplierDataGridViewTextBoxColumn2
            // 
            this.idSupplierDataGridViewTextBoxColumn2.DataPropertyName = "idSupplier";
            this.idSupplierDataGridViewTextBoxColumn2.HeaderText = "idSupplier";
            this.idSupplierDataGridViewTextBoxColumn2.Name = "idSupplierDataGridViewTextBoxColumn2";
            // 
            // medicineBindingSource2
            // 
            this.medicineBindingSource2.DataMember = "Medicine";
            this.medicineBindingSource2.DataSource = this.analisisResidenciaDataSet;
            // 
            // analisisResidenciaDataSet
            // 
            this.analisisResidenciaDataSet.DataSetName = "AnalisisResidenciaDataSet";
            this.analisisResidenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicineTableAdapter1
            // 
            this.medicineTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecciona,
            this.id_Medicine,
            this.MedicineName,
            this.MedicineExpDate,
            this.MedicineQuantity,
            this.MedicineQuantityPres,
            this.MedicineUnits,
            this.MedicineUnitsType,
            this.MedicineDosQuan,
            this.MedicineDosUnits,
            this.idSupplier,
            this.CompoundQuantityUnits});
            this.dataGridView3.Location = new System.Drawing.Point(490, 157);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(350, 139);
            this.dataGridView3.TabIndex = 104;
            this.dataGridView3.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellValidated);
            this.dataGridView3.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView3_CellValidating);
            this.dataGridView3.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView3_EditingControlShowing);
            // 
            // Selecciona
            // 
            this.Selecciona.HeaderText = "Seleccionar";
            this.Selecciona.Name = "Selecciona";
            // 
            // id_Medicine
            // 
            this.id_Medicine.HeaderText = "Id";
            this.id_Medicine.Name = "id_Medicine";
            // 
            // MedicineName
            // 
            this.MedicineName.HeaderText = "Nombre";
            this.MedicineName.Name = "MedicineName";
            // 
            // MedicineExpDate
            // 
            this.MedicineExpDate.HeaderText = "Caducidad";
            this.MedicineExpDate.Name = "MedicineExpDate";
            // 
            // MedicineQuantity
            // 
            this.MedicineQuantity.HeaderText = "Cantidad";
            this.MedicineQuantity.Name = "MedicineQuantity";
            // 
            // MedicineQuantityPres
            // 
            this.MedicineQuantityPres.HeaderText = "Presentacion ";
            this.MedicineQuantityPres.Name = "MedicineQuantityPres";
            // 
            // MedicineUnits
            // 
            this.MedicineUnits.HeaderText = "Unidades";
            this.MedicineUnits.Name = "MedicineUnits";
            // 
            // MedicineUnitsType
            // 
            this.MedicineUnitsType.HeaderText = "Tipo de unidad";
            this.MedicineUnitsType.Name = "MedicineUnitsType";
            // 
            // MedicineDosQuan
            // 
            this.MedicineDosQuan.HeaderText = "Cantidad Dosis";
            this.MedicineDosQuan.Name = "MedicineDosQuan";
            // 
            // MedicineDosUnits
            // 
            this.MedicineDosUnits.HeaderText = "Unidades Dosis";
            this.MedicineDosUnits.Name = "MedicineDosUnits";
            // 
            // idSupplier
            // 
            this.idSupplier.HeaderText = "Proveedor";
            this.idSupplier.Name = "idSupplier";
            // 
            // CompoundQuantityUnits
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.CompoundQuantityUnits.DefaultCellStyle = dataGridViewCellStyle2;
            this.CompoundQuantityUnits.HeaderText = "Unidades Necesarias";
            this.CompoundQuantityUnits.Name = "CompoundQuantityUnits";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(384, 176);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 32);
            this.btnAgregar.TabIndex = 105;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuitar.Location = new System.Drawing.Point(384, 252);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(81, 30);
            this.btnQuitar.TabIndex = 106;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(677, 382);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 41);
            this.btnEliminar.TabIndex = 108;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(540, 382);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 41);
            this.btnEditar.TabIndex = 107;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataMember = "Medicine";
            this.medicineBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicineBindingSource1
            // 
            this.medicineBindingSource1.DataMember = "Medicine";
            this.medicineBindingSource1.DataSource = this.dataSet11;
            // 
            // medicineTableAdapter
            // 
            this.medicineTableAdapter.ClearBeforeFill = true;
            // 
            // compoundBindingSource
            // 
            this.compoundBindingSource.DataMember = "Compound";
            this.compoundBindingSource.DataSource = this.dataSet11;
            // 
            // compoundTableAdapter
            // 
            this.compoundTableAdapter.ClearBeforeFill = true;
            // 
            // compoundTableAdapterBindingSource
            // 
            this.compoundTableAdapterBindingSource.DataSource = typeof(ProyectoResInv_1.DataSet1TableAdapters.CompoundTableAdapter);
            // 
            // FrmCompuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 595);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiarProd);
            this.Controls.Add(this.btnLimpiarProv);
            this.Controls.Add(this.txtBuscarMed);
            this.Controls.Add(this.txtBuscarComp);
            this.Controls.Add(this.dgvCompuesto);
            this.Controls.Add(this.cbxCargarTodo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblMedicamento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblInfoSubtitulo);
            this.Controls.Add(this.lblAgregarTitulo);
            this.Name = "FrmCompuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compuesto";
            this.Load += new System.EventHandler(this.FrmCompuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisisResidenciaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compoundBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compoundTableAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarProd;
        private System.Windows.Forms.Button btnLimpiarProv;
        private System.Windows.Forms.TextBox txtBuscarMed;
        private System.Windows.Forms.TextBox txtBuscarComp;
        private System.Windows.Forms.DataGridView dgvCompuesto;
        private System.Windows.Forms.CheckBox cbxCargarTodo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblInfoSubtitulo;
        private System.Windows.Forms.Label lblAgregarTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private DataSet1TableAdapters.MedicineTableAdapter medicineTableAdapter;
        private System.Windows.Forms.BindingSource medicineDataTableBindingSource;
        private System.Windows.Forms.BindingSource medicineBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private AnalisisResidenciaDataSet analisisResidenciaDataSet;
        private System.Windows.Forms.BindingSource medicineBindingSource2;
        private AnalisisResidenciaDataSetTableAdapters.MedicineTableAdapter medicineTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineQuantityPres;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineUnitsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineDosQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineDosUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompoundQuantityUnits;
        private System.Windows.Forms.BindingSource BS_Test;
        private System.Windows.Forms.BindingSource compoundBindingSource;
        private DataSet1TableAdapters.CompoundTableAdapter compoundTableAdapter;
        private System.Windows.Forms.BindingSource compoundTableAdapterBindingSource;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicineDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineExpDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineQuantityDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineQuantityPresDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineUnitsDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineUnitsTypeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineDosQuanDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineDosUnitsDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSupplierDataGridViewTextBoxColumn2;
    }
}