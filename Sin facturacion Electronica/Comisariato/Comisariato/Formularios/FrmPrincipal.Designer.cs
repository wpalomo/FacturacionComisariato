namespace Comisariato.Formularios
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Administrar Clientes");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Administrar Proveedores");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Administrar Usuarios");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cajas/Talonarios");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Impresion de Factura");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Empresa");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Sucursales");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Administrar Empresas", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Administrar Empleados");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Administrar Menu");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Mantenimiento", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Productos");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Categoria Producto");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Creacion de Bodega");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Combo de Productos");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Asignacion de Producto por Bodega");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Inventario", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Ventas");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Compras");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Devolución en Compras");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Devolución en Venta");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Orden de Giro");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Factura de Servicios o Gastos");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Transacciones", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Kardex");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Informe Ventas");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Informe Compras");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Informe Retención");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Informe Nota de Crédito");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Informe Nota de Débito");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Informe Caja");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Informes", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tvPrincipal = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuIzq = new System.Windows.Forms.MenuStrip();
            this.sssssssssssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal2 = new System.Windows.Forms.MenuStrip();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1.SuspendLayout();
            this.MenuIzq.SuspendLayout();
            this.msPrincipal2.SuspendLayout();
            this.msPrincipal1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvPrincipal
            // 
            this.tvPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvPrincipal.BackColor = System.Drawing.Color.Bisque;
            this.tvPrincipal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvPrincipal.FullRowSelect = true;
            this.tvPrincipal.Location = new System.Drawing.Point(0, 48);
            this.tvPrincipal.Margin = new System.Windows.Forms.Padding(5);
            this.tvPrincipal.Name = "tvPrincipal";
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Administrar Clientes";
            treeNode2.Name = "Nodo2";
            treeNode2.Text = "Administrar Proveedores";
            treeNode3.Name = "Nodo15";
            treeNode3.Text = "Administrar Usuarios";
            treeNode4.Name = "Nodo1";
            treeNode4.Text = "Cajas/Talonarios";
            treeNode5.Name = "Nodo2";
            treeNode5.Text = "Impresion de Factura";
            treeNode6.Name = "Nodo3";
            treeNode6.Text = "Empresa";
            treeNode7.Name = "Nodo4";
            treeNode7.Text = "Sucursales";
            treeNode8.Name = "Nodo16";
            treeNode8.Text = "Administrar Empresas";
            treeNode9.Name = "Nodo0";
            treeNode9.Text = "Administrar Empleados";
            treeNode10.Name = "nodoMenu";
            treeNode10.Text = "Administrar Menu";
            treeNode11.Name = "nodoMantenimiento";
            treeNode11.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode11.Text = "Mantenimiento";
            treeNode12.Name = "Nodo7";
            treeNode12.Text = "Productos";
            treeNode13.Name = "Nodo8";
            treeNode13.Text = "Categoria Producto";
            treeNode14.Name = "Nodo9";
            treeNode14.Text = "Creacion de Bodega";
            treeNode15.Name = "Nodo10";
            treeNode15.Text = "Combo de Productos";
            treeNode16.Name = "Nodo11";
            treeNode16.Text = "Asignacion de Producto por Bodega";
            treeNode17.Name = "nodoInventario";
            treeNode17.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode17.Text = "Inventario";
            treeNode18.Name = "Nodo3";
            treeNode18.Text = "Ventas";
            treeNode19.Name = "Nodo5";
            treeNode19.Text = "Compras";
            treeNode20.Name = "Nodo6";
            treeNode20.Text = "Devolución en Compras";
            treeNode21.Name = "Nodo1";
            treeNode21.Text = "Devolución en Venta";
            treeNode22.Name = "Nodo0";
            treeNode22.Text = "Orden de Giro";
            treeNode23.Name = "Nodo0";
            treeNode23.Text = "Factura de Servicios o Gastos";
            treeNode24.Name = "nodoTransaccion";
            treeNode24.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode24.Text = "Transacciones";
            treeNode25.Name = "Nodo14";
            treeNode25.Text = "Kardex";
            treeNode26.Name = "Nodo0";
            treeNode26.Text = "Informe Ventas";
            treeNode27.Name = "Nodo0";
            treeNode27.Text = "Informe Compras";
            treeNode28.Name = "Nodo1";
            treeNode28.Text = "Informe Retención";
            treeNode29.Name = "Nodo4";
            treeNode29.Text = "Informe Nota de Crédito";
            treeNode30.Name = "Nodo5";
            treeNode30.Text = "Informe Nota de Débito";
            treeNode31.Name = "Nodo0";
            treeNode31.Text = "Informe Caja";
            treeNode32.Name = "nodoInforme";
            treeNode32.NodeFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode32.Text = "Informes";
            this.tvPrincipal.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode17,
            treeNode24,
            treeNode32});
            this.tvPrincipal.Size = new System.Drawing.Size(239, 592);
            this.tvPrincipal.TabIndex = 0;
            this.tvPrincipal.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvPrincipal_NodeMouseClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1342, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 17);
            this.lblFecha.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuIzq
            // 
            this.MenuIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuIzq.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sssssssssssToolStripMenuItem});
            this.MenuIzq.Location = new System.Drawing.Point(0, 48);
            this.MenuIzq.Name = "MenuIzq";
            this.MenuIzq.Size = new System.Drawing.Size(239, 592);
            this.MenuIzq.TabIndex = 13;
            this.MenuIzq.Text = "menuStrip3";
            // 
            // sssssssssssToolStripMenuItem
            // 
            this.sssssssssssToolStripMenuItem.Name = "sssssssssssToolStripMenuItem";
            this.sssssssssssToolStripMenuItem.Size = new System.Drawing.Size(226, 19);
            this.sssssssssssToolStripMenuItem.Text = "holaholaholaholaholaholaholaholaholah";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = global::Comisariato.Properties.Resources.icono_libro;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 20);
            this.toolStripMenuItem1.Text = "Panel de Contenido";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inicioToolStripMenuItem.Image = global::Comisariato.Properties.Resources.inicio;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Image = global::Comisariato.Properties.Resources.calendario;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.ayudaToolStripMenuItem.Text = "Calendario";
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.contactosToolStripMenuItem.Image = global::Comisariato.Properties.Resources.contactos;
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.contactosToolStripMenuItem.Text = "Contactos";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.emailToolStripMenuItem.Image = global::Comisariato.Properties.Resources.email;
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.emailToolStripMenuItem.Text = "E-mail";
            // 
            // msPrincipal2
            // 
            this.msPrincipal2.BackColor = System.Drawing.Color.SteelBlue;
            this.msPrincipal2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPrincipal2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.inicioToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.contactosToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.calculadoraToolStripMenuItem});
            this.msPrincipal2.Location = new System.Drawing.Point(0, 24);
            this.msPrincipal2.MdiWindowListItem = this.inicioToolStripMenuItem;
            this.msPrincipal2.Name = "msPrincipal2";
            this.msPrincipal2.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.msPrincipal2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msPrincipal2.Size = new System.Drawing.Size(1342, 24);
            this.msPrincipal2.TabIndex = 2;
            this.msPrincipal2.Text = "menuStrip1";
            this.msPrincipal2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msPrincipal_ItemClicked);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.calculadoraToolStripMenuItem.Image = global::Comisariato.Properties.Resources.calculadora_1;
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.tsmCerrarSesion});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // tsmCerrarSesion
            // 
            this.tsmCerrarSesion.Name = "tsmCerrarSesion";
            this.tsmCerrarSesion.Size = new System.Drawing.Size(182, 22);
            this.tsmCerrarSesion.Text = "Cerrar Sesion";
            this.tsmCerrarSesion.Click += new System.EventHandler(this.tsmCerrarSesion_Click_1);
            // 
            // msPrincipal1
            // 
            this.msPrincipal1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanaToolStripMenuItem,
            this.ayudaToolStripMenuItem1,
            this.opcionesToolStripMenuItem});
            this.msPrincipal1.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal1.MdiWindowListItem = this.ventanaToolStripMenuItem;
            this.msPrincipal1.Name = "msPrincipal1";
            this.msPrincipal1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msPrincipal1.Size = new System.Drawing.Size(1342, 24);
            this.msPrincipal1.TabIndex = 1;
            this.msPrincipal1.Text = "menuStrip1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1342, 662);
            this.Controls.Add(this.tvPrincipal);
            this.Controls.Add(this.MenuIzq);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msPrincipal2);
            this.Controls.Add(this.msPrincipal1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "AirControl System ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MenuIzq.ResumeLayout(false);
            this.MenuIzq.PerformLayout();
            this.msPrincipal2.ResumeLayout(false);
            this.msPrincipal2.PerformLayout();
            this.msPrincipal1.ResumeLayout(false);
            this.msPrincipal1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvPrincipal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.MenuStrip MenuIzq;
        private System.Windows.Forms.ToolStripMenuItem sssssssssssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msPrincipal2;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCerrarSesion;
        private System.Windows.Forms.MenuStrip msPrincipal1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
    }
}