namespace Comisariato.Formularios.Mantenimiento
{
    partial class FrmEmpleado
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
            this.tcEmpleado = new System.Windows.Forms.TabControl();
            this.tpNuevoEmpleado = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtCelular2 = new System.Windows.Forms.TextBox();
            this.TxtCelular1 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.NupDiscapacidad = new System.Windows.Forms.NumericUpDown();
            this.CkbDiscapacidad = new System.Windows.Forms.CheckBox();
            this.TxtSueldoExtra = new System.Windows.Forms.TextBox();
            this.TxtSueldoMensual = new System.Windows.Forms.TextBox();
            this.TxtMovimientoQuincenal = new System.Windows.Forms.TextBox();
            this.TxtLibretaMilitar = new System.Windows.Forms.TextBox();
            this.CmbGenero = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.CmbTipoSangre = new System.Windows.Forms.ComboBox();
            this.CmbTipoLicencia = new System.Windows.Forms.ComboBox();
            this.CmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbParroquia = new System.Windows.Forms.ComboBox();
            this.CmbCanton = new System.Windows.Forms.ComboBox();
            this.CmbProvincia = new System.Windows.Forms.ComboBox();
            this.CmbPais = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.PictureFoto = new System.Windows.Forms.PictureBox();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtIdentidad = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpConsultarModificarEmpleado = new System.Windows.Forms.TabPage();
            this.BtnExportarExcel = new System.Windows.Forms.Button();
            this.rbtInactivosEmpleado = new System.Windows.Forms.RadioButton();
            this.rbtActivosEmpleado = new System.Windows.Forms.RadioButton();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.DgvDatosEmpleado = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deshabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tcEmpleado.SuspendLayout();
            this.tpNuevoEmpleado.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupDiscapacidad)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFoto)).BeginInit();
            this.tpConsultarModificarEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // tcEmpleado
            // 
            this.tcEmpleado.Controls.Add(this.tpNuevoEmpleado);
            this.tcEmpleado.Controls.Add(this.tpConsultarModificarEmpleado);
            this.tcEmpleado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.tcEmpleado.HotTrack = true;
            this.tcEmpleado.Location = new System.Drawing.Point(12, 10);
            this.tcEmpleado.Multiline = true;
            this.tcEmpleado.Name = "tcEmpleado";
            this.tcEmpleado.SelectedIndex = 0;
            this.tcEmpleado.Size = new System.Drawing.Size(1065, 569);
            this.tcEmpleado.TabIndex = 1;
            // 
            // tpNuevoEmpleado
            // 
            this.tpNuevoEmpleado.BackColor = System.Drawing.Color.Bisque;
            this.tpNuevoEmpleado.Controls.Add(this.btnLimpiar);
            this.tpNuevoEmpleado.Controls.Add(this.btnGuardar);
            this.tpNuevoEmpleado.Controls.Add(this.tabControl1);
            this.tpNuevoEmpleado.Controls.Add(this.groupBox1);
            this.tpNuevoEmpleado.Location = new System.Drawing.Point(4, 25);
            this.tpNuevoEmpleado.Name = "tpNuevoEmpleado";
            this.tpNuevoEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.tpNuevoEmpleado.Size = new System.Drawing.Size(1057, 540);
            this.tpNuevoEmpleado.TabIndex = 0;
            this.tpNuevoEmpleado.Text = "Nuevo Empleado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.Teal;
            this.btnLimpiar.Image = global::Comisariato.Properties.Resources.LIMPIAR32X32;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(564, 478);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 47);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnGuardar.ForeColor = System.Drawing.Color.Teal;
            this.btnGuardar.Image = global::Comisariato.Properties.Resources.GUARDAR32X32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(424, 478);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 47);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(14, 218);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 253);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Bisque;
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.TxtCelular2);
            this.tabPage1.Controls.Add(this.TxtCelular1);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.NupDiscapacidad);
            this.tabPage1.Controls.Add(this.CkbDiscapacidad);
            this.tabPage1.Controls.Add(this.TxtSueldoExtra);
            this.tabPage1.Controls.Add(this.TxtSueldoMensual);
            this.tabPage1.Controls.Add(this.TxtMovimientoQuincenal);
            this.tabPage1.Controls.Add(this.TxtLibretaMilitar);
            this.tabPage1.Controls.Add(this.CmbGenero);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.TxtEmail);
            this.tabPage1.Controls.Add(this.CmbTipoSangre);
            this.tabPage1.Controls.Add(this.CmbTipoLicencia);
            this.tabPage1.Controls.Add(this.CmbEstadoCivil);
            this.tabPage1.Controls.Add(this.DtpFechaNacimiento);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Personales";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Teal;
            this.label22.Location = new System.Drawing.Point(744, 188);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 16);
            this.label22.TabIndex = 47;
            this.label22.Text = "Celular 2:";
            // 
            // TxtCelular2
            // 
            this.TxtCelular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular2.Location = new System.Drawing.Point(848, 185);
            this.TxtCelular2.Name = "TxtCelular2";
            this.TxtCelular2.Size = new System.Drawing.Size(166, 22);
            this.TxtCelular2.TabIndex = 20;
            this.TxtCelular2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdentidad_KeyPress);
            // 
            // TxtCelular1
            // 
            this.TxtCelular1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular1.Location = new System.Drawing.Point(848, 156);
            this.TxtCelular1.Name = "TxtCelular1";
            this.TxtCelular1.Size = new System.Drawing.Size(166, 22);
            this.TxtCelular1.TabIndex = 18;
            this.TxtCelular1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdentidad_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Teal;
            this.label23.Location = new System.Drawing.Point(744, 159);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 16);
            this.label23.TabIndex = 44;
            this.label23.Text = "Celular 1:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Teal;
            this.label21.Location = new System.Drawing.Point(744, 130);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 16);
            this.label21.TabIndex = 43;
            this.label21.Text = "Sueldo Extra:";
            // 
            // NupDiscapacidad
            // 
            this.NupDiscapacidad.Enabled = false;
            this.NupDiscapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NupDiscapacidad.Location = new System.Drawing.Point(532, 155);
            this.NupDiscapacidad.Name = "NupDiscapacidad";
            this.NupDiscapacidad.Size = new System.Drawing.Size(58, 22);
            this.NupDiscapacidad.TabIndex = 17;
            this.NupDiscapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NupDiscapacidad_KeyPress);
            // 
            // CkbDiscapacidad
            // 
            this.CkbDiscapacidad.AutoSize = true;
            this.CkbDiscapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbDiscapacidad.ForeColor = System.Drawing.Color.Teal;
            this.CkbDiscapacidad.Location = new System.Drawing.Point(392, 157);
            this.CkbDiscapacidad.Name = "CkbDiscapacidad";
            this.CkbDiscapacidad.Size = new System.Drawing.Size(112, 20);
            this.CkbDiscapacidad.TabIndex = 17;
            this.CkbDiscapacidad.Text = "Discapacidad";
            this.CkbDiscapacidad.UseVisualStyleBackColor = true;
            this.CkbDiscapacidad.CheckedChanged += new System.EventHandler(this.CkbDiscapacidad_CheckedChanged);
            // 
            // TxtSueldoExtra
            // 
            this.TxtSueldoExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSueldoExtra.Location = new System.Drawing.Point(848, 127);
            this.TxtSueldoExtra.Name = "TxtSueldoExtra";
            this.TxtSueldoExtra.Size = new System.Drawing.Size(166, 22);
            this.TxtSueldoExtra.TabIndex = 16;
            this.TxtSueldoExtra.Text = "0";
            this.TxtSueldoExtra.Click += new System.EventHandler(this.TxtSueldoExtra_Click);
            this.TxtSueldoExtra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSueldoExtra_KeyPress);
            // 
            // TxtSueldoMensual
            // 
            this.TxtSueldoMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSueldoMensual.Location = new System.Drawing.Point(848, 96);
            this.TxtSueldoMensual.Name = "TxtSueldoMensual";
            this.TxtSueldoMensual.Size = new System.Drawing.Size(166, 22);
            this.TxtSueldoMensual.TabIndex = 14;
            this.TxtSueldoMensual.Text = "0";
            this.TxtSueldoMensual.Click += new System.EventHandler(this.TxtSueldoMensual_Click);
            this.TxtSueldoMensual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSueldoMensual_KeyPress);
            // 
            // TxtMovimientoQuincenal
            // 
            this.TxtMovimientoQuincenal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMovimientoQuincenal.Location = new System.Drawing.Point(532, 185);
            this.TxtMovimientoQuincenal.Name = "TxtMovimientoQuincenal";
            this.TxtMovimientoQuincenal.Size = new System.Drawing.Size(206, 22);
            this.TxtMovimientoQuincenal.TabIndex = 19;
            this.TxtMovimientoQuincenal.Text = "0";
            this.TxtMovimientoQuincenal.Click += new System.EventHandler(this.TxtMovimientoQuincenal_Click);
            this.TxtMovimientoQuincenal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMovimientoQuincenal_KeyPress);
            // 
            // TxtLibretaMilitar
            // 
            this.TxtLibretaMilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibretaMilitar.Location = new System.Drawing.Point(532, 127);
            this.TxtLibretaMilitar.Name = "TxtLibretaMilitar";
            this.TxtLibretaMilitar.Size = new System.Drawing.Size(206, 22);
            this.TxtLibretaMilitar.TabIndex = 15;
            this.TxtLibretaMilitar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // CmbGenero
            // 
            this.CmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbGenero.FormattingEnabled = true;
            this.CmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CmbGenero.Location = new System.Drawing.Point(831, 36);
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(183, 24);
            this.CmbGenero.TabIndex = 10;
            this.CmbGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbGenero_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(381, 350);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 16);
            this.label19.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Teal;
            this.label18.Location = new System.Drawing.Point(744, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 16);
            this.label18.TabIndex = 34;
            this.label18.Text = "Sueldo Mensual:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Teal;
            this.label17.Location = new System.Drawing.Point(392, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 16);
            this.label17.TabIndex = 33;
            this.label17.Text = "# Libreta Militar:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Teal;
            this.label16.Location = new System.Drawing.Point(392, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "Movimiento Quincenal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(744, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Genero:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(81, 185);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(294, 22);
            this.TxtEmail.TabIndex = 21;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // CmbTipoSangre
            // 
            this.CmbTipoSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoSangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoSangre.FormattingEnabled = true;
            this.CmbTipoSangre.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.CmbTipoSangre.Location = new System.Drawing.Point(532, 96);
            this.CmbTipoSangre.Name = "CmbTipoSangre";
            this.CmbTipoSangre.Size = new System.Drawing.Size(206, 24);
            this.CmbTipoSangre.TabIndex = 13;
            this.CmbTipoSangre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbGenero_KeyPress);
            // 
            // CmbTipoLicencia
            // 
            this.CmbTipoLicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoLicencia.FormattingEnabled = true;
            this.CmbTipoLicencia.Items.AddRange(new object[] {
            "Sin Licencia",
            "Licencia Profesional",
            "Licencia No Profesional",
            "Licencia Especial"});
            this.CmbTipoLicencia.Location = new System.Drawing.Point(532, 66);
            this.CmbTipoLicencia.Name = "CmbTipoLicencia";
            this.CmbTipoLicencia.Size = new System.Drawing.Size(206, 24);
            this.CmbTipoLicencia.TabIndex = 11;
            this.CmbTipoLicencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbTipoLicencia_KeyPress);
            // 
            // CmbEstadoCivil
            // 
            this.CmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstadoCivil.FormattingEnabled = true;
            this.CmbEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "Union Libre",
            "Viudo"});
            this.CmbEstadoCivil.Location = new System.Drawing.Point(831, 65);
            this.CmbEstadoCivil.Name = "CmbEstadoCivil";
            this.CmbEstadoCivil.Size = new System.Drawing.Size(183, 24);
            this.CmbEstadoCivil.TabIndex = 12;
            this.CmbEstadoCivil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbGenero_KeyPress);
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(532, 37);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(206, 22);
            this.DtpFechaNacimiento.TabIndex = 9;
            this.DtpFechaNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpFechaNacimiento_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbParroquia);
            this.groupBox3.Controls.Add(this.CmbCanton);
            this.groupBox3.Controls.Add(this.CmbProvincia);
            this.groupBox3.Controls.Add(this.CmbPais);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Teal;
            this.groupBox3.Location = new System.Drawing.Point(20, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 168);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lugar de Nacimiento";
            // 
            // CmbParroquia
            // 
            this.CmbParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbParroquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbParroquia.FormattingEnabled = true;
            this.CmbParroquia.Location = new System.Drawing.Point(182, 108);
            this.CmbParroquia.Name = "CmbParroquia";
            this.CmbParroquia.Size = new System.Drawing.Size(159, 24);
            this.CmbParroquia.TabIndex = 26;
            // 
            // CmbCanton
            // 
            this.CmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCanton.FormattingEnabled = true;
            this.CmbCanton.Location = new System.Drawing.Point(13, 108);
            this.CmbCanton.Name = "CmbCanton";
            this.CmbCanton.Size = new System.Drawing.Size(159, 24);
            this.CmbCanton.TabIndex = 25;
            this.CmbCanton.SelectedIndexChanged += new System.EventHandler(this.CmbCanton_SelectedIndexChanged);
            // 
            // CmbProvincia
            // 
            this.CmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProvincia.FormattingEnabled = true;
            this.CmbProvincia.Location = new System.Drawing.Point(182, 55);
            this.CmbProvincia.Name = "CmbProvincia";
            this.CmbProvincia.Size = new System.Drawing.Size(159, 24);
            this.CmbProvincia.TabIndex = 24;
            this.CmbProvincia.SelectedIndexChanged += new System.EventHandler(this.CmbProvincia_SelectedIndexChanged);
            // 
            // CmbPais
            // 
            this.CmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPais.FormattingEnabled = true;
            this.CmbPais.Location = new System.Drawing.Point(13, 55);
            this.CmbPais.Name = "CmbPais";
            this.CmbPais.Size = new System.Drawing.Size(159, 24);
            this.CmbPais.TabIndex = 23;
            this.CmbPais.SelectedIndexChanged += new System.EventHandler(this.CmbPais_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(178, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Parroquia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cantón:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(178, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Provincia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "País:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(392, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Tipo de Sangre:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(392, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Fecha de Nacimiento:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(744, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Estado Civil:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(393, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Tipo de Licencia:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(20, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ckbActivo);
            this.groupBox1.Controls.Add(this.cmbTipoDocumento);
            this.groupBox1.Controls.Add(this.TxtApellidos);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.Controls.Add(this.TxtIdentidad);
            this.groupBox1.Controls.Add(this.TxtNombres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(20, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.PictureFoto);
            this.groupBox2.Location = new System.Drawing.Point(692, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 176);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(194, 95);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 48);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCancelar_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = global::Comisariato.Properties.Resources.buscar2;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(194, 37);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(107, 48);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.BtnBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnBuscar_KeyPress);
            // 
            // PictureFoto
            // 
            this.PictureFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureFoto.Image = global::Comisariato.Properties.Resources.contact;
            this.PictureFoto.Location = new System.Drawing.Point(27, 21);
            this.PictureFoto.Name = "PictureFoto";
            this.PictureFoto.Size = new System.Drawing.Size(140, 147);
            this.PictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureFoto.TabIndex = 0;
            this.PictureFoto.TabStop = false;
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Checked = true;
            this.ckbActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbActivo.ForeColor = System.Drawing.Color.Teal;
            this.ckbActivo.Location = new System.Drawing.Point(617, 26);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(64, 20);
            this.ckbActivo.TabIndex = 10;
            this.ckbActivo.Text = "Activo";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "Cedula",
            "RUC",
            "Pasaporte"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(127, 24);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(216, 24);
            this.cmbTipoDocumento.TabIndex = 1;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(423, 57);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(258, 22);
            this.TxtApellidos.TabIndex = 4;
            this.TxtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombres_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(127, 90);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(554, 99);
            this.TxtDireccion.TabIndex = 5;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // TxtIdentidad
            // 
            this.TxtIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentidad.Location = new System.Drawing.Point(423, 24);
            this.TxtIdentidad.Name = "TxtIdentidad";
            this.TxtIdentidad.Size = new System.Drawing.Size(151, 22);
            this.TxtIdentidad.TabIndex = 2;
            this.TxtIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdentidad_KeyPress);
            this.TxtIdentidad.Leave += new System.EventHandler(this.TxtIdentidad_Leave);
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(127, 57);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(216, 22);
            this.TxtNombres.TabIndex = 3;
            this.TxtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombres_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(349, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "N°:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(10, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(349, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Documento:";
            // 
            // tpConsultarModificarEmpleado
            // 
            this.tpConsultarModificarEmpleado.BackColor = System.Drawing.Color.Bisque;
            this.tpConsultarModificarEmpleado.Controls.Add(this.BtnExportarExcel);
            this.tpConsultarModificarEmpleado.Controls.Add(this.rbtInactivosEmpleado);
            this.tpConsultarModificarEmpleado.Controls.Add(this.rbtActivosEmpleado);
            this.tpConsultarModificarEmpleado.Controls.Add(this.TxtBuscar);
            this.tpConsultarModificarEmpleado.Controls.Add(this.label20);
            this.tpConsultarModificarEmpleado.Controls.Add(this.DgvDatosEmpleado);
            this.tpConsultarModificarEmpleado.Location = new System.Drawing.Point(4, 25);
            this.tpConsultarModificarEmpleado.Name = "tpConsultarModificarEmpleado";
            this.tpConsultarModificarEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsultarModificarEmpleado.Size = new System.Drawing.Size(1057, 540);
            this.tpConsultarModificarEmpleado.TabIndex = 1;
            this.tpConsultarModificarEmpleado.Text = "Consultar - Modificar Empleado";
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Image = global::Comisariato.Properties.Resources.Excel_2013_24px_1180012_easyicon_net;
            this.BtnExportarExcel.Location = new System.Drawing.Point(965, 24);
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.Size = new System.Drawing.Size(36, 29);
            this.BtnExportarExcel.TabIndex = 25;
            this.BtnExportarExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExportarExcel.UseVisualStyleBackColor = true;
            this.BtnExportarExcel.Click += new System.EventHandler(this.BtnExportarExcel_Click);
            // 
            // rbtInactivosEmpleado
            // 
            this.rbtInactivosEmpleado.AutoSize = true;
            this.rbtInactivosEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtInactivosEmpleado.ForeColor = System.Drawing.Color.Teal;
            this.rbtInactivosEmpleado.Location = new System.Drawing.Point(531, 63);
            this.rbtInactivosEmpleado.Name = "rbtInactivosEmpleado";
            this.rbtInactivosEmpleado.Size = new System.Drawing.Size(79, 20);
            this.rbtInactivosEmpleado.TabIndex = 11;
            this.rbtInactivosEmpleado.Text = "Inactivos";
            this.rbtInactivosEmpleado.UseVisualStyleBackColor = true;
            this.rbtInactivosEmpleado.CheckedChanged += new System.EventHandler(this.rbtActivosEmpleado_CheckedChanged);
            // 
            // rbtActivosEmpleado
            // 
            this.rbtActivosEmpleado.AutoSize = true;
            this.rbtActivosEmpleado.Checked = true;
            this.rbtActivosEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtActivosEmpleado.ForeColor = System.Drawing.Color.Teal;
            this.rbtActivosEmpleado.Location = new System.Drawing.Point(443, 63);
            this.rbtActivosEmpleado.Name = "rbtActivosEmpleado";
            this.rbtActivosEmpleado.Size = new System.Drawing.Size(70, 20);
            this.rbtActivosEmpleado.TabIndex = 10;
            this.rbtActivosEmpleado.TabStop = true;
            this.rbtActivosEmpleado.Text = "Activos";
            this.rbtActivosEmpleado.UseVisualStyleBackColor = true;
            this.rbtActivosEmpleado.CheckedChanged += new System.EventHandler(this.rbtActivosEmpleado_CheckedChanged);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(293, 27);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(543, 22);
            this.TxtBuscar.TabIndex = 2;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label20.ForeColor = System.Drawing.Color.Teal;
            this.label20.Location = new System.Drawing.Point(220, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 16);
            this.label20.TabIndex = 1;
            this.label20.Text = "Consultar:";
            // 
            // DgvDatosEmpleado
            // 
            this.DgvDatosEmpleado.AllowUserToAddRows = false;
            this.DgvDatosEmpleado.AllowUserToDeleteRows = false;
            this.DgvDatosEmpleado.AllowUserToOrderColumns = true;
            this.DgvDatosEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDatosEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDatosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatosEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Deshabilitar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatosEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDatosEmpleado.Location = new System.Drawing.Point(6, 100);
            this.DgvDatosEmpleado.Name = "DgvDatosEmpleado";
            this.DgvDatosEmpleado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            this.DgvDatosEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDatosEmpleado.Size = new System.Drawing.Size(995, 418);
            this.DgvDatosEmpleado.TabIndex = 0;
            this.DgvDatosEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatosEmpleado_CellClick);
            this.DgvDatosEmpleado.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvDatosEmpleado_CellPainting);
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
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1089, 589);
            this.Controls.Add(this.tcEmpleado);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1105, 627);
            this.MinimumSize = new System.Drawing.Size(1105, 627);
            this.Name = "FrmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Administrar Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.tcEmpleado.ResumeLayout(false);
            this.tpNuevoEmpleado.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupDiscapacidad)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureFoto)).EndInit();
            this.tpConsultarModificarEmpleado.ResumeLayout(false);
            this.tpConsultarModificarEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpNuevoEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpConsultarModificarEmpleado;
        private System.Windows.Forms.TabControl tcEmpleado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CmbParroquia;
        private System.Windows.Forms.ComboBox CmbCanton;
        private System.Windows.Forms.ComboBox CmbProvincia;
        private System.Windows.Forms.ComboBox CmbPais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.PictureBox PictureFoto;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtIdentidad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.ComboBox CmbTipoSangre;
        private System.Windows.Forms.ComboBox CmbTipoLicencia;
        private System.Windows.Forms.ComboBox CmbEstadoCivil;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.CheckBox CkbDiscapacidad;
        private System.Windows.Forms.TextBox TxtSueldoExtra;
        private System.Windows.Forms.TextBox TxtSueldoMensual;
        private System.Windows.Forms.TextBox TxtMovimientoQuincenal;
        private System.Windows.Forms.TextBox TxtLibretaMilitar;
        private System.Windows.Forms.ComboBox CmbGenero;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView DgvDatosEmpleado;
        private System.Windows.Forms.NumericUpDown NupDiscapacidad;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TxtCelular2;
        private System.Windows.Forms.TextBox TxtCelular1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RadioButton rbtInactivosEmpleado;
        private System.Windows.Forms.RadioButton rbtActivosEmpleado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Deshabilitar;
        private System.Windows.Forms.Button BtnExportarExcel;
    }
}