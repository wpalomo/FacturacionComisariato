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

namespace Comisariato.Formularios.Cartera
{
    public partial class FrmCuentasPorPagar : Form
    {
        public FrmCuentasPorPagar()
        {
            InitializeComponent();
        }
        FrmDetalleCP FrmDetalleCP;
        Consultas objConsulta = new Consultas();
        private void FrmCuentasPorPagar_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
            {
                dgvCuentasPorPagar.Rows.Add();
            }
            rbActivos.Checked = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmDetalleCP = null;
            if (Convert.ToString(dgvCuentasPorPagar.CurrentRow.Cells[0].Value) != "")
            {
                if (FrmDetalleCP == null || FrmDetalleCP.IsDisposed)
                {
                    FrmDetalleCP = new FrmDetalleCP(dgvCuentasPorPagar.CurrentRow.Cells[4].Value.ToString(), dgvCuentasPorPagar.CurrentRow.Cells[0].Value.ToString(), FechaHasta, FechaDesde);
                    FrmDetalleCP.ShowDialog();

                }
            }
        }

        string FechaHasta = "";
        string FechaDesde = "";

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sqlCompras = "select p.IDPROVEEDOR as IDProveedor, p.NOMBRES as Nombre, ec.TOTAL as Total, " +
                                " DATEADD(MM, 1, FECHAORDENCOMPRA) as Fecha_Vence, DATEDIFF(dd, FECHAORDENCOMPRA, DATEADD(MM, 1, FECHAORDENCOMPRA)) as Dias " +
                                " from TbEncabezadoyPieCompra ec, TbProveedor p " +
                                " where ec.IDPROVEEDOR = p.IDPROVEEDOR and ec.PAGADO = 'False' and ec.FECHAORDENCOMPRA between '" + Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToShortDateString()) + "' and '" + Funcion.reemplazarcaracterFecha(dtpHasta.Value.ToShortDateString()) + "'" +
                                " and (p.NOMBRES like '%" + txtConsultar.Text + "%' OR p.IDENTIFICACION like '%" + txtConsultar.Text +"%') order by ec.FECHAORDENCOMPRA ASC";

            FechaHasta = dtpHasta.Value.ToShortDateString();
            FechaDesde = dtpDesde.Value.ToShortDateString();

            DataTable dtCompra = objConsulta.BoolDataTable(sqlCompras);
            if (dtCompra.Rows.Count > 0)
            {
                
                dgvCuentasPorPagar.Rows.Clear();
                for (int i = 0; i < 25; i++)
                {
                    dgvCuentasPorPagar.Rows.Add();
                }
                for (int i = 0; i < dtCompra.Rows.Count; i++)
                {
                    DataRow rowCompra = dtCompra.Rows[i];
                    if (i == dgvCuentasPorPagar.RowCount - 1)
                        dgvCuentasPorPagar.Rows.Add();
                    if (Convert.ToString(dgvCuentasPorPagar.Rows[0].Cells[0].Value) == "")
                    {
                        dgvCuentasPorPagar.Rows[0].Cells[0].Value = rowCompra[1];
                        dgvCuentasPorPagar.Rows[0].Cells[1].Value = rowCompra[2];
                        dgvCuentasPorPagar.Rows[0].Cells[2].Value = Convert.ToDateTime(rowCompra[3]).ToShortDateString();
                        dgvCuentasPorPagar.Rows[0].Cells[3].Value = rowCompra[4];
                        dgvCuentasPorPagar.Rows[0].Cells[4].Value = rowCompra[0];
                    }
                    else
                    {
                        for (int j = 0; j < dgvCuentasPorPagar.RowCount - 1; j++)
                        {
                            if (Convert.ToString(dgvCuentasPorPagar.Rows[j].Cells[0].Value) == Convert.ToString(rowCompra[1]))
                            {
                                dgvCuentasPorPagar.Rows[j].Cells[1].Value = Convert.ToSingle(dgvCuentasPorPagar.Rows[j].Cells[1].Value) + Convert.ToSingle(rowCompra[2]);
                                break;
                            }
                            else if (Convert.ToString(dgvCuentasPorPagar.Rows[j].Cells[0].Value) == "")
                            {
                                dgvCuentasPorPagar.Rows[j].Cells[0].Value = rowCompra[1];
                                dgvCuentasPorPagar.Rows[j].Cells[1].Value = rowCompra[2];
                                dgvCuentasPorPagar.Rows[j].Cells[2].Value = Convert.ToDateTime(rowCompra[3]).ToShortDateString();
                                dgvCuentasPorPagar.Rows[j].Cells[3].Value = rowCompra[4];
                                dgvCuentasPorPagar.Rows[j].Cells[4].Value = rowCompra[0];
                                break;
                            }
                            //if (Convert.ToString(dgvCuentasPorPagar.Rows[j].Cells[0].Value) == "")
                            //    break;
                        }
                    }
                }
            }


            for (int i = 0; i < dgvCuentasPorPagar.RowCount - 1; i++)
            {
                if (Convert.ToString(dgvCuentasPorPagar.Rows[i].Cells[0].Value) != "")
                {
                    dgvCuentasPorPagar.Rows[i].Cells[1].Value = Funcion.reemplazarcaracter((Math.Round(Convert.ToDouble(dgvCuentasPorPagar.Rows[i].Cells[1].Value), 4)).ToString("N4"));
                }

                else
                    break;
            }
            dgvCuentasPorPagar.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void dgvCuentasPorPagar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToString(dgvCuentasPorPagar.CurrentRow.Cells[0].Value) != "")
            {
                btnModificar.Enabled = true;
                BtnPagar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
                BtnPagar.Enabled = false;
            }
        }
    }
}
