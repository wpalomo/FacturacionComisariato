using Comisariato.Clases;
using Comisariato.Formularios.Transacciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Mantenimiento.Inventario
{
    public partial class FrmCompra : Form
    {
        public FrmCompra()
        {
            InitializeComponent();
        }
        public static DataGridView datosProductoCompra;
        public static ComboBox datosProveedor;
        Funcion objFuncion = new Funcion();
        FrmPrincipal objPrincipal = new FrmPrincipal();
        public static int IDEncabezadoCompraOG = 0;
        public static string IVA = "";

        Consultas consultas;
        EmcabezadoCompra ObjEncabezadoCompra;
        DetalleCompra ObjDetalleCompra;
        Producto objProducto;
        int ordenCompra = 0, idOrdenComrpa;
        float sumasubiva = 0.0f, sumasubcero = 0.0f, totalpagar = 0.0f, ivatotal = 0.0f, sumaice = 0.0f, sumairbp = 0.0f, subtotalPie = 0.0f;
        bool banderaFocoCelda = false;
        int posicion = 0;
        bool tieneIVA = false, saltarPosicionEsc = false, dobleTab = false, eliminacion = false;
        float ivaTotal = 0.0f;
        public static string CodigoBarraConsultaProducto = "";
        Bitacora ip = new Bitacora();
        public void incializar()
        {
            tieneIVA = false;
            ordenCompra = 0;
            sumasubiva = 0.0f; sumasubcero = 0.0f; totalpagar = 0.0f; ivatotal = 0.0f; sumaice = 0.0f; sumairbp = 0.0f; subtotalPie = 0.0f;
            banderaFocoCelda = false;
            posicion = 0;
            ivaTotal = 0.0f;
            txtFlete.Text = "0";
            txtSubtotal.Text = "0.0";
            txtSubtotal0.Text = "0.0";
            txtSubtutalIVA.Text = "0.0";
            txtTotal.Text = "0.0";
            txtICE.Text = "0.0";
            txtIRBP.Text = "0.0";
            txtIVA.Text = "0.0";
            txtFlete.Text = "0.0";
            cbTerminoPago.SelectedIndex = 0;
            dgvProductosIngresos.Rows.Clear();
            for (int i = 0; i < 8; i++)
            {
                dgvProductosIngresos.Rows.Add();
            }
            for (int i = 0; i < dgvProductosIngresos.ColumnCount - 1; i++)
            {
                dgvProductosIngresos.Columns[i].ReadOnly = true;
            }
            dgvProductosIngresos.Rows[0].Cells[0].ReadOnly = false;
        }
        private void FrmCompra_Load(object sender, EventArgs e)
        {
            
            for (int i = 2; i < 13; i++)
                dgvProductosIngresos.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
            txtSerie1.Focus();
            incializar();
            consultas = new Consultas();
            consultas.BoolLlenarComboBox(cbSucursal, "select IDSUCURSAL AS Id, NOMBRESUCURSAL as Texto from TbSucursal");
            consultas.BoolLlenarComboBox(cbProveedor, "select IDPROVEEDOR AS Id, NOMBRES AS Texto from TbProveedor");
            idOrdenComrpa = consultas.ObtenerID("IDEMCABEZADOCOMPRA", "TbEncabezadoyPieCompra", "");
            ordenCompra = 1 + consultas.ObtenerID("ORDEN_COMPRA_NUMERO", "TbEncabezadoyPieCompra", " where IDEMCABEZADOCOMPRA ="+ idOrdenComrpa + "");
            consultas.BoolLlenarComboBox(cbImpuesto, "select IDIVA AS ID, IVA + '%' as TEXTO from tbIva");            
            txtOrdenCompra.Text = Convert.ToString(ordenCompra);
            datosProductoCompra = dgvProductosIngresos;
            datosProveedor = cbProveedor;
            txtFlete.Text = "0";
            txtSubtotal.Text = "0.0";
            txtSubtotal0.Text = "0.0";
            txtSubtutalIVA.Text = "0.0";
            txtTotal.Text = "0.0";
            txtICE.Text = "0.0";
            txtIRBP.Text = "0.0";
            txtIVA.Text = "0.0";
            txtFlete.Text = "0.0";
            cbTerminoPago.SelectedIndex = 0;
            for (int i = 0; i < 20; i++)
                dgvInformeCompras.Rows.Add();
            cadenaConsultar = cadenaGeneral;
            DataTable dt = (DataTable)cbProveedor.DataSource;
            cbProveedor.AutoCompleteCustomSource = consultas.LoadAutoComplete(dt);
            cbProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            dt = (DataTable)cbSucursal.DataSource;
            cbSucursal.AutoCompleteCustomSource = consultas.LoadAutoComplete(dt);
            cbSucursal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSucursal.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        //FrmOrdenDeGiro frmOrdenDeGiro = new FrmOrdenDeGiro();
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtSerie1.Text != "" && txtSerie2.Text != "" && txtNumero.Text != "")
            {
                bool cantidadRegistros = false;
                if (!modificarVer)
                {
                    cantidadRegistros = consultas.Existe("SERIE1 = " + Convert.ToInt32(txtSerie1.Text) + " and SERIE2 = " + Convert.ToInt32(txtSerie2.Text) + " and NUMERO = " + Convert.ToInt32(txtNumero.Text) + " and IDPROVEEDOR", Convert.ToString(cbProveedor.SelectedValue), "TbEncabezadoyPieCompra");
                }
                if (!cantidadRegistros)
                {
                    bool dataGridCorrecto = false;
                    for (int i = 0; i < datosProductoCompra.RowCount - 1; i++)
                    {
                        if (Convert.ToString(datosProductoCompra.Rows[i].Cells[0].Value) != "")
                        {
                            for (int j = 1; j < datosProductoCompra.ColumnCount - 3; j++)
                            {
                                if (Convert.ToString(datosProductoCompra.Rows[i].Cells[j].Value) != "")
                                {
                                    dataGridCorrecto = true;
                                }
                                else
                                {
                                    dataGridCorrecto = false;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (dataGridCorrecto)
                    {
                        if (MessageBox.Show("¿Desea guardar la compra?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ObjEncabezadoCompra = new EmcabezadoCompra(txtSerie1.Text, txtSerie2.Text, txtNumero.Text, sumasubiva, sumasubcero, subtotalPie, totalpagar, txtOrdenCompra.Text,
                                Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToSingle(txtFlete.Text), dtpFechaOC.Value, Convert.ToInt32(datosProveedor.SelectedValue), cbTerminoPago.Text,
                                "0", cbImpuesto.Text, txtObservacion.Text, ivatotal, sumaice, sumairbp, "Compra");
                            String resultadoDetalle = "";
                            String resultadoEncabezado = "";
                            if (modificarVer)
                            {
                                resultadoEncabezado = ObjEncabezadoCompra.ActualizarEncabezadoyPieCompra(ObjEncabezadoCompra, Convert.ToInt32(idEncabezadoCompra)); // retorna true si esta correcto todo
                            }
                            else
                                resultadoEncabezado = ObjEncabezadoCompra.InsertarEncabezadoyPieCompra(ObjEncabezadoCompra); // retorna true si esta correcto todo
                            if (resultadoEncabezado == "Datos Guardados")
                            {
                                if (modificarVer)
                                {
                                    actualizarProducto();
                                    objConsulta.EjecutarSQL("DELETE FROM [dbo].[TbDetalleCompra] WHERE IDENCABEZADOCOMPRA = " + idEncabezadoCompra);
                                }                                
                                for (int i = 0; i < datosProductoCompra.RowCount; i++)
                                {
                                    ObjDetalleCompra = new DetalleCompra(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.Rows[i].Cells[5].Value.ToString())), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.Rows[i].Cells[6].Value.ToString())),
                                        Convert.ToString(datosProductoCompra.Rows[i].Cells[0].Value), Convert.ToInt32(datosProductoCompra.Rows[i].Cells[2].Value),
                                        Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.Rows[i].Cells[3].Value.ToString())), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.Rows[i].Cells[4].Value.ToString())),
                                        Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.Rows[i].Cells[7].Value.ToString())), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.Rows[i].Cells[8].Value.ToString())),
                                        Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.Rows[i].Cells[9].Value.ToString())), Convert.ToInt32(txtSerie1.Text), Convert.ToInt32(txtSerie2.Text), Convert.ToInt32(txtNumero.Text), Convert.ToInt32(cbProveedor.SelectedValue));
                                    //if (modificarVer)
                                    //{
                                    //    int idProductoDetalleCompra = Convert.ToInt32(objConsulta.ObtenerValorCampo("IDDETALLECOMPRA", "TbDetalleCompra", "where CODIGOBARRAPRODUCTO = '" + Convert.ToString(datosProductoCompra.Rows[i].Cells[0].Value) + "' AND IDENCABEZADOCOMPRA = " + Convert.ToInt32(idEncabezadoCompra)));
                                    //    //resultadoDetalle = ObjDetalleCompra.ActualizarDetalleCompra(ObjDetalleCompra, Convert.ToInt32(idEncabezadoCompra), idProductoDetalleCompra);
                                    //    if (!objConsulta.Existe(" IDENCABEZADOCOMPRA = " + Convert.ToInt32(idEncabezadoCompra) + " and CODIGOBARRAPRODUCTO", Convert.ToString(datosProductoCompra.Rows[i + 1].Cells[0].Value), "TbDetalleCompra"))
                                    //    {
                                    //        modificarVer = false;
                                    //    }
                                    //}
                                    //else                                    
                                        resultadoDetalle = ObjDetalleCompra.InsertarDetalleCompra(ObjDetalleCompra);
                                    if (Convert.ToString(datosProductoCompra.Rows[i + 1].Cells[0].Value) == "")
                                        break;
                                }
                                if (resultadoDetalle == "Datos Guardados")
                                {
                                    MessageBox.Show("Compra Registrada Correctamente ", "Exito", MessageBoxButtons.OK);
                                    modificarVer = false;
                                    if (MessageBox.Show("¿Desea ingresar la orden de giro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        Program.FormularioLlamado = true;
                                        IVA = cbImpuesto.Text;
                                        string condicion = "where SERIE1 = " + Convert.ToInt32(txtSerie1.Text) + " AND SERIE2 = " + Convert.ToInt32(txtSerie2.Text) + " AND NUMERO = " + Convert.ToInt32(txtNumero.Text) + " AND IDPROVEEDOR = " + Convert.ToInt32(cbProveedor.SelectedValue);
                                        IDEncabezadoCompraOG = Convert.ToInt32(consultas.ObtenerValorCampo("IDEMCABEZADOCOMPRA", "TbEncabezadoyPieCompra", condicion));
                                        //select * from TbCajasTalonario WHERE IPESTACION = '' AND TIPODOCUMENTO = 'RET' AND ESTADO = 1
                                        if (objConsulta.Existe("IPESTACION", "" + ip.LocalIPAddress() + "' AND TIPODOCUMENTO = 'RET' AND ESTADO = '1", "TbCajasTalonario"))
                                        {
                                            if (FrmPrincipal.FrmOrdenDeGiro == null || FrmPrincipal.FrmOrdenDeGiro.IsDisposed)
                                            {
                                                FrmPrincipal.FrmOrdenDeGiro = new FrmOrdenDeGiro();
                                                FrmPrincipal.FrmOrdenDeGiro.MdiParent = Program.panelPrincipalVariable;
                                                FrmPrincipal.FrmOrdenDeGiro.BringToFront();
                                                FrmPrincipal.FrmOrdenDeGiro.Show();
                                            }
                                            else
                                            {
                                                FrmPrincipal.FrmOrdenDeGiro.Close();
                                                if (FrmPrincipal.FrmOrdenDeGiro == null || FrmPrincipal.FrmOrdenDeGiro.IsDisposed)
                                                {
                                                    FrmPrincipal.FrmOrdenDeGiro = new FrmOrdenDeGiro();
                                                    FrmPrincipal.FrmOrdenDeGiro.MdiParent = Program.panelPrincipalVariable;
                                                    FrmPrincipal.FrmOrdenDeGiro.BringToFront();
                                                    FrmPrincipal.FrmOrdenDeGiro.Show();
                                                }
                                            }
                                        }
                                        else
                                            MessageBox.Show("Caja no registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        string ordenNumero = txtOrdenCompra.Text;
                                        Funcion.Limpiarobjetos(gbEncabezadoCompra);
                                        incializar();
                                        txtOrdenCompra.Text = ordenNumero;
                                    }
                                    else
                                    {
                                        int ordenNumero = Convert.ToInt32(txtOrdenCompra.Text);
                                        Funcion.Limpiarobjetos(gbEncabezadoCompra);
                                        incializar();
                                        txtOrdenCompra.Text = Convert.ToString(ordenNumero + 1);
                                    }
                                }
                                else if (resultadoDetalle == "Error al Registrar")
                                {
                                    MessageBox.Show("Error al guardar Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    try
                                    {
                                        int idDetalle = 0, idEncabezado = 0;
                                        consultas.ObtenerIDCompra(ref idDetalle, "select D.IDENCABEZADOCOMPRA from TbEncabezadoyPieCompra E, TbDetalleCompra D where D.IDENCABEZADOCOMPRA = E.IDEMCABEZADOCOMPRA and E.NUMERO = " + Convert.ToInt32(txtNumero.Text) + " AND E. SERIE1 = " + Convert.ToInt32(txtSerie1.Text) + " AND SERIE2 = " + Convert.ToInt32(txtSerie2.Text) + " AND IDPROVEEDOR = " + Convert.ToInt32(cbProveedor.SelectedValue) + "");
                                        consultas.EjecutarSQL("DELETE FROM [dbo].[TbDetalleCompra] WHERE IDENCABEZADOCOMPRA = " + idDetalle + "");
                                        consultas.ObtenerIDCompra(ref idEncabezado, "select E.IDEMCABEZADOCOMPRA from TbEncabezadoyPieCompra E where E.NUMERO = " + Convert.ToInt32(txtNumero.Text) + " AND E. SERIE1 = " + Convert.ToInt32(txtSerie1.Text) + " AND SERIE2 = " + Convert.ToInt32(txtSerie2.Text) + " AND IDPROVEEDOR = " + Convert.ToInt32(cbProveedor.SelectedValue) + "");
                                        consultas.EjecutarSQL("DELETE FROM [dbo].[TbEncabezadoyPieCompra] WHERE IDEMCABEZADOCOMPRA = " + idEncabezado + "");
                                    }
                                    catch (Exception)
                                    {
                                    }
                                }
                            }
                            else if (resultadoEncabezado == "Error al Registrar Encabezado")
                            {
                                try
                                {
                                    int idEncabezado = 0;
                                    MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    consultas.ObtenerIDCompra(ref idEncabezado, "select E.IDEMCABEZADOCOMPRA from TbEncabezadoyPieCompra E where E.NUMERO = " + Convert.ToInt32(txtNumero.Text) + " AND E. SERIE1 = " + Convert.ToInt32(txtSerie1.Text) + " AND SERIE2 = " + Convert.ToInt32(txtSerie2.Text) + " AND IDPROVEEDOR = " + Convert.ToInt32(cbProveedor.SelectedValue) + "");
                                    consultas.EjecutarSQL("DELETE FROM [dbo].[TbEncabezadoyPieCompra] WHERE IDEMCABEZADOCOMPRA = " + idEncabezado + "");
                                }
                                catch (Exception)
                                {
                                }
                            }
                            else if (resultadoEncabezado == "Existe") { MessageBox.Show("Ya Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Uno o mas campos en el detalle de la compra estan vacíos");
                        dgvProductosIngresos.Focus();
                    }
                }
                else
                    MessageBox.Show("El numero de factura del proveedor seleccionado ya existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Ingrese los datos necesarios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }        
        
        public void informacionProducto()
        {
            datosProductoCompra.CurrentRow.Cells[1].Value = objProducto.Nombreproducto;
            if (tieneIVA)
            {
                datosProductoCompra.CurrentRow.Cells[5].Value = Funcion.reemplazarcaracter(objProducto.Ice.ToString());
                posicion = 5;
                Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                datosProductoCompra.CurrentRow.Cells[6].Value = Funcion.reemplazarcaracter(objProducto.Irbp.ToString());
                posicion = 6;
                Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                datosProductoCompra.CurrentRow.Cells[7].Value = Funcion.reemplazarcaracter(objProducto.Preciopublico_iva.ToString());
                posicion = 7;
                Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                datosProductoCompra.CurrentRow.Cells[8].Value = Funcion.reemplazarcaracter(objProducto.Precioalmayor_iva.ToString());
                posicion = 8;
                Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                datosProductoCompra.CurrentRow.Cells[9].Value = Funcion.reemplazarcaracter(objProducto.Precioporcaja_iva.ToString());
                posicion = 9;
                Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
            }
            else
            {
                datosProductoCompra.CurrentRow.Cells[5].Value = 0;
                posicion = 5;
                Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                datosProductoCompra.CurrentRow.Cells[6].Value = 0;
                posicion = 6;
                Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                datosProductoCompra.CurrentRow.Cells[5].ReadOnly = true;
                datosProductoCompra.CurrentRow.Cells[6].ReadOnly = true;
                datosProductoCompra.CurrentRow.Cells[7].Value = Funcion.reemplazarcaracter(objProducto.Preciopublico_sin_iva.ToString());
                posicion = 7;
                Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                datosProductoCompra.CurrentRow.Cells[8].Value = Funcion.reemplazarcaracter(objProducto.Precioalmayor_sin_iva.ToString());
                posicion = 8;
                Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                datosProductoCompra.CurrentRow.Cells[9].Value = Funcion.reemplazarcaracter(objProducto.Precioporcaja_sin_iva.ToString());
                posicion = 9;
                Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
            }
            if (objProducto.PrecioCompra != 0)
            {
                datosProductoCompra.CurrentRow.Cells[3].Value = Funcion.reemplazarcaracter(objProducto.PrecioCompra.ToString());
                posicion = 3;
                Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
            }
        }
        
        public bool validarCodigoRepetido(DataGridViewCellEventArgs e)
        {
            bool repetido = false;
            for (int i = e.RowIndex - 1; i > -1; i--)
            {
                if (Convert.ToString(datosProductoCompra.Rows[e.RowIndex].Cells[0].Value) == Convert.ToString(datosProductoCompra.Rows[i].Cells[0].Value))
                {
                    MessageBox.Show("Producto ya ingresado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    datosProductoCompra.Rows[e.RowIndex].Cells[0].Value = "";
                    datosProductoCompra.CurrentCell = datosProductoCompra.Rows[e.RowIndex].Cells[0];
                    repetido = true;
                    break;
                }
                else
                {
                    repetido = false;
                }
            }
            return repetido;
        }
        float ivaFila = 0.0f, subtotalFila = 0.0f, totalFila = 0.0f;
        private void dgvProductosIngresos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool banderaTab = false;
            objProducto = new Producto();
            
            try
            {
                if (datosProductoCompra.Columns[e.ColumnIndex].Name == "codigo")
                {
                    //---------------Desbloquear Celdas
                    if (!validarCodigoRepetido(e))
                    {
                        //---------------Desbloquear Celdas
                        for (int i = 0; i < datosProductoCompra.ColumnCount - 3; i++)
                        {
                            datosProductoCompra.CurrentRow.Cells[i].ReadOnly = false;
                        }
                        objProducto = consultas.ConsultarproductoCompra(Convert.ToString(datosProductoCompra.CurrentRow.Cells[0].Value));
                        if (objProducto == null)
                        {
                            if (MessageBox.Show("¿Desea agregar el producto?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                //FrmProductos frmProducto = new FrmProductos();
                                Program.FormularioLlamado = true;
                                FrmProductos.codigo = Convert.ToString(datosProductoCompra.CurrentRow.Cells[0].Value);
                                if (FrmPrincipal.FrmProducto == null || FrmPrincipal.FrmProducto.IsDisposed)
                                {
                                    FrmPrincipal.FrmProducto = new FrmProductos();
                                    FrmPrincipal.FrmProducto.MdiParent = Program.panelPrincipalVariable;
                                    FrmPrincipal.FrmProducto.BringToFront();
                                    FrmPrincipal.FrmProducto.Show();
                                }
                                else
                                {
                                    FrmPrincipal.FrmProducto.Close();
                                    if (FrmPrincipal.FrmProducto == null || FrmPrincipal.FrmProducto.IsDisposed)
                                    {
                                        FrmPrincipal.FrmProducto = new FrmProductos();
                                        FrmPrincipal.FrmProducto.MdiParent = Program.panelPrincipalVariable;
                                        FrmPrincipal.FrmProducto.BringToFront();
                                        FrmPrincipal.FrmProducto.Show();
                                    }
                                }
                                informacionProducto();
                                datosProductoCompra.CurrentCell = datosProductoCompra.CurrentRow.Cells[2];
                            }
                            else
                            {
                                datosProductoCompra.CurrentRow.Cells[0].Value = "";
                                SendKeys.Send("{LEFT}");
                                banderaTab = true;
                            }
                            datosProductoCompra.CurrentCell = datosProductoCompra.CurrentRow.Cells[1];
                        }
                        else
                        {
                            tieneIVA = objProducto.Ivaestado;
                            informacionProducto();
                            if (!dobleTab)
                            {
                                SendKeys.Send("{TAB}");
                            }
                            else
                                dobleTab = false;
                        }
                    }
                    else
                    {
                        datosProductoCompra.CurrentRow.Cells[0].Value = "";
                        SendKeys.Send("{LEFT}");
                        banderaTab = true;
                    }

                }


                if (datosProductoCompra.Columns[e.ColumnIndex].Name == "cantidad")
                {
                    if (Convert.ToString(datosProductoCompra.CurrentRow.Cells[2].Value) != "")
                        SendKeys.Send("{RIGHT}");
                    banderaTab = true;
                }
                if (datosProductoCompra.Columns[e.ColumnIndex].Name == "precioCompra")
                {
                    if (Convert.ToString(datosProductoCompra.CurrentRow.Cells[3].Value) != "")
                    {
                        posicion = 3;
                        Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                        SendKeys.Send("{RIGHT}");
                    }
                    banderaTab = true;
                }
                if (datosProductoCompra.Columns[e.ColumnIndex].Name == "descuento")
                {
                    if (Convert.ToString(datosProductoCompra.CurrentRow.Cells[4].Value) == "")
                    {
                        datosProductoCompra.CurrentRow.Cells[4].Value = "0.0";
                        // posicion = 4;
                        //Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                        //if (dgvProductosIngresos.CurrentRow.Cells[5].ReadOnly == true)
                        //    dgvProductosIngresos.CurrentCell = dgvProductosIngresos.CurrentRow.Cells[5];
                        //else
                            SendKeys.Send("{RIGHT}");
                    }
                    else
                    {
                        posicion = 4;
                        Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                        //if (dgvProductosIngresos.CurrentRow.Cells[5].ReadOnly == true)
                        //    dgvProductosIngresos.CurrentCell = dgvProductosIngresos.CurrentRow.Cells[5];
                        //else
                            SendKeys.Send("{RIGHT}");
                    }
                    banderaTab = true;
                }
                if (datosProductoCompra.Columns[e.ColumnIndex].Name == "iceProducto")
                {
                    if (Convert.ToString(datosProductoCompra.CurrentRow.Cells[5].Value) != "")
                    {
                        posicion = 5;
                        Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                        SendKeys.Send("{RIGHT}");
                    }
                    banderaTab = true;
                }
                if (datosProductoCompra.Columns[e.ColumnIndex].Name == "irbpProducto")
                {
                    if (Convert.ToString(datosProductoCompra.CurrentRow.Cells[6].Value) != "")
                    {
                        posicion = 6;
                        Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                        SendKeys.Send("{RIGHT}");
                    }
                    banderaTab = true;
                }
                if (datosProductoCompra.Columns[e.ColumnIndex].Name == "precioPublico")
                {
                    if (Convert.ToString(datosProductoCompra.CurrentRow.Cells[7].Value) != "")
                    {
                        posicion = 7;
                        Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                        SendKeys.Send("{RIGHT}");
                    }
                    banderaTab = true;
                }
                if (datosProductoCompra.Columns[e.ColumnIndex].Name == "precioMayorista")
                {
                    if (Convert.ToString(datosProductoCompra.CurrentRow.Cells[8].Value) != "")
                    {
                        posicion = 8;
                        Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                        SendKeys.Send("{RIGHT}");
                    }
                    banderaTab = true;
                }
                if (datosProductoCompra.Columns[e.ColumnIndex].Name == "precioCaja")
                {
                    if (Convert.ToString(datosProductoCompra.CurrentRow.Cells[9].Value) != "")
                    {
                        posicion = 9;
                        Funcion.ValidaCeldasPrecios(datosProductoCompra, posicion, ref banderaFocoCelda);
                        datosProductoCompra.CurrentCell = datosProductoCompra.CurrentRow.Cells[12];
                        datosProductoCompra.Rows[e.RowIndex + 1].Cells[0].ReadOnly = false;
                        if (e.RowIndex == dgvProductosIngresos.RowCount - 2)
                        {
                            dgvProductosIngresos.Rows.Add();
                        }
                        SendKeys.Send("{TAB}");
                    }
                    banderaTab = true;
                }
                if (datosProductoCompra.Columns[e.ColumnIndex].Name == "precioCompra" || datosProductoCompra.Columns[e.ColumnIndex].Name == "cantidad" || datosProductoCompra.Columns[e.ColumnIndex].Name == "iceProducto" || datosProductoCompra.Columns[e.ColumnIndex].Name == "irbpProducto" || datosProductoCompra.Columns[e.ColumnIndex].Name == "codigo")
                {
                    calcularFila();
                }
                if (datosProductoCompra.Columns[e.ColumnIndex].Name == "precioCaja")
                {
                    dgvProductosIngresos.CurrentRow.ReadOnly = true;
                }
            }
            catch (Exception otro)
            {
            }
            Calcular();
            SendKeys.Send("{UP}");
            if (!banderaTab)
                SendKeys.Send("{RIGHT}");
            else
                banderaTab = false;
        }
        public void calcularFila()
        {
            float precioCompra = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.CurrentRow.Cells[3].Value.ToString()));
            float cantidad = Convert.ToInt32(datosProductoCompra.CurrentRow.Cells[2].Value.ToString());
            float precioICE = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.CurrentRow.Cells[5].Value.ToString()));
            float precioIRBP = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.CurrentRow.Cells[6].Value.ToString()));
            string[] separadorPorcentaje = cbImpuesto.Text.Split('%');
            int tipoIva = Convert.ToInt32(separadorPorcentaje[0]);
            if (tieneIVA)
            {
                ivaFila = (((precioCompra + precioICE) * cantidad) * tipoIva) / 100;
            }
            else
            {
                ivaFila = 0;
            }
            subtotalFila = ((precioCompra + precioICE + precioIRBP) * cantidad);
            totalFila = subtotalFila + ivaFila;
            ivaTotal = ivaFila;
            datosProductoCompra.CurrentRow.Cells[11].Value = Funcion.reemplazarcaracter(Math.Round(ivaFila, 2).ToString("#####0.00"));
            datosProductoCompra.CurrentRow.Cells[10].Value = Funcion.reemplazarcaracter(Math.Round(subtotalFila, 2).ToString("#####0.00"));
            datosProductoCompra.CurrentRow.Cells[12].Value = Funcion.reemplazarcaracter(Math.Round(totalFila, 2).ToString("#####0.00"));
        }
        private void Calcular()
        {
            float cantidad = 0, pc = 0.0f;
            sumasubiva = 0.0f; sumasubcero = 0.0f; totalpagar = 0.0f; ivatotal = 0.0f; sumaice = 0.0f; sumairbp = 0.0f; subtotalPie = 0.0f;
            try
            {
                for (int i = 0; i < datosProductoCompra.RowCount; i++)
                {
                    if (Convert.ToSingle(datosProductoCompra.Rows[i].Cells[11].Value.ToString()) != 0)
                    {
                        cantidad = Convert.ToInt32(datosProductoCompra.Rows[i].Cells[2].Value);
                        pc = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.Rows[i].Cells[3].Value.ToString()));
                        sumasubiva += Convert.ToSingle(cantidad * pc);
                        
                    }
                    if (Convert.ToSingle(datosProductoCompra.Rows[i].Cells[11].Value.ToString()) == 0)
                    {
                        cantidad = Convert.ToInt32(datosProductoCompra.Rows[i].Cells[2].Value);
                        pc = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.Rows[i].Cells[3].Value.ToString()));
                        sumasubcero += Convert.ToSingle(cantidad * pc);
                    }
                    sumaice += Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.Rows[i].Cells[5].Value.ToString())) * Convert.ToInt32(datosProductoCompra.Rows[i].Cells[2].Value);
                    sumairbp += Convert.ToSingle(Funcion.reemplazarcaracterViceversa(datosProductoCompra.Rows[i].Cells[6].Value.ToString())) * Convert.ToInt32(datosProductoCompra.Rows[i].Cells[2].Value);
                    if (Convert.ToString(datosProductoCompra.Rows[i + 1].Cells[0].Value) == "")
                    {
                        break;
                    }
                }
                string[] s = cbImpuesto.Text.Split('%');
                float iva = Convert.ToSingle(s[0]) / 100;
                ivatotal = (sumasubiva + sumaice) * iva;
                txtIRBP.Text = Funcion.reemplazarcaracter(Math.Round(sumairbp, 2).ToString("#####0.00"));
                txtICE.Text = Funcion.reemplazarcaracter(Math.Round(sumaice, 2).ToString("#####0.00"));
                txtSubtotal0.Text = Funcion.reemplazarcaracter(Math.Round(sumasubcero, 2).ToString("#####0.00"));
                subtotalPie = sumasubcero + sumasubiva;
                txtSubtotal.Text = Funcion.reemplazarcaracter(Math.Round(subtotalPie, 2).ToString("#####0.00"));
                txtSubtutalIVA.Text = Funcion.reemplazarcaracter(Math.Round(sumasubiva, 2).ToString("#####0.00"));
                txtIVA.Text = Funcion.reemplazarcaracter(Math.Round(ivatotal, 2).ToString("#####0.00"));
                totalpagar = sumairbp + sumaice + subtotalPie + ivatotal;
                txtTotal.Text = Funcion.reemplazarcaracter(Math.Round(totalpagar, 2).ToString("#####0.00"));
                sumasubiva = Convert.ToSingle(Math.Round(sumasubiva, 6));
                ivatotal = Convert.ToSingle(Math.Round(ivatotal, 6));
                sumasubcero = Convert.ToSingle(Math.Round(sumasubcero, 6));
                sumaice = Convert.ToSingle(Math.Round(sumaice, 6));
                sumairbp = Convert.ToSingle(Math.Round(sumairbp, 6));
                subtotalPie = Convert.ToSingle(Math.Round(subtotalPie, 6));
                totalpagar = Convert.ToSingle(Math.Round(totalpagar, 6));
            }
            catch (Exception EX)
            {
            }
        }

        private void dgvProductosIngresos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                if (saltarPosicionEsc)
                {
                    SendKeys.Send("{TAB}");
                    saltarPosicionEsc = false;
                    dobleTab = true;
                }
                else if (dgvProductosIngresos.CurrentCell == dgvProductosIngresos.CurrentRow.Cells[5] && dgvProductosIngresos.CurrentCell.ReadOnly == true)
                {
                    SendKeys.Send("{TAB}");
                }
                else if (dgvProductosIngresos.CurrentCell == dgvProductosIngresos.CurrentRow.Cells[6] && dgvProductosIngresos.CurrentCell.ReadOnly == true)
                {
                    SendKeys.Send("{TAB}");
                }
            }
            if (e.KeyCode == Keys.Delete && eliminacion)
            {
                dgvProductosIngresos.CurrentCell = dgvProductosIngresos.CurrentRow.Cells[0];
                dgvProductosIngresos.CurrentRow.Cells[0].ReadOnly = false;
                eliminacion = false;
            }
            //if (e.KeyCode == Keys.Tab)
            //{
            //    e.Handled = true;
            //    SendKeys.Send("{RIGHT}");
            //}
        }


        //FrmProveedores FrmProveedor;
        private void btnProveedor_Click(object sender, EventArgs e)
        {            
            consultas.BoolLlenarComboBox(cbProveedor, "select IDPROVEEDOR AS Id, NOMBRES AS Texto from TbProveedor");
            //if (!Program.FormularioProveedorCompra)
            //{//FrmProveedores frmProveedor = null;
                Program.FormularioLlamado = true;
                if (FrmPrincipal.FrmProveedor == null || FrmPrincipal.FrmProveedor.IsDisposed)
                {
                    FrmPrincipal.FrmProveedor = new FrmProveedores();
                    FrmPrincipal.FrmProveedor.MdiParent = Program.panelPrincipalVariable;
                    FrmPrincipal.FrmProveedor.BringToFront();
                    FrmPrincipal.FrmProveedor.Show();
                }
                else { FrmPrincipal.FrmProveedor.BringToFront(); }
            //}
        }

        private void OnlyNumbersdgvcheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[2])
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[0])
            {
                Funcion.validar_Num_Letras(e);
            }
            if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[1])
            {
                Funcion.validar_Num_Letras(e);
            }
            
        }
        private void dgvProductosIngresos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbersdgvcheque_KeyPress;
            }
        }

        private void txtOrdenCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void txtFlete_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtFlete.Text);
        }
        
        private void txtPlazoOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.validar_Num_Letras(e);
        }

        private void txtICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtICE.Text);
        }

        private void txtIRBP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtIRBP.Text);
        }

        private void txtSerie1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void txtObservacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
                dgvProductosIngresos.Focus();
            }
        }
        Consultas objConsulta = new Consultas();
        string cadenaGeneral = "select SERIE1 +''+ SERIE2 +''+ NUMERO AS SERIES , FECHAORDENCOMPRA, NOMBRES, TOTALIVA,"+
