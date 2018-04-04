namespace Comisariato.Formularios.SRI
{
    partial class FrmDeclaracionSRI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGenerarKardex = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbReporteVentas = new System.Windows.Forms.GroupBox();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            this.txtIvaVenta = new System.Windows.Forms.TextBox();
            this.txtGravadoVenta = new System.Windows.Forms.TextBox();
            this.txtExentoVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbReporteCompras = new System.Windows.Forms.GroupBox();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.txtIrbpCompra = new System.Windows.Forms.TextBox();
            this.txtIvaCompra = new System.Windows.Forms.TextBox();
            this.txtIceCompra = new System.Windows.Forms.TextBox();
            this.txtGravadoCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExentoCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbReporteRetenciones = new System.Windows.Forms.GroupBox();
            this.dgvRetencion = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbReporteNotaCredito = new System.Windows.Forms.GroupBox();
            this.txtTotalNC = new System.Windows.Forms.TextBox();
            this.txtIvaNC = new System.Windows.Forms.TextBox();
            this.txtGravadoNC = new System.Windows.Forms.TextBox();
            this.txtExentoNC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gbReporteVentas.SuspendLayout();
            this.gbReporteCompras.SuspendLayout();
            this.gbReporteRetenciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetencion)).BeginInit();
            this.gbReporteNotaCredito.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarKardex
            // 
            this.btnGenerarKardex.Font = new System.Drawing.Font("Arial", 10F);
            this.btnGenerarKardex.ForeColor = System.Drawing.Color.Teal;
            this.btnGenerarKardex.Location = new System.Drawing.Point(404, 26);
            this.btnGenerarKardex.Name = "btnGenerarKardex";
            this.btnGenerarKardex.Size = new System.Drawing.Size(133, 56);
            this.btnGenerarKardex.TabIndex = 15;
            this.btnGenerarKardex.Text = "Consultar";
            this.btnGenerarKardex.UseVisualStyleBackColor = true;
            this.btnGenerarKardex.Click += new System.EventHandler(this.btnGenerarKardex_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpHasta.Location = new System.Drawing.Point(128, 64);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(253, 23);
            this.dtpHasta.TabIndex = 11;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpDesde.Location = new System.Drawing.Point(128, 23);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(253, 23);
            this.dtpDesde.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha Desde:";
            // 
            // gbReporteVentas
            // 
            this.gbReporteVentas.Controls.Add(this.txtTotalVenta);
            this.gbReporteVentas.Controls.Add(this.txtIvaVenta);
            this.gbReporteVentas.Controls.Add(this.txtGravadoVenta);
            this.gbReporteVentas.Controls.Add(this.txtExentoVenta);
            this.gbReporteVentas.Controls.Add(this.label6);
            this.gbReporteVentas.Controls.Add(this.label3);
            this.gbReporteVentas.Controls.Add(this.label2);
            this.gbReporteVentas.Controls.Add(this.label1);
            this.gbReporteVentas.Font = new System.Drawing.Font("Arial", 10F);
            this.gbReporteVentas.ForeColor = System.Drawing.Color.Teal;
            this.gbReporteVentas.Location = new System.Drawing.Point(15, 93);
            this.gbReporteVentas.Name = "gbReporteVentas";
            this.gbReporteVentas.Size = new System.Drawing.Size(405, 85);
            this.gbReporteVentas.TabIndex = 16;
            this.gbReporteVentas.TabStop = false;
            this.gbReporteVentas.Text = "Reporte de Ventas";
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.Location = new System.Drawing.Point(269, 49);
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.ReadOnly = true;
            this.txtTotalVenta.Size = new System.Drawing.Size(127, 23);
            this.txtTotalVenta.TabIndex = 7;
            // 
            // txtIvaVenta
            // 
            this.txtIvaVenta.Location = new System.Drawing.Point(269, 20);
            this.txtIvaVenta.Name = "txtIvaVenta";
            this.txtIvaVenta.ReadOnly = true;
            this.txtIvaVenta.Size = new System.Drawing.Size(127, 23);
            this.txtIvaVenta.TabIndex = 6;
            // 
            // txtGravadoVenta
            // 
            this.txtGravadoVenta.Location = new System.Drawing.Point(84, 49);
            this.txtGravadoVenta.Name = "txtGravadoVenta";
            this.txtGravadoVenta.ReadOnly = true;
            this.txtGravadoVenta.Size = new System.Drawing.Size(127, 23);
            this.txtGravadoVenta.TabIndex = 5;
            // 
            // txtExentoVenta
            // 
            this.txtExentoVenta.Location = new System.Drawing.Point(84, 20);
            this.txtExentoVenta.Name = "txtExentoVenta";
            this.txtExentoVenta.ReadOnly = true;
            this.txtExentoVenta.Size = new System.Drawing.Size(127, 23);
            this.txtExentoVenta.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Iva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gravado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exento:";
            // 
            // gbReporteCompras
            // 
            this.gbReporteCompras.Controls.Add(this.txtTotalCompra);
            this.gbReporteCompras.Controls.Add(this.txtIrbpCompra);
            this.gbReporteCompras.Controls.Add(this.txtIvaCompra);
            this.gbReporteCompras.Controls.Add(this.txtIceCompra);
            this.gbReporteCompras.Controls.Add(this.txtGravadoCompra);
            this.gbReporteCompras.Controls.Add(this.label8);
            this.gbReporteCompras.Controls.Add(this.txtExentoCompra);
            this.gbReporteCompras.Controls.Add(this.label7);
            this.gbReporteCompras.Controls.Add(this.label12);
            this.gbReporteCompras.Controls.Add(this.label10);
            this.gbReporteCompras.Controls.Add(this.label11);
            this.gbReporteCompras.Controls.Add(this.label9);
            this.gbReporteCompras.Font = new System.Drawing.Font("Arial", 10F);
            this.gbReporteCompras.ForeColor = System.Drawing.Color.Teal;
            this.gbReporteCompras.Location = new System.Drawing.Point(15, 193);
            this.gbReporteCompras.Name = "gbReporteCompras";
            this.gbReporteCompras.Size = new System.Drawing.Size(405, 146);
            this.gbReporteCompras.TabIndex = 16;
            this.gbReporteCompras.TabStop = false;
            this.gbReporteCompras.Text = "Reporte de Compras";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Location = new System.Drawing.Point(84, 110);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.ReadOnly = true;
            this.txtTotalCompra.Size = new System.Drawing.Size(127, 23);
            this.txtTotalCompra.TabIndex = 7;
            // 
            // txtIrbpCompra
            // 
            this.txtIrbpCompra.Location = new System.Drawing.Point(269, 50);
            this.txtIrbpCompra.Name = "txtIrbpCompra";
            this.txtIrbpCompra.ReadOnly = true;
            this.txtIrbpCompra.Size = new System.Drawing.Size(127, 23);
            this.txtIrbpCompra.TabIndex = 3;
            // 
            // txtIvaCompra
            // 
            this.txtIvaCompra.Location = new System.Drawing.Point(84, 80);
            this.txtIvaCompra.Name = "txtIvaCompra";
            this.txtIvaCompra.ReadOnly = true;
            this.txtIvaCompra.Size = new System.Drawing.Size(127, 23);
            this.txtIvaCompra.TabIndex = 6;
            // 
            // txtIceCompra
            // 
            this.txtIceCompra.Location = new System.Drawing.Point(269, 20);
            this.txtIceCompra.Name = "txtIceCompra";
            this.txtIceCompra.ReadOnly = true;
            this.txtIceCompra.Size = new System.Drawing.Size(127, 23);
            this.txtIceCompra.TabIndex = 2;
            // 
            // txtGravadoCompra
            // 
            this.txtGravadoCompra.Location = new System.Drawing.Point(84, 50);
            this.txtGravadoCompra.Name = "txtGravadoCompra";
            this.txtGravadoCompra.ReadOnly = true;
            this.txtGravadoCompra.Size = new System.Drawing.Size(127, 23);
            this.txtGravadoCompra.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "IRBP:";
            // 
            // txtExentoCompra
            // 
            this.txtExentoCompra.Location = new System.Drawing.Point(84, 20);
            this.txtExentoCompra.Name = "txtExentoCompra";
            this.txtExentoCompra.ReadOnly = true;
            this.txtExentoCompra.Size = new System.Drawing.Size(127, 23);
            this.txtExentoCompra.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ice:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Gravado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Iva:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Exento:";
            // 
            // gbReporteRetenciones
            // 
            this.gbReporteRetenciones.Controls.Add(this.dgvRetencion);
            this.gbReporteRetenciones.Font = new System.Drawing.Font("Arial", 10F);
            this.gbReporteRetenciones.ForeColor = System.Drawing.Color.Teal;
            this.gbReporteRetenciones.Location = new System.Drawing.Point(477, 93);
            this.gbReporteRetenciones.Name = "gbReporteRetenciones";
            this.gbReporteRetenciones.Size = new System.Drawing.Size(532, 246);
            this.gbReporteRetenciones.TabIndex = 16;
            this.gbReporteRetenciones.TabStop = false;
            this.gbReporteRetenciones.Text = "Reporte Retenciones";
            // 
            // dgvRetencion
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRetencion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetencion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Porcentaje,
            this.Total,
            this.id});
            this.dgvRetencion.Location = new System.Drawing.Point(9, 24);
            this.dgvRetencion.Name = "dgvRetencion";
            this.dgvRetencion.RowHeadersVisible = false;
            this.dgvRetencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRetencion.Size = new System.Drawing.Size(508, 209);
            this.dgvRetencion.TabIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 335;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "%";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            this.Porcentaje.Width = 50;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // gbReporteNotaCredito
            // 
            this.gbReporteNotaCredito.Controls.Add(this.txtTotalNC);
            this.gbReporteNotaCredito.Controls.Add(this.txtIvaNC);
            this.gbReporteNotaCredito.Controls.Add(this.txtGravadoNC);
            this.gbReporteNotaCredito.Controls.Add(this.txtExentoNC);
            this.gbReporteNotaCredito.Controls.Add(this.label13);
            this.gbReporteNotaCredito.Controls.Add(this.label14);
            this.gbReporteNotaCredito.Controls.Add(this.label15);
            this.gbReporteNotaCredito.Controls.Add(this.label16);
            this.gbReporteNotaCredito.Font = new System.Drawing.Font("Arial", 10F);
            this.gbReporteNotaCredito.ForeColor = System.Drawing.Color.Teal;
            this.gbReporteNotaCredito.Location = new System.Drawing.Point(15, 356);
            this.gbReporteNotaCredito.Name = "gbReporteNotaCredito";
            this.gbReporteNotaCredito.Size = new System.Drawing.Size(1025, 66);
            this.gbReporteNotaCredito.TabIndex = 16;
            this.gbReporteNotaCredito.TabStop = false;
            this.gbReporteNotaCredito.Text = "Reporte de Nota de Crédito";
            // 
            // txtTotalNC
            // 
            this.txtTotalNC.Location = new System.Drawing.Point(819, 23);
            this.txtTotalNC.Name = "txtTotalNC";
            this.txtTotalNC.ReadOnly = true;
            this.txtTotalNC.Size = new System.Drawing.Size(127, 23);
            this.txtTotalNC.TabIndex = 15;
            // 
            // txtIvaNC
            // 
            this.txtIvaNC.Location = new System.Drawing.Point(603, 23);
            this.txtIvaNC.Name = "txtIvaNC";
            this.txtIvaNC.ReadOnly = true;
            this.txtIvaNC.Size = new System.Drawing.Size(127, 23);
            this.txtIvaNC.TabIndex = 14;
            // 
            // txtGravadoNC
            // 
            this.txtGravadoNC.Location = new System.Drawing.Point(384, 23);
            this.txtGravadoNC.Name = "txtGravadoNC";
            this.txtGravadoNC.ReadOnly = true;
            this.txtGravadoNC.Size = new System.Drawing.Size(127, 23);
            this.txtGravadoNC.TabIndex = 13;
            // 
            // txtExentoNC
            // 
            this.txtExentoNC.Location = new System.Drawing.Point(156, 23);
            this.txtExentoNC.Name = "txtExentoNC";
            this.txtExentoNC.ReadOnly = true;
            this.txtExentoNC.Size = new System.Drawing.Size(127, 23);
            this.txtExentoNC.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(767, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Total:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(560, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Iva:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(306, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "Gravado:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(78, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Exento:";
            // 
            // FrmDeclaracionSRI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1065, 438);
            this.Controls.Add(this.gbReporteNotaCredito);
            this.Controls.Add(this.gbReporteRetenciones);
            this.Controls.Add(this.gbReporteCompras);
            this.Controls.Add(this.gbReporteVentas);
            this.Controls.Add(this.btnGenerarKardex);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmDeclaracionSRI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reporte para Declaracion SRI";
            this.Load += new System.EventHandler(this.FrmDeclaracionSRI_Load);
            this.gbReporteVentas.ResumeLayout(false);
            this.gbReporteVentas.PerformLayout();
            this.gbReporteCompras.ResumeLayout(false);
            this.gbReporteCompras.PerformLayout();
            this.gbReporteRetenciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetencion)).EndInit();
            this.gbReporteNotaCredito.ResumeLayout(false);
            this.gbReporteNotaCredito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarKardex;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbReporteVentas;
        private System.Windows.Forms.TextBox txtTotalVenta;
        private System.Windows.Forms.TextBox txtIvaVenta;
        private System.Windows.Forms.TextBox txtGravadoVenta;
        private System.Windows.Forms.TextBox txtExentoVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbReporteCompras;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.TextBox txtIrbpCompra;
        private System.Windows.Forms.TextBox txtIvaCompra;
        private System.Windows.Forms.TextBox txtIceCompra;
        private System.Windows.Forms.TextBox txtGravadoCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExentoCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbReporteRetenciones;
        private System.Windows.Forms.DataGridView dgvRetencion;
        private System.Windows.Forms.GroupBox gbReporteNotaCredito;
        private System.Windows.Forms.TextBox txtTotalNC;
        private System.Windows.Forms.TextBox txtIvaNC;
        private System.Windows.Forms.TextBox txtGravadoNC;
        private System.Windows.Forms.TextBox txtExentoNC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}