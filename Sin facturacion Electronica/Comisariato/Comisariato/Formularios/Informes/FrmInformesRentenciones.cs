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

namespace Comisariato.Formularios.Informes
{
    public partial class FrmInformesRentenciones : Form
    {
        public FrmInformesRentenciones()
        {
            InitializeComponent();
        }
        Consultas objConsulta = new Consultas();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            llenarDgv();
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvInformeRetenciones.Rows[0].Cells[0].Value != null)
            {
                if (Funcion.ExportarDataGridViewExcel(dgvInformeRetenciones,0))
                {
                    MessageBox.Show("Reporte creado con exito.");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al crear el reporte.");
                }

            }
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                dgvInformeRetenciones.Rows.Add();
        }
        public void llenarDgv()
        {
            try
            {
                string sqlBuscar = "select ec.SERIE1 + '' + ec.SERIE2 + '' + ec.NUMERO as Factura, CONVERT(char(10), eo.FECHAORDENGIRO, 110) as Fecha, p.NOMBRES, csri.DESCRIPCION, csri.RETENCION, do.MONTO, tcsri.CODIGO, ec.IDPROVEEDOR " +
                    "    from TbEncabezadoyPieCompra ec, TbDetalleOrdenGiro do, TbEncabezadoOrdenGiro eo, TbCodigoSRI csri, TbTipoCodigoSRI tcsri, TbProveedor p " +
                    "     where ec.IDEMCABEZADOCOMPRA = eo.IDEMCABEZADOCOMPRA and do.IDENCABEZADOORDENGIRO = eo.IDORDENGIRO and do.IDRETENCION = csri.IDCODIGOSRI " +
                    "      and tcsri.IDTIPOCODIGOSRI = csri.IDTIPOCODIGOSRI and p.IDPROVEEDOR = ec.IDPROVEEDOR and eo.FECHAORDENGIRO between '" + Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToString()) + "' and '" + Funcion.reemplazarcaracterFecha(dtpHasta.Value.ToString()) + "' " +
                    " and (p.NOMBRES like '%" + txtConsultar.Text + "%' or csri.DESCRIPCION like '%" + txtConsultar.Text + "%') order by eo.FECHAORDENGIRO";
                DataTable dt = objConsulta.BoolDataTable(sqlBuscar);
                if (dt.Rows.Count > 0)
                {
                    dgvInformeRetenciones.Rows.Clear();
                    for (int i = 0; i < 20; i++)
                        dgvInformeRetenciones.Rows.Add();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];
                        if (i == dgvInformeRetenciones.RowCount - 1)
                            dgvInformeRetenciones.Rows.Add();
                        dgvInformeRetenciones.Rows[i].Cells[0].Value = row["Factura"];
                        dgvInformeRetenciones.Rows[i].Cells[1].Value = row["Fecha"];
                        dgvInformeRetenciones.Rows[i].Cells[2].Value = row["NOMBRES"];
                        dgvInformeRetenciones.Rows[i].Cells[3].Value = row["DESCRIPCION"];
                        dgvInformeRetenciones.Rows[i].Cells[4].Value = row["RETENCION"];
                        dgvInformeRetenciones.Rows[i].Cells[6].Value = row["MONTO"];
                        dgvInformeRetenciones.Rows[i].Cells[7].Value = row["CODIGO"];
                        dgvInformeRetenciones.Rows[i].Cells[8].Value = row["IDPROVEEDOR"];

                        string serie1 = Convert.ToString(row["Factura"]).Substring(0, 3);
                        string serie2 = Convert.ToString(row["Factura"]).Substring(3, 3);
                        string numero = Convert.ToString(row["Factura"]).Substring(6, 9);

                        string sqlBaseImponible = "select SUBTOTAL, TOTALIVA from TbEncabezadoyPieCompra ec where SERIE1 = '" + serie1 + "' and SERIE2 ='" + serie2 + "' and NUMERO = '" + numero + "' and IDPROVEEDOR = " + row["IDPROVEEDOR"] + "";
                        DataTable dtBI = objConsulta.BoolDataTable(sqlBaseImponible);
                        if (dtBI.Rows.Count > 0)
                        {
                            DataRow rowBI = dtBI.Rows[0];
                            string tipo = Convert.ToString(dgvInformeRetenciones.Rows[i].Cells[7].Value);
                            if (tipo == "COD_RET_FUE")
                                dgvInformeRetenciones.Rows[i].Cells[5].Value = rowBI[0];
                            else if (tipo == "COD_RET_IVA")
                                dgvInformeRetenciones.Rows[i].Cells[5].Value = rowBI[1];
                        }
                    }
                }
                else
                {
                    dgvInformeRetenciones.Rows.Clear();
                    for (int i = 0; i < 20; i++)
                        dgvInformeRetenciones.Rows.Add();
                }
            }
            catch { }
        }
    }
}
