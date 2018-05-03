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

namespace Comisariato.Formularios.Informes
{
    public partial class FrmKardex : Form
    {
        public FrmKardex()
        {
            InitializeComponent();
        }
        public static string CodigoBarraConsultaProducto = "";
        public void inicializar()
        {
            //txtProducto.Text = "";
            dgvKardex.Rows.Clear();
            for (int i = 0; i < 17; i++)
                dgvKardex.Rows.Add();
        }
        Consultas objConsulta = new Consultas();
        private void FrmKardex_Load(object sender, EventArgs e)
        {
            //objConsulta.BoolLlenarComboBox(cbCategoria, "Select IDCATEGORIA as ID, Descripcion as Texto from TbCategoria");
            for (int i = 0; i < 17; i++)
                dgvKardex.Rows.Add();
            SendKeys.Send("{TAB}");
        }
        bool notaCredito = false;
        private void btnGenerarKardex_Click(object sender, EventArgs e)
        {
            //string cantidadProducto = "select CANTIDAD from TbProducto where CODIGOBARRA = '" + txtProducto.Text + "'";
            //string cantidadCompra = "sum(CANTIDAD) from TbDetalleCompra where CODIGOBARRAPRODUCTO = '" + txtProducto.Text + "'";
            //string cantidadVenta = "select sum(CANTIDAD) from TbDetalleFactura where CODIGOBARRAPRODUCTO = '" + txtProducto.Text + "'";           
            inicializar();
            if (consultoFormularioExterno)
            {
                LblNombreProducto.Visible = true; consultoFormularioExterno = false;
            }
            else
                LblNombreProducto.Visible = false;

            if (txtProducto.Text != "")
            {
                float cantProducto = Convert.ToSingle(objConsulta.ObtenerValorCampo("CANTIDAD", "TbProducto", " where CODIGOBARRA = '" + txtProducto.Text + "' OR NOMBREPRODUCTO = '" + txtProducto.Text + "'"));
                float existencia = 0;
                DataTable cantCompra = objConsulta.BoolDataTable("select sum(CANTIDAD) from TbDetalleCompra c, TbEncabezadoyPieCompra e " +
                            " where c.IDENCABEZADOCOMPRA = e.IDEMCABEZADOCOMPRA and  (CODIGOBARRAPRODUCTO = '" + txtProducto.Text + "' OR NOMBREPRODUCTO = '" + txtProducto.Text + "' )and e.FECHAORDENCOMPRA < '" + Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToShortDateString()) + "'");
                DataTable cantVenta = objConsulta.BoolDataTable("select sum(CANTIDAD) from TbDetalleFactura d, TbEncabezadoFactura e " +
                            " where d.NFACTURA = e.IDFACTURA and (CODIGOBARRAPRODUCTO = '" + txtProducto.Text + "' OR NOMBREPRODUCTO = '" + txtProducto.Text + "' ) and e.FECHA < '" + Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToShortDateString()) + "'");
                if (cantCompra != null && cantVenta != null)
                {
                    DataRow compra = cantCompra.Rows[0];
                    DataRow venta = cantVenta.Rows[0];
                    if (Convert.ToString(venta[0]) != "" && Convert.ToString(compra[0]) != "")
                        existencia = cantProducto + Convert.ToSingle(venta[0]) - Convert.ToSingle(compra[0]);
                    else
                        existencia = cantProducto;
                }
                dgvKardex.Rows[0].Cells[0].Value = Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToShortDateString());
                dgvKardex.Rows[0].Cells[1].Value = "Existencia";
                dgvKardex.Rows[0].Cells[2].Value = existencia;
                dgvKardex.Rows[0].Cells[3].Value = "0";
                dgvKardex.Rows[0].Cells[4].Value = "0";
                dgvKardex.Rows[0].Cells[8].Value = existencia;
                dgvKardex.Rows[0].Cells[9].Value = "0";
                dgvKardex.Rows[0].Cells[10].Value = "0";


