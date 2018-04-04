namespace Comisariato.Formularios.Mantenimiento.Inventario
{
    partial class FrmComboProductos
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbproductosParaCombo = new System.Windows.Forms.GroupBox();
            this.dgvProductosParaCombo = new System.Windows.Forms.DataGridView();
            this.txtBuscarProductosParaCombo = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tcComboProducto = new System.Windows.Forms.TabControl();
            this.tpNuevoCombo = new System.Windows.Forms.TabPage();
            this.txtPrecioCombo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantCombo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodigoCombo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiarCombo = new System.Windows.Forms.Button();
            this.btnGuardarCombo = new System.Windows.Forms.Button();
            this.txtNombreCombo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarProductoACombo = new System.Windows.Forms.Button();
            this.gbComboProductos = new System.Windows.Forms.GroupBox();
            this.dgvProductosEnCombo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpConsultarModificarCombo = new System.Windows.Forms.TabPage();
            this.rdbCombosInactivos = new System.Windows.Forms.RadioButton();
            this.rdbCombosActivos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDetalleCombo = new System.Windows.Forms.DataGridView();
            this.txtConsultarCombo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDatosCombo = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Desabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbproductosParaCombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosParaCombo)).BeginInit();
            this.tcComboProducto.SuspendLayout();
            this.tpNuevoCombo.SuspendLayout();
            this.gbComboProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnCombo)).BeginInit();
            this.tpConsultarModificarCombo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbproductosParaCombo
            // 
            this.gbproductosParaCombo.Controls.Add(this.dgvProductosParaCombo);
            this.gbproductosParaCombo.Controls.Add(this.txtBuscarProductosParaCombo);
            this.gbproductosParaCombo.Controls.Add(this.label25);
            this.gbproductosParaCombo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbproductosParaCombo.ForeColor = System.Drawing.Color.Teal;
            this.gbproductosParaCombo.Location = new System.Drawing.Point(47, 37);
            this.gbproductosParaCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbproductosParaCombo.Name = "gbproductosParaCombo";
            this.gbproductosParaCombo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbproductosParaCombo.Size = new System.Drawing.Size(895, 185);
            this.gbproductosParaCombo.TabIndex = 3;
            this.gbproductosParaCombo.TabStop = false;
            this.gbproductosParaCombo.Text = "Productos para Combos";
            // 
            // dgvProductosParaCombo
            // 
            this.dgvProductosParaCombo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosParaCombo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosParaCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosParaCombo.Location = new System.Drawing.Point(83, 49);
            this.dgvProductosParaCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductosParaCombo.Name = "dgvProductosParaCombo";
            this.dgvProductosParaCombo.RowHeadersVisible = false;
            this.dgvProductosParaCombo.Size = new System.Drawing.Size(737, 119);
            this.dgvProductosParaCombo.TabIndex = 3;
            this.dgvProductosParaCombo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosParaCombo_CellClick);
            // 
            // txtBuscarProductosParaCombo
            // 
            this.txtBuscarProductosParaCombo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtBuscarProductosParaCombo.Location = new System.Drawing.Point(211, 22);
            this.txtBuscarProductosParaCombo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarProductosParaCombo.Name = "txtBuscarProductosParaCombo";
            this.txtBuscarProductosParaCombo.Size = new System.Drawing.Size(571, 22);
            this.txtBuscarProductosParaCombo.TabIndex = 7;
            this.txtBuscarProductosParaCombo.TextChanged += new System.EventHandler(this.txtBuscarProductosParaCombo_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label25.Location = new System.Drawing.Point(110, 26);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 16);
            this.label25.TabIndex = 6;
            this.label25.Text = "Buscar:";
            // 
            // tcComboProducto
            // 
            this.tcComboProducto.Controls.Add(this.tpNuevoCombo);
            this.tcComboProducto.Controls.Add(this.tpConsultarModificarCombo);
            this.tcComboProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcComboProducto.Location = new System.Drawing.Point(15, 8);
            this.tcComboProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcComboProducto.Name = "tcComboProducto";
            this.tcComboProducto.SelectedIndex = 0;
            this.tcComboProducto.Size = new System.Drawing.Size(1043, 573);
            this.tcComboProducto.TabIndex = 3;
            // 
            // tpNuevoCombo
            // 
            this.tpNuevoCombo.BackColor = System.Drawing.Color.Bisque;
            this.tpNuevoCombo.Controls.Add(this.txtPrecioCombo);
            this.tpNuevoCombo.Controls.Add(this.label5);
            this.tpNuevoCombo.Controls.Add(this.txtCantCombo);
            this.tpNuevoCombo.Controls.Add(this.label4);
            this.tpNuevoCombo.Controls.Add(this.button1);
            this.tpNuevoCombo.Controls.Add(this.txtCodigoCombo);
            this.tpNuevoCombo.Controls.Add(this.label3);
            this.tpNuevoCombo.Controls.Add(this.btnLimpiarCombo);
            this.tpNuevoCombo.Controls.Add(this.btnGuardarCombo);
            this.tpNuevoCombo.Controls.Add(this.txtNombreCombo);
            this.tpNuevoCombo.Controls.Add(this.label1);
            this.tpNuevoCombo.Controls.Add(this.btnAgregarProductoACombo);
            this.tpNuevoCombo.Controls.Add(this.gbComboProductos);
            this.tpNuevoCombo.Controls.Add(this.gbproductosParaCombo);
            this.tpNuevoCombo.ForeColor = System.Drawing.Color.Teal;
            this.tpNuevoCombo.Location = new System.Drawing.Point(4, 25);
            this.tpNuevoCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpNuevoCombo.Name = "tpNuevoCombo";
            this.tpNuevoCombo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpNuevoCombo.Size = new System.Drawing.Size(1035, 544);
            this.tpNuevoCombo.TabIndex = 0;
            this.tpNuevoCombo.Text = "Nuevo Combo";
            // 
            // txtPrecioCombo
            // 
            this.txtPrecioCombo.Location = new System.Drawing.Point(594, 483);
            this.txtPrecioCombo.Name = "txtPrecioCombo";
            this.txtPrecioCombo.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioCombo.TabIndex = 16;
            this.txtPrecioCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCombo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Precio Combo:";
            // 
            // txtCantCombo
            // 
            this.txtCantCombo.Location = new System.Drawing.Point(594, 455);
            this.txtCantCombo.Name = "txtCantCombo";
            this.txtCantCombo.Size = new System.Drawing.Size(100, 22);
            this.txtCantCombo.TabIndex = 14;
            this.txtCantCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantCombo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantidad Combo:";
            // 
            // button1
            // 
            this.button1.Image = global::Comisariato.Properties.Resources.salir2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(39, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 57);
            this.button1.TabIndex = 12;
            this.button1.Text = "Salir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodigoCombo
            // 
            this.txtCodigoCombo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCodigoCombo.Location = new System.Drawing.Point(183, 10);
            this.txtCodigoCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoCombo.Name = "txtCodigoCombo";
            this.txtCodigoCombo.Size = new System.Drawing.Size(157, 22);
            this.txtCodigoCombo.TabIndex = 11;
            this.txtCodigoCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoCombo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(44, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Codigo del Combo: ";
            // 
            // btnLimpiarCombo
            // 
            this.btnLimpiarCombo.Image = global::Comisariato.Properties.Resources.limpiar;
            this.btnLimpiarCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarCombo.Location = new System.Drawing.Point(874, 455);
            this.btnLimpiarCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiarCombo.Name = "btnLimpiarCombo";
            this.btnLimpiarCombo.Size = new System.Drawing.Size(128, 81);
            this.btnLimpiarCombo.TabIndex = 9;
            this.btnLimpiarCombo.Text = "&Limpiar";
            this.btnLimpiarCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarCombo.UseVisualStyleBackColor = true;
            this.btnLimpiarCombo.Click += new System.EventHandler(this.btnLimpiarCombo_Click);
            // 
            // btnGuardarCombo
            // 
            this.btnGuardarCombo.Image = global::Comisariato.Properties.Resources.guardar11;
            this.btnGuardarCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCombo.Location = new System.Drawing.Point(721, 455);
            this.btnGuardarCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarCombo.Name = "btnGuardarCombo";
            this.btnGuardarCombo.Size = new System.Drawing.Size(128, 81);
            this.btnGuardarCombo.TabIndex = 8;
            this.btnGuardarCombo.Text = "&Guardar";
            this.btnGuardarCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCombo.UseVisualStyleBackColor = true;
            this.btnGuardarCombo.Click += new System.EventHandler(this.btnGuardarCombo_Click);
            // 
            // txtNombreCombo
            // 
            this.txtNombreCombo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNombreCombo.Location = new System.Drawing.Point(496, 10);
            this.txtNombreCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreCombo.Name = "txtNombreCombo";
            this.txtNombreCombo.Size = new System.Drawing.Size(475, 22);
            this.txtNombreCombo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(357, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del Combo:";
            // 
            // btnAgregarProductoACombo
            // 
            this.btnAgregarProductoACombo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnAgregarProductoACombo.Image = global::Comisariato.Properties.Resources.Modificar;
            this.btnAgregarProductoACombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProductoACombo.Location = new System.Drawing.Point(865, 223);
            this.btnAgregarProductoACombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarProductoACombo.Name = "btnAgregarProductoACombo";
            this.btnAgregarProductoACombo.Size = new System.Drawing.Size(106, 53);
            this.btnAgregarProductoACombo.TabIndex = 5;
            this.btnAgregarProductoACombo.Text = "&Agregar";
            this.btnAgregarProductoACombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProductoACombo.UseVisualStyleBackColor = true;
            this.btnAgregarProductoACombo.Click += new System.EventHandler(this.btnAgregarProductoACombo_Click);
            // 
            // gbComboProductos
            // 
            this.gbComboProductos.Controls.Add(this.dgvProductosEnCombo);
            this.gbComboProductos.ForeColor = System.Drawing.Color.Teal;
            this.gbComboProductos.Location = new System.Drawing.Point(6, 274);
            this.gbComboProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbComboProductos.Name = "gbComboProductos";
            this.gbComboProductos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbComboProductos.Size = new System.Drawing.Size(994, 173);
            this.gbComboProductos.TabIndex = 4;
            this.gbComboProductos.TabStop = false;
            this.gbComboProductos.Text = "Combo de Productos";
            // 
            // dgvProductosEnCombo
            // 
            this.dgvProductosEnCombo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosEnCombo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductosEnCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosEnCombo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.categoriaCombo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Cant,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ID});
            this.dgvProductosEnCombo.Location = new System.Drawing.Point(30, 25);
            this.dgvProductosEnCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductosEnCombo.Name = "dgvProductosEnCombo";
            this.dgvProductosEnCombo.RowHeadersVisible = false;
            this.dgvProductosEnCombo.Size = new System.Drawing.Size(935, 137);
            this.dgvProductosEnCombo.TabIndex = 2;
            this.dgvProductosEnCombo.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProductosEnCombo_EditingControlShowing);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // categoriaCombo
            // 
            this.categoriaCombo.HeaderText = "Categoria";
            this.categoriaCombo.Name = "categoriaCombo";
            this.categoriaCombo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cant.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // Cant
            // 
            this.Cant.HeaderText = "EnBodega";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Bodega";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "V. Unit.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // tpConsultarModificarCombo
            // 
            this.tpConsultarModificarCombo.BackColor = System.Drawing.Color.Bisque;
            this.tpConsultarModificarCombo.Controls.Add(this.rdbCombosInactivos);
            this.tpConsultarModificarCombo.Controls.Add(this.rdbCombosActivos);
            this.tpConsultarModificarCombo.Controls.Add(this.groupBox1);
            this.tpConsultarModificarCombo.Controls.Add(this.txtConsultarCombo);
            this.tpConsultarModificarCombo.Controls.Add(this.label2);
            this.tpConsultarModificarCombo.Controls.Add(this.dgvDatosCombo);
            this.tpConsultarModificarCombo.Location = new System.Drawing.Point(4, 25);
            this.tpConsultarModificarCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpConsultarModificarCombo.Name = "tpConsultarModificarCombo";
            this.tpConsultarModificarCombo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpConsultarModificarCombo.Size = new System.Drawing.Size(1035, 544);
            this.tpConsultarModificarCombo.TabIndex = 1;
            this.tpConsultarModificarCombo.Text = "Consultar - Modificar Combo";
            // 
            // rdbCombosInactivos
            // 
            this.rdbCombosInactivos.AutoSize = true;
            this.rdbCombosInactivos.Location = new System.Drawing.Point(711, 24);
            this.rdbCombosInactivos.Name = "rdbCombosInactivos";
            this.rdbCombosInactivos.Size = new System.Drawing.Size(76, 20);
            this.rdbCombosInactivos.TabIndex = 11;
            this.rdbCombosInactivos.Text = "Inactivo";
            this.rdbCombosInactivos.UseVisualStyleBackColor = true;
            this.rdbCombosInactivos.CheckedChanged += new System.EventHandler(this.rdbCombosInactivos_CheckedChanged);
            // 
            // rdbCombosActivos
            // 
            this.rdbCombosActivos.AutoSize = true;
            this.rdbCombosActivos.Checked = true;
            this.rdbCombosActivos.Location = new System.Drawing.Point(565, 24);
            this.rdbCombosActivos.Name = "rdbCombosActivos";
            this.rdbCombosActivos.Size = new System.Drawing.Size(65, 20);
            this.rdbCombosActivos.TabIndex = 10;
            this.rdbCombosActivos.TabStop = true;
            this.rdbCombosActivos.Text = "Activo";
            this.rdbCombosActivos.UseVisualStyleBackColor = true;
            this.rdbCombosActivos.CheckedChanged += new System.EventHandler(this.rdbCombosActivos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDetalleCombo);
            this.groupBox1.Location = new System.Drawing.Point(564, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 460);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Combo";
            // 
            // dgvDetalleCombo
            // 
            this.dgvDetalleCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCombo.Location = new System.Drawing.Point(20, 28);
            this.dgvDetalleCombo.Name = "dgvDetalleCombo";
            this.dgvDetalleCombo.ReadOnly = true;
            this.dgvDetalleCombo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleCombo.Size = new System.Drawing.Size(408, 413);
            this.dgvDetalleCombo.TabIndex = 0;
            // 
            // txtConsultarCombo
            // 
            this.txtConsultarCombo.Location = new System.Drawing.Point(87, 25);
            this.txtConsultarCombo.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultarCombo.Name = "txtConsultarCombo";
            this.txtConsultarCombo.Size = new System.Drawing.Size(374, 22);
            this.txtConsultarCombo.TabIndex = 8;
            this.txtConsultarCombo.TextChanged += new System.EventHandler(this.txtConsultarCombo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Consultar:";
            // 
            // dgvDatosCombo
            // 
            this.dgvDatosCombo.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosCombo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCombo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Desabilitar});
            this.dgvDatosCombo.Location = new System.Drawing.Point(19, 61);
            this.dgvDatosCombo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosCombo.Name = "dgvDatosCombo";
            this.dgvDatosCombo.ReadOnly = true;
            this.dgvDatosCombo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosCombo.Size = new System.Drawing.Size(517, 460);
            this.dgvDatosCombo.TabIndex = 6;
            this.dgvDatosCombo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosCombo_CellClick);
            this.dgvDatosCombo.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDatosCombo_CellPainting);
            this.dgvDatosCombo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDatosCombo_RowHeaderMouseClick);
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Width = 30;
            // 
            // Desabilitar
            // 
            this.Desabilitar.HeaderText = "";
            this.Desabilitar.Name = "Desabilitar";
            this.Desabilitar.ReadOnly = true;
            this.Desabilitar.Width = 30;
            // 
            // FrmComboProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1083, 588);
            this.Controls.Add(this.tcComboProducto);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmComboProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Administrar Combo de Productos";
            this.Load += new System.EventHandler(this.FrmComboProductos_Load);
            this.gbproductosParaCombo.ResumeLayout(false);
            this.gbproductosParaCombo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosParaCombo)).EndInit();
            this.tcComboProducto.ResumeLayout(false);
            this.tpNuevoCombo.ResumeLayout(false);
            this.tpNuevoCombo.PerformLayout();
            this.gbComboProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnCombo)).EndInit();
            this.tpConsultarModificarCombo.ResumeLayout(false);
            this.tpConsultarModificarCombo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCombo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbproductosParaCombo;
        private System.Windows.Forms.TabControl tcComboProducto;
        private System.Windows.Forms.TabPage tpConsultarModificarCombo;
        private System.Windows.Forms.TabPage tpNuevoCombo;
        private System.Windows.Forms.GroupBox gbComboProductos;
        private System.Windows.Forms.TextBox txtBuscarProductosParaCombo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnAgregarProductoACombo;
        private System.Windows.Forms.TextBox txtNombreCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarCombo;
        private System.Windows.Forms.Button btnGuardarCombo;
        private System.Windows.Forms.TextBox txtConsultarCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDatosCombo;
        private System.Windows.Forms.TextBox txtCodigoCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProductosEnCombo;
        private System.Windows.Forms.DataGridView dgvProductosParaCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrecioCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDetalleCombo;
        private System.Windows.Forms.RadioButton rdbCombosInactivos;
        private System.Windows.Forms.RadioButton rdbCombosActivos;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Desabilitar;
    }
}