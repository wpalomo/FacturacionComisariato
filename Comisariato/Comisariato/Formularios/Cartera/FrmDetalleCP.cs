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
        Pen blackPen;
        Point puntoInicio, puntoFinal;

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
                    dgvDetalleCP.Rows[i].Cells[3].Value = Convert.ToDateTime(rowCompra[1]).ToShortDateString(); //Fecha

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
                        if (Convert.ToDateTime(Funcion.FormarFechaDiaMesAño(rowRetencion["FECHAORDENGIRO"].ToString())) < Convert.ToDateTime(dgvDetalleCP.Rows[j].Cells[3].Value))
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
                            dgvDetalleCP.Rows[j].Cells[3].Value = Convert.ToDateTime(Funcion.FormarFechaDiaMesAño(rowRetencion[1].ToString())).ToShortDateString();//Fecha
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
                            dgvDetalleCP.Rows[row.Index].Cells[1].ReadOnly = true;
                        }
                        else
                        {
                            if (Convert.ToString(dgvDetalleCP.Rows[row.Index].Cells[0].Value) != "")
                            {
                                dgvDetalleCP.Rows[row.Index].Cells[0].ReadOnly = true;
                                dgvDetalleCP.Rows[row.Index].Cells[1].ReadOnly = true;
                                dgvDetalleCP.Rows[row.Index].Cells[2].ReadOnly = true;
                            }
                            else
                                row.ReadOnly = true;
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
                        if(Convert.ToBoolean(dgvDetalleCP.Rows[i].Cells[4].Value))
                            totalDEBE += Convert.ToDouble(Funcion.comprobarnumeroCelda(dgvDetalleCP.Rows[i].Cells[1].Value));
                    }
                    if (dgvDetalleCP.Rows[i].Cells[2].Value != System.DBNull.Value)
                    {
                        if (Convert.ToBoolean(dgvDetalleCP.Rows[i].Cells[4].Value))
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
            if ((e.RowIndex == FilaDESCUENTOSADICIONALES && FilaDESCUENTOSADICIONALES != 0 && e.ColumnIndex == 2 && estadoValorAUX))
            {
                CalcularDEBE_HABER_TOTAL(true);
            }
        }

        private void ChkPagarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPagarTodo.Checked)
            {
                for (int i = 0; i < dgvDetalleCP.RowCount; i++)
                {
                    if (Convert.ToString(dgvDetalleCP.Rows[i].Cells[0].Value) != "")
                        dgvDetalleCP.Rows[i].Cells[4].Value = true;
                    else
                        break;
                }
            }
            else
            {
                for (int i = 0; i < dgvDetalleCP.RowCount; i++)
                {
                    if (Convert.ToString(dgvDetalleCP.Rows[i].Cells[0].Value) != "")
                        dgvDetalleCP.Rows[i].Cells[4].Value = false;
                    else
                        break;
                }
            }
            CalcularDEBE_HABER_TOTAL(true);
        }

        private void dgvDetalleCP_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDetalleCP.IsCurrentCellDirty)
            {
                dgvDetalleCP.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvDetalleCP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleCP.Rows[e.RowIndex].Cells[4].Value != null)
            {
                bool isCellChecked = (bool)dgvDetalleCP.Rows[e.RowIndex].Cells[4].Value;

                if (isCellChecked)
                {
                    CalcularDEBE_HABER_TOTAL(true);
                }
                else
                    CalcularDEBE_HABER_TOTAL(true);
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            ElegirImpresero.AllowSomePages = true;
            ElegirImpresero.ShowHelp = true;
            ElegirImpresero.Document = ImpresionDetallePago;
            DialogResult result = ElegirImpresero.ShowDialog();
            if (result == DialogResult.OK)
                ImpresionDetallePago.Print();
        }
        public void dibujarRayas(ref int y, int sumar, int grosor, int inicio, int fin)
        {
            blackPen = new Pen(Color.Black, grosor);
            puntoInicio = new Point(inicio, y = y + sumar);
            puntoFinal = new Point(fin, y);
        }

        private void ImpresionDetallePago_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                DataTable dte = objConsulta.BoolDataTable("SELECT CELULAR1, CELULAR2 FROM TbEmpresa where IDEMPRESA =" + Program.IDEMPRESA);
                DataRow rowe = dte.Rows[0];
                DataTable dtp = objConsulta.BoolDataTable("select CODIGO, NOMBRES from tbproveedor where IDPROVEEDOR = " + IDProveedor);
                DataRow rowp = dtp.Rows[0];
                //"EL EMPALME, VIA GUAYAS # 207 Y ABDON CALDERON, (04)2961661 - 0998108483
                //imprimirRetencion(e);
                e.Graphics.DrawString("ORDEN DE PAGO #:", new Font("Verdana", 14, FontStyle.Bold), Brushes.Black, 25, 25);
                e.Graphics.DrawString("---", new Font("Verdana", 14, FontStyle.Italic), Brushes.Black, 300, 25);
                e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Verdana", 12, FontStyle.Regular), Brushes.Gray, 625, 25);
                e.Graphics.DrawString(Program.nombreempresa.ToUpper(), new Font("Verdana", 14, FontStyle.Regular), Brushes.Black, 310, 70);
                e.Graphics.DrawString(Program.razonsocialempresa.ToUpper(), new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 320, 90);
                e.Graphics.DrawString("RUC: " + Program.rucempresa, new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 335, 110);
                e.Graphics.DrawString("CIUDAD, DIRECCION, TELEFONO", new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 305, 130);
                e.Graphics.DrawString(Program.direccionempresa.ToUpper()+ ", " + rowe[0] +" - "+ rowe[1], new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 75, 150);
                //string numeroFactura = txtSerie1.Text + '-' + txtSerie2.Text + '-' + txtNumero.Text;
                //e.Graphics.DrawString(numeroFactura, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 175, 110);
                e.Graphics.DrawString("PROVEEDOR: ", new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 25, 170);
                e.Graphics.DrawString(NombreProveedor.ToUpper(), new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 150, 170);
                e.Graphics.DrawString("CODIGO: ", new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 625, 170);
                e.Graphics.DrawString(Convert.ToInt32(rowp[0]).ToString("D4"), new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 710, 170);
                e.Graphics.DrawString("DETALLE", new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 100, 200);
                e.Graphics.DrawString("DEBE", new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 450, 200);
                e.Graphics.DrawString("HABER", new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 575, 200);
                int y = 210;
                dibujarRayas(ref y, 10, 2, 75, 735);
                e.Graphics.DrawLine(blackPen, puntoInicio, puntoFinal);
                y = 230;
                for (int i = 0; i < dgvDetalleCP.RowCount - 1; i++)
                {
                    if (Convert.ToBoolean(dgvDetalleCP.Rows[i].Cells[4].Value))
                    {
                        e.Graphics.DrawString(dgvDetalleCP.Rows[i].Cells[0].Value.ToString(), new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 100, y);
                        if (Convert.ToString(dgvDetalleCP.Rows[i].Cells[1].Value) != "")
                            e.Graphics.DrawString(dgvDetalleCP.Rows[i].Cells[1].Value.ToString(), new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 450, y);
                        else if (Convert.ToString(dgvDetalleCP.Rows[i].Cells[2].Value) != "")
                            e.Graphics.DrawString(dgvDetalleCP.Rows[i].Cells[2].Value.ToString(), new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 575, y);
                        y = y + 20;
                    }
                    if (Convert.ToString(dgvDetalleCP.Rows[i + 1].Cells[0].Value) == "")
                        break;                    
                }
                for (int i = 0; i < y - 200; i++)
                {
                    int yLineas = 200 + i;
                    e.Graphics.DrawString("|", new Font("Verdana", 11, FontStyle.Regular), Brushes.Black, 400, yLineas);
                }
                y = y + 50;
                //dibujarRayas(ref y, 0, 2, 575, 700);
                //e.Graphics.DrawLine(blackPen, puntoInicio, puntoFinal);
                e.Graphics.DrawString("TOTAL A PAGAR $", new Font("Verdana", 10, FontStyle.Regular), Brushes.Black, 450, y);
                e.Graphics.DrawString(TxtTotalPagar.Text, new Font("Verdana", 10, FontStyle.Regular), Brushes.Black, 600, y);
                y = y + 75;
                dibujarRayas(ref y, 5, 2, 35, 215);
                e.Graphics.DrawLine(blackPen, puntoInicio, puntoFinal);
                e.Graphics.DrawString("FIRMA RESPONSABLE", new Font("Verdana", 10, FontStyle.Regular), Brushes.Black, 50, y);
                e.Graphics.DrawString(Program.Usuario, new Font("Verdana", 10, FontStyle.Regular), Brushes.Black, 50, y+13);
                dibujarRayas(ref y, 5, 2, 335, 515);
                e.Graphics.DrawLine(blackPen, puntoInicio, puntoFinal);
                e.Graphics.DrawString("FIRMA COBRADOR", new Font("Verdana", 10, FontStyle.Regular), Brushes.Black, 355, y);
                e.Graphics.DrawString("PERSONA A UBICAR", new Font("Verdana", 10, FontStyle.Regular), Brushes.Black, 350, y + 13);
                e.Graphics.DrawString("C.I.:", new Font("Verdana", 10, FontStyle.Regular), Brushes.Black, 350, y + 26);
                dibujarRayas(ref y, 5, 2, 610, 790);
                e.Graphics.DrawLine(blackPen, puntoInicio, puntoFinal);
                e.Graphics.DrawString("FIRMA SUPERVISOR", new Font("Verdana", 10, FontStyle.Regular), Brushes.Black, 625, y);
            }
            catch (Exception ex) { }
        }
    }
}