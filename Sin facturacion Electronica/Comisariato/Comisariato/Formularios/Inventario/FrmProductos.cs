﻿using Comisariato.Clases;
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

namespace Comisariato.Formularios.Mantenimiento.Inventario
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
            Objconsul = new Consultas();
        }

        public static string codigo;

        Consultas Objconsul;
        String GlobalCodigoBarra = "";
        bool bandera_Estado = false;
        public static String nameImagen = "";
        byte[] AuxMyDataImagenProducto = new byte[0];
        DataTable dtProductos;

        public void inicializarDatos()
        {
            tcProducto.SelectedIndex = 0; //Seleccion el tab a mostrarse
            pbImagenProducto.Image = Comisariato.Properties.Resources.boxProducto;
            //limpiar los textbox
            txtNombreProducto.Text = "";
            txtCodigoBarraProducto.Text = "";
            txtStockMaximoProducto.Text = "0";
            txtStockMinimoProducto.Text = "0";
            txtCajaProducto.Text = "0";
            txtDisplay.Text = "0";
            txtPVPConIVAProducto.Text = "0.0";
            txtPVPSinIVAProducto.Text = "0.0";
            txtPrecioMayorConIVAProducto.Text = "0.0";
            txtPrecioMayorSinIVAProducto.Text = "0.0";
            txtPrecioCajaConIVAProducto.Text = "0.0";
            txtPrecioCajaSinIVAProducto.Text = "0.0";
            TxtIce.Text = "0.0";
            TxtIRBP.Text = "0.0";
            txtObservacionesProducto.Text = "";
            txtPeso.Text = "0";
            txtUnidadProducto.Text = "0";
            TxtStockActual.Text = "0";
            ckbActivoProducto.Checked = true;
            txtCosto.Text = "0.0";
            txtIDProducto.Text = (Convert.ToInt32(Objconsul.ObtenerID("IDPRODUCTO", "TbProducto", ""))+1).ToString();

            //iniciar combos
            if (cbUnidadMedidaProducto.Items.Count > 0 && cbTipoProducto.Items.Count > 0)
            {
                cbUnidadMedidaProducto.SelectedIndex = 0;
                cbTipoProducto.SelectedIndex = 0;
                //cbPeso.SelectedIndex = 0;
            }

            // Dimensionar lista combo
            cbTipoProducto.DropDownHeight = cbTipoProducto.ItemHeight = 150;
            cbUnidadMedidaProducto.DropDownHeight = cbTipoProducto.ItemHeight = 150;
            //cbPeso.DropDownHeight = cbTipoProducto.ItemHeight = 100;

            //// llenar datadrigview solo los activos
            //cargarDatos("1");

            CkbIva.Checked = false;
            CkbLibreImpuesto.Checked = false;
        }

        private void cargarDatos(string condicion)
        {
            Objconsul = new Consultas();
            //Objconsul.boolLlenarDataGridView(dgvDatosProducto, "Select * from View_VistaFinalProducto P" +
            //" WHERE P.ACTIVO = " + condicion + ";");


            Objconsul.BoolCrearDateTableProductos(dgvDatosProducto, "Select * from View_VistaFinalProducto P" +
            " WHERE P.ACTIVO = " + condicion + ";");

            //dgvDatosProducto.Columns["ID"].Visible = false;
            //dgvDatosProducto.Columns["ACTIVO"].Visible = false;
            DataGridViewColumn col = dgvDatosProducto.Columns["P.V.P."];
            col.DefaultCellStyle.Format = "N2";
            DataGridViewColumn col1 = dgvDatosProducto.Columns["P. MAYOR."];
            col1.DefaultCellStyle.Format = "N2";
            DataGridViewColumn col2 = dgvDatosProducto.Columns["P. CAJA"];
            col2.DefaultCellStyle.Format = "N2";
            DataGridViewColumn col3 = dgvDatosProducto.Columns["COSTO"];
            col3.DefaultCellStyle.Format = "N2";
            try
            {

                dgvDatosProducto.Columns["IVA"].Width = 40;
                dgvDatosProducto.Columns["P. MAYOR."].Width = 50;
                dgvDatosProducto.Columns["P.V.P."].Width = 50;
                dgvDatosProducto.Columns["P. CAJA"].Width = 50;
                dgvDatosProducto.Columns["STOCK"].Width = 50;
                dgvDatosProducto.Columns["COSTO"].Width = 50;
            }
            catch (Exception ex)
            {

            }
        }
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            byte[] bitDataImagen = null;
            if (txtNombreProducto.Text != "" && txtCodigoBarraProducto.Text != "" && txtPVPSinIVAProducto.Text != "" && txtPrecioMayorSinIVAProducto.Text != "" && txtPrecioCajaSinIVAProducto.Text != "")
            {
                if (nameImagen != "")
                {
                    Image img = pbImagenProducto.Image;
                    bitDataImagen = Funcion.imgToByteArray(img);
                }
                //Objconsul.BoolDataTable("SELECT [CANTIDAD]  FROM [dbo].[TbProducto] where IDPRODUCTO = ''")
                Producto ObjProducto = new Producto(txtNombreProducto.Text, ckbActivoProducto.Checked, txtCodigoBarraProducto.Text, cbTipoProducto.Text, 
                    cbUnidadMedidaProducto.Text, txtPeso.Text, Convert.ToInt32(txtStockMaximoProducto.Text), Convert.ToInt32(txtStockMinimoProducto.Text), 
                    Convert.ToInt32(txtCajaProducto.Text), Convert.ToInt32(txtUnidadProducto.Text), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPVPConIVAProducto.Text)), 
                    Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPVPSinIVAProducto.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioMayorConIVAProducto.Text)), 
                    Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioMayorSinIVAProducto.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioCajaConIVAProducto.Text)), 
                    Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioCajaSinIVAProducto.Text)), bitDataImagen, CkbIva.Checked, txtObservacionesProducto.Text, 
                    Convert.ToInt32(cbTipoProducto.SelectedValue), Convert.ToInt32(TxtStockActual.Text), Convert.ToInt32(txtDisplay.Text), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(TxtIce.Text)), 
                    Convert.ToSingle(Funcion.reemplazarcaracterViceversa(TxtIRBP.Text))/*Convert.ToInt32(txtUnidadProducto.Text)*/, CkbLibreImpuesto.Checked);

                if (!bandera_Estado) // Para identificar si se va ingresar
                {
                    String resultado = ObjProducto.InsertarProducto(ObjProducto); // retorna true si esta correcto todo
                    if (resultado == "Datos Guardados")
                    {
                        MessageBox.Show("Producto Registrado Correctamente ", "Exito", MessageBoxButtons.OK);
                        //rbtActivosEmpresa.Checked = true;                  
                        //No hagan nada aqui meco      
                        if (Program.FormularioLlamado)
                        {
                            FrmCompra.datosProductoCompra.CurrentRow.Cells[1].Value = txtNombreProducto.Text;
                            if (CkbIva.Checked)
                            {
                                FrmCompra.datosProductoCompra.CurrentRow.Cells[7].Value = txtPVPConIVAProducto.Text;
                                FrmCompra.datosProductoCompra.CurrentRow.Cells[8].Value = txtPrecioMayorConIVAProducto.Text;
                                FrmCompra.datosProductoCompra.CurrentRow.Cells[9].Value = txtPrecioCajaConIVAProducto.Text;
                            }
                            else
                            {
                                FrmCompra.datosProductoCompra.CurrentRow.Cells[7].Value = txtPVPSinIVAProducto.Text;
                                FrmCompra.datosProductoCompra.CurrentRow.Cells[8].Value = txtPrecioMayorSinIVAProducto.Text;
                                FrmCompra.datosProductoCompra.CurrentRow.Cells[9].Value = txtPrecioCajaSinIVAProducto.Text;
                            }
                            FrmCompra.datosProductoCompra.CurrentCell = FrmCompra.datosProductoCompra.CurrentRow.Cells[2];
                            FrmCompra.datosProductoCompra.BeginEdit(true);
                            Program.FormularioLlamado = false;
                            this.Close();
                        }
                        //----------------------------------------------------------
                        inicializarDatos();
                        //cargarDatos("1");
                    }
                    else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else if (resultado == "Existe") { MessageBox.Show("Ya Existe el Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else if (bandera_Estado) // Para identificar si se va modificar
                {
                    String Resultado = ObjProducto.ModificarProducto(GlobalCodigoBarra); // retorna true si esta correcto todo
                    if (Resultado == "Correcto")
                    {
                        MessageBox.Show("Producto Actualizado", "Exito");
                        //rbtActivosEmpleado.Checked = true;
                        GlobalCodigoBarra = "";
                    }
                    else { MessageBox.Show("Error al actualizar el Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    inicializarDatos();
                    bandera_Estado = false;
                    //cargarDatos("1");
                    btnGuardarProducto.Text = "&Guardar";
                    btnLimpiarProducto.Text = "&Limpiar";
                }
                //else if(txtCeluar1Empresa.Text == "")
                //{
                //    MessageBox.Show("Ingrese al menos un numero de telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}


            }
            else { MessageBox.Show("Ingrese los datos del Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtCodigoBarraProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && txtCodigoBarraProducto.Focused == true)
            {
                txtNombreProducto.Focus();
            }
            Funcion.validar_Num_Letras(e);
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {            
            Objconsul = new Consultas();
            txtIDProducto.Text = (Convert.ToInt32(Objconsul.ObtenerID("IDPRODUCTO", "TbProducto", "")) + 1).ToString();
            SendKeys.Send("{TAB}");
            Objconsul.BoolLlenarComboBox(cbTipoProducto, "Select IDCATEGORIA as ID , DESCRIPCION AS TEXTO from TbCategoria where DESCRIPCION != 'COMBO' ;");
            Objconsul.BoolLlenarComboBox(CmbConsultarCategoria, "Select IDCATEGORIA as ID , DESCRIPCION AS TEXTO from TbCategoria where DESCRIPCION != 'COMBO' ;");
            int cantidaditemcombocategoria = CmbConsultarCategoria.Items.Count;
            CmbConsultarCategoria.SelectedIndex = cantidaditemcombocategoria - 1;
            cbUnidadMedidaProducto.SelectedIndex = 0;
            txtPeso.Text = "";
            inicializarDatos();
            if (Program.FormularioLlamado)
            {
                txtCodigoBarraProducto.Text = codigo;
            }
        }

        bool banderaCheckError = false;

        private void CkbIva_CheckedChanged(object sender, EventArgs e)
        {
            float PVPSinIva = 0.0f, PrecioMayorSinIva = 0.0f, PrecioCajaSinIva = 0.0f;
            float PVPConIva = 0.0f, PrecioMayorConIva = 0.0f, PrecioCajaConIva = 0.0f;
            if (CkbIva.Checked)
            {
                CkbICE.Enabled = true;
                CkbIRBP.Enabled = true;
                banderaCheckError = true;
                CkbLibreImpuesto.Checked = false;
                CkbLibreImpuesto.Enabled = false;
            }
            else
            {
                CkbICE.Enabled = false;
                CkbIRBP.Enabled = false;
                CkbICE.Checked = false;
                CkbIRBP.Checked = false;
                CkbLibreImpuesto.Enabled = true;
                CkbLibreImpuesto.Checked = false;
                TxtIce.Text = "0";
                TxtIRBP.Text = "0";
                banderaCheckError = false;
                txtPVPConIVAProducto.Text = "0";
                txtPrecioMayorConIVAProducto.Text = "0";
                txtPrecioCajaConIVAProducto.Text = "0";
            }

            if ((txtPVPConIVAProducto.Text != "" && txtPrecioMayorConIVAProducto.Text != "" && txtPrecioCajaConIVAProducto.Text != "") && (Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPVPConIVAProducto.Text)) != 0 && Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioMayorConIVAProducto.Text)) != 0 && Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioCajaConIVAProducto.Text)) != 0))
            {
                if (CkbIva.Checked)
                {

                    PVPSinIva = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPVPConIVAProducto.Text)) / 1.12f;
                    PrecioMayorSinIva = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioMayorConIVAProducto.Text)) / 1.12f;
                    PrecioCajaSinIva = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioCajaConIVAProducto.Text)) / 1.12f;
                    //banderaCheckError = false;
                }
                //else
                //{

                //    txtPVPConIVAProducto.Text = "0";
                //    txtPrecioMayorConIVAProducto.Text = "0";
                //    txtPrecioCajaConIVAProducto.Text = "0";
                //}
                if (PVPSinIva != 0 && PrecioMayorSinIva != 0 && PrecioCajaSinIva != 0)
                {

                    txtPVPSinIVAProducto.Text = PVPSinIva.ToString("#####0.0000");
                    txtPrecioMayorSinIVAProducto.Text = PrecioMayorSinIva.ToString("#####0.0000");
                    txtPrecioCajaSinIVAProducto.Text = PrecioCajaSinIva.ToString("#####0.0000");
                    txtPVPSinIVAProducto.Text = Funcion.reemplazarcaracter(PVPSinIva.ToString());
                    txtPrecioMayorSinIVAProducto.Text = Funcion.reemplazarcaracter(PrecioMayorSinIva.ToString());
                    txtPrecioCajaSinIVAProducto.Text = Funcion.reemplazarcaracter(PrecioCajaSinIva.ToString());
                }
            }


            if ((txtPVPSinIVAProducto.Text != "" && txtPrecioMayorSinIVAProducto.Text != "" && txtPrecioCajaSinIVAProducto.Text != "") && (Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPVPSinIVAProducto.Text)) != 0 && Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioMayorSinIVAProducto.Text)) != 0 && Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioCajaSinIVAProducto.Text)) != 0))
            {
                if (CkbIva.Checked)
                {

                    PVPConIva = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPVPSinIVAProducto.Text)) * 0.12f;
                    PrecioMayorConIva = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioMayorSinIVAProducto.Text)) * 0.12f;
                    PrecioCajaConIva = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioCajaSinIVAProducto.Text)) * 0.12f;
                    //banderaCheckError = false;
                }
                //else
                //{

                //    txtPVPConIVAProducto.Text = "0";
                //    txtPrecioMayorConIVAProducto.Text = "0";
                //    txtPrecioCajaConIVAProducto.Text = "0";
                //}
                if (PVPConIva != 0 && PrecioMayorConIva != 0 && PrecioCajaConIva != 0)
                {
                    txtPVPConIVAProducto.Text = PVPSinIva.ToString("#####0.0000");
                    txtPrecioMayorConIVAProducto.Text = PrecioMayorSinIva.ToString("#####0.0000");
                    txtPrecioCajaConIVAProducto.Text = PrecioCajaSinIva.ToString("#####0.0000");
                    txtPVPConIVAProducto.Text = Funcion.reemplazarcaracter((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPVPSinIVAProducto.Text)) + PVPConIva).ToString());
                    txtPrecioMayorConIVAProducto.Text = Funcion.reemplazarcaracter((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioMayorSinIVAProducto.Text)) + PrecioMayorConIva).ToString());
                    txtPrecioCajaConIVAProducto.Text = Funcion.reemplazarcaracter((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioCajaSinIVAProducto.Text)) + PrecioCajaConIva).ToString());
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pbImagenProducto.Image = Comisariato.Properties.Resources.boxProducto;
            //Image img = pbImagenProducto.Image;
        }

        private void btnBuscarImagenProducto_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarLogo = new OpenFileDialog();
            BuscarLogo.Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg";
            if (BuscarLogo.ShowDialog() == DialogResult.OK)
            {
                nameImagen = BuscarLogo.FileName;
                pbImagenProducto.Image = Image.FromFile(BuscarLogo.FileName);
                pbImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void TxtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);

            if (e.KeyChar == (char)Keys.Return)
            {

                //int iva = Convert.ToInt32(TxtIVA.Text);
                //txtPVPConIVAProducto.Text = (((Convert.ToDouble(Funcion.reemplazarcaracterViceversa(txtPVPSinIVAProducto.Text)) * iva) / 100) + Convert.ToDouble(Funcion.reemplazarcaracterViceversa(txtPVPSinIVAProducto.Text))).ToString();
                //txtPrecioCajaConIVAProducto.Text = (((Convert.ToDouble(Funcion.reemplazarcaracterViceversa(txtPrecioCajaSinIVAProducto.Text)) * iva) / 100) + Convert.ToDouble(Funcion.reemplazarcaracterViceversa(txtPrecioCajaSinIVAProducto.Text))).ToString();
                //txtPrecioMayorConIVAProducto.Text = (((Convert.ToDouble(Funcion.reemplazarcaracterViceversa(txtPrecioMayorSinIVAProducto.Text)) * iva) / 100) + Convert.ToDouble(Funcion.reemplazarcaracterViceversa(txtPrecioMayorSinIVAProducto.Text))).ToString();

                txtObservacionesProducto.Focus();

            }

        }

        private void dgvDatosProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Producto ObjProducto = new Producto();
                if (rbtActivos.Checked)
                {
                    if (this.dgvDatosProducto.Columns[e.ColumnIndex].Name == "Deshabilitar")
                    {
                        ObjProducto.EstadoProducto(dgvDatosProducto.CurrentRow.Cells[2].Value.ToString(), 2);
                        //cargarDatos("1");
                        dgvDatosProducto.Rows.RemoveAt(e.RowIndex);
                    }
                }
                else if (rbtInactivos.Checked)
                {
                    if (this.dgvDatosProducto.Columns[e.ColumnIndex].Name == "Deshabilitar")
                    {
                        ObjProducto.EstadoProducto(dgvDatosProducto.CurrentRow.Cells[2].Value.ToString(), 1);
                        //cargarDatos("0");
                        dgvDatosProducto.Rows.RemoveAt(e.RowIndex);
                    }
                }

                if (this.dgvDatosProducto.Columns[e.ColumnIndex].Name == "Modificar")
                {
                    //MessageBox.Show("modificar toca " + DgvDatosEmpleado.CurrentRow.Cells[3].Value.ToString());
                    GlobalCodigoBarra = dgvDatosProducto.CurrentRow.Cells[2].Value.ToString();
                    tcProducto.SelectedIndex = 0;
                    bandera_Estado = true;
                    //Llenar el DataTable
                    DataTable dt = Objconsul.BoolDataTable("Select * from TbProducto where CODIGOBARRA = '" + GlobalCodigoBarra + "'");
                    //Arreglo de byte en donde se almacenara la foto en bytes
                    byte[] MyDataProducto = new byte[0];
                    //Verificar si tiene Datos
                    if (dt.Rows.Count > 0)
                    {
                        DataRow myRow = dt.Rows[0];
                        MemoryStream stream;

                        //Se almacena el campo foto de la tabla en el arreglo de bytes

                        if (myRow["IMAGENPRODUCTO"] != System.DBNull.Value)
                        {
                            MyDataProducto = (byte[])myRow["IMAGENPRODUCTO"];
                            AuxMyDataImagenProducto = MyDataProducto;
                            //Se inicializa un flujo en memoria del arreglo de bytes
                            stream = new MemoryStream(MyDataProducto);
                            //En el picture box se muestra la imagen que esta almacenada en el flujo en memoria 
                            //el cual contiene el arreglo de bytes
                            pbImagenProducto.Image = Image.FromStream(stream);
                            stream.Dispose();
                        }

                        //Cargar los demas Datos
                        cbTipoProducto.SelectedValue = Convert.ToInt32(myRow["IDCATEGORIA"]);
                        ckbActivoProducto.Checked = Convert.ToBoolean(myRow["ACTIVO"]);
                        txtNombreProducto.Text = myRow["NOMBREPRODUCTO"].ToString();
                        txtCodigoBarraProducto.Text = myRow["CODIGOBARRA"].ToString();

                        cbUnidadMedidaProducto.SelectedItem = myRow["UNIDAMEDIDA"].ToString();
                        txtPeso.Text = myRow["PESO"].ToString();
                        txtStockMaximoProducto.Text = myRow["STOCKMAXIMO"].ToString();
                        txtStockMinimoProducto.Text = myRow["STOCKMINIMO"].ToString();
                        //txtDisplay.Text= myRow["DISPLAY"].ToString();
                        txtUnidadProducto.Text = myRow["UNIDAD"].ToString();
                        TxtIce.Text = Funcion.reemplazarcaracter(myRow["ICE"].ToString());
                        TxtIRBP.Text = Funcion.reemplazarcaracter(myRow["IRBP"].ToString());
                        lbCosto.Visible = true;
                        txtCosto.Visible = true;
                        txtCosto.Text = Funcion.reemplazarcaracter(myRow["PRECIOCOMPRA"].ToString());
                        txtIDProducto.Text = Funcion.reemplazarcaracter(myRow["IDPRODUCTO"].ToString());


                        CkbIva.Checked = Convert.ToBoolean(myRow["IVAESTADO"]);

                        if (myRow["CAJA"] != System.DBNull.Value)
                        {
                            txtCajaProducto.Text = myRow["CAJA"].ToString();
                        }
                        if (myRow["DISPLAY"] != System.DBNull.Value)
                        {
                            txtDisplay.Text = myRow["DISPLAY"].ToString();
                        }

                        if (myRow["CANTIDAD"] != System.DBNull.Value)
                        {
                            TxtStockActual.Text = myRow["CANTIDAD"].ToString();
                        }

                        txtPVPConIVAProducto.Text = Funcion.reemplazarcaracter(myRow["PRECIOPUBLICO_IVA"].ToString());
                        txtPVPSinIVAProducto.Text = Funcion.reemplazarcaracter(myRow["PRECIOPUBLICO_SIN_IVA"].ToString());
                        txtPrecioMayorConIVAProducto.Text = Funcion.reemplazarcaracter(myRow["PRECIOALMAYOR_IVA"].ToString());
                        txtPrecioMayorSinIVAProducto.Text = Funcion.reemplazarcaracter(myRow["PRECIOALMAYOR_SIN_IVA"].ToString());
                        txtPrecioCajaConIVAProducto.Text = Funcion.reemplazarcaracter(myRow["PRECIOPORCAJA_IVA"].ToString());
                        txtPrecioCajaSinIVAProducto.Text = Funcion.reemplazarcaracter(myRow["PRECIOPORCAJA_SIN_IVA"].ToString());

                        if (TxtIce.Text != "0" && TxtIce.Text != "")
                            CkbICE.Checked = true;
                        else
                        {
                            CkbICE.Checked = false;
                            TxtIce.Text = "0.00";
                        }
                        if (TxtIRBP.Text != "0" && TxtIRBP.Text != "")
                            CkbIRBP.Checked = true;
                        else
                        {
                            CkbIRBP.Checked = false;
                            TxtIRBP.Text = "0.00";
                        }
                        if (myRow["LIBREIMPUESTO"] != System.DBNull.Value)
                        {
                            CkbLibreImpuesto.Checked = Convert.ToBoolean(myRow["LIBREIMPUESTO"]);
                        }
                        //CkbICE.Checked = Convert.ToBoolean(myRow["ICEESTADO"]);
                        //CkbIRBP.Checked = Convert.ToBoolean(myRow["IRBPESTADO"]);

                        //TxtIVA.Text = myRow["IVA"].ToString();
                        //TxtIce.Text = myRow["ICE"].ToString();
                        //TxtIRBP.Text = myRow["IRBP"].ToString();

                        txtObservacionesProducto.Text = myRow["OBSERVACIONES"].ToString();
                    }
                    btnLimpiarProducto.Text = "&Cancelar";
                    btnGuardarProducto.Text = "&Modificar";

                }
            }
            catch (Exception)
            {

            }

        }

        private void txtPVPConIVAProducto_TextChanged(object sender, EventArgs e)
        {

            //txtPVPConIVAProducto.Text = Math.Round(Convert.ToDouble(txtPVPConIVAProducto.Text), 2).ToString();

            //txtPVPConIVAProducto.Text = Funcion.reemplazarcaracter(txtPVPConIVAProducto.Text);
        }

        private void txtPrecioMayorConIVAProducto_TextChanged(object sender, EventArgs e)
        {
            //txtPrecioMayorConIVAProducto.Text = Funcion.reemplazarcaracter(txtPrecioMayorConIVAProducto.Text);
        }

        private void txtPrecioCajaConIVAProducto_TextChanged(object sender, EventArgs e)
        {
            //txtPrecioCajaConIVAProducto.Text = Funcion.reemplazarcaracter(txtPrecioCajaConIVAProducto.Text);
        }

        private void txtPVPSinIVAProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtPVPSinIVAProducto.Text);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPrecioMayorSinIVAProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtPrecioMayorSinIVAProducto.Text);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPrecioCajaSinIVAProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtPrecioCajaSinIVAProducto.Text);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }


        private void rbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbtActivos.Checked)
            //{
            //    cargarDatos("1");
            //    //dgvDatosProducto.Columns[1].HeaderText = "Desabilitar";
            //}
            //else if (rbtInactivos.Checked)
            //{
            //    cargarDatos("0");
            //    //dgvDatosProducto.Columns[1].HeaderText = "Habilitar";
            //}
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            if (btnLimpiarProducto.Text == "&Cancelar")
            {
                inicializarDatos();
                btnLimpiarProducto.Text = "&Limpiar";
                btnGuardarProducto.Text = "&Guardar";
            }
            else { inicializarDatos(); }
            bandera_Estado = false;
        }

        private void txtConsultarProducto_TextChanged(object sender, EventArgs e)
        {
            //if (rbtActivos.Checked)
            //{
            //    Objconsul.BoolCrearDateTableProductos(dgvDatosProducto, "Select  * from View_VistaFinalProducto P where P.ACTIVO   = 1 and P.[CODIGO BARRA] like '%" + txtConsultarProducto.Text + "%' or P.PRODUCTO like '%" + txtConsultarProducto.Text + "%' or P.CATEGORIA like '%" + txtConsultarProducto.Text + "%' or P.PROVEEDOR like '%" + txtConsultarProducto.Text + "%' ; ");
            //    //dgvDatosProducto.Columns["ID"].Visible = false;
            //    //dgvDatosProducto.Columns["ACTIVO"].Visible = false;
            //}
            //else if (rbtInactivos.Checked)
            //{
            //    Objconsul.BoolCrearDateTableProductos(dgvDatosProducto, "Select * from View_VistaFinalProducto P where P.ACTIVO = 0 and P.[CODIGO BARRA] like '%" + txtConsultarProducto.Text + "%' or P.PRODUCTO  like '%" + txtConsultarProducto.Text + "%' or P.CATEGORIA like '%" + txtConsultarProducto.Text + "%' or P.PROVEEDOR like '%" + txtConsultarProducto.Text + "%' ;");
            //    //dgvDatosProducto.Columns["ID"].Visible = false;
            //    //dgvDatosProducto.Columns["ACTIVO"].Visible = false;
            //}
        }



        private void txtStockMaximoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }

        }

        private void txtObservacionesProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion.validar_Num_Letras(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void CkbICE_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbICE.Checked)
            {
                TxtIce.Enabled = true;
            }
            else
                TxtIce.Enabled = false;
        }

        private void CkbIRBP_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbIRBP.Checked)
            {
                TxtIRBP.Enabled = true;
            }
            else
                TxtIRBP.Enabled = false;
        }

        private void txtPVPConIVAProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPVPConIVAProducto_Leave(object sender, EventArgs e)
        {

            float PVPSinIva = 0.0f, PrecioMayorSinIva = 0.0f, PrecioCajaSinIva = 0.0f;
            if ((txtPVPConIVAProducto.Text != "" && txtPrecioMayorConIVAProducto.Text != "" && txtPrecioCajaConIVAProducto.Text != "") && (Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPVPConIVAProducto.Text)) != 0 && Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioMayorConIVAProducto.Text)) != 0 && Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioCajaConIVAProducto.Text)) != 0))
            {
                if (CkbIva.Checked)
                {

                    PVPSinIva = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPVPConIVAProducto.Text)) / 1.12f;
                    PrecioMayorSinIva = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioMayorConIVAProducto.Text)) / 1.12f;
                    PrecioCajaSinIva = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioCajaConIVAProducto.Text)) / 1.12f;
                    //banderaCheckError = false;
                }
                //else
                //{

                //    txtPVPConIVAProducto.Text = "0";
                //    txtPrecioMayorConIVAProducto.Text = "0";
                //    txtPrecioCajaConIVAProducto.Text = "0";
                //}
                if (PVPSinIva != 0 && PrecioMayorSinIva != 0 && PrecioCajaSinIva != 0)
                {

                    txtPVPSinIVAProducto.Text = PVPSinIva.ToString("#####0.0000");
                    txtPrecioMayorSinIVAProducto.Text = PrecioMayorSinIva.ToString("#####0.0000");
                    txtPrecioCajaSinIVAProducto.Text = PrecioCajaSinIva.ToString("#####0.0000");
                    txtPVPSinIVAProducto.Text = Funcion.reemplazarcaracter(PVPSinIva.ToString());
                    txtPrecioMayorSinIVAProducto.Text = Funcion.reemplazarcaracter(PrecioMayorSinIva.ToString());
                    txtPrecioCajaSinIVAProducto.Text = Funcion.reemplazarcaracter(PrecioCajaSinIva.ToString());
                }
            }
        }

        private void txtPVPConIVAProducto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtPVPConIVAProducto.Text);
            //txtPVPConIVAProducto.Select();
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPrecioMayorConIVAProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtPrecioMayorConIVAProducto.Text);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPrecioCajaConIVAProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtPrecioCajaConIVAProducto.Text);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtStockMaximoProducto_Enter(object sender, EventArgs e)
        {

            txtStockMaximoProducto.SelectAll();
            txtStockMaximoProducto.Focus();
        }

        private void txtCajaProducto_Enter(object sender, EventArgs e)
        {
            txtCajaProducto.SelectAll();
            txtCajaProducto.Focus();
        }

        private void txtStockMinimoProducto_Enter(object sender, EventArgs e)
        {
            txtStockMinimoProducto.SelectAll();
            txtStockMinimoProducto.Focus();
        }



        private void txtPVPConIVAProducto_Enter(object sender, EventArgs e)
        {
            txtPVPConIVAProducto.SelectAll();
            txtPVPConIVAProducto.Focus();
        }

        private void txtPrecioMayorConIVAProducto_Enter(object sender, EventArgs e)
        {
            txtPrecioMayorConIVAProducto.SelectAll();
            txtPrecioMayorConIVAProducto.Focus();
        }

        private void txtPrecioCajaConIVAProducto_Enter(object sender, EventArgs e)
        {
            txtPrecioCajaConIVAProducto.SelectAll();
            txtPrecioCajaConIVAProducto.Focus();
        }

        private void dgvDatosProducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvDatosProducto.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = dgvDatosProducto.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\modificarDgv.ico");

                Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.modificarDgv);
                IntPtr Hicon = bitmap.GetHicon();
                Icon icoAtomico = Icon.FromHandle(Hicon);
                //bitmap.SetResolution(72, 72);

                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                dgvDatosProducto.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dgvDatosProducto.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }

            if (rbtInactivos.Checked)
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosProducto.Columns[e.ColumnIndex].Name == "Deshabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosProducto.Rows[e.RowIndex].Cells["Deshabilitar"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\Habilitar.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.Habilitar);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosProducto.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosProducto.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosProducto.Columns[e.ColumnIndex].Name == "Deshabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosProducto.Rows[e.RowIndex].Cells["Deshabilitar"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\EliminarDgv.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.EliminarDgv);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosProducto.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosProducto.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (txtNombreProducto.Text.Length > 14)
            {

                //string parte2 = "";
                int dimension = txtNombreProducto.Text.Length;

                for (int i = 14; i < dimension; i++)
                {
                    //parte2 = txtNombreProducto.Text.Substring(i, 1);
                    //txtNombreProducto.SelectionStart = 16;
                    txtNombreProducto.SelectionColor = Color.Red;
                }
            }

        }

        private void txtPVPSinIVAProducto_Enter(object sender, EventArgs e)
        {
            txtPVPSinIVAProducto.SelectAll();
        }

        private void txtPrecioMayorSinIVAProducto_Enter(object sender, EventArgs e)
        {
            txtPrecioMayorSinIVAProducto.SelectAll();
        }

        private void txtPrecioCajaSinIVAProducto_Enter(object sender, EventArgs e)
        {
            txtPrecioCajaSinIVAProducto.SelectAll();
        }

        private void txtNombreProducto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Funcion.validar_Num_Letras(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                cbUnidadMedidaProducto.Focus();
            }
        }

        private void cbUnidadMedidaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void CkbIva_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPVPConIVAProducto_TextChanged_1(object sender, EventArgs e)
        {
            if (!CkbIva.Checked)
            {
                txtPVPConIVAProducto.Text = "0";
                txtPrecioMayorConIVAProducto.Text = "0";
                txtPrecioCajaConIVAProducto.Text = "0";
            }
        }

        private void txtPVPSinIVAProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPVPSinIVAProducto_Leave(object sender, EventArgs e)
        {

            float PVPConIva = 0.0f, PrecioMayorConIva = 0.0f, PrecioCajaConIva = 0.0f;
            if ((txtPVPSinIVAProducto.Text != "" && txtPrecioMayorSinIVAProducto.Text != "" && txtPrecioCajaSinIVAProducto.Text != "") && (Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPVPSinIVAProducto.Text)) != 0 && Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioMayorSinIVAProducto.Text)) != 0 && Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioCajaSinIVAProducto.Text)) != 0))
            {
                if (CkbIva.Checked)
                {

                    PVPConIva = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPVPSinIVAProducto.Text)) * 0.12f;
                    PrecioMayorConIva = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioMayorSinIVAProducto.Text)) * 0.12f;
                    PrecioCajaConIva = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioCajaSinIVAProducto.Text)) * 0.12f;
                    //banderaCheckError = false;
                }
                //else
                //{

                //    txtPVPConIVAProducto.Text = "0";
                //    txtPrecioMayorConIVAProducto.Text = "0";
                //    txtPrecioCajaConIVAProducto.Text = "0";
                //}
                if (PVPConIva != 0 && PrecioMayorConIva != 0 && PrecioCajaConIva != 0)
                {

                    txtPVPConIVAProducto.Text = PVPConIva.ToString("#####0.0000");
                    txtPrecioMayorConIVAProducto.Text = PrecioMayorConIva.ToString("#####0.0000");
                    txtPrecioCajaConIVAProducto.Text = PrecioCajaConIva.ToString("#####0.0000");
                    txtPVPConIVAProducto.Text = Funcion.reemplazarcaracter((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPVPSinIVAProducto.Text)) + PVPConIva).ToString());
                    txtPrecioMayorConIVAProducto.Text = Funcion.reemplazarcaracter((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioMayorSinIVAProducto.Text)) + PrecioMayorConIva).ToString());
                    txtPrecioCajaConIVAProducto.Text = Funcion.reemplazarcaracter((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtPrecioCajaSinIVAProducto.Text)) + PrecioCajaConIva).ToString());
                }
            }
        }

        private void TxtIce_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, TxtIce.Text);
        }

        private void TxtIRBP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, TxtIRBP.Text);
        }

        private void TxtIce_Enter(object sender, EventArgs e)
        {
            TxtIce.SelectAll();
        }

        private void TxtIRBP_Enter(object sender, EventArgs e)
        {
            TxtIRBP.SelectAll();
        }

        private void txtUnidadProducto_Enter(object sender, EventArgs e)
        {
            txtUnidadProducto.SelectAll();
        }

        private void txtPeso_Enter(object sender, EventArgs e)
        {
            txtPeso.SelectAll();
        }


        private void txtStockMinimoProducto_Leave(object sender, EventArgs e)
        {
            int stockMax = Convert.ToInt32(txtStockMaximoProducto.Text);
            int stockMin = Convert.ToInt32(txtStockMinimoProducto.Text);
            if (stockMax < stockMin)
            {
                MessageBox.Show("El Stock Mimimo debe ser menor al Stock Máximo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtStockMinimoProducto.Focus();
                txtStockMinimoProducto.SelectAll();
            }
        }

        private void CkbLibreImpuesto_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbLibreImpuesto.Checked)
            {
                CkbIva.Enabled = false;
                CkbIva.Checked = false;
            }
            else
            {
                CkbIva.Enabled = true;
                CkbIva.Checked = false;
            }
        }

        private void txtPVPConIVAProducto_Click(object sender, EventArgs e)
        {
            txtPVPConIVAProducto.SelectAll();
            txtPVPConIVAProducto.Focus();
        }

        private void txtPVPSinIVAProducto_Click(object sender, EventArgs e)
        {
            txtPVPSinIVAProducto.SelectAll();
        }

        private void txtPrecioMayorConIVAProducto_Click(object sender, EventArgs e)
        {
            txtPrecioMayorConIVAProducto.SelectAll();
            txtPrecioMayorConIVAProducto.Focus();

        }

        private void txtPrecioCajaConIVAProducto_Click(object sender, EventArgs e)
        {
            txtPrecioCajaConIVAProducto.SelectAll();
            txtPrecioCajaConIVAProducto.Focus();
        }

        private void txtPrecioMayorSinIVAProducto_Click(object sender, EventArgs e)
        {
            txtPrecioMayorSinIVAProducto.SelectAll();
        }

        private void txtPrecioCajaSinIVAProducto_Click(object sender, EventArgs e)
        {
            txtPrecioCajaSinIVAProducto.SelectAll();
        }

        private void TxtIce_Click(object sender, EventArgs e)
        {
            TxtIce.SelectAll();
        }

        private void TxtIRBP_Click(object sender, EventArgs e)
        {
            TxtIRBP.SelectAll();
        }

        private void txtCajaProducto_Click(object sender, EventArgs e)
        {
            txtCajaProducto.SelectAll();
            txtCajaProducto.Focus();
        }

        private void txtDisplay_Click(object sender, EventArgs e)
        {
            txtDisplay.SelectAll();
            txtDisplay.Focus();
        }

        private void txtUnidadProducto_Click(object sender, EventArgs e)
        {
            txtUnidadProducto.SelectAll();
            txtUnidadProducto.Focus();
        }

        private void txtPeso_Click(object sender, EventArgs e)
        {
            txtPeso.SelectAll();
            txtPeso.Focus();
        }

        private void txtStockMaximoProducto_Click(object sender, EventArgs e)
        {
            txtStockMaximoProducto.SelectAll();
            txtStockMaximoProducto.Focus();
        }

        private void txtStockMinimoProducto_Click(object sender, EventArgs e)
        {
            txtStockMinimoProducto.SelectAll();
            txtStockMinimoProducto.Focus();
        }

        private void txtConsultarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //SendKeys.Send("{TAB}");ç
                BtnBuscar_Click(null, null);
            }
        }

        private void TxtStockActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvDatosProducto.Rows.Count > 0)
            {
                if (Funcion.ExportarDataGridViewExcel(dgvDatosProducto,2))
                {
                    MessageBox.Show("Reporte creado con exito.");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al crear el reporte.");
                }

            }
        }

        private void TxtStockActual_Enter(object sender, EventArgs e)
        {
            TxtStockActual.SelectAll();
            TxtStockActual.Focus();
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtCosto.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Objconsul = new Consultas();
                //if (e.KeyChar == (char)Keys.Return)
                //{
                int auxiliarcont = 0;
                string codigobarra = "", nombreproducto = "", proveedor = "", categoriaconsult = "";

                string condicioncodigobarra = "", condicionnombreproducto = "", condicionproveedor = "", condicioncategoriaconsult = "";

                if (txtConsultarCodigoBarra.Text != "")
                {
                    codigobarra = txtConsultarCodigoBarra.Text + "%";
                    //auxiliarcont += 1;
                    //if (auxiliarcont > 1)
                    condicioncodigobarra = "and P.[CODIGO BARRA] like '" + codigobarra + "'";
                }
                if (txtConsultarNombreProducto.Text != "")
                {
                    nombreproducto = txtConsultarNombreProducto.Text + "%";
                    //auxiliarcont += 1;
                    //if (auxiliarcont > 1)
                    condicionnombreproducto = "and P.PRODUCTO like '%" + nombreproducto + "%'";
                }
                if (txtConsultarProveedor.Text != "")
                {
                    proveedor = txtConsultarProveedor.Text + "%";
                    //auxiliarcont += 1;
                    //if (auxiliarcont > 1)
                    condicionproveedor = "and P.PROVEEDOR like '" + proveedor + "'";
                }
                if (CmbConsultarCategoria.Text != "TODOS")
                {
                    categoriaconsult = CmbConsultarCategoria.Text + "%";
                    //auxiliarcont += 1;
                    //if (auxiliarcont > 1)
                    condicioncategoriaconsult = "and P.CATEGORIA like '" + categoriaconsult + "'";
                }

                if (rbtActivos.Checked)
                {
                    if ((txtConsultarCodigoBarra.Text != "" || txtConsultarNombreProducto.Text != "" || txtConsultarProveedor.Text != "" || CmbConsultarCategoria.Text != ""))
                        dtProductos = Objconsul.BoolCrearDateTableProductos(dgvDatosProducto, "Select  * from View_VistaFinalProducto P where P.ACTIVO   = 1 " + condicioncodigobarra + " " + condicionnombreproducto + " " + condicioncategoriaconsult + " " + condicionproveedor + " ; ");
                    //else if (auxiliarcont > 1)
                    //Objconsul.BoolCrearDateTableProductos(dgvDatosProducto, "Select  * from View_VistaFinalProducto P where P.ACTIVO   = 1 and P.[CODIGO BARRA] like '" + codigobarra + "' and P.PRODUCTO like '" + nombreproducto + "' and P.CATEGORIA like '" + categoriaconsult + "' and P.PROVEEDOR like '" + proveedor + "' ; ");
                    //dgvDatosProducto.Columns["ID"].Visible = false;
                    //dgvDatosProducto.Columns["ACTIVO"].Visible = false;
                }
                else if (rbtInactivos.Checked)
                {
                    if ((txtConsultarCodigoBarra.Text != "" || txtConsultarNombreProducto.Text != "" || txtConsultarProveedor.Text != "" || CmbConsultarCategoria.Text != ""))
                        //Objconsul.BoolCrearDateTableProductos(dgvDatosProducto, "Select * from View_VistaFinalProducto P where P.ACTIVO = 0 and (P.[CODIGO BARRA] like '" + codigobarra + "' and P.PRODUCTO  like '" + nombreproducto + "' and P.CATEGORIA like '" + categoriaconsult + "' and P.PROVEEDOR like '" + proveedor + "' );");
                        dtProductos = Objconsul.BoolCrearDateTableProductos(dgvDatosProducto, "Select  * from View_VistaFinalProducto P where P.ACTIVO   = 0 " + condicioncodigobarra + " " + condicionnombreproducto + " " + condicioncategoriaconsult + " " + condicionproveedor + " ; ");
                    //else if (auxiliarcont > 1)
                    //objconsul.BoolCrearDateTableProductos(dgvDatosProducto, "Select * from View_VistaFinalProducto P where P.ACTIVO = 0 and (P.[CODIGO BARRA] like '" + codigobarra + "' and P.PRODUCTO  like '" + nombreproducto + "' and P.CATEGORIA like '" + categoriaconsult + "' and P.PROVEEDOR like '" + proveedor + "' );");
                    //dgvDatosProducto.Columns["ID"].Visible = false;
                    //dgvDatosProducto.Columns["ACTIVO"].Visible = false;
                }

                if (dgvDatosProducto.Rows.Count > 2)
                {
                    if(dgvDatosProducto.Rows[0].Cells[3].Value != null)
                        GrbMicrobusqueda.Enabled = true;
                    else
                        GrbMicrobusqueda.Enabled = false;
                }
                else
                    GrbMicrobusqueda.Enabled = false;
            }
            catch (Exception ex)
            {

            }
            
            //}
        }

        
        private void BtnBuscarMicroBusqueda_Click(object sender, EventArgs e)
        {
            if (dtProductos != null)
            {
                string Codigo = string.Concat("[", dtProductos.Columns[0].ColumnName, "]");
                string Nombre = string.Concat("[", dtProductos.Columns[1].ColumnName, "]");
                string Costo = string.Concat("[", dtProductos.Columns[4].ColumnName, "]");
                dtProductos.DefaultView.Sort = Codigo;
                DataView view = dtProductos.DefaultView;
                view.RowFilter = string.Empty;
                if (TxtNombreMicrobusca.Text != "")
                {
                    view.RowFilter = Nombre + " =  '" + TxtNombreMicrobusca.Text + "'"; 
                }
                if (TxtCodigoBarraMicrobusca.Text != "")
                {
                    view.RowFilter = Codigo + " =  '" + TxtCodigoBarraMicrobusca.Text + "'";
                }
                if (TxtCostoMicrobusca.Text != "")
                {
                    view.RowFilter = Costo + " =  '" + TxtCostoMicrobusca.Text + "'";
                }
                    
                dgvDatosProducto.DataSource = view;
            }
        }

        private void TxtCodigoBarraMicrobusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //SendKeys.Send("{TAB}");ç
                BtnBuscarMicroBusqueda_Click(null, null);
            }
        }
    }
}
