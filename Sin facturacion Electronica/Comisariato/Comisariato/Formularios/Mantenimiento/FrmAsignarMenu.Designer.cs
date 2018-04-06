namespace Comisariato.Formularios.Mantenimiento
{
    partial class FrmAsignarMenu
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
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.tvMenuAsignacion = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.btnLimpiarProveedor = new System.Windows.Forms.Button();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(122, 13);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(249, 26);
            this.cbEmpresa.TabIndex = 2;
            this.cbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbEmpresa_SelectedIndexChanged);
            // 
            // tvMenuAsignacion
            // 
            this.tvMenuAsignacion.CheckBoxes = true;
            this.tvMenuAsignacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMenuAsignacion.Location = new System.Drawing.Point(43, 99);
            this.tvMenuAsignacion.Name = "tvMenuAsignacion";
            this.tvMenuAsignacion.Size = new System.Drawing.Size(321, 382);
            this.tvMenuAsignacion.TabIndex = 4;
            this.tvMenuAsignacion.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvMenuAsignacion_AfterCheck);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(35, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(122, 49);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(249, 26);
            this.cbUsuario.TabIndex = 2;
            this.cbUsuario.Enter += new System.EventHandler(this.cbUsuario_Enter);
            // 
            // btnLimpiarProveedor
            // 
            this.btnLimpiarProveedor.Font = new System.Drawing.Font("Arial", 12F);
            this.btnLimpiarProveedor.ForeColor = System.Drawing.Color.Teal;
            this.btnLimpiarProveedor.Image = global::Comisariato.Properties.Resources.limpiar;
            this.btnLimpiarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarProveedor.Location = new System.Drawing.Point(206, 490);
            this.btnLimpiarProveedor.Name = "btnLimpiarProveedor";
            this.btnLimpiarProveedor.Size = new System.Drawing.Size(134, 84);
            this.btnLimpiarProveedor.TabIndex = 34;
            this.btnLimpiarProveedor.Text = "&Limpiar";
            this.btnLimpiarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Font = new System.Drawing.Font("Arial", 12F);
            this.btnGuardarProveedor.ForeColor = System.Drawing.Color.Teal;
            this.btnGuardarProveedor.Image = global::Comisariato.Properties.Resources.guardar11;
            this.btnGuardarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProveedor.Location = new System.Drawing.Point(66, 490);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(133, 84);
            this.btnGuardarProveedor.TabIndex = 33;
            this.btnGuardarProveedor.Text = "&Guardar";
            this.btnGuardarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // FrmAsignarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(407, 586);
            this.Controls.Add(this.btnLimpiarProveedor);
            this.Controls.Add(this.btnGuardarProveedor);
            this.Controls.Add(this.tvMenuAsignacion);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEmpresa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(423, 532);
            this.Name = "FrmAsignarMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Menu";
            this.Load += new System.EventHandler(this.FrmAsignarMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.TreeView tvMenuAsignacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Button btnLimpiarProveedor;
        private System.Windows.Forms.Button btnGuardarProveedor;
    }
}