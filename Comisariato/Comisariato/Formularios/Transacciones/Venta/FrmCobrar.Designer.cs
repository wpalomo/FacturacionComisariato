namespace Comisariato.Formularios.Transacciones
{
    partial class FrmCobrar
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
            this.ckbEfectivo = new System.Windows.Forms.CheckBox();
            this.ckbCheque = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbTarjeta = new System.Windows.Forms.CheckBox();
            this.gbDinero = new System.Windows.Forms.GroupBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecibido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCheque = new System.Windows.Forms.DataGridView();
            this.NCheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROPIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTarjeta = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbDinero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbEfectivo
            // 
            this.ckbEfectivo.AutoSize = true;
            this.ckbEfectivo.Checked = true;
            this.ckbEfectivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbEfectivo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEfectivo.Location = new System.Drawing.Point(65, 25);
            this.ckbEfectivo.Name = "ckbEfectivo";
            this.ckbEfectivo.Size = new System.Drawing.Size(93, 23);
            this.ckbEfectivo.TabIndex = 5;
            this.ckbEfectivo.Text = "Efectivo";
            this.ckbEfectivo.UseVisualStyleBackColor = true;
            this.ckbEfectivo.CheckedChanged += new System.EventHandler(this.ckbEfectivo_CheckedChanged);
            // 
            // ckbCheque
            // 
            this.ckbCheque.AutoSize = true;
            this.ckbCheque.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCheque.Location = new System.Drawing.Point(209, 25);
            this.ckbCheque.Name = "ckbCheque";
            this.ckbCheque.Size = new System.Drawing.Size(89, 23);
            this.ckbCheque.TabIndex = 6;
            this.ckbCheque.Text = "Cheque";
            this.ckbCheque.UseVisualStyleBackColor = true;
            this.ckbCheque.CheckedChanged += new System.EventHandler(this.ckbCheque_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbTarjeta);
            this.groupBox1.Controls.Add(this.ckbCheque);
            this.groupBox1.Controls.Add(this.ckbEfectivo);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pago";
            // 
            // ckbTarjeta
            // 
            this.ckbTarjeta.AutoSize = true;
            this.ckbTarjeta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTarjeta.Location = new System.Drawing.Point(344, 25);
            this.ckbTarjeta.Name = "ckbTarjeta";
            this.ckbTarjeta.Size = new System.Drawing.Size(89, 23);
            this.ckbTarjeta.TabIndex = 7;
            this.ckbTarjeta.Text = "Tarjeta";
            this.ckbTarjeta.UseVisualStyleBackColor = true;
            this.ckbTarjeta.CheckedChanged += new System.EventHandler(this.ckbTarjeta_CheckedChanged);
            // 
            // gbDinero
            // 
            this.gbDinero.BackColor = System.Drawing.Color.Linen;
            this.gbDinero.Controls.Add(this.txtCambio);
            this.gbDinero.Controls.Add(this.label6);
            this.gbDinero.Controls.Add(this.txtRecibido);
            this.gbDinero.Controls.Add(this.label3);
            this.gbDinero.Controls.Add(this.txtTotalPagar);
            this.gbDinero.Controls.Add(this.label4);
            this.gbDinero.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDinero.ForeColor = System.Drawing.Color.Teal;
            this.gbDinero.Location = new System.Drawing.Point(21, 92);
            this.gbDinero.Name = "gbDinero";
            this.gbDinero.Size = new System.Drawing.Size(613, 125);
            this.gbDinero.TabIndex = 1;
            this.gbDinero.TabStop = false;
            this.gbDinero.Text = "Dinero";
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.ForeColor = System.Drawing.Color.Crimson;
            this.txtCambio.Location = new System.Drawing.Point(429, 50);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(161, 53);
            this.txtCambio.TabIndex = 8;
            this.txtCambio.Text = "0.00";
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "CAMBIO";
            // 
            // txtRecibido
            // 
            this.txtRecibido.Enabled = false;
            this.txtRecibido.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibido.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtRecibido.Location = new System.Drawing.Point(228, 51);
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.Size = new System.Drawing.Size(161, 53);
            this.txtRecibido.TabIndex = 2;
            this.txtRecibido.Text = "0.00";
            this.txtRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecibido.TextChanged += new System.EventHandler(this.txtRecibido_TextChanged);
            this.txtRecibido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecibido_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "RECIBIDO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtTotalPagar.Location = new System.Drawing.Point(28, 50);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(161, 53);
            this.txtTotalPagar.TabIndex = 4;
            this.txtTotalPagar.Text = "0.00";
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOTAL";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvCheque
            // 
            this.dgvCheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NCheque,
            this.CUENTA,
            this.BANCO,
            this.FECHA,
            this.PROPIETARIO,
            this.MONTO});
            this.dgvCheque.Location = new System.Drawing.Point(21, 282);
            this.dgvCheque.Name = "dgvCheque";
            this.dgvCheque.Size = new System.Drawing.Size(625, 91);
            this.dgvCheque.TabIndex = 3;
            this.dgvCheque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheque_CellClick);
            this.dgvCheque.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheque_CellEndEdit);
            this.dgvCheque.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCheque_EditingControlShowing);
            this.dgvCheque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCheque_KeyDown);
            this.dgvCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCheque_KeyPress);
            this.dgvCheque.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCheque_KeyUp);
            // 
            // NCheque
            // 
            this.NCheque.HeaderText = "Nº. CHEQUE";
            this.NCheque.Name = "NCheque";
            this.NCheque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CUENTA
            // 
            this.CUENTA.HeaderText = "Nº. CUENTA";
            this.CUENTA.Name = "CUENTA";
            this.CUENTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BANCO
            // 
            this.BANCO.HeaderText = "BANCO";
            this.BANCO.Name = "BANCO";
            this.BANCO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BANCO.Width = 80;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PROPIETARIO
            // 
            this.PROPIETARIO.HeaderText = "PROPIETARIO";
            this.PROPIETARIO.Name = "PROPIETARIO";
            this.PROPIETARIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MONTO
            // 
            this.MONTO.HeaderText = "MONTO";
            this.MONTO.Name = "MONTO";
            this.MONTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTarjeta
            // 
            this.dgvTarjeta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.TIPO});
            this.dgvTarjeta.Location = new System.Drawing.Point(21, 390);
            this.dgvTarjeta.Name = "dgvTarjeta";
            this.dgvTarjeta.Size = new System.Drawing.Size(464, 91);
            this.dgvTarjeta.TabIndex = 4;
            this.dgvTarjeta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarjeta_CellClick);
            this.dgvTarjeta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarjeta_CellEndEdit);
            this.dgvTarjeta.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvTarjeta_EditingControlShowing);
            this.dgvTarjeta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTarjeta_KeyDown);
            this.dgvTarjeta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvTarjeta_KeyUp);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nº. TARJETA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "FECHA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "MONTO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO TARJETA";
            this.TIPO.Name = "TIPO";
            this.TIPO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Comisariato.Properties.Resources.impresora2;
            this.btnImprimir.Location = new System.Drawing.Point(491, 411);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(164, 120);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCheque
            // 
            this.txtCheque.Enabled = false;
            this.txtCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheque.Location = new System.Drawing.Point(546, 379);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(100, 26);
            this.txtCheque.TabIndex = 10;
            // 
            // txtCredito
            // 
            this.txtCredito.Enabled = false;
            this.txtCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.Location = new System.Drawing.Point(272, 487);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(100, 26);
            this.txtCredito.TabIndex = 11;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.Location = new System.Drawing.Point(450, 223);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(161, 53);
            this.txtEfectivo.TabIndex = 1;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Efectivo";
            // 
            // FrmCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(687, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.txtCheque);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvTarjeta);
            this.Controls.Add(this.dgvCheque);
            this.Controls.Add(this.gbDinero);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Pago";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCobrar_FormClosed);
            this.Load += new System.EventHandler(this.FrmCobrar_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCobrar_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDinero.ResumeLayout(false);
            this.gbDinero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ckbEfectivo;
        private System.Windows.Forms.CheckBox ckbCheque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbDinero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRecibido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.DataGridView dgvCheque;
        private System.Windows.Forms.DataGridView dgvTarjeta;
        private System.Windows.Forms.CheckBox ckbTarjeta;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROPIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
    }
}