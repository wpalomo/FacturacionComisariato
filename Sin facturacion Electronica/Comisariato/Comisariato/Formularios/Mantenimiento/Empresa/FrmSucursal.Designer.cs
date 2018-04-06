namespace Comisariato.Formularios.Mantenimiento.Empresa
{
    partial class FrmSucursal
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
            this.tcSucursal = new System.Windows.Forms.TabControl();
            this.tpNuevaSucursal = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatosSucursal = new System.Windows.Forms.GroupBox();
            this.CmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUbicacionSucursal = new System.Windows.Forms.TextBox();
            this.txtTelefonoSucursal = new System.Windows.Forms.TextBox();
            this.txtJefeSucursal = new System.Windows.Forms.TextBox();
            this.txtRUCSucursal = new System.Windows.Forms.TextBox();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtDireccionSucursal = new System.Windows.Forms.TextBox();
            this.txtCodigoSucursal = new System.Windows.Forms.TextBox();
            this.ckbEstadoSucursal = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpConsultarModificarSucursal = new System.Windows.Forms.TabPage();
            this.DgvDatosSucursal = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deshabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rbtInactivos = new System.Windows.Forms.RadioButton();
            this.rbtActivos = new System.Windows.Forms.RadioButton();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tcSucursal.SuspendLayout();
            this.tpNuevaSucursal.SuspendLayout();
            this.gbDatosSucursal.SuspendLayout();
            this.tpConsultarModificarSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // tcSucursal
            // 
            this.tcSucursal.Controls.Add(this.tpNuevaSucursal);
            this.tcSucursal.Controls.Add(this.tpConsultarModificarSucursal);
            this.tcSucursal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcSucursal.Location = new System.Drawing.Point(14, 10);
            this.tcSucursal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tcSucursal.Name = "tcSucursal";
            this.tcSucursal.SelectedIndex = 0;
            this.tcSucursal.Size = new System.Drawing.Size(679, 409);
            this.tcSucursal.TabIndex = 0;
            // 
            // tpNuevaSucursal
            // 
            this.tpNuevaSucursal.BackColor = System.Drawing.Color.Bisque;
            this.tpNuevaSucursal.Controls.Add(this.btnLimpiar);
            this.tpNuevaSucursal.Controls.Add(this.btnGuardar);
            this.tpNuevaSucursal.Controls.Add(this.gbDatosSucursal);
            this.tpNuevaSucursal.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tpNuevaSucursal.Location = new System.Drawing.Point(4, 25);
            this.tpNuevaSucursal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpNuevaSucursal.Name = "tpNuevaSucursal";
            this.tpNuevaSucursal.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpNuevaSucursal.Size = new System.Drawing.Size(671, 380);
            this.tpNuevaSucursal.TabIndex = 0;
            this.tpNuevaSucursal.Text = "Nueva Sucursal";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.Teal;
            this.btnLimpiar.Image = global::Comisariato.Properties.Resources.LIMPIAR32X32;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(366, 327);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 43);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.Teal;
            this.btnGuardar.Image = global::Comisariato.Properties.Resources.GUARDAR32X32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(193, 327);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 43);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbDatosSucursal
            // 
            this.gbDatosSucursal.Controls.Add(this.CmbEmpresa);
            this.gbDatosSucursal.Controls.Add(this.label9);
            this.gbDatosSucursal.Controls.Add(this.txtCelular);
            this.gbDatosSucursal.Controls.Add(this.TxtEmail);
            this.gbDatosSucursal.Controls.Add(this.label5);
            this.gbDatosSucursal.Controls.Add(this.label4);
            this.gbDatosSucursal.Controls.Add(this.txtUbicacionSucursal);
            this.gbDatosSucursal.Controls.Add(this.txtTelefonoSucursal);
            this.gbDatosSucursal.Controls.Add(this.txtJefeSucursal);
            this.gbDatosSucursal.Controls.Add(this.txtRUCSucursal);
            this.gbDatosSucursal.Controls.Add(this.txtSucursal);
            this.gbDatosSucursal.Controls.Add(this.txtDireccionSucursal);
            this.gbDatosSucursal.Controls.Add(this.txtCodigoSucursal);
            this.gbDatosSucursal.Controls.Add(this.ckbEstadoSucursal);
            this.gbDatosSucursal.Controls.Add(this.label7);
            this.gbDatosSucursal.Controls.Add(this.label6);
            this.gbDatosSucursal.Controls.Add(this.label);
            this.gbDatosSucursal.Controls.Add(this.label10);
            this.gbDatosSucursal.Controls.Add(this.label3);
            this.gbDatosSucursal.Controls.Add(this.label2);
            this.gbDatosSucursal.Controls.Add(this.label1);
            this.gbDatosSucursal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosSucursal.ForeColor = System.Drawing.Color.Teal;
            this.gbDatosSucursal.Location = new System.Drawing.Point(24, 6);
            this.gbDatosSucursal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbDatosSucursal.Name = "gbDatosSucursal";
            this.gbDatosSucursal.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbDatosSucursal.Size = new System.Drawing.Size(625, 310);
            this.gbDatosSucursal.TabIndex = 15;
            this.gbDatosSucursal.TabStop = false;
            this.gbDatosSucursal.Text = "Datos de la Sucursal";
            // 
            // CmbEmpresa
            // 
            this.CmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmpresa.FormattingEnabled = true;
            this.CmbEmpresa.Location = new System.Drawing.Point(126, 25);
            this.CmbEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.CmbEmpresa.Name = "CmbEmpresa";
            this.CmbEmpresa.Size = new System.Drawing.Size(233, 24);
            this.CmbEmpresa.TabIndex = 1;
            this.CmbEmpresa.Enter += new System.EventHandler(this.CmbEmpresa_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(36, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Empresa:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCelular.Location = new System.Drawing.Point(373, 196);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCelular.MaxLength = 10;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(132, 22);
            this.txtCelular.TabIndex = 8;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoSucursal_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtEmail.Location = new System.Drawing.Point(127, 196);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(172, 22);
            this.TxtEmail.TabIndex = 7;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(307, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(36, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email:";
            // 
            // txtUbicacionSucursal
            // 
            this.txtUbicacionSucursal.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtUbicacionSucursal.Location = new System.Drawing.Point(127, 230);
            this.txtUbicacionSucursal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUbicacionSucursal.Name = "txtUbicacionSucursal";
            this.txtUbicacionSucursal.Size = new System.Drawing.Size(378, 22);
            this.txtUbicacionSucursal.TabIndex = 8;
            this.txtUbicacionSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUbicacionSucursal_KeyPress);
            // 
            // txtTelefonoSucursal
            // 
            this.txtTelefonoSucursal.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtTelefonoSucursal.Location = new System.Drawing.Point(373, 128);
            this.txtTelefonoSucursal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTelefonoSucursal.MaxLength = 10;
            this.txtTelefonoSucursal.Name = "txtTelefonoSucursal";
            this.txtTelefonoSucursal.Size = new System.Drawing.Size(132, 22);
            this.txtTelefonoSucursal.TabIndex = 5;
            this.txtTelefonoSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoSucursal_KeyPress);
            // 
            // txtJefeSucursal
            // 
            this.txtJefeSucursal.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtJefeSucursal.Location = new System.Drawing.Point(127, 162);
            this.txtJefeSucursal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtJefeSucursal.Name = "txtJefeSucursal";
            this.txtJefeSucursal.Size = new System.Drawing.Size(378, 22);
            this.txtJefeSucursal.TabIndex = 6;
            this.txtJefeSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJefeSucursal_KeyPress);
            // 
            // txtRUCSucursal
            // 
            this.txtRUCSucursal.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtRUCSucursal.Location = new System.Drawing.Point(127, 128);
            this.txtRUCSucursal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRUCSucursal.MaxLength = 13;
            this.txtRUCSucursal.Name = "txtRUCSucursal";
            this.txtRUCSucursal.Size = new System.Drawing.Size(172, 22);
            this.txtRUCSucursal.TabIndex = 4;
            this.txtRUCSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoSucursal_KeyPress);
            this.txtRUCSucursal.Leave += new System.EventHandler(this.txtRUCSucursal_Leave);
            // 
            // txtSucursal
            // 
            this.txtSucursal.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtSucursal.Location = new System.Drawing.Point(127, 94);
            this.txtSucursal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(277, 22);
            this.txtSucursal.TabIndex = 3;
            this.txtSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSucursal_KeyPress);
            // 
            // txtDireccionSucursal
            // 
            this.txtDireccionSucursal.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtDireccionSucursal.Location = new System.Drawing.Point(127, 264);
            this.txtDireccionSucursal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDireccionSucursal.Name = "txtDireccionSucursal";
            this.txtDireccionSucursal.Size = new System.Drawing.Size(378, 22);
            this.txtDireccionSucursal.TabIndex = 10;
            this.txtDireccionSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUbicacionSucursal_KeyPress);
            // 
            // txtCodigoSucursal
            // 
            this.txtCodigoSucursal.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCodigoSucursal.Location = new System.Drawing.Point(127, 60);
            this.txtCodigoSucursal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCodigoSucursal.Name = "txtCodigoSucursal";
            this.txtCodigoSucursal.ReadOnly = true;
            this.txtCodigoSucursal.Size = new System.Drawing.Size(58, 22);
            this.txtCodigoSucursal.TabIndex = 2;
            this.txtCodigoSucursal.Text = "0";
            this.txtCodigoSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoSucursal_KeyPress);
            // 
            // ckbEstadoSucursal
            // 
            this.ckbEstadoSucursal.AutoSize = true;
            this.ckbEstadoSucursal.Checked = true;
            this.ckbEstadoSucursal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbEstadoSucursal.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ckbEstadoSucursal.Location = new System.Drawing.Point(437, 95);
            this.ckbEstadoSucursal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckbEstadoSucursal.Name = "ckbEstadoSucursal";
            this.ckbEstadoSucursal.Size = new System.Drawing.Size(68, 20);
            this.ckbEstadoSucursal.TabIndex = 12;
            this.ckbEstadoSucursal.Text = "Estado";
            this.ckbEstadoSucursal.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.Location = new System.Drawing.Point(36, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ubicación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(307, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Teléfono:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label.Location = new System.Drawing.Point(36, 233);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 16);
            this.label.TabIndex = 4;
            this.label.Text = "Dirección:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label10.Location = new System.Drawing.Point(36, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Jefe Sucursal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(36, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(36, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sucursal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(36, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // tpConsultarModificarSucursal
            // 
            this.tpConsultarModificarSucursal.BackColor = System.Drawing.Color.Bisque;
            this.tpConsultarModificarSucursal.Controls.Add(this.DgvDatosSucursal);
            this.tpConsultarModificarSucursal.Controls.Add(this.rbtInactivos);
            this.tpConsultarModificarSucursal.Controls.Add(this.rbtActivos);
            this.tpConsultarModificarSucursal.Controls.Add(this.TxtBuscar);
            this.tpConsultarModificarSucursal.Controls.Add(this.label8);
            this.tpConsultarModificarSucursal.Location = new System.Drawing.Point(4, 25);
            this.tpConsultarModificarSucursal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpConsultarModificarSucursal.Name = "tpConsultarModificarSucursal";
            this.tpConsultarModificarSucursal.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpConsultarModificarSucursal.Size = new System.Drawing.Size(671, 380);
            this.tpConsultarModificarSucursal.TabIndex = 1;
            this.tpConsultarModificarSucursal.Text = "Consultar - Modificar Sucursal";
            // 
            // DgvDatosSucursal
            // 
            this.DgvDatosSucursal.AllowUserToAddRows = false;
            this.DgvDatosSucursal.AllowUserToDeleteRows = false;
            this.DgvDatosSucursal.AllowUserToOrderColumns = true;
            this.DgvDatosSucursal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDatosSucursal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosSucursal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDatosSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatosSucursal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Deshabilitar});
            this.DgvDatosSucursal.Location = new System.Drawing.Point(5, 91);
            this.DgvDatosSucursal.Name = "DgvDatosSucursal";
            this.DgvDatosSucursal.ReadOnly = true;
            this.DgvDatosSucursal.Size = new System.Drawing.Size(661, 282);
            this.DgvDatosSucursal.TabIndex = 1;
            this.DgvDatosSucursal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatosSucursal_CellClick);
            this.DgvDatosSucursal.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvDatosSucursal_CellPainting);
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
            // rbtInactivos
            // 
            this.rbtInactivos.AutoSize = true;
            this.rbtInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtInactivos.ForeColor = System.Drawing.Color.Teal;
            this.rbtInactivos.Location = new System.Drawing.Point(338, 57);
            this.rbtInactivos.Name = "rbtInactivos";
            this.rbtInactivos.Size = new System.Drawing.Size(79, 20);
            this.rbtInactivos.TabIndex = 13;
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
            this.rbtActivos.Location = new System.Drawing.Point(250, 57);
            this.rbtActivos.Name = "rbtActivos";
            this.rbtActivos.Size = new System.Drawing.Size(70, 20);
            this.rbtActivos.TabIndex = 12;
            this.rbtActivos.TabStop = true;
            this.rbtActivos.Text = "Activos";
            this.rbtActivos.UseVisualStyleBackColor = true;
            this.rbtActivos.CheckedChanged += new System.EventHandler(this.rbtInactivos_CheckedChanged);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtBuscar.Location = new System.Drawing.Point(184, 21);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(372, 22);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(96, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Consultar:";
            // 
            // FrmSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(704, 431);
            this.Controls.Add(this.tcSucursal);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 470);
            this.MinimumSize = new System.Drawing.Size(710, 450);
            this.Name = "FrmSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Sucursal";
            this.Load += new System.EventHandler(this.FrmSucursal_Load);
            this.tcSucursal.ResumeLayout(false);
            this.tpNuevaSucursal.ResumeLayout(false);
            this.gbDatosSucursal.ResumeLayout(false);
            this.gbDatosSucursal.PerformLayout();
            this.tpConsultarModificarSucursal.ResumeLayout(false);
            this.tpConsultarModificarSucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosSucursal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSucursal;
        private System.Windows.Forms.TabPage tpNuevaSucursal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpConsultarModificarSucursal;
        private System.Windows.Forms.TextBox txtUbicacionSucursal;
        private System.Windows.Forms.TextBox txtTelefonoSucursal;
        private System.Windows.Forms.TextBox txtJefeSucursal;
        private System.Windows.Forms.TextBox txtRUCSucursal;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtDireccionSucursal;
        private System.Windows.Forms.TextBox txtCodigoSucursal;
        private System.Windows.Forms.CheckBox ckbEstadoSucursal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox gbDatosSucursal;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbEmpresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtInactivos;
        private System.Windows.Forms.RadioButton rbtActivos;
        private System.Windows.Forms.DataGridView DgvDatosSucursal;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Deshabilitar;
    }
}