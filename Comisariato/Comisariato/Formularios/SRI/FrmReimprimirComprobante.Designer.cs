namespace Comisariato.Formularios.SRI
{
    partial class FrmReimprimirComprobante
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
            this.label14 = new System.Windows.Forms.Label();
            this.TxtNumeroComprobante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnimprimirRide = new System.Windows.Forms.Button();
            this.txtNAutorizacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(10, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 16);
            this.label14.TabIndex = 36;
            this.label14.Text = "Aut. SRI/Clave Acceso:";
            // 
            // TxtNumeroComprobante
            // 
            this.TxtNumeroComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroComprobante.Location = new System.Drawing.Point(180, 38);
            this.TxtNumeroComprobante.MaxLength = 9;
            this.TxtNumeroComprobante.Multiline = true;
            this.TxtNumeroComprobante.Name = "TxtNumeroComprobante";
            this.TxtNumeroComprobante.Size = new System.Drawing.Size(75, 26);
            this.TxtNumeroComprobante.TabIndex = 1;
            this.TxtNumeroComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroComprobante_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Número Comprobante:";
            // 
            // BtnimprimirRide
            // 
            this.BtnimprimirRide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnimprimirRide.Image = global::Comisariato.Properties.Resources.impresoraRide32x32;
            this.BtnimprimirRide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnimprimirRide.Location = new System.Drawing.Point(249, 127);
            this.BtnimprimirRide.Name = "BtnimprimirRide";
            this.BtnimprimirRide.Size = new System.Drawing.Size(141, 45);
            this.BtnimprimirRide.TabIndex = 3;
            this.BtnimprimirRide.Text = "Imprimir Ride";
            this.BtnimprimirRide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnimprimirRide.UseVisualStyleBackColor = true;
            this.BtnimprimirRide.Click += new System.EventHandler(this.BtnimprimirRide_Click);
            // 
            // txtNAutorizacion
            // 
            this.txtNAutorizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAutorizacion.Location = new System.Drawing.Point(180, 80);
            this.txtNAutorizacion.MaxLength = 49;
            this.txtNAutorizacion.Multiline = true;
            this.txtNAutorizacion.Name = "txtNAutorizacion";
            this.txtNAutorizacion.Size = new System.Drawing.Size(395, 26);
            this.txtNAutorizacion.TabIndex = 2;
            // 
            // FrmReimprimirComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(603, 184);
            this.Controls.Add(this.txtNAutorizacion);
            this.Controls.Add(this.BtnimprimirRide);
            this.Controls.Add(this.TxtNumeroComprobante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(619, 223);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(619, 223);
            this.Name = "FrmReimprimirComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reimprimir Comprobante";
            this.Load += new System.EventHandler(this.FrmReimprimirComprobante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtNumeroComprobante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnimprimirRide;
        private System.Windows.Forms.TextBox txtNAutorizacion;
    }
}