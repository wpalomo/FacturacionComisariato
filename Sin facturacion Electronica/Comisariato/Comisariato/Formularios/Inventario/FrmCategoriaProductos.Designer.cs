namespace Comisariato.Formularios.Mantenimiento.Inventario
{
    partial class FrmCategoriaProductos
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
            this.gbRegistrarCategoriaProducto = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCategoriaProducto = new System.Windows.Forms.Button();
            this.btnGuardarCategoriaProducto = new System.Windows.Forms.Button();
            this.ckbManejaInventarioCategoriaProducto = new System.Windows.Forms.CheckBox();
            this.ckbComboCategoriaProducto = new System.Windows.Forms.CheckBox();
            this.txtDescripcionCategoriaUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbConsultarModificarEliminarCategoriaProducto = new System.Windows.Forms.GroupBox();
            this.dgvDatosCategoriaProducto = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deshabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rbtInactivos = new System.Windows.Forms.RadioButton();
            this.rbtActivos = new System.Windows.Forms.RadioButton();
            this.txtConsultarCategoriaProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbRegistrarCategoriaProducto.SuspendLayout();
            this.gbConsultarModificarEliminarCategoriaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCategoriaProducto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistrarCategoriaProducto
            // 
            this.gbRegistrarCategoriaProducto.Controls.Add(this.btnLimpiarCategoriaProducto);
            this.gbRegistrarCategoriaProducto.Controls.Add(this.btnGuardarCategoriaProducto);
            this.gbRegistrarCategoriaProducto.Controls.Add(this.ckbManejaInventarioCategoriaProducto);
            this.gbRegistrarCategoriaProducto.Controls.Add(this.ckbComboCategoriaProducto);
            this.gbRegistrarCategoriaProducto.Controls.Add(this.txtDescripcionCategoriaUsuario);
            this.gbRegistrarCategoriaProducto.Controls.Add(this.label1);
            this.gbRegistrarCategoriaProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarCategoriaProducto.ForeColor = System.Drawing.Color.Teal;
            this.gbRegistrarCategoriaProducto.Location = new System.Drawing.Point(24, 22);
            this.gbRegistrarCategoriaProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbRegistrarCategoriaProducto.Name = "gbRegistrarCategoriaProducto";
            this.gbRegistrarCategoriaProducto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbRegistrarCategoriaProducto.Size = new System.Drawing.Size(663, 292);
            this.gbRegistrarCategoriaProducto.TabIndex = 1;
            this.gbRegistrarCategoriaProducto.TabStop = false;
            this.gbRegistrarCategoriaProducto.Text = "Registrar Categoria de Productos";
            // 
            // btnLimpiarCategoriaProducto
            // 
            this.btnLimpiarCategoriaProducto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnLimpiarCategoriaProducto.Image = global::Comisariato.Properties.Resources.limpiar;
            this.btnLimpiarCategoriaProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarCategoriaProducto.Location = new System.Drawing.Point(369, 189);
            this.btnLimpiarCategoriaProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiarCategoriaProducto.Name = "btnLimpiarCategoriaProducto";
            this.btnLimpiarCategoriaProducto.Size = new System.Drawing.Size(125, 71);
            this.btnLimpiarCategoriaProducto.TabIndex = 31;
            this.btnLimpiarCategoriaProducto.Text = "&Limpiar";
            this.btnLimpiarCategoriaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarCategoriaProducto.UseVisualStyleBackColor = true;
            this.btnLimpiarCategoriaProducto.Click += new System.EventHandler(this.btnLimpiarCategoriaProducto_Click);
            // 
            // btnGuardarCategoriaProducto
            // 
            this.btnGuardarCategoriaProducto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnGuardarCategoriaProducto.Image = global::Comisariato.Properties.Resources.guardar11;
            this.btnGuardarCategoriaProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCategoriaProducto.Location = new System.Drawing.Point(212, 189);
            this.btnGuardarCategoriaProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarCategoriaProducto.Name = "btnGuardarCategoriaProducto";
            this.btnGuardarCategoriaProducto.Size = new System.Drawing.Size(125, 71);
            this.btnGuardarCategoriaProducto.TabIndex = 30;
            this.btnGuardarCategoriaProducto.Text = "&Guardar";
            this.btnGuardarCategoriaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCategoriaProducto.UseVisualStyleBackColor = true;
            this.btnGuardarCategoriaProducto.Click += new System.EventHandler(this.btnGuardarCategoriaProducto_Click);
            // 
            // ckbManejaInventarioCategoriaProducto
            // 
            this.ckbManejaInventarioCategoriaProducto.AutoSize = true;
            this.ckbManejaInventarioCategoriaProducto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ckbManejaInventarioCategoriaProducto.Location = new System.Drawing.Point(449, 113);
            this.ckbManejaInventarioCategoriaProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbManejaInventarioCategoriaProducto.Name = "ckbManejaInventarioCategoriaProducto";
            this.ckbManejaInventarioCategoriaProducto.Size = new System.Drawing.Size(127, 20);
            this.ckbManejaInventarioCategoriaProducto.TabIndex = 3;
            this.ckbManejaInventarioCategoriaProducto.Text = "Maneja Inventario";
            this.ckbManejaInventarioCategoriaProducto.UseVisualStyleBackColor = true;
            // 
            // ckbComboCategoriaProducto
            // 
            this.ckbComboCategoriaProducto.AutoSize = true;
            this.ckbComboCategoriaProducto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ckbComboCategoriaProducto.Location = new System.Drawing.Point(156, 113);
            this.ckbComboCategoriaProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbComboCategoriaProducto.Name = "ckbComboCategoriaProducto";
            this.ckbComboCategoriaProducto.Size = new System.Drawing.Size(68, 20);
            this.ckbComboCategoriaProducto.TabIndex = 2;
            this.ckbComboCategoriaProducto.Text = "Combo";
            this.ckbComboCategoriaProducto.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionCategoriaUsuario
            // 
            this.txtDescripcionCategoriaUsuario.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtDescripcionCategoriaUsuario.Location = new System.Drawing.Point(156, 83);
            this.txtDescripcionCategoriaUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcionCategoriaUsuario.Name = "txtDescripcionCategoriaUsuario";
            this.txtDescripcionCategoriaUsuario.Size = new System.Drawing.Size(420, 22);
            this.txtDescripcionCategoriaUsuario.TabIndex = 1;
            this.txtDescripcionCategoriaUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionCategoriaUsuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(58, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción:";
            // 
            // gbConsultarModificarEliminarCategoriaProducto
            // 
            this.gbConsultarModificarEliminarCategoriaProducto.Controls.Add(this.dgvDatosCategoriaProducto);
            this.gbConsultarModificarEliminarCategoriaProducto.Controls.Add(this.rbtInactivos);
            this.gbConsultarModificarEliminarCategoriaProducto.Controls.Add(this.rbtActivos);
            this.gbConsultarModificarEliminarCategoriaProducto.Controls.Add(this.txtConsultarCategoriaProducto);
            this.gbConsultarModificarEliminarCategoriaProducto.Controls.Add(this.label2);
            this.gbConsultarModificarEliminarCategoriaProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultarModificarEliminarCategoriaProducto.ForeColor = System.Drawing.Color.Teal;
            this.gbConsultarModificarEliminarCategoriaProducto.Location = new System.Drawing.Point(19, 11);
            this.gbConsultarModificarEliminarCategoriaProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbConsultarModificarEliminarCategoriaProducto.Name = "gbConsultarModificarEliminarCategoriaProducto";
            this.gbConsultarModificarEliminarCategoriaProducto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbConsultarModificarEliminarCategoriaProducto.Size = new System.Drawing.Size(668, 338);
            this.gbConsultarModificarEliminarCategoriaProducto.TabIndex = 2;
            this.gbConsultarModificarEliminarCategoriaProducto.TabStop = false;
            this.gbConsultarModificarEliminarCategoriaProducto.Text = "Consultar - Modificar Categoria de Producto";
            // 
            // dgvDatosCategoriaProducto
            // 
            this.dgvDatosCategoriaProducto.AllowUserToAddRows = false;
            this.dgvDatosCategoriaProducto.AllowUserToDeleteRows = false;
            this.dgvDatosCategoriaProducto.AllowUserToOrderColumns = true;
            this.dgvDatosCategoriaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosCategoriaProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosCategoriaProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosCategoriaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCategoriaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Deshabilitar});
            this.dgvDatosCategoriaProducto.Location = new System.Drawing.Point(20, 74);
            this.dgvDatosCategoriaProducto.Name = "dgvDatosCategoriaProducto";
            this.dgvDatosCategoriaProducto.ReadOnly = true;
            this.dgvDatosCategoriaProducto.Size = new System.Drawing.Size(631, 251);
            this.dgvDatosCategoriaProducto.TabIndex = 16;
            this.dgvDatosCategoriaProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosCategoriaProducto_CellClick);
            this.dgvDatosCategoriaProducto.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDatosCategoriaProducto_CellPainting);
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
            this.rbtInactivos.Location = new System.Drawing.Point(358, 52);
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
            this.rbtActivos.Location = new System.Drawing.Point(270, 52);
            this.rbtActivos.Name = "rbtActivos";
            this.rbtActivos.Size = new System.Drawing.Size(70, 20);
            this.rbtActivos.TabIndex = 14;
            this.rbtActivos.TabStop = true;
            this.rbtActivos.Text = "Activos";
            this.rbtActivos.UseVisualStyleBackColor = true;
            this.rbtActivos.CheckedChanged += new System.EventHandler(this.rbtActivos_CheckedChanged);
            // 
            // txtConsultarCategoriaProducto
            // 
            this.txtConsultarCategoriaProducto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtConsultarCategoriaProducto.Location = new System.Drawing.Point(174, 23);
            this.txtConsultarCategoriaProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsultarCategoriaProducto.Name = "txtConsultarCategoriaProducto";
            this.txtConsultarCategoriaProducto.Size = new System.Drawing.Size(382, 22);
            this.txtConsultarCategoriaProducto.TabIndex = 1;
            this.txtConsultarCategoriaProducto.TextChanged += new System.EventHandler(this.txtConsultarCategoriaProducto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(89, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consultar:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 398);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Bisque;
            this.tabPage1.Controls.Add(this.gbRegistrarCategoriaProducto);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(709, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nueva Categoria";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.gbConsultarModificarEliminarCategoriaProducto);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(709, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar - Modificar Categoria";
            // 
            // FrmCategoriaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(760, 422);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCategoriaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Categoria de Productos";
            this.Load += new System.EventHandler(this.FrmCategoriaProductos_Load);
            this.gbRegistrarCategoriaProducto.ResumeLayout(false);
            this.gbRegistrarCategoriaProducto.PerformLayout();
            this.gbConsultarModificarEliminarCategoriaProducto.ResumeLayout(false);
            this.gbConsultarModificarEliminarCategoriaProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCategoriaProducto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbRegistrarCategoriaProducto;
        private System.Windows.Forms.CheckBox ckbManejaInventarioCategoriaProducto;
        private System.Windows.Forms.CheckBox ckbComboCategoriaProducto;
        private System.Windows.Forms.TextBox txtDescripcionCategoriaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbConsultarModificarEliminarCategoriaProducto;
        private System.Windows.Forms.TextBox txtConsultarCategoriaProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiarCategoriaProducto;
        private System.Windows.Forms.Button btnGuardarCategoriaProducto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rbtInactivos;
        private System.Windows.Forms.RadioButton rbtActivos;
        private System.Windows.Forms.DataGridView dgvDatosCategoriaProducto;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Deshabilitar;
    }
}