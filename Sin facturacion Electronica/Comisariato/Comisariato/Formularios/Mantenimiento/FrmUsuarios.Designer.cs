namespace Comisariato.Formularios
{
    partial class FrmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcUsuario = new System.Windows.Forms.TabControl();
            this.tpNuevoUsuario = new System.Windows.Forms.TabPage();
            this.btnLimpiarProveedor = new System.Windows.Forms.Button();
            this.gbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckMostrarContra = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbFacturaUsuario = new System.Windows.Forms.CheckBox();
            this.gbEmpresaConectarseProveedor = new System.Windows.Forms.GroupBox();
            this.CheckListBEmpresas = new System.Windows.Forms.CheckedListBox();
            this.TxtConfirmarContraUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cbPersonaUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.tpConsultarModificarUsuario = new System.Windows.Forms.TabPage();
            this.rbtInactivos = new System.Windows.Forms.RadioButton();
            this.rbtActivos = new System.Windows.Forms.RadioButton();
            this.dgvDatosUsuario = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deshabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtConsultarUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tcUsuario.SuspendLayout();
            this.tpNuevoUsuario.SuspendLayout();
            this.gbDatosUsuario.SuspendLayout();
            this.gbEmpresaConectarseProveedor.SuspendLayout();
            this.tpConsultarModificarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tcUsuario
            // 
            this.tcUsuario.Controls.Add(this.tpNuevoUsuario);
            this.tcUsuario.Controls.Add(this.tpConsultarModificarUsuario);
            this.tcUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcUsuario.Location = new System.Drawing.Point(10, 17);
            this.tcUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tcUsuario.Name = "tcUsuario";
            this.tcUsuario.SelectedIndex = 0;
            this.tcUsuario.Size = new System.Drawing.Size(626, 416);
            this.tcUsuario.TabIndex = 1;
            // 
            // tpNuevoUsuario
            // 
            this.tpNuevoUsuario.BackColor = System.Drawing.Color.Bisque;
            this.tpNuevoUsuario.Controls.Add(this.btnLimpiarProveedor);
            this.tpNuevoUsuario.Controls.Add(this.gbDatosUsuario);
            this.tpNuevoUsuario.Controls.Add(this.btnGuardarUsuario);
            this.tpNuevoUsuario.Location = new System.Drawing.Point(4, 25);
            this.tpNuevoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tpNuevoUsuario.Name = "tpNuevoUsuario";
            this.tpNuevoUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.tpNuevoUsuario.Size = new System.Drawing.Size(618, 387);
            this.tpNuevoUsuario.TabIndex = 0;
            this.tpNuevoUsuario.Text = "Nuevo Usuario";
            // 
            // btnLimpiarProveedor
            // 
            this.btnLimpiarProveedor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnLimpiarProveedor.Image = global::Comisariato.Properties.Resources.limpiar;
            this.btnLimpiarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarProveedor.Location = new System.Drawing.Point(362, 303);
            this.btnLimpiarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarProveedor.Name = "btnLimpiarProveedor";
            this.btnLimpiarProveedor.Size = new System.Drawing.Size(122, 69);
            this.btnLimpiarProveedor.TabIndex = 29;
            this.btnLimpiarProveedor.Text = "&Limpiar";
            this.btnLimpiarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarProveedor.UseVisualStyleBackColor = true;
            this.btnLimpiarProveedor.Click += new System.EventHandler(this.btnLimpiarProveedor_Click);
            // 
            // gbDatosUsuario
            // 
            this.gbDatosUsuario.Controls.Add(this.cbTipoUsuario);
            this.gbDatosUsuario.Controls.Add(this.label6);
            this.gbDatosUsuario.Controls.Add(this.ckMostrarContra);
            this.gbDatosUsuario.Controls.Add(this.label5);
            this.gbDatosUsuario.Controls.Add(this.ckbFacturaUsuario);
            this.gbDatosUsuario.Controls.Add(this.gbEmpresaConectarseProveedor);
            this.gbDatosUsuario.Controls.Add(this.TxtConfirmarContraUsuario);
            this.gbDatosUsuario.Controls.Add(this.txtContraseñaUsuario);
            this.gbDatosUsuario.Controls.Add(this.txtUsuario);
            this.gbDatosUsuario.Controls.Add(this.cbPersonaUsuario);
            this.gbDatosUsuario.Controls.Add(this.label3);
            this.gbDatosUsuario.Controls.Add(this.label2);
            this.gbDatosUsuario.Controls.Add(this.label1);
            this.gbDatosUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosUsuario.ForeColor = System.Drawing.Color.Teal;
            this.gbDatosUsuario.Location = new System.Drawing.Point(42, 6);
            this.gbDatosUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatosUsuario.Size = new System.Drawing.Size(560, 295);
            this.gbDatosUsuario.TabIndex = 0;
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Text = "Datos Usuario";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(114, 58);
            this.cbTipoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(173, 24);
            this.cbTipoUsuario.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(28, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo Usuario:";
            // 
            // ckMostrarContra
            // 
            this.ckMostrarContra.AutoSize = true;
            this.ckMostrarContra.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ckMostrarContra.Location = new System.Drawing.Point(529, 95);
            this.ckMostrarContra.Margin = new System.Windows.Forms.Padding(2);
            this.ckMostrarContra.Name = "ckMostrarContra";
            this.ckMostrarContra.Size = new System.Drawing.Size(15, 14);
            this.ckMostrarContra.TabIndex = 11;
            this.ckMostrarContra.UseVisualStyleBackColor = true;
            this.ckMostrarContra.CheckedChanged += new System.EventHandler(this.ckMostrarContra_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(253, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmar Contraseña:";
            // 
            // ckbFacturaUsuario
            // 
            this.ckbFacturaUsuario.AutoSize = true;
            this.ckbFacturaUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ckbFacturaUsuario.Location = new System.Drawing.Point(31, 124);
            this.ckbFacturaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.ckbFacturaUsuario.Name = "ckbFacturaUsuario";
            this.ckbFacturaUsuario.Size = new System.Drawing.Size(119, 20);
            this.ckbFacturaUsuario.TabIndex = 9;
            this.ckbFacturaUsuario.Text = "Usuario Factura";
            this.ckbFacturaUsuario.UseVisualStyleBackColor = true;
            // 
            // gbEmpresaConectarseProveedor
            // 
            this.gbEmpresaConectarseProveedor.Controls.Add(this.CheckListBEmpresas);
            this.gbEmpresaConectarseProveedor.ForeColor = System.Drawing.Color.Teal;
            this.gbEmpresaConectarseProveedor.Location = new System.Drawing.Point(31, 156);
            this.gbEmpresaConectarseProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.gbEmpresaConectarseProveedor.Name = "gbEmpresaConectarseProveedor";
            this.gbEmpresaConectarseProveedor.Padding = new System.Windows.Forms.Padding(2);
            this.gbEmpresaConectarseProveedor.Size = new System.Drawing.Size(497, 128);
            this.gbEmpresaConectarseProveedor.TabIndex = 8;
            this.gbEmpresaConectarseProveedor.TabStop = false;
            this.gbEmpresaConectarseProveedor.Text = "Empresa a conectarse";
            // 
            // CheckListBEmpresas
            // 
            this.CheckListBEmpresas.CheckOnClick = true;
            this.CheckListBEmpresas.Font = new System.Drawing.Font("Arial", 9.75F);
            this.CheckListBEmpresas.FormattingEnabled = true;
            this.CheckListBEmpresas.Items.AddRange(new object[] {
            "Empresa 1"});
            this.CheckListBEmpresas.Location = new System.Drawing.Point(97, 27);
            this.CheckListBEmpresas.Margin = new System.Windows.Forms.Padding(2);
            this.CheckListBEmpresas.Name = "CheckListBEmpresas";
            this.CheckListBEmpresas.Size = new System.Drawing.Size(302, 89);
            this.CheckListBEmpresas.TabIndex = 7;
            this.CheckListBEmpresas.Enter += new System.EventHandler(this.CheckListBEmpresas_Enter);
            // 
            // TxtConfirmarContraUsuario
            // 
            this.TxtConfirmarContraUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtConfirmarContraUsuario.Location = new System.Drawing.Point(395, 123);
            this.TxtConfirmarContraUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtConfirmarContraUsuario.Name = "TxtConfirmarContraUsuario";
            this.TxtConfirmarContraUsuario.Size = new System.Drawing.Size(133, 22);
            this.TxtConfirmarContraUsuario.TabIndex = 6;
            this.TxtConfirmarContraUsuario.UseSystemPasswordChar = true;
            // 
            // txtContraseñaUsuario
            // 
            this.txtContraseñaUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtContraseñaUsuario.Location = new System.Drawing.Point(395, 90);
            this.txtContraseñaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            this.txtContraseñaUsuario.Size = new System.Drawing.Size(133, 22);
            this.txtContraseñaUsuario.TabIndex = 6;
            this.txtContraseñaUsuario.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtUsuario.Location = new System.Drawing.Point(114, 90);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(133, 22);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // cbPersonaUsuario
            // 
            this.cbPersonaUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonaUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbPersonaUsuario.FormattingEnabled = true;
            this.cbPersonaUsuario.Location = new System.Drawing.Point(114, 23);
            this.cbPersonaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbPersonaUsuario.Name = "cbPersonaUsuario";
            this.cbPersonaUsuario.Size = new System.Drawing.Size(426, 24);
            this.cbPersonaUsuario.TabIndex = 4;
            this.cbPersonaUsuario.Enter += new System.EventHandler(this.cbPersonaUsuario_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(253, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(28, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presona:";
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnGuardarUsuario.Image = global::Comisariato.Properties.Resources.guardar11;
            this.btnGuardarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(196, 303);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(133, 69);
            this.btnGuardarUsuario.TabIndex = 28;
            this.btnGuardarUsuario.Text = "&Guardar";
            this.btnGuardarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // tpConsultarModificarUsuario
            // 
            this.tpConsultarModificarUsuario.BackColor = System.Drawing.Color.Bisque;
            this.tpConsultarModificarUsuario.Controls.Add(this.rbtInactivos);
            this.tpConsultarModificarUsuario.Controls.Add(this.rbtActivos);
            this.tpConsultarModificarUsuario.Controls.Add(this.dgvDatosUsuario);
            this.tpConsultarModificarUsuario.Controls.Add(this.txtConsultarUsuario);
            this.tpConsultarModificarUsuario.Controls.Add(this.label4);
            this.tpConsultarModificarUsuario.Location = new System.Drawing.Point(4, 25);
            this.tpConsultarModificarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tpConsultarModificarUsuario.Name = "tpConsultarModificarUsuario";
            this.tpConsultarModificarUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.tpConsultarModificarUsuario.Size = new System.Drawing.Size(618, 387);
            this.tpConsultarModificarUsuario.TabIndex = 1;
            this.tpConsultarModificarUsuario.Text = "Consultar - Modificar Usuario";
            // 
            // rbtInactivos
            // 
            this.rbtInactivos.AutoSize = true;
            this.rbtInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtInactivos.ForeColor = System.Drawing.Color.Teal;
            this.rbtInactivos.Location = new System.Drawing.Point(329, 52);
            this.rbtInactivos.Name = "rbtInactivos";
            this.rbtInactivos.Size = new System.Drawing.Size(79, 20);
            this.rbtInactivos.TabIndex = 15;
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
            this.rbtActivos.Location = new System.Drawing.Point(241, 52);
            this.rbtActivos.Name = "rbtActivos";
            this.rbtActivos.Size = new System.Drawing.Size(70, 20);
            this.rbtActivos.TabIndex = 14;
            this.rbtActivos.TabStop = true;
            this.rbtActivos.Text = "Activos";
            this.rbtActivos.UseVisualStyleBackColor = true;
            this.rbtActivos.CheckedChanged += new System.EventHandler(this.rbtActivos_CheckedChanged);
            // 
            // dgvDatosUsuario
            // 
            this.dgvDatosUsuario.AllowUserToAddRows = false;
            this.dgvDatosUsuario.AllowUserToDeleteRows = false;
            this.dgvDatosUsuario.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Deshabilitar,
            this.usuario,
            this.contraseña,
            this.factura,
            this.empresa,
            this.id});
            this.dgvDatosUsuario.Location = new System.Drawing.Point(18, 82);
            this.dgvDatosUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosUsuario.Name = "dgvDatosUsuario";
            this.dgvDatosUsuario.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Teal;
            this.dgvDatosUsuario.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatosUsuario.Size = new System.Drawing.Size(586, 289);
            this.dgvDatosUsuario.TabIndex = 2;
            this.dgvDatosUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosUsuario_CellClick);
            this.dgvDatosUsuario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDatosUsuario_CellPainting);
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Width = 25;
            // 
            // Deshabilitar
            // 
            this.Deshabilitar.HeaderText = "";
            this.Deshabilitar.Name = "Deshabilitar";
            this.Deshabilitar.ReadOnly = true;
            this.Deshabilitar.Width = 25;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 125;
            // 
            // contraseña
            // 
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            this.contraseña.ReadOnly = true;
            this.contraseña.Width = 125;
            // 
            // factura
            // 
            this.factura.HeaderText = "Factura";
            this.factura.Name = "factura";
            this.factura.ReadOnly = true;
            this.factura.Width = 70;
            // 
            // empresa
            // 
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            this.empresa.Width = 145;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // txtConsultarUsuario
            // 
            this.txtConsultarUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtConsultarUsuario.Location = new System.Drawing.Point(184, 21);
            this.txtConsultarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultarUsuario.Name = "txtConsultarUsuario";
            this.txtConsultarUsuario.Size = new System.Drawing.Size(325, 22);
            this.txtConsultarUsuario.TabIndex = 1;
            this.txtConsultarUsuario.TextChanged += new System.EventHandler(this.txtConsultarUsuario_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(109, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Consultar:";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(647, 444);
            this.Controls.Add(this.tcUsuario);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(663, 482);
            this.MinimumSize = new System.Drawing.Size(663, 482);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.tcUsuario.ResumeLayout(false);
            this.tpNuevoUsuario.ResumeLayout(false);
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDatosUsuario.PerformLayout();
            this.gbEmpresaConectarseProveedor.ResumeLayout(false);
            this.tpConsultarModificarUsuario.ResumeLayout(false);
            this.tpConsultarModificarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcUsuario;
        private System.Windows.Forms.TabPage tpNuevoUsuario;
        private System.Windows.Forms.GroupBox gbDatosUsuario;
        private System.Windows.Forms.CheckBox ckbFacturaUsuario;
        private System.Windows.Forms.GroupBox gbEmpresaConectarseProveedor;
        private System.Windows.Forms.CheckedListBox CheckListBEmpresas;
        private System.Windows.Forms.TextBox txtContraseñaUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cbPersonaUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpConsultarModificarUsuario;
        private System.Windows.Forms.DataGridView dgvDatosUsuario;
        private System.Windows.Forms.TextBox txtConsultarUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiarProveedor;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtConfirmarContraUsuario;
        private System.Windows.Forms.CheckBox ckMostrarContra;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtInactivos;
        private System.Windows.Forms.RadioButton rbtActivos;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Deshabilitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}