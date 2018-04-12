namespace Comisariato.Formularios.Informes
{
    partial class FrmInformeNotaCredito
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvDatosProducto = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbAnulados = new System.Windows.Forms.RadioButton();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProducto)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(14, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(402, 121);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpHasta.Location = new System.Drawing.Point(110, 73);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(267, 23);
            this.dtpHasta.TabIndex = 20;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpDesde.Location = new System.Drawing.Point(110, 26);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(267, 23);
            this.dtpDesde.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10F);
            this.label14.Location = new System.Drawing.Point(20, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Hasta:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10F);
            this.label16.Location = new System.Drawing.Point(20, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "Desde:";
            // 
            // dgvDatosProducto
            // 
            this.dgvDatosProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.nc,
            this.compra,
            this.proveedor,
            this.totalDevolucion,
            this.totalCompra,
            this.idNC,
            this.idCompra});
            this.dgvDatosProducto.Location = new System.Drawing.Point(25, 142);
            this.dgvDatosProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosProducto.Name = "dgvDatosProducto";
            this.dgvDatosProducto.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosProducto.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            this.dgvDatosProducto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosProducto.Size = new System.Drawing.Size(873, 549);
            this.dgvDatosProducto.TabIndex = 22;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 135;
            // 
            // nc
            // 
            this.nc.HeaderText = "Número Nota Crédito";
            this.nc.Name = "nc";
            this.nc.ReadOnly = true;
            this.nc.Width = 165;
            // 
            // compra
            // 
            this.compra.HeaderText = "Numero Compra";
            this.compra.Name = "compra";
            this.compra.ReadOnly = true;
            this.compra.Width = 150;
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            this.proveedor.Width = 200;
            // 
            // totalDevolucion
            // 
            this.totalDevolucion.HeaderText = "Total Dev.";
            this.totalDevolucion.Name = "totalDevolucion";
            this.totalDevolucion.ReadOnly = true;
            // 
            // totalCompra
            // 
            this.totalCompra.HeaderText = "Total Com.";
            this.totalCompra.Name = "totalCompra";
            this.totalCompra.ReadOnly = true;
            // 
            // idNC
            // 
            this.idNC.HeaderText = "idNC";
            this.idNC.Name = "idNC";
            this.idNC.ReadOnly = true;
            this.idNC.Visible = false;
            // 
            // idCompra
            // 
            this.idCompra.HeaderText = "Compra";
            this.idCompra.Name = "idCompra";
            this.idCompra.ReadOnly = true;
            this.idCompra.Visible = false;
            // 
            // rbAnulados
            // 
            this.rbAnulados.AutoSize = true;
            this.rbAnulados.Font = new System.Drawing.Font("Arial", 10F);
            this.rbAnulados.ForeColor = System.Drawing.Color.Teal;
            this.rbAnulados.Location = new System.Drawing.Point(624, 91);
            this.rbAnulados.Name = "rbAnulados";
            this.rbAnulados.Size = new System.Drawing.Size(85, 20);
            this.rbAnulados.TabIndex = 32;
            this.rbAnulados.TabStop = true;
            this.rbAnulados.Text = "Anulados";
            this.rbAnulados.UseVisualStyleBackColor = true;
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Font = new System.Drawing.Font("Arial", 10F);
            this.rbActivos.ForeColor = System.Drawing.Color.Teal;
            this.rbActivos.Location = new System.Drawing.Point(547, 91);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(71, 20);
            this.rbActivos.TabIndex = 31;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnConsultar.Location = new System.Drawing.Point(780, 63);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(114, 25);
            this.btnConsultar.TabIndex = 30;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsultar
            // 
            this.txtConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultar.Location = new System.Drawing.Point(495, 64);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(268, 22);
            this.txtConsultar.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(422, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Consultar:";
            // 
            // FrmInformeNotaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(923, 702);
            this.Controls.Add(this.rbAnulados);
            this.Controls.Add(this.rbActivos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvDatosProducto);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmInformeNotaCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Informe Nota Crédito";
            this.Load += new System.EventHandler(this.FrmInformeNotaCredito_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvDatosProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nc;
        private System.Windows.Forms.DataGridViewTextBoxColumn compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompra;
        private System.Windows.Forms.RadioButton rbAnulados;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Label label8;
    }
}