" TOTALICE, TOTALIRBP, SUBTOTAL0, SUBTOTALIVA, TOTAL, IDPROVEEDOR "+
" from Vista_InformeCompras", añoDesde = "", fechaDesde = "", añoHasta = "", fechaHasta = "", mesDesde = "", diaDesde = "", mesHasta = "", diaHasta = "", cadenaConsultar = "";

        private void dgvProductosIngresos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 2; i < 10; i++)
            {
                dgvProductosIngresos.CurrentRow.Cells[i].ReadOnly = true;
                eliminacion = true;
                dgvProductosIngresos.Rows[e.RowIndex + 1].Cells[0].ReadOnly = false;
            }
            dgvProductosIngresos.Rows.Add();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar esta compra?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                actualizarProducto();   
                if (objConsulta.EjecutarSQL("DELETE FROM [dbo].[TbDetalleCompra] WHERE IDENCABEZADOCOMPRA = " + idEncabezadoCompra))
                {
                    if (objConsulta.EjecutarSQL("DELETE FROM [dbo].[TbEncabezadoyPieCompra] WHERE IDEMCABEZADOCOMPRA = " + idEncabezadoCompra))
                    {
                        MessageBox.Show("Eliminado correctamente");
                    }
                }
                consultaCompras();
            }
        }
        public void actualizarProducto()
        {
            DataTable dtProductoCantidad = objConsulta.BoolDataTable("select dc.CODIGOBARRAPRODUCTO, dc.CANTIDAD from TbDetalleCompra dc, TbEncabezadoyPieCompra ec where ec.IDEMCABEZADOCOMPRA = dc.IDENCABEZADOCOMPRA and ec.IDEMCABEZADOCOMPRA = " + idEncabezadoCompra);
            if (dtProductoCantidad.Rows.Count > 0)
            {
                for (int i = 0; i < dtProductoCantidad.Rows.Count; i++)
                {
                    DataRow rowCantidad = dtProductoCantidad.Rows[i];
                    float cantidadActualProducto = Convert.ToSingle(objConsulta.ObtenerValorCampo("CANTIDAD", "TbProducto", "where CODIGOBARRA = '" + rowCantidad[0] + "'"));
                    float cantidadFinal = cantidadActualProducto - Convert.ToSingle(rowCantidad[1]);
                    objConsulta.EjecutarSQL("UPDATE [dbo].[TbProducto] SET [CANTIDAD] = " + cantidadFinal + "  WHERE CODIGOBARRA = " + rowCantidad[0]);
                }
            }
        }

        bool modificarVer = false;
        //string valorNumeroOrdenCopra = "";
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //valorNumeroOrdenCopra = txtOrdenCompra.Text;
            modificarVer = true;
            incializar();
            if (existeOG)
            {                
                BtnGuardar.Enabled = false;
                dgvProductosIngresos.ReadOnly = true;
                txtSerie1.ReadOnly = true;
                txtSerie2.ReadOnly = true;
                txtNumero.ReadOnly = true;
                txtObservacion.ReadOnly = true;
                cbImpuesto.Enabled = false;
                cbProveedor.Enabled = false;
                cbTerminoPago.Enabled = false;
                cbSucursal.Enabled = false;
                txtOrdenCompra.Text = idEncabezadoCompra;
            }
            else
            {
                BtnGuardar.Text = "Modificar";
                BtnGuardar.Enabled = true;
                dgvProductosIngresos.ReadOnly = false;
                txtSerie1.ReadOnly = false;
                txtSerie2.ReadOnly = false;
                txtNumero.ReadOnly = false;
                txtObservacion.ReadOnly = false;
                cbImpuesto.Enabled = true;
                cbProveedor.Enabled = true;
                cbTerminoPago.Enabled = false;
                cbSucursal.Enabled = true;
                txtOrdenCompra.Text = idEncabezadoCompra;
            }
            tabControl1.SelectedIndex = 0;
            DataTable encabezadoPie = objConsulta.BoolDataTable("select * from TbEncabezadoyPieCompra where IDEMCABEZADOCOMPRA = " + idEncabezadoCompra);
            DataTable detalleCompra = objConsulta.BoolDataTable("select dc.CODIGOBARRAPRODUCTO, p.NOMBREPRODUCTO, dc.CANTIDAD, dc.PRECIOCOMRPA, dc.DESCUENTO, dc.ICE, dc.IRBP, dc.PRECIOVENTAPUBLICO, dc.PRECIOMAYORISTA, dc.PRECIOCAJAS from TbDetalleCompra dc, TbEncabezadoyPieCompra ec, TbProducto p where dc.IDENCABEZADOCOMPRA = ec.IDEMCABEZADOCOMPRA and dc.CODIGOBARRAPRODUCTO = p.CODIGOBARRA and ec.IDEMCABEZADOCOMPRA = " + idEncabezadoCompra + " order by IDDETALLECOMPRA");
            if (encabezadoPie.Rows.Count > 0)
            {
                DataRow rowEncabezado = encabezadoPie.Rows[0];
                cbProveedor.SelectedValue = Convert.ToInt32(rowEncabezado["IDPROVEEDOR"]);
                cbSucursal.SelectedValue = Convert.ToInt32(rowEncabezado["IDSUCURSAL"]);
                //cbImpuesto.SelectedText = rowEncabezado["IMPUESTO"].ToString();
                txtObservacion.Text = rowEncabezado["OBSERVACION"].ToString();
                txtTotal.Text = Funcion.reemplazarcaracter(Convert.ToSingle(rowEncabezado["TOTAL"]).ToString("####0.00"));
                txtSubtutalIVA.Text = Funcion.reemplazarcaracter(Convert.ToSingle(rowEncabezado["SUBTOTALIVA"]).ToString("####0.00"));
                txtSubtotal0.Text = Funcion.reemplazarcaracter(Convert.ToSingle(rowEncabezado["SUBTOTAL0"]).ToString("####0.00"));
                txtSubtotal.Text = Funcion.reemplazarcaracter(Convert.ToSingle(rowEncabezado["SUBTOTAL"]).ToString("####0.00"));
                txtICE.Text = Funcion.reemplazarcaracter(Convert.ToSingle(rowEncabezado["TOTALICE"]).ToString("####0.00"));
                txtIRBP.Text = Funcion.reemplazarcaracter(Convert.ToSingle(rowEncabezado["TOTALIRBP"]).ToString("####0.00"));
                txtSerie1.Text = rowEncabezado["SERIE1"].ToString();
                txtSerie2.Text = rowEncabezado["SERIE2"].ToString();
                txtNumero.Text = rowEncabezado["NUMERO"].ToString();
                txtIVA.Text = Funcion.reemplazarcaracter(Convert.ToSingle(rowEncabezado["TOTALIVA"]).ToString("####0.00"));
            }
            if (detalleCompra.Rows.Count > 0)
            {
                int i = 0;
                for (i = 0; i < detalleCompra.Rows.Count; i++)
                {
                    if (i >= dgvProductosIngresos.RowCount - 1)
                    {
                        dgvProductosIngresos.Rows.Add();
                    }
                    DataRow rowDetalle = detalleCompra.Rows[i];
                    for (int j = 0; j < 10; j++)
                    {
                        if (j==0)
                        {
                            string ivaBool = objConsulta.ObtenerValorCampo("IVAESTADO", "TbProducto", "where CODIGOBARRA = '" + rowDetalle[j] + "'");
                            tieneIVA = Convert.ToBoolean(ivaBool);
                        }
                        if (j > 1)
                        {
                            dgvProductosIngresos.Rows[i].Cells[j].Value = Funcion.reemplazarcaracter(rowDetalle[j].ToString());
                        }
                        else
                            dgvProductosIngresos.Rows[i].Cells[j].Value = rowDetalle[j];
                    }
                    dgvProductosIngresos.CurrentCell = dgvProductosIngresos.Rows[i].Cells[0];
                    calcularFila();
                }
            }
        }
        bool existeOG = false;
        string idEncabezadoCompra = "";
        private void dgvInformeCompras_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (Convert.ToString(dgvInformeCompras.CurrentRow.Cells[0].Value) != "")
                {
                    btnModificar.Enabled = true;
                    btnAnular.Enabled = true;
                    string factura = Convert.ToString(dgvInformeCompras.CurrentRow.Cells[0].Value);
                    string serie1 = factura.Substring(0, 3);
                    string serie2 = factura.Substring(3, 3);
                    string numero = factura.Substring(6, 9);
                    int proveedor = Convert.ToInt32(dgvInformeCompras.CurrentRow.Cells[9].Value);
                    idEncabezadoCompra = objConsulta.ObtenerValorCampo("IDEMCABEZADOCOMPRA", "TbEncabezadoyPieCompra", "where SERIE1 = '" + serie1 + "' AND SERIE2 = '" + serie2 + "' AND NUMERO = '" + numero + "' and IDPROVEEDOR = " + proveedor);
                    existeOG = objConsulta.Existe("IDEMCABEZADOCOMPRA", idEncabezadoCompra, "TbEncabezadoOrdenGiro");
                    if (existeOG)
                    {
                        btnModificar.Text = "Ver";
                        btnAnular.Enabled = false;
                    }
                    else
                    {
                        btnModificar.Text = "Modificar";
                        btnAnular.Enabled = true;
                    }
                }
                else
                {
                    btnModificar.Enabled = false;
                    btnAnular.Enabled = false;
                }
            }
            catch { }

        }
        public void consultaCompras()
        {
            string sql = cadenaGeneral + " where (FECHAORDENCOMPRA between '" + fechaDesde + "' AND '" + fechaHasta + "') and (IDENTIFICACION like '%" + txtConsultar.Text + "%' or NOMBRES like '%" + txtConsultar.Text + "%' or NUMERO like '%" + txtConsultar.Text + "%' or SERIE2 like '%" + txtConsultar.Text + "%' or SERIE2 like '%" + txtConsultar.Text + "%')  ORDER BY IDENTIFICADOR ASC";
            objConsulta.boolLlenarDataGrid(dgvInformeCompras, sql, 20, 9, 0);
            if (Convert.ToString(dgvInformeCompras.Rows[0].Cells[0].Value) != "")
            {
                btnModificar.Enabled = true;
                btnAnular.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
                btnAnular.Enabled = false;
            }
            if (Convert.ToString(dgvInformeCompras.Rows[0].Cells[0].Value) != "")
            {
                for (int i = 3; i < 9; i++)
                    dgvInformeCompras.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                for (int i = 0; i < 3; i++)
                    dgvInformeCompras.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                for (int i = 0; i < dgvInformeCompras.RowCount - 1; i++)
                {
                    if (Convert.ToString(dgvInformeCompras.Rows[i].Cells[0].Value) != "")
                    {
                        for (int j = 3; j < 9; j++)
                            dgvInformeCompras.Rows[i].Cells[j].Value = Funcion.reemplazarcaracter(dgvInformeCompras.Rows[i].Cells[j].Value.ToString());
                        if (Convert.ToString(dgvInformeCompras.Rows[i + 1].Cells[0].Value) == "")
                            break;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int i = 0; i < dgvInformeCompras.RowCount - 1; i++)
                {
                    dgvInformeCompras.Rows[i].Cells[1].Value = Convert.ToDateTime(dgvInformeCompras.Rows[i].Cells[1].Value).ToShortDateString();
                    if (Convert.ToString(dgvInformeCompras.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
            dgvInformeCompras.Focus();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            obtenerFechas();
            consultaCompras();
            for (int i = 0; i < dgvInformeCompras.RowCount - 1; i++)
            {
                if (Convert.ToString(dgvInformeCompras.Rows[i].Cells[0].Value) != "")
                {
                    for (int j = 3; j < 9; j++)
                        dgvInformeCompras.Rows[i].Cells[j].Value = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvInformeCompras.Rows[i].Cells[j].Value.ToString())), 2).ToString());
                    if (Convert.ToString(dgvInformeCompras.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
            Funcion.dosDecimales(ref dgvInformeCompras, 3, 9, 0);
        }

        private void dgvProductosIngresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex > 0)
                {
                    if (Convert.ToString(dgvProductosIngresos.Rows[e.RowIndex - 1].Cells[0].Value) != "")
                    {
                        dgvProductosIngresos.CurrentCell.ReadOnly = false;
                    }
                }
            }
        }

        private void FrmCompra_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F6:
                    Program.banderaProductosCompras = true;
                    for (int i = 0; i < dgvProductosIngresos.ColumnCount; i++)
                    {
                        dgvProductosIngresos.CurrentRow.Cells[i].Value = "";
                    }
                    for (int i = 1; i < dgvProductosIngresos.ColumnCount; i++)
                    {
                        dgvProductosIngresos.CurrentRow.Cells[i].ReadOnly = true;
                    }
                    FrmConsultarProducto FrmConsultarProduct = new FrmConsultarProducto();
                    FrmConsultarProduct.ShowDialog();
                    dgvProductosIngresos.Focus();
                    dgvProductosIngresos.CurrentCell = dgvProductosIngresos.CurrentRow.Cells[0];
                    dgvProductosIngresos.BeginEdit(true);
                    dgvProductosIngresos.CurrentCell.Value = CodigoBarraConsultaProducto;
                    saltarPosicionEsc = true;
                    SendKeys.Send("{ENTER}");
                    break;
            }
        }
        
        public void obtenerFechas()
        {
            añoDesde = Convert.ToString(dtpDesde.Value.Date.Year);
            mesDesde = Convert.ToString(dtpDesde.Value.Date.Month);
            diaDesde = Convert.ToString(dtpDesde.Value.Date.Day);
            fechaDesde = añoDesde + "-" + mesDesde + "-" + diaDesde;
            añoHasta = Convert.ToString(dtpHasta.Value.Date.Year);
            mesHasta = Convert.ToString(dtpHasta.Value.Date.Month);
            diaHasta = Convert.ToString(dtpHasta.Value.Date.Day);
            fechaHasta = añoHasta + "-" + mesHasta + "-" + diaHasta;
        }
        private void txtSerie2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void dgvProductosIngresos_Enter(object sender, EventArgs e)
        {
            try
            {
                datosProductoCompra.Rows[0].Cells[0].ReadOnly = false;
            }
            catch (Exception)
            {
            }
            
        }

        private void dgvProductosIngresos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[posicion] && banderaFocoCelda)
                    datosProductoCompra.BeginEdit(true);
                if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[2])
                    datosProductoCompra.BeginEdit(true);
                if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[3])
                    datosProductoCompra.BeginEdit(true);
                if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[4])
                    datosProductoCompra.BeginEdit(true);
                if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[5])
                    datosProductoCompra.BeginEdit(true);
                if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[6])
                    datosProductoCompra.BeginEdit(true);
                if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[7])
                    datosProductoCompra.BeginEdit(true);
                if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[8])
                    datosProductoCompra.BeginEdit(true);
                if (datosProductoCompra.CurrentCell == datosProductoCompra.CurrentRow.Cells[9])
                    datosProductoCompra.BeginEdit(true);
            }
            catch (Exception ex)
            {
            }
        }
        private void txtSerie1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            string ordenNumero = txtOrdenCompra.Text;
            Funcion.Limpiarobjetos(gbEncabezadoCompra);            
            txtOrdenCompra.Text = ordenNumero;
            if (modificarVer)
            {
                txtOrdenCompra.Text = Convert.ToString(objConsulta.ObtenerCantidadRegistros("Select count(*) as Numeros from TbEncabezadoyPieCompra") + 1);
                BtnGuardar.Enabled = true;
                dgvProductosIngresos.ReadOnly = false;
                txtSerie1.ReadOnly = false;
                txtSerie2.ReadOnly = false;
                txtNumero.ReadOnly = false;
                txtObservacion.ReadOnly = false;
                cbImpuesto.Enabled = true;
                cbProveedor.Enabled = true;
                cbTerminoPago.Enabled = false;
                cbSucursal.Enabled = true;
            }
            BtnGuardar.Text = "&Guardar";
            incializar();
        }

        private void btnSalirCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
