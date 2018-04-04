namespace Comisariato.Formularios.Informes
{
    partial class FrmInformeVentas
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
            this.dgvInformeVentas = new System.Windows.Forms.DataGridView();
            this.BtnExportarExcel = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeVentas)).BeginInit();
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
            this.txtConsultar.Size = new System.Drawing.Size(340, 23);
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
            // dgvInformeVentas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInformeVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInformeVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformeVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sucursal,
            this.Caja,
            this.NFactura,
            this.Fecha,
            this.Usuario,
            this.identificacion,
            this.Cliente,
            this.Iva,
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
            this.dgvInformeVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInformeVentas.Location = new System.Drawing.Point(14, 126);
            this.dgvInformeVentas.Name = "dgvInformeVentas";
            this.dgvInformeVentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInformeVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInformeVentas.RowHeadersVisible = false;
            this.dgvInformeVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInformeVentas.Size = new System.Drawing.Size(1039, 442);
            this.dgvInformeVentas.TabIndex = 21;
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Image = global::Comisariato.Properties.Resources.Excel_2013_24px_1180012_easyicon_net;
            this.BtnExportarExcel.Location = new System.Drawing.Point(1017, 91);
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.Size = new System.Drawing.Size(36, 29);
            this.BtnExportarExcel.TabIndex = 23;
            this.BtnExportarExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExportarExcel.UseVisualStyleBackColor = true;
            this.BtnExportarExcel.Click += new System.EventHandler(this.BtnExportarExcel_Click_1);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnConsultar.Location = new System.Drawing.Point(924, 49);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(114, 25);
            this.btnConsultar.TabIndex = 26;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // Sucursal
            // 
            this.Sucursal.FillWeight = 160.7917F;
            this.Sucursal.HeaderText = "Scl";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            this.Sucursal.Width = 35;
            // 
            // Caja
            // 
            this.Caja.FillWeight = 177.6649F;
            this.Caja.HeaderText = "Caja";
            this.Caja.Name = "Caja";
            this.Caja.ReadOnly = true;
            this.Caja.Width = 35;
            // 
            // NFactura
            // 
            this.NFactura.FillWeight = 82.69291F;
            this.NFactura.HeaderText = "N°Factura";
            this.NFactura.Name = "NFactura";
            this.NFactura.ReadOnly = true;
            this.NFactura.Width = 85;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 82.69291F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 80;
            // 
            // Usuario
            // 
            this.Usuario.FillWeight = 82.69291F;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 85;
            // 
            // identificacion
            // 
            this.identificacion.HeaderText = "Identificación";
            this.identificacion.Name = "identificacion";
            this.identificacion.ReadOnly = true;
            this.identificacion.Width = 125;
            // 
            // Cliente
            // 
            this.Cliente.FillWeight = 82.69291F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 225;
            // 
            // Iva
            // 
            this.Iva.FillWeight = 82.69291F;
            this.Iva.HeaderText = "Iva";
            this.Iva.Name = "Iva";
            this.Iva.ReadOnly = true;
            this.Iva.Width = 80;
            // 
            // Subtotal0
            // 
            this.Subtotal0.FillWeight = 82.69291F;
            this.Subtotal0.HeaderText = "Sub 0%";
            this.Subtotal0.Name = "Subtotal0";
            this.Subtotal0.ReadOnly = true;
            this.Subtotal0.Width = 86;
            // 
            // Subtotal12
            // 
            this.Subtotal12.FillWeight = 82.69291F;
            this.Subtotal12.HeaderText = "Sub 12%";
            this.Subtotal12.Name = "Subtotal12";
            this.Subtotal12.ReadOnly = true;
            this.Subtotal12.Width = 90;
            // 
            // Total
            // 
            this.Total.FillWeight = 82.69291F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 85;
            // 
            // FrmInformeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1065, 580);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.BtnExportarExcel);
            this.Controls.Add(this.dgvInformeVentas);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmInformeVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Informes de Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeVentas)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvInformeVentas;
        private System.Windows.Forms.Button BtnExportarExcel;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn NFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}