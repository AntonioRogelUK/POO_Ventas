namespace VentasForms
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductoClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductoDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductoTasaIVA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductoValorUnitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConceptoCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVentaSubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVentaIVA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVentaTotal = new System.Windows.Forms.TextBox();
            this.chkProductoAplicaIVA = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgConceptos = new System.Windows.Forms.DataGridView();
            this.btnConceptosAgregar = new System.Windows.Forms.Button();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReiniciarVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConceptos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // txtProductoClave
            // 
            this.txtProductoClave.Location = new System.Drawing.Point(69, 31);
            this.txtProductoClave.Name = "txtProductoClave";
            this.txtProductoClave.Size = new System.Drawing.Size(100, 20);
            this.txtProductoClave.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción";
            // 
            // txtProductoDescripcion
            // 
            this.txtProductoDescripcion.Location = new System.Drawing.Point(249, 31);
            this.txtProductoDescripcion.Name = "txtProductoDescripcion";
            this.txtProductoDescripcion.Size = new System.Drawing.Size(457, 20);
            this.txtProductoDescripcion.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tasa IVA";
            // 
            // txtProductoTasaIVA
            // 
            this.txtProductoTasaIVA.Location = new System.Drawing.Point(402, 57);
            this.txtProductoTasaIVA.Name = "txtProductoTasaIVA";
            this.txtProductoTasaIVA.Size = new System.Drawing.Size(100, 20);
            this.txtProductoTasaIVA.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor unitario";
            // 
            // txtProductoValorUnitario
            // 
            this.txtProductoValorUnitario.Location = new System.Drawing.Point(606, 60);
            this.txtProductoValorUnitario.Name = "txtProductoValorUnitario";
            this.txtProductoValorUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtProductoValorUnitario.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cantidad";
            // 
            // txtConceptoCantidad
            // 
            this.txtConceptoCantidad.Location = new System.Drawing.Point(511, 19);
            this.txtConceptoCantidad.Name = "txtConceptoCantidad";
            this.txtConceptoCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtConceptoCantidad.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "SubTotal";
            // 
            // txtVentaSubtotal
            // 
            this.txtVentaSubtotal.Location = new System.Drawing.Point(606, 323);
            this.txtVentaSubtotal.Name = "txtVentaSubtotal";
            this.txtVentaSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtVentaSubtotal.TabIndex = 1;
            this.txtVentaSubtotal.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "IVA";
            // 
            // txtVentaIVA
            // 
            this.txtVentaIVA.Location = new System.Drawing.Point(606, 351);
            this.txtVentaIVA.Name = "txtVentaIVA";
            this.txtVentaIVA.Size = new System.Drawing.Size(100, 20);
            this.txtVentaIVA.TabIndex = 1;
            this.txtVentaIVA.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(565, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total";
            // 
            // txtVentaTotal
            // 
            this.txtVentaTotal.Location = new System.Drawing.Point(606, 377);
            this.txtVentaTotal.Name = "txtVentaTotal";
            this.txtVentaTotal.Size = new System.Drawing.Size(100, 20);
            this.txtVentaTotal.TabIndex = 1;
            this.txtVentaTotal.TabStop = false;
            // 
            // chkProductoAplicaIVA
            // 
            this.chkProductoAplicaIVA.AutoSize = true;
            this.chkProductoAplicaIVA.Location = new System.Drawing.Point(249, 57);
            this.chkProductoAplicaIVA.Name = "chkProductoAplicaIVA";
            this.chkProductoAplicaIVA.Size = new System.Drawing.Size(75, 17);
            this.chkProductoAplicaIVA.TabIndex = 2;
            this.chkProductoAplicaIVA.Text = "Aplica IVA";
            this.chkProductoAplicaIVA.UseVisualStyleBackColor = true;
            this.chkProductoAplicaIVA.CheckedChanged += new System.EventHandler(this.chkProductoAplicaIVA_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProductoClave);
            this.groupBox1.Controls.Add(this.chkProductoAplicaIVA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProductoDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProductoTasaIVA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtProductoValorUnitario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnReiniciarVenta);
            this.groupBox2.Controls.Add(this.dtgConceptos);
            this.groupBox2.Controls.Add(this.btnConceptosAgregar);
            this.groupBox2.Controls.Add(this.txtVentaIVA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtVentaTotal);
            this.groupBox2.Controls.Add(this.txtConceptoCantidad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtVentaSubtotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Venta";
            // 
            // dtgConceptos
            // 
            this.dtgConceptos.AllowUserToAddRows = false;
            this.dtgConceptos.AllowUserToDeleteRows = false;
            this.dtgConceptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Clave,
            this.Descripcion,
            this.ValorUnitario,
            this.Importe});
            this.dtgConceptos.Location = new System.Drawing.Point(17, 46);
            this.dtgConceptos.Name = "dtgConceptos";
            this.dtgConceptos.ReadOnly = true;
            this.dtgConceptos.RowHeadersVisible = false;
            this.dtgConceptos.Size = new System.Drawing.Size(689, 271);
            this.dtgConceptos.TabIndex = 3;
            this.dtgConceptos.TabStop = false;
            // 
            // btnConceptosAgregar
            // 
            this.btnConceptosAgregar.Location = new System.Drawing.Point(617, 17);
            this.btnConceptosAgregar.Name = "btnConceptosAgregar";
            this.btnConceptosAgregar.Size = new System.Drawing.Size(89, 23);
            this.btnConceptosAgregar.TabIndex = 1;
            this.btnConceptosAgregar.Text = "Agregar";
            this.btnConceptosAgregar.UseVisualStyleBackColor = true;
            this.btnConceptosAgregar.Click += new System.EventHandler(this.btnConceptosAgregar_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle7;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "Clave";
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0.00";
            this.ValorUnitario.DefaultCellStyle = dataGridViewCellStyle8;
            this.ValorUnitario.HeaderText = "ValorUnitario";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0.00";
            this.Importe.DefaultCellStyle = dataGridViewCellStyle9;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // btnReiniciarVenta
            // 
            this.btnReiniciarVenta.Location = new System.Drawing.Point(6, 348);
            this.btnReiniciarVenta.Name = "btnReiniciarVenta";
            this.btnReiniciarVenta.Size = new System.Drawing.Size(175, 23);
            this.btnReiniciarVenta.TabIndex = 4;
            this.btnReiniciarVenta.Text = "Reiniciar venta";
            this.btnReiniciarVenta.UseVisualStyleBackColor = true;
            this.btnReiniciarVenta.Click += new System.EventHandler(this.btnReiniciarVenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(6, 380);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(175, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConceptos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductoClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductoDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductoTasaIVA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductoValorUnitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConceptoCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVentaSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVentaIVA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVentaTotal;
        private System.Windows.Forms.CheckBox chkProductoAplicaIVA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgConceptos;
        private System.Windows.Forms.Button btnConceptosAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReiniciarVenta;
    }
}