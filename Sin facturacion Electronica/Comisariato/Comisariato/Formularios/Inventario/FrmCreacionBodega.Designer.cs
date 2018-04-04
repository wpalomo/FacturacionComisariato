namespace Comisariato.Formularios.Mantenimiento.Inventario
{
    partial class FrmCreacionBodega
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
            this.btnLimpiarBodega = new System.Windows.Forms.Button();
            this.btnGuardarBodega = new System.Windows.Forms.Button();
            this.tcbodega = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cbResponsableBodega = new System.Windows.Forms.ComboBox();
            this.txtUbicacionBodega = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionBodega = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbInactivoBodega = new System.Windows.Forms.RadioButton();
            this.rbActivosBodega = new System.Windows.Forms.RadioButton();
            this.txtConsultarBodega = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDatosBodega = new System.Windows.Forms.DataGridView();
            this.modificarDatosBodega = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeshabilitarDatosBodega = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tcbodega.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarBodega
            // 
            this.btnLimpiarBodega.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnLimpiarBodega.Image = global::Comisariato.Properties.Resources.limpiar;
            this.btnLimpiarBodega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarBodega.Location = new System.Drawing.Point(352, 151);
            this.btnLimpiarBodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiarBodega.Name = "btnLimpiarBodega";
            this.btnLimpiarBodega.Size = new System.Drawing.Size(125, 68);
            this.btnLimpiarBodega.TabIndex = 5;
            this.btnLimpiarBodega.Text = "&Limpiar";
            this.btnLimpiarBodega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBodega.UseVisualStyleBackColor = true;
            this.btnLimpiarBodega.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnGuardarBodega
            // 
            this.btnGuardarBodega.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnGuardarBodega.Image = global::Comisariato.Properties.Resources.guardar11;
            this.btnGuardarBodega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarBodega.Location = new System.Drawing.Point(199, 151);
            this.btnGuardarBodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarBodega.Name = "btnGuardarBodega";
            this.btnGuardarBodega.Size = new System.Drawing.Size(125, 68);
            this.btnGuardarBodega.TabIndex = 4;
            this.btnGuardarBodega.Text = "&Guardar";
            this.btnGuardarBodega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarBodega.UseVisualStyleBackColor = true;
            this.btnGuardarBodega.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // tcbodega
            // 
            this.tcbodega.Controls.Add(this.tabPage1);
            this.tcbodega.Controls.Add(this.tabPage2);
            this.tcbodega.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcbodega.Location = new System.Drawing.Point(14, 14);
            this.tcbodega.Name = "tcbodega";
            this.tcbodega.SelectedIndex = 0;
            this.tcbodega.Size = new System.Drawing.Size(703, 306);
            this.tcbodega.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Bisque;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbResponsableBodega);
            this.tabPage1.Controls.Add(this.txtUbicacionBodega);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtDescripcionBodega);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnLimpiarBodega);
            this.tabPage1.Controls.Add(this.btnGuardarBodega);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(695, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nueva Bodega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(87, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Responsable:";
            // 
            // cbResponsableBodega
            // 
            this.cbResponsableBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResponsableBodega.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbResponsableBodega.FormattingEnabled = true;
            this.cbResponsableBodega.Location = new System.Drawing.Point(187, 109);
            this.cbResponsableBodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbResponsableBodega.Name = "cbResponsableBodega";
            this.cbResponsableBodega.Size = new System.Drawing.Size(420, 24);
            this.cbResponsableBodega.TabIndex = 3;
            // 
            // txtUbicacionBodega
            // 
            this.txtUbicacionBodega.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtUbicacionBodega.Location = new System.Drawing.Point(187, 78);
            this.txtUbicacionBodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUbicacionBodega.Name = "txtUbicacionBodega";
            this.txtUbicacionBodega.Size = new System.Drawing.Size(420, 22);
            this.txtUbicacionBodega.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(87, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ubicación:";
            // 
            // txtDescripcionBodega
            // 
            this.txtDescripcionBodega.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtDescripcionBodega.Location = new System.Drawing.Point(187, 46);
            this.txtDescripcionBodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcionBodega.Name = "txtDescripcionBodega";
            this.txtDescripcionBodega.Size = new System.Drawing.Size(420, 22);
            this.txtDescripcionBodega.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(87, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Descripción:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.rbInactivoBodega);
            this.tabPage2.Controls.Add(this.rbActivosBodega);
            this.tabPage2.Controls.Add(this.txtConsultarBodega);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvDatosBodega);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(695, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar - Modificar Bodega";
            // 
            // rbInactivoBodega
            // 
            this.rbInactivoBodega.AutoSize = true;
            this.rbInactivoBodega.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbInactivoBodega.ForeColor = System.Drawing.Color.Teal;
            this.rbInactivoBodega.Location = new System.Drawing.Point(369, 37);
            this.rbInactivoBodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbInactivoBodega.Name = "rbInactivoBodega";
            this.rbInactivoBodega.Size = new System.Drawing.Size(76, 20);
            this.rbInactivoBodega.TabIndex = 9;
            this.rbInactivoBodega.Text = "Inactivos";
            this.rbInactivoBodega.UseVisualStyleBackColor = true;
            this.rbInactivoBodega.CheckedChanged += new System.EventHandler(this.RbtActivos_CheckedChanged);
            // 
            // rbActivosBodega
            // 
            this.rbActivosBodega.AutoSize = true;
            this.rbActivosBodega.Checked = true;
            this.rbActivosBodega.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbActivosBodega.ForeColor = System.Drawing.Color.Teal;
            this.rbActivosBodega.Location = new System.Drawing.Point(250, 37);
            this.rbActivosBodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbActivosBodega.Name = "rbActivosBodega";
            this.rbActivosBodega.Size = new System.Drawing.Size(68, 20);
            this.rbActivosBodega.TabIndex = 8;
            this.rbActivosBodega.TabStop = true;
            this.rbActivosBodega.Text = "Activos";
            this.rbActivosBodega.UseVisualStyleBackColor = true;
            this.rbActivosBodega.CheckedChanged += new System.EventHandler(this.RbtActivos_CheckedChanged);
            // 
            // txtConsultarBodega
            // 
            this.txtConsultarBodega.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtConsultarBodega.Location = new System.Drawing.Point(153, 7);
            this.txtConsultarBodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsultarBodega.Name = "txtConsultarBodega";
            this.txtConsultarBodega.Size = new System.Drawing.Size(462, 22);
            this.txtConsultarBodega.TabIndex = 7;
            this.txtConsultarBodega.TextChanged += new System.EventHandler(this.TxtConsulta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(80, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Consultar:";
            // 
            // dgvDatosBodega
            // 
            this.dgvDatosBodega.AllowUserToAddRows = false;
            this.dgvDatosBodega.AllowUserToDeleteRows = false;
            this.dgvDatosBodega.AllowUserToOrderColumns = true;
            this.dgvDatosBodega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosBodega.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosBodega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosBodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modificarDatosBodega,
            this.DeshabilitarDatosBodega});
            this.dgvDatosBodega.Location = new System.Drawing.Point(31, 73);
            this.dgvDatosBodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDatosBodega.Name = "dgvDatosBodega";
            this.dgvDatosBodega.ReadOnly = true;
            this.dgvDatosBodega.Size = new System.Drawing.Size(633, 177);
            this.dgvDatosBodega.TabIndex = 5;
            this.dgvDatosBodega.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosBodega_CellClick);
            this.dgvDatosBodega.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDatosBodega_CellPainting_1);
            // 
            // modificarDatosBodega
            // 
            this.modificarDatosBodega.HeaderText = "";
            this.modificarDatosBodega.Name = "modificarDatosBodega";
            this.modificarDatosBodega.ReadOnly = true;
            // 
            // DeshabilitarDatosBodega
            // 
            this.DeshabilitarDatosBodega.HeaderText = "";
            this.DeshabilitarDatosBodega.Name = "DeshabilitarDatosBodega";
            this.DeshabilitarDatosBodega.ReadOnly = true;
            // 
            // FrmCreacionBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(730, 334);
            this.Controls.Add(this.tcbodega);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCreacionBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Bodegas";
            this.Load += new System.EventHandler(this.FrmCreacionBodega_Load);
            this.tcbodega.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBodega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLimpiarBodega;
        private System.Windows.Forms.Button btnGuardarBodega;
        private System.Windows.Forms.TabControl tcbodega;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbResponsableBodega;
        private System.Windows.Forms.TextBox txtUbicacionBodega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcionBodega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rbInactivoBodega;
        private System.Windows.Forms.RadioButton rbActivosBodega;
        private System.Windows.Forms.TextBox txtConsultarBodega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDatosBodega;
        private System.Windows.Forms.DataGridViewButtonColumn modificarDatosBodega;
        private System.Windows.Forms.DataGridViewButtonColumn DeshabilitarDatosBodega;
    }
}