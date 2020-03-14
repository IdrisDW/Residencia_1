namespace ProyectoResInv_1
{
    partial class FrmMedicamento
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
            this.btnLimpiarProv = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtBuscarMed = new System.Windows.Forms.TextBox();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnFechaExp = new System.Windows.Forms.MonthCalendar();
            this.udCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblFechaExp = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblInfoSubtitulo = new System.Windows.Forms.Label();
            this.lblAgregarTitulo = new System.Windows.Forms.Label();
            this.lblUnidadDosis = new System.Windows.Forms.Label();
            this.lblCantidadDosis = new System.Windows.Forms.Label();
            this.txtPres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.udUnidades = new System.Windows.Forms.NumericUpDown();
            this.udUnidadesDosis = new System.Windows.Forms.NumericUpDown();
            this.udCantidadDosis = new System.Windows.Forms.NumericUpDown();
            this.txtTipoUnidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnElegir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUnidadesDosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCantidadDosis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarProv
            // 
            this.btnLimpiarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarProv.Location = new System.Drawing.Point(675, 175);
            this.btnLimpiarProv.Name = "btnLimpiarProv";
            this.btnLimpiarProv.Size = new System.Drawing.Size(60, 24);
            this.btnLimpiarProv.TabIndex = 41;
            this.btnLimpiarProv.Text = "Limpiar";
            this.btnLimpiarProv.UseVisualStyleBackColor = true;
            this.btnLimpiarProv.Click += new System.EventHandler(this.btnLimpiarProv_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(500, 176);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(158, 22);
            this.txtProveedor.TabIndex = 39;
            this.txtProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProveedor_KeyPress);
            // 
            // txtBuscarMed
            // 
            this.txtBuscarMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMed.Location = new System.Drawing.Point(41, 396);
            this.txtBuscarMed.Name = "txtBuscarMed";
            this.txtBuscarMed.Size = new System.Drawing.Size(262, 22);
            this.txtBuscarMed.TabIndex = 38;
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(500, 217);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.Size = new System.Drawing.Size(331, 83);
            this.dgvProveedor.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 433);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 36;
            // 
            // clnFechaExp
            // 
            this.clnFechaExp.Location = new System.Drawing.Point(201, 195);
            this.clnFechaExp.MaxSelectionCount = 1;
            this.clnFechaExp.Name = "clnFechaExp";
            this.clnFechaExp.TabIndex = 35;
            // 
            // udCantidad
            // 
            this.udCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udCantidad.Location = new System.Drawing.Point(201, 104);
            this.udCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udCantidad.Name = "udCantidad";
            this.udCantidad.Size = new System.Drawing.Size(248, 22);
            this.udCantidad.TabIndex = 32;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(201, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 22);
            this.txtNombre.TabIndex = 31;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Location = new System.Drawing.Point(602, 316);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 41);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(465, 316);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 41);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(497, 148);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(72, 16);
            this.lblProveedor.TabIndex = 28;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidades.Location = new System.Drawing.Point(29, 166);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(67, 16);
            this.lblUnidades.TabIndex = 27;
            this.lblUnidades.Text = "Unidades";
            // 
            // lblFechaExp
            // 
            this.lblFechaExp.AutoSize = true;
            this.lblFechaExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaExp.Location = new System.Drawing.Point(38, 201);
            this.lblFechaExp.Name = "lblFechaExp";
            this.lblFechaExp.Size = new System.Drawing.Size(132, 16);
            this.lblFechaExp.TabIndex = 26;
            this.lblFechaExp.Text = "Fecha de caducidad";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(29, 106);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(166, 16);
            this.lblCantidad.TabIndex = 25;
            this.lblCantidad.Text = "Cantidad de medicamento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(29, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(161, 16);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre de medicamento";
            // 
            // lblInfoSubtitulo
            // 
            this.lblInfoSubtitulo.AutoSize = true;
            this.lblInfoSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoSubtitulo.Location = new System.Drawing.Point(5, 43);
            this.lblInfoSubtitulo.Name = "lblInfoSubtitulo";
            this.lblInfoSubtitulo.Size = new System.Drawing.Size(250, 20);
            this.lblInfoSubtitulo.TabIndex = 23;
            this.lblInfoSubtitulo.Text = "Informacion de medicamentos";
            // 
            // lblAgregarTitulo
            // 
            this.lblAgregarTitulo.AutoSize = true;
            this.lblAgregarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAgregarTitulo.Location = new System.Drawing.Point(45, 9);
            this.lblAgregarTitulo.Name = "lblAgregarTitulo";
            this.lblAgregarTitulo.Size = new System.Drawing.Size(217, 24);
            this.lblAgregarTitulo.TabIndex = 22;
            this.lblAgregarTitulo.Text = "Agregar medicamento";
            // 
            // lblUnidadDosis
            // 
            this.lblUnidadDosis.AutoSize = true;
            this.lblUnidadDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadDosis.Location = new System.Drawing.Point(497, 95);
            this.lblUnidadDosis.Name = "lblUnidadDosis";
            this.lblUnidadDosis.Size = new System.Drawing.Size(122, 16);
            this.lblUnidadDosis.TabIndex = 44;
            this.lblUnidadDosis.Text = "Unidades de dosis";
            // 
            // lblCantidadDosis
            // 
            this.lblCantidadDosis.AutoSize = true;
            this.lblCantidadDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDosis.Location = new System.Drawing.Point(497, 123);
            this.lblCantidadDosis.Name = "lblCantidadDosis";
            this.lblCantidadDosis.Size = new System.Drawing.Size(117, 16);
            this.lblCantidadDosis.TabIndex = 46;
            this.lblCantidadDosis.Text = "Cantidad de dosis";
            // 
            // txtPres
            // 
            this.txtPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPres.Location = new System.Drawing.Point(201, 136);
            this.txtPres.Name = "txtPres";
            this.txtPres.Size = new System.Drawing.Size(248, 22);
            this.txtPres.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 93;
            this.label2.Text = "Presentacion";
            // 
            // udUnidades
            // 
            this.udUnidades.DecimalPlaces = 2;
            this.udUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udUnidades.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.udUnidades.Location = new System.Drawing.Point(201, 166);
            this.udUnidades.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.udUnidades.Name = "udUnidades";
            this.udUnidades.Size = new System.Drawing.Size(248, 22);
            this.udUnidades.TabIndex = 95;
            // 
            // udUnidadesDosis
            // 
            this.udUnidadesDosis.DecimalPlaces = 2;
            this.udUnidadesDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udUnidadesDosis.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.udUnidadesDosis.Location = new System.Drawing.Point(649, 93);
            this.udUnidadesDosis.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.udUnidadesDosis.Name = "udUnidadesDosis";
            this.udUnidadesDosis.Size = new System.Drawing.Size(133, 22);
            this.udUnidadesDosis.TabIndex = 96;
            // 
            // udCantidadDosis
            // 
            this.udCantidadDosis.DecimalPlaces = 2;
            this.udCantidadDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udCantidadDosis.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.udCantidadDosis.Location = new System.Drawing.Point(649, 121);
            this.udCantidadDosis.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.udCantidadDosis.Name = "udCantidadDosis";
            this.udCantidadDosis.Size = new System.Drawing.Size(133, 22);
            this.udCantidadDosis.TabIndex = 97;
            // 
            // txtTipoUnidad
            // 
            this.txtTipoUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoUnidad.Location = new System.Drawing.Point(602, 59);
            this.txtTipoUnidad.Name = "txtTipoUnidad";
            this.txtTipoUnidad.Size = new System.Drawing.Size(216, 22);
            this.txtTipoUnidad.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 98;
            this.label1.Text = "Tipo de unidad";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(602, 377);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 41);
            this.btnEliminar.TabIndex = 104;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(465, 377);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 41);
            this.btnEditar.TabIndex = 103;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(332, 377);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 41);
            this.btnLimpiar.TabIndex = 102;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(332, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 41);
            this.button2.TabIndex = 101;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(49, 369);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(188, 20);
            this.checkBox1.TabIndex = 100;
            this.checkBox1.Text = "Ver todos los registros";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(575, 149);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 20);
            this.checkBox2.TabIndex = 105;
            this.checkBox2.Text = "Filtrar por ID";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnElegir
            // 
            this.btnElegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnElegir.Location = new System.Drawing.Point(771, 174);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(60, 24);
            this.btnElegir.TabIndex = 106;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // FrmMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 595);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtTipoUnidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.udCantidadDosis);
            this.Controls.Add(this.udUnidadesDosis);
            this.Controls.Add(this.udUnidades);
            this.Controls.Add(this.txtPres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCantidadDosis);
            this.Controls.Add(this.lblUnidadDosis);
            this.Controls.Add(this.btnLimpiarProv);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtBuscarMed);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clnFechaExp);
            this.Controls.Add(this.udCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.lblFechaExp);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblInfoSubtitulo);
            this.Controls.Add(this.lblAgregarTitulo);
            this.Name = "FrmMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicamento";
            this.Load += new System.EventHandler(this.FrmMedicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUnidadesDosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCantidadDosis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpiarProv;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtBuscarMed;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MonthCalendar clnFechaExp;
        private System.Windows.Forms.NumericUpDown udCantidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblFechaExp;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblInfoSubtitulo;
        private System.Windows.Forms.Label lblAgregarTitulo;
        private System.Windows.Forms.Label lblUnidadDosis;
        private System.Windows.Forms.Label lblCantidadDosis;
        private System.Windows.Forms.TextBox txtPres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udUnidades;
        private System.Windows.Forms.NumericUpDown udUnidadesDosis;
        private System.Windows.Forms.NumericUpDown udCantidadDosis;
        private System.Windows.Forms.TextBox txtTipoUnidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnElegir;
    }
}