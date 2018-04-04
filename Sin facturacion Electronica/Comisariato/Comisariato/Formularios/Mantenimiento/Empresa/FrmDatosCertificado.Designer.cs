namespace Comisariato.Formularios.Mantenimiento.Empresa
{
    partial class FrmDatosCertificado
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
            this.label13 = new System.Windows.Forms.Label();
            this.TxtContraCertificado = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.gbSRIEmpresa = new System.Windows.Forms.GroupBox();
            this.gbSRIEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label13.Location = new System.Drawing.Point(11, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ingrese la Contraseña:";
            // 
            // TxtContraCertificado
            // 
            this.TxtContraCertificado.BackColor = System.Drawing.SystemColors.Window;
            this.TxtContraCertificado.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtContraCertificado.Location = new System.Drawing.Point(117, 52);
            this.TxtContraCertificado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtContraCertificado.Name = "TxtContraCertificado";
            this.TxtContraCertificado.Size = new System.Drawing.Size(201, 22);
            this.TxtContraCertificado.TabIndex = 5;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(251, 81);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(67, 25);
            this.BtnAceptar.TabIndex = 12;
            this.BtnAceptar.Text = "&Agregar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // gbSRIEmpresa
            // 
            this.gbSRIEmpresa.Controls.Add(this.BtnAceptar);
            this.gbSRIEmpresa.Controls.Add(this.TxtContraCertificado);
            this.gbSRIEmpresa.Controls.Add(this.label13);
            this.gbSRIEmpresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSRIEmpresa.ForeColor = System.Drawing.Color.Teal;
            this.gbSRIEmpresa.Location = new System.Drawing.Point(12, 13);
            this.gbSRIEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSRIEmpresa.Name = "gbSRIEmpresa";
            this.gbSRIEmpresa.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSRIEmpresa.Size = new System.Drawing.Size(352, 116);
            this.gbSRIEmpresa.TabIndex = 12;
            this.gbSRIEmpresa.TabStop = false;
            this.gbSRIEmpresa.Text = "CERTIFICADO";
            // 
            // FrmDatosCertificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(386, 145);
            this.Controls.Add(this.gbSRIEmpresa);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDatosCertificado";
            this.Text = "Datos Certificado Digital";
            this.gbSRIEmpresa.ResumeLayout(false);
            this.gbSRIEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtContraCertificado;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.GroupBox gbSRIEmpresa;
    }
}