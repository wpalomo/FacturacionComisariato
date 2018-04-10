namespace Comisariato.Formularios.Transacciones.Devolucion_Venta
{
    partial class FrmDevolucionVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.txtNumFact = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAutorizacionND = new System.Windows.Forms.TextBox();
            this.txtNumeroND = new System.Windows.Forms.TextBox();
            this.txtSerie1ND = new System.Windows.Forms.TextBox();
            this.txtSerie2ND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvDetalleFact = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.txtTotalDevolucion = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalirCompra = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvDatosProducto = new System.Windows.Forms.DataGridView();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNCVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleFact)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProducto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSucursal
            // 
            this.txtSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucursal.Location = new System.Drawing.Point(517, 21);
            this.txtSucursal.MaxLength = 3;
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(56, 22);
            this.txtSucursal.TabIndex = 0;
            this.txtSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSucursal_KeyPress);
            // 
            // txtCaja
            // 
            this.txtCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja.Location = new System.Drawing.Point(579, 21);
            this.txtCaja.MaxLength = 3;
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(56, 22);
            this.txtCaja.TabIndex = 1;
            this.txtCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaja_KeyPress);
            // 
            // txtNumFact
            // 
            this.txtNumFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFact.Location = new System.Drawing.Point(641, 21);
            this.txtNumFact.MaxLength = 9;
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.Size = new System.Drawing.Size(156, 22);
            this.txtNumFact.TabIndex = 2;
            this.txtNumFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAutorizacionND);
            this.groupBox1.Controls.Add(this.txtNumeroND);
            this.groupBox1.Controls.Add(this.txtSerie1ND);
            this.groupBox1.Controls.Add(this.txtSerie2ND);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumFact);
            this.groupBox1.Controls.Add(this.txtSucursal);
            this.groupBox1.Controls.Add(this.txtCaja);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(54, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(446, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCliente.Location = new System.Drawing.Point(517, 49);
            this.txtCliente.MaxLength = 9;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(280, 23);
            this.txtCliente.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(7, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Autorización:";
            // 
            // txtAutorizacionND
            // 
            this.txtAutorizacionND.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAutorizacionND.Location = new System.Drawing.Point(144, 49);
            this.txtAutorizacionND.MaxLength = 9;
            this.txtAutorizacionND.Name = "txtAutorizacionND";
            this.txtAutorizacionND.ReadOnly = true;
            this.txtAutorizacionND.Size = new System.Drawing.Size(185, 23);
            this.txtAutorizacionND.TabIndex = 69;
            // 
            // txtNumeroND
            // 
            this.txtNumeroND.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNumeroND.Location = new System.Drawing.Point(265, 21);
            this.txtNumeroND.MaxLength = 9;
            this.txtNumeroND.Name = "txtNumeroND";
            this.txtNumeroND.ReadOnly = true;
            this.txtNumeroND.Size = new System.Drawing.Size(156, 23);
            this.txtNumeroND.TabIndex = 68;
            // 
            // txtSerie1ND
            // 
            this.txtSerie1ND.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSerie1ND.Location = new System.Drawing.Point(144, 21);
            this.txtSerie1ND.MaxLength = 3;
            this.txtSerie1ND.Name = "txtSerie1ND";
            this.txtSerie1ND.ReadOnly = true;
            this.txtSerie1ND.Size = new System.Drawing.Size(56, 23);
            this.txtSerie1ND.TabIndex = 66;
            // 
            // txtSerie2ND
            // 
            this.txtSerie2ND.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSerie2ND.Location = new System.Drawing.Point(204, 21);
            this.txtSerie2ND.MaxLength = 3;
            this.txtSerie2ND.Name = "txtSerie2ND";
            this.txtSerie2ND.ReadOnly = true;
            this.txtSerie2ND.Size = new System.Drawing.Size(56, 23);
            this.txtSerie2ND.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "N° Nota de Crédito:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblUsuario.Location = new System.Drawing.Point(8, 80);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 16);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.checkBox1.Location = new System.Drawing.Point(449, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Devolver toda la Venta";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nº. FACT:";
            // 
            // DgvDetalleFact
            // 
            this.DgvDetalleFact.AllowUserToAddRows = false;
            this.DgvDetalleFact.AllowUserToDeleteRows = false;
            this.DgvDetalleFact.AllowUserToOrderColumns = true;
            this.DgvDetalleFact.AllowUserToResizeColumns = false;
            this.DgvDetalleFact.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDetalleFact.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDetalleFact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DETALLE,
            this.CANTIDAD,
            this.PRECIO,
            this.IVA,
            this.TOTAL,
            this.Column1,
            this.Anular});
            this.DgvDetalleFact.Location = new System.Drawing.Point(18, 138);
            this.DgvDetalleFact.Name = "DgvDetalleFact";
            this.DgvDetalleFact.RowHeadersVisible = false;
            this.DgvDetalleFact.Size = new System.Drawing.Size(880, 337);
            this.DgvDetalleFact.TabIndex = 5;
            this.DgvDetalleFact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalleFact_CellClick);
            this.DgvDetalleFact.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalleFact_CellEndEdit);
            this.DgvDetalleFact.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvDetalleFact_EditingControlShowing);
            // 
            // CODIGO
            // 
            this.CODIGO.FillWeight = 105.5838F;
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 125;
            // 
            // DETALLE
            // 
            this.DETALLE.FillWeight = 105.5838F;
            this.DETALLE.HeaderText = "Detalle";
            this.DETALLE.Name = "DETALLE";
            this.DETALLE.ReadOnly = true;
            this.DETALLE.Width = 250;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.FillWeight = 105.5838F;
            this.CANTIDAD.HeaderText = "Cant.";
            this.CANTIDAD.MaxInputLength = 5;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 50;
            // 
            // PRECIO
            // 
            this.PRECIO.FillWeight = 105.5838F;
            this.PRECIO.HeaderText = "Precio";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.Width = 90;
            // 
            // IVA
            // 
            this.IVA.FillWeight = 105.5838F;
            this.IVA.HeaderText = "Iva";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.FillWeight = 105.5838F;
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 105.5838F;
            this.Column1.HeaderText = "C. Devolver";
            this.Column1.MaxInputLength = 5;
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // Anular
            // 
            this.Anular.FillWeight = 60.9137F;
            this.Anular.HeaderText = "Anular";
            this.Anular.Name = "Anular";
            this.Anular.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Anular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Anular.Width = 50;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Enabled = false;
            this.txtTotalFactura.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFactura.Location = new System.Drawing.Point(638, 481);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(259, 41);
            this.txtTotalFactura.TabIndex = 8;
            // 
            // txtTotalDevolucion
            // 
            this.txtTotalDevolucion.Enabled = false;
            this.txtTotalDevolucion.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDevolucion.Location = new System.Drawing.Point(638, 528);
            this.txtTotalDevolucion.Name = "txtTotalDevolucion";
            this.txtTotalDevolucion.Size = new System.Drawing.Size(259, 41);
            this.txtTotalDevolucion.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 612);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Bisque;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnSalirCompra);
            this.tabPage1.Controls.Add(this.BtnLimpiar);
            this.tabPage1.Controls.Add(this.BtnGuardar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.DgvDetalleFact);
            this.tabPage1.Controls.Add(this.txtTotalDevolucion);
            this.tabPage1.Controls.Add(this.txtTotalFactura);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(929, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nota de Débito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(496, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "Total Devolución:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(496, 493);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 61;
            this.label10.Text = "Total Compra:";
            // 
            // btnSalirCompra
            // 
            this.btnSalirCompra.ForeColor = System.Drawing.Color.Teal;
            this.btnSalirCompra.Image = global::Comisariato.Properties.Resources.salir2;
            this.btnSalirCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirCompra.Location = new System.Drawing.Point(18, 481);
            this.btnSalirCompra.Name = "btnSalirCompra";
            this.btnSalirCompra.Size = new System.Drawing.Size(96, 53);
            this.btnSalirCompra.TabIndex = 14;
            this.btnSalirCompra.Text = "Salir";
            this.btnSalirCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirCompra.UseVisualStyleBackColor = true;
            this.btnSalirCompra.Click += new System.EventHandler(this.btnSalirCompra_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Teal;
            this.BtnLimpiar.Image = global::Comisariato.Properties.Resources.limpiar;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(287, 481);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(135, 77);
            this.BtnLimpiar.TabIndex = 13;
            this.BtnLimpiar.Text = "&Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.ForeColor = System.Drawing.Color.Teal;
            this.BtnGuardar.Image = global::Comisariato.Properties.Resources.guardar11;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(135, 481);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(135, 77);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.btnConsultar);
            this.tabPage2.Controls.Add(this.dgvDatosProducto);
            this.tabPage2.Controls.Add(this.txtConsultar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(929, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Nota de Débito";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnConsultar.Location = new System.Drawing.Point(790, 51);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(114, 25);
            this.btnConsultar.TabIndex = 29;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvDatosProducto
            // 
            this.dgvDatosProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.nc,
            this.compra,
            this.Cliente,
            this.totalDevolucion,
            this.totalVenta,
            this.idNCVenta,
            this.idFactura});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosProducto.Location = new System.Drawing.Point(25, 127);
            this.dgvDatosProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosProducto.Name = "dgvDatosProducto";
            this.dgvDatosProducto.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatosProducto.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Teal;
            this.dgvDatosProducto.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatosProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosProducto.Size = new System.Drawing.Size(879, 446);
            this.dgvDatosProducto.TabIndex = 27;
            // 
            // txtConsultar
            // 
            this.txtConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultar.Location = new System.Drawing.Point(505, 52);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(268, 22);
            this.txtConsultar.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(432, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Consultar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpHasta);
            this.groupBox2.Controls.Add(this.dtpDesde);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(25, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 113);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Location = new System.Drawing.Point(91, 66);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(292, 22);
            this.dtpHasta.TabIndex = 20;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Location = new System.Drawing.Point(91, 27);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(292, 22);
            this.dtpDesde.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Hasta:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "Desde:";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 135;
            // 
            // nc
            // 
            this.nc.HeaderText = "Número Nota Crédito";
            this.nc.Name = "nc";
            this.nc.ReadOnly = true;
            this.nc.Width = 165;
            // 
            // compra
            // 
            this.compra.HeaderText = "Numero Factura";
            this.compra.Name = "compra";
            this.compra.ReadOnly = true;
            this.compra.Width = 150;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Identificación Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 200;
            // 
            // totalDevolucion
            // 
            this.totalDevolucion.HeaderText = "Total Dev.";
            this.totalDevolucion.Name = "totalDevolucion";
            this.totalDevolucion.ReadOnly = true;
            // 
            // totalVenta
            // 
            this.totalVenta.HeaderText = "Total Venta";
            this.totalVenta.Name = "totalVenta";
            this.totalVenta.ReadOnly = true;
            // 
            // idNCVenta
            // 
            this.idNCVenta.HeaderText = "idNC";
            this.idNCVenta.Name = "idNCVenta";
            this.idNCVenta.ReadOnly = true;
            this.idNCVenta.Visible = false;
            // 
            // idFactura
            // 
            this.idFactura.HeaderText = "Factura";
            this.idFactura.Name = "idFactura";
            this.idFactura.ReadOnly = true;
            this.idFactura.Visible = false;
            // 
            // FrmDevolucionVenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(961, 624);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(977, 663);
            this.MinimumSize = new System.Drawing.Size(977, 663);
            this.Name = "FrmDevolucionVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota de Débito";
            this.Load += new System.EventHandler(this.FrmDevolucionVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleFact)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProducto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.TextBox txtNumFact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvDetalleFact;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.TextBox txtTotalDevolucion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSalirCompra;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAutorizacionND;
        private System.Windows.Forms.TextBox txtNumeroND;
        private System.Windows.Forms.TextBox txtSerie1ND;
        private System.Windows.Forms.TextBox txtSerie2ND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DETALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvDatosProducto;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nc;
        private System.Windows.Forms.DataGridViewTextBoxColumn compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNCVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactura;
    }
}