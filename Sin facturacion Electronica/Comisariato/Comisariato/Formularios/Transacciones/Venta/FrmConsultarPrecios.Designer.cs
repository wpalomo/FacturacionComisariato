namespace Comisariato.Formularios.Transacciones.Venta
{
    partial class FrmConsultarPrecios
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
            this.TxtPrecioPVP = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirCompra = new System.Windows.Forms.Button();
            this.TxtPrecioCaja = new System.Windows.Forms.Label();
            this.TxtPrecioMayorista = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPrecioPVP
            // 
            this.TxtPrecioPVP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrecioPVP.BackColor = System.Drawing.Color.White;
            this.TxtPrecioPVP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecioPVP.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioPVP.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TxtPrecioPVP.Location = new System.Drawing.Point(19, 64);
            this.TxtPrecioPVP.Name = "TxtPrecioPVP";
            this.TxtPrecioPVP.Size = new System.Drawing.Size(167, 78);
            this.TxtPrecioPVP.TabIndex = 34;
            this.TxtPrecioPVP.Text = "0.00";
            this.TxtPrecioPVP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(212, 159);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(175, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(148, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Consulta de Producto";
            // 
            // btnSalirCompra
            // 
            this.btnSalirCompra.Image = global::Comisariato.Properties.Resources.salir2;
            this.btnSalirCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirCompra.Location = new System.Drawing.Point(245, 196);
            this.btnSalirCompra.Name = "btnSalirCompra";
            this.btnSalirCompra.Size = new System.Drawing.Size(96, 53);
            this.btnSalirCompra.TabIndex = 38;
            this.btnSalirCompra.Text = "Salir";
            this.btnSalirCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirCompra.UseVisualStyleBackColor = true;
            this.btnSalirCompra.Click += new System.EventHandler(this.btnSalirCompra_Click);
            // 
            // TxtPrecioCaja
            // 
            this.TxtPrecioCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrecioCaja.BackColor = System.Drawing.Color.White;
            this.TxtPrecioCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecioCaja.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioCaja.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TxtPrecioCaja.Location = new System.Drawing.Point(387, 64);
            this.TxtPrecioCaja.Name = "TxtPrecioCaja";
            this.TxtPrecioCaja.Size = new System.Drawing.Size(167, 78);
            this.TxtPrecioCaja.TabIndex = 40;
            this.TxtPrecioCaja.Text = "0.00";
            this.TxtPrecioCaja.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtPrecioMayorista
            // 
            this.TxtPrecioMayorista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrecioMayorista.BackColor = System.Drawing.Color.White;
            this.TxtPrecioMayorista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecioMayorista.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioMayorista.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TxtPrecioMayorista.Location = new System.Drawing.Point(203, 64);
            this.TxtPrecioMayorista.Name = "TxtPrecioMayorista";
            this.TxtPrecioMayorista.Size = new System.Drawing.Size(167, 78);
            this.TxtPrecioMayorista.TabIndex = 39;
            this.TxtPrecioMayorista.Text = "0.00";
            this.TxtPrecioMayorista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(72, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "P.V.P.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(226, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "Precio Mayorista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(410, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "Precio Caja";
            // 
            // FrmConsultarPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(592, 261);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPrecioCaja);
            this.Controls.Add(this.TxtPrecioMayorista);
            this.Controls.Add(this.btnSalirCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPrecioPVP);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmConsultarPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Precios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultarPrecios_FormClosed);
            this.Load += new System.EventHandler(this.FrmConsultarPrecios_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmConsultarPrecios_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtPrecioPVP;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirCompra;
        private System.Windows.Forms.Label TxtPrecioCaja;
        private System.Windows.Forms.Label TxtPrecioMayorista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}