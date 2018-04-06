namespace Comisariato.Formularios.Mantenimiento
{
    partial class FrmCajasTalonario
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
            this.tcCajaTalonario = new System.Windows.Forms.TabControl();
            this.tpNuevaCajaTalonario = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatosGeneralesCaja = new System.Windows.Forms.GroupBox();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEstacionCaja = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaCaducidadCaja = new System.Windows.Forms.DateTimePicker();
            this.txtAutorizacionCaja = new System.Windows.Forms.TextBox();
            this.txtDocumentoActualCaja = new System.Windows.Forms.TextBox();
            this.txtDocumentoFinalCaja = new System.Windows.Forms.TextBox();
            this.txtDocumentoInicialCaja = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSerie2Caja = new System.Windows.Forms.TextBox();
            this.txtSerie1Caja = new System.Windows.Forms.TextBox();
            this.cbTipoDocumentoCaja = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbUbicacionCaja = new System.Windows.Forms.GroupBox();
            this.cbBodegaCaja = new System.Windows.Forms.ComboBox();
            this.cbSucursalCaja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbActivoCaja = new System.Windows.Forms.CheckBox();
            this.tpConsultarModificarDeshabilitarCaja = new System.Windows.Forms.TabPage();
            this.rbtInactivos = new System.Windows.Forms.RadioButton();
            this.rbtActivos = new System.Windows.Forms.RadioButton();
            this.dgvDatosCaja = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deshabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtConsultarCaja = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tcCajaTalonario.SuspendLayout();
            this.tpNuevaCajaTalonario.SuspendLayout();
            this.gbDatosGeneralesCaja.SuspendLayout();
            this.gbUbicacionCaja.SuspendLayout();
            this.tpConsultarModificarDeshabilitarCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCajaTalonario
            // 
            this.tcCajaTalonario.Controls.Add(this.tpNuevaCajaTalonario);
            this.tcCajaTalonario.Controls.Add(this.tpConsultarModificarDeshabilitarCaja);
            this.tcCajaTalonario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcCajaTalonario.Location = new System.Drawing.Point(17, 11);
            this.tcCajaTalonario.Name = "tcCajaTalonario";
            this.tcCajaTalonario.SelectedIndex = 0;
            this.tcCajaTalonario.Size = new System.Drawing.Size(1074, 395);
            this.tcCajaTalonario.TabIndex = 0;
            // 
            // tpNuevaCajaTalonario
            // 
            this.tpNuevaCajaTalonario.BackColor = System.Drawing.Color.Bisque;
            this.tpNuevaCajaTalonario.Controls.Add(this.btnLimpiar);
            this.tpNuevaCajaTalonario.Controls.Add(this.btnGuardar);
            this.tpNuevaCajaTalonario.Controls.Add(this.gbDatosGeneralesCaja);
            this.tpNuevaCajaTalonario.Controls.Add(this.gbUbicacionCaja);
            this.tpNuevaCajaTalonario.Controls.Add(this.ckbActivoCaja);
            this.tpNuevaCajaTalonario.ForeColor = System.Drawing.Color.Teal;
            this.tpNuevaCajaTalonario.Location = new System.Drawing.Point(4, 25);
            this.tpNuevaCajaTalonario.Name = "tpNuevaCajaTalonario";
            this.tpNuevaCajaTalonario.Padding = new System.Windows.Forms.Padding(3);
            this.tpNuevaCajaTalonario.Size = new System.Drawing.Size(1066, 366);
            this.tpNuevaCajaTalonario.TabIndex = 0;
            this.tpNuevaCajaTalonario.Text = "Nueva Caja";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnLimpiar.Image = global::Comisariato.Properties.Resources.limpiar;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(544, 272);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 72);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiarProveedor_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnGuardar.Image = global::Comisariato.Properties.Resources.guardar11;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(395, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 72);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // gbDatosGeneralesCaja
            // 
            this.gbDatosGeneralesCaja.Controls.Add(this.TxtIP);
            this.gbDatosGeneralesCaja.Controls.Add(this.label13);
            this.gbDatosGeneralesCaja.Controls.Add(this.txtEstacionCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.label11);
            this.gbDatosGeneralesCaja.Controls.Add(this.dtpFechaCaducidadCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.txtAutorizacionCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.txtDocumentoActualCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.txtDocumentoFinalCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.txtDocumentoInicialCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.label10);
            this.gbDatosGeneralesCaja.Controls.Add(this.txtSerie2Caja);
            this.gbDatosGeneralesCaja.Controls.Add(this.txtSerie1Caja);
            this.gbDatosGeneralesCaja.Controls.Add(this.cbTipoDocumentoCaja);
            this.gbDatosGeneralesCaja.Controls.Add(this.label9);
            this.gbDatosGeneralesCaja.Controls.Add(this.label8);
            this.gbDatosGeneralesCaja.Controls.Add(this.label7);
            this.gbDatosGeneralesCaja.Controls.Add(this.label6);
            this.gbDatosGeneralesCaja.Controls.Add(this.label5);
            this.gbDatosGeneralesCaja.Controls.Add(this.label4);
            this.gbDatosGeneralesCaja.Controls.Add(this.label3);
            this.gbDatosGeneralesCaja.ForeColor = System.Drawing.Color.Teal;
            this.gbDatosGeneralesCaja.Location = new System.Drawing.Point(6, 100);
            this.gbDatosGeneralesCaja.Name = "gbDatosGeneralesCaja";
            this.gbDatosGeneralesCaja.Size = new System.Drawing.Size(1042, 166);
            this.gbDatosGeneralesCaja.TabIndex = 1;
            this.gbDatosGeneralesCaja.TabStop = false;
            this.gbDatosGeneralesCaja.Text = "Datos Generales";
            // 
            // TxtIP
            // 
            this.TxtIP.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtIP.Location = new System.Drawing.Point(863, 99);
            this.TxtIP.MaxLength = 15;
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(166, 22);
            this.TxtIP.TabIndex = 20;
            this.TxtIP.TextChanged += new System.EventHandler(this.TxtIP_TextChanged);
            this.TxtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIP_KeyPress);
            this.TxtIP.Leave += new System.EventHandler(this.TxtIP_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label13.Location = new System.Drawing.Point(705, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "IP Estación:";
            // 
            // txtEstacionCaja
            // 
            this.txtEstacionCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtEstacionCaja.Location = new System.Drawing.Point(863, 74);
            this.txtEstacionCaja.Name = "txtEstacionCaja";
            this.txtEstacionCaja.Size = new System.Drawing.Size(166, 22);
            this.txtEstacionCaja.TabIndex = 18;
            this.txtEstacionCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstacionCaja_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label11.Location = new System.Drawing.Point(705, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Estación:";
            // 
            // dtpFechaCaducidadCaja
            // 
            this.dtpFechaCaducidadCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dtpFechaCaducidadCaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCaducidadCaja.Location = new System.Drawing.Point(863, 46);
            this.dtpFechaCaducidadCaja.Name = "dtpFechaCaducidadCaja";
            this.dtpFechaCaducidadCaja.Size = new System.Drawing.Size(166, 22);
            this.dtpFechaCaducidadCaja.TabIndex = 15;
            // 
            // txtAutorizacionCaja
            // 
            this.txtAutorizacionCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtAutorizacionCaja.Location = new System.Drawing.Point(484, 99);
            this.txtAutorizacionCaja.Name = "txtAutorizacionCaja";
            this.txtAutorizacionCaja.Size = new System.Drawing.Size(204, 22);
            this.txtAutorizacionCaja.TabIndex = 14;
            this.txtAutorizacionCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumentoInicialCaja_KeyPress);
            // 
            // txtDocumentoActualCaja
            // 
            this.txtDocumentoActualCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtDocumentoActualCaja.Location = new System.Drawing.Point(172, 99);
            this.txtDocumentoActualCaja.MaxLength = 9;
            this.txtDocumentoActualCaja.Name = "txtDocumentoActualCaja";
            this.txtDocumentoActualCaja.Size = new System.Drawing.Size(190, 22);
            this.txtDocumentoActualCaja.TabIndex = 13;
            this.txtDocumentoActualCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumentoInicialCaja_KeyPress);
            this.txtDocumentoActualCaja.Leave += new System.EventHandler(this.txtDocumentoActualCaja_Leave);
            // 
            // txtDocumentoFinalCaja
            // 
            this.txtDocumentoFinalCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtDocumentoFinalCaja.Location = new System.Drawing.Point(484, 72);
            this.txtDocumentoFinalCaja.MaxLength = 9;
            this.txtDocumentoFinalCaja.Name = "txtDocumentoFinalCaja";
            this.txtDocumentoFinalCaja.Size = new System.Drawing.Size(204, 22);
            this.txtDocumentoFinalCaja.TabIndex = 12;
            this.txtDocumentoFinalCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumentoInicialCaja_KeyPress);
            this.txtDocumentoFinalCaja.Leave += new System.EventHandler(this.txtDocumentoFinalCaja_Leave);
            // 
            // txtDocumentoInicialCaja
            // 
            this.txtDocumentoInicialCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtDocumentoInicialCaja.Location = new System.Drawing.Point(172, 72);
            this.txtDocumentoInicialCaja.MaxLength = 9;
            this.txtDocumentoInicialCaja.Name = "txtDocumentoInicialCaja";
            this.txtDocumentoInicialCaja.Size = new System.Drawing.Size(190, 22);
            this.txtDocumentoInicialCaja.TabIndex = 11;
            this.txtDocumentoInicialCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumentoInicialCaja_KeyPress);
            this.txtDocumentoInicialCaja.Leave += new System.EventHandler(this.txtDocumentoInicialCaja_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label10.Location = new System.Drawing.Point(570, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "-";
            // 
            // txtSerie2Caja
            // 
            this.txtSerie2Caja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtSerie2Caja.Location = new System.Drawing.Point(588, 46);
            this.txtSerie2Caja.MaxLength = 3;
            this.txtSerie2Caja.Name = "txtSerie2Caja";
            this.txtSerie2Caja.Size = new System.Drawing.Size(100, 22);
            this.txtSerie2Caja.TabIndex = 9;
            this.txtSerie2Caja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumentoInicialCaja_KeyPress);
            this.txtSerie2Caja.Leave += new System.EventHandler(this.txtSerie2Caja_Leave);
            // 
            // txtSerie1Caja
            // 
            this.txtSerie1Caja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtSerie1Caja.Location = new System.Drawing.Point(484, 46);
            this.txtSerie1Caja.MaxLength = 3;
            this.txtSerie1Caja.Name = "txtSerie1Caja";
            this.txtSerie1Caja.Size = new System.Drawing.Size(82, 22);
            this.txtSerie1Caja.TabIndex = 8;
            this.txtSerie1Caja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumentoInicialCaja_KeyPress);
            this.txtSerie1Caja.Leave += new System.EventHandler(this.txtSerie1Caja_Leave);
            // 
            // cbTipoDocumentoCaja
            // 
            this.cbTipoDocumentoCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDocumentoCaja.DropDownWidth = 100;
            this.cbTipoDocumentoCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbTipoDocumentoCaja.FormattingEnabled = true;
            this.cbTipoDocumentoCaja.Location = new System.Drawing.Point(172, 45);
            this.cbTipoDocumentoCaja.Name = "cbTipoDocumentoCaja";
            this.cbTipoDocumentoCaja.Size = new System.Drawing.Size(190, 24);
            this.cbTipoDocumentoCaja.TabIndex = 7;
            this.cbTipoDocumentoCaja.Enter += new System.EventHandler(this.cbSucursalCaja_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label9.Location = new System.Drawing.Point(368, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Autorización:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.Location = new System.Drawing.Point(368, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Documento Final:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.Location = new System.Drawing.Point(705, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha de Caducidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(14, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Documento Inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(14, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Documento Actual:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(368, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Serie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(14, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de Documento:";
            // 
            // gbUbicacionCaja
            // 
            this.gbUbicacionCaja.Controls.Add(this.cbBodegaCaja);
            this.gbUbicacionCaja.Controls.Add(this.cbSucursalCaja);
            this.gbUbicacionCaja.Controls.Add(this.label2);
            this.gbUbicacionCaja.Controls.Add(this.label1);
            this.gbUbicacionCaja.ForeColor = System.Drawing.Color.Teal;
            this.gbUbicacionCaja.Location = new System.Drawing.Point(318, 9);
            this.gbUbicacionCaja.Name = "gbUbicacionCaja";
            this.gbUbicacionCaja.Size = new System.Drawing.Size(431, 88);
            this.gbUbicacionCaja.TabIndex = 0;
            this.gbUbicacionCaja.TabStop = false;
            this.gbUbicacionCaja.Text = "Ubicación de la Caja";
            // 
            // cbBodegaCaja
            // 
            this.cbBodegaCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBodegaCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbBodegaCaja.FormattingEnabled = true;
            this.cbBodegaCaja.Location = new System.Drawing.Point(83, 53);
            this.cbBodegaCaja.Name = "cbBodegaCaja";
            this.cbBodegaCaja.Size = new System.Drawing.Size(333, 24);
            this.cbBodegaCaja.TabIndex = 3;
            this.cbBodegaCaja.Enter += new System.EventHandler(this.cbSucursalCaja_Enter);
            // 
            // cbSucursalCaja
            // 
            this.cbSucursalCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucursalCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbSucursalCaja.FormattingEnabled = true;
            this.cbSucursalCaja.Location = new System.Drawing.Point(83, 21);
            this.cbSucursalCaja.Name = "cbSucursalCaja";
            this.cbSucursalCaja.Size = new System.Drawing.Size(333, 24);
            this.cbSucursalCaja.TabIndex = 2;
            this.cbSucursalCaja.Enter += new System.EventHandler(this.cbSucursalCaja_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bodega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursal:";
            // 
            // ckbActivoCaja
            // 
            this.ckbActivoCaja.AutoSize = true;
            this.ckbActivoCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ckbActivoCaja.Location = new System.Drawing.Point(986, 9);
            this.ckbActivoCaja.Name = "ckbActivoCaja";
            this.ckbActivoCaja.Size = new System.Drawing.Size(62, 20);
            this.ckbActivoCaja.TabIndex = 16;
            this.ckbActivoCaja.Text = "Activo";
            this.ckbActivoCaja.UseVisualStyleBackColor = true;
            // 
            // tpConsultarModificarDeshabilitarCaja
            // 
            this.tpConsultarModificarDeshabilitarCaja.BackColor = System.Drawing.Color.Bisque;
            this.tpConsultarModificarDeshabilitarCaja.Controls.Add(this.rbtInactivos);
            this.tpConsultarModificarDeshabilitarCaja.Controls.Add(this.rbtActivos);
            this.tpConsultarModificarDeshabilitarCaja.Controls.Add(this.dgvDatosCaja);
            this.tpConsultarModificarDeshabilitarCaja.Controls.Add(this.txtConsultarCaja);
            this.tpConsultarModificarDeshabilitarCaja.Controls.Add(this.label12);
            this.tpConsultarModificarDeshabilitarCaja.Location = new System.Drawing.Point(4, 25);
            this.tpConsultarModificarDeshabilitarCaja.Name = "tpConsultarModificarDeshabilitarCaja";
            this.tpConsultarModificarDeshabilitarCaja.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsultarModificarDeshabilitarCaja.Size = new System.Drawing.Size(1066, 366);
            this.tpConsultarModificarDeshabilitarCaja.TabIndex = 1;
            this.tpConsultarModificarDeshabilitarCaja.Text = "Consultar - Modificar Caja";
            // 
            // rbtInactivos
            // 
            this.rbtInactivos.AutoSize = true;
            this.rbtInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtInactivos.ForeColor = System.Drawing.Color.Teal;
            this.rbtInactivos.Location = new System.Drawing.Point(385, 54);
            this.rbtInactivos.Name = "rbtInactivos";
            this.rbtInactivos.Size = new System.Drawing.Size(79, 20);
            this.rbtInactivos.TabIndex = 17;
            this.rbtInactivos.Text = "Inactivos";
            this.rbtInactivos.UseVisualStyleBackColor = true;
            this.rbtInactivos.CheckedChanged += new System.EventHandler(this.rbtInactivos_CheckedChanged);
            // 
            // rbtActivos
            // 
            this.rbtActivos.AutoSize = true;
            this.rbtActivos.Checked = true;
            this.rbtActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtActivos.ForeColor = System.Drawing.Color.Teal;
            this.rbtActivos.Location = new System.Drawing.Point(297, 54);
            this.rbtActivos.Name = "rbtActivos";
            this.rbtActivos.Size = new System.Drawing.Size(70, 20);
            this.rbtActivos.TabIndex = 16;
            this.rbtActivos.TabStop = true;
            this.rbtActivos.Text = "Activos";
            this.rbtActivos.UseVisualStyleBackColor = true;
            this.rbtActivos.CheckedChanged += new System.EventHandler(this.rbtInactivos_CheckedChanged);
            // 
            // dgvDatosCaja
            // 
            this.dgvDatosCaja.AllowUserToAddRows = false;
            this.dgvDatosCaja.AllowUserToDeleteRows = false;
            this.dgvDatosCaja.AllowUserToOrderColumns = true;
            this.dgvDatosCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosCaja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Deshabilitar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosCaja.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosCaja.Location = new System.Drawing.Point(19, 77);
            this.dgvDatosCaja.Name = "dgvDatosCaja";
            this.dgvDatosCaja.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosCaja.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosCaja.Size = new System.Drawing.Size(1025, 274);
            this.dgvDatosCaja.TabIndex = 15;
            this.dgvDatosCaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosCaja_CellClick);
            this.dgvDatosCaja.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDatosCaja_CellPainting);
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Deshabilitar
            // 
            this.Deshabilitar.HeaderText = "";
            this.Deshabilitar.Name = "Deshabilitar";
            this.Deshabilitar.ReadOnly = true;
            // 
            // txtConsultarCaja
            // 
            this.txtConsultarCaja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtConsultarCaja.Location = new System.Drawing.Point(180, 23);
            this.txtConsultarCaja.Name = "txtConsultarCaja";
            this.txtConsultarCaja.Size = new System.Drawing.Size(444, 22);
            this.txtConsultarCaja.TabIndex = 1;
            this.txtConsultarCaja.TextChanged += new System.EventHandler(this.txtConsultarCaja_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(93, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Consultar:";
            // 
            // FrmCajasTalonario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1108, 423);
            this.Controls.Add(this.tcCajaTalonario);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.MaximizeBox = false;
            this.Name = "FrmCajasTalonario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Cajas/Talonarios";
            this.Load += new System.EventHandler(this.FrmCajasTalonario_Load);
            this.tcCajaTalonario.ResumeLayout(false);
            this.tpNuevaCajaTalonario.ResumeLayout(false);
            this.tpNuevaCajaTalonario.PerformLayout();
            this.gbDatosGeneralesCaja.ResumeLayout(false);
            this.gbDatosGeneralesCaja.PerformLayout();
            this.gbUbicacionCaja.ResumeLayout(false);
            this.gbUbicacionCaja.PerformLayout();
            this.tpConsultarModificarDeshabilitarCaja.ResumeLayout(false);
            this.tpConsultarModificarDeshabilitarCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCajaTalonario;
        private System.Windows.Forms.TabPage tpNuevaCajaTalonario;
        private System.Windows.Forms.GroupBox gbDatosGeneralesCaja;
        private System.Windows.Forms.TextBox txtDocumentoFinalCaja;
        private System.Windows.Forms.TextBox txtDocumentoInicialCaja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSerie2Caja;
        private System.Windows.Forms.TextBox txtSerie1Caja;
        private System.Windows.Forms.ComboBox cbTipoDocumentoCaja;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbUbicacionCaja;
        private System.Windows.Forms.ComboBox cbBodegaCaja;
        private System.Windows.Forms.ComboBox cbSucursalCaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpConsultarModificarDeshabilitarCaja;
        private System.Windows.Forms.TextBox txtEstacionCaja;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ckbActivoCaja;
        private System.Windows.Forms.DateTimePicker dtpFechaCaducidadCaja;
        private System.Windows.Forms.TextBox txtAutorizacionCaja;
        private System.Windows.Forms.TextBox txtDocumentoActualCaja;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtConsultarCaja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvDatosCaja;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.RadioButton rbtInactivos;
        private System.Windows.Forms.RadioButton rbtActivos;
        private System.Windows.Forms.DataGridViewButtonColumn Deshabilitar;
    }
}