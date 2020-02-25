namespace ProyectoResInv_1
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaExp = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.udCantidad = new System.Windows.Forms.NumericUpDown();
            this.Unidades = new System.Windows.Forms.TextBox();
            this.cbxCargarTodo = new System.Windows.Forms.CheckBox();
            this.clnFechaExp = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarProv = new System.Windows.Forms.Button();
            this.btnLimpiarProv = new System.Windows.Forms.Button();
            this.btnBuscarProductos = new System.Windows.Forms.Button();
            this.btnLimpiarProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarTitulo
            // 
            this.lblAgregarTitulo.AutoSize = true;
            this.lblAgregarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAgregarTitulo.Location = new System.Drawing.Point(52, 9);
            this.lblAgregarTitulo.Name = "lblAgregarTitulo";
            this.lblAgregarTitulo.Size = new System.Drawing.Size(174, 24);
            this.lblAgregarTitulo.TabIndex = 0;
            this.lblAgregarTitulo.Text = "Agregar producto";
            // 
            // lblInfoSubtitulo
            // 
            this.lblInfoSubtitulo.AutoSize = true;
            this.lblInfoSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoSubtitulo.Location = new System.Drawing.Point(12, 43);
            this.lblInfoSubtitulo.Name = "lblInfoSubtitulo";
            this.lblInfoSubtitulo.Size = new System.Drawing.Size(214, 20);
            this.lblInfoSubtitulo.TabIndex = 1;
            this.lblInfoSubtitulo.Text = "Informacion de productos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(41, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(132, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre de producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(41, 104);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(137, 16);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad de producto";
            this.lblCantidad.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblFechaExp
            // 
            this.lblFechaExp.AutoSize = true;
            this.lblFechaExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaExp.Location = new System.Drawing.Point(41, 136);
            this.lblFechaExp.Name = "lblFechaExp";
            this.lblFechaExp.Size = new System.Drawing.Size(132, 16);
            this.lblFechaExp.TabIndex = 4;
            this.lblFechaExp.Text = "Fecha de caducidad";
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidades.Location = new System.Drawing.Point(504, 78);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(67, 16);
            this.lblUnidades.TabIndex = 5;
            this.lblUnidades.Text = "Unidades";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(504, 110);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(72, 16);
            this.lblProveedor.TabIndex = 6;
            this.lblProveedor.Text = "Proveedor";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(581, 281);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 41);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Location = new System.Drawing.Point(754, 281);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 41);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(199, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // udCantidad
            // 
            this.udCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udCantidad.Location = new System.Drawing.Point(199, 104);
            this.udCantidad.Name = "udCantidad";
            this.udCantidad.Size = new System.Drawing.Size(248, 22);
            this.udCantidad.TabIndex = 10;
            // 
            // Unidades
            // 
            this.Unidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unidades.Location = new System.Drawing.Point(610, 75);
            this.Unidades.Name = "Unidades";
            this.Unidades.Size = new System.Drawing.Size(166, 22);
            this.Unidades.TabIndex = 11;
            // 
            // cbxCargarTodo
            // 
            this.cbxCargarTodo.AutoSize = true;
            this.cbxCargarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCargarTodo.Location = new System.Drawing.Point(610, 388);
            this.cbxCargarTodo.Name = "cbxCargarTodo";
            this.cbxCargarTodo.Size = new System.Drawing.Size(192, 20);
            this.cbxCargarTodo.TabIndex = 12;
            this.cbxCargarTodo.Text = "Ver todos los productos";
            this.cbxCargarTodo.UseVisualStyleBackColor = true;
            // 
            // clnFechaExp
            // 
            this.clnFechaExp.Location = new System.Drawing.Point(199, 138);
            this.clnFechaExp.Name = "clnFechaExp";
            this.clnFechaExp.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 445);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(507, 177);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(331, 83);
            this.dataGridView2.TabIndex = 15;
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProd.Location = new System.Drawing.Point(44, 386);
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(262, 22);
            this.txtBuscarProd.TabIndex = 16;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(507, 138);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(158, 22);
            this.txtProveedor.TabIndex = 17;
            // 
            // btnBuscarProv
            // 
            this.btnBuscarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarProv.Location = new System.Drawing.Point(698, 138);
            this.btnBuscarProv.Name = "btnBuscarProv";
            this.btnBuscarProv.Size = new System.Drawing.Size(60, 24);
            this.btnBuscarProv.TabIndex = 18;
            this.btnBuscarProv.Text = "Buscar";
            this.btnBuscarProv.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarProv
            // 
            this.btnLimpiarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarProv.Location = new System.Drawing.Point(778, 138);
            this.btnLimpiarProv.Name = "btnLimpiarProv";
            this.btnLimpiarProv.Size = new System.Drawing.Size(60, 24);
            this.btnLimpiarProv.TabIndex = 19;
            this.btnLimpiarProv.Text = "Limpiar";
            this.btnLimpiarProv.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarProductos.Location = new System.Drawing.Point(354, 377);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Size = new System.Drawing.Size(84, 41);
            this.btnBuscarProductos.TabIndex = 20;
            this.btnBuscarProductos.Text = "Buscar";
            this.btnBuscarProductos.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarProd
            // 
            this.btnLimpiarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarProd.Location = new System.Drawing.Point(475, 377);
            this.btnLimpiarProd.Name = "btnLimpiarProd";
            this.btnLimpiarProd.Size = new System.Drawing.Size(84, 41);
            this.btnLimpiarProd.TabIndex = 21;
            this.btnLimpiarProd.Text = "Limpiar";
            this.btnLimpiarProd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 622);
            this.Controls.Add(this.btnLimpiarProd);
            this.Controls.Add(this.btnBuscarProductos);
            this.Controls.Add(this.btnLimpiarProv);
            this.Controls.Add(this.btnBuscarProv);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtBuscarProd);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clnFechaExp);
            this.Controls.Add(this.cbxCargarTodo);
            this.Controls.Add(this.Unidades);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.udCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarTitulo;
        private System.Windows.Forms.Label lblInfoSubtitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFechaExp;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown udCantidad;
        private System.Windows.Forms.TextBox Unidades;
        private System.Windows.Forms.CheckBox cbxCargarTodo;
        private System.Windows.Forms.MonthCalendar clnFechaExp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Button btnBuscarProv;
        private System.Windows.Forms.Button btnLimpiarProv;
        private System.Windows.Forms.Button btnBuscarProductos;
        private System.Windows.Forms.Button btnLimpiarProd;
    }
}

