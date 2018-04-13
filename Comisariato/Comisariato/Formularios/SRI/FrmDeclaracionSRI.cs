using Comisariato.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace Comisariato.Formularios.SRI
{
    public partial class FrmDeclaracionSRI : Form
    {
        Consultas objConsultas = new Consultas();

        public FrmDeclaracionSRI()
        {
            InitializeComponent();
        }        
        private void FrmDeclaracionSRI_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
                dgvRetencion.Rows.Add();
        }
        private void btnGenerarKardex_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaDesde = Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToShortDateString());
                string fechaHasta = Funcion.reemplazarcaracterFecha(dtpHasta.Value.ToShortDateString());
                //REPORTE VENTA
                string consultaVenta = "select SUM(d.SUBTOTAL0) as Sub0, sum(d.SUBTOTAL12) as Sub12,sum(d.IVA) as Iva, sum(d.TOTAPAGAR) as TotalPagar from TbEncabezadoFactura e, TbDetallePago d" +
                                    " where e.IDFACTURA = d.IDENCABEZADOFACT and(e.FECHA between '" + fechaDesde + "' and '" + fechaHasta + "')";
                DataTable dt = objConsultas.BoolDataTable(consultaVenta);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];
                        txtExentoVenta.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["Sub0"]), 2).ToString("#####0.00"));
                        txtGravadoVenta.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["Sub12"]), 2).ToString("#####0.00"));
                        txtIvaVenta.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["Iva"]), 2).ToString("#####0.00"));
                        txtTotalVenta.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["TotalPagar"]), 2).ToString("#####0.00"));
                    }
                }
                //REPORTE COMPRA
                string consultaCompra = "select SUM(d.SUBTOTAL0) as Sub0, sum(d.SUBTOTALIVA) as Sub12,sum(d.TOTALIVA) as Iva, sum(d.TOTAL) as TotalPagar, sum(d.TOTALICE) as Ice, sum(d.TOTALIRBP) as Irbp" +
                                        " from TbEncabezadoyPieCompra d where d.FECHAORDENCOMPRA between '" + fechaDesde + "' and '" + fechaHasta + "'";
                dt = objConsultas.BoolDataTable(consultaCompra);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];
                        txtExentoCompra.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["Sub0"]), 2).ToString("#####0.00"));
                        txtGravadoCompra.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["Sub12"]), 2).ToString("#####0.00"));
                        txtIvaCompra.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["Iva"]), 2).ToString("#####0.00"));
                        txtTotalCompra.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["TotalPagar"]), 2).ToString("#####0.00"));
                        txtIceCompra.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["Ice"]), 2).ToString("#####0.00"));
                        txtIrbpCompra.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["Irbp"]), 2).ToString("#####0.00"));
                    }
                }
                //REPORTE RETENCION
                string consultaRetencion = "select c.DESCRIPCION, c.RETENCION, do.MONTO, do.IDRETENCION from TbEncabezadoOrdenGiro eo, TbDetalleOrdenGiro do, TbCodigoSRI c where do.IDENCABEZADOORDENGIRO = eo.IDORDENGIRO and " +
                    "eo.FECHAORDENGIRO between '" + dtpDesde.Value.ToShortDateString() + "' and '" + dtpHasta.Value.ToShortDateString() + "' and c.IDCODIGOSRI = do.IDRETENCION";
                objConsultas.boolLlenarDataGrid(dgvRetencion, consultaRetencion, 15, 3, 0);
                for (int i = 0; i < dgvRetencion.RowCount - 1; i++)
                {
                    for (int j = i+1; j < dgvRetencion.RowCount - 1; j++)
                    {
                        if (Convert.ToString(dgvRetencion.Rows[i].Cells[3].Value) == Convert.ToString(dgvRetencion.Rows[j].Cells[3].Value))
                        {
                            if (Convert.ToString(dgvRetencion.Rows[i].Cells[1].Value) != "")
                            {
                                if (Convert.ToString(dgvRetencion.Rows[j].Cells[2].Value) == "")
                                    dgvRetencion.Rows[j].Cells[2].Value = "0";
                                if (Convert.ToString(dgvRetencion.Rows[i].Cells[2].Value) == "")
                                    dgvRetencion.Rows[i].Cells[2].Value = "0";
                                dgvRetencion.Rows[i].Cells[2].Value = Convert.ToSingle(dgvRetencion.Rows[i].Cells[2].Value) + Convert.ToSingle(dgvRetencion.Rows[j].Cells[2].Value);
                                dgvRetencion.Rows.Remove(dgvRetencion.Rows[j]);
                                dgvRetencion.Rows.Add();
                                j--;
                            }
                        }
                        if (Convert.ToString(dgvRetencion.Rows[j + 1].Cells[0].Value) == "")
                            break;
                    }
                    if (Convert.ToString(dgvRetencion.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
                Funcion.dosDecimales(ref dgvRetencion, 2, 3, 0);
                //REPORTE NOTA CREDITO
                string consultaNC = "select SUM(SUBTOTAL0) AS Exento, SUM(SUBTOTAL12) as Gravado, SUM(IVA) as IVA, SUM(TOTALDEVOLUCION) as TOTAL " +
                                    " from TbEncabezadoNotaCredito where FECHA between '"+ fechaDesde +"' and '"+ fechaHasta +"'";
                dt = objConsultas.BoolDataTable(consultaNC);
                if (dt.Rows.Count > 0)
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];
                        txtExentoNC.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["Exento"]), 2).ToString("#####0.00"));
                        txtGravadoNC.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["Gravado"]), 2).ToString("#####0.00"));
                        txtIvaNC.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["IVA"]), 2).ToString("#####0.00"));
                        txtTotalNC.Text = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(row["TOTAL"]), 2).ToString("#####0.00"));
                    }
            }
            catch (Exception)  {}
        }
    }
}