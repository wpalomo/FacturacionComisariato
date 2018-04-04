namespace ModuloFacturacionElectronica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TollMenuLablelDocumento = new System.Windows.Forms.ToolStripStatusLabel();
            this.TollMenuLablelFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEnviados = new System.Windows.Forms.Label();
            this.lblAutorizados = new System.Windows.Forms.Label();
            this.lblNoAutorizados = new System.Windows.Forms.Label();
            this.lblDevuelta = new System.Windows.Forms.Label();
            this.lblRecibida = new System.Windows.Forms.Label();
            this.lblTotalArchivos = new System.Windows.Forms.Label();
            this.lblcontadorArchivos = new System.Windows.Forms.Label();
            this.lblNE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblArchivosRestaurados = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(332, 78);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(154, 20);
            this.DtpFecha.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(332, 119);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(154, 52);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar Archivos";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(332, 201);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 52);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "FACTURACIÓN ELECTRONICA";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TollMenuLablelDocumento,
            this.TollMenuLablelFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(552, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TollMenuLablelDocumento
            // 
            this.TollMenuLablelDocumento.Name = "TollMenuLablelDocumento";
            this.TollMenuLablelDocumento.Size = new System.Drawing.Size(0, 17);
            // 
            // TollMenuLablelFecha
            // 
            this.TollMenuLablelFecha.Name = "TollMenuLablelFecha";
            this.TollMenuLablelFecha.Size = new System.Drawing.Size(0, 17);
            // 
            // lblEnviados
            // 
            this.lblEnviados.AutoSize = true;
            this.lblEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviados.Location = new System.Drawing.Point(56, 267);
            this.lblEnviados.Name = "lblEnviados";
            this.lblEnviados.Size = new System.Drawing.Size(89, 16);
            this.lblEnviados.TabIndex = 7;
            this.lblEnviados.Text = "Enviados; 0";
            // 
            // lblAutorizados
            // 
            this.lblAutorizados.AutoSize = true;
            this.lblAutorizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorizados.Location = new System.Drawing.Point(197, 267);
            this.lblAutorizados.Name = "lblAutorizados";
            this.lblAutorizados.Size = new System.Drawing.Size(106, 16);
            this.lblAutorizados.TabIndex = 8;
            this.lblAutorizados.Text = "Autorizados; 0";
            // 
            // lblNoAutorizados
            // 
            this.lblNoAutorizados.AutoSize = true;
            this.lblNoAutorizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAutorizados.Location = new System.Drawing.Point(356, 267);
            this.lblNoAutorizados.Name = "lblNoAutorizados";
            this.lblNoAutorizados.Size = new System.Drawing.Size(130, 16);
            this.lblNoAutorizados.TabIndex = 9;
            this.lblNoAutorizados.Text = "No Autorizados; 0";
            // 
            // lblDevuelta
            // 
            this.lblDevuelta.AutoSize = true;
            this.lblDevuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevuelta.Location = new System.Drawing.Point(56, 294);
            this.lblDevuelta.Name = "lblDevuelta";
            this.lblDevuelta.Size = new System.Drawing.Size(86, 16);
            this.lblDevuelta.TabIndex = 10;
            this.lblDevuelta.Text = "Devuelta: 0";
            // 
            // lblRecibida
            // 
            this.lblRecibida.AutoSize = true;
            this.lblRecibida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibida.Location = new System.Drawing.Point(197, 294);
            this.lblRecibida.Name = "lblRecibida";
            this.lblRecibida.Size = new System.Drawing.Size(87, 16);
            this.lblRecibida.TabIndex = 11;
            this.lblRecibida.Text = "Recibido: 0";
            // 
            // lblTotalArchivos
            // 
            this.lblTotalArchivos.AutoSize = true;
            this.lblTotalArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalArchivos.Location = new System.Drawing.Point(56, 67);
            this.lblTotalArchivos.Name = "lblTotalArchivos";
            this.lblTotalArchivos.Size = new System.Drawing.Size(105, 15);
            this.lblTotalArchivos.TabIndex = 12;
            this.lblTotalArchivos.Text = "Total de  Archivos:";
            // 
            // lblcontadorArchivos
            // 
            this.lblcontadorArchivos.AutoSize = true;
            this.lblcontadorArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontadorArchivos.ForeColor = System.Drawing.Color.Green;
            this.lblcontadorArchivos.Location = new System.Drawing.Point(356, 295);
            this.lblcontadorArchivos.Name = "lblcontadorArchivos";
            this.lblcontadorArchivos.Size = new System.Drawing.Size(62, 15);
            this.lblcontadorArchivos.TabIndex = 13;
            this.lblcontadorArchivos.Text = "1 de 6000";
            // 
            // lblNE
            // 
            this.lblNE.AutoSize = true;
            this.lblNE.Location = new System.Drawing.Point(0, -1);
            this.lblNE.Name = "lblNE";
            this.lblNE.Size = new System.Drawing.Size(25, 13);
            this.lblNE.TabIndex = 14;
            this.lblNE.Text = "NE:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(59, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblArchivosRestaurados
            // 
            this.lblArchivosRestaurados.AutoSize = true;
            this.lblArchivosRestaurados.Location = new System.Drawing.Point(0, 19);
            this.lblArchivosRestaurados.Name = "lblArchivosRestaurados";
            this.lblArchivosRestaurados.Size = new System.Drawing.Size(28, 13);
            this.lblArchivosRestaurados.TabIndex = 15;
            this.lblArchivosRestaurados.Text = "A.R:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 352);
            this.Controls.Add(this.lblArchivosRestaurados);
            this.Controls.Add(this.lblNE);
            this.Controls.Add(this.lblcontadorArchivos);
            this.Controls.Add(this.lblTotalArchivos);
            this.Controls.Add(this.lblRecibida);
            this.Controls.Add(this.lblDevuelta);
            this.Controls.Add(this.lblNoAutorizados);
            this.Controls.Add(this.lblAutorizados);
            this.Controls.Add(this.lblEnviados);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación Electronica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblEnviados;
        private System.Windows.Forms.Label lblAutorizados;
        private System.Windows.Forms.Label lblNoAutorizados;
        private System.Windows.Forms.ToolStripStatusLabel TollMenuLablelDocumento;
        private System.Windows.Forms.ToolStripStatusLabel TollMenuLablelFecha;
        private System.Windows.Forms.Label lblDevuelta;
        private System.Windows.Forms.Label lblRecibida;
        private System.Windows.Forms.Label lblTotalArchivos;
        private System.Windows.Forms.Label lblcontadorArchivos;
        private System.Windows.Forms.Label lblNE;
        private System.Windows.Forms.Label lblArchivosRestaurados;
    }
}

