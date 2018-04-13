namespace Comisariato.Formularios.Transacciones.Venta
{
    partial class FrmAdministrarPromociones
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
            this.tabControlPromociones = new System.Windows.Forms.TabControl();
            this.pcOrdenCompra = new System.Windows.Forms.TabPage();
            this.GrbDatosTicket = new System.Windows.Forms.GroupBox();
            this.TxtLinea5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtLinea1 = new System.Windows.Forms.TextBox();
            this.TxtLinea2 = new System.Windows.Forms.TextBox();
            this.TxtLinea3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtCabecera = new System.Windows.Forms.TextBox();
            this.TxtLinea4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GrbDatosPromocion = new System.Windows.Forms.GroupBox();
            this.TxtIdPromocion = new System.Windows.Forms.TextBox();
            this.CmbTipoPromocion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtMontoFinal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtMontoInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NudNumTickets = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaVencimientoCupon = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbInformeCompra = new System.Windows.Forms.GroupBox();
            this.DgvPromociones = new System.Windows.Forms.DataGridView();
            this.GrbConsulta = new System.Windows.Forms.GroupBox();
            this.rbtInactivos = new System.Windows.Forms.RadioButton();
            this.rbtActivos = new System.Windows.Forms.RadioButton();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnActivarDescativar = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControlPromociones.SuspendLayout();
            this.pcOrdenCompra.SuspendLayout();
            this.GrbDatosTicket.SuspendLayout();
            this.GrbDatosPromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudNumTickets)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbInformeCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPromociones)).BeginInit();
            this.GrbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPromociones
            // 
            this.tabControlPromociones.Controls.Add(this.pcOrdenCompra);
            this.tabControlPromociones.Controls.Add(this.tabPage2);
            this.tabControlPromociones.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tabControlPromociones.Location = new System.Drawing.Point(11, 11);
            this.tabControlPromociones.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlPromociones.Name = "tabControlPromociones";
            this.tabControlPromociones.SelectedIndex = 0;
            this.tabControlPromociones.Size = new System.Drawing.Size(826, 565);
            this.tabControlPromociones.TabIndex = 2;
            // 
            // pcOrdenCompra
            // 
            this.pcOrdenCompra.BackColor = System.Drawing.Color.Bisque;
            this.pcOrdenCompra.Controls.Add(this.GrbDatosTicket);
            this.pcOrdenCompra.Controls.Add(this.btnSalir);
            this.pcOrdenCompra.Controls.Add(this.BtnLimpiar);
            this.pcOrdenCompra.Controls.Add(this.BtnGuardar);
            this.pcOrdenCompra.Controls.Add(this.GrbDatosPromocion);
            this.pcOrdenCompra.ForeColor = System.Drawing.Color.DarkCyan;
            this.pcOrdenCompra.Location = new System.Drawing.Point(4, 25);
            this.pcOrdenCompra.Margin = new System.Windows.Forms.Padding(2);
            this.pcOrdenCompra.Name = "pcOrdenCompra";
            this.pcOrdenCompra.Padding = new System.Windows.Forms.Padding(2);
            this.pcOrdenCompra.Size = new System.Drawing.Size(818, 536);
            this.pcOrdenCompra.TabIndex = 0;
            this.pcOrdenCompra.Text = "Promociones";
            // 
            // GrbDatosTicket
            // 
            this.GrbDatosTicket.Controls.Add(this.TxtLinea5);
            this.GrbDatosTicket.Controls.Add(this.label12);
            this.GrbDatosTicket.Controls.Add(this.label7);
            this.GrbDatosTicket.Controls.Add(this.TxtLinea1);
            this.GrbDatosTicket.Controls.Add(this.TxtLinea2);
            this.GrbDatosTicket.Controls.Add(this.TxtLinea3);
            this.GrbDatosTicket.Controls.Add(this.label9);
            this.GrbDatosTicket.Controls.Add(this.label11);
            this.GrbDatosTicket.Controls.Add(this.TxtCabecera);
            this.GrbDatosTicket.Controls.Add(this.TxtLinea4);
            this.GrbDatosTicket.Controls.Add(this.label6);
            this.GrbDatosTicket.Controls.Add(this.label5);
            this.GrbDatosTicket.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.GrbDatosTicket.ForeColor = System.Drawing.Color.Teal;
            this.GrbDatosTicket.Location = new System.Drawing.Point(23, 188);
            this.GrbDatosTicket.Name = "GrbDatosTicket";
            this.GrbDatosTicket.Size = new System.Drawing.Size(767, 231);
            this.GrbDatosTicket.TabIndex = 8;
            this.GrbDatosTicket.TabStop = false;
            this.GrbDatosTicket.Text = "Datos Ticket";
            // 
            // TxtLinea5
            // 
            this.TxtLinea5.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtLinea5.Location = new System.Drawing.Point(198, 178);
            this.TxtLinea5.Name = "TxtLinea5";
            this.TxtLinea5.Size = new System.Drawing.Size(545, 23);
            this.TxtLinea5.TabIndex = 14;
            this.TxtLinea5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudNumTickets_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F);
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(12, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 55;
            this.label12.Text = "Línea 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(12, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Línea 2:";
            // 
            // TxtLinea1
            // 
            this.TxtLinea1.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtLinea1.Location = new System.Drawing.Point(198, 63);
            this.TxtLinea1.Name = "TxtLinea1";
            this.TxtLinea1.Size = new System.Drawing.Size(545, 23);
            this.TxtLinea1.TabIndex = 10;
            this.TxtLinea1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudNumTickets_KeyPress);
            // 
            // TxtLinea2
            // 
            this.TxtLinea2.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtLinea2.Location = new System.Drawing.Point(198, 92);
            this.TxtLinea2.Name = "TxtLinea2";
            this.TxtLinea2.Size = new System.Drawing.Size(545, 23);
            this.TxtLinea2.TabIndex = 11;
            this.TxtLinea2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudNumTickets_KeyPress);
            // 
            // TxtLinea3
            // 
            this.TxtLinea3.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtLinea3.Location = new System.Drawing.Point(198, 121);
            this.TxtLinea3.Name = "TxtLinea3";
            this.TxtLinea3.Size = new System.Drawing.Size(545, 23);
            this.TxtLinea3.TabIndex = 12;
            this.TxtLinea3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudNumTickets_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(12, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "Cabecera:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F);
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(12, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "Línea 3";
            // 
            // TxtCabecera
            // 
            this.TxtCabecera.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtCabecera.Location = new System.Drawing.Point(198, 31);
            this.TxtCabecera.Name = "TxtCabecera";
            this.TxtCabecera.Size = new System.Drawing.Size(545, 23);
            this.TxtCabecera.TabIndex = 9;
            this.TxtCabecera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudNumTickets_KeyPress);
            // 
            // TxtLinea4
            // 
            this.TxtLinea4.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtLinea4.Location = new System.Drawing.Point(198, 149);
            this.TxtLinea4.Name = "TxtLinea4";
            this.TxtLinea4.Size = new System.Drawing.Size(545, 23);
            this.TxtLinea4.TabIndex = 13;
            this.TxtLinea4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudNumTickets_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(12, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Línea 5:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Línea 4:";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Comisariato.Properties.Resources.salir2;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(23, 469);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 53);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Image = global::Comisariato.Properties.Resources.limpiar;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(669, 445);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(135, 77);
            this.BtnLimpiar.TabIndex = 16;
            this.BtnLimpiar.Text = "&Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = global::Comisariato.Properties.Resources.guardar11;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(517, 445);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(135, 77);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // GrbDatosPromocion
            // 
            this.GrbDatosPromocion.Controls.Add(this.TxtIdPromocion);
            this.GrbDatosPromocion.Controls.Add(this.CmbTipoPromocion);
            this.GrbDatosPromocion.Controls.Add(this.label10);
            this.GrbDatosPromocion.Controls.Add(this.TxtMontoFinal);
            this.GrbDatosPromocion.Controls.Add(this.label8);
            this.GrbDatosPromocion.Controls.Add(this.TxtMontoInicial);
            this.GrbDatosPromocion.Controls.Add(this.label4);
            this.GrbDatosPromocion.Controls.Add(this.NudNumTickets);
            this.GrbDatosPromocion.Controls.Add(this.label3);
            this.GrbDatosPromocion.Controls.Add(this.label2);
            this.GrbDatosPromocion.Controls.Add(this.DtpFechaVencimientoCupon);
            this.GrbDatosPromocion.Controls.Add(this.label1);
            this.GrbDatosPromocion.Controls.Add(this.DtpFechaFin);
            this.GrbDatosPromocion.Controls.Add(this.label17);
            this.GrbDatosPromocion.Controls.Add(this.label);
            this.GrbDatosPromocion.Controls.Add(this.DtpFechaInicio);
            this.GrbDatosPromocion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.GrbDatosPromocion.ForeColor = System.Drawing.Color.Teal;
            this.GrbDatosPromocion.Location = new System.Drawing.Point(23, 5);
            this.GrbDatosPromocion.Name = "GrbDatosPromocion";
            this.GrbDatosPromocion.Size = new System.Drawing.Size(771, 163);
            this.GrbDatosPromocion.TabIndex = 36;
            this.GrbDatosPromocion.TabStop = false;
            this.GrbDatosPromocion.Text = "Datos Promoción";
            // 
            // TxtIdPromocion
            // 
            this.TxtIdPromocion.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtIdPromocion.Location = new System.Drawing.Point(690, 11);
            this.TxtIdPromocion.Name = "TxtIdPromocion";
            this.TxtIdPromocion.ReadOnly = true;
            this.TxtIdPromocion.Size = new System.Drawing.Size(78, 23);
            this.TxtIdPromocion.TabIndex = 60;
            this.TxtIdPromocion.Text = "ID";
            this.TxtIdPromocion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtIdPromocion.Visible = false;
            // 
            // CmbTipoPromocion
            // 
            this.CmbTipoPromocion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoPromocion.FormattingEnabled = true;
            this.CmbTipoPromocion.Items.AddRange(new object[] {
            "Promoción",
            "Rifa"});
            this.CmbTipoPromocion.Location = new System.Drawing.Point(626, 69);
            this.CmbTipoPromocion.Name = "CmbTipoPromocion";
            this.CmbTipoPromocion.Size = new System.Drawing.Size(129, 24);
            this.CmbTipoPromocion.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(533, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 59;
            this.label10.Text = "Num. Tickets:";
            // 
            // TxtMontoFinal
            // 
            this.TxtMontoFinal.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtMontoFinal.Location = new System.Drawing.Point(450, 118);
            this.TxtMontoFinal.Name = "TxtMontoFinal";
            this.TxtMontoFinal.Size = new System.Drawing.Size(78, 23);
            this.TxtMontoFinal.TabIndex = 7;
            this.TxtMontoFinal.Text = "0.00";
            this.TxtMontoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMontoFinal.Enter += new System.EventHandler(this.TxtMontoFinal_Enter);
            this.TxtMontoFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMontoFinal_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(327, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 57;
            this.label8.Text = "Monto Final:";
            // 
            // TxtMontoInicial
            // 
            this.TxtMontoInicial.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtMontoInicial.Location = new System.Drawing.Point(131, 118);
            this.TxtMontoInicial.Name = "TxtMontoInicial";
            this.TxtMontoInicial.Size = new System.Drawing.Size(78, 23);
            this.TxtMontoInicial.TabIndex = 6;
            this.TxtMontoInicial.Text = "0.00";
            this.TxtMontoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMontoInicial.Enter += new System.EventHandler(this.TxtMontoInicial_Enter);
            this.TxtMontoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMontoInicial_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Monto Inicial:";
            // 
            // NudNumTickets
            // 
            this.NudNumTickets.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudNumTickets.Location = new System.Drawing.Point(450, 70);
            this.NudNumTickets.Name = "NudNumTickets";
            this.NudNumTickets.Size = new System.Drawing.Size(57, 22);
            this.NudNumTickets.TabIndex = 4;
            this.NudNumTickets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudNumTickets_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(327, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Num. Tickets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Cupón:";
            // 
            // DtpFechaVencimientoCupon
            // 
            this.DtpFechaVencimientoCupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaVencimientoCupon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaVencimientoCupon.Location = new System.Drawing.Point(131, 70);
            this.DtpFechaVencimientoCupon.Name = "DtpFechaVencimientoCupon";
            this.DtpFechaVencimientoCupon.Size = new System.Drawing.Size(155, 22);
            this.DtpFechaVencimientoCupon.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(327, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Fecha Fin:";
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFin.Location = new System.Drawing.Point(450, 24);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(155, 22);
            this.DtpFechaFin.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Teal;
            this.label17.Location = new System.Drawing.Point(10, 63);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 16);
            this.label17.TabIndex = 41;
            this.label17.Text = "Fecha Vencimiento";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Teal;
            this.label.Location = new System.Drawing.Point(10, 27);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(82, 16);
            this.label.TabIndex = 41;
            this.label.Text = "Fecha Inicio:";
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicio.Location = new System.Drawing.Point(131, 24);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(155, 22);
            this.DtpFechaInicio.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.gbInformeCompra);
            this.tabPage2.Controls.Add(this.GrbConsulta);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(818, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Promociones";
            // 
            // gbInformeCompra
            // 
            this.gbInformeCompra.Controls.Add(this.DgvPromociones);
            this.gbInformeCompra.Font = new System.Drawing.Font("Arial", 10F);
            this.gbInformeCompra.Location = new System.Drawing.Point(17, 133);
            this.gbInformeCompra.Name = "gbInformeCompra";
            this.gbInformeCompra.Size = new System.Drawing.Size(778, 387);
            this.gbInformeCompra.TabIndex = 26;
            this.gbInformeCompra.TabStop = false;
            // 
            // DgvPromociones
            // 
            this.DgvPromociones.AllowUserToAddRows = false;
            this.DgvPromociones.AllowUserToDeleteRows = false;
            this.DgvPromociones.AllowUserToOrderColumns = true;
            this.DgvPromociones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvPromociones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPromociones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPromociones.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPromociones.Location = new System.Drawing.Point(9, 20);
            this.DgvPromociones.Name = "DgvPromociones";
            this.DgvPromociones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPromociones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPromociones.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            this.DgvPromociones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvPromociones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPromociones.Size = new System.Drawing.Size(758, 351);
            this.DgvPromociones.TabIndex = 22;
            this.DgvPromociones.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPromociones_CellEnter);
            // 
            // GrbConsulta
            // 
            this.GrbConsulta.Controls.Add(this.rbtInactivos);
            this.GrbConsulta.Controls.Add(this.rbtActivos);
            this.GrbConsulta.Controls.Add(this.dtpHasta);
            this.GrbConsulta.Controls.Add(this.btnModificar);
            this.GrbConsulta.Controls.Add(this.btnActivarDescativar);
            this.GrbConsulta.Controls.Add(this.dtpDesde);
            this.GrbConsulta.Controls.Add(this.label14);
            this.GrbConsulta.Controls.Add(this.btnConsultar);
            this.GrbConsulta.Controls.Add(this.label16);
            this.GrbConsulta.ForeColor = System.Drawing.Color.Teal;
            this.GrbConsulta.Location = new System.Drawing.Point(17, 14);
            this.GrbConsulta.Name = "GrbConsulta";
            this.GrbConsulta.Size = new System.Drawing.Size(778, 113);
            this.GrbConsulta.TabIndex = 19;
            this.GrbConsulta.TabStop = false;
            this.GrbConsulta.Text = "Fecha";
            // 
            // rbtInactivos
            // 
            this.rbtInactivos.AutoSize = true;
            this.rbtInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtInactivos.ForeColor = System.Drawing.Color.Teal;
            this.rbtInactivos.Location = new System.Drawing.Point(475, 87);
            this.rbtInactivos.Name = "rbtInactivos";
            this.rbtInactivos.Size = new System.Drawing.Size(79, 20);
            this.rbtInactivos.TabIndex = 27;
            this.rbtInactivos.Text = "Inactivos";
            this.rbtInactivos.UseVisualStyleBackColor = true;
            this.rbtInactivos.CheckedChanged += new System.EventHandler(this.rbtActivos_CheckedChanged);
            // 
            // rbtActivos
            // 
            this.rbtActivos.AutoSize = true;
            this.rbtActivos.Checked = true;
            this.rbtActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtActivos.ForeColor = System.Drawing.Color.Teal;
            this.rbtActivos.Location = new System.Drawing.Point(387, 87);
            this.rbtActivos.Name = "rbtActivos";
            this.rbtActivos.Size = new System.Drawing.Size(70, 20);
            this.rbtActivos.TabIndex = 26;
            this.rbtActivos.TabStop = true;
            this.rbtActivos.Text = "Activos";
            this.rbtActivos.UseVisualStyleBackColor = true;
            this.rbtActivos.CheckedChanged += new System.EventHandler(this.rbtActivos_CheckedChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(98, 66);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(256, 22);
            this.dtpHasta.TabIndex = 20;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnModificar.Location = new System.Drawing.Point(665, 84);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnActivarDescativar
            // 
            this.btnActivarDescativar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnActivarDescativar.Location = new System.Drawing.Point(573, 84);
            this.btnActivarDescativar.Name = "btnActivarDescativar";
            this.btnActivarDescativar.Size = new System.Drawing.Size(75, 23);
            this.btnActivarDescativar.TabIndex = 25;
            this.btnActivarDescativar.Text = "Activar";
            this.btnActivarDescativar.UseVisualStyleBackColor = true;
            this.btnActivarDescativar.Click += new System.EventHandler(this.btnActivarDescativar_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(98, 27);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(256, 22);
            this.dtpDesde.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Hasta:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnConsultar.Location = new System.Drawing.Point(600, 28);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(114, 25);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "Desde:";
            // 
            // FrmAdministrarPromociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(855, 588);
            this.Controls.Add(this.tabControlPromociones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(871, 626);
            this.MinimumSize = new System.Drawing.Size(871, 626);
            this.Name = "FrmAdministrarPromociones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Administrar Promociones";
            this.Load += new System.EventHandler(this.FrmAdministrarPromociones_Load);
            this.tabControlPromociones.ResumeLayout(false);
            this.pcOrdenCompra.ResumeLayout(false);
            this.GrbDatosTicket.ResumeLayout(false);
            this.GrbDatosTicket.PerformLayout();
            this.GrbDatosPromocion.ResumeLayout(false);
            this.GrbDatosPromocion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudNumTickets)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbInformeCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPromociones)).EndInit();
            this.GrbConsulta.ResumeLayout(false);
            this.GrbConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPromociones;
        private System.Windows.Forms.TabPage pcOrdenCompra;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox TxtLinea5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtLinea1;
        private System.Windows.Forms.TextBox TxtLinea2;
        private System.Windows.Forms.TextBox TxtLinea3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtCabecera;
        private System.Windows.Forms.TextBox TxtLinea4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.GroupBox GrbDatosPromocion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbInformeCompra;
        private System.Windows.Forms.DataGridView DgvPromociones;
        private System.Windows.Forms.Button btnActivarDescativar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox GrbConsulta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox GrbDatosTicket;
        private System.Windows.Forms.TextBox TxtMontoFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtMontoInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudNumTickets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaVencimientoCupon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.ComboBox CmbTipoPromocion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtIdPromocion;
        private System.Windows.Forms.RadioButton rbtInactivos;
        private System.Windows.Forms.RadioButton rbtActivos;
    }
}