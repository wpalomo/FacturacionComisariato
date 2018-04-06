namespace Comisariato.Formularios.Transacciones
{
    partial class FrmDatosClientes
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
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.dgvDatosUsuario = new System.Windows.Forms.DataGridView();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Consultar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Font = new System.Drawing.Font("Arial", 14.25F);
            this.TxtConsulta.Location = new System.Drawing.Point(130, 19);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(277, 29);
            this.TxtConsulta.TabIndex = 0;
            this.TxtConsulta.TextChanged += new System.EventHandler(this.TxtConsulta_TextChanged);
            this.TxtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConsulta_KeyPress);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.dgvDatosUsuario);
            this.gbBuscar.Controls.Add(this.TxtConsulta);
            this.gbBuscar.Controls.Add(this.label1);
            this.gbBuscar.Location = new System.Drawing.Point(23, 66);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(853, 338);
            this.gbBuscar.TabIndex = 22;
            this.gbBuscar.TabStop = false;
            // 
            // dgvDatosUsuario
            // 
            this.dgvDatosUsuario.AllowUserToAddRows = false;
            this.dgvDatosUsuario.AllowUserToDeleteRows = false;
            this.dgvDatosUsuario.AllowUserToOrderColumns = true;
            this.dgvDatosUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDatosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosUsuario.Location = new System.Drawing.Point(26, 58);
            this.dgvDatosUsuario.Name = "dgvDatosUsuario";
            this.dgvDatosUsuario.ReadOnly = true;
            this.dgvDatosUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosUsuario.Size = new System.Drawing.Size(800, 258);
            this.dgvDatosUsuario.TabIndex = 1;
            this.dgvDatosUsuario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosUsuario_CellContentDoubleClick);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Teal;
            this.lbltitulo.Location = new System.Drawing.Point(376, 23);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(156, 24);
            this.lbltitulo.TabIndex = 21;
            this.lbltitulo.Text = "Datos Clientes";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(745, 407);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 46);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmDatosClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(901, 458);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDatosClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDatosClientes_FormClosed);
            this.Load += new System.EventHandler(this.FrmDatosClientes_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmDatosClientes_KeyUp);
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.DataGridView dgvDatosUsuario;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnSalir;
    }
}