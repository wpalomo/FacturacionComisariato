using Comisariato.Clases;
using Comisariato.Formularios.Mantenimiento.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Threading;
using Comisariato.Ride.Retencion;

namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmOrdenDeGiro : Form
    {

        string PathLocal = @"C:\Users\Public\Documents\ArchivosXml\Generados\";
        int numeroOrden = 0;
        String RutaXML = "";
        String NombreXML = "";
        String FechaEmision = "";
        DataTable DtDocuemtosXML;
        delegate void CambiarProgresoDelegado(string nombreXml, string fecha, string contadordevuelta, string contadorRecivida, string contadorautorizado, string contadornoautorizado, string contadorenviados, string contador, string archivosTotales);
        bool radioB = true;

        public FrmOrdenDeGiro()
        {
            InitializeComponent();
        }
        bool ver = false;
        Consultas ObjConsul = new Consultas();
        Bitacora bitacora = new Bitacora();
        List<string> parametrosFactu =  new List<string>();
        string claveacceso="";
        public void inicializar()
        {
            if (ver)
            {
                txtOrdenGiro.Enabled = true;
                CmbTipoDocumento.Enabled = true;
                cbTipo.Enabled = true;
                txtPlazo.Enabled = true;
                txtConcepto.Enabled = true;
                txtNAutorizacion.Enabled = true;
                txtNumero.Enabled = true;
                txtSerie1.Enabled = true;
                txtSerie2.Enabled = true;
                ckbRISE.Enabled = true;
                ckbDeclaraSRI.Enabled = true;
                ckbManual.Enabled = true;
                dtpFechaDocumentacion.Enabled = true;
                dtpFechaOrdenGiro.Enabled = true;
                dtpFechaVigente.Enabled = true;
                dtpFechaRetencion.Enabled = true;
                dtpFechaVenceDocumento.Enabled = true;
                txtSerie1Retencion.Enabled = true;
                txtSerie2Retencion.Enabled = true;
                txtNumeroRetencion.Enabled = true;
                txtAutorizacionRetencion.Enabled = true;
                CmbProveedor.Enabled = true;
                cbSustentoTributario.Enabled = true;
                dtpFechaContabilizacion.Enabled = true;
                cbFormaPago.Enabled = true;
                cbAutorizacionSRI.Enabled = true;
                int idOrdenGiro = ObjConsul.ObtenerID("IDORDENGIRO", "TbEncabezadoOrdenGiro", "");
                ObjConsul.seriesDocumentoRetencion(txtNumeroRetencion, txtSerie1Retencion, txtSerie2Retencion, txtAutorizacionRetencion, "RET", bitacora.LocalIPAddress());
                int NordenGiro = 1 + ObjConsul.ObtenerID("NUMEROORDENGIRO", "TbEncabezadoOrdenGiro", " where IDORDENGIRO =" + idOrdenGiro + "");
                txtOrdenGiro.Text = NordenGiro.ToString();
                ver = true;
                
            }
            Funcion.Limpiarobjetos(gbDatosFactura);
            txtSerie1.Text = "";
            txtSerie2.Text = "";
            txtNumero.Text = "";
            txtSerie1.ReadOnly = false;
            txtSerie2.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtConcepto.Text = "";
            txtTotalDebe.Text = "";
            txtTotalHaber.Text = "";
            cbSustentoTributario.Text = "";
            cbTipo.SelectedIndex = 0;
            cbAutorizacionSRI.SelectedIndex = 0;
            Funcion.Limpiarobjetos(gbDatosAutorizacion);
            dgvDatosLibroDiario.Rows.Clear();
            dgvDatosRetencion.Rows.Clear();
            for (int i = 0; i < 7; i++)
            {
                dgvDatosLibroDiario.Rows.Add();
            }
            for (int i = 0; i < 14; i++)
            {
                dgvDatosRetencion.Rows.Add();
            }
            for (int i = 0; i < 25; i++)
            {
                dgvDatosOG.Rows.Add();
            }
        }
        public string agregra0Decimal(string valor)
        {
            
            int i;
            int ocurrencias = valor.Split('.').Length - 1;
            if (ocurrencias == 0)
            {
                valor += ".0";
            }
            string[] s = valor.Split('.');
            for (i = 0; i < s[1].Length;)
            {
                i++;
            }
            if (i < 4)
            {
                for (int j = i; j < 4; j++)
                {
                    s[1] += "0"; 
                }
            }
            return s[0] + "." + s[1];
        }
        public void llenarDatosOG(int ecnabezadoCompra)
        {
            try
            {
                SqlDataReader datos = null;
                datos = ObjConsul.obtenerDatos("select * from TbEncabezadoyPieCompra where IDEMCABEZADOCOMPRA = " + ecnabezadoCompra + "");
                txtNumero.Text = Convert.ToString(datos["NUMERO"]);
                txtSerie1.Text = Convert.ToString(datos["SERIE1"]);
                txtSerie2.Text = Convert.ToString(datos["SERIE2"]);
                cbIVA.Text = Convert.ToString(datos["IMPUESTO"]);
                cbIVA.Enabled = false;
                txtBaseImponible.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["SUBTOTAL"]));
                txtBaseImponible.Text = agregra0Decimal(txtBaseImponible.Text);
                txtICE.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["TOTALICE"]));
                txtICE.Text = agregra0Decimal(txtICE.Text);
                txtIRBP.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["TOTALIRBP"]));
                txtIRBP.Text = agregra0Decimal(txtIRBP.Text);
                txtSubtotalIVA.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["SUBTOTALIVA"]));
                txtSubtotalIVA.Text = agregra0Decimal(txtSubtotalIVA.Text);
                txtSubtotal0.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["SUBTOTAL0"]));
                txtSubtotal0.Text = agregra0Decimal(txtSubtotal0.Text);
                txtTotal.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["TOTAL"]));
                txtTotal.Text = agregra0Decimal(txtTotal.Text);
                txtIVA.Text = Funcion.reemplazarcaracter(Convert.ToString(datos["TOTALIVA"]));
                txtIVA.Text = agregra0Decimal(txtIVA.Text);
                datos = ObjConsul.obtenerDatos("select PROVEEDORRISE from TbProveedor where IDPROVEEDOR = " + CmbProveedor.SelectedValue + "");
                ckbRISE.Checked = Convert.ToBoolean(datos["PROVEEDORRISE"]);

                //objData = ObjConsul.BoolDataTable("select * from TbEncabezadoyPieCompra where IDEMCABEZADOCOMPRA = " + idEncabezadoOG + "");
                //txtNumero.Text = objData.["NUMERO"].ToString();
                DataTable datosRetencion = new DataTable();
                datosRetencion = ObjConsul.BoolDataTable("select * from VistaRetencion where IDPROVEEDOR = " + CmbProveedor.SelectedValue + "");
                //DataRow myRow = datosRetencion.Rows[0];
                for (int i = 0; i < datosRetencion.Rows.Count; i++)
                {
                    DataRow myRow = datosRetencion.Rows[i];
                    dgvDatosRetencion.Rows[i].Cells[0].Value = myRow["DESCRIPCION"];
                    dgvDatosRetencion.Rows[i].Cells[2].Value = myRow["RETENCION"];
                    if (myRow["CODIGO"].ToString() == "COD_RET_FUE")
                    {
                        dgvDatosRetencion.Rows[i].Cells[1].Value = "FUENTE";
                        dgvDatosRetencion.Rows[i].Cells[3].Value = txtBaseImponible.Text;
                    }
                    else
                    {
                        dgvDatosRetencion.Rows[i].Cells[1].Value = "IVA";
                        dgvDatosRetencion.Rows[i].Cells[3].Value = txtIVA.Text;
                    }
                    dgvDatosRetencion.Rows[i].Cells[4].Value = Funcion.reemplazarcaracter(((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvDatosRetencion.Rows[i].Cells[3].Value.ToString())) * Convert.ToSingle(dgvDatosRetencion.Rows[i].Cells[2].Value)) / 100).ToString());
                    dgvDatosRetencion.Rows[i].Cells[6].Value = Convert.ToDateTime(myRow["FECHAVALIDODESDE"]).ToShortDateString() + " - " + Convert.ToDateTime(myRow["FECHAVALIDOHASTA"]).ToShortDateString();
                    dgvDatosRetencion.Rows[i].Cells[7].Value = Convert.ToInt32(myRow["IDCODIGOSRI"]);
                    dgvDatosRetencion.Rows[i].Cells[8].Value = Convert.ToInt32(myRow["CODIGOSRI"]);
                    dgvDatosRetencion.Rows[i].Cells[9].Value = Convert.ToInt32(myRow["IDTIPOCODIGOSRI"]);
                }
                float sumaRetencion = 0.0f;
                for (int i = 0; i < dgvDatosRetencion.RowCount - 1; i++)
                {
                    sumaRetencion = sumaRetencion + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(Convert.ToString(dgvDatosRetencion.Rows[i].Cells[4].Value)));
                    if (Convert.ToString(dgvDatosRetencion.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
                float valorPagar = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotal.Text)) - sumaRetencion;
                txtValorPagar.Text = Funcion.reemplazarcaracter(valorPagar.ToString("##.0000"));
            }
            catch (Exception ex)
            {

            }
            
        }

        private void FrmOrdenDeGiro_Load(object sender, EventArgs e)
        {
            Program.FormularioOrdenGiro = true;
            for (int i = 1; i < 3; i++)
                dgvDatosLibroDiario.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            for (int i = 3; i < 5; i++)
                dgvDatosRetencion.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            inicializar();
            ObjConsul = new Clases.Consultas();
            ObjConsul.BoolLlenarComboBox(CmbProveedor, "Select IDPROVEEDOR AS ID , NOMBRES AS TEXTO from TbProveedor");
            // hacer aparecer un scrollBar, poniendo un limite de item que aparezcan
            CmbProveedor.DropDownHeight = CmbProveedor.ItemHeight = 100;
            ObjConsul.BoolLlenarComboBox(CmbTipoDocumento, "Select CODIGOSRI ID, NOMBREDOCUMENTO AS TEXTO from TbTipoDocumento");
            // hacer aparecer un scrollBar, poniendo un limite de item que aparezcan
            CmbTipoDocumento.DropDownHeight = CmbTipoDocumento.ItemHeight = 100;
            cbTipo.SelectedIndex = 0;
            cbAutorizacionSRI.SelectedIndex = 0;
            int idOrdenGiro = ObjConsul.ObtenerID("IDORDENGIRO", "TbEncabezadoOrdenGiro", "");
            int NordenGiro = 1 + ObjConsul.ObtenerID("NUMEROORDENGIRO", "TbEncabezadoOrdenGiro", " where IDORDENGIRO =" + idOrdenGiro + "");
            txtOrdenGiro.Text = NordenGiro.ToString();
            if (Program.FormularioLlamado)
            {
                int idEncabezadoOG = 0;
                if (FrmFacturaGastos.gasto)
                    idEncabezadoOG = FrmFacturaGastos.IDEncabezadoGasto;
                else
                    idEncabezadoOG = FrmCompra.IDEncabezadoCompraOG;
                //FrmCompra.IDEncabezadoCompraOG;
                ObjConsul.BoolLlenarComboBox(CmbProveedor, "Select P.IDPROVEEDOR as ID,  P.NOMBRES as Texto from TbProveedor P , TbEncabezadoyPieCompra E where E.IDPROVEEDOR = P.IDPROVEEDOR and E.IDEMCABEZADOCOMPRA = " + idEncabezadoOG + "");
                CmbProveedor.Enabled = false;
                ObjConsul.BoolLlenarComboBox(cbSustentoTributario, "Select C.IDCODIGOSRI as ID,  C.DESCRIPCION as Texto from TbProveedor P, TbCodigoSRI C  where  P.CREDITO = C.IDCODIGOSRI and  P.IDPROVEEDOR = " + CmbProveedor.SelectedValue + "");
                //cbSustentoTributario.Enabled = false;
                txtNumero.ReadOnly = true;
                txtSerie1.ReadOnly = true;
                txtSerie2.ReadOnly = true;
                llenarDatosOG(idEncabezadoOG);
                Program.FormularioLlamado = false;
            }
            else
            {
                inicializar();
                ObjConsul.BoolLlenarComboBox(cbSustentoTributario, "Select C.IDCODIGOSRI as ID,  C.DESCRIPCION as Texto from TbProveedor P, TbCodigoSRI C  where  P.CREDITO = C.IDCODIGOSRI and  P.IDPROVEEDOR = " + CmbProveedor.SelectedValue + "");
                cbSustentoTributario.Enabled = false;            
            }
           ObjConsul.seriesDocumentoRetencion(txtNumeroRetencion, txtSerie1Retencion, txtSerie2Retencion, txtAutorizacionRetencion, "RET", bitacora.LocalIPAddress());

            DataTable dt = ObjConsul.BoolDataTable("Select CONTRIBUYENTEESPECIAL, NUMERORESOLUCION from TbParametrosFactura;");
            //Verificar si tiene Datos
            if (dt.Rows.Count > 0)
            {
                DataRow myRow = dt.Rows[0];
                if (Convert.ToBoolean(myRow["CONTRIBUYENTEESPECIAL"]))
                {
                    parametrosFactu.Add(myRow["CONTRIBUYENTEESPECIAL"].ToString());
                    parametrosFactu.Add(myRow["NUMERORESOLUCION"].ToString());
                }
                else
                {
                    parametrosFactu.Add("No");
                    parametrosFactu.Add("No");
                }
            }
            rbActivos.Checked = true;

        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSerie1.Text != "" && txtSerie2.Text != "" && txtNumero.Text != "")
                {
                    string condicion = "where SERIE1 = " + Convert.ToInt32(txtSerie1.Text) + " AND SERIE2 = " + Convert.ToInt32(txtSerie2.Text) + " AND NUMERO = " + Convert.ToInt32(txtNumero.Text) + " AND IDPROVEEDOR = " + Convert.ToInt32(CmbProveedor.SelectedValue);
                    string valor = ObjConsul.ObtenerValorCampo("IDEMCABEZADOCOMPRA", "TbEncabezadoyPieCompra", condicion);
                    ObjConsul.BoolLlenarComboBox(cbSustentoTributario, "Select C.IDCODIGOSRI as ID,  C.DESCRIPCION as Texto from TbProveedor P, TbCodigoSRI C  where  P.CREDITO = C.IDCODIGOSRI and  P.IDPROVEEDOR = " + CmbProveedor.SelectedValue + "");
                    if (valor != "")
                    {
                        int IDEncabezadoCompraOG = Convert.ToInt32(valor);
                        llenarDatosOG(IDEncabezadoCompraOG);
                    }
                    else
                    {
                        //MessageBox.Show("No existe registro para este #factura del proveedor seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        inicializar();
                    }
                }
                
            }
            catch (Exception ex)
            {
            }
        }

        private void CmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            inicializar();
            ObjConsul.BoolLlenarComboBox(cbSustentoTributario, "Select C.IDCODIGOSRI as ID,  C.DESCRIPCION as Texto from TbProveedor P, TbCodigoSRI C  where  P.CREDITO = C.IDCODIGOSRI and  P.IDPROVEEDOR = " + CmbProveedor.SelectedValue + "");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void txtNAutorizacion_Enter(object sender, EventArgs e)
        {
            if (cbAutorizacionSRI.SelectedIndex == 0)
            {
                txtNAutorizacion.MaxLength = 49;
            }
            else if (cbAutorizacionSRI.SelectedIndex == 1)
            {
                txtNAutorizacion.MaxLength = 10;
            }
        }

        private void txtPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
            
        }

        private void txtPlazo_TextChanged(object sender, EventArgs e)
        {
           // txtPlazo.Text += "Días";
        }

        private void cbAutorizacionSRI_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNAutorizacion.Text = "";
        }

        private void txtValorPagar_TextChanged(object sender, EventArgs e)
        {
            float saldo = 0.0f;
            try
            {

                saldo = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotal.Text)) - Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtValorPagar.Text));
                if (saldo < 0)
                {
                    txtSaldo.Text = "";
                }
                else
                {
                    txtSaldo.Text = Funcion.reemplazarcaracter(saldo.ToString("0.0000"));
                }
            }
            catch (Exception)
            {
            }
            if (txtValorPagar.Text == "")
            {
                txtSaldo.Text = "";
            }
        }

        private void txtValorPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtValorPagar.Text);
        }

        private void btnContabilizar_Click(object sender, EventArgs e)
        {
            if(txtValorPagar.Text != "" && cbFormaPago.Text != "")
            {
                float sumaRetencion = 0.0f;
                for (int i = 0; i < dgvDatosRetencion.RowCount - 1; i++)
                {
                    sumaRetencion = sumaRetencion + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(Convert.ToString(dgvDatosRetencion.Rows[i].Cells[4].Value)));
                    if (Convert.ToString(dgvDatosRetencion.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
                float valorPagar = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotal.Text)) - sumaRetencion;
                txtValorPagar.Text = Funcion.reemplazarcaracter(valorPagar.ToString("##.0000"));
                dgvDatosLibroDiario.Rows.Clear();
                for (int i = 0; i < 5; i++)
                {
                    dgvDatosLibroDiario.Rows.Add();
                }
                //fila 0 para inventario 0%
                dgvDatosLibroDiario.Rows[0].Cells[2].Value = txtSubtotal0.Text;
                dgvDatosLibroDiario.Rows[0].Cells[0].Value = "101.03.03.01 - Inventario 0%";
                //fila 0 para inventario 12%
                dgvDatosLibroDiario.Rows[1].Cells[2].Value = txtSubtotalIVA.Text;
                dgvDatosLibroDiario.Rows[1].Cells[0].Value = "101.03.03.02 - Inventario 12%";
                //fila 0 para iva
                dgvDatosLibroDiario.Rows[2].Cells[2].Value = txtIVA.Text;
                dgvDatosLibroDiario.Rows[2].Cells[0].Value = "101.05.01.01 - IVA";
                //fila 0 para ice
                dgvDatosLibroDiario.Rows[3].Cells[2].Value = txtICE.Text;
                dgvDatosLibroDiario.Rows[3].Cells[0].Value = "ICE";
                //fila 0 para irbp
                dgvDatosLibroDiario.Rows[4].Cells[2].Value = txtIRBP.Text;
                dgvDatosLibroDiario.Rows[4].Cells[0].Value = "IRBP";
                int contadorFilaLibroDiario = 5;
                
                for (int i = 0; i < dgvDatosRetencion.RowCount - 1; i++)
                {
                    if (contadorFilaLibroDiario < dgvDatosLibroDiario.RowCount - 1)
                    {
                        dgvDatosLibroDiario.Rows[contadorFilaLibroDiario].Cells[3].Value = dgvDatosRetencion.Rows[i].Cells[4].Value;
                        string concepto = Convert.ToString(dgvDatosRetencion.Rows[i].Cells[0].Value) + "(" + Convert.ToString(dgvDatosRetencion.Rows[i].Cells[1].Value) + ")";
                        dgvDatosLibroDiario.Rows[contadorFilaLibroDiario].Cells[0].Value = concepto;
                        contadorFilaLibroDiario++;                        
                    }
                    else
                    {
                        dgvDatosLibroDiario.Rows.Add();
                        i--;
                        //contadorFilaLibroDiario--;
                    }
                    if (dgvDatosRetencion.Rows[i + 1].Cells[4].Value == null)
                    {
                        break;
                    }
                }
                dgvDatosLibroDiario.Rows.Add();
                dgvDatosLibroDiario.Rows[contadorFilaLibroDiario].Cells[3].Value = txtValorPagar.Text;
                if (txtPlazo.Text == "0")
                {
                    //dgvDatosLibroDiario.Rows.Add();
                    if (cbFormaPago.SelectedIndex == 0)
                    {
                        dgvDatosLibroDiario.Rows[contadorFilaLibroDiario].Cells[0].Value = "101.01.01 - CAJA";
                    }
                    else
                    {
                        dgvDatosLibroDiario.Rows[contadorFilaLibroDiario].Cells[0].Value = "101.01.02 - BANCO";
                    }                    
                }
                else
                {
                    dgvDatosLibroDiario.Rows[contadorFilaLibroDiario].Cells[0].Value = "CTA X PAGAR";
                }
                for (int i = 0; i < dgvDatosLibroDiario.RowCount - 1 ; i++)
                {
                    dgvDatosLibroDiario.Rows[i].Cells[4].Value = txtConcepto.Text;
                }
                quitarValores0DGVLD();
                calcularLibroDiario();
            }
            else
            {
                MessageBox.Show("Debe ingresar los datos necesarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void quitarValores0DGVLD()
        {
            int columna;
            for (int i = 0; i < dgvDatosLibroDiario.RowCount -1; i++)
            {
                if (Convert.ToString(dgvDatosLibroDiario.Rows[i].Cells[2].Value) != "")
                {
                    columna = 2;
                }
                else
                    columna = 3;
                if (Convert.ToString(dgvDatosLibroDiario.Rows[i].Cells[columna].Value) == "0.0000")
                {
                    //dgvDatosLibroDiario.Rows.Remove(dgvDatosLibroDiario.Rows[i]);
                    dgvDatosLibroDiario.Rows.RemoveAt(i);
                    i--;
                }
            }
        }
        public void calcularLibroDiario()
        {
            float sumaDebe = 0.0f, sumaHaber = 0.0f;
            for (int i = 0; i < dgvDatosLibroDiario.RowCount - 1; i++)
            {
                if (dgvDatosLibroDiario.Rows[i].Cells[2].Value != null)
                {
                    sumaDebe = sumaDebe + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvDatosLibroDiario.Rows[i].Cells[2].Value.ToString()));
                }
                else
                    sumaHaber = sumaHaber + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvDatosLibroDiario.Rows[i].Cells[3].Value.ToString()));
            }
            txtTotalDebe.Text = Funcion.reemplazarcaracter(Math.Round(sumaDebe,4).ToString());
            txtTotalHaber.Text = Funcion.reemplazarcaracter(Math.Round(sumaHaber,4).ToString());
        }
        string serie1 = "", serie2 = "", numeroDocumentoProveedor = "";
        DateTime fechaEmisionRetencion, fechaEmisionFActura;
        DataGridView dtpTemporalRetencion = new DataGridView();
        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (txtValorPagar.Text != "" && cbFormaPago.Text != "" && txtNAutorizacion.Text != "" && cbTipo.Text != "" && txtTotalDebe.Text != "" && txtTotalHaber.Text != "" )
            {
                string idEncabezado = ObjConsul.ObtenerValorCampo("IDEMCABEZADOCOMPRA", "TbEncabezadoyPieCompra", " WHERE SERIE1 ="+ txtSerie1.Text + " AND SERIE2 =" + txtSerie2.Text + " AND NUMERO = " + txtNumero.Text + "");
                EncabezadoOrdenGiro objEncabezadoOG = new EncabezadoOrdenGiro(Convert.ToInt32(txtOrdenGiro.Text), Convert.ToInt32(CmbTipoDocumento.SelectedValue), Convert.ToInt32(CmbProveedor.SelectedValue), cbTipo.Text, txtPlazo.Text,
                    txtConcepto.Text, txtNAutorizacion.Text, txtNumero.Text, Convert.ToInt32(txtSerie1.Text), Convert.ToInt32(txtSerie2.Text), ckbRISE.Checked, ckbDeclaraSRI.Checked, ckbManual.Checked,
                    dtpFechaDocumentacion.Value, dtpFechaContabilizacion.Value, dtpFechaOrdenGiro.Value, dtpFechaVigente.Value, Convert.ToInt32(idEncabezado), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtValorPagar.Text)),
                    Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtSaldo.Text)), dtpFechaRetencion.Value, dtpFechaVenceDocumento.Value, Convert.ToInt32(txtSerie1Retencion.Text), Convert.ToInt32(txtSerie2Retencion.Text),
                    Convert.ToInt32(txtNumeroRetencion.Text), txtAutorizacionRetencion.Text, Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalDebe.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalHaber.Text)), 
                    cbAutorizacionSRI.Text, cbFormaPago.Text, true);
                string resultado =  objEncabezadoOG.InsertarEncabezadoOrden(objEncabezadoOG);
                if (resultado == "Datos Guardados")
                {
                    numeroOrden = Convert.ToInt32(txtOrdenGiro.Text);
                    if (Convert.ToString(dgvDatosRetencion.Rows[0].Cells[0].Value) != "")
                    {
                        string valor = ObjConsul.ObtenerValorCampo("IDORDENGIRO", "TbEncabezadoOrdenGiro", " WHERE IDPROVEEDOR = "+ CmbProveedor.SelectedValue +" AND SERIE1PROVEEDOR = "+ Convert.ToInt32(txtSerie1.Text) + " AND SERIE2PROVEEDOR = "+ Convert.ToInt32(txtSerie2.Text) +" AND NUMERODOCUMENTOPROVEEDOR = "+ Convert.ToInt32(txtNumero.Text) + "");
                        if (valor != "")
                        {
                            int idEncabezadoOrdenGiro = Convert.ToInt32(valor);
                            for (int i = 0; i < dgvDatosRetencion.RowCount - 1; i++)
                            {
                                DetalleOrdenGiro objDetalleOG = new DetalleOrdenGiro(idEncabezadoOrdenGiro, Convert.ToInt32(dgvDatosRetencion.Rows[i].Cells[7].Value), 
                                    Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvDatosRetencion.Rows[i].Cells[4].Value.ToString())));
                                objDetalleOG.InsertarDetalledoOrden(objDetalleOG);
                                objEncabezadoOG.InsertarAutorizacionProveedor(txtSerie1.Text, txtSerie2.Text, txtNAutorizacion.Text, Convert.ToInt32(CmbProveedor.SelectedValue));
                                if (Convert.ToString(dgvDatosRetencion.Rows[i+1].Cells[0].Value) == "")
                                {
                                    break;
                                }
                            }
                            
                        }                        
                    }
                    //Fin Crear XML
                    serie1 = txtSerie1.Text;
                    serie2 = txtSerie2.Text;
                    numeroDocumentoProveedor = txtNumero.Text;
                    fechaEmisionRetencion = dtpFechaRetencion.Value;
                    fechaEmisionFActura = dtpFechaDocumentacion.Value;
                    dtpTemporalRetencion = new DataGridView();
                    for (int i = 0; i < dgvDatosRetencion.ColumnCount; i++)
                    {
                        dtpTemporalRetencion.Columns.Add("1","1");
                    }
                    for (int i = 0; i < dgvDatosRetencion.RowCount -1; i++)
                    {
                        dtpTemporalRetencion.Rows.Add();
                        for (int j = 0; j < dgvDatosRetencion.ColumnCount; j++)
                        {
                            dtpTemporalRetencion.Rows[i].Cells[j].Value = dgvDatosRetencion.Rows[i].Cells[j].Value;
                        }
                    }
                    
                    string numeroRetencion = (Convert.ToInt32(txtNumeroRetencion.Text) + 1).ToString("D9");                    
                    ObjConsul.EjecutarSQL("UPDATE [dbo].[TbCajasTalonario] SET [DOCUMENTOACTUAL] = '"+ numeroRetencion +"' WHERE SERIE1 = '"+ txtSerie1Retencion.Text + "' and SERIE2 = '" + txtSerie2Retencion.Text + "' and IPESTACION = '" + bitacora.LocalIPAddress() + "' and TIPODOCUMENTO = 'RET'");
                    MessageBox.Show("Registrado Correctamente ", "Exito", MessageBoxButtons.OK);
                    
                    

                    ObjConsul.seriesDocumentoRetencion(txtNumeroRetencion, txtSerie1Retencion, txtSerie2Retencion, txtAutorizacionRetencion, "RET", bitacora.LocalIPAddress());
                    txtOrdenGiro.Text = (Convert.ToInt32(ObjConsul.ObtenerID("NUMEROORDENGIRO", "TbEncabezadoOrdenGiro", "")) + 1).ToString();

                    CbTipoAutorizacionVariable = cbAutorizacionSRI.SelectedItem.ToString().ToUpper();
                    cmbAñoRetencionHechaVariable = dtpFechaRetencion.Value.Date.Year.ToString();
                    ProveedorVariable = CmbProveedor.SelectedValue.ToString();

                    //Crear XML
                    //imprimir();
                    //
                    CrearXMLRetencion();


                    

                    inicializar();
                }
                else if (resultado == "Error al Registrar")
                {
                    MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == "Existe") { MessageBox.Show("Ya Existe la orden de giro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void CrearXMLRetencion()
        {

            ///Crear el XML
            ////XmlRetencion xmlRetencion = new XmlRetencion();
            //InfoTributaria infotribu = new InfoTributaria(1, 1, Program.razonsocialempresa, Program.nombreempresa, Program.rucempresa, "07", txtSerie1.Text, txtSerie2.Text, txtNumero.Text, Program.direccionempresa);
            if (!Directory.Exists(PathLocal))
            {
                Directory.CreateDirectory(PathLocal);
            }
            string serie = txtSerie1Retencion.Text + txtSerie2Retencion.Text;
            //string fecha = DateTime.Now.Date.ToShortDateString();
            string fecha = dtpFechaRetencion.Value.Date.ToShortDateString();
            string hora = DateTime.Now.ToLongTimeString();

            //Si la fecha Obtenida no tienen los ceros en dias y meses

            fecha = Funcion.FormarFecha(fecha);


            XmlRetencion xmlRetencion = new XmlRetencion();
            ////var ruta = ConfigurationManager.AppSettings["XmlRetencion"];
            //xml._crearXml(PathLocal + @"\" + claveacceso + ".xml", "factura");

            string Tipocomprobante = CmbTipoDocumento.SelectedValue.ToString();
            switch (CmbTipoDocumento.SelectedValue.ToString())
            {
                case "1":
                    Tipocomprobante = "01";
                    break;
                case "3":
                    Tipocomprobante = "03";
                    break;
                case "4":
                    Tipocomprobante = "04";
                    break;
                case "5":
                    Tipocomprobante = "05";
                    break;
                default:
                    break;
            }

            
            string numeroRetencion = (Convert.ToInt32(txtNumeroRetencion.Text) - 1).ToString("D9");

            InfoTributaria infotribu = new InfoTributaria(Program.Ambiente, 1, Program.razonsocialempresa, Program.nombreempresa, Program.rucempresa, "07", txtSerie1Retencion.Text, txtSerie2Retencion.Text, numeroRetencion, Program.direccionempresa); // 07 porque es retencion
                                                                                                                                                                                                                        //string serie = txtSerie1.Text + txtSerie2.Text;
                                                                                                                                                                                                                        //xmlRetencion.InfoTributaria("infoTributaria", infotribu, serie,claveacceso);

            claveacceso = infotribu.GenerarClaveAcceso(fecha, "7", serie);
            xmlRetencion._crearXml(PathLocal + @"\" + claveacceso + ".xml", "comprobanteRetencion");
            var ruta = ConfigurationManager.AppSettings["XmlServidor"];
            xmlRetencion._crearXml(PathLocal + @"\" + claveacceso + ".xml", "comprobanteRetencion");
            string pathfinal = PathLocal + claveacceso + ".xml";

            imprimir();
            //imprimirRetencion();

            //InfoTributaria infotribu = new InfoTributaria(1, 1, Program.razonsocialempresa, Program.nombreempresa, Program.rucempresa, "07", txtSerie1.Text, txtSerie2.Text, txtNumero.Text, Program.direccionempresa);

            xmlRetencion.InfoTributaria("infoTributaria", infotribu, serie, claveacceso);



            DataTable dt = ObjConsul.BoolDataTable("Select TIPOIDENTIFICACION,IDENTIFICACION,RAZONSOCIAL,NOMBRES from TbProveedor where IDPROVEEDOR = " + CmbProveedor.SelectedValue + ";");
            DataRow myRow = dt.Rows[0];
            string periodoFiscal = dtpFechaContabilizacion.Value.Date.Month.ToString();



            if (myRow["RAZONSOCIAL"] != System.DBNull.Value)
            {
                myRow["RAZONSOCIAL"] = myRow["NOMBRES"];
            }
            periodoFiscal = periodoFiscal + "/" + dtpFechaContabilizacion.Value.Date.Year.ToString();
            periodoFiscal = Funcion.FormarFechaperiodoFiscal(periodoFiscal);
            string tipoidentificacion = "";
            if (myRow["TIPOIDENTIFICACION"].ToString() == "RUC")
                tipoidentificacion = "04";
            if (myRow["TIPOIDENTIFICACION"].ToString() == "CEDULA")
                tipoidentificacion = "05";
            if (myRow["TIPOIDENTIFICACION"].ToString() == "PASAPORTE")
                tipoidentificacion = "06";
            if (myRow["TIPOIDENTIFICACION"].ToString() == "VENTA A CONSUMIDOR FINAL")
                tipoidentificacion = "07";
            if (myRow["TIPOIDENTIFICACION"].ToString() == "IDENTIFICACION DELEXTERIOR")
                tipoidentificacion = "08";

            InfoCompRetencion infoCompReten = new InfoCompRetencion(fecha, Program.direccionempresa, parametrosFactu[1], Program.obligadoContabilidad, tipoidentificacion, myRow["RAZONSOCIAL"].ToString(), myRow["IDENTIFICACION"].ToString(), periodoFiscal);
            xmlRetencion.infoCompRetencion(infoCompReten);

            //xmlRetencion.impuestos(dgvDatosRetencion,txtSerie1.Text+txtSerie2.Text+ txtNumero.Text);

            string CodSustento = ObjConsul.ObtenerValorCampo("CODIGOSRI", "TbCodigoSRI", "where DESCRIPCION = '"+ cbSustentoTributario.Text + "'");

            xmlRetencion.impuestos(dgvDatosRetencion, txtSerie1.Text + txtSerie2.Text + txtNumero.Text, Funcion.FormarFecha(dtpFechaDocumentacion.Value.Date.ToShortDateString()), /*Convert.ToInt32(CmbTipoDocumento.SelectedValue)*/CodSustento);

            var PathServer = ConfigurationManager.AppSettings["XmlServidor"];
            if (!Directory.Exists(PathServer + @"\Generados\"))
            {
                Directory.CreateDirectory(PathServer + @"\Generados\");
            }

            if (!Directory.Exists(PathLocal))
            {
                Directory.CreateDirectory(PathLocal);
            }

            File.Copy(pathfinal, PathServer + @"\Generados\" + @"\" + @claveacceso + ".xml", true);


            //Insertar BDFactuElec

            ObjConsul.RegistrarArchivosXml(claveacceso, PathServer + @"\Generados", fecha, hora, "OrdenGiro");

            //Creamos el delegado 
            ThreadStart h1 = new ThreadStart(Procesar);
            //Creamos la instancia del hilo 
            Thread h2 = new Thread(h1);
            //Iniciamos el hilo 
            h2.Start();


            // Fin Insertar BDFactuElec


        }
        // DataTable DtDocuemtosXML;
        string fechaAutorizacion;
        String CbTipoAutorizacionVariable = "";
        String cmbAñoRetencionHechaVariable = "";
        String ProveedorVariable = "";
        private void Procesar()
        {
            try
            {
                string fecha = Funcion.FormarFecha(dtpFechaRetencion.Value.Date.ToShortDateString());
                DtDocuemtosXML = ObjConsul.BoolDataTableFactElect("Select * from TbDocumentosGeneradosRect DocRect where DocRect.FechaEmision = '" + fecha + "' and   DocRect.EstadoAutorizacion = '0' and DocRect.NombreXML='" + claveacceso+"'");
                int contadorAutorizado = 0, contadorEnviados = 0, contadorNoautorizados = 0, contadorDevuelta = 0, contadorRecibida = 0, contador = 0, estadoautorizacion = 0;
                string Recibida = "", AUT = "NO";
                if (DtDocuemtosXML.Rows.Count > 0)
                {
                    //btnEnviar.Enabled = false;
                    //lblTotalArchivos.Text = "Total de Archivos: " + DtDocuemtosXML.Rows.Count;
                    foreach (DataRow myRow in DtDocuemtosXML.Rows)
                    {
                        RutaXML = myRow["Ruta"].ToString();
                        NombreXML = myRow["NombreXML"].ToString();
                        FechaEmision = myRow["FechaEmision"].ToString();
                        contador++;
                        //Inicio menuInferior
                        //TollMenuLablelDocumento.Text = "Documento : " + NombreXML + ".xml";
                        //TollMenuLablelFecha.Text = "Fecha : " + Funcion.reemplazarcaracterFecha(Convert.ToDateTime(FechaEmision).Date.ToShortDateString());
                        //Fin menuInferior
                        //var PathServer = @"C:\ArchivosXml";
                        //var ruta = ConfigurationManager.AppSettings["XmlServidor"];
                        string RutaXML1 = ConfigurationManager.AppSettings["XmlServidor"];
                        string SRIRecepcion = ConfigurationManager.AppSettings["SRIRecepcion"];
                        string SRIAutorizacion = ConfigurationManager.AppSettings["SRIAutorizacion"];
                        //string pathXml = RutaXML1 + @"\sonna_judith_vega_solis.p12";
                        if (System.IO.File.Exists(RutaXML1 + @"\Generados" + @"\" + NombreXML + ".xml"))
                        {
                            //Firmar Documento
                            Firma.Firmalo(Program.RutaCertificado, Program.passwordCertificado, RutaXML1 + @"\Generados\" + NombreXML + ".xml", RutaXML1 + @"\Firmados\" + NombreXML + ".xml", RutaXML1);

                            SRIRecepcionComprobante sriRecepcion = new SRIRecepcionComprobante();
                            string respuestaRecepcion = sriRecepcion.RecepcionArchivos(RutaXML1 + @"\Firmados" + @"\" + NombreXML + ".xml", SRIRecepcion, NombreXML, RutaXML1);
                            //Fin RecepcionSRI

                            if (respuestaRecepcion == "RECIBIDA")
                            {
                                contadorRecibida++;
                                Recibida = "R";


                                SRIAutorizacionComprobante sriAutori = new SRIAutorizacionComprobante(SRIAutorizacion);
                                string estado = sriAutori.AutorizacionArchivos(NombreXML, RutaXML1, respuestaRecepcion);
                                string [] autorizado = estado.Split(';');
                                if (autorizado.Length > 1)
                                    fechaAutorizacion = autorizado[1];
                                if (autorizado[0] == "AUTORIZADO")
                                {
                                    contadorAutorizado++;
                                    estadoautorizacion = 1;
                                    AUT = "SI";
                                }
                                else
                                {
                                    contadorNoautorizados++;
                                    estadoautorizacion = 0;
                                    AUT = "NO";
                                }
                                contadorEnviados++;
                                

                                //Thread.Sleep(500);

                                string contadoraenviar = contador + " de " + DtDocuemtosXML.Rows.Count + " Archivos.";
                                CambiarProgreso(NombreXML, FechaEmision, contadorDevuelta.ToString(), contadorRecibida.ToString(), contadorAutorizado.ToString(), contadorNoautorizados.ToString(), contadorEnviados.ToString(), contadoraenviar, "" + DtDocuemtosXML.Rows.Count);


                            }
                            else
                            {
                                contadorDevuelta++;
                                Recibida = "D";
                            }

                            Consultas Objconsul = new Consultas();
                            Objconsul.EjecutarSQLFactElectronica("UPDATE [dbo].[TbDocumentosGeneradosRect] SET [EstadoAutorizacion] = '" + estadoautorizacion + "',[RecepcionSRI] ='" + Recibida + "',[AutorizadoSRI]='" + AUT + "'  WHERE  NombreXML = '" + NombreXML + "'");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningun archivo.");
                }

                //Thread.Sleep(1000);
                // MessageBox.Show("Proceso finalizado");
                //btnEnviar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en enviar al SRI: No responde\n Intentelo más tarde en el formulario Corregir Errores");
                //MessageBox.Show(ex.Message);
            }

        }

        private void CambiarProgreso(string nombreXml, string fecha, string contadorDevuelta, string contadorRecibida, string contadorautorizado, string contadornoautorizado, string contadorenviados, string contador, string archivosTotales)
        {
            if (this.InvokeRequired)
            {
                CambiarProgresoDelegado h1 = new CambiarProgresoDelegado(CambiarProgreso);
                object[] parametros = new object[] { nombreXml, fecha, contadorDevuelta, contadorRecibida, contadorautorizado, contadornoautorizado, contadorenviados, contador, archivosTotales };
                this.Invoke(h1, parametros);

            }
            else
            {
                //imprimirRetencion();
                if (fechaAutorizacion != null) //´solo se formara ride si la fecha de autorizacion esta, lo q significa si se autorizo o no
                {
                    //LLamar Reporte
                    string ambiente = "";
                    switch (Program.Ambiente)
                    {
                        case 1:
                            ambiente = "PRUEBA";
                            break;
                        case 2:
                            ambiente = "PRODUCCION";
                            break;
                        default:
                            break;
                    }
                    
                    string numeroRetencion2 = (Convert.ToInt32(txtOrdenGiro.Text) - 1).ToString();
                    ObjConsul.EjecutarSQL("UPDATE [dbo].[TbEncabezadoOrdenGiro] SET [AUTORIZACIONSRICLAVEACCESO] = '"+ claveacceso + "' ,[FECHAAUTORIZACIONSRI] = '"+ fechaAutorizacion + "'	WHERE NUMERORETECION =" + numeroRetencion2 + "; ");
                    ReporteRetencion objeformularioReporte = null;
                    objeformularioReporte = new ReporteRetencion(claveacceso, fechaAutorizacion, numeroRetencion2, ambiente, CbTipoAutorizacionVariable, cmbAñoRetencionHechaVariable);
                    objeformularioReporte.Show();
                    //Fin Llamar Reporte

                    //Eviar Correo
                    ObjConsul.enviarCorreoRideRetencion(numeroRetencion2, cmbAñoRetencionHechaVariable, claveacceso);
                    //Fin Eviar Correo
                }
            }
        }


        private void CmbProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if (txtNAutorizacion.Text.Length != 49)
                //{
                //    MessageBox.Show("La Autorización debe de tener exactamente 49 digitos", "Aviso", MessageBoxButtons.OK);
                //}
                //else
                //{
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                //}
            }
        }

        private void btnSalirCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            btnGuardarProveedor.Enabled = true;
            inicializar();
        }

        private void ImpresionOG_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //imprimirRetencion(e);
                e.Graphics.DrawString("Orden de Giro#:", new Font("Verdana", 14, FontStyle.Bold), Brushes.Black, 25, 25);
                e.Graphics.DrawString(numeroOrden.ToString(), new Font("Verdana", 14, FontStyle.Italic), Brushes.Black, 200, 25);
                e.Graphics.DrawString("Proveedor: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, 70);
                e.Graphics.DrawString(CmbProveedor.Text, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 175, 70);
                e.Graphics.DrawString("Tipo Documento: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, 90);
                e.Graphics.DrawString(CmbTipoDocumento.Text, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 175, 90);
                e.Graphics.DrawString("N° Factura: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, 110);
                string numeroFactura = txtSerie1.Text + '-' + txtSerie2.Text + '-' + txtNumero.Text;
                e.Graphics.DrawString(numeroFactura, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 175, 110);
                e.Graphics.DrawString("Autorizacion: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, 130);
                e.Graphics.DrawString(txtNAutorizacion.Text, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 175, 130);

                /////////////////////////
                e.Graphics.DrawString("Subtotal 12%: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, 150);
                e.Graphics.DrawString(txtSubtotalIVA.Text, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 175, 150);
                e.Graphics.DrawString("Subtotal 0%::", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, 170);
                e.Graphics.DrawString(txtSubtotal0.Text, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 175, 170);
                e.Graphics.DrawString("Subtotal: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, 190);
                e.Graphics.DrawString(txtBaseImponible.Text, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 175, 190);
                e.Graphics.DrawString("ICE: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, 210);
                e.Graphics.DrawString(txtICE.Text, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 175, 210);
                e.Graphics.DrawString("IVA: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, 230);
                e.Graphics.DrawString(txtIVA.Text, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 175, 230);
                e.Graphics.DrawString("IRBP: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, 250);
                e.Graphics.DrawString(txtIRBP.Text, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 175, 250);



                e.Graphics.DrawString("Usuario: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Gray, 675, 20);
                string usurio = ObjConsul.ObtenerValorCampo("USUARIO", "TbUsuario", "WHERE IDUSUARIO = " + Program.IDUsuarioMenu);
                e.Graphics.DrawString(usurio, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 750, 20);
                e.Graphics.DrawString(Convert.ToString(DateTime.Now), new Font("Verdana", 8, FontStyle.Regular), Brushes.Gray, 675, 35);
                e.Graphics.DrawString("Fecha Factura:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 500, 70);
                e.Graphics.DrawString(Convert.ToString(dtpFechaDocumentacion.Value), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 675, 70);
                e.Graphics.DrawString("Fecha Contabilización:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 500, 90);
                e.Graphics.DrawString(Convert.ToString(dtpFechaContabilizacion.Value), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 675, 90);
                e.Graphics.DrawString("Fecha Vencimiento:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 500, 110);
                e.Graphics.DrawString(Convert.ToString(dtpFechaVenceDocumento.Value), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 675, 110);
                

                //DGV Retencion

                e.Graphics.DrawString("N° Retención: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, 285);
                string numeroRetencion = (Convert.ToInt32(txtNumeroRetencion.Text) - 1).ToString("D9");
                string retencion = txtSerie1Retencion.Text + '-' + txtSerie2Retencion.Text + '-' + numeroRetencion;
                e.Graphics.DrawString(retencion, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 175, 285);
                e.Graphics.DrawString("Clave de Acceso: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, 295);
                e.Graphics.DrawString(claveacceso, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 175, 295);
                int y = 275;
                dibujarRayas(ref y, 40, 2);
                e.Graphics.DrawLine(blackPen, puntoInicio, puntoFinal);

                e.Graphics.DrawString("Año Fiscal", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 50, y + 2);
                e.Graphics.DrawString("Codigo", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 200, y + 2);
                e.Graphics.DrawString("Tipo", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 300, y + 2);
                e.Graphics.DrawString("%", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 375, y + 2);
                e.Graphics.DrawString("Base", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 450, y + 2);
                e.Graphics.DrawString("Monto", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 650, y + 2);

                dibujarRayas(ref y, 20, 2);
                e.Graphics.DrawLine(blackPen, puntoInicio, puntoFinal);
                y = y + 5;
                double sumaRetencion = 0.0f;
                for (int i = 0; i < dgvDatosRetencion.RowCount - 1; i++)
                {
                    DateTime fechaactual = DateTime.Today;
                    e.Graphics.DrawString(Convert.ToString(fechaactual.Year), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 65, y + 2);
                    e.Graphics.DrawString(Convert.ToString(dgvDatosRetencion.Rows[i].Cells[8].Value), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 210, y + 2);
                    if (Convert.ToString(dgvDatosRetencion.Rows[i].Cells[1].Value) == "FUENTE")
                        e.Graphics.DrawString("RTF", new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 300, y + 2);
                    else
                        e.Graphics.DrawString("IVA", new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 300, y + 2);
                    e.Graphics.DrawString(Convert.ToString(dgvDatosRetencion.Rows[i].Cells[2].Value) + "%", new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 375, y + 2);

                    double baseIm = Math.Round(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(Convert.ToString(dgvDatosRetencion.Rows[i].Cells[3].Value))), 2);
                    e.Graphics.DrawString(Funcion.reemplazarcaracter(Convert.ToString(baseIm)), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 450, y + 2);
                    double retenido = Math.Round(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(Convert.ToString(dgvDatosRetencion.Rows[i].Cells[4].Value))), 2);
                    e.Graphics.DrawString(Funcion.reemplazarcaracter(Convert.ToString(retenido)), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 650, y + 2);
                    y = y + 22;
                    double totalRetenido = Math.Round(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(Convert.ToString(dgvDatosRetencion.Rows[i].Cells[4].Value))), 2);
                    sumaRetencion = Math.Round((sumaRetencion + Convert.ToSingle(totalRetenido)), 2);
                    if (Convert.ToString(dgvDatosRetencion.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
                e.Graphics.DrawString("Retención:", new Font("Verdana", 9, FontStyle.Bold), Brushes.Black, 550, y);
                e.Graphics.DrawString(Funcion.reemplazarcaracter(Convert.ToString(sumaRetencion)), new Font("Verdana", 9, FontStyle.Regular), Brushes.Black, 650, y);

                e.Graphics.DrawString("Total a Pagar:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 500, 150);
                e.Graphics.DrawString(Funcion.reemplazarcaracter(Convert.ToString(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotal.Text)) - Convert.ToSingle(sumaRetencion))), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 675, 150);


                e.Graphics.DrawString("Firma:", new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, 500, y + 75);

            }
            catch (Exception)
            {
            }
        }

        private void imprimir()
        {
            ElegirImpresero.AllowSomePages = true;
            ElegirImpresero.ShowHelp = true;
            ElegirImpresero.Document = ImpresionOG;
            DialogResult result = ElegirImpresero.ShowDialog();
            if (result == DialogResult.OK)
            {
                ImpresionOG.Print();
            }
        }
        private void imprimirRetencion()
        {
            ImprimirRetencionRide.AllowSomePages = true;
            ImprimirRetencionRide.ShowHelp = true;
            ImprimirRetencionRide.Document = ImpresionOG;
            DialogResult result = ImprimirRetencionRide.ShowDialog();
            if (result == DialogResult.OK)
            {
                ImpresionRide.Print();
            }
        }
        Pen blackPen;
        Point puntoInicio;
        Point puntoFinal;
        public void dibujarRayas(ref int y, int sumar, int grosor)
        {
            blackPen = new Pen(Color.Black, grosor);
            puntoInicio = new Point(25, y = y + sumar);
            puntoFinal = new Point(800, y);
        }
        string cadenaGeneral = "select NUMEROORDENGIRO, NOMBREDOCUMENTO, FECHAORDENGIRO, SERIE1PROVEEDOR, SERIE2PROVEEDOR, NUMERODOCUMENTOPROVEEDOR, FECHADOCUMENTO, NOMBRES, SUBTOTALIVA, SUBTOTAL0, SUBTOTAL, IDORDENGIRO from Vista_InformeOG";
        //string cadenaGeneral = "select NUMEROORDENGIRO, NOMBREDOCUMENTO, FECHAORDENGIRO, SERIE1PROVEEDOR, SERIE2PROVEEDOR, NUMERODOCUMENTOPROVEEDOR, FECHADOCUMENTO, NOMBRES, SUBTOTALIVA, SUBTOTAL0, SUBTOTAL, IDORDENGIRO,SERIE1RETENCION,SERIE2RETENCION,NUMERORETECION from Vista_InformeOG";
        private void btnConsultar_Click(object sender, EventArgs e)
        {            
            consultaOG();
            for (int i = 0; i < dgvDatosOG.RowCount - 1; i++)
            {
                if (Convert.ToString(dgvDatosOG.Rows[i].Cells[0].Value) != "")
                {
                    for (int j = 6; j < 9; j++)
                        dgvDatosOG.Rows[i].Cells[j].Value = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvDatosOG.Rows[i].Cells[j].Value.ToString())), 2).ToString());
                    if (Convert.ToString(dgvDatosOG.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
        }
        public void consultaOG()
        {
            if (rbActivos.Checked)
                radioB = true;
            else if (rbAnulados.Checked)
                radioB = false;
            string sql = cadenaGeneral + " where (CONVERT(VARCHAR(10),FECHAORDENGIRO, 120) between '" + Funcion.reemplazarcaracterFecha(Convert.ToString(dtpDesde.Value.ToShortDateString())) + "' AND '" + Funcion.reemplazarcaracterFecha(Convert.ToString(dtpHasta.Value.ToShortDateString())) + "') and (NOMBRES like '%"+ txtConsultar.Text +"%') and ESTADO = " + Convert.ToInt32(radioB) ;
            DataGridView dgvAux = new DataGridView();
            for (int i = 0; i < 12; i++)
            {
                dgvAux.Columns.Add("1", "1");
            }
            ObjConsul.boolLlenarDataGrid(dgvAux, sql, 25, 11, 0);
            dgvDatosOG.Rows.Clear();
            for (int i = 0; i < 25; i++)
            {
                dgvDatosOG.Rows.Add();
            }
            if (Convert.ToString(dgvAux.Rows[0].Cells[0].Value) != "")
            {
                for (int i = 0; i < dgvAux.RowCount - 1; i++)
                {
                    if (i == Convert.ToInt32(dgvDatosOG.RowCount - 1))
                        dgvDatosOG.Rows.Add(1);
                    int columnas = 0;
                    for (int j = 0; j < dgvDatosOG.ColumnCount; j++)
                    {
                        if (columnas > 2 && columnas < 6)
                        {
                            int s1 = Convert.ToInt32(dgvAux.Rows[i].Cells[columnas].Value);
                            columnas++;
                            int s2 = Convert.ToInt32(dgvAux.Rows[i].Cells[columnas].Value);
                            columnas++;
                            int np = Convert.ToInt32(dgvAux.Rows[i].Cells[columnas].Value);
                            dgvDatosOG.Rows[i].Cells[j].Value = s1.ToString("D3") + s2.ToString("D3") + np.ToString("D9");
                        }
                        else
                            dgvDatosOG.Rows[i].Cells[j].Value = Convert.ToString(dgvAux.Rows[i].Cells[columnas].Value);
                        columnas++;
                    }
                    if (Convert.ToString(dgvAux.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
                if (Convert.ToString(dgvDatosOG.Rows[0].Cells[0].Value) != "")
                {
                    btnVer.Enabled = true;
                    btnAnular.Enabled = true;
                }
                else
                {
                    btnVer.Enabled = false;
                    btnAnular.Enabled = false;
                }
                for (int i = 6; i < 9; i++)
                    dgvDatosOG.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                for (int i = 0; i < 6; i++)
                    dgvDatosOG.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                for (int i = 0; i < dgvDatosOG.RowCount - 1; i++)
                {
                    if (Convert.ToString(dgvDatosOG.Rows[i].Cells[0].Value) != "")
                    {
                        for (int j = 6; j < 9; j++)
                            dgvDatosOG.Rows[i].Cells[j].Value = Funcion.reemplazarcaracter(dgvDatosOG.Rows[i].Cells[j].Value.ToString());
                        if (Convert.ToString(dgvDatosOG.Rows[i + 1].Cells[0].Value) == "")
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                for (int i = 0; i < dgvDatosOG.RowCount - 1; i++)
                {
                    dgvDatosOG.Rows[i].Cells[2].Value = Convert.ToDateTime(dgvDatosOG.Rows[i].Cells[2].Value).ToShortDateString();
                    dgvDatosOG.Rows[i].Cells[4].Value = Convert.ToDateTime(dgvDatosOG.Rows[i].Cells[4].Value).ToShortDateString();
                    if (Convert.ToString(dgvAux.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
            dgvDatosOG.Focus();
        }

        private void dgvDatosOG_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToString(dgvDatosOG.CurrentRow.Cells[0].Value) != "")
            {
                btnVer.Enabled = true;
                btnAnular.Enabled = true;
            }
            else
            {
                btnVer.Enabled = false;
                btnAnular.Enabled = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            numeroOrden = Convert.ToInt32(txtOrdenGiro.Text);
            imprimir();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sqlAnular = "";
            
            if (rbActivos.Checked)
            {
                sqlAnular = "UPDATE[dbo].[TbEncabezadoOrdenGiro] SET[ESTADO] = 0 WHERE IDORDENGIRO = " + Convert.ToInt32(dgvDatosOG.CurrentRow.Cells[9].Value);
            }
            else if (rbAnulados.Checked)
            {
                sqlAnular = "UPDATE[dbo].[TbEncabezadoOrdenGiro] SET[ESTADO] = 1 WHERE IDORDENGIRO = " + Convert.ToInt32(dgvDatosOG.CurrentRow.Cells[9].Value);
            }
            if (!ObjConsul.EjecutarSQL(sqlAnular))
            {
                //btnConsultar_Click(null, null);
                //MessageBox.Show("Anulado Correctamente ", "Exito", MessageBoxButtons.OK);
                MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //else
            //{
            //    MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            ///Inicio Dar de Baja Factura Electrinonica
            ///

            string fechaordengiro = Funcion.reemplazarcaracterFecha(dgvDatosOG.CurrentRow.Cells[2].Value.ToString());
            string numerodocumento = Convert.ToString(dgvDatosOG.CurrentRow.Cells[3].Value);

            string serie1 = numerodocumento.Substring(0, 3);
            string serie2 = numerodocumento.Substring(3, 3);
            string serie3Secuencial = numerodocumento.Substring(6, 9);

            DataTable dt = ObjConsul.BoolDataTable("Select SERIE1RETENCION,SERIE2RETENCION,NUMERORETECION from Vista_InformeOG where (CONVERT(VARCHAR(10),FECHAORDENGIRO, 120)) = '"
                + fechaordengiro + "' and SERIE1PROVEEDOR = "+ Convert.ToInt32(serie1) + " and  SERIE2PROVEEDOR = "+ Convert.ToInt32(serie2) + " and  NUMERODOCUMENTOPROVEEDOR= '"+ serie3Secuencial + "' ");

            if (dt.Rows.Count > 0)
            {
                DataRow drFila = dt.Rows[0];
                serie1 = Convert.ToInt32(drFila["SERIE1RETENCION"]).ToString("D3");
                serie2 = Convert.ToInt32(drFila["SERIE2RETENCION"]).ToString("D3");
                serie3Secuencial = Convert.ToInt32(drFila["NUMERORETECION"]).ToString("D9");
                String parametroParteClaveAcceso = serie1 + serie2 + serie3Secuencial;  

                if (Program.BoolAutorizadoImprimir)
                {
                    string sqlEstadoDeBaja = "";
                    if (rbActivos.Checked)
                    {
                        sqlEstadoDeBaja = "Update TbDocumentosGeneradosRect SET EstadodeBaja = '1' where NombreXML like '%"+ parametroParteClaveAcceso + "%' and FechaEmision = '"+ fechaordengiro + "'";
                    }
                    else if (rbAnulados.Checked)
                    {
                        sqlEstadoDeBaja = "Update TbDocumentosGeneradosRect SET EstadodeBaja = '0' where NombreXML like '%"+ parametroParteClaveAcceso + "%' and FechaEmision = '"+ fechaordengiro + "'";
                    }
                    if (!ObjConsul.EjecutarSQLFactElectronica(sqlEstadoDeBaja))
                    {
                        //btnConsultar_Click(null, null);
                        //MessageBox.Show("Anulado Correctamente ", "Exito", MessageBoxButtons.OK);
                        MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //else
                    //{
                    //    MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                }
            }
            ///Fin Dar de Baja Factura Electrinonica
            btnConsultar_Click(null, null);

        }

        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActivos.Checked)
                btnAnular.Text = "Anular";
            else if (rbAnulados.Checked)
                btnAnular.Text = "Activar";
        }

        private void dgvDatosOG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            ver = true;
            string ecanbezadoOG = "SELECT        dbo.TbEncabezadoOrdenGiro.IDORDENGIRO, dbo.TbTipoDocumento.NOMBREDOCUMENTO, dbo.TbEncabezadoOrdenGiro.TIPO, dbo.TbEncabezadoOrdenGiro.PLAZO, dbo.TbEncabezadoOrdenGiro.CONCEPTO, " +
                         "dbo.TbEncabezadoOrdenGiro.AUTORIZACIONPROVEEDOR, dbo.TbEncabezadoOrdenGiro.NUMERODOCUMENTOPROVEEDOR, dbo.TbEncabezadoOrdenGiro.SERIE1PROVEEDOR, " +
                         "dbo.TbEncabezadoOrdenGiro.SERIE2PROVEEDOR, dbo.TbEncabezadoOrdenGiro.RISE, dbo.TbEncabezadoOrdenGiro.DECLARASRI, dbo.TbEncabezadoOrdenGiro.RETENCIONMANUAL, " +
                         "dbo.TbEncabezadoOrdenGiro.FECHADOCUMENTO, dbo.TbEncabezadoOrdenGiro.FECHACONTABILIZACION, dbo.TbEncabezadoOrdenGiro.FECHAORDENGIRO, dbo.TbEncabezadoOrdenGiro.FECHAVIGENTE, " +
                         "dbo.TbEncabezadoOrdenGiro.VALORAPAGAR, dbo.TbEncabezadoOrdenGiro.FECHARETENCION, dbo.TbEncabezadoOrdenGiro.FECHAVENCEDOCUMENTO, dbo.TbEncabezadoOrdenGiro.SALDO, " +
                         "dbo.TbEncabezadoOrdenGiro.SERIE1RETENCION, dbo.TbEncabezadoOrdenGiro.SERIE2RETENCION, dbo.TbEncabezadoOrdenGiro.NUMERORETECION, dbo.TbEncabezadoOrdenGiro.AUTORIZACIONRETECION, " +
                         "dbo.TbEncabezadoOrdenGiro.TOTALDEBE, dbo.TbEncabezadoOrdenGiro.TOTALHABER, dbo.TbProveedor.NOMBRES, dbo.TbCodigoSRI.DESCRIPCION, dbo.TbEncabezadoOrdenGiro.FORMAPAGO, dbo.TbEncabezadoOrdenGiro.TIPOAUTORIZACION " +
                         "FROM            dbo.TbEncabezadoOrdenGiro INNER JOIN " +
                         "dbo.TbProveedor ON dbo.TbEncabezadoOrdenGiro.IDPROVEEDOR = dbo.TbProveedor.IDPROVEEDOR INNER JOIN " +
                         "dbo.TbTipoDocumento ON dbo.TbEncabezadoOrdenGiro.IDTIPODOCUMENTO = dbo.TbTipoDocumento.IDTIPODOCUMENTO CROSS JOIN " +
                         "dbo.TbCodigoSRI WHERE        (dbo.TbEncabezadoOrdenGiro.IDORDENGIRO = "+Convert.ToInt32(dgvDatosOG.CurrentRow.Cells[9].Value)+")and dbo.TbProveedor.CREDITO = dbo.TbCodigoSRI.IDCODIGOSRI";
            DataTable dtOG = ObjConsul.BoolDataTable(ecanbezadoOG);
            if (dtOG.Rows.Count > 0)
            {
                DataRow drFila = dtOG.Rows[0];                
                txtOrdenGiro.Text = drFila[0].ToString();
                CmbTipoDocumento.Text = drFila[1].ToString();
                cbTipo.Text = drFila[2].ToString();
                txtPlazo.Text = drFila[3].ToString();
                txtConcepto.Text = drFila[4].ToString();                
                CmbProveedor.Text = drFila[26].ToString();
                txtSerie1.Text = Convert.ToInt32(drFila[7]).ToString("D3");
                txtSerie2.Text = Convert.ToInt32(drFila[8]).ToString("D3");
                txtNumero.Text = Convert.ToInt32(drFila[6]).ToString("D9");          
                txtNumero.Focus();                
                ckbRISE.Checked = Convert.ToBoolean(drFila[9]);
                ckbDeclaraSRI.Checked = Convert.ToBoolean(drFila[10]);
                ckbManual.Checked = Convert.ToBoolean(drFila[11]);
                dtpFechaDocumentacion.Value = Convert.ToDateTime(drFila[12]);
                dtpFechaContabilizacion.Value = Convert.ToDateTime(drFila[13]);
                dtpFechaOrdenGiro.Value = Convert.ToDateTime(drFila[14]);
                dtpFechaVigente.Value = Convert.ToDateTime(drFila[15]);
                //txtValorPagar.Text = drFila[16].ToString();
                dtpFechaRetencion.Value = Convert.ToDateTime(drFila[17]);
                dtpFechaVenceDocumento.Value = Convert.ToDateTime(drFila[18]);
                //txtSaldo.Text = drFila[19].ToString();
                txtSerie1Retencion.Text = Convert.ToInt32(drFila[20]).ToString("D3");
                txtSerie2Retencion.Text = Convert.ToInt32(drFila[21]).ToString("D3");
                txtNumeroRetencion.Text = Convert.ToInt32(drFila[22]).ToString("D9");
                txtAutorizacionRetencion.Text = drFila[23].ToString();
                //txtTotalDebe.Text = drFila[24].ToString();
                //txtTotalHaber.Text = drFila[25].ToString();                
                cbSustentoTributario.Text = drFila[27].ToString();
                if (Convert.ToString(drFila[28]) == "")
                {
                    cbFormaPago.SelectedIndex = 0;
                }
                else
                    cbFormaPago.Text = drFila[28].ToString();
                if (Convert.ToString(drFila[29]) != "Normal" && Convert.ToString(drFila[29]) != "Electrónica")
                    cbAutorizacionSRI.Text = "Normal";
                else
                    cbAutorizacionSRI.Text = drFila[29].ToString();
                txtNAutorizacion.Text = drFila[5].ToString();
                txtConcepto.Focus();
                btnImprimir.Visible = true;
                btnGuardarProveedor.Enabled = false;
            }
            //cbFormaPago.SelectedIndex = 0;
            btnContabilizar_Click(null, null);

            txtOrdenGiro.Enabled = false;
            CmbTipoDocumento.Enabled = false;
            cbTipo.Enabled = false;
            txtPlazo.Enabled = false;
            txtConcepto.Enabled = false;
            txtNAutorizacion.Enabled = false;
            txtNumero.Enabled = false;
            txtSerie1.Enabled = false;
            txtSerie2.Enabled = false;
            ckbRISE.Enabled = false;
            ckbDeclaraSRI.Enabled = false;
            ckbManual.Enabled = false;
            dtpFechaDocumentacion.Enabled = false;
            dtpFechaOrdenGiro.Enabled = false;
            dtpFechaVigente.Enabled = false;
            dtpFechaRetencion.Enabled = false;
            dtpFechaVenceDocumento.Enabled = false;
            txtSerie1Retencion.Enabled = false;
            txtSerie2Retencion.Enabled = false;
            txtNumeroRetencion.Enabled = false;
            txtAutorizacionRetencion.Enabled = false;
            CmbProveedor.Enabled = false;
            cbSustentoTributario.Enabled = false;
            dtpFechaContabilizacion.Enabled = false;
            cbFormaPago.Enabled = false;
            cbAutorizacionSRI.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.Date.ToShortDateString();
            string fechaActual = Funcion.FormarFecha(fecha);

        }

        private void ImpresionRide_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                DataTable dtEmpresa = ObjConsul.BoolDataTable("select e.NOMBRECOMERCIAL, e.RAZONSOCIAL, e.RUC, e.DIRECCION as DEmpresa, e.CELULAR1  from TbEmpresa e where e.IDEMPRESA = 1");
                DataRow rowEmpresa = null;
                if (dtEmpresa.Rows.Count > 0)
                {
                    rowEmpresa = dtEmpresa.Rows[0];
                    int y = 25;
                    e.Graphics.DrawString(rowEmpresa[0].ToString(), new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, 300, y);
                    e.Graphics.DrawString(rowEmpresa[1].ToString(), new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, 275, y = y + 25);
                    e.Graphics.DrawString("R.U.C " + rowEmpresa[2].ToString(), new Font("Verdana", 11, FontStyle.Bold), Brushes.Black, 310, y = y + 25);
                    e.Graphics.DrawString("MATRIZ: " + rowEmpresa[3].ToString(), new Font("Verdana", 10, FontStyle.Regular), Brushes.Black, 250, y = y + 20);
                    e.Graphics.DrawString("Teléfono: " + rowEmpresa[4].ToString() + "/ El Empalme - Guayas - Ecuador", new Font("Verdana", 10, FontStyle.Italic), Brushes.Black, 240, y = y + 20);
                    int encabezadoRetencion = y + 40;
                    e.Graphics.DrawString("CLAVE DE ACCESO: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, y = y + 40);
                    e.Graphics.DrawString(claveacceso, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 150, y);
                    e.Graphics.DrawString("AUTORIZACIÓN: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, y = y + 25);
                    e.Graphics.DrawString(claveacceso, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 150, y);
                    e.Graphics.DrawString("FECHA Y HORA DE ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, y = y + 25);
                    e.Graphics.DrawString("AUTORIZACIÓN: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 25, y = y + 25);
                    e.Graphics.DrawString(fechaAutorizacion, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 150, y);


                    e.Graphics.DrawString("OBLIGADO A LLEVAR CONTABILIDAD", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 550, encabezadoRetencion);


                    Pen blackPenC = new Pen(Color.Black, 1);
                    Point puntoInicioC = new Point(545, encabezadoRetencion + 23);
                    Point puntoFinalC = new Point(800, encabezadoRetencion + 23);
                    e.Graphics.DrawLine(blackPenC, puntoInicioC, puntoFinalC);
                    for (int i = 0; i < 70; i += 10)
                    {
                        e.Graphics.DrawString("|", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 540, encabezadoRetencion + 21 + i);
                        e.Graphics.DrawString("|", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 795, encabezadoRetencion + 21 + i);
                    }
                    e.Graphics.DrawString("COMPROBANTE RETENCIÓN", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 575, encabezadoRetencion = encabezadoRetencion + 25);
                    string numeroRetencion = (Convert.ToInt32(txtNumeroRetencion.Text) - 1).ToString("D9");
                    e.Graphics.DrawString("N° " + txtSerie1Retencion.Text + "-" + txtSerie2Retencion.Text + "-" + numeroRetencion, new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 580, encabezadoRetencion = encabezadoRetencion + 25);
                    e.Graphics.DrawString("Fecha de Emisión: ", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 545, encabezadoRetencion = encabezadoRetencion + 25);
                    e.Graphics.DrawString(Convert.ToString(fechaEmisionRetencion.ToShortDateString()), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 660, encabezadoRetencion);
                    puntoInicioC = new Point(545, encabezadoRetencion + 20);
                    puntoFinalC = new Point(800, encabezadoRetencion + 20);
                    e.Graphics.DrawLine(blackPenC, puntoInicioC, puntoFinalC);

                    y = encabezadoRetencion;
                    dibujarRayas(ref y, 25, 3);
                    e.Graphics.DrawLine(blackPen, puntoInicio, puntoFinal);
                    DataTable dtProveedor = ObjConsul.BoolDataTable("select NOMBRES, IDENTIFICACION, DIRECCION from TbProveedor where IDPROVEEDOR = " + CmbProveedor.SelectedValue);
                    DataRow rowProveedor = null;
                    if (dtProveedor.Rows.Count > 0)
                    {
                        rowProveedor = dtProveedor.Rows[0];
                        e.Graphics.DrawString("SR.(ES): ", new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, 25, y = y + 25);
                        e.Graphics.DrawString(rowProveedor[0].ToString(), new Font("Verdana", 10, FontStyle.Regular), Brushes.Black, 150, y);
                        e.Graphics.DrawString("RUC: ", new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, 25, y = y + 25);
                        e.Graphics.DrawString(rowProveedor[1].ToString(), new Font("Verdana", 10, FontStyle.Regular), Brushes.Black, 150, y);
                        e.Graphics.DrawString("DIRECCIÓN: ", new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, 25, y = y + 25);
                        e.Graphics.DrawString(rowProveedor[2].ToString(), new Font("Verdana", 10, FontStyle.Regular), Brushes.Black, 150, y);

                        e.Graphics.DrawString("FECHA DE EMISIÓN: ", new Font("Verdana", 9, FontStyle.Bold), Brushes.Black, 500, y = y - 50);
                        e.Graphics.DrawString(Convert.ToString(fechaEmisionFActura.ToShortDateString()), new Font("Verdana", 9, FontStyle.Regular), Brushes.Black, 650, y);
                        e.Graphics.DrawString("COMPROBANTE: ", new Font("Verdana", 9, FontStyle.Bold), Brushes.Black, 500, y = y + 25);
                        e.Graphics.DrawString(CmbTipoDocumento.Text, new Font("Verdana", 9, FontStyle.Regular), Brushes.Black, 650, y);
                        e.Graphics.DrawString("N° COMPROBANTE: ", new Font("Verdana", 9, FontStyle.Bold), Brushes.Black, 500, y = y + 25);
                        e.Graphics.DrawString(serie1 + "-" + serie2 + "-" + numeroDocumentoProveedor, new Font("Verdana", 9, FontStyle.Regular), Brushes.Black, 650, y);
                    }

                    //DGV Retencion

                    dibujarRayas(ref y, 40, 2);
                    e.Graphics.DrawLine(blackPen, puntoInicio, puntoFinal);

                    e.Graphics.DrawString("Año Fiscal", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 50, y + 2);
                    e.Graphics.DrawString("Código", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 150, y + 2);
                    e.Graphics.DrawString("Impuesto", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 225, y + 2);
                    e.Graphics.DrawString("% de Retención", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 325, y + 2);
                    e.Graphics.DrawString("Base Imponible", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 500, y + 2);
                    e.Graphics.DrawString("para la Retención", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 495, y + 15);

                    e.Graphics.DrawString("Valor Retenido", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 675, y + 2);

                    dibujarRayas(ref y, 33, 2);
                    e.Graphics.DrawLine(blackPen, puntoInicio, puntoFinal);
                    y = y + 5;
                    float sumaRetencion = 0.0f;
                    for (int i = 0; i < dtpTemporalRetencion.RowCount - 1; i++)
                    {
                        DateTime fechaactual = DateTime.Today;
                        e.Graphics.DrawString(Convert.ToString(fechaactual.Year), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 75, y + 2);
                        e.Graphics.DrawString(Convert.ToString(dtpTemporalRetencion.Rows[i].Cells[8].Value), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 150, y + 2);
                        e.Graphics.DrawString(Convert.ToString(dtpTemporalRetencion.Rows[i].Cells[1].Value), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 225, y + 2);
                        e.Graphics.DrawString(Convert.ToString(dtpTemporalRetencion.Rows[i].Cells[2].Value) + "%", new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 400, y + 2);
                        double baseIm = Math.Round(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(Convert.ToString(dtpTemporalRetencion.Rows[i].Cells[3].Value))), 2);
                        e.Graphics.DrawString(Funcion.reemplazarcaracter(Convert.ToString(baseIm)), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 575, y + 2);
                        double retenido = Math.Round(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(Convert.ToString(dtpTemporalRetencion.Rows[i].Cells[4].Value))), 2);
                        e.Graphics.DrawString(Funcion.reemplazarcaracter(Convert.ToString(retenido)), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 745, y + 2);
                        y = y + 22;
                        double totalRetenido = Math.Round(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(Convert.ToString(dtpTemporalRetencion.Rows[i].Cells[4].Value))), 2);
                        sumaRetencion = sumaRetencion + Convert.ToSingle(totalRetenido);
                        if (Convert.ToString(dtpTemporalRetencion.Rows[i + 1].Cells[0].Value) == "")
                            break;
                    }
                    e.Graphics.DrawString("Total Retenido:", new Font("Verdana", 9, FontStyle.Bold), Brushes.Black, 500, y + 5);
                    e.Graphics.DrawString(Funcion.reemplazarcaracter(Convert.ToString(sumaRetencion)), new Font("Verdana", 9, FontStyle.Regular), Brushes.Black, 745, y);

                    /*
                    e.Graphics.DrawString("Firma:", new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, 500, y + 75);*/
                }

            }
            catch (Exception)
            {
            }
        }
    }
}
