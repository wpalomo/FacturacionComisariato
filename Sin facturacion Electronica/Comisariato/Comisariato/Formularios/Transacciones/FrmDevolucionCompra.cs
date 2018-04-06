using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmDevolucionCompra : Form
    {
        public FrmDevolucionCompra()
        {
            InitializeComponent();
        }
        Consultas objConsultas = new Consultas();
        Bitacora bitacora = new Bitacora();
        EncabezadoNotaCredito objENC;
        DetalleNotaCredito objDNC;
        int encabezadoNotaCredito = 0;
        int compraDetalle = 0;
        bool ivaEstado = false;
        bool modificar = false;
        float sumasubiva = 0.0f, sumasubcero = 0.0f, totalpagar = 0.0f, ivatotal = 0.0f, sumaice = 0.0f, sumairbp = 0.0f, subtotalPie = 0.0f;

        public void inicializar()
        {
            modificar = false;
            int i = 0;
            txtTotal.Text = "";
            txtTotalDevolucion.Text = "";
            txtICE.Text = "";
            txtIRBP.Text = "";
            txtIVA.Text = "";
            txtIrbpDevolucion.Text = "";
            txtIceDevolucion.Text = "";
            txtIvaDevolucion.Text = "";
            txtSubtotal.Text = "";
            txtSubtotal0.Text = "";
            txtSubtotal0Devolucion.Text = "";
            txtSubtotalDevolucion.Text = "";
            txtSubtotalIvaDevolucion.Text = "";
            txtSubtutalIVA.Text = "";
            ckbDevolver.Checked = false;
            txtPorcetajeDevolucion.Text = "0";
            Funcion.Limpiarobjetos(gbEncabezadoNC);
            dgvProductosDevolucion.Rows.Clear();
            for (i = 0; i < 20; i++)
            {
                dgvProductosDevolucion.Rows.Add();
                dgvDatosProducto.Rows.Add();
            }
            dgvProductosDevolucion.Rows[i].ReadOnly = true;
            dgvProductosDevolucion.Columns[9].ReadOnly = true;
            dgvProductosDevolucion.Columns[10].ReadOnly = true;
            BtnGuardar.Text = "&Guardar";
        }
        private void FrmDevolucionCompra_Load(object sender, EventArgs e)
        {
            dgvProductosDevolucion.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProductosDevolucion.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            for (int i = 2; i < 11; i++)
                dgvProductosDevolucion.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            objConsultas.BoolLlenarComboBox(cbProveedor, "select IDPROVEEDOR AS ID, NOMBRES AS Texto from TbProveedor");
            rbActivos.Checked = true;
            inicializar();
            SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
        }
        private void cbProveedor_Leave(object sender, EventArgs e)
        {
            if (txtSerie1.Text != "" && txtSerie2.Text != "" && txtNumero.Text != "" && cbProveedor.Text != "")
            {
                txtPorcetajeDevolucion.Focus();
                string sqlConsultar = "select e.IDEMCABEZADOCOMPRA, e.IMPUESTO, p.IVAESTADO, p.NOMBREPRODUCTO,d.CANTIDAD, d.CODIGOBARRAPRODUCTO, d.ICE, d.PRECIOCOMRPA,d.IRBP " +
                    " from TbEncabezadoyPieCompra e, TbDetalleCompra d, TbProducto p, TbProveedor pro" +
                    " where d.IDENCABEZADOCOMPRA = e.IDEMCABEZADOCOMPRA and p.CODIGOBARRA = d.CODIGOBARRAPRODUCTO" +
                    " and pro.IDPROVEEDOR = e.IDPROVEEDOR and e.SERIE1 = '" + txtSerie1.Text + "' and e.SERIE2 = '" + txtSerie2.Text +"' and e.NUMERO = '"+ txtNumero.Text +"'" +
                    " and e.IDPROVEEDOR = "+ cbProveedor.SelectedValue + " order by d.IDDETALLECOMPRA";
                DataTable dt = objConsultas.BoolDataTable(sqlConsultar);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];
                        if (i == dgvProductosDevolucion.RowCount -1)
                        {
                            dgvProductosDevolucion.Rows.Add();
                        }
                        dgvProductosDevolucion.Rows[i].Cells[0].Value = row["CODIGOBARRAPRODUCTO"];//codigo
                        dgvProductosDevolucion.Rows[i].Cells[1].Value = row["NOMBREPRODUCTO"];//producto
                        dgvProductosDevolucion.Rows[i].Cells[2].Value = row["CANTIDAD"];//cantidad
                        dgvProductosDevolucion.Rows[i].Cells[3].Value = Funcion.reemplazarcaracter(row["PRECIOCOMRPA"].ToString());//precio
                        //dgvProductosDevolucion.Rows[i].Cells[4].Value = Funcion.reemplazarcaracter(row["DESCUENTO"].ToString());//descuento
                        dgvProductosDevolucion.Rows[i].Cells[4].Value = Funcion.reemplazarcaracter(row["ICE"].ToString());//ice
                        dgvProductosDevolucion.Rows[i].Cells[5].Value = Funcion.reemplazarcaracter(row["IRBP"].ToString());//irbp
                        //if (!ckbDevolver.Checked)
                        if (!ckbDevolver.Checked)
                        {
                            dgvProductosDevolucion.Rows[i].Cells[9].ReadOnly = false;
                            dgvProductosDevolucion.Rows[i].Cells[10].ReadOnly = false;
                            dgvProductosDevolucion.Rows[i].Cells[9].Value = "0";
                            dgvProductosDevolucion.Rows[i].Cells[10].Value = "0%";
                        }
                        else
                        {
                            dgvProductosDevolucion.Rows[i].Cells[9].ReadOnly = true;
                            dgvProductosDevolucion.Rows[i].Cells[10].ReadOnly = true;
                        }
                        //    dgvProductosDevolucion.ReadOnly = true;
                        txtImpuesto.Text = row["IMPUESTO"].ToString();
                        compraDetalle = Convert.ToInt32(row["IDEMCABEZADOCOMPRA"]);
                        ivaEstado = Convert.ToBoolean(row["IVAESTADO"]);
                        float precioCompra = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[3].Value.ToString()));
                        float cantidad = Convert.ToInt32(dgvProductosDevolucion.Rows[i].Cells[2].Value.ToString());
                        float precioICE = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[4].Value.ToString()));
                        float precioIRBP = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[5].Value.ToString()));
                        float subtotalP = 0.0f;
                        float totalP = 0.0f;
                        string[] separadorPorcentaje = txtImpuesto.Text.Split('%');
                        int tipoIva = Convert.ToInt32(separadorPorcentaje[0]);
                        float ivaP = 0.0f;
                        if (ivaEstado)
                        {
                            ivaP = (((precioCompra + precioICE) * cantidad) * tipoIva) / 100;
                        }
                        else
                        {
                            ivaP = 0;
                        }
                        subtotalP = ((precioCompra + precioICE + precioIRBP) * cantidad);
                        totalP = subtotalP + ivaP;
                        dgvProductosDevolucion.Rows[i].Cells[7].Value = Funcion.reemplazarcaracter(Math.Round(ivaP, 2).ToString("#####0.00"));
                        dgvProductosDevolucion.Rows[i].Cells[6].Value = Funcion.reemplazarcaracter(Math.Round(subtotalP, 2).ToString("#####0.00"));
                        dgvProductosDevolucion.Rows[i].Cells[8].Value = Funcion.reemplazarcaracter(Math.Round(totalP, 2).ToString("#####0.00"));
                    }
                }
                Calcular(2);
                if (ckbDevolver.Checked)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgvProductosDevolucion.Rows[i].Cells[9].Value = dgvProductosDevolucion.Rows[i].Cells[2].Value;
                        dgvProductosDevolucion.Rows[i].Cells[11].Value = dgvProductosDevolucion.Rows[i].Cells[2].Value;
                        dgvProductosDevolucion.Rows[i].Cells[10].Value = "100%";
                    }
                    Calcular(11);
                }
                else
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgvProductosDevolucion.Rows[i].Cells[9].Value = "0";
                        dgvProductosDevolucion.Rows[i].Cells[11].Value = "0";
                        dgvProductosDevolucion.Rows[i].Cells[10].Value = "0%";
                    }
                    Calcular(11);
                }

            }
            
        }

        private void dgvProductosDevolucion_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbersdgvcheque_KeyPress;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            inicializar();
        }

        private void btnSalirCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbDevolver_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDevolver.Checked)
            {
                txtPorcetajeDevolucion.Text = "100";
                txtPorcetajeDevolucion.Enabled = false;
                cbProveedor_Leave(null, null);
                for (int i = 0; i < dgvProductosDevolucion.RowCount - 1; i++)
                {
                    dgvProductosDevolucion.Rows[i].Cells[9].ReadOnly = true;
                    dgvProductosDevolucion.Rows[i].Cells[10].ReadOnly = true;
                    if (Convert.ToString(dgvProductosDevolucion.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
                //Calcular(2);
            }
            else
            {
                txtPorcetajeDevolucion.Enabled = true;
                for (int i = 0; i < dgvProductosDevolucion.RowCount-1; i++)
                {
                    dgvProductosDevolucion.Rows[i].Cells[9].ReadOnly = false;
                    dgvProductosDevolucion.Rows[i].Cells[10].ReadOnly = false;
                    if (Convert.ToString(dgvProductosDevolucion.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
                txtPorcetajeDevolucion.Text = "0";
                cbProveedor_Leave(null, null);
            }
        }

        private void txtSerie1NC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPorcetajeDevolucion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                dgvProductosDevolucion.Focus();
                dgvProductosDevolucion.CurrentCell = dgvProductosDevolucion.Rows[0].Cells[10];
            }
        }

        private void txtPorcetajeDevolucion_Leave(object sender, EventArgs e)
        {
            if (!ckbDevolver.Checked && txtPorcetajeDevolucion.Text != "")
            {
                for (int i = 0; i < dgvProductosDevolucion.RowCount - 1; i++)
                {
                    dgvProductosDevolucion.Rows[i].Cells[10].Value = txtPorcetajeDevolucion.Text + "%";
                    dgvProductosDevolucion.Rows[i].Cells[11].Value = Funcion.reemplazarcaracter((Convert.ToSingle(dgvProductosDevolucion.Rows[i].Cells[2].Value) * (Convert.ToSingle(txtPorcetajeDevolucion.Text) / 100)).ToString());
                    dgvProductosDevolucion.Rows[i].Cells[9].Value = "0";
                    dgvProductosDevolucion.Rows[i].Cells[9].ReadOnly = true;
                    //Calcular(9);
                    Calcular(11);

                    if (Convert.ToString(dgvProductosDevolucion.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
            else
            {
                for (int i = 0; i < dgvProductosDevolucion.RowCount - 1; i++)
                {
                    dgvProductosDevolucion.Rows[i].Cells[9].ReadOnly = false;
                    if (Convert.ToString(dgvProductosDevolucion.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
            
        }

        private void cbProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void dgvProductosDevolucion_Enter(object sender, EventArgs e)
        {
            try {
                for (int i = 0; i < dgvProductosDevolucion.RowCount - 1; i++)
                {
                    string[] porcentaje = dgvProductosDevolucion.Rows[i].Cells[10].Value.ToString().Split('%');
                    dgvProductosDevolucion.Rows[i].Cells[11].Value = Funcion.reemplazarcaracter((Convert.ToSingle(dgvProductosDevolucion.Rows[i].Cells[2].Value) * (Convert.ToSingle(porcentaje[0]) / 100)).ToString());
                    if (Convert.ToString(dgvProductosDevolucion.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
            catch { }
        }

        private void pcOrdenCompra_Click(object sender, EventArgs e)
        {
        }

        private void txt0_Leave(object sender, EventArgs e)
        {
            if (txt0.Text != "")
            {
                for (int i = 0; i < dgvProductosDevolucion.RowCount - 1; i++)
                {
                    if (Convert.ToString(dgvProductosDevolucion.Rows[i].Cells[7].Value) == "0.00")
                    {
                        dgvProductosDevolucion.Rows[i].Cells[10].Value = txt0.Text + "%";
                        dgvProductosDevolucion.Rows[i].Cells[11].Value = Funcion.reemplazarcaracter((Convert.ToSingle(dgvProductosDevolucion.Rows[i].Cells[2].Value) * (Convert.ToSingle(txt0.Text) / 100)).ToString());
                        dgvProductosDevolucion.Rows[i].Cells[9].Value = "0";
                        dgvProductosDevolucion.Rows[i].Cells[9].ReadOnly = true;
                        //Calcular(9);
                        Calcular(11);
                    }
                    if (Convert.ToString(dgvProductosDevolucion.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
            else
            {
                for (int i = 0; i < dgvProductosDevolucion.RowCount - 1; i++)
                {
                    dgvProductosDevolucion.Rows[i].Cells[9].ReadOnly = false;
                    if (Convert.ToString(dgvProductosDevolucion.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
        }

        private void txt12_Leave(object sender, EventArgs e)
        {
            if (txt12.Text != "")
            {
                for (int i = 0; i < dgvProductosDevolucion.RowCount - 1; i++)
                {
                    if (Convert.ToString(dgvProductosDevolucion.Rows[i].Cells[7].Value) != "0.00")
                    {
                        dgvProductosDevolucion.Rows[i].Cells[10].Value = txt12.Text + "%";
                        dgvProductosDevolucion.Rows[i].Cells[11].Value = Funcion.reemplazarcaracter((Convert.ToSingle(dgvProductosDevolucion.Rows[i].Cells[2].Value) * (Convert.ToSingle(txt12.Text) / 100)).ToString());
                        dgvProductosDevolucion.Rows[i].Cells[9].Value = "0";
                        dgvProductosDevolucion.Rows[i].Cells[9].ReadOnly = true;
                        //Calcular(9);
                        Calcular(11);
                    }
                    if (Convert.ToString(dgvProductosDevolucion.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
            else
            {
                for (int i = 0; i < dgvProductosDevolucion.RowCount - 1; i++)
                {
                    dgvProductosDevolucion.Rows[i].Cells[9].ReadOnly = false;
                    if (Convert.ToString(dgvProductosDevolucion.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
        }
        public void consultaNC()
        {
            bool ver = false;
            if (rbActivos.Checked)
            {
                ver = true;
                btnAnular.Text = "Anular";
            }
            else if (rbAnulados.Checked)
            {
                ver = false;
                btnAnular.Text = "Activar";
            }
            string sql = "select FECHA, SERIE1+''+SERIE2+''+NUMERO AS NOTACREDITO, SERIE1COMPRA+''+SERIE2COMPRA+''+NUMEROCOMPRA AS COMPRA, NOMBRES, TOTALDEVOLUCION, TOTAL, IDENCABEZADONOTACREDITO, IDEMCABEZADOCOMPRA from VistaNotaCredito where NOMBRES LIKE '%" + txtConsultar.Text + "%' AND FECHA BETWEEN '" + Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToShortDateString()) + "' AND '" + Funcion.reemplazarcaracterFecha(dtpHasta.Value.ToShortDateString()) + "' and ESTADO = '"+ver+"'";
            objConsultas.boolLlenarDataGrid(dgvDatosProducto, sql, 20, 7, 0);
            if (Convert.ToString(dgvDatosProducto.Rows[0].Cells[0].Value) != "")
            {
                dgvDatosProducto.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDatosProducto.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                for (int i = 0; i < dgvDatosProducto.RowCount - 1; i++)
                {
                    if (Convert.ToString(dgvDatosProducto.Rows[i].Cells[0].Value) != "")
                    {
                        for (int j = 4; j < 6; j++)
                            dgvDatosProducto.Rows[i].Cells[j].Value = Funcion.reemplazarcaracter(dgvDatosProducto.Rows[i].Cells[j].Value.ToString());
                        if (Convert.ToString(dgvDatosProducto.Rows[i + 1].Cells[0].Value) == "")
                            break;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int i = 0; i < dgvDatosProducto.RowCount - 1; i++)
                {
                    dgvDatosProducto.Rows[i].Cells[0].Value = Convert.ToDateTime(dgvDatosProducto.Rows[i].Cells[0].Value).ToShortDateString();
                    if (Convert.ToString(dgvDatosProducto.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
            dgvDatosProducto.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                
                consultaNC();
                for (int i = 0; i < dgvDatosProducto.RowCount - 1; i++)
                {
                    if (Convert.ToString(dgvDatosProducto.Rows[i].Cells[0].Value) != "")
                    {
                        for (int j = 4; j < 6; j++)
                            dgvDatosProducto.Rows[i].Cells[j].Value = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvDatosProducto.Rows[i].Cells[j].Value.ToString())), 2).ToString());
                        if (Convert.ToString(dgvDatosProducto.Rows[i + 1].Cells[0].Value) == "")
                            break;
                    }
                }
                if (rbActivos.Checked)
                {
                    txtModificarVer.Enabled = true;
                }
                else if (rbAnulados.Checked)
                {
                    txtModificarVer.Enabled = false;
                }
            }
            catch
            {}
            
        }

        private void txtModificarVer_Click(object sender, EventArgs e)
        {
            modificar = true;
            BtnGuardar.Text = "Modificar";
            encabezadoNotaCredito = Convert.ToInt32(dgvDatosProducto.CurrentRow.Cells[6].Value);
            tabControl1.SelectedIndex = 0;
            DataTable encabezadoPie = objConsultas.BoolDataTable("select * from TbEncabezadoNotaCredito where IDENCABEZADONOTACREDITO = " + encabezadoNotaCredito);
            if (encabezadoPie.Rows.Count > 0)
            {
                DataRow rowEncabezado = encabezadoPie.Rows[0];
                DataTable numeroCompra = objConsultas.BoolDataTable("select * from TbEncabezadoyPieCompra where IDEMCABEZADOCOMPRA = " + rowEncabezado["IDENCABEZADOCOMPRA"]);
                if (numeroCompra.Rows.Count > 0)
                {
                    DataRow rowCompra = numeroCompra.Rows[0];
                    cbProveedor.SelectedValue = Convert.ToInt32(rowCompra["IDPROVEEDOR"]);
                    txtSerie1.Text = rowCompra["SERIE1"].ToString();
                    txtSerie2.Text = rowCompra["SERIE2"].ToString();
                    txtNumero.Text = rowCompra["NUMERO"].ToString();
                    cbProveedor_Leave(null, null);
                }

                txtAutorizacionNC.Text = Convert.ToString(rowEncabezado["AUTORIZACION"]);
                dtpFechaEmision.Value = Convert.ToDateTime(rowEncabezado["FECHA"]);
                txtSerie1NC.Text = rowEncabezado["SERIE1"].ToString();
                txtSerie2NC.Text = rowEncabezado["SERIE2"].ToString();
                txtNumeroNC.Text = rowEncabezado["NUMERO"].ToString();
                DataTable detalleNotaCredito = objConsultas.BoolDataTable("select * from TbDetalleNotaCredito where IDENCABEZADONOTACREDITO = " + encabezadoNotaCredito);
                if (detalleNotaCredito.Rows.Count > 0)
                {
                    for (int i = 0; i < detalleNotaCredito.Rows.Count; i++)
                    {
                        DataRow rowDetalleCredito = detalleNotaCredito.Rows[i];
                        if (Convert.ToString(rowDetalleCredito["CANTIDAD"]) != "0" && Convert.ToString(rowDetalleCredito["PORCENTAJE"]) == "0")
                        {
                            dgvProductosDevolucion.Rows[i].Cells[9].Value = rowDetalleCredito["CANTIDAD"];
                            dgvProductosDevolucion.Rows[i].Cells[11].Value = rowDetalleCredito["CANTIDAD"];
                            Calcular(11);
                        }
                        else if (Convert.ToString(rowDetalleCredito["CANTIDAD"]) == "0" && Convert.ToString(rowDetalleCredito["PORCENTAJE"]) != "0")
                        {
                            dgvProductosDevolucion.Rows[i].Cells[10].Value = rowDetalleCredito["PORCENTAJE"] + "%";
                            string[] porcentaje = dgvProductosDevolucion.Rows[i].Cells[10].Value.ToString().Split('%');
                            dgvProductosDevolucion.Rows[i].Cells[11].Value = Funcion.reemplazarcaracter((Convert.ToSingle(dgvProductosDevolucion.Rows[i].Cells[2].Value) * (Convert.ToSingle(porcentaje[0]) / 100)).ToString());
                            Calcular(11);
                        }
                        else if (Convert.ToString(rowDetalleCredito["CANTIDAD"]) == "0" && Convert.ToString(rowDetalleCredito["PORCENTAJE"]) == "0")
                        {
                            dgvProductosDevolucion.Rows[i].Cells[9].Value = "0";
                            dgvProductosDevolucion.Rows[i].Cells[10].Value = "0";
                            dgvProductosDevolucion.Rows[i].Cells[11].Value = "0";
                            Calcular(11);
                        }
                    }
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            int encabezado = Convert.ToInt32(dgvDatosProducto.CurrentRow.Cells[6].Value);
            int estado = 0;
            if (btnAnular.Text == "Anular")
                estado = 0;
            else if (btnAnular.Text == "Activar")
                estado = 1;
            string sqlAnular = "UPDATE [dbo].[TbEncabezadoNotaCredito] SET [ESTADO] = "+ estado +" WHERE IDENCABEZADONOTACREDITO = "+ encabezado +"";
            if (objConsultas.EjecutarSQL(sqlAnular))
            {
                MessageBox.Show("Acción guardada correctamente");
                consultaNC();
            }
            else
                MessageBox.Show("Error al anular");
        }

        private void dgvDatosProducto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToString(dgvDatosProducto.CurrentRow.Cells[0].Value) != "")
            {
                txtModificarVer.Enabled = true;
                btnAnular.Enabled = true;
                //string factura = Convert.ToString(dgvDatosProducto.CurrentRow.Cells[1].Value);
                //string serie1 = factura.Substring(0, 3);
                //string serie2 = factura.Substring(3, 3);
                //string numero = factura.Substring(6, 9);
                int compra = Convert.ToInt32(dgvDatosProducto.CurrentRow.Cells[7].Value);
                //string idEncabezadoNC = objConsultas.ObtenerValorCampo("IDENCABEZADONOTACREDITO", "TbEncabezadoNotaCredito", " where IDENCABEZADOCOMPRA = " + compra + " and SERIE1 = '" + serie2 + "' and SERIE2 = '" + serie2 + "' and NUMERO = '" + numero + "' ");
                bool existeCredito = objConsultas.verificaCreditoCompra(compra, Convert.ToSingle(dgvDatosProducto.CurrentRow.Cells[4].Value));
                if (existeCredito && rbAnulados.Checked)
                {
                    //btnModificar.Text = "Ver";
                    btnAnular.Enabled = true;
                }
                else if (!existeCredito && rbAnulados.Checked)
                {
                    //btnModificar.Text = "Modificar";
                    btnAnular.Enabled = false;
                }
            }
            else
            {
                txtModificarVer.Enabled = false;
                btnAnular.Enabled = false;
            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                dgvProductosDevolucion.Focus();
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool banderaCorrecto = false;
            if (txtTotalDevolucion.Text != "")
            {
                if (MessageBox.Show("¿Desea Gaurdar la Nota de Credito?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtSerie1.Text != "" && txtSerie2.Text != "" && txtNumero.Text != "" && txtAutorizacionNC.Text != "" && txtSerie1NC.Text != "" && txtSerie2NC.Text != "" && txtNumeroNC.Text != "")
                    {
                        if (txtTotalDevolucion.Text != "0.00")
                        {
                            if (!modificar)
                            {
                                objENC = new EncabezadoNotaCredito(txtSerie1NC.Text, txtSerie2NC.Text, txtNumeroNC.Text, compraDetalle, Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalDevolucion.Text)), sumasubcero, sumasubiva, ivatotal, sumaice, sumairbp, Convert.ToDateTime(dtpFechaEmision.Value.ToShortDateString()), txtAutorizacionNC.Text, subtotalPie);
                                string resultado = objENC.InsertarEncabezadoNC(objENC);
                                if (resultado == "Datos Guardados")
                                {
                                    string idEncabezadoNC = objConsultas.ObtenerValorCampo("IDENCABEZADONOTACREDITO", "TbEncabezadoNotaCredito", " where IDENCABEZADOCOMPRA = "+ compraDetalle + " and SERIE1 = " + txtSerie1NC.Text  + " and SERIE2 = " + txtSerie2NC.Text + " and NUMERO = " + txtNumeroNC.Text + " ");
                                    for (int i = 0; i < dgvProductosDevolucion.RowCount - 1; i++)
                                    {
                                        string[] porcentaje = dgvProductosDevolucion.Rows[i].Cells[10].Value.ToString().Split('%');
                                        float precioPorcentaje = Convert.ToSingle(porcentaje[0]);
                                        objDNC = new DetalleNotaCredito(Convert.ToInt32(idEncabezadoNC), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[9].Value.ToString())), Convert.ToString(dgvProductosDevolucion.Rows[i].Cells[0].Value), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(precioPorcentaje.ToString())));
                                        string resultadoDetalle = objDNC.InsertarDetalleNC(objDNC);
                                        if (resultadoDetalle == "Datos Guardados")
                                            banderaCorrecto = true;
                                        else if (resultadoDetalle == "Error al Registrar")
                                        {
                                            banderaCorrecto = false;
                                            break;
                                        }
                                        if (Convert.ToString(dgvProductosDevolucion.Rows[i + 1].Cells[0].Value) == "")
                                            break;
                                    }
                                    if (!banderaCorrecto)
                                    {
                                        MessageBox.Show("Error al guardar la Nota de Crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        objConsultas.EjecutarSQL("DELETE FROM [dbo].[TbEncabezadoNotaCredito] WHERE IDENCABEZADOCOMPRA = " + compraDetalle + "");
                                        objConsultas.EjecutarSQL("DELETE FROM [dbo].[TbDetalleNotaCredito] WHERE IDENCABEZADONOTACREDITO = " + idEncabezadoNC + "");
                                        inicializar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Guardada correctamente la Nota de Crédito");
                                        //string numeroNC = (Convert.ToInt32(txtNumeroNC.Text) + 1).ToString("D9");
                                        //objConsultas.EjecutarSQL("UPDATE [dbo].[TbCajasTalonario] SET [DOCUMENTOACTUAL] = '" + numeroNC + "' WHERE SERIE1 = '" + txtSerie1NC.Text + "' and SERIE2 = '" + txtSerie2NC.Text + "' and IPESTACION = '" + bitacora.LocalIPAddress() + "' and TIPODOCUMENTO = 'NCRE'");
                                        inicializar();
                                    }
                                }
                                else if (resultado == "Error al Registrar")
                                {
                                    MessageBox.Show("Error al guardar la Nota de Crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    objConsultas.EjecutarSQL("DELETE FROM [dbo].[TbEncabezadoNotaCredito] WHERE IDENCABEZADOCOMPRA = " + encabezadoNotaCredito + "");
                                }
                                else if (resultado == "Existe")
                                    MessageBox.Show("No hay mas crédito para esta compra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (modificar)
                            {
                                objENC = new EncabezadoNotaCredito(txtSerie1NC.Text, txtSerie2NC.Text, txtNumeroNC.Text, compraDetalle, Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalDevolucion.Text)), sumasubcero, sumasubiva, ivatotal, sumaice, sumairbp, Convert.ToDateTime(dtpFechaEmision.Value.ToShortDateString()), txtAutorizacionNC.Text, subtotalPie);
                                string resultado = objENC.ActualizarEncabezadoNC(encabezadoNotaCredito);
                                if (resultado == "Datos Guardados")
                                {
                                    string idEncabezadoNC = objConsultas.ObtenerValorCampo("IDENCABEZADONOTACREDITO", "TbEncabezadoNotaCredito", " where IDENCABEZADOCOMPRA = " + compraDetalle + " and SERIE1 = '" + txtSerie1NC.Text + "' and SERIE2 = '" + txtSerie2NC.Text + "' and NUMERO = '" + txtNumeroNC.Text + "' ");
                                    for (int i = 0; i < dgvProductosDevolucion.RowCount - 1; i++)
                                    {
                                        string[] porcentaje = dgvProductosDevolucion.Rows[i].Cells[10].Value.ToString().Split('%');
                                        float precioPorcentaje = Convert.ToSingle(porcentaje[0]);
                                        objDNC = new DetalleNotaCredito(Convert.ToInt32(idEncabezadoNC), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[9].Value.ToString())), Convert.ToString(dgvProductosDevolucion.Rows[i].Cells[0].Value), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(precioPorcentaje.ToString())));
                                        //if (Convert.ToString(dgvProductosDevolucion.Rows[i].Cells[9].Value) != "")
                                        //{
                                        string resultadoDetalle = objDNC.ActualizarDetalleNC();
                                        if (resultadoDetalle == "Datos Guardados")
                                            banderaCorrecto = true;
                                        else if (resultadoDetalle == "Error al Registrar")
                                        {
                                            banderaCorrecto = false;
                                            break;
                                        }
                                        if (Convert.ToString(dgvProductosDevolucion.Rows[i + 1].Cells[0].Value) == "")
                                            break;
                                        //}
                                    }
                                    if (!banderaCorrecto)
                                    {
                                        MessageBox.Show("Error al guardar la Nota de Crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        inicializar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Guardada correctamente la Nota de Crédito");
                                        
                                        inicializar();
                                    }
                                }
                                else if (resultado == "Error al Registrar")
                                {
                                    MessageBox.Show("Error al actualizar la Nota de Crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    //objConsultas.EjecutarSQL("DELETE FROM [dbo].[TbEncabezadoNotaCredito] WHERE IDENCABEZADOCOMPRA = " + encabezadoNotaCredito + "");
                                }
                            }
                        }
                        else
                            MessageBox.Show("No se a realizado ninguna devolución", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //--------------------------------------------
                    
                    }
                    else
                        MessageBox.Show("Debe ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("No se a realizado ninguna devolución", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void dgvProductosDevolucion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProductosDevolucion.Columns[e.ColumnIndex].Name == "porcentajeDevolucion")
                {
                    if (Convert.ToString(dgvProductosDevolucion.Rows[e.RowIndex].Cells[9].Value) != "" || Convert.ToString(dgvProductosDevolucion.Rows[e.RowIndex].Cells[9].Value) == "0")
                    {
                        string cantidadProducto = objConsultas.ObtenerValorCampo("CANTIDAD", "TbProducto", "where CODIGOBARRA = '" + Convert.ToString(dgvProductosDevolucion.CurrentRow.Cells[0].Value) + "'");
                        if (Convert.ToSingle(cantidadProducto) >= Convert.ToSingle(dgvProductosDevolucion.CurrentRow.Cells[9].Value))
                        {
                            if (Convert.ToInt32(dgvProductosDevolucion.Rows[e.RowIndex].Cells[9].Value) <= Convert.ToInt32(dgvProductosDevolucion.Rows[e.RowIndex].Cells[2].Value))
                            {
                                string[] porcentaje = dgvProductosDevolucion.Rows[e.RowIndex].Cells[10].Value.ToString().Split('%');
                                dgvProductosDevolucion.Rows[e.RowIndex].Cells[11].Value = Funcion.reemplazarcaracter((Convert.ToSingle(dgvProductosDevolucion.Rows[e.RowIndex].Cells[2].Value) * (Convert.ToSingle(porcentaje[0]) / 100)).ToString());
                                dgvProductosDevolucion.Rows[e.RowIndex].Cells[9].ReadOnly = true;
                                dgvProductosDevolucion.Rows[e.RowIndex].Cells[10].Value = Convert.ToString(dgvProductosDevolucion.Rows[e.RowIndex].Cells[10].Value) + "%";
                                txtPorcetajeDevolucion.Text = "0";
                                Calcular(11);
                            }
                            else
                            {
                                MessageBox.Show("Cantidad a devolver debe ser menor o igual que la cantidad comprada", "Aviso", MessageBoxButtons.OK);
                                dgvProductosDevolucion.CurrentRow.Cells[9].Value = "";
                                SendKeys.Send("{UP}");
                            }
                        }
                        else if (Convert.ToInt32(cantidadProducto) == 0)
                            MessageBox.Show("Stock en 0 de este producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("No existe cantidad suficiente para devolver", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (Convert.ToString(dgvProductosDevolucion.Rows[e.RowIndex].Cells[10].Value) == "0%")
                        {
                            dgvProductosDevolucion.Rows[e.RowIndex].Cells[9].ReadOnly = false;
                        }
                    }

                }
                if (dgvProductosDevolucion.Columns[e.ColumnIndex].Name == "cantidadDevolver")
                {
                    if (Convert.ToString(dgvProductosDevolucion.Rows[e.RowIndex].Cells[9].Value) != "" && Convert.ToString(dgvProductosDevolucion.Rows[e.RowIndex].Cells[9].Value) != "0")
                    {
                        string cantidadProducto = objConsultas.ObtenerValorCampo("CANTIDAD", "TbProducto", "where CODIGOBARRA = '" + Convert.ToString(dgvProductosDevolucion.CurrentRow.Cells[0].Value) + "'");
                        if (Convert.ToSingle(cantidadProducto) >= Convert.ToSingle(dgvProductosDevolucion.CurrentRow.Cells[9].Value))
                        {
                            if (Convert.ToSingle(dgvProductosDevolucion.Rows[e.RowIndex].Cells[9].Value) <= Convert.ToSingle(dgvProductosDevolucion.Rows[e.RowIndex].Cells[2].Value))
                            {
                                dgvProductosDevolucion.Rows[e.RowIndex].Cells[10].ReadOnly = true;
                                dgvProductosDevolucion.Rows[e.RowIndex].Cells[11].Value = Funcion.reemplazarcaracter(Convert.ToSingle(dgvProductosDevolucion.Rows[e.RowIndex].Cells[9].Value).ToString());
                                txtPorcetajeDevolucion.Text = "0";
                                Calcular(11);
                            }
                            else
                            {
                                MessageBox.Show("Cantidad a devolver debe ser menor o igual que la cantidad comprada", "Aviso", MessageBoxButtons.OK);
                                dgvProductosDevolucion.CurrentRow.Cells[9].Value = "";
                                SendKeys.Send("{UP}");
                            }
                        }
                        else if (Convert.ToInt32(cantidadProducto) == 0)
                            MessageBox.Show("Stock en 0 de este producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("No existe cantidad suficiente para devolver", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                        dgvProductosDevolucion.Rows[e.RowIndex].Cells[10].ReadOnly = false;
                }
            }
            catch
            {

            }
        }
        private void Calcular(int posicion)
        {
            float cantidad = 0, pc = 0.0f;
            sumasubiva = 0.0f; sumasubcero = 0.0f; totalpagar = 0.0f; ivatotal = 0.0f; sumaice = 0.0f; sumairbp = 0.0f; subtotalPie = 0.0f;
            try
            {
                for (int i = 0; i < dgvProductosDevolucion.RowCount; i++)
                {
                    cantidad = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[posicion].Value.ToString()));
                    if (Convert.ToSingle(dgvProductosDevolucion.Rows[i].Cells[7].Value.ToString()) != 0)
                    {
                        pc = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[3].Value.ToString()));
                        sumasubiva += Convert.ToSingle(cantidad * pc);

                    }
                    if (Convert.ToSingle(dgvProductosDevolucion.Rows[i].Cells[7].Value.ToString()) == 0)
                    {
                        pc = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[3].Value.ToString()));
                        sumasubcero += Convert.ToSingle(cantidad * pc);
                    }
                    sumaice += Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[4].Value.ToString())) * Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[posicion].Value.ToString()));
                    sumairbp += Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[5].Value.ToString())) * Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[posicion].Value.ToString()));
                    if (Convert.ToString(dgvProductosDevolucion.Rows[i + 1].Cells[0].Value) == "")
                    {
                        break;
                    }
                }
                string[] s = txtImpuesto.Text.Split('%');
                float iva = Convert.ToSingle(s[0]) / 100;
                ivatotal = (sumasubiva + sumaice) * iva;
                subtotalPie = sumasubcero + sumasubiva;
                totalpagar = sumairbp + sumaice + subtotalPie + ivatotal;
                if (posicion == 2)
                {
                    txtICE.Text = Funcion.reemplazarcaracter(Math.Round(sumaice, 2).ToString("#####0.00"));
                    txtIRBP.Text = Funcion.reemplazarcaracter(Math.Round(sumairbp, 2).ToString("#####0.00"));
                    txtIVA.Text = Funcion.reemplazarcaracter(Math.Round(ivatotal, 2).ToString("#####0.00"));
                    txtSubtotal0.Text = Funcion.reemplazarcaracter(Math.Round(sumasubcero, 2).ToString("#####0.00"));
                    txtSubtutalIVA.Text = Funcion.reemplazarcaracter(Math.Round(sumasubiva, 2).ToString("#####0.00"));
                    txtSubtotal.Text = Funcion.reemplazarcaracter(Math.Round(subtotalPie, 2).ToString("#####0.00"));
                    txtTotal.Text = Funcion.reemplazarcaracter(Math.Round(totalpagar, 2).ToString("#####0.00"));
                }
                else
                {
                    txtIceDevolucion.Text = Funcion.reemplazarcaracter(Math.Round(sumaice, 2).ToString("#####0.00"));
                    txtIrbpDevolucion.Text = Funcion.reemplazarcaracter(Math.Round(sumairbp, 2).ToString("#####0.00"));
                    txtIvaDevolucion.Text = Funcion.reemplazarcaracter(Math.Round(ivatotal, 2).ToString("#####0.00"));
                    txtSubtotal0Devolucion.Text = Funcion.reemplazarcaracter(Math.Round(sumasubcero, 2).ToString("#####0.00"));
                    txtSubtotalIvaDevolucion.Text = Funcion.reemplazarcaracter(Math.Round(sumasubiva, 2).ToString("#####0.00"));
                    txtSubtotalDevolucion.Text = Funcion.reemplazarcaracter(Math.Round(subtotalPie, 2).ToString("#####0.00"));
                    txtTotalDevolucion.Text = Funcion.reemplazarcaracter(Math.Round(totalpagar, 2).ToString("#####0.00"));
                }
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
        private void CalcularPorcentaje()
        {
            float cantidad = 0, pc = 0.0f;
            sumasubiva = 0.0f; sumasubcero = 0.0f; totalpagar = 0.0f; ivatotal = 0.0f; sumaice = 0.0f; sumairbp = 0.0f; subtotalPie = 0.0f;
            try
            {
                for (int i = 0; i < dgvProductosDevolucion.RowCount; i++)
                {
                    if (Convert.ToString(dgvProductosDevolucion.Rows[i].Cells[10].Value) != "")
                    {
                        cantidad = Convert.ToSingle(dgvProductosDevolucion.Rows[i].Cells[2].Value) * (Convert.ToSingle(txtPorcetajeDevolucion.Text) / 100);
                        if (Convert.ToSingle(dgvProductosDevolucion.Rows[i].Cells[7].Value.ToString()) != 0)
                        {
                            pc = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[3].Value.ToString()));
                            sumasubiva += Convert.ToSingle(cantidad * pc);

                        }
                        if (Convert.ToSingle(dgvProductosDevolucion.Rows[i].Cells[7].Value.ToString()) == 0)
                        {
                            pc = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvProductosDevolucion.Rows[i].Cells[3].Value.ToString()));
                            sumasubcero += Convert.ToSingle(cantidad * pc);
                        }
                        sumaice += Convert.ToSingle(dgvProductosDevolucion.Rows[i].Cells[4].Value.ToString()) * cantidad;
                        sumairbp += Convert.ToSingle(dgvProductosDevolucion.Rows[i].Cells[5].Value.ToString()) * cantidad;
                       
                    }
                    if (Convert.ToString(dgvProductosDevolucion.Rows[i + 1].Cells[0].Value) == "")
                    {
                        break;
                    }

                }
                string[] s = txtImpuesto.Text.Split('%');
                float iva = Convert.ToSingle(s[0]) / 100;
                ivatotal = (sumasubiva + sumaice) * iva;
                subtotalPie = sumasubcero + sumasubiva;
                totalpagar = sumairbp + sumaice + subtotalPie + ivatotal;
                txtIceDevolucion.Text = Funcion.reemplazarcaracter(Math.Round(sumaice, 2).ToString("#####0.00"));
                txtIrbpDevolucion.Text = Funcion.reemplazarcaracter(Math.Round(sumairbp, 2).ToString("#####0.00"));
                txtIvaDevolucion.Text = Funcion.reemplazarcaracter(Math.Round(ivatotal, 2).ToString("#####0.00"));
                txtSubtotal0Devolucion.Text = Funcion.reemplazarcaracter(Math.Round(sumasubcero, 2).ToString("#####0.00"));
                txtSubtotalIvaDevolucion.Text = Funcion.reemplazarcaracter(Math.Round(sumasubiva, 2).ToString("#####0.00"));
                txtSubtotalDevolucion.Text = Funcion.reemplazarcaracter(Math.Round(subtotalPie, 2).ToString("#####0.00"));
                txtTotalDevolucion.Text = Funcion.reemplazarcaracter(Math.Round(totalpagar, 2).ToString("#####0.00"));
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

        private void OnlyNumbersdgvcheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (dgvProductosDevolucion.CurrentCell == dgvProductosDevolucion.CurrentRow.Cells[10])
            //{
            //    Funcion.Validar_Numeros(e);
            //}
        }
    }
}
