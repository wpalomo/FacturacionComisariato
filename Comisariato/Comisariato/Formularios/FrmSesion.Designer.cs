namespace Comisariato
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PanelSesion = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.BtnIniciar = new iTalk.iTalk_Button_1();
            this.lblError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PboxSalir = new System.Windows.Forms.PictureBox();
            this.PanelSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSesion
            // 
            this.PanelSesion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelSesion.Controls.Add(this.txtContraseña);
            this.PanelSesion.Controls.Add(this.txtUsuario);
            this.PanelSesion.Controls.Add(this.cbEmpresa);
            this.PanelSesion.Controls.Add(this.BtnIniciar);
            this.PanelSesion.Controls.Add(this.lblError);
            this.PanelSesion.Controls.Add(this.label2);
            this.PanelSesion.Controls.Add(this.label3);
            this.PanelSesion.Controls.Add(this.label1);
            this.PanelSesion.Location = new System.Drawing.Point(168, 125);
            this.PanelSesion.Name = "PanelSesion";
            this.PanelSesion.Size = new System.Drawing.Size(313, 329);
            this.PanelSesion.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(45, 183);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(232, 25);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Text = "tita";
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(42, 129);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(232, 25);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "ADMIN";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cbEmpresa.DropDownHeight = 100;
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.IntegralHeight = false;
            this.cbEmpresa.Location = new System.Drawing.Point(42, 78);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(232, 25);
            this.cbEmpresa.TabIndex = 2;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BtnIniciar.Image = null;
            this.BtnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIniciar.Location = new System.Drawing.Point(93, 257);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(136, 30);
            this.BtnIniciar.TabIndex = 3;
            this.BtnIniciar.Text = "INICIAR";
            this.BtnIniciar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click_2);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(42, 219);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "CONTRASEÑA:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "EMPRESA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "USUARIO:";
            // 
            // PboxSalir
            // 
            this.PboxSalir.Image = global::Comisariato.Properties.Resources.cerrar1;
            this.PboxSalir.Location = new System.Drawing.Point(596, 1);
            this.PboxSalir.Name = "PboxSalir";
            this.PboxSalir.Size = new System.Drawing.Size(36, 31);
            this.PboxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PboxSalir.TabIndex = 2;
            this.PboxSalir.TabStop = false;
            this.PboxSalir.Click += new System.EventHandler(this.PboxSalir_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Comisariato.Properties.Resources.Splashaircontrol;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(637, 489);
            this.Controls.Add(this.PboxSalir);
            this.Controls.Add(this.PanelSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.PanelSesion.ResumeLayout(false);
            this.PanelSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSesion;
        private System.Windows.Forms.PictureBox PboxSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label3;
        private iTalk.iTalk_Button_1 BtnIniciar;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}

