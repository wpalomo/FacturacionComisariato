namespace Comisariato.Formularios.Cartera
{
    partial class FrmCuentasPorPagar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.rbAnulados = new System.Windows.Forms.RadioButton();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvCuentasPorPagar = new System.Windows.Forms.DataGridView();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasPorPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpHasta);
            this.groupBox2.Controls.Add(this.dtpDesde);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(14, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.groupBox2.Size = new System.Drawing.Size(408, 127);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpHasta.Location = new System.Drawing.Point(89, 69);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(298, 23);
            this.dtpHasta.TabIndex = 20;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpDesde.Location = new System.Drawing.Point(89, 34);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.dtpDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(298, 23);
            this.dtpDesde.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10F);
            this.label14.Location = new System.Drawing.Point(22, 71);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Hasta:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10F);
            this.label16.Location = new System.Drawing.Point(22, 40);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "Desde:";
            // 
            // rbAnulados
            // 
            this.rbAnulados.AutoSize = true;
            this.rbAnulados.Font = new System.Drawing.Font("Arial", 10F);
            this.rbAnulados.ForeColor = System.Drawing.Color.Teal;
            this.rbAnulados.Location = new System.Drawing.Point(634, 81);
            this.rbAnulados.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbAnulados.Name = "rbAnulados";
            this.rbAnulados.Size = new System.Drawing.Size(85, 20);
            this.rbAnulados.TabIndex = 37;
            this.rbAnulados.TabStop = true;
            this.rbAnulados.Text = "Anulados";
            this.rbAnulados.UseVisualStyleBackColor = true;
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Font = new System.Drawing.Font("Arial", 10F);
            this.rbActivos.ForeColor = System.Drawing.Color.Teal;
            this.rbActivos.Location = new System.Drawing.Point(559, 81);
            this.rbActivos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(71, 20);
            this.rbActivos.TabIndex = 36;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnConsultar.Location = new System.Drawing.Point(791, 48);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 31);
            this.btnConsultar.TabIndex = 35;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsultar
            // 
            this.txtConsultar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultar.Location = new System.Drawing.Point(497, 53);
            this.txtConsultar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(290, 22);
            this.txtConsultar.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(426, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Consultar:";
            // 
            // btnAnular
            // 
            this.btnAnular.Enabled = false;
            this.btnAnular.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAnular.Location = new System.Drawing.Point(800, 114);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(86, 29);
            this.btnAnular.TabIndex = 39;
            this.btnAnular.Text = "Pagar";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnModificar.Location = new System.Drawing.Point(705, 114);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 29);
            this.btnModificar.TabIndex = 38;
            this.btnModificar.Text = "Ver";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvCuentasPorPagar
            // 
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dgvCuentasPorPagar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentasPorPagar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvCuentasPorPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentasPorPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proveedor,
            this.totalPagar,
            this.plazo,
            this.dias});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuentasPorPagar.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvCuentasPorPagar.Location = new System.Drawing.Point(14, 152);
            this.dgvCuentasPorPagar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvCuentasPorPagar.Name = "dgvCuentasPorPagar";
            this.dgvCuentasPorPagar.ReadOnly = true;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentasPorPagar.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvCuentasPorPagar.RowHeadersVisible = false;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Teal;
            this.dgvCuentasPorPagar.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvCuentasPorPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentasPorPagar.Size = new System.Drawing.Size(873, 517);
            this.dgvCuentasPorPagar.TabIndex = 40;
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            this.proveedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proveedor.Width = 450;
            // 
            // totalPagar
            // 
            this.totalPagar.HeaderText = "Total a Pagar";
            this.totalPagar.Name = "totalPagar";
            this.totalPagar.ReadOnly = true;
            this.totalPagar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.totalPagar.Width = 150;
            // 
            // plazo
            // 
            this.plazo.HeaderText = "Fecha Vence";
            this.plazo.Name = "plazo";
            this.plazo.ReadOnly = true;
            this.plazo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.plazo.Width = 175;
            // 
            // dias
            // 
            this.dias.HeaderText = "Días";
            this.dias.Name = "dias";
            this.dias.ReadOnly = true;
            this.dias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dias.Width = 75;
            // 
            // FrmCuentasPorPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(902, 682);
            this.Controls.Add(this.dgvCuentasPorPagar);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.rbAnulados);
            this.Controls.Add(this.rbActivos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FrmCuentasPorPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por Pagar";
            this.Load += new System.EventHandler(this.FrmCuentasPorPagar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasPorPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbAnulados;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvCuentasPorPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
    }
}