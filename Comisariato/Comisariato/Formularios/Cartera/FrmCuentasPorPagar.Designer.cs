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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.BtnPagar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvCuentasPorPagar = new System.Windows.Forms.DataGridView();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.rbAnulados.Visible = false;
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
            this.rbActivos.Visible = false;
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
            // BtnPagar
            // 
            this.BtnPagar.Enabled = false;
            this.BtnPagar.Font = new System.Drawing.Font("Arial", 10F);
            this.BtnPagar.Location = new System.Drawing.Point(800, 114);
            this.BtnPagar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(86, 29);
            this.BtnPagar.TabIndex = 39;
            this.BtnPagar.Text = "Pagar";
            this.BtnPagar.UseVisualStyleBackColor = true;
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
            this.dgvCuentasPorPagar.AllowUserToResizeColumns = false;
            this.dgvCuentasPorPagar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dgvCuentasPorPagar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentasPorPagar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuentasPorPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentasPorPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proveedor,
            this.totalPagar,
            this.plazo,
            this.dias,
            this.IDProveedor});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuentasPorPagar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCuentasPorPagar.Location = new System.Drawing.Point(14, 152);
            this.dgvCuentasPorPagar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvCuentasPorPagar.Name = "dgvCuentasPorPagar";
            this.dgvCuentasPorPagar.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentasPorPagar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCuentasPorPagar.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Teal;
            this.dgvCuentasPorPagar.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCuentasPorPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentasPorPagar.Size = new System.Drawing.Size(873, 517);
            this.dgvCuentasPorPagar.TabIndex = 40;
            this.dgvCuentasPorPagar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentasPorPagar_CellEnter);
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
            // IDProveedor
            // 
            this.IDProveedor.HeaderText = "IDProveedor";
            this.IDProveedor.Name = "IDProveedor";
            this.IDProveedor.ReadOnly = true;
            this.IDProveedor.Visible = false;
            // 
            // FrmCuentasPorPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(902, 682);
            this.Controls.Add(this.dgvCuentasPorPagar);
            this.Controls.Add(this.BtnPagar);
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
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvCuentasPorPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProveedor;
    }
}