namespace Comisariato.Formularios.Informes
{
    partial class FrmInformesCompras
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
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvInformeCompras = new System.Windows.Forms.DataGridView();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rucProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Irbp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnExportarExcel = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeCompras)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 98);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpHasta.Location = new System.Drawing.Point(94, 59);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(340, 23);
            this.dtpHasta.TabIndex = 20;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpDesde.Location = new System.Drawing.Point(94, 21);
            this.dtpDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(340, 23);
            this.dtpDesde.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10F);
            this.label14.Location = new System.Drawing.Point(17, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Hasta:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10F);
            this.label16.Location = new System.Drawing.Point(17, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "Desde:";
            // 
            // txtConsultar
            // 
            this.txtConsultar.Font = new System.Drawing.Font("Arial", 10F);
            this.txtConsultar.Location = new System.Drawing.Point(568, 50);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(355, 23);
            this.txtConsultar.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(487, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Consultar:";
            // 
            // dgvInformeCompras
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInformeCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInformeCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformeCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Factura,
            this.Fecha,
            this.rucProveedor,
            this.Proveedor,
            this.Iva,
            this.Ice,
            this.Irbp,
            this.Subtotal0,
            this.Subtotal12,
            this.Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInformeCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInformeCompras.Location = new System.Drawing.Point(14, 126);
            this.dgvInformeCompras.Name = "dgvInformeCompras";
            this.dgvInformeCompras.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInformeCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInformeCompras.RowHeadersVisible = false;
            this.dgvInformeCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInformeCompras.Size = new System.Drawing.Size(1039, 442);
            this.dgvInformeCompras.TabIndex = 21;
            // 
            // Factura
            // 
            this.Factura.FillWeight = 160.7917F;
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.Width = 130;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 82.69291F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 65;
            // 
            // rucProveedor
            // 
            this.rucProveedor.HeaderText = "RUC";
            this.rucProveedor.Name = "rucProveedor";
            this.rucProveedor.ReadOnly = true;
            this.rucProveedor.Width = 120;
            // 
            // Proveedor
            // 
            this.Proveedor.FillWeight = 82.69291F;
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 265;
            // 
            // Iva
            // 
            this.Iva.FillWeight = 82.69291F;
            this.Iva.HeaderText = "Iva";
            this.Iva.Name = "Iva";
            this.Iva.ReadOnly = true;
            this.Iva.Width = 90;
            // 
            // Ice
            // 
            this.Ice.HeaderText = "ICE";
            this.Ice.Name = "Ice";
            this.Ice.ReadOnly = true;
            this.Ice.Width = 45;
            // 
            // Irbp
            // 
            this.Irbp.HeaderText = "IRBP";
            this.Irbp.Name = "Irbp";
            this.Irbp.ReadOnly = true;
            this.Irbp.Width = 45;
            // 
            // Subtotal0
            // 
            this.Subtotal0.FillWeight = 82.69291F;
            this.Subtotal0.HeaderText = "Sub 0%";
            this.Subtotal0.Name = "Subtotal0";
            this.Subtotal0.ReadOnly = true;
            this.Subtotal0.Width = 85;
            // 
            // Subtotal12
            // 
            this.Subtotal12.FillWeight = 82.69291F;
            this.Subtotal12.HeaderText = "Sub12%";
            this.Subtotal12.Name = "Subtotal12";
            this.Subtotal12.ReadOnly = true;
            this.Subtotal12.Width = 85;
            // 
            // Total
            // 
            this.Total.FillWeight = 82.69291F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Image = global::Comisariato.Properties.Resources.Excel_2013_24px_1180012_easyicon_net;
            this.BtnExportarExcel.Location = new System.Drawing.Point(995, 91);
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.Size = new System.Drawing.Size(36, 29);
            this.BtnExportarExcel.TabIndex = 24;
            this.BtnExportarExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExportarExcel.UseVisualStyleBackColor = true;
            this.BtnExportarExcel.Click += new System.EventHandler(this.BtnExportarExcel_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnConsultar.Location = new System.Drawing.Point(929, 50);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(114, 25);
            this.btnConsultar.TabIndex = 25;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FrmInformesCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1065, 580);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.BtnExportarExcel);
            this.Controls.Add(this.dgvInformeCompras);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmInformesCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Informes de Compras";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvInformeCompras;
        private System.Windows.Forms.Button BtnExportarExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn rucProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Irbp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnConsultar;
    }
}