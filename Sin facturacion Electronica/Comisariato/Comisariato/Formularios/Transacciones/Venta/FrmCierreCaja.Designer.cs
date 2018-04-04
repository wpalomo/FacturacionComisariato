namespace Comisariato.Formularios.Transacciones.Venta
{
    partial class FrmCierreCaja
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
            this.gbCheque = new System.Windows.Forms.GroupBox();
            this.txtTotalCheque = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvCheque = new System.Windows.Forms.DataGridView();
            this.NCheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROPIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalRecaudado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSalirCompra = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.gbAvance = new System.Windows.Forms.GroupBox();
            this.txtCantidadAvances = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAvances = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBillestes1 = new System.Windows.Forms.TextBox();
            this.txtBillestes5 = new System.Windows.Forms.TextBox();
            this.txtBillestes10 = new System.Windows.Forms.TextBox();
            this.txtBillestes20 = new System.Windows.Forms.TextBox();
            this.txtBillestes50 = new System.Windows.Forms.TextBox();
            this.txtBillestes100 = new System.Windows.Forms.TextBox();
            this.txtMonedas1 = new System.Windows.Forms.TextBox();
            this.txtMonedas5 = new System.Windows.Forms.TextBox();
            this.txtMonedas10 = new System.Windows.Forms.TextBox();
            this.txtMonedas25 = new System.Windows.Forms.TextBox();
            this.txtMonedas50 = new System.Windows.Forms.TextBox();
            this.txtMonedas1Dolar = new System.Windows.Forms.TextBox();
            this.txtTotalBillestes = new System.Windows.Forms.TextBox();
            this.txtTotalMonedas = new System.Windows.Forms.TextBox();
            this.gbEfectivo = new System.Windows.Forms.GroupBox();
            this.gbCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheque)).BeginInit();
            this.gbAvance.SuspendLayout();
            this.gbEfectivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCheque
            // 
            this.gbCheque.Controls.Add(this.txtTotalCheque);
            this.gbCheque.Controls.Add(this.label8);
            this.gbCheque.Controls.Add(this.dgvCheque);
            this.gbCheque.Font = new System.Drawing.Font("Arial", 9F);
            this.gbCheque.ForeColor = System.Drawing.Color.Teal;
            this.gbCheque.Location = new System.Drawing.Point(12, 315);
            this.gbCheque.Name = "gbCheque";
            this.gbCheque.Size = new System.Drawing.Size(534, 188);
            this.gbCheque.TabIndex = 0;
            this.gbCheque.TabStop = false;
            this.gbCheque.Text = "Cheques";
            // 
            // txtTotalCheque
            // 
            this.txtTotalCheque.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCheque.Location = new System.Drawing.Point(384, 150);
            this.txtTotalCheque.Name = "txtTotalCheque";
            this.txtTotalCheque.ReadOnly = true;
            this.txtTotalCheque.Size = new System.Drawing.Size(124, 29);
            this.txtTotalCheque.TabIndex = 27;
            this.txtTotalCheque.Text = "0.00";
            this.txtTotalCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Total Cheques:";
            // 
            // dgvCheque
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NCheque,
            this.BANCO,
            this.PROPIETARIO,
            this.MONTO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheque.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheque.Location = new System.Drawing.Point(6, 28);
            this.dgvCheque.Name = "dgvCheque";
            this.dgvCheque.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheque.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCheque.RowHeadersVisible = false;
            this.dgvCheque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheque.Size = new System.Drawing.Size(522, 112);
            this.dgvCheque.TabIndex = 4;
            // 
            // NCheque
            // 
            this.NCheque.HeaderText = "Nº. Cheque";
            this.NCheque.Name = "NCheque";
            this.NCheque.ReadOnly = true;
            this.NCheque.Width = 150;
            // 
            // BANCO
            // 
            this.BANCO.HeaderText = "Banco";
            this.BANCO.Name = "BANCO";
            this.BANCO.ReadOnly = true;
            this.BANCO.Width = 150;
            // 
            // PROPIETARIO
            // 
            this.PROPIETARIO.HeaderText = "Propietario";
            this.PROPIETARIO.Name = "PROPIETARIO";
            this.PROPIETARIO.ReadOnly = true;
            // 
            // MONTO
            // 
            this.MONTO.HeaderText = "Monto";
            this.MONTO.Name = "MONTO";
            this.MONTO.ReadOnly = true;
            // 
            // txtTotalRecaudado
            // 
            this.txtTotalRecaudado.Font = new System.Drawing.Font("Arial", 16F);
            this.txtTotalRecaudado.Location = new System.Drawing.Point(743, 131);
            this.txtTotalRecaudado.Name = "txtTotalRecaudado";
            this.txtTotalRecaudado.ReadOnly = true;
            this.txtTotalRecaudado.Size = new System.Drawing.Size(153, 32);
            this.txtTotalRecaudado.TabIndex = 31;
            this.txtTotalRecaudado.Text = "0.00";
            this.txtTotalRecaudado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(557, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 19);
            this.label15.TabIndex = 30;
            this.label15.Text = "Total Recaudado:";
            // 
            // btnSalirCompra
            // 
            this.btnSalirCompra.Image = global::Comisariato.Properties.Resources.salir2;
            this.btnSalirCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirCompra.Location = new System.Drawing.Point(800, 450);
            this.btnSalirCompra.Name = "btnSalirCompra";
            this.btnSalirCompra.Size = new System.Drawing.Size(96, 53);
            this.btnSalirCompra.TabIndex = 34;
            this.btnSalirCompra.Text = "Salir";
            this.btnSalirCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirCompra.UseVisualStyleBackColor = true;
            this.btnSalirCompra.Click += new System.EventHandler(this.btnSalirCompra_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = global::Comisariato.Properties.Resources.guardar11;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(575, 181);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(135, 77);
            this.BtnGuardar.TabIndex = 32;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // gbAvance
            // 
            this.gbAvance.Controls.Add(this.txtCantidadAvances);
            this.gbAvance.Controls.Add(this.label19);
            this.gbAvance.Controls.Add(this.txtAvances);
            this.gbAvance.Controls.Add(this.label16);
            this.gbAvance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAvance.ForeColor = System.Drawing.Color.Teal;
            this.gbAvance.Location = new System.Drawing.Point(606, 12);
            this.gbAvance.Name = "gbAvance";
            this.gbAvance.Size = new System.Drawing.Size(272, 103);
            this.gbAvance.TabIndex = 28;
            this.gbAvance.TabStop = false;
            this.gbAvance.Text = "Avances";
            // 
            // txtCantidadAvances
            // 
            this.txtCantidadAvances.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadAvances.Location = new System.Drawing.Point(131, 24);
            this.txtCantidadAvances.Name = "txtCantidadAvances";
            this.txtCantidadAvances.ReadOnly = true;
            this.txtCantidadAvances.Size = new System.Drawing.Size(124, 22);
            this.txtCantidadAvances.TabIndex = 29;
            this.txtCantidadAvances.Text = "0";
            this.txtCantidadAvances.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 16);
            this.label19.TabIndex = 28;
            this.label19.Text = "Cantidad Avances:";
            // 
            // txtAvances
            // 
            this.txtAvances.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvances.Location = new System.Drawing.Point(131, 55);
            this.txtAvances.Name = "txtAvances";
            this.txtAvances.ReadOnly = true;
            this.txtAvances.Size = new System.Drawing.Size(124, 29);
            this.txtAvances.TabIndex = 27;
            this.txtAvances.Text = "0.00";
            this.txtAvances.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "Total Avances:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Image = global::Comisariato.Properties.Resources.limpiar;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(743, 183);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(135, 77);
            this.BtnLimpiar.TabIndex = 35;
            this.BtnLimpiar.Text = "&Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Billetes $1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Billetes $5:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Billetes $10:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Billetes $20:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Billetes $50:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Billetes $100:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Billetes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(246, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Monedas 1 ctvs:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(246, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Monedas 25 ctvs:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(246, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Monedas 50 ctvs:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(246, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Monedas 1 dolar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(246, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Total Monedas:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(246, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 16);
            this.label17.TabIndex = 16;
            this.label17.Text = "Monedas 5 ctvs:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(246, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 16);
            this.label18.TabIndex = 17;
            this.label18.Text = "Monedas 10 ctvs:";
            // 
            // txtBillestes1
            // 
            this.txtBillestes1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillestes1.Location = new System.Drawing.Point(114, 24);
            this.txtBillestes1.Name = "txtBillestes1";
            this.txtBillestes1.Size = new System.Drawing.Size(124, 22);
            this.txtBillestes1.TabIndex = 1;
            this.txtBillestes1.Text = "0";
            this.txtBillestes1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBillestes1.Click += new System.EventHandler(this.txtBillestes1_Click);
            this.txtBillestes1.Enter += new System.EventHandler(this.txtBillestes1_Enter);
            this.txtBillestes1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBillestes1_KeyDown);
            this.txtBillestes1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillestes1_KeyPress);
            // 
            // txtBillestes5
            // 
            this.txtBillestes5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillestes5.Location = new System.Drawing.Point(114, 60);
            this.txtBillestes5.Name = "txtBillestes5";
            this.txtBillestes5.Size = new System.Drawing.Size(124, 22);
            this.txtBillestes5.TabIndex = 2;
            this.txtBillestes5.Text = "0";
            this.txtBillestes5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBillestes5.Click += new System.EventHandler(this.txtBillestes5_Click);
            this.txtBillestes5.Enter += new System.EventHandler(this.txtBillestes5_Enter);
            this.txtBillestes5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBillestes1_KeyDown);
            this.txtBillestes5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillestes1_KeyPress);
            // 
            // txtBillestes10
            // 
            this.txtBillestes10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillestes10.Location = new System.Drawing.Point(114, 96);
            this.txtBillestes10.Name = "txtBillestes10";
            this.txtBillestes10.Size = new System.Drawing.Size(124, 22);
            this.txtBillestes10.TabIndex = 3;
            this.txtBillestes10.Text = "0";
            this.txtBillestes10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBillestes10.Click += new System.EventHandler(this.txtBillestes10_Click);
            this.txtBillestes10.Enter += new System.EventHandler(this.txtBillestes10_Enter);
            this.txtBillestes10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBillestes1_KeyDown);
            this.txtBillestes10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillestes1_KeyPress);
            // 
            // txtBillestes20
            // 
            this.txtBillestes20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillestes20.Location = new System.Drawing.Point(114, 132);
            this.txtBillestes20.Name = "txtBillestes20";
            this.txtBillestes20.Size = new System.Drawing.Size(124, 22);
            this.txtBillestes20.TabIndex = 4;
            this.txtBillestes20.Text = "0";
            this.txtBillestes20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBillestes20.Click += new System.EventHandler(this.txtBillestes20_Click);
            this.txtBillestes20.Enter += new System.EventHandler(this.txtBillestes20_Enter);
            this.txtBillestes20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBillestes1_KeyDown);
            this.txtBillestes20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillestes1_KeyPress);
            // 
            // txtBillestes50
            // 
            this.txtBillestes50.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillestes50.Location = new System.Drawing.Point(114, 168);
            this.txtBillestes50.Name = "txtBillestes50";
            this.txtBillestes50.Size = new System.Drawing.Size(124, 22);
            this.txtBillestes50.TabIndex = 5;
            this.txtBillestes50.Text = "0";
            this.txtBillestes50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBillestes50.Click += new System.EventHandler(this.txtBillestes50_Click);
            this.txtBillestes50.Enter += new System.EventHandler(this.txtBillestes50_Enter);
            this.txtBillestes50.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBillestes1_KeyDown);
            this.txtBillestes50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillestes1_KeyPress);
            // 
            // txtBillestes100
            // 
            this.txtBillestes100.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillestes100.Location = new System.Drawing.Point(114, 204);
            this.txtBillestes100.Name = "txtBillestes100";
            this.txtBillestes100.Size = new System.Drawing.Size(124, 22);
            this.txtBillestes100.TabIndex = 6;
            this.txtBillestes100.Text = "0";
            this.txtBillestes100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBillestes100.Click += new System.EventHandler(this.txtBillestes100_Click);
            this.txtBillestes100.Enter += new System.EventHandler(this.txtBillestes100_Enter);
            this.txtBillestes100.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBillestes1_KeyDown);
            this.txtBillestes100.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillestes1_KeyPress);
            // 
            // txtMonedas1
            // 
            this.txtMonedas1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedas1.Location = new System.Drawing.Point(355, 24);
            this.txtMonedas1.Name = "txtMonedas1";
            this.txtMonedas1.Size = new System.Drawing.Size(124, 22);
            this.txtMonedas1.TabIndex = 7;
            this.txtMonedas1.Text = "0";
            this.txtMonedas1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonedas1.Click += new System.EventHandler(this.txtMonedas1_Click);
            this.txtMonedas1.Enter += new System.EventHandler(this.txtMonedas1_Enter);
            this.txtMonedas1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonedas1_KeyDown);
            this.txtMonedas1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillestes1_KeyPress);
            // 
            // txtMonedas5
            // 
            this.txtMonedas5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedas5.Location = new System.Drawing.Point(355, 60);
            this.txtMonedas5.Name = "txtMonedas5";
            this.txtMonedas5.Size = new System.Drawing.Size(124, 22);
            this.txtMonedas5.TabIndex = 8;
            this.txtMonedas5.Text = "0";
            this.txtMonedas5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonedas5.Click += new System.EventHandler(this.txtMonedas5_Click);
            this.txtMonedas5.Enter += new System.EventHandler(this.txtMonedas5_Enter);
            this.txtMonedas5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonedas1_KeyDown);
            this.txtMonedas5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillestes1_KeyPress);
            // 
            // txtMonedas10
            // 
            this.txtMonedas10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedas10.Location = new System.Drawing.Point(355, 96);
            this.txtMonedas10.Name = "txtMonedas10";
            this.txtMonedas10.Size = new System.Drawing.Size(124, 22);
            this.txtMonedas10.TabIndex = 9;
            this.txtMonedas10.Text = "0";
            this.txtMonedas10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonedas10.Click += new System.EventHandler(this.txtMonedas10_Click);
            this.txtMonedas10.Enter += new System.EventHandler(this.txtMonedas10_Enter);
            this.txtMonedas10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonedas1_KeyDown);
            this.txtMonedas10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillestes1_KeyPress);
            // 
            // txtMonedas25
            // 
            this.txtMonedas25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedas25.Location = new System.Drawing.Point(355, 132);
            this.txtMonedas25.Name = "txtMonedas25";
            this.txtMonedas25.Size = new System.Drawing.Size(124, 22);
            this.txtMonedas25.TabIndex = 10;
            this.txtMonedas25.Text = "0";
            this.txtMonedas25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonedas25.Click += new System.EventHandler(this.txtMonedas25_Click);
            this.txtMonedas25.Enter += new System.EventHandler(this.txtMonedas25_Enter);
            this.txtMonedas25.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonedas1_KeyDown);
            this.txtMonedas25.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillestes1_KeyPress);
            // 
            // txtMonedas50
            // 
            this.txtMonedas50.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedas50.Location = new System.Drawing.Point(355, 168);
            this.txtMonedas50.Name = "txtMonedas50";
            this.txtMonedas50.Size = new System.Drawing.Size(124, 22);
            this.txtMonedas50.TabIndex = 11;
            this.txtMonedas50.Text = "0";
            this.txtMonedas50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonedas50.Click += new System.EventHandler(this.txtMonedas50_Click);
            this.txtMonedas50.Enter += new System.EventHandler(this.txtMonedas50_Enter);
            this.txtMonedas50.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonedas1_KeyDown);
            this.txtMonedas50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillestes1_KeyPress);
            // 
            // txtMonedas1Dolar
            // 
            this.txtMonedas1Dolar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedas1Dolar.Location = new System.Drawing.Point(355, 204);
            this.txtMonedas1Dolar.Name = "txtMonedas1Dolar";
            this.txtMonedas1Dolar.Size = new System.Drawing.Size(124, 22);
            this.txtMonedas1Dolar.TabIndex = 12;
            this.txtMonedas1Dolar.Text = "0";
            this.txtMonedas1Dolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonedas1Dolar.Click += new System.EventHandler(this.txtMonedas1Dolar_Click);
            this.txtMonedas1Dolar.Enter += new System.EventHandler(this.txtMonedas1Dolar_Enter);
            this.txtMonedas1Dolar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonedas1Dolar_KeyDown);
            this.txtMonedas1Dolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillestes1_KeyPress);
            this.txtMonedas1Dolar.Leave += new System.EventHandler(this.txtMonedas1Dolar_Leave);
            // 
            // txtTotalBillestes
            // 
            this.txtTotalBillestes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBillestes.Location = new System.Drawing.Point(114, 248);
            this.txtTotalBillestes.Name = "txtTotalBillestes";
            this.txtTotalBillestes.ReadOnly = true;
            this.txtTotalBillestes.Size = new System.Drawing.Size(124, 29);
            this.txtTotalBillestes.TabIndex = 25;
            this.txtTotalBillestes.Text = "0.00";
            this.txtTotalBillestes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalMonedas
            // 
            this.txtTotalMonedas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMonedas.Location = new System.Drawing.Point(355, 246);
            this.txtTotalMonedas.Name = "txtTotalMonedas";
            this.txtTotalMonedas.ReadOnly = true;
            this.txtTotalMonedas.Size = new System.Drawing.Size(124, 29);
            this.txtTotalMonedas.TabIndex = 26;
            this.txtTotalMonedas.Text = "0.00";
            this.txtTotalMonedas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbEfectivo
            // 
            this.gbEfectivo.Controls.Add(this.txtTotalMonedas);
            this.gbEfectivo.Controls.Add(this.txtTotalBillestes);
            this.gbEfectivo.Controls.Add(this.txtMonedas1Dolar);
            this.gbEfectivo.Controls.Add(this.txtMonedas50);
            this.gbEfectivo.Controls.Add(this.txtMonedas25);
            this.gbEfectivo.Controls.Add(this.txtMonedas10);
            this.gbEfectivo.Controls.Add(this.txtMonedas5);
            this.gbEfectivo.Controls.Add(this.txtMonedas1);
            this.gbEfectivo.Controls.Add(this.txtBillestes100);
            this.gbEfectivo.Controls.Add(this.txtBillestes50);
            this.gbEfectivo.Controls.Add(this.txtBillestes20);
            this.gbEfectivo.Controls.Add(this.txtBillestes10);
            this.gbEfectivo.Controls.Add(this.txtBillestes5);
            this.gbEfectivo.Controls.Add(this.txtBillestes1);
            this.gbEfectivo.Controls.Add(this.label18);
            this.gbEfectivo.Controls.Add(this.label17);
            this.gbEfectivo.Controls.Add(this.label13);
            this.gbEfectivo.Controls.Add(this.label12);
            this.gbEfectivo.Controls.Add(this.label11);
            this.gbEfectivo.Controls.Add(this.label10);
            this.gbEfectivo.Controls.Add(this.label9);
            this.gbEfectivo.Controls.Add(this.label7);
            this.gbEfectivo.Controls.Add(this.label6);
            this.gbEfectivo.Controls.Add(this.label5);
            this.gbEfectivo.Controls.Add(this.label4);
            this.gbEfectivo.Controls.Add(this.label3);
            this.gbEfectivo.Controls.Add(this.label2);
            this.gbEfectivo.Controls.Add(this.label1);
            this.gbEfectivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEfectivo.ForeColor = System.Drawing.Color.Teal;
            this.gbEfectivo.Location = new System.Drawing.Point(25, 12);
            this.gbEfectivo.Name = "gbEfectivo";
            this.gbEfectivo.Size = new System.Drawing.Size(508, 297);
            this.gbEfectivo.TabIndex = 0;
            this.gbEfectivo.TabStop = false;
            this.gbEfectivo.Text = "Efectivo";
            // 
            // FrmCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(907, 510);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.gbAvance);
            this.Controls.Add(this.btnSalirCompra);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtTotalRecaudado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gbCheque);
            this.Controls.Add(this.gbEfectivo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmCierreCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Caja";
            this.Load += new System.EventHandler(this.FrmCierreCaja_Load);
            this.gbCheque.ResumeLayout(false);
            this.gbCheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheque)).EndInit();
            this.gbAvance.ResumeLayout(false);
            this.gbAvance.PerformLayout();
            this.gbEfectivo.ResumeLayout(false);
            this.gbEfectivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCheque;
        private System.Windows.Forms.TextBox txtTotalCheque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROPIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.TextBox txtTotalRecaudado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSalirCompra;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.GroupBox gbAvance;
        private System.Windows.Forms.TextBox txtCantidadAvances;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAvances;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBillestes1;
        private System.Windows.Forms.TextBox txtBillestes5;
        private System.Windows.Forms.TextBox txtBillestes10;
        private System.Windows.Forms.TextBox txtBillestes20;
        private System.Windows.Forms.TextBox txtBillestes50;
        private System.Windows.Forms.TextBox txtBillestes100;
        private System.Windows.Forms.TextBox txtMonedas1;
        private System.Windows.Forms.TextBox txtMonedas5;
        private System.Windows.Forms.TextBox txtMonedas10;
        private System.Windows.Forms.TextBox txtMonedas25;
        private System.Windows.Forms.TextBox txtMonedas50;
        private System.Windows.Forms.TextBox txtMonedas1Dolar;
        private System.Windows.Forms.TextBox txtTotalBillestes;
        private System.Windows.Forms.TextBox txtTotalMonedas;
        private System.Windows.Forms.GroupBox gbEfectivo;
    }
}