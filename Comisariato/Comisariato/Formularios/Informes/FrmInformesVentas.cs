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
    public partial class FrmInformeVentas : Form
    {
        public FrmInformeVentas()
        {
            InitializeComponent();
        }
        Consultas objConsulta = new Consultas();
        string cadenaGeneral = "select SUCURSAL, CAJA, NFACTURA, FECHA , USUARIO, IDENTIFICACION, NombreCliente, IVA, SUBTOTAL0, SUBTOTAL12, TOTAPAGAR from Vista_InformeVentas", cadeCondicion = "", condicionEntre="", añoDesde = "", 
            fechaDesde = "", añoHasta = "", fechaHasta = "", mesDesde = "", diaDesde = "", mesHasta = "", diaHasta = "", 
            cadenaConsultar = "";

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtConsultar.Text != "")
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    btnConsultar_Click(null, null);
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            obtenerFechas();
            consultaVentas();
            for (int i = 0; i < dgvInformeVentas.RowCount - 1; i++)
            {
                if (Convert.ToString(dgvInformeVentas.Rows[i].Cells[0].Value) != "")
                {
                    for (int j = 7; j < 11; j++)
                        dgvInformeVentas.Rows[i].Cells[j].Value = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgvInformeVentas.Rows[i].Cells[j].Value.ToString())), 2).ToString());
                    if (Convert.ToString(dgvInformeVentas.Rows[i + 1].Cells[0].Value) == "")
                        break;
                }
            }
            Funcion.dosDecimales(ref dgvInformeVentas, 7, 11, 0);
        }
        public void consultaVentas()
        {
            string sql = cadenaGeneral + " where (FECHA between '" + fechaDesde + "' and '" + fechaHasta + "') and (NombreCliente like'%" + txtConsultar.Text + "%' or SUCURSAL like '%" + txtConsultar.Text + "%' or CAJA like '%" + txtConsultar.Text + "%' or NFACTURA like '%" + txtConsultar.Text +"%') and USUARIO != 'admin'";
            objConsulta.boolLlenarDataGrid(dgvInformeVentas, sql, 20, 10, 0);
            if (Convert.ToString(dgvInformeVentas.Rows[0].Cells[0].Value) != "")
            {
                for (int i = 7; i < 11; i++)
                    dgvInformeVentas.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                for (int i = 0; i < 7; i++)
                    dgvInformeVentas.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                for (int i = 0; i < dgvInformeVentas.RowCount - 1; i++)
                {
                    if (Convert.ToString(dgvInformeVentas.Rows[i].Cells[0].Value) != "")
                    {
                        dgvInformeVentas.Rows[i].Cells[0].Value = Convert.ToInt32(dgvInformeVentas.Rows[i].Cells[0].Value).ToString("D3");
                        dgvInformeVentas.Rows[i].Cells[1].Value = Convert.ToInt32(dgvInformeVentas.Rows[i].Cells[1].Value).ToString("D3");
                        dgvInformeVentas.Rows[i].Cells[2].Value = Convert.ToInt32(dgvInformeVentas.Rows[i].Cells[2].Value).ToString("D9");
                        for (int j = 7; j < 10; j++)
                            dgvInformeVentas.Rows[i].Cells[j].Value = Funcion.reemplazarcaracter(dgvInformeVentas.Rows[i].Cells[j].Value.ToString());
                        if (Convert.ToString(dgvInformeVentas.Rows[i + 1].Cells[0].Value) == "")
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                for (int i = 0; i < dgvInformeVentas.RowCount - 1; i++)
                {
                    if (dgvInformeVentas.Rows[i].Cells[0].Value != null)
                    {
                        dgvInformeVentas.Rows[i].Cells[3].Value = Convert.ToDateTime(dgvInformeVentas.Rows[i].Cells[3].Value).ToShortDateString();
                    }
                }
            }
            dgvInformeVentas.Focus();
        }
        private void BtnExportarExcel_Click_1(object sender, EventArgs e)
        {
            if (dgvInformeVentas.Rows[0].Cells[0].Value != null)
            {
                if (Funcion.ExportarDataGridViewExcel(dgvInformeVentas,0))
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
                dgvInformeVentas.Rows.Add();
            cadenaConsultar = cadenaGeneral;
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
