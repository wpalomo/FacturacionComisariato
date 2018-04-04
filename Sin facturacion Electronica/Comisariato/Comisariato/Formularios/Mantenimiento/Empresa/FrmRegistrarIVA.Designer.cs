namespace Comisariato.Formularios.Mantenimiento.Empresa
{
    partial class FrmRegistrarIVA
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiarIva = new System.Windows.Forms.Button();
            this.btnGuardarIva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "IVA:";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(117, 38);
            this.txtIva.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(86, 29);
            this.txtIva.TabIndex = 11;
            this.txtIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIva_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(209, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "%";
            // 
            // btnLimpiarIva
            // 
            this.btnLimpiarIva.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnLimpiarIva.ForeColor = System.Drawing.Color.Teal;
            this.btnLimpiarIva.Image = global::Comisariato.Properties.Resources.LIMPIAR32X32;
            this.btnLimpiarIva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarIva.Location = new System.Drawing.Point(155, 88);
            this.btnLimpiarIva.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLimpiarIva.Name = "btnLimpiarIva";
            this.btnLimpiarIva.Size = new System.Drawing.Size(98, 42);
            this.btnLimpiarIva.TabIndex = 29;
            this.btnLimpiarIva.Text = "&Limpiar";
            this.btnLimpiarIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarIva.UseVisualStyleBackColor = true;
            this.btnLimpiarIva.Click += new System.EventHandler(this.btnLimpiarIva_Click);
            // 
            // btnGuardarIva
            // 
            this.btnGuardarIva.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnGuardarIva.ForeColor = System.Drawing.Color.Teal;
            this.btnGuardarIva.Image = global::Comisariato.Properties.Resources.GUARDAR32X32;
            this.btnGuardarIva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarIva.Location = new System.Drawing.Point(47, 88);
            this.btnGuardarIva.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGuardarIva.Name = "btnGuardarIva";
            this.btnGuardarIva.Size = new System.Drawing.Size(102, 42);
            this.btnGuardarIva.TabIndex = 28;
            this.btnGuardarIva.Text = "&Guardar";
            this.btnGuardarIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarIva.UseVisualStyleBackColor = true;
            this.btnGuardarIva.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // FrmRegistrarIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(300, 144);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiarIva);
            this.Controls.Add(this.btnGuardarIva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIva);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRegistrarIVA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistrarIVA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Button btnLimpiarIva;
        private System.Windows.Forms.Button btnGuardarIva;
        private System.Windows.Forms.Label label2;
    }
}