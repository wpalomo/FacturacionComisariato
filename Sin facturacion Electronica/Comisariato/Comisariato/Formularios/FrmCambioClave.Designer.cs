namespace Comisariato.Formularios
{
    partial class FrmCambioClave
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
            this.ckbNueva = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.ckbActual = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbValidar = new System.Windows.Forms.Label();
            this.btnLimpiarProveedor = new System.Windows.Forms.Button();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbNueva
            // 
            this.ckbNueva.AutoSize = true;
            this.ckbNueva.Font = new System.Drawing.Font("Arial", 12F);
            this.ckbNueva.Location = new System.Drawing.Point(334, 74);
            this.ckbNueva.Margin = new System.Windows.Forms.Padding(2);
            this.ckbNueva.Name = "ckbNueva";
            this.ckbNueva.Size = new System.Drawing.Size(15, 14);
            this.ckbNueva.TabIndex = 16;
            this.ckbNueva.UseVisualStyleBackColor = true;
            this.ckbNueva.CheckedChanged += new System.EventHandler(this.ckbNueva_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(18, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Confirmar contraseña:";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Font = new System.Drawing.Font("Arial", 12F);
            this.txtConfirmar.Location = new System.Drawing.Point(193, 110);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(133, 26);
            this.txtConfirmar.TabIndex = 2;
            this.txtConfirmar.UseSystemPasswordChar = true;
            // 
            // txtNueva
            // 
            this.txtNueva.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNueva.Location = new System.Drawing.Point(193, 68);
            this.txtNueva.Margin = new System.Windows.Forms.Padding(2);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Size = new System.Drawing.Size(133, 26);
            this.txtNueva.TabIndex = 1;
            this.txtNueva.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contraseña nueva:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contraseña actual:";
            // 
            // txtActual
            // 
            this.txtActual.Font = new System.Drawing.Font("Arial", 12F);
            this.txtActual.Location = new System.Drawing.Point(193, 27);
            this.txtActual.Margin = new System.Windows.Forms.Padding(2);
            this.txtActual.Name = "txtActual";
            this.txtActual.Size = new System.Drawing.Size(137, 26);
            this.txtActual.TabIndex = 0;
            this.txtActual.UseSystemPasswordChar = true;
            // 
            // ckbActual
            // 
            this.ckbActual.AutoSize = true;
            this.ckbActual.Font = new System.Drawing.Font("Arial", 12F);
            this.ckbActual.Location = new System.Drawing.Point(334, 33);
            this.ckbActual.Margin = new System.Windows.Forms.Padding(2);
            this.ckbActual.Name = "ckbActual";
            this.ckbActual.Size = new System.Drawing.Size(15, 14);
            this.ckbActual.TabIndex = 16;
            this.ckbActual.UseVisualStyleBackColor = true;
            this.ckbActual.CheckedChanged += new System.EventHandler(this.ckbActual_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ckbActual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ckbNueva);
            this.groupBox1.Controls.Add(this.txtNueva);
            this.groupBox1.Controls.Add(this.lbValidar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtActual);
            this.groupBox1.Controls.Add(this.txtConfirmar);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 181);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre Usuario";
            // 
            // lbValidar
            // 
            this.lbValidar.AutoSize = true;
            this.lbValidar.Font = new System.Drawing.Font("Arial", 12F);
            this.lbValidar.ForeColor = System.Drawing.Color.Teal;
            this.lbValidar.Location = new System.Drawing.Point(86, 149);
            this.lbValidar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbValidar.Name = "lbValidar";
            this.lbValidar.Size = new System.Drawing.Size(0, 18);
            this.lbValidar.TabIndex = 15;
            // 
            // btnLimpiarProveedor
            // 
            this.btnLimpiarProveedor.Image = global::Comisariato.Properties.Resources.limpiar;
            this.btnLimpiarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarProveedor.Location = new System.Drawing.Point(212, 199);
            this.btnLimpiarProveedor.Name = "btnLimpiarProveedor";
            this.btnLimpiarProveedor.Size = new System.Drawing.Size(134, 67);
            this.btnLimpiarProveedor.TabIndex = 25;
            this.btnLimpiarProveedor.Text = "&Limpiar";
            this.btnLimpiarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarProveedor.UseVisualStyleBackColor = true;
            this.btnLimpiarProveedor.Click += new System.EventHandler(this.btnLimpiarProveedor_Click);
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Image = global::Comisariato.Properties.Resources.guardar11;
            this.btnGuardarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProveedor.Location = new System.Drawing.Point(50, 199);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(137, 67);
            this.btnGuardarProveedor.TabIndex = 24;
            this.btnGuardarProveedor.Text = "&Guardar";
            this.btnGuardarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // FrmCambioClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(396, 269);
            this.Controls.Add(this.btnLimpiarProveedor);
            this.Controls.Add(this.btnGuardarProveedor);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCambioClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbNueva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.CheckBox ckbActual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbValidar;
        private System.Windows.Forms.Button btnLimpiarProveedor;
        private System.Windows.Forms.Button btnGuardarProveedor;
    }
}