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
    public partial class FrmDetalleCP : Form
    {
        string IDProveedor = "";
        string NombreProveedor = "";
        string FechaHasta = "";
        string FechaDesde = "";
        Consultas objConsulta = new Consultas();

        int FilaDESCUENTOSADICIONALES = 0;

        public FrmDetalleCP(string IDProveedor, string NombreProveedor, string FechaHasta, string FechaDesde)
        {
            InitializeComponent();
            this.IDProveedor = IDProveedor;
            this.NombreProveedor = NombreProveedor;
            this.FechaHasta = FechaHasta;
            this.FechaDesde = FechaDesde;
        }

        private void FrmDetalleCP_Load(object sender, EventArgs e)
        {
            LblNombreProveedor.Text = NombreProveedor;
            for (int i = 0; i < 20; i++)
            {
                dgvDetalleCP.Rows.Add();
            }

            string sentenciaCompra = "Select * from Vista_EncabezadoCompra_Cartera where FECHAORDENCOMPRA between '" + FechaDesde + "' and '" + FechaHasta + "' AND IDPROVEEDOR = '" + IDProveedor + "'";
            string sentenciaRetencion = "Select * from Vista_EncabezadoOrdenGiro_Cartera where FECHAORDENGIRO between '" + FechaDesde + "' and '" + FechaHasta + "' AND IDPROVEEDOR = '" + IDProveedor + "' AND ESTADO = '1'";
            string sentenciaNotaCredito = "Select * from Vista_EncabezadoNotaCredito_Cartera where FECHA   between '" + FechaDesde + "' and '" + FechaHasta + "' AND IDPROVEEDOR = '" + IDProveedor + "'  AND ESTADO = '1'";



            DataTable dtCompra = objConsulta.BoolDataTable(sentenciaCompra);
            DataTable dtRetencion = objConsulta.BoolDataTable(sentenciaRetencion);
            DataTable dtNotaCredito = objConsulta.BoolDataTable(sentenciaNotaCredito);

            //AGREGAR LAS COMPRAS
            if (dtCompra.Rows.Count > 0)
            {
                for (int i = 0; i < dtCompra.Rows.Count; i++)
                {
                    DataRow rowCompra = dtCompra.Rows[i];

                    if (i == dgvDetalleCP.RowCount - 1)
                        dgvDetalleCP.Rows.Add();

                    dgvDetalleCP.Rows[i].Cells[0].Value = "COMPRA - " + rowCompra[3].ToString() + rowCompra[4].ToString() + rowCompra[5].ToString(); //Detalle
                    dgvDetalleCP.Rows[i].Cells[1].Value = rowCompra[2]; //Debe
                    //dgvDetalleCP.Rows[i].Cells[2].Value = rowCompra[0]; // Haber
                    dgvDetalleCP.Rows[i].Cells[3].Value = rowCompra[1]; //Fecha

                }
            }
            //FIN AGREGAR LAS COMPRAS



            //AGREGAR LAS RETENCIONES
            if (dtRetencion.Rows.Count > 0)
            {
                for (int i = 0; i < dtRetencion.Rows.Count; i++)
                {
                    DataRow rowRetencion = dtRetencion.Rows[i];
                    if (i == dgvDetalleCP.RowCount - 1)
                        dgvDetalleCP.Rows.Add();

                    for (int j = 0; j < dgvDetalleCP.RowCount - 1; j++)
                    {
                        if (Convert.ToDateTime(rowRetencion["FECHAORDENGIRO"]) < Convert.ToDateTime(dgvDetalleCP.Rows[j].Cells[3].Value))
                        {
                            ///Inicio Detalle OrdenGiro
                            int IDOrdenGiro = Convert.ToInt32(rowRetencion[3]);
                            Double Monto = 0;
                            string sentenciaDetalleRetencion = "Select SUM(MONTO) as MontoRetencion from TbDetalleOrdenGiro where IDENCABEZADOORDENGIRO = " + IDOrdenGiro + "";
                            DataTable dtDetalleRetencion = objConsulta.BoolDataTable(sentenciaDetalleRetencion);
                            for (int k = 0; k < dtDetalleRetencion.Rows.Count; k++)
                            {
                                DataRow rowDetalleRetencion = dtDetalleRetencion.Rows[k];
                                if (rowDetalleRetencion[0] != System.DBNull.Value)
                                {
                                    Monto += Convert.ToDouble(rowDetalleRetencion[0]);
                                }
                            }
                            ///Fin Detalle OrdenGiro

                            dgvDetalleCP.Rows.Insert(j, 1);
                            dgvDetalleCP.Rows[j].Cells[0].Value = "RETENCION - " + Convert.ToInt32(rowRetencion[4]).ToString("D3") + Convert.ToInt32(rowRetencion[5]).ToString("D3") + Convert.ToInt32(rowRetencion[6]).ToString("D9"); //Detalle
                            //dgvDetalleCP.Rows[j].Cells[1].Value = Monto; //Debe
                            dgvDetalleCP.Rows[j].Cells[2].Value = Monto; // Haber
                            dgvDetalleCP.Rows[j].Cells[3].Value = rowRetencion[1]; //Fecha
                            break;
                        }
                    }

                }
            }
            //FIN AGREGAR LAS RETENCIONES


            //AGREGAR LAS NOTA CREDITO

            if (dtNotaCredito.Rows.Count > 0)
            {
                for (int i = 0; i < dtNotaCredito.Rows.Count; i++)
                {
                    DataRow rowNotaCredito = dtNotaCredito.Rows[i];

                    if (i == dgvDetalleCP.RowCount - 1)
                        dgvDetalleCP.Rows.Add();

                    for (int j = 0; j < dgvDetalleCP.RowCount - 1; j++)
                    {
                        if (Convert.ToDateTime(rowNotaCredito["FECHA"]) < Convert.ToDateTime(dgvDetalleCP.Rows[j].Cells[3].Value))
                        {
                            dgvDetalleCP.Rows.Insert(j, 1);
                            dgvDetalleCP.Rows[j].Cells[0].Value = "NOTA CREDITO - " + Convert.ToInt32(rowNotaCredito[3]).ToString("D3") + Convert.ToInt32(rowNotaCredito[4]).ToString("D3") + Convert.ToInt32(rowNotaCredito[5]).ToString("D9"); //Detalle
                            //dgvDetalleCP.Rows[j].Cells[1].Value = rowNotaCredito[2]; //Debe
                            dgvDetalleCP.Rows[j].Cells[2].Value = rowNotaCredito[2]; // Haber
                            dgvDetalleCP.Rows[j].Cells[3].Value = rowNotaCredito[1]; // Fecha
                            break;
                        }
                    }
                }
            }


            //FIN AGREGAR LAS NOTA CREDITO


            //AGREGAR VARIOS
            for (int i = 0; i < dgvDetalleCP.RowCount - 1; i++)
            {
                if (Convert.ToString(dgvDetalleCP.Rows[i].Cells[0].Value) == "")
                {
                    if (i == dgvDetalleCP.RowCount - 1)
                        dgvDetalleCP.Rows.Add();
                    dgvDetalleCP.Rows[i].Cells[0].Value = "DESCUENTOS ADICIONALES"; //Detalle
                    //dgvDetalleCP.Rows[i].Cells[2].Value = "0,00"; // Haber
                    FilaDESCUENTOSADICIONALES = i;
                    foreach (DataGridViewRow row in dgvDetalleCP.Rows)
                    {

                        if (((row.Index == i)))
                        {
                            dgvDetalleCP.Rows[row.Index].Cells[4].ReadOnly = false;
                            dgvDetalleCP.Rows[row.Index].Cells[0].ReadOnly = false;
                            dgvDetalleCP.Rows[row.Index].Cells[2].ReadOnly = false;
                        }
                        else
                        {
                            if (Convert.ToString(dgvDetalleCP.Rows[row.Index].Cells[0].Value) != "")
                            {
                                dgvDetalleCP.Rows[row.Index].Cells[4].ReadOnly = false;
                            }
                        }
                            

                    }
                    break;
                }
            }
            //FIN AGREGAR VARIOS

            Funcion.HabilitarColumnaDatagridview(dgvDetalleCP, 4);


            dgvDetalleCP.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalleCP.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            CalcularDEBE_HABER_TOTAL(false);


        }

        bool estadoValorAUX = true;

        public void CalcularDEBE_HABER_TOTAL(bool estadoValor)
        {
            estadoValorAUX = false;
            ///SUMAR DEBE,HABER y TOTAL
            Double totalDEBE = 0;
            Double totalHABER = 0;


            if (estadoValor)
            {
                for (int i = 0; i < dgvDetalleCP.RowCount - 1; i++)
                {
                    if (Convert.ToString(dgvDetalleCP.Rows[i].Cells[1].Value) != "")
                        dgvDetalleCP.Rows[i].Cells[1].Value = Funcion.reemplazarcaracterViceversa(dgvDetalleCP.Rows[i].Cells[1].Value.ToString());
                    else if (Convert.ToString(dgvDetalleCP.Rows[i].Cells[2].Value) != "")
                        dgvDetalleCP.Rows[i].Cells[2].Value = Funcion.reemplazarcaracterViceversa(dgvDetalleCP.Rows[i].Cells[2].Value.ToString());
                    else
                        break;
                }
            }



            for (int i = 0; i < dgvDetalleCP.RowCount - 1; i++)
            {
                
                if (dgvDetalleCP.Rows[i].Cells[0].Value != System.DBNull.Value)
                {
                    if (dgvDetalleCP.Rows[i].Cells[1].Value != System.DBNull.Value)
                    {
                        totalDEBE += Convert.ToDouble(Funcion.comprobarnumeroCelda(dgvDetalleCP.Rows[i].Cells[1].Value));
                    }
                    if (dgvDetalleCP.Rows[i].Cells[2].Value != System.DBNull.Value)
                    {
                        totalHABER += Convert.ToDouble(Funcion.comprobarnumeroCelda(dgvDetalleCP.Rows[i].Cells[2].Value));
                    }
                }
                else
                    break;
            }
            TxtTotalDebe.Text = Funcion.reemplazarcaracter(totalDEBE.ToString("N4"));
            TxtTotalHaber.Text = Funcion.reemplazarcaracter(totalHABER.ToString("N4"));
            TxtTotalPagar.Text = Funcion.reemplazarcaracter((totalDEBE - totalHABER).ToString());
            ///FIN SUMAR DEBE,HABER y TOTAL


            for (int i = 0; i < dgvDetalleCP.RowCount - 1; i++)
            {
                if (Convert.ToString(dgvDetalleCP.Rows[i].Cells[1].Value) != "")
                    dgvDetalleCP.Rows[i].Cells[1].Value = Funcion.reemplazarcaracter((Math.Round(Convert.ToDouble(Funcion.comprobarnumeroCelda(dgvDetalleCP.Rows[i].Cells[1].Value)), 4)).ToString("N4"));
                else if (Convert.ToString(dgvDetalleCP.Rows[i].Cells[2].Value) != "")
                    dgvDetalleCP.Rows[i].Cells[2].Value = Funcion.reemplazarcaracter((Math.Round(Convert.ToDouble(Funcion.comprobarnumeroCelda(dgvDetalleCP.Rows[i].Cells[2].Value)), 4)).ToString("N4"));
                else
                    break;
            }

            estadoValorAUX = true;
        }



        private void dgvDetalleCP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == FilaDESCUENTOSADICIONALES && FilaDESCUENTOSADICIONALES != 0 && e.ColumnIndex == 2 && estadoValorAUX)
            {
                //dgvDetalleCP.Rows[FilaDESCUENTOSADICIONALES].Cells[1].Value = "";
                CalcularDEBE_HABER_TOTAL(true);
            }
        }

    }
}