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
    public partial class FrmInformesCompras : Form
    {
        public FrmInformesCompras()
        {
            InitializeComponent();
        }
        Consultas objConsulta = new Consultas();
        string cadenaGeneral = "select SERIE1 +''+ SERIE2 +''+ NUMERO AS SERIES , FECHAORDENCOMPRA, IDENTIFICACION, NOMBRES, TOTALIVA," +
" TOTALICE, TOTALIRBP, SUBTOTAL0, SUBTOTALIVA, TOTAL " +
" from Vista_InformeCompras", añoDesde = "", fechaDesde = "", añoHasta = "", fechaHasta = "", mesDesde = "", diaDesde = "", mesHasta = "", diaHasta = "";
        

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            obtenerFechas();
            consultaCompras();
            for (int i = 0; i < dgvInformeCompras.RowCount - 1; i++)
            {
                if (Convert.ToString(dgvInformeCompras.Rows[i].Cells[0].Value) != "")
                {
                    for (int j = 4; j < 10; j++)
                    dgvInformeCompras.Rows[i].Cells[j].Value = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvInformeCompras.Rows[i].Cells[j].Value.ToString())), 2).ToString());
                    if (Convert.ToString(dgvInformeCompras.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
            Funcion.dosDecimales(ref dgvInformeCompras, 4, 10, 0);
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvInformeCompras.Rows[0].Cells[0].Value != null)
            {
                if (Funcion.ExportarDataGridViewExcel(dgvInformeCompras,0))
                {
                    MessageBox.Show("Reporte creado con exito.");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al crear el reporte.");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvInformeCompras.Rows[0].Cells[0].Value != null)
            {
                if (Funcion.ExportarDataGridViewExcel(dgvInformeCompras,0))
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
                dgvInformeCompras.Rows.Add();
            //cadenaConsultar = cadenaGeneral;
            //llenarDgv();
        }
        public void consultaCompras()
        {
            string sql = cadenaGeneral + " where (FECHAORDENCOMPRA between '" + fechaDesde + "' AND '" + fechaHasta + "') and (IDENTIFICACION like '%" + txtConsultar.Text + "%' or NOMBRES like '%" + txtConsultar.Text + "%' or NUMERO like '%" + txtConsultar.Text + "%' or SERIE2 like '%" + txtConsultar.Text + "%' or SERIE2 like '%" + txtConsultar.Text + "%')";
            objConsulta.boolLlenarDataGrid(dgvInformeCompras, sql, 20, 9, 0);
            if (Convert.ToString(dgvInformeCompras.Rows[0].Cells[0].Value) != "")
            {
                for (int i = 4; i < 10; i++)
                    dgvInformeCompras.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                for (int i = 0; i < 4; i++)
                    dgvInformeCompras.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                for (int i = 0; i < dgvInformeCompras.RowCount - 1; i++)
                {
                    if (Convert.ToString(dgvInformeCompras.Rows[i].Cells[0].Value) != "")
                    {
                        for (int j = 4; j < 10; j++)
                            dgvInformeCompras.Rows[i].Cells[j].Value = Funcion.reemplazarcaracter(dgvInformeCompras.Rows[i].Cells[j].Value.ToString());
                        if (Convert.ToString(dgvInformeCompras.Rows[i + 1].Cells[0].Value) == "")
                            break;
                    }
                    else
                        break;
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
    }
}
