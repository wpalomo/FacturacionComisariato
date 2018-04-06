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
    public partial class FrmInformesCajas : Form
    {
        public FrmInformesCajas()
        {
            InitializeComponent();
        }
        Consultas objConsulta = new Consultas();
        string fechaDesde = "", fechaHasta = "";

        public void arqueoCaja()
        {
            string consulta = "select dp.TOTAPAGAR, CT.ESTACION, ef.FECHA, u.USUARIO, CT.IPESTACION"+
" from TbDetallePago dp, TbEncabezadoFactura ef, TbEmpleado e, TbUsuario u, TbCajasTalonario ct"+
" where dp.IDENCABEZADOFACT = ef.IDFACTURA and ef.IDEMPLEADO = e.IDEMPLEADO and e.IDEMPLEADO = u.IDEMPLEADO and"+
" ef.FECHA between '"+fechaDesde+ "' and '" + fechaHasta + "' and ct.SERIE2 = ef.CAJA and ct.TIPODOCUMENTO = 'FAC' and u.USUARIO != 'admin' ";
            DataTable st = objConsulta.BoolDataTable(consulta);
            if (st.Rows.Count > 0)
            {
                for (int i = 0; i < st.Rows.Count; i++)
                {
                    if (i == dgvInformeCajas.RowCount - 1)
                    {
                        dgvInformeCajas.Rows.Add();
                    }
                    DataRow row = st.Rows[i];
                    dgvInformeCajas.Rows[i].Cells[0].Value = row[3];
                    dgvInformeCajas.Rows[i].Cells[1].Value = Convert.ToDateTime(row[2]).ToShortDateString();
                    dgvInformeCajas.Rows[i].Cells[2].Value = row[0];
                    //dgvInformeCajas.Rows[i].Cells[3].Value = row[3];
                    dgvInformeCajas.Rows[i].Cells[7].Value = row[1];
                    dgvInformeCajas.Rows[i].Cells[8].Value = row[4];                    
                }
            }
        }
        public void saldos() {
            for (int i = 0; i < dgvInformeCajas.RowCount - 1; i++)
            {
                dgvInformeCajas.Rows[i].Cells[4].Value = Math.Round(Convert.ToSingle(dgvInformeCajas.Rows[i].Cells[2].Value) - Convert.ToSingle(dgvInformeCajas.Rows[i].Cells[3].Value), 2);
            }
        }
        public void cierreCaja()
        {
            for (int i = 0; i < dgvInformeCajas.RowCount - 1; i++)
            {
                try {
                    string sql = "select TOTALRECAUDADO from TbCierreCaja cc, TbUsuario u, TbCajasTalonario ct " +
        " where cc.IDUSUARIO = u.IDUSUARIO and cc.CAJA = ct.SERIE2 and u.USUARIO = '" + dgvInformeCajas.Rows[i].Cells[0].Value + "'  and ct.ESTACION = '" + dgvInformeCajas.Rows[i].Cells[7].Value + "' and u.USUARIO != 'admin' " +
        " and cc.FECHA = '" + Funcion.reemplazarcaracterFecha(Convert.ToString(dgvInformeCajas.Rows[i].Cells[1].Value)) + "'";
                    DataTable dt = new DataTable();
                    dt = objConsulta.BoolDataTable(sql);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        dgvInformeCajas.Rows[i].Cells[5].Value = row[0];
                        dgvInformeCajas.Rows[i].Cells[6].Value = Math.Round(Convert.ToSingle(dgvInformeCajas.Rows[i].Cells[5].Value) - Convert.ToSingle(dgvInformeCajas.Rows[i].Cells[2].Value), 2);
                    }
                    if (Convert.ToString(dgvInformeCajas.Rows[i + 1].Cells[0].Value) == "")
                    {
                        break;
                    }
                }
                catch { }
            }
        }

        private void FrmInformesCajas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                dgvInformeCajas.Rows.Add();
            }
                
        }
        public void sumaArqueoCaja()
        {
            for (int i = 0; i < dgvInformeCajas.RowCount - 1; i++)
            {
                for (int j = i + 1; j < dgvInformeCajas.RowCount - 1; j++)
                {
                    if (Convert.ToString(dgvInformeCajas.Rows[j].Cells[0].Value) == "")
                    {
                        break;
                    }
                    string usuario1 = Convert.ToString(dgvInformeCajas.Rows[i].Cells[0].Value);
                    string usuario2 = Convert.ToString(dgvInformeCajas.Rows[j].Cells[0].Value);
                    string fecha1 = Convert.ToString(dgvInformeCajas.Rows[i].Cells[1].Value);
                    string fecha2 = Convert.ToString(dgvInformeCajas.Rows[j].Cells[1].Value);
                    string estacion1 = Convert.ToString(dgvInformeCajas.Rows[i].Cells[7].Value);
                    string estacion2 = Convert.ToString(dgvInformeCajas.Rows[j].Cells[7].Value);
                    if (usuario1 == usuario2 && fecha1 == fecha2 && estacion1 == estacion2)
                    {
                        dgvInformeCajas.Rows[i].Cells[2].Value = Convert.ToSingle(dgvInformeCajas.Rows[i].Cells[2].Value) + Convert.ToSingle(dgvInformeCajas.Rows[j].Cells[2].Value);
                        dgvInformeCajas.Rows.RemoveAt(j);
                        j--;
                    }

                }
            }
            if (dgvInformeCajas.RowCount - 1 < 15)
            {
                for (int i = dgvInformeCajas.RowCount - 1; i < 15; i++)
                {
                    dgvInformeCajas.Rows.Add();
                }
            }
        }
        public void avances()
        {
            string sqlAvance = "SELECT CANTIDAD, FECHA, CAJA, USUARIO FROM TbAvance a, TbUsuario u where a.IDEMPLEADO = u.IDEMPLEADO AND FECHA BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "'";
            DataTable dt = objConsulta.BoolDataTable(sqlAvance);
            if (dt.Rows.Count > 0)
            {
                dgv.DataSource = dt;
            }
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                for (int j = i + 1; j < dgv.RowCount - 1; j++)
                {
                    if (Convert.ToString(dgv.Rows[j].Cells[0].Value) == "")
                    {
                        break;
                    }
                    string usuario1 = Convert.ToString(dgv.Rows[i].Cells[3].Value);
                    string usuario2 = Convert.ToString(dgv.Rows[j].Cells[3].Value);
                    string fecha1 = Convert.ToString(dgv.Rows[i].Cells[1].Value);
                    string fecha2 = Convert.ToString(dgv.Rows[j].Cells[1].Value);
                    string estacion1 = Convert.ToString(dgv.Rows[i].Cells[2].Value);
                    string estacion2 = Convert.ToString(dgv.Rows[j].Cells[2].Value);
                    if (usuario1 == usuario2 && fecha1 == fecha2 && estacion1 == estacion2)
                    {
                        dgv.Rows[i].Cells[0].Value = Convert.ToSingle(dgv.Rows[i].Cells[0].Value) + Convert.ToSingle(dgv.Rows[j].Cells[0].Value);
                        dgv.Rows.RemoveAt(j);
                        j--;
                    }
                }
            }
            //dgv.DataSource = dgv.DataSource;
            for (int i = 0; i < dgvInformeCajas.RowCount - 1; i++)
            {
                for (int j = 0; j < dgv.RowCount - 1; j++)
                {
                    if (Convert.ToString(dgv.Rows[j].Cells[0].Value) == "")
                    {
                        break;
                    }
                    string usuario1 = Convert.ToString(dgvInformeCajas.Rows[i].Cells[0].Value);
                    string usuario2 = Convert.ToString(dgv.Rows[j].Cells[3].Value);
                    string fecha1 = Convert.ToString(dgvInformeCajas.Rows[i].Cells[1].Value);
                    string fecha2 = Convert.ToString(Convert.ToDateTime(dgv.Rows[j].Cells[1].Value).ToShortDateString());
                    string estacion1 = Convert.ToString(dgvInformeCajas.Rows[i].Cells[7].Value);
                    string estacion2 = "CAJA " + Convert.ToString(dgv.Rows[j].Cells[2].Value); ;
                    if (usuario1 == usuario2 && fecha1 == fecha2 && estacion1 == estacion2)
                    {
                        dgvInformeCajas.Rows[i].Cells[3].Value = Convert.ToSingle(dgv.Rows[j].Cells[0].Value);
                        dgv.Rows.RemoveAt(j);
                        j--;
                    }
                }
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvInformeCajas.Rows.Clear();
            for (int i = 0; i < 15; i++)
            {
                dgvInformeCajas.Rows.Add();
            }
            fechaDesde = Convert.ToString(Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToShortDateString()));
            fechaHasta = Convert.ToString(Funcion.reemplazarcaracterFecha(dtpHasta.Value.ToShortDateString()));
            arqueoCaja();
            if (Convert.ToString(dgvInformeCajas.Rows[0].Cells[0].Value) != "")
            {
                sumaArqueoCaja();
                avances();
                saldos();
                cierreCaja();
                for (int i = 0; i < dgvInformeCajas.RowCount - 1; i++)
                {
                    dgvInformeCajas.Rows[i].Cells[2].Value = Funcion.reemplazarcaracter(Convert.ToString(Math.Round(Convert.ToSingle(dgvInformeCajas.Rows[i].Cells[2].Value),2)));
                    dgvInformeCajas.Rows[i].Cells[3].Value = Funcion.reemplazarcaracter(Convert.ToString(Math.Round(Convert.ToSingle(dgvInformeCajas.Rows[i].Cells[3].Value), 2)));
                    dgvInformeCajas.Rows[i].Cells[4].Value = Funcion.reemplazarcaracter(Convert.ToString(Math.Round(Convert.ToSingle(dgvInformeCajas.Rows[i].Cells[4].Value), 2)));
                    dgvInformeCajas.Rows[i].Cells[5].Value = Funcion.reemplazarcaracter(Convert.ToString(Math.Round(Convert.ToSingle(dgvInformeCajas.Rows[i].Cells[5].Value), 2)));
                    dgvInformeCajas.Rows[i].Cells[6].Value = Funcion.reemplazarcaracter(Convert.ToString(Math.Round(Convert.ToSingle(dgvInformeCajas.Rows[i].Cells[6].Value), 2)));
                    if (Convert.ToString(dgvInformeCajas.Rows[i + 1].Cells[0].Value) == "")
                    {
                        break;
                    }
                }
            }
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvInformeCajas.Rows[0].Cells[0].Value != null)
            {
                if (Funcion.ExportarDataGridViewExcel(dgvInformeCajas, 0))
                {
                    MessageBox.Show("Reporte creado con exito.");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al crear el reporte.");
                }

            }
        }
    }
}
