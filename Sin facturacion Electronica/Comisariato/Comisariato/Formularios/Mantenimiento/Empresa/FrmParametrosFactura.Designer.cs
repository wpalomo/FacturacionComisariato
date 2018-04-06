namespace Comisariato.Formularios.Mantenimiento.Empresa
{
    partial class FrmParametrosFactura
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
            this.gbTipoFacturaEmpresa = new System.Windows.Forms.GroupBox();
            this.rbAutorizadoImprimir = new System.Windows.Forms.RadioButton();
            this.rbPreimpresa = new System.Windows.Forms.RadioButton();
            this.gbSRIEmpresa = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroResolucion = new System.Windows.Forms.TextBox();
            this.cbIVA = new System.Windows.Forms.ComboBox();
            this.btnRegistrarIVA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbObligadoContabilidad = new System.Windows.Forms.CheckBox();
            this.ckbContribuyenteEspecial = new System.Windows.Forms.CheckBox();
            this.txtMontoMinimoFacturaEmpresa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbAutorizadoImprimir = new System.Windows.Forms.GroupBox();
            this.TxtPie4 = new System.Windows.Forms.TextBox();
            this.TxtPie3 = new System.Windows.Forms.TextBox();
            this.TxtPie2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtPie1 = new System.Windows.Forms.TextBox();
            this.gbPreimpresa = new System.Windows.Forms.GroupBox();
            this.TxtNumeroItemsFactura = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.TxtTamañoPieFact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTamañoEncabezadoFact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLargo = new System.Windows.Forms.TextBox();
            this.TxtAncho = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BtnAgregarCertificado = new System.Windows.Forms.Button();
            this.LblEntidadCertificadora = new System.Windows.Forms.Label();
            this.LblEstadoCertificado = new System.Windows.Forms.Label();
            this.LblUnidadCertificadora = new System.Windows.Forms.Label();
            this.btnLimpiarEmpresa = new System.Windows.Forms.Button();
            this.btnGuardarEmpresa = new System.Windows.Forms.Button();
            this.LblSujetoCertificado = new System.Windows.Forms.Label();
            this.gbTipoFacturaEmpresa.SuspendLayout();
            this.gbSRIEmpresa.SuspendLayout();
            this.gbAutorizadoImprimir.SuspendLayout();
            this.gbPreimpresa.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTipoFacturaEmpresa
            // 
            this.gbTipoFacturaEmpresa.Controls.Add(this.rbAutorizadoImprimir);
            this.gbTipoFacturaEmpresa.Controls.Add(this.rbPreimpresa);
            this.gbTipoFacturaEmpresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoFacturaEmpresa.ForeColor = System.Drawing.Color.Teal;
            this.gbTipoFacturaEmpresa.Location = new System.Drawing.Point(60, 21);
            this.gbTipoFacturaEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTipoFacturaEmpresa.Name = "gbTipoFacturaEmpresa";
            this.gbTipoFacturaEmpresa.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTipoFacturaEmpresa.Size = new System.Drawing.Size(350, 57);
            this.gbTipoFacturaEmpresa.TabIndex = 10;
            this.gbTipoFacturaEmpresa.TabStop = false;
            this.gbTipoFacturaEmpresa.Text = "Tipo Factura";
            // 
            // rbAutorizadoImprimir
            // 
            this.rbAutorizadoImprimir.AutoSize = true;
            this.rbAutorizadoImprimir.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbAutorizadoImprimir.Location = new System.Drawing.Point(145, 25);
            this.rbAutorizadoImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAutorizadoImprimir.Name = "rbAutorizadoImprimir";
            this.rbAutorizadoImprimir.Size = new System.Drawing.Size(167, 20);
            this.rbAutorizadoImprimir.TabIndex = 5;
            this.rbAutorizadoImprimir.Text = "Autorizado para Imprimir";
            this.rbAutorizadoImprimir.UseVisualStyleBackColor = true;
            this.rbAutorizadoImprimir.CheckedChanged += new System.EventHandler(this.rbAutorizadoImprimir_CheckedChanged_1);
            // 
            // rbPreimpresa
            // 
            this.rbPreimpresa.AutoSize = true;
            this.rbPreimpresa.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbPreimpresa.Location = new System.Drawing.Point(30, 25);
            this.rbPreimpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbPreimpresa.Name = "rbPreimpresa";
            this.rbPreimpresa.Size = new System.Drawing.Size(92, 20);
            this.rbPreimpresa.TabIndex = 4;
            this.rbPreimpresa.Text = "Preimpresa";
            this.rbPreimpresa.UseVisualStyleBackColor = true;
            this.rbPreimpresa.CheckedChanged += new System.EventHandler(this.rbPreimpresa_CheckedChanged_1);
            // 
            // gbSRIEmpresa
            // 
            this.gbSRIEmpresa.Controls.Add(this.label4);
            this.gbSRIEmpresa.Controls.Add(this.txtNumeroResolucion);
            this.gbSRIEmpresa.Controls.Add(this.cbIVA);
            this.gbSRIEmpresa.Controls.Add(this.btnRegistrarIVA);
            this.gbSRIEmpresa.Controls.Add(this.label1);
            this.gbSRIEmpresa.Controls.Add(this.ckbObligadoContabilidad);
            this.gbSRIEmpresa.Controls.Add(this.ckbContribuyenteEspecial);
            this.gbSRIEmpresa.Controls.Add(this.txtMontoMinimoFacturaEmpresa);
            this.gbSRIEmpresa.Controls.Add(this.label13);
            this.gbSRIEmpresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSRIEmpresa.ForeColor = System.Drawing.Color.Teal;
            this.gbSRIEmpresa.Location = new System.Drawing.Point(448, 21);
            this.gbSRIEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSRIEmpresa.Name = "gbSRIEmpresa";
            this.gbSRIEmpresa.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSRIEmpresa.Size = new System.Drawing.Size(405, 172);
            this.gbSRIEmpresa.TabIndex = 11;
            this.gbSRIEmpresa.TabStop = false;
            this.gbSRIEmpresa.Text = "SRI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nº. Resolucion:";
            // 
            // txtNumeroResolucion
            // 
            this.txtNumeroResolucion.Enabled = false;
            this.txtNumeroResolucion.Location = new System.Drawing.Point(110, 130);
            this.txtNumeroResolucion.Name = "txtNumeroResolucion";
            this.txtNumeroResolucion.Size = new System.Drawing.Size(108, 22);
            this.txtNumeroResolucion.TabIndex = 14;
            this.txtNumeroResolucion.Text = "0";
            // 
            // cbIVA
            // 
            this.cbIVA.FormattingEnabled = true;
            this.cbIVA.Location = new System.Drawing.Point(190, 59);
            this.cbIVA.Name = "cbIVA";
            this.cbIVA.Size = new System.Drawing.Size(115, 24);
            this.cbIVA.TabIndex = 13;
            this.cbIVA.Enter += new System.EventHandler(this.cbIVA_Enter);
            // 
            // btnRegistrarIVA
            // 
            this.btnRegistrarIVA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarIVA.Location = new System.Drawing.Point(324, 60);
            this.btnRegistrarIVA.Name = "btnRegistrarIVA";
            this.btnRegistrarIVA.Size = new System.Drawing.Size(67, 25);
            this.btnRegistrarIVA.TabIndex = 12;
            this.btnRegistrarIVA.Text = "&Agregar";
            this.btnRegistrarIVA.UseVisualStyleBackColor = true;
            this.btnRegistrarIVA.Click += new System.EventHandler(this.btnRegistrarIVA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(161, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "IVA:";
            // 
            // ckbObligadoContabilidad
            // 
            this.ckbObligadoContabilidad.AutoSize = true;
            this.ckbObligadoContabilidad.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ckbObligadoContabilidad.Location = new System.Drawing.Point(190, 98);
            this.ckbObligadoContabilidad.Name = "ckbObligadoContabilidad";
            this.ckbObligadoContabilidad.Size = new System.Drawing.Size(201, 20);
            this.ckbObligadoContabilidad.TabIndex = 9;
            this.ckbObligadoContabilidad.Text = "Obligado a Llevar Contabilidad";
            this.ckbObligadoContabilidad.UseVisualStyleBackColor = true;
            // 
            // ckbContribuyenteEspecial
            // 
            this.ckbContribuyenteEspecial.AutoSize = true;
            this.ckbContribuyenteEspecial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbContribuyenteEspecial.Location = new System.Drawing.Point(10, 98);
            this.ckbContribuyenteEspecial.Name = "ckbContribuyenteEspecial";
            this.ckbContribuyenteEspecial.Size = new System.Drawing.Size(161, 20);
            this.ckbContribuyenteEspecial.TabIndex = 8;
            this.ckbContribuyenteEspecial.Text = "Contribuyente Especial";
            this.ckbContribuyenteEspecial.UseVisualStyleBackColor = true;
            this.ckbContribuyenteEspecial.CheckedChanged += new System.EventHandler(this.ckbContribuyenteEspecial_CheckedChanged);
            // 
            // txtMontoMinimoFacturaEmpresa
            // 
            this.txtMontoMinimoFacturaEmpresa.BackColor = System.Drawing.SystemColors.Window;
            this.txtMontoMinimoFacturaEmpresa.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtMontoMinimoFacturaEmpresa.Location = new System.Drawing.Point(190, 24);
            this.txtMontoMinimoFacturaEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMontoMinimoFacturaEmpresa.Name = "txtMontoMinimoFacturaEmpresa";
            this.txtMontoMinimoFacturaEmpresa.Size = new System.Drawing.Size(201, 22);
            this.txtMontoMinimoFacturaEmpresa.TabIndex = 5;
            this.txtMontoMinimoFacturaEmpresa.Enter += new System.EventHandler(this.txtMontoMinimoFacturaEmpresa_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label13.Location = new System.Drawing.Point(11, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Monto Mínimo para Facturar:";
            // 
            // gbAutorizadoImprimir
            // 
            this.gbAutorizadoImprimir.Controls.Add(this.TxtPie4);
            this.gbAutorizadoImprimir.Controls.Add(this.TxtPie3);
            this.gbAutorizadoImprimir.Controls.Add(this.TxtPie2);
            this.gbAutorizadoImprimir.Controls.Add(this.label21);
            this.gbAutorizadoImprimir.Controls.Add(this.label20);
            this.gbAutorizadoImprimir.Controls.Add(this.label19);
            this.gbAutorizadoImprimir.Controls.Add(this.label18);
            this.gbAutorizadoImprimir.Controls.Add(this.TxtPie1);
            this.gbAutorizadoImprimir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAutorizadoImprimir.ForeColor = System.Drawing.Color.Teal;
            this.gbAutorizadoImprimir.Location = new System.Drawing.Point(60, 152);
            this.gbAutorizadoImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAutorizadoImprimir.Name = "gbAutorizadoImprimir";
            this.gbAutorizadoImprimir.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAutorizadoImprimir.Size = new System.Drawing.Size(350, 146);
            this.gbAutorizadoImprimir.TabIndex = 13;
            this.gbAutorizadoImprimir.TabStop = false;
            this.gbAutorizadoImprimir.Text = "Auorizado para Imprimir";
            // 
            // TxtPie4
            // 
            this.TxtPie4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtPie4.Location = new System.Drawing.Point(77, 103);
            this.TxtPie4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPie4.Name = "TxtPie4";
            this.TxtPie4.Size = new System.Drawing.Size(240, 22);
            this.TxtPie4.TabIndex = 7;
            // 
            // TxtPie3
            // 
            this.TxtPie3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtPie3.Location = new System.Drawing.Point(77, 76);
            this.TxtPie3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPie3.Name = "TxtPie3";
            this.TxtPie3.Size = new System.Drawing.Size(240, 22);
            this.TxtPie3.TabIndex = 6;
            // 
            // TxtPie2
            // 
            this.TxtPie2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtPie2.Location = new System.Drawing.Point(77, 49);
            this.TxtPie2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPie2.Name = "TxtPie2";
            this.TxtPie2.Size = new System.Drawing.Size(240, 22);
            this.TxtPie2.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label21.Location = new System.Drawing.Point(17, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 16);
            this.label21.TabIndex = 4;
            this.label21.Text = "Pie 4:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label20.Location = new System.Drawing.Point(17, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 16);
            this.label20.TabIndex = 3;
            this.label20.Text = "Pie 3:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label19.Location = new System.Drawing.Point(17, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 16);
            this.label19.TabIndex = 2;
            this.label19.Text = "Pie 2:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label18.Location = new System.Drawing.Point(17, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "Pie 1:";
            // 
            // TxtPie1
            // 
            this.TxtPie1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtPie1.Location = new System.Drawing.Point(77, 22);
            this.TxtPie1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPie1.Name = "TxtPie1";
            this.TxtPie1.Size = new System.Drawing.Size(240, 22);
            this.TxtPie1.TabIndex = 0;
            // 
            // gbPreimpresa
            // 
            this.gbPreimpresa.Controls.Add(this.TxtNumeroItemsFactura);
            this.gbPreimpresa.Controls.Add(this.label17);
            this.gbPreimpresa.Controls.Add(this.groupBox8);
            this.gbPreimpresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPreimpresa.ForeColor = System.Drawing.Color.Teal;
            this.gbPreimpresa.Location = new System.Drawing.Point(24, 160);
            this.gbPreimpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPreimpresa.Name = "gbPreimpresa";
            this.gbPreimpresa.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPreimpresa.Size = new System.Drawing.Size(418, 138);
            this.gbPreimpresa.TabIndex = 12;
            this.gbPreimpresa.TabStop = false;
            this.gbPreimpresa.Text = "Preimpresa";
            this.gbPreimpresa.Visible = false;
            // 
            // TxtNumeroItemsFactura
            // 
            this.TxtNumeroItemsFactura.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtNumeroItemsFactura.Location = new System.Drawing.Point(199, 109);
            this.TxtNumeroItemsFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtNumeroItemsFactura.Name = "TxtNumeroItemsFactura";
            this.TxtNumeroItemsFactura.Size = new System.Drawing.Size(203, 22);
            this.TxtNumeroItemsFactura.TabIndex = 2;
            this.TxtNumeroItemsFactura.Text = "0";
            this.TxtNumeroItemsFactura.Enter += new System.EventHandler(this.TxtNumeroItemsFactura_Enter);
            this.TxtNumeroItemsFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroItemsFactura_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label17.Location = new System.Drawing.Point(12, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(181, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "Número de Items por Factura:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.TxtTamañoPieFact);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.TxtTamañoEncabezadoFact);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.TxtLargo);
            this.groupBox8.Controls.Add(this.TxtAncho);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.Teal;
            this.groupBox8.Location = new System.Drawing.Point(15, 23);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Size = new System.Drawing.Size(387, 78);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Tamaño Factura";
            // 
            // TxtTamañoPieFact
            // 
            this.TxtTamañoPieFact.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtTamañoPieFact.Location = new System.Drawing.Point(282, 45);
            this.TxtTamañoPieFact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTamañoPieFact.Name = "TxtTamañoPieFact";
            this.TxtTamañoPieFact.Size = new System.Drawing.Size(76, 22);
            this.TxtTamañoPieFact.TabIndex = 7;
            this.TxtTamañoPieFact.Text = "0";
            this.TxtTamañoPieFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTamañoPieFact_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(233, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pie:";
            // 
            // TxtTamañoEncabezadoFact
            // 
            this.TxtTamañoEncabezadoFact.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtTamañoEncabezadoFact.Location = new System.Drawing.Point(106, 46);
            this.TxtTamañoEncabezadoFact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTamañoEncabezadoFact.Name = "TxtTamañoEncabezadoFact";
            this.TxtTamañoEncabezadoFact.Size = new System.Drawing.Size(76, 22);
            this.TxtTamañoEncabezadoFact.TabIndex = 5;
            this.TxtTamañoEncabezadoFact.Text = "0";
            this.TxtTamañoEncabezadoFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTamañoEncabezadoFact_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encabezado:";
            // 
            // TxtLargo
            // 
            this.TxtLargo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtLargo.Location = new System.Drawing.Point(283, 18);
            this.TxtLargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtLargo.Name = "TxtLargo";
            this.TxtLargo.Size = new System.Drawing.Size(76, 22);
            this.TxtLargo.TabIndex = 3;
            this.TxtLargo.Text = "0";
            this.TxtLargo.Enter += new System.EventHandler(this.TxtLargo_Enter);
            this.TxtLargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLargo_KeyPress);
            // 
            // TxtAncho
            // 
            this.TxtAncho.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtAncho.Location = new System.Drawing.Point(106, 18);
            this.TxtAncho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtAncho.Name = "TxtAncho";
            this.TxtAncho.Size = new System.Drawing.Size(76, 22);
            this.TxtAncho.TabIndex = 2;
            this.TxtAncho.Text = "0";
            this.TxtAncho.Enter += new System.EventHandler(this.TxtAncho_Enter);
            this.TxtAncho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAncho_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label16.Location = new System.Drawing.Point(233, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Largo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label15.Location = new System.Drawing.Point(16, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ancho:";
            // 
            // BtnAgregarCertificado
            // 
            this.BtnAgregarCertificado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCertificado.Location = new System.Drawing.Point(238, 125);
            this.BtnAgregarCertificado.Name = "BtnAgregarCertificado";
            this.BtnAgregarCertificado.Size = new System.Drawing.Size(172, 25);
            this.BtnAgregarCertificado.TabIndex = 16;
            this.BtnAgregarCertificado.Text = "&Agregar Certificado Digital";
            this.BtnAgregarCertificado.UseVisualStyleBackColor = true;
            this.BtnAgregarCertificado.Visible = false;
            this.BtnAgregarCertificado.Click += new System.EventHandler(this.BtnAgregarCertificado_Click);
            // 
            // LblEntidadCertificadora
            // 
            this.LblEntidadCertificadora.AutoSize = true;
            this.LblEntidadCertificadora.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblEntidadCertificadora.Location = new System.Drawing.Point(66, 85);
            this.LblEntidadCertificadora.Name = "LblEntidadCertificadora";
            this.LblEntidadCertificadora.Size = new System.Drawing.Size(91, 16);
            this.LblEntidadCertificadora.TabIndex = 17;
            this.LblEntidadCertificadora.Text = "Entidad Certf.:";
            this.LblEntidadCertificadora.Visible = false;
            // 
            // LblEstadoCertificado
            // 
            this.LblEstadoCertificado.AutoSize = true;
            this.LblEstadoCertificado.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblEstadoCertificado.Location = new System.Drawing.Point(164, 106);
            this.LblEstadoCertificado.Name = "LblEstadoCertificado";
            this.LblEstadoCertificado.Size = new System.Drawing.Size(49, 16);
            this.LblEstadoCertificado.TabIndex = 18;
            this.LblEstadoCertificado.Text = "Estado";
            this.LblEstadoCertificado.Visible = false;
            // 
            // LblUnidadCertificadora
            // 
            this.LblUnidadCertificadora.AutoSize = true;
            this.LblUnidadCertificadora.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblUnidadCertificadora.Location = new System.Drawing.Point(164, 85);
            this.LblUnidadCertificadora.Name = "LblUnidadCertificadora";
            this.LblUnidadCertificadora.Size = new System.Drawing.Size(49, 16);
            this.LblUnidadCertificadora.TabIndex = 19;
            this.LblUnidadCertificadora.Text = "Estado";
            this.LblUnidadCertificadora.Visible = false;
            // 
            // btnLimpiarEmpresa
            // 
            this.btnLimpiarEmpresa.Font = new System.Drawing.Font("Arial", 10F);
            this.btnLimpiarEmpresa.Image = global::Comisariato.Properties.Resources.limpiar;
            this.btnLimpiarEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarEmpresa.Location = new System.Drawing.Point(676, 214);
            this.btnLimpiarEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiarEmpresa.Name = "btnLimpiarEmpresa";
            this.btnLimpiarEmpresa.Size = new System.Drawing.Size(128, 75);
            this.btnLimpiarEmpresa.TabIndex = 15;
            this.btnLimpiarEmpresa.Text = "&Limpiar";
            this.btnLimpiarEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarEmpresa.UseVisualStyleBackColor = true;
            this.btnLimpiarEmpresa.Click += new System.EventHandler(this.btnLimpiarEmpresa_Click);
            // 
            // btnGuardarEmpresa
            // 
            this.btnGuardarEmpresa.Font = new System.Drawing.Font("Arial", 10F);
            this.btnGuardarEmpresa.Image = global::Comisariato.Properties.Resources.guardar11;
            this.btnGuardarEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarEmpresa.Location = new System.Drawing.Point(499, 211);
            this.btnGuardarEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarEmpresa.Name = "btnGuardarEmpresa";
            this.btnGuardarEmpresa.Size = new System.Drawing.Size(135, 78);
            this.btnGuardarEmpresa.TabIndex = 14;
            this.btnGuardarEmpresa.Text = "&Guardar";
            this.btnGuardarEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEmpresa.UseVisualStyleBackColor = true;
            this.btnGuardarEmpresa.Click += new System.EventHandler(this.btnGuardarEmpresa_Click);
            // 
            // LblSujetoCertificado
            // 
            this.LblSujetoCertificado.AutoSize = true;
            this.LblSujetoCertificado.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblSujetoCertificado.Location = new System.Drawing.Point(66, 106);
            this.LblSujetoCertificado.Name = "LblSujetoCertificado";
            this.LblSujetoCertificado.Size = new System.Drawing.Size(49, 16);
            this.LblSujetoCertificado.TabIndex = 20;
            this.LblSujetoCertificado.Text = "Sujeto:";
            this.LblSujetoCertificado.Visible = false;
            // 
            // FrmParametrosFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(873, 323);
            this.Controls.Add(this.LblSujetoCertificado);
            this.Controls.Add(this.LblUnidadCertificadora);
            this.Controls.Add(this.LblEstadoCertificado);
            this.Controls.Add(this.LblEntidadCertificadora);
            this.Controls.Add(this.BtnAgregarCertificado);
            this.Controls.Add(this.gbAutorizadoImprimir);
            this.Controls.Add(this.gbPreimpresa);
            this.Controls.Add(this.btnLimpiarEmpresa);
            this.Controls.Add(this.btnGuardarEmpresa);
            this.Controls.Add(this.gbTipoFacturaEmpresa);
            this.Controls.Add(this.gbSRIEmpresa);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmParametrosFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parámetros de Factura";
            this.Load += new System.EventHandler(this.FrmParametrosFactura_Load);
            this.gbTipoFacturaEmpresa.ResumeLayout(false);
            this.gbTipoFacturaEmpresa.PerformLayout();
            this.gbSRIEmpresa.ResumeLayout(false);
            this.gbSRIEmpresa.PerformLayout();
            this.gbAutorizadoImprimir.ResumeLayout(false);
            this.gbAutorizadoImprimir.PerformLayout();
            this.gbPreimpresa.ResumeLayout(false);
            this.gbPreimpresa.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTipoFacturaEmpresa;
        private System.Windows.Forms.RadioButton rbAutorizadoImprimir;
        private System.Windows.Forms.RadioButton rbPreimpresa;
        private System.Windows.Forms.GroupBox gbSRIEmpresa;
        private System.Windows.Forms.TextBox txtMontoMinimoFacturaEmpresa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbAutorizadoImprimir;
        private System.Windows.Forms.TextBox TxtPie4;
        private System.Windows.Forms.TextBox TxtPie3;
        private System.Windows.Forms.TextBox TxtPie2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtPie1;
        private System.Windows.Forms.GroupBox gbPreimpresa;
        private System.Windows.Forms.TextBox TxtNumeroItemsFactura;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox TxtLargo;
        private System.Windows.Forms.TextBox TxtAncho;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnLimpiarEmpresa;
        private System.Windows.Forms.Button btnGuardarEmpresa;
        private System.Windows.Forms.CheckBox ckbObligadoContabilidad;
        private System.Windows.Forms.CheckBox ckbContribuyenteEspecial;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRegistrarIVA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIVA;
        private System.Windows.Forms.TextBox TxtTamañoPieFact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTamañoEncabezadoFact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroResolucion;
        private System.Windows.Forms.Button BtnAgregarCertificado;
        private System.Windows.Forms.Label LblEntidadCertificadora;
        private System.Windows.Forms.Label LblEstadoCertificado;
        private System.Windows.Forms.Label LblUnidadCertificadora;
        private System.Windows.Forms.Label LblSujetoCertificado;
    }
}