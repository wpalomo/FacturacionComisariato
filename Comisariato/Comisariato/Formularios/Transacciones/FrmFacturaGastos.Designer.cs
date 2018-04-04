namespace Comisariato.Formularios.Transacciones
{
    partial class FrmFacturaGastos
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
            this.gbEncabezadoCompra = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtSerie1 = new System.Windows.Forms.TextBox();
            this.txtSerie2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.cbImpuesto = new System.Windows.Forms.ComboBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtOrdenCompra = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaOC = new System.Windows.Forms.DateTimePicker();
            this.gbDetalleProducto = new System.Windows.Forms.GroupBox();
            this.cbCuentaContableProveedor = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubtutalIVA = new System.Windows.Forms.TextBox();
            this.txtSubtotal0 = new System.Windows.Forms.TextBox();
            this.txtDesceunto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.btnSalirCompra = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.gbEncabezadoCompra.SuspendLayout();
            this.gbDetalleProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEncabezadoCompra
            // 
            this.gbEncabezadoCompra.Controls.Add(this.txtNumero);
            this.gbEncabezadoCompra.Controls.Add(this.txtSerie1);
            this.gbEncabezadoCompra.Controls.Add(this.txtSerie2);
            this.gbEncabezadoCompra.Controls.Add(this.label1);
            this.gbEncabezadoCompra.Controls.Add(this.btnProveedor);
            this.gbEncabezadoCompra.Controls.Add(this.cbImpuesto);
            this.gbEncabezadoCompra.Controls.Add(this.txtObservacion);
            this.gbEncabezadoCompra.Controls.Add(this.txtOrdenCompra);
            this.gbEncabezadoCompra.Controls.Add(this.label17);
            this.gbEncabezadoCompra.Controls.Add(this.label20);
            this.gbEncabezadoCompra.Controls.Add(this.label19);
            this.gbEncabezadoCompra.Controls.Add(this.label15);
            this.gbEncabezadoCompra.Controls.Add(this.label13);
            this.gbEncabezadoCompra.Controls.Add(this.cbSucursal);
            this.gbEncabezadoCompra.Controls.Add(this.cbProveedor);
            this.gbEncabezadoCompra.Controls.Add(this.label3);
            this.gbEncabezadoCompra.Controls.Add(this.dtpFechaOC);
            this.gbEncabezadoCompra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbEncabezadoCompra.ForeColor = System.Drawing.Color.Teal;
            this.gbEncabezadoCompra.Location = new System.Drawing.Point(12, 12);
            this.gbEncabezadoCompra.Name = "gbEncabezadoCompra";
            this.gbEncabezadoCompra.Size = new System.Drawing.Size(864, 137);
            this.gbEncabezadoCompra.TabIndex = 37;
            this.gbEncabezadoCompra.TabStop = false;
            this.gbEncabezadoCompra.Text = "Datos de la Orden de Compra";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNumero.Location = new System.Drawing.Point(695, 24);
            this.txtNumero.MaxLength = 9;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(156, 23);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie1_KeyDown);
            // 
            // txtSerie1
            // 
            this.txtSerie1.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSerie1.Location = new System.Drawing.Point(544, 24);
            this.txtSerie1.MaxLength = 3;
            this.txtSerie1.Name = "txtSerie1";
            this.txtSerie1.Size = new System.Drawing.Size(56, 23);
            this.txtSerie1.TabIndex = 2;
            this.txtSerie1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie1_KeyDown);
            // 
            // txtSerie2
            // 
            this.txtSerie2.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSerie2.Location = new System.Drawing.Point(614, 24);
            this.txtSerie2.MaxLength = 3;
            this.txtSerie2.Name = "txtSerie2";
            this.txtSerie2.Size = new System.Drawing.Size(56, 23);
            this.txtSerie2.TabIndex = 3;
            this.txtSerie2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(407, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "N° Factura Proveedor";
            // 
            // btnProveedor
            // 
            this.btnProveedor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.Location = new System.Drawing.Point(794, 52);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(57, 23);
            this.btnProveedor.TabIndex = 47;
            this.btnProveedor.Text = "Buscar";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // cbImpuesto
            // 
            this.cbImpuesto.Font = new System.Drawing.Font("Arial", 10F);
            this.cbImpuesto.FormattingEnabled = true;
            this.cbImpuesto.Location = new System.Drawing.Point(80, 77);
            this.cbImpuesto.Name = "cbImpuesto";
            this.cbImpuesto.Size = new System.Drawing.Size(214, 24);
            this.cbImpuesto.TabIndex = 7;
            this.cbImpuesto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie1_KeyDown);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Arial", 10F);
            this.txtObservacion.Location = new System.Drawing.Point(388, 81);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(463, 44);
            this.txtObservacion.TabIndex = 8;
            this.txtObservacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtObservacion_KeyDown);
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Enabled = false;
            this.txtOrdenCompra.Font = new System.Drawing.Font("Arial", 10F);
            this.txtOrdenCompra.Location = new System.Drawing.Point(80, 24);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.ReadOnly = true;
            this.txtOrdenCompra.Size = new System.Drawing.Size(50, 23);
            this.txtOrdenCompra.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Teal;
            this.label17.Location = new System.Drawing.Point(10, 54);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 16);
            this.label17.TabIndex = 41;
            this.label17.Text = "Sucursal:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Teal;
            this.label20.Location = new System.Drawing.Point(130, 27);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 16);
            this.label20.TabIndex = 41;
            this.label20.Text = "Fecha Doc:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Teal;
            this.label19.Location = new System.Drawing.Point(298, 80);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 16);
            this.label19.TabIndex = 41;
            this.label19.Text = "Observación:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(10, 27);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "N°:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(298, 53);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Proveedor:";
            // 
            // cbSucursal
            // 
            this.cbSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSucursal.Font = new System.Drawing.Font("Arial", 10F);
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(80, 50);
            this.cbSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(214, 24);
            this.cbSucursal.TabIndex = 5;
            this.cbSucursal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie1_KeyDown);
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownWidth = 225;
            this.cbProveedor.Font = new System.Drawing.Font("Arial", 10F);
            this.cbProveedor.Location = new System.Drawing.Point(388, 50);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(400, 24);
            this.cbProveedor.TabIndex = 6;
            this.cbProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Impuesto:";
            // 
            // dtpFechaOC
            // 
            this.dtpFechaOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaOC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaOC.Location = new System.Drawing.Point(205, 24);
            this.dtpFechaOC.Name = "dtpFechaOC";
            this.dtpFechaOC.Size = new System.Drawing.Size(89, 22);
            this.dtpFechaOC.TabIndex = 1;
            // 
            // gbDetalleProducto
            // 
            this.gbDetalleProducto.Controls.Add(this.cbCuentaContableProveedor);
            this.gbDetalleProducto.Controls.Add(this.label25);
            this.gbDetalleProducto.Controls.Add(this.txtTotal);
            this.gbDetalleProducto.Controls.Add(this.label12);
            this.gbDetalleProducto.Controls.Add(this.label7);
            this.gbDetalleProducto.Controls.Add(this.txtSubtutalIVA);
            this.gbDetalleProducto.Controls.Add(this.txtSubtotal0);
            this.gbDetalleProducto.Controls.Add(this.txtDesceunto);
            this.gbDetalleProducto.Controls.Add(this.label9);
            this.gbDetalleProducto.Controls.Add(this.label10);
            this.gbDetalleProducto.Controls.Add(this.label11);
            this.gbDetalleProducto.Controls.Add(this.txtIVA);
            this.gbDetalleProducto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gbDetalleProducto.ForeColor = System.Drawing.Color.Teal;
            this.gbDetalleProducto.Location = new System.Drawing.Point(12, 155);
            this.gbDetalleProducto.Name = "gbDetalleProducto";
            this.gbDetalleProducto.Size = new System.Drawing.Size(609, 199);
            this.gbDetalleProducto.TabIndex = 59;
            this.gbDetalleProducto.TabStop = false;
            this.gbDetalleProducto.Text = "Detalle de Gasto";
            // 
            // cbCuentaContableProveedor
            // 
            this.cbCuentaContableProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuentaContableProveedor.DropDownWidth = 400;
            this.cbCuentaContableProveedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCuentaContableProveedor.FormattingEnabled = true;
            this.cbCuentaContableProveedor.Location = new System.Drawing.Point(184, 27);
            this.cbCuentaContableProveedor.Name = "cbCuentaContableProveedor";
            this.cbCuentaContableProveedor.Size = new System.Drawing.Size(313, 24);
            this.cbCuentaContableProveedor.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(112, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 16);
            this.label25.TabIndex = 67;
            this.label25.Text = "Servicio:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 36F);
            this.txtTotal.Location = new System.Drawing.Point(335, 119);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(259, 63);
            this.txtTotal.TabIndex = 60;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F);
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(76, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 65;
            this.label12.Text = "Subtotal IVA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(76, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "Subtotal 0%:";
            // 
            // txtSubtutalIVA
            // 
            this.txtSubtutalIVA.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSubtutalIVA.Location = new System.Drawing.Point(195, 57);
            this.txtSubtutalIVA.Name = "txtSubtutalIVA";
            this.txtSubtutalIVA.Size = new System.Drawing.Size(88, 23);
            this.txtSubtutalIVA.TabIndex = 2;
            this.txtSubtutalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtutalIVA.Click += new System.EventHandler(this.txtSubtutalIVA_Click);
            this.txtSubtutalIVA.Enter += new System.EventHandler(this.txtSubtutalIVA_Enter);
            this.txtSubtutalIVA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie1_KeyDown);
            this.txtSubtutalIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubtutalIVA_KeyPress);
            this.txtSubtutalIVA.Leave += new System.EventHandler(this.txtSubtutalIVA_Leave);
            // 
            // txtSubtotal0
            // 
            this.txtSubtotal0.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSubtotal0.Location = new System.Drawing.Point(195, 86);
            this.txtSubtotal0.Name = "txtSubtotal0";
            this.txtSubtotal0.Size = new System.Drawing.Size(88, 23);
            this.txtSubtotal0.TabIndex = 3;
            this.txtSubtotal0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtotal0.Click += new System.EventHandler(this.txtSubtotal0_Click);
            this.txtSubtotal0.Enter += new System.EventHandler(this.txtSubtotal0_Enter);
            this.txtSubtotal0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie1_KeyDown);
            this.txtSubtotal0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubtotal0_KeyPress);
            this.txtSubtotal0.Leave += new System.EventHandler(this.txtSubtutalIVA_Leave);
            // 
            // txtDesceunto
            // 
            this.txtDesceunto.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDesceunto.Location = new System.Drawing.Point(445, 57);
            this.txtDesceunto.Name = "txtDesceunto";
            this.txtDesceunto.Size = new System.Drawing.Size(88, 23);
            this.txtDesceunto.TabIndex = 4;
            this.txtDesceunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesceunto.Click += new System.EventHandler(this.txtDesceunto_Click);
            this.txtDesceunto.Enter += new System.EventHandler(this.txtDesceunto_Enter);
            this.txtDesceunto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesceunto_KeyDown);
            this.txtDesceunto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesceunto_KeyPress);
            this.txtDesceunto.Leave += new System.EventHandler(this.txtSubtutalIVA_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(359, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 63;
            this.label9.Text = "Iva:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(261, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 62;
            this.label10.Text = "Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F);
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(359, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 61;
            this.label11.Text = "Descuento:";
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Arial", 10F);
            this.txtIVA.Location = new System.Drawing.Point(445, 86);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(88, 23);
            this.txtIVA.TabIndex = 56;
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIVA.Click += new System.EventHandler(this.txtIVA_Click);
            this.txtIVA.Enter += new System.EventHandler(this.txtIVA_Enter);
            this.txtIVA.Leave += new System.EventHandler(this.txtSubtutalIVA_Leave);
            // 
            // btnSalirCompra
            // 
            this.btnSalirCompra.Image = global::Comisariato.Properties.Resources.salir2;
            this.btnSalirCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirCompra.Location = new System.Drawing.Point(780, 301);
            this.btnSalirCompra.Name = "btnSalirCompra";
            this.btnSalirCompra.Size = new System.Drawing.Size(96, 53);
            this.btnSalirCompra.TabIndex = 62;
            this.btnSalirCompra.Text = "Salir";
            this.btnSalirCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirCompra.UseVisualStyleBackColor = true;
            this.btnSalirCompra.Click += new System.EventHandler(this.btnSalirCompra_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Image = global::Comisariato.Properties.Resources.limpiar;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(627, 253);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(135, 77);
            this.BtnLimpiar.TabIndex = 61;
            this.BtnLimpiar.Text = "&Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = global::Comisariato.Properties.Resources.guardar11;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(627, 161);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(135, 77);
            this.BtnGuardar.TabIndex = 60;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmFacturaGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(885, 372);
            this.Controls.Add(this.btnSalirCompra);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.gbDetalleProducto);
            this.Controls.Add(this.gbEncabezadoCompra);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmFacturaGastos";
            this.Text = "Factura de Gastos";
            this.Load += new System.EventHandler(this.FrmFacturaGastos_Load);
            this.gbEncabezadoCompra.ResumeLayout(false);
            this.gbEncabezadoCompra.PerformLayout();
            this.gbDetalleProducto.ResumeLayout(false);
            this.gbDetalleProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEncabezadoCompra;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtSerie1;
        private System.Windows.Forms.TextBox txtSerie2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.ComboBox cbImpuesto;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtOrdenCompra;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaOC;
        private System.Windows.Forms.GroupBox gbDetalleProducto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubtutalIVA;
        private System.Windows.Forms.TextBox txtSubtotal0;
        private System.Windows.Forms.TextBox txtDesceunto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Button btnSalirCompra;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox cbCuentaContableProveedor;
        private System.Windows.Forms.Label label25;
    }
}