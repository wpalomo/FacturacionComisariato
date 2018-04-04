using Comisariato.Clases;
using Comisariato.Formularios.Cartera;
using Comisariato.Formularios.Informes;
using Comisariato.Formularios.Mantenimiento;
using Comisariato.Formularios.Mantenimiento.Empresa;
using Comisariato.Formularios.Mantenimiento.Inventario;
using Comisariato.Formularios.SRI;
using Comisariato.Formularios.Transacciones;
using Comisariato.Formularios.Transacciones.Devolucion_Venta;
using Comisariato.Formularios.Transacciones.Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios
{
    public partial class FrmPrincipal : Form
    {


        public static FrmClientes FrmCliente;
        public static FrmProveedores FrmProveedor;
        public static FrmUsuarios FrmUsuario;
        public static FrmEmpresa FrmEmpresa;
        public static FrmProductos FrmProducto;
        public static FrmCategoriaProductos FrmCategoriaProducto;
        public static FrmCreacionBodega FrmCreacionBodega;
        public static FrmComboProductos FrmComboProducto;
        public static FrmClaveUsuario FrmClaveUsuario;
        public static FrmCompra FrmCompra;
        public static FrmCajasTalonario FrmCajasTalonario;
        public static FrmParametrosFactura FrmParametrosFactura;
        public static FrmSucursal FrmSucursal;
        public static FrmAsignacionProductoBodega FrmAsignacionProductoBodega;
        public static FrmEmpleado FrmEmpleado;
        public static FrmOrdenDeGiro FrmOrdenDeGiro;
        public static FrmDevolucionVenta FrmDevolucionVenta;
        public static FrmAsignarMenu FrmAsignarMenu;
        public static FrmInformeVentas FrmInformeVentas;
        public static FrmInformesCompras FrmInformesCompras;
        public static FrmInformesRentenciones FrmInformesRentenciones;
        public static MenuStrip menuMostrar;
        public static FrmKardex FrmKardex;
        public static FrmDevolucionCompra FrmDevolucionCompra;
        public static FrmDeclaracionSRI FrmDeclaracionSRI;
        public static FrmCambioClave FrmCambioClave;
        public static FrmRegistrarIVA FrmRegistrarIVA;
        public static FrmInformesCajas FrmInformesCajas;
        public static FrmComprobantesSri FrmComprobantesSri;
        public static FrmFacturaGastos FrmFacturaGastos;
        public static FormAts Formats ;
        public static FrmInformeNotaCredito FrmInformeNotaCredito;
        public static FrmAdministrarPromociones FrmAdministrarPromocion;
        public static FrmCuentasPorPagar FrmCuentasPorPagar;
        public bool primerIngresoSistema;

        Bitacora  bitacora = new Bitacora();
        //public static void Panel
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        Funcion objFuncion = new Funcion();
        Consultas objConsulta = new Consultas();


        private void tvPrincipal_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Program.panelPrincipalVariable = this;

            string nombre = e.Node.Text;
            //-------------------------------------------------Mantenimiento---------------------------------------//
            //---------------------Cliente --------------------------------------//
            if (nombre == "Administrar Clientes")
            {
                if (FrmCliente == null || FrmCliente.IsDisposed)
                {
                    FrmCliente = new FrmClientes();
                    FrmCliente.MdiParent = this;
                    FrmCliente.Show();
                }
                else
                    FrmCliente.BringToFront();
            }
            //---------------------Empleado --------------------------------------//
            else if (nombre == "Administrar Empleados")
            {
                if (FrmEmpleado == null || FrmEmpleado.IsDisposed)
                {
                    FrmEmpleado = new FrmEmpleado();
                    FrmEmpleado.MdiParent = this;
                    FrmEmpleado.Show();
                }
                else { FrmEmpleado.BringToFront(); }
            }
            else if (nombre == "Administrar Menu")
            {
                if (FrmAsignarMenu == null || FrmAsignarMenu.IsDisposed)
                {
                    FrmAsignarMenu = new FrmAsignarMenu();
                    FrmAsignarMenu.MdiParent = this;
                    FrmAsignarMenu.Show();

                }
                else { FrmAsignarMenu.BringToFront(); }
            }
            //--------------------Empresa---------------------------------------//
            else if (nombre == "Cajas/Talonarios")
            {
                if (FrmCajasTalonario == null || FrmCajasTalonario.IsDisposed)
                {
                    FrmCajasTalonario = new FrmCajasTalonario();
                    FrmCajasTalonario.MdiParent = this;
                    FrmCajasTalonario.Show();
                }
                else { FrmCajasTalonario.BringToFront(); }
            }
            else if (nombre == "Informe Ventas")
            {
                if (FrmInformeVentas == null || FrmInformeVentas.IsDisposed)
                {
                    FrmInformeVentas = new FrmInformeVentas();
                    FrmInformeVentas.MdiParent = this;
                    FrmInformeVentas.Show();
                }
                else { FrmInformeVentas.BringToFront(); }
            }
            else if (nombre == "Factura de Servicios o Gastos")
            {
                if (FrmFacturaGastos == null || FrmFacturaGastos.IsDisposed)
                {
                    FrmFacturaGastos = new FrmFacturaGastos();
                    FrmFacturaGastos.MdiParent = this;
                    FrmFacturaGastos.Show();
                }
                else { FrmFacturaGastos.BringToFront(); }
            }
            else if (nombre == "Informe Compras")
            {
                //        FrmInformesCompras;
                //public static FrmInformesOrdenGiro FrmInformesOrdenGiro;
                if (FrmInformesCompras == null || FrmInformesCompras.IsDisposed)
                {
                    FrmInformesCompras = new FrmInformesCompras();
                    FrmInformesCompras.MdiParent = this;
                    FrmInformesCompras.Show();
                }
                else { FrmInformesCompras.BringToFront(); }
            }
            else if (nombre == "Informe Retención")
            {
                //hillbsasvdb
                if (FrmInformesRentenciones == null || FrmInformesRentenciones.IsDisposed)
                {
                    FrmInformesRentenciones = new FrmInformesRentenciones();
                    FrmInformesRentenciones.MdiParent = this;
                    FrmInformesRentenciones.Show();
                }
                else { FrmInformesRentenciones.BringToFront(); }
            }
            else if (nombre == "Empresa")
            {
                if (FrmEmpresa == null || FrmEmpresa.IsDisposed)
                {
                    FrmEmpresa = new FrmEmpresa();
                    FrmEmpresa.MdiParent = this;
                    FrmEmpresa.Show();
                }
                else { FrmEmpresa.BringToFront(); }
            }
            else if (nombre == "Impresion de Factura")
            {
                if (FrmParametrosFactura == null || FrmParametrosFactura.IsDisposed)
                {
                    FrmParametrosFactura = new FrmParametrosFactura();
                    FrmParametrosFactura.MdiParent = this;
                    FrmParametrosFactura.Show();
                }
                else { FrmParametrosFactura.BringToFront(); }
            }
            else if (nombre == "Sucursales")
            {
                if (FrmSucursal == null || FrmSucursal.IsDisposed)
                {
                    FrmSucursal = new FrmSucursal();
                    FrmSucursal.MdiParent = this;
                    FrmSucursal.Show();
                    //FrmSucursal.BringToFront();
                }
                else { FrmSucursal.BringToFront(); }
            }
            //--------------------Proveedores---------------------------------------//
            else if (nombre == "Administrar Proveedores")
            {
                if (FrmProveedor == null || FrmProveedor.IsDisposed)
                {
                    FrmProveedor = new FrmProveedores();
                    FrmProveedor.MdiParent = this;
                    FrmProveedor.Show();

                    //FrmProveedor.BringToFront();
                }
                else { FrmProveedor.BringToFront(); }
            }
            //--------------------Usuarios---------------------------------------//
            else if (nombre == "Administrar Usuarios")
            {
                if (FrmUsuario == null || FrmUsuario.IsDisposed)
                {
                    FrmUsuario = new FrmUsuarios();
                    FrmUsuario.MdiParent = this;
                    FrmUsuario.Show();
                    //FrmUsuario.BringToFront();
                }
                else { FrmUsuario.BringToFront(); }
            }
            //--------------------Inventario---------------------------------------//
            else if (nombre == "Productos")
            {
                if (FrmProducto == null || FrmProducto.IsDisposed)
                {
                    FrmProducto = new FrmProductos();
                    FrmProducto.MdiParent = this;
                    ////FrmProducto.BringToFront();
                    FrmProducto.Show();
                }
                else { FrmProducto.BringToFront(); }
            }
            else if (nombre == "Categoria Producto")
            {
                if (FrmCategoriaProducto == null || FrmCategoriaProducto.IsDisposed)
                {
                    FrmCategoriaProducto = new FrmCategoriaProductos();
                    FrmCategoriaProducto.MdiParent = this;
                    //FrmCategoriaProducto.BringToFront();
                    FrmCategoriaProducto.Show();
                }
                else { FrmCategoriaProducto.BringToFront(); }

            }
            else if (nombre == "Creacion de Bodega")
            {
                if (FrmCreacionBodega == null || FrmCreacionBodega.IsDisposed)
                {
                    FrmCreacionBodega = new FrmCreacionBodega();
                    FrmCreacionBodega.MdiParent = this;
                    //FrmCreacionBodega.BringToFront();
                    FrmCreacionBodega.Show();
                }
                else { FrmCreacionBodega.BringToFront(); }
            }
            else if (nombre == "Combo de Productos")
            {
                if (FrmComboProducto == null || FrmComboProducto.IsDisposed)
                {
                    FrmComboProducto = new FrmComboProductos();
                    FrmComboProducto.MdiParent = this;
                    //FrmComboProducto.BringToFront();
                    FrmComboProducto.Show();
                }
                else { FrmCreacionBodega.BringToFront(); }
            }
            else if (nombre == "Asignacion de Producto por Bodega")
            {
                if (FrmAsignacionProductoBodega == null || FrmAsignacionProductoBodega.IsDisposed)
                {
                    FrmAsignacionProductoBodega = new FrmAsignacionProductoBodega();
                    FrmAsignacionProductoBodega.MdiParent = this;
                    //FrmAsignacionProductoBodega.BringToFront();
                    FrmAsignacionProductoBodega.Show();
                }
                else { FrmAsignacionProductoBodega.BringToFront(); }
            }
            //-------------------------------------------------Transacciones---------------------------------------//
            else if (nombre == "Ventas")
            {
                if (!Program.FormularioVentaAbierto)
                {
                    if (FrmClaveUsuario == null || FrmClaveUsuario.IsDisposed)
                    {
                        FrmClaveUsuario = new FrmClaveUsuario();
                        FrmClaveUsuario.verificarMetodo = 1;
                        FrmClaveUsuario.MdiParent = this;
                        //FrmClaveUsuario.BringToFront();
                        FrmClaveUsuario.Show();
                    }
                    else { FrmClaveUsuario.BringToFront(); }
                }
            }
            else if (nombre == "Compras")
            {
                if (objConsulta.ObtenerValorCampo("IDPROVEEDOR", "TbProveedor", "") != "" && objConsulta.ObtenerValorCampo("IDSUCURSAL", "TbSucursal", "") != "" && objConsulta.ObtenerValorCampo("IDPARAMETROSFACTURA", "TbParametrosFactura", "") != "")
                {
                    if (FrmCompra == null || FrmCompra.IsDisposed)
                    {
                        FrmCompra = new FrmCompra();
                        FrmCompra.MdiParent = this;
                        //FrmCompra.BringToFront();
                        FrmCompra.Show();
                    }
                    else { FrmCompra.BringToFront(); }
                }
                else
                {
                    MessageBox.Show("Para realizar un registro de compra debe de tener registrado lo siguiente:\n*Al menos un proveedor.\n*Al menos una sucursal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (nombre == "Devolución en Compras")
            {
                //string IpMaquina = bitacora.LocalIPAddress();
                //DataTable Dt = objConsulta.BoolDataTable("Select TIPODOCUMENTO, SERIE1,SERIE2,DOCUMENTOACTUAL,DOCUMENTOINICIAL,DOCUMENTOFINAL,AUTORIZACION,ESTACION,IPESTACION from TbCajasTalonario where IPESTACION = '" + IpMaquina + "' and ESTADO=1;");
                //bool banderaCaja = false;
                //if (Dt.Rows.Count > 0)
                //{
                //    for (int i = 0; i < Dt.Rows.Count; i++)
                //    {
                //        banderaCaja = true;
                //        DataRow myRows = Dt.Rows[i];
                //        if (myRows["TIPODOCUMENTO"].ToString() == "NCRE")
                //        {
                //            banderaCaja = false;
                if (FrmDevolucionCompra == null || FrmDevolucionCompra.IsDisposed)
                {
                    FrmDevolucionCompra = new FrmDevolucionCompra();
                    FrmDevolucionCompra.MdiParent = this;
                    //FrmDevolucionVenta.BringToFront();
                    FrmDevolucionCompra.Show();
                    //break;
                }
                else { FrmDevolucionCompra.BringToFront(); }
                //        }
                //    }
                //    if (banderaCaja)
                //    {
                //        MessageBox.Show("Caja no registrada");
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Caja no registrada");
                //}
            }
            else if (nombre == "Orden de Giro")
            {
                string IpMaquina = bitacora.LocalIPAddress();
                DataTable Dt = objConsulta.BoolDataTable("Select TIPODOCUMENTO, SERIE1,SERIE2,DOCUMENTOACTUAL,DOCUMENTOINICIAL,DOCUMENTOFINAL,AUTORIZACION,ESTACION,IPESTACION from TbCajasTalonario where IPESTACION = '" + IpMaquina + "' and ESTADO=1;");
                bool banderaCaja = false;
                if (Dt.Rows.Count > 0)
                {
                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {
                        banderaCaja = true;
                        DataRow myRows = Dt.Rows[i];
                        if (myRows["TIPODOCUMENTO"].ToString() == "RET")
                        {
                            banderaCaja = false;
                            if (FrmOrdenDeGiro == null || FrmOrdenDeGiro.IsDisposed)
                            {
                                FrmOrdenDeGiro = new FrmOrdenDeGiro();
                                FrmOrdenDeGiro.MdiParent = this;
                                //FrmOrdenDeGiro.BringToFront();
                                FrmOrdenDeGiro.Show();
                                break;
                            }
                            else { FrmOrdenDeGiro.BringToFront(); }
                        }
                    }
                    if (banderaCaja)
                    {
                        MessageBox.Show("Caja no registrada");
                    }
                }
                else
                {
                    MessageBox.Show("Caja no registrada");
                }

            }
            else if (nombre == "Devolución en Venta")
            {
                string IpMaquina = bitacora.LocalIPAddress();
                //IPESTACION = '" + IpMaquina + "' and
                DataTable Dt = objConsulta.BoolDataTable("Select TIPODOCUMENTO, SERIE1,SERIE2,DOCUMENTOACTUAL,DOCUMENTOINICIAL,DOCUMENTOFINAL,AUTORIZACION,ESTACION,IPESTACION from TbCajasTalonario where IPESTACION = '" + IpMaquina + "' and ESTADO=1;");
                bool banderaCaja = false;
                if (Dt.Rows.Count > 0)
                {
                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {
                        banderaCaja = true;
                        DataRow myRows = Dt.Rows[i];
                        if (myRows["TIPODOCUMENTO"].ToString() == "NDEB")
                        {
                            banderaCaja = false;
                            if (FrmDevolucionVenta == null || FrmDevolucionVenta.IsDisposed)
                            {
                                FrmDevolucionVenta = new FrmDevolucionVenta();
                                FrmDevolucionVenta.MdiParent = this;
                                //FrmOrdenDeGiro.BringToFront();
                                FrmDevolucionVenta.Show();
                                break;
                            }
                            else { FrmDevolucionVenta.BringToFront(); }
                        }
                    }
                    if (banderaCaja)
                    {
                        MessageBox.Show("Caja no registrada");
                    }
                }
                else
                {
                    MessageBox.Show("Caja no registrada");
                }
            }
            else if (nombre == "Kardex")
            {
                if (FrmKardex == null || FrmKardex.IsDisposed)
                {
                    FrmKardex = new FrmKardex();
                    FrmKardex.MdiParent = this;
                    FrmKardex.Show();
                }
                else { FrmKardex.BringToFront(); }
            }
            else if (nombre == "Declaración SRI")
            {
                if (FrmDeclaracionSRI == null || FrmDeclaracionSRI.IsDisposed)
                {
                    FrmDeclaracionSRI = new FrmDeclaracionSRI();
                    FrmDeclaracionSRI.MdiParent = this;
                    //FrmDevolucionVenta.BringToFront();
                    FrmDeclaracionSRI.Show();
                }
                else { FrmDeclaracionSRI.BringToFront(); }
            }
            else if (nombre == "Comprobantes")
            {
                if (FrmComprobantesSri == null || FrmComprobantesSri.IsDisposed)
                {
                    FrmComprobantesSri = new FrmComprobantesSri();
                    FrmComprobantesSri.MdiParent = this;
                    //FrmDevolucionVenta.BringToFront();
                    FrmComprobantesSri.Show();
                }
                else { FrmComprobantesSri.BringToFront(); }
            }
            else if (nombre == "Informe Caja")
            {
                if (FrmInformesCajas == null || FrmInformesCajas.IsDisposed)
                {
                    FrmInformesCajas = new FrmInformesCajas();
                    FrmInformesCajas.MdiParent = this;
                    //FrmDevolucionVenta.BringToFront();
                    FrmInformesCajas.Show();
                }
                else { FrmInformesCajas.BringToFront(); }
            }
            else if (nombre == "ATS")
            {
                
                if (Formats == null || Formats.IsDisposed)
                {
                    Formats =  new FormAts();
                    Formats.MdiParent = this;
                    //FrmDevolucionVenta.BringToFront();
                    Formats.Show();
                }
                else { Formats.BringToFront(); }
            }
            
                else if (nombre == "Informe Nota de Crédito")
            {

                if (FrmInformeNotaCredito == null || FrmInformeNotaCredito.IsDisposed)
                {
                    FrmInformeNotaCredito = new FrmInformeNotaCredito();
                    FrmInformeNotaCredito.MdiParent = this;
                    //FrmDevolucionVenta.BringToFront();
                    FrmInformeNotaCredito.Show();
                }
                else { FrmInformeNotaCredito.BringToFront(); }
            }
            else if (nombre == "Administrar Promociones")
            {
                if (FrmAdministrarPromocion == null || FrmAdministrarPromocion.IsDisposed)
                {
                    FrmAdministrarPromocion = new FrmAdministrarPromociones();
                    FrmAdministrarPromocion.MdiParent = this;
                    FrmAdministrarPromocion.Show();
                }
                else { FrmAdministrarPromocion.BringToFront(); }
            }
            else if (nombre == "Cuentas por Pagar")
            {
                if (FrmCuentasPorPagar == null || FrmCuentasPorPagar.IsDisposed)
                {
                    FrmCuentasPorPagar = new FrmCuentasPorPagar();
                    FrmCuentasPorPagar.MdiParent = this;
                    FrmCuentasPorPagar.Show();
                }
                else { FrmCuentasPorPagar.BringToFront(); }
            }
        }



        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            String HoraSalida = DateTime.Now.TimeOfDay.ToString();
            Bitacora ObjBitacora = new Bitacora(HoraSalida, "Sesión Finalizada");
            ObjBitacora.insertarBitacora();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss");
        }

        private void tsmCerrarSesion_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult Resul = MessageBox.Show("Esta Seguro que Quiere Cerrar la Sesión", "Estado de Cesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resul == DialogResult.Yes)
                {
                    String HoraSalida = DateTime.Now.TimeOfDay.ToString();
                    Bitacora ObjBitacora = new Bitacora(HoraSalida, "Sesión Finalizada");
                    ObjBitacora.insertarBitacora();
                    Application.Restart();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (primerIngresoSistema)
            {
                MessageBox.Show("Actualize los datos de la Empresa", "Bienvenido",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            menuMostrar = msPrincipal1;
            DataTable dt = objConsulta.BoolDataTable("Select FONDOPANTALLA from TbEmpresa where IDEMPRESA = 1");
            byte[] MyData = new byte[0];
            if (dt.Rows.Count > 0)
            {
                DataRow myRow = dt.Rows[0];
                string valor = myRow["FONDOPANTALLA"].ToString();

                if (myRow["FONDOPANTALLA"].ToString() != "")
                {
                    MyData = (byte[])myRow["FONDOPANTALLA"];
                    MemoryStream stream = new MemoryStream(MyData);
                    //this.panelPrincipal.BackgroundImage = Image.FromStream(stream);
                    this.BackgroundImage = Image.FromStream(stream);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            try
            {
                if (Program.IDTIPOUSUARIO != "1")
                {
                    llenarTreeViewPrincipal();
                }
            }
            catch (Exception ex)
            {
            }
            Program.tamañoVentanaPrincipal = ClientSize.Height;
            Program.tamañoVentanaPrincipalWith = ClientSize.Width;

        }        

        public void llenarTreeViewPrincipal()
        {
            for (int i = 0; i < tvPrincipal.Nodes.Count;)
            {
                tvPrincipal.Nodes.Remove(tvPrincipal.Nodes[0]);
            }
            objConsulta.BoolLlenarTreeViewMenu(tvPrincipal, "SELECT DISTINCT M.IDMENU, M.DESCRIPCION, M.NODOPADRE from TbMenu M, TbAsignacionMenu AM where M.IDMENU = AM.IDMENU AND AM.IDUSUARIO = " + Program.IDUsuarioMenu + " ORDER BY M.IDMENU;");
        }

        private void msPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        bool banderaMenuPrincipal = false;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!banderaMenuPrincipal)
            {
                tvPrincipal.Visible = false;
                MenuIzq.Visible = false;
                banderaMenuPrincipal = true;
            }
            else
            {
                tvPrincipal.Visible = true;
                MenuIzq.Visible = true;
                banderaMenuPrincipal = false;
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                ActiveMdiChild.Close();
            int a = ventanaToolStripMenuItem.DropDownItems.Count;
            if (a > 2)
            {
                ventanaToolStripMenuItem.DropDownItems.RemoveAt(a - 1);
            }
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmCambioClave == null || FrmCambioClave.IsDisposed)
            {
                FrmCambioClave = new FrmCambioClave();
                FrmCambioClave.Show();
                FrmCambioClave.MdiParent = this;
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "calc";
            proc.Start();
        }
    }
}
