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
    public partial class FrmInformeNotaCredito : Form
    {
        public FrmInformeNotaCredito()
        {
            InitializeComponent();
        }
        Consultas objConsultas = new Consultas();
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
                Funcion.dosDecimales(ref dgvDatosProducto, 4, 6);
            }
            catch
            { }
        }
        public void consultaNC()
        {
            bool ver = false;
            if (rbActivos.Checked)
                ver = true;
            else if (rbAnulados.Checked)
                ver = false;
            string sql = "select FECHA, SERIE1+''+SERIE2+''+NUMERO AS NOTACREDITO, SERIE1COMPRA+''+SERIE2COMPRA+''+NUMEROCOMPRA AS COMPRA, NOMBRES, TOTALDEVOLUCION, TOTAL, IDENCABEZADONOTACREDITO, IDEMCABEZADOCOMPRA from VistaNotaCredito where NOMBRES LIKE '%" + txtConsultar.Text + "%' AND FECHA BETWEEN '" + Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToShortDateString()) + "' AND '" + Funcion.reemplazarcaracterFecha(dtpHasta.Value.ToShortDateString()) + "' and ESTADO = '" + ver + "'";
            objConsultas.boolLlenarDataGrid(dgvDatosProducto, sql, 25, 7, 0);
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

        private void FrmInformeNotaCredito_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
            {
                dgvDatosProducto.Rows.Add();
            }
        }
    }
}