                //---- desde aqui esta bien
                DataTable datosCompra = objConsulta.BoolDataTable("select e.SERIE1+''+e.SERIE2+''+e.NUMERO as NFactura, d.PRECIOCOMRPA, e.FECHAORDENCOMPRA, d.CANTIDAD" +
                " from TbEncabezadoyPieCompra e, TbDetalleCompra d, TbProducto p  where e.IDEMCABEZADOCOMPRA = d.IDENCABEZADOCOMPRA and" +
                " d.CODIGOBARRAPRODUCTO = p.CODIGOBARRA and (p.CODIGOBARRA = '" + txtProducto.Text + "' OR p.NOMBREPRODUCTO = '" + txtProducto.Text + "') and e.FECHAORDENCOMPRA between  '" + Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToShortDateString()) + "' and '" + Funcion.reemplazarcaracterFecha(dtpHasta.Value.ToShortDateString()) + "' order by e.FECHAORDENCOMPRA");

                DataTable datosVenta = objConsulta.BoolDataTable("select e.SUCURSAL, e.CAJA, e.NFACTURA, d.PRECIO, d.CANTIDAD, e.FECHA" +
                " from TbEncabezadoFactura e, TbDetalleFactura d, TbProducto p where e.IDFACTURA = d.NFACTURA and" +
                " d.CODIGOBARRAPRODUCTO = p.CODIGOBARRA and (p.CODIGOBARRA = '" + txtProducto.Text + "' OR p.NOMBREPRODUCTO = '" + txtProducto.Text + "') and e.FECHA between  '" + Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToShortDateString()) + "' and '" + Funcion.reemplazarcaracterFecha(dtpHasta.Value.ToShortDateString()) + "' order by e.FECHA");

                DataTable datosNotaCredito = objConsulta.BoolDataTable("select enc.SERIE1, enc.SERIE2, enc.NUMERO, dc.PRECIOCOMRPA, dnc.CANTIDAD, enc.FECHA, dnc.PORCENTAJE, dc.CANTIDAD as CANTCOMPRA " +
    " from TbEncabezadoNotaCredito enc, TbDetalleNotaCredito dnc, TbEncabezadoyPieCompra ec, TbDetalleCompra dc " +
    " where dnc.IDENCABEZADONOTACREDITO = enc.IDENCABEZADONOTACREDITO and enc.IDENCABEZADOCOMPRA = ec.IDEMCABEZADOCOMPRA and " +
    " dc.IDENCABEZADOCOMPRA = ec.IDEMCABEZADOCOMPRA and enc.FECHA between '" + Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToShortDateString()) + "' and '" + Funcion.reemplazarcaracterFecha(dtpHasta.Value.ToShortDateString()) + "' and dnc.CODIGOBARRA = '" + txtProducto.Text + "' " +
    " order by enc.FECHA");


                if (datosCompra != null)
                {
                    for (int i = 0; i < datosCompra.Rows.Count; i++)
                    {
                        DataRow dtCompra = datosCompra.Rows[i];
                        dgvKardex.Rows[i + 1].Cells[0].Value = dtCompra["FECHAORDENCOMPRA"];
                        dgvKardex.Rows[i + 1].Cells[1].Value = "Compra S/F " + dtCompra["NFactura"];
                        dgvKardex.Rows[i + 1].Cells[2].Value = dtCompra["CANTIDAD"];
                        dgvKardex.Rows[i + 1].Cells[3].Value = dtCompra["PRECIOCOMRPA"];
                        dgvKardex.Rows[i + 1].Cells[4].Value = Convert.ToSingle(dgvKardex.Rows[i].Cells[3].Value) * Convert.ToInt32(dgvKardex.Rows[i].Cells[2].Value);
                        notaCredito = false;
                        if (i == dgvKardex.RowCount - 1)
                            dgvKardex.Rows.Add();
                        //dgvKardex.Rows.Insert(1,1);
                    }
                }
                if (datosVenta != null)
                {
                    for (int i = 0; i < datosVenta.Rows.Count; i++)
                    {
                        int j = 01;
                        bool banderaIngreso = false;
                        DataRow dtVenta = datosVenta.Rows[i];
                        for (j = 0; j < dgvKardex.RowCount - 1; j++)
                        {
                            if (Convert.ToDateTime(dtVenta["FECHA"]) < Convert.ToDateTime(dgvKardex.Rows[j].Cells[0].Value))
                            {
                                int numeroFactura = Convert.ToInt32(dtVenta["NFactura"]), serie1 = Convert.ToInt32(dtVenta["SUCURSAL"]), serie2 = Convert.ToInt32(dtVenta["CAJA"]);
                                dgvKardex.Rows.Insert(j, 1);
                                dgvKardex.Rows[j].Cells[0].Value = dtVenta["FECHA"];
                                dgvKardex.Rows[j].Cells[1].Value = "Venta S/F " + serie1.ToString("D3") + serie2.ToString("D3") + numeroFactura.ToString("D9");
                                dgvKardex.Rows[j].Cells[5].Value = dtVenta["CANTIDAD"];
                                if (Convert.ToString(dgvKardex.Rows[j - 1].Cells[9].Value) == "0")
                                    dgvKardex.Rows[j].Cells[6].Value = dtVenta["PRECIO"];
                                else
                                    dgvKardex.Rows[j].Cells[6].Value = dgvKardex.Rows[j - 1].Cells[9].Value;
                                dgvKardex.Rows[j].Cells[7].Value = Convert.ToSingle(dgvKardex.Rows[j].Cells[6].Value) * Convert.ToSingle(dgvKardex.Rows[j].Cells[5].Value);
                                banderaIngreso = true;
                                notaCredito = false;
                                break;
                            }
                            if (Convert.ToString(dgvKardex.Rows[j + 1].Cells[1].Value) == "")
                            {
                                j++;
                                break;
                            }
                        }
                        if (!banderaIngreso)
                        {
                            if (j == dgvKardex.RowCount - 1)
                                dgvKardex.Rows.Add();
                            int numeroFactura = Convert.ToInt32(dtVenta["NFactura"]), serie1 = Convert.ToInt32(dtVenta["SUCURSAL"]), serie2 = Convert.ToInt32(dtVenta["CAJA"]);
                            //dgvKardex.Rows.Insert(, 1);
                            dgvKardex.Rows[j].Cells[0].Value = dtVenta["FECHA"];
                            dgvKardex.Rows[j].Cells[1].Value = "Venta S/F " + serie1.ToString("D3") + serie2.ToString("D3") + numeroFactura.ToString("D9");
                            dgvKardex.Rows[j].Cells[5].Value = dtVenta["CANTIDAD"];
                            if (Convert.ToString(dgvKardex.Rows[j - 1].Cells[9].Value) == "0")
                                dgvKardex.Rows[j].Cells[6].Value = dtVenta["PRECIO"];
                            else
                                dgvKardex.Rows[j].Cells[6].Value = dgvKardex.Rows[j - 1].Cells[9].Value;
                            dgvKardex.Rows[j].Cells[7].Value = Convert.ToSingle(dgvKardex.Rows[j].Cells[6].Value) * Convert.ToSingle(dgvKardex.Rows[j].Cells[5].Value);
                            notaCredito = false;
                        }
                        calculoExistecia();
                    }
                }
                if (datosNotaCredito != null)
                {
                    for (int i = 0; i < datosNotaCredito.Rows.Count; i++)
                    {
                        int j = 0;
                        bool banderaIngreso = false;
                        DataRow dtNotaCredito = datosNotaCredito.Rows[i];
                        for (j = 0; j < dgvKardex.RowCount - 1; j++)
                        {
                            if (Convert.ToString(dtNotaCredito["PORCENTAJE"]) != "0" || Convert.ToString(dtNotaCredito["CANTIDAD"]) != "0")
                            {
                                if (Convert.ToDateTime(dtNotaCredito["FECHA"]) < Convert.ToDateTime(dgvKardex.Rows[j].Cells[0].Value))
                                {
                                    int numeroFactura = Convert.ToInt32(dtNotaCredito["NUMERO"]), serie1 = Convert.ToInt32(dtNotaCredito["SERIE1"]), serie2 = Convert.ToInt32(dtNotaCredito["SERIE2"]);
                                    dgvKardex.Rows.Insert(j, 1);
                                    dgvKardex.Rows[j].Cells[0].Value = dtNotaCredito["FECHA"];
                                    dgvKardex.Rows[j].Cells[1].Value = "D/Compra S/NC " + serie1.ToString("D3") + serie2.ToString("D3") + numeroFactura.ToString("D9");
                                    //dgvKardex.Rows[j].Cells[5].Value = dtNotaCredito["CANTIDAD"];
                                    dgvKardex.Rows[j].Cells[6].Value = dtNotaCredito["PRECIOCOMRPA"];
                                    if (Convert.ToString(dtNotaCredito["PORCENTAJE"]) != "0")
                                    {
                                        string porcentaje = Convert.ToString(dtNotaCredito["PORCENTAJE"]);
                                        dgvKardex.Rows[j].Cells[5].Value = dtNotaCredito["CANTCOMPRA"];
                                        float por = ((Convert.ToSingle(dgvKardex.Rows[j].Cells[6].Value) * Convert.ToSingle(dgvKardex.Rows[j].Cells[5].Value)) * Convert.ToSingle(porcentaje) / 100);
                                        dgvKardex.Rows[j].Cells[7].Value = por;
                                        notaCredito = true;
                                    }
                                    else if (Convert.ToString(dtNotaCredito["CANTIDAD"]) != "0")
                                    {
                                        dgvKardex.Rows[j].Cells[5].Value = dtNotaCredito["CANTIDAD"];
                                        dgvKardex.Rows[j].Cells[7].Value = Convert.ToSingle(dgvKardex.Rows[j].Cells[6].Value) * Convert.ToInt32(dgvKardex.Rows[j].Cells[5].Value);
                                        notaCredito = false;
                                    }
                                    banderaIngreso = true;
                                    break;
                                }
                                if (Convert.ToString(dgvKardex.Rows[j + 1].Cells[1].Value) == "")
                                {
                                    j++;
                                    break;
                                }
                            }
                        }
                        if (!banderaIngreso)
                        {
                            if (Convert.ToString(dtNotaCredito["PORCENTAJE"]) != "0" || Convert.ToString(dtNotaCredito["CANTIDAD"]) != "0")
                            {
                                if (j == dgvKardex.RowCount - 1)
                                    dgvKardex.Rows.Add();
                                int numeroFactura = Convert.ToInt32(dtNotaCredito["NUMERO"]), serie1 = Convert.ToInt32(dtNotaCredito["SERIE1"]), serie2 = Convert.ToInt32(dtNotaCredito["SERIE2"]);
                                //dgvKardex.Rows.Insert(, 1);
                                dgvKardex.Rows[j].Cells[0].Value = dtNotaCredito["FECHA"];
                                dgvKardex.Rows[j].Cells[1].Value = "D/Compra S/NC " + serie1.ToString("D3") + serie2.ToString("D3") + numeroFactura.ToString("D9");
                                //dgvKardex.Rows[j].Cells[5].Value = dtNotaCredito["CANTIDAD"];
                                dgvKardex.Rows[j].Cells[6].Value = dtNotaCredito["PRECIOCOMRPA"];
                                if (Convert.ToString(dtNotaCredito["PORCENTAJE"]) != "0")
                                {
                                    string porcentaje = Convert.ToString(dtNotaCredito["PORCENTAJE"]);
                                    dgvKardex.Rows[j].Cells[5].Value = dtNotaCredito["CANTCOMPRA"];
                                    float por = ((Convert.ToSingle(dgvKardex.Rows[j].Cells[6].Value) * Convert.ToSingle(dgvKardex.Rows[j].Cells[5].Value)) * Convert.ToSingle(porcentaje) / 100);
                                    dgvKardex.Rows[j].Cells[7].Value = por;
                                    notaCredito = true;
                                }
                                else if (Convert.ToString(dtNotaCredito["CANTIDAD"]) != "0")
                                {
                                    dgvKardex.Rows[j].Cells[5].Value = dtNotaCredito["CANTIDAD"];
                                    dgvKardex.Rows[j].Cells[7].Value = Convert.ToSingle(dgvKardex.Rows[j].Cells[6].Value) * Convert.ToInt32(dgvKardex.Rows[j].Cells[5].Value);
                                    notaCredito = false;
                                }
                            }
                        }
                        calculoExistecia();
                    }
                }
                //eliminaVacio();
            }
            else
                MessageBox.Show("Ingrese el producto.");
        }
        //calcular la existencia
        public void eliminaVacio()
        {
            for (int i = 0; i < dgvKardex.RowCount - 1; i++)
            {
                if (Convert.ToString(dgvKardex.Rows[i].Cells[0].Value) == "")
                {
                    dgvKardex.Rows.Remove(dgvKardex.Rows[i]);
                }
            }
        }
        public void totales()
        {
            float cantidadEntrada = 0, cantSalida = 0, totalEntrada = 0, totalSalida = 0;
            for (int i = 0; i < dgvKardex.RowCount - 1; i++)
            {
                // cantidadEntrada += Convert.toflo
            }
        }
        public void calculoExistecia()
        {
            for (int i = 1; i < dgvKardex.RowCount - 1; i++)
            {
                string[] tipo = Convert.ToString(dgvKardex.Rows[i].Cells[1].Value).Split(' ');
                if (tipo[0] == "Compra")
                {
                    if (i == 0)
                    {
                        dgvKardex.Rows[i].Cells[8].Value = dgvKardex.Rows[i].Cells[2].Value;
                        dgvKardex.Rows[i].Cells[9].Value = dgvKardex.Rows[i].Cells[3].Value;
                        dgvKardex.Rows[i].Cells[10].Value = dgvKardex.Rows[i].Cells[4].Value;
                    }
                    else
                    {
                        if (Convert.ToString(dgvKardex.Rows[i - 1].Cells[10].Value) == "0")
                        {
                            dgvKardex.Rows[i].Cells[8].Value = Convert.ToSingle(dgvKardex.Rows[i].Cells[2].Value) + Convert.ToSingle(dgvKardex.Rows[i - 1].Cells[8].Value);
                            dgvKardex.Rows[i].Cells[9].Value = dgvKardex.Rows[i].Cells[3].Value;
                            dgvKardex.Rows[i].Cells[10].Value = Convert.ToSingle(dgvKardex.Rows[i].Cells[9].Value) * Convert.ToSingle(dgvKardex.Rows[i].Cells[8].Value);
                        }
                        else
                        {
                            dgvKardex.Rows[i].Cells[8].Value = Convert.ToSingle(dgvKardex.Rows[i].Cells[2].Value) + Convert.ToSingle(dgvKardex.Rows[i - 1].Cells[8].Value);
                            dgvKardex.Rows[i].Cells[10].Value = Convert.ToSingle(dgvKardex.Rows[i].Cells[4].Value) + Convert.ToSingle(dgvKardex.Rows[i - 1].Cells[10].Value);
                            dgvKardex.Rows[i].Cells[9].Value = Convert.ToSingle(dgvKardex.Rows[i].Cells[10].Value) / Convert.ToSingle(dgvKardex.Rows[i].Cells[8].Value);
                        }
                    }
                }
                if (tipo[0] == "Venta")
                {
                    if (i == 0)
                    {
                        dgvKardex.Rows[i].Cells[8].Value = dgvKardex.Rows[i].Cells[5].Value;
                        dgvKardex.Rows[i].Cells[9].Value = dgvKardex.Rows[i].Cells[6].Value;
                        dgvKardex.Rows[i].Cells[10].Value = dgvKardex.Rows[i].Cells[7].Value;
                    }
                    else
                    {
                        if (Convert.ToString(dgvKardex.Rows[i - 1].Cells[10].Value) == "0")
                        {
                            dgvKardex.Rows[i].Cells[8].Value = Convert.ToSingle(dgvKardex.Rows[i - 1].Cells[8].Value) - Convert.ToSingle(dgvKardex.Rows[i].Cells[5].Value);
                            dgvKardex.Rows[i].Cells[9].Value = dgvKardex.Rows[i].Cells[6].Value;
                            dgvKardex.Rows[i].Cells[10].Value = Convert.ToSingle(dgvKardex.Rows[i].Cells[9].Value) * Convert.ToSingle(dgvKardex.Rows[i].Cells[8].Value);
                        }
                        else
                        {
                            dgvKardex.Rows[i].Cells[8].Value = Convert.ToSingle(dgvKardex.Rows[i - 1].Cells[8].Value) - Convert.ToSingle(dgvKardex.Rows[i].Cells[5].Value);
                            dgvKardex.Rows[i].Cells[10].Value = Convert.ToSingle(dgvKardex.Rows[i - 1].Cells[10].Value) - Convert.ToSingle(dgvKardex.Rows[i].Cells[7].Value);
                            dgvKardex.Rows[i].Cells[9].Value = Convert.ToSingle(dgvKardex.Rows[i].Cells[10].Value) / Convert.ToSingle(dgvKardex.Rows[i].Cells[8].Value);
                        }
                    }
                }
                if (tipo[0] == "D/Compra")
                {
                    if (i == 0)
                    {
                        dgvKardex.Rows[i].Cells[8].Value = dgvKardex.Rows[i].Cells[5].Value;
                        dgvKardex.Rows[i].Cells[9].Value = dgvKardex.Rows[i].Cells[6].Value;
                        dgvKardex.Rows[i].Cells[10].Value = dgvKardex.Rows[i].Cells[7].Value;
                    }
                    else
                    {
                        if (Convert.ToString(dgvKardex.Rows[i - 1].Cells[10].Value) == "0" && !notaCredito)
                        {
                            dgvKardex.Rows[i].Cells[8].Value = Convert.ToSingle(dgvKardex.Rows[i - 1].Cells[8].Value) - Convert.ToSingle(dgvKardex.Rows[i].Cells[5].Value);
                            dgvKardex.Rows[i].Cells[9].Value = dgvKardex.Rows[i].Cells[6].Value;
                            dgvKardex.Rows[i].Cells[10].Value = Convert.ToSingle(dgvKardex.Rows[i].Cells[9].Value) * Convert.ToSingle(dgvKardex.Rows[i].Cells[8].Value);
                        }
                        else if (Convert.ToString(dgvKardex.Rows[i - 1].Cells[10].Value) != "0" && !notaCredito)
                        {
                            dgvKardex.Rows[i].Cells[8].Value = Convert.ToSingle(dgvKardex.Rows[i - 1].Cells[8].Value) - Convert.ToSingle(dgvKardex.Rows[i].Cells[5].Value);
                            dgvKardex.Rows[i].Cells[10].Value = Convert.ToSingle(dgvKardex.Rows[i - 1].Cells[10].Value) - Convert.ToSingle(dgvKardex.Rows[i].Cells[7].Value);
                            dgvKardex.Rows[i].Cells[9].Value = Convert.ToSingle(dgvKardex.Rows[i].Cells[10].Value) / Convert.ToSingle(dgvKardex.Rows[i].Cells[8].Value);
                        }
                        else if (notaCredito)
                        {
                            dgvKardex.Rows[i].Cells[8].Value = Convert.ToSingle(dgvKardex.Rows[i - 1].Cells[8].Value);
                            dgvKardex.Rows[i].Cells[10].Value = Convert.ToSingle(dgvKardex.Rows[i - 1].Cells[10].Value) - Convert.ToSingle(dgvKardex.Rows[i].Cells[7].Value);
                            dgvKardex.Rows[i].Cells[9].Value = Convert.ToSingle(dgvKardex.Rows[i].Cells[10].Value) / Convert.ToSingle(dgvKardex.Rows[i].Cells[8].Value);
                        }
                    }
                }
            }
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvKardex.Rows[0].Cells[0].Value != null)
            {
                if (Funcion.ExportarDataGridViewExcel(dgvKardex, 0))
                {
                    MessageBox.Show("Reporte creado con exito.");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al crear el reporte.");
                }

            }
        }
        bool consultoFormularioExterno = false;
        private void FrmKardex_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                switch (e.KeyCode)
                {
                    case Keys.F6:
                        Program.banderaProductosConsultarKardex = true;
                        FrmConsultarProducto FrmConsultarProduct = new FrmConsultarProducto();
                        FrmConsultarProduct.ShowDialog();
                        txtProducto.Focus();
                        string[] detalleProductoBusq = CodigoBarraConsultaProducto.Split(';');
                        txtProducto.Text = detalleProductoBusq[0];
                        LblNombreProducto.Text = detalleProductoBusq[1];
                        LblNombreProducto.Visible = true;
                        consultoFormularioExterno = true;
                        btnGenerarKardex_Click(null, null);
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnGenerarKardex_Click(null, null);
            }
        }
    }
}
