namespace Comisariato.Formularios.SRI
{
    partial class FrmComprobantesSri
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
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCantComprobantesPendientes = new System.Windows.Forms.TextBox();
            this.BtnProcesarPendientes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReimprimirRide = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMensajeError = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.rTxtVistaXML = new System.Windows.Forms.RichTextBox();
            this.dgvComprobantesErroneos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.CmbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtClaveAcceso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantesErroneos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(677, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad de Comprobantes Pendientes:";
            // 
            // TxtCantComprobantesPendientes
            // 
            this.TxtCantComprobantesPendientes.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtCantComprobantesPendientes.ForeColor = System.Drawing.Color.Teal;
            this.TxtCantComprobantesPendientes.Location = new System.Drawing.Point(988, 23);
            this.TxtCantComprobantesPendientes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtCantComprobantesPendientes.Name = "TxtCantComprobantesPendientes";
            this.TxtCantComprobantesPendientes.ReadOnly = true;
            this.TxtCantComprobantesPendientes.Size = new System.Drawing.Size(101, 23);
            this.TxtCantComprobantesPendientes.TabIndex = 7;
            // 
            // BtnProcesarPendientes
            // 
            this.BtnProcesarPendientes.Font = new System.Drawing.Font("Arial", 10F);
            this.BtnProcesarPendientes.ForeColor = System.Drawing.Color.Teal;
            this.BtnProcesarPendientes.Location = new System.Drawing.Point(409, 18);
            this.BtnProcesarPendientes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnProcesarPendientes.Name = "BtnProcesarPendientes";
            this.BtnProcesarPendientes.Size = new System.Drawing.Size(159, 38);
            this.BtnProcesarPendientes.TabIndex = 50;
            this.BtnProcesarPendientes.Text = "Procesar Pendientes";
            this.BtnProcesarPendientes.UseVisualStyleBackColor = true;
            this.BtnProcesarPendientes.Click += new System.EventHandler(this.BtnProcesarPendientes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtClaveAcceso);
            this.groupBox1.Controls.Add(this.BtnReimprimirRide);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtMensajeError);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.rTxtVistaXML);
            this.groupBox1.Controls.Add(this.dgvComprobantesErroneos);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtpFechaInicial);
            this.groupBox1.Controls.Add(this.DtpFechaFinal);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(13, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(1077, 674);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Errores";
            // 
            // BtnReimprimirRide
            // 
            this.BtnReimprimirRide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReimprimirRide.Image = global::Comisariato.Properties.Resources.impresoraRide32x32;
            this.BtnReimprimirRide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReimprimirRide.Location = new System.Drawing.Point(782, 614);
            this.BtnReimprimirRide.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnReimprimirRide.Name = "BtnReimprimirRide";
            this.BtnReimprimirRide.Size = new System.Drawing.Size(147, 55);
            this.BtnReimprimirRide.TabIndex = 70;
            this.BtnReimprimirRide.Text = "ReImprimir Ride";
            this.BtnReimprimirRide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReimprimirRide.UseVisualStyleBackColor = true;
            this.BtnReimprimirRide.Click += new System.EventHandler(this.BtnReimprimirRide_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(10, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Mensaje Error  :";
            // 
            // TxtMensajeError
            // 
            this.TxtMensajeError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMensajeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMensajeError.Location = new System.Drawing.Point(145, 341);
            this.TxtMensajeError.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtMensajeError.Name = "TxtMensajeError";
            this.TxtMensajeError.Size = new System.Drawing.Size(914, 20);
            this.TxtMensajeError.TabIndex = 68;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.Image = global::Comisariato.Properties.Resources.GUARDAR32X32;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(938, 614);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(122, 55);
            this.BtnGuardar.TabIndex = 66;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // rTxtVistaXML
            // 
            this.rTxtVistaXML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTxtVistaXML.Font = new System.Drawing.Font("Arial", 8.25F);
            this.rTxtVistaXML.Location = new System.Drawing.Point(14, 368);
            this.rTxtVistaXML.Margin = new System.Windows.Forms.Padding(0);
            this.rTxtVistaXML.Name = "rTxtVistaXML";
            this.rTxtVistaXML.Size = new System.Drawing.Size(1046, 238);
            this.rTxtVistaXML.TabIndex = 67;
            this.rTxtVistaXML.Text = "";
            // 
            // dgvComprobantesErroneos
            // 
            this.dgvComprobantesErroneos.AllowUserToAddRows = false;
            this.dgvComprobantesErroneos.AllowUserToDeleteRows = false;
            this.dgvComprobantesErroneos.AllowUserToResizeColumns = false;
            this.dgvComprobantesErroneos.AllowUserToResizeRows = false;
            this.dgvComprobantesErroneos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComprobantesErroneos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComprobantesErroneos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvComprobantesErroneos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComprobantesErroneos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComprobantesErroneos.Location = new System.Drawing.Point(14, 75);
            this.dgvComprobantesErroneos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvComprobantesErroneos.MultiSelect = false;
            this.dgvComprobantesErroneos.Name = "dgvComprobantesErroneos";
            this.dgvComprobantesErroneos.ReadOnly = true;
            this.dgvComprobantesErroneos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvComprobantesErroneos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComprobantesErroneos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprobantesErroneos.Size = new System.Drawing.Size(1046, 261);
            this.dgvComprobantesErroneos.TabIndex = 65;
            this.dgvComprobantesErroneos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprobantesErroneos_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnBuscar.Image = global::Comisariato.Properties.Resources.BuscarArchivo;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(926, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 48);
            this.btnBuscar.TabIndex = 64;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(310, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Fecha Final :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Fecha Inicial :";
            // 
            // DtpFechaInicial
            // 
            this.DtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicial.Location = new System.Drawing.Point(128, 25);
            this.DtpFechaInicial.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DtpFechaInicial.Name = "DtpFechaInicial";
            this.DtpFechaInicial.Size = new System.Drawing.Size(165, 23);
            this.DtpFechaInicial.TabIndex = 61;
            // 
            // DtpFechaFinal
            // 
            this.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFinal.Location = new System.Drawing.Point(408, 25);
            this.DtpFechaFinal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DtpFechaFinal.Name = "DtpFechaFinal";
            this.DtpFechaFinal.Size = new System.Drawing.Size(165, 23);
            this.DtpFechaFinal.TabIndex = 60;
            // 
            // CmbTipoComprobante
            // 
            this.CmbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoComprobante.Font = new System.Drawing.Font("Arial", 10F);
            this.CmbTipoComprobante.ForeColor = System.Drawing.Color.Teal;
            this.CmbTipoComprobante.FormattingEnabled = true;
            this.CmbTipoComprobante.Items.AddRange(new object[] {
            "Factura",
            "Retención"});
            this.CmbTipoComprobante.Location = new System.Drawing.Point(140, 23);
            this.CmbTipoComprobante.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CmbTipoComprobante.Name = "CmbTipoComprobante";
            this.CmbTipoComprobante.Size = new System.Drawing.Size(233, 24);
            this.CmbTipoComprobante.TabIndex = 70;
            this.CmbTipoComprobante.SelectedIndexChanged += new System.EventHandler(this.CmbTipoComprobante_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(23, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Comprobante";
            // 
            // TxtClaveAcceso
            // 
            this.TxtClaveAcceso.Location = new System.Drawing.Point(696, 25);
            this.TxtClaveAcceso.Name = "TxtClaveAcceso";
            this.TxtClaveAcceso.Size = new System.Drawing.Size(202, 23);
            this.TxtClaveAcceso.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(595, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Clave Acceso:";
            // 
            // FrmComprobantesSri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1107, 741);
            this.Controls.Add(this.CmbTipoComprobante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnProcesarPendientes);
            this.Controls.Add(this.TxtCantComprobantesPendientes);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1123, 792);
            this.MinimumSize = new System.Drawing.Size(1123, 726);
            this.Name = "FrmComprobantesSri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Comprobantes SRI";
            this.Load += new System.EventHandler(this.FrmComprobantesSri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantesErroneos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCantComprobantesPendientes;
        private System.Windows.Forms.Button BtnProcesarPendientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.RichTextBox rTxtVistaXML;
        private System.Windows.Forms.DataGridView dgvComprobantesErroneos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFechaInicial;
        private System.Windows.Forms.DateTimePicker DtpFechaFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMensajeError;
        private System.Windows.Forms.ComboBox CmbTipoComprobante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnReimprimirRide;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtClaveAcceso;
    }
}