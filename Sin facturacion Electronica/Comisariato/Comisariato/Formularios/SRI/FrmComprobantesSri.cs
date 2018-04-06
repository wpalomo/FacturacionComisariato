using Comisariato.Clases;
using Comisariato.Ride.Retencion;
using Microsoft.Reporting.WebForms;
//using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;



namespace Comisariato.Formularios.SRI
{
    public partial class FrmComprobantesSri : Form
    {
        Consultas objconsul = new Consultas();
        DataTable dtComprobantes;
        DataTable DtDocuemtosXML;


        String RutaXML = "";
        String NombreXML = "";
        String FechaEmision = "";


        string fechaAutorizacion;
        String CbTipoAutorizacionVariable = "";
        String cmbAñoRetencionHechaVariable = "";



        

        delegate void CambiarProgresoDelegado(string nombreXml, string fecha, string contadordevuelta, string contadorRecivida, string contadorautorizado, string contadornoautorizado, string contadorenviados, string contador, string archivosTotales);
        public FrmComprobantesSri()
        {
            InitializeComponent();
            this.Height = Program.tamañoVentanaPrincipal - 75;
            //int width = this.Width;
            this.Width = Program.tamañoVentanaPrincipalWith - 300;
        }

        private void FrmComprobantesSri_Load(object sender, EventArgs e)
        {
            //DataTable dt = objconsul.BoolDataTable("");
            CmbTipoComprobante.SelectedIndex = 0;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void modificarDatagridviweDiseño()
        {
            if (dgvComprobantesErroneos.RowCount >= 1)
            {
                dgvComprobantesErroneos.Columns[8].Visible = false;
                dgvComprobantesErroneos.Columns[9].Visible = false;

                //dgvComprobantesErroneos.Columns[7].DividerWidth = 80;
                dgvComprobantesErroneos.Columns[0].Width = 26;
                dgvComprobantesErroneos.Columns[1].Width = 180;
                dgvComprobantesErroneos.Columns[2].Width = 48;
                dgvComprobantesErroneos.Columns[3].Width = 48;
                dgvComprobantesErroneos.Columns[4].Width = 54;
                dgvComprobantesErroneos.Columns[5].Width = 63;
                dgvComprobantesErroneos.Columns[6].Width = 50;
                dgvComprobantesErroneos.Columns[7].Width = 233;
                dgvComprobantesErroneos.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvComprobantesErroneos.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgvComprobantesErroneos.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvComprobantesErroneos.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvComprobantesErroneos.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvComprobantesErroneos.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvComprobantesErroneos.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvComprobantesErroneos.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvComprobantesErroneos.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvComprobantesErroneos.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public void procesarComprobantesPendientes()
        {
            TxtMensajeError.Text = "";

            if (CmbTipoComprobante.Text == "Factura")
            {
                //MessageBox.Show("factura");
                dtComprobantes = null;
                dtComprobantes = objconsul.BoolDataTable("");
                int cantidadComprobanrt = objconsul.ObtenerValorEntero("SELECT COUNT(*) as TotalComprobantes from VistaComprobantesFactura");
                TxtCantComprobantesPendientes.Text = cantidadComprobanrt.ToString();
                objconsul.BoolCrearDateTableComprobantesErroneos(dgvComprobantesErroneos, "SELECT *  FROM [BDFacturacionElectronica].[dbo].[VistaComprobantesFactura]");

                modificarDatagridviweDiseño();

                //dtComprobantes = Funcion.llenarDataTable_Datagriview(dgvComprobantesErroneos);

            }
            else
            {
                //MessageBox.Show("retención");
                dtComprobantes = null;
                int cantidadComprobanrt = objconsul.ObtenerValorEntero("SELECT COUNT(*) as TotalComprobantes from VistaComprobantesRetencion");
                TxtCantComprobantesPendientes.Text = cantidadComprobanrt.ToString();
                objconsul.BoolCrearDateTableComprobantesErroneos(dgvComprobantesErroneos, "SELECT *  FROM [BDFacturacionElectronica].[dbo].[VistaComprobantesRetencion]");

                modificarDatagridviweDiseño();

                //dtComprobantes = Funcion.llenarDataTable_Datagriview(dgvComprobantesErroneos);

            }
        }

        private void BtnProcesarPendientes_Click(object sender, EventArgs e)
        {
            procesarComprobantesPendientes();
        }


        string nombrexml = "";
        private void dgvComprobantesErroneos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string RutaXML1 = "";
                try
                {
                    TxtMensajeError.Text = dgvComprobantesErroneos[8, e.RowIndex].Value.ToString();
                    rTxtVistaXML.Text = "";
                    RutaXML1 = ConfigurationManager.AppSettings["XmlServidor"];
                    nombrexml = dgvComprobantesErroneos[1, e.RowIndex].Value.ToString();
                    string[] lineas = File.ReadAllLines(RutaXML1 + @"\Generados" + @"\" + dgvComprobantesErroneos[1, e.RowIndex].Value.ToString() + ".xml");
                    foreach (string linea in lineas)
                    {

                        rTxtVistaXML.Text += linea + "\n";

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encuentra el XML en la Ruta Especificada:\n " + RutaXML1 + @"\Generados" + @"\" + dgvComprobantesErroneos[1, e.RowIndex].Value.ToString() + ".xml", "Aviso");
                }
            }
        }

        private void CmbTipoComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvComprobantesErroneos.DataSource = null;
            rTxtVistaXML.Text = "";
            TxtMensajeError.Text = "";
            TxtCantComprobantesPendientes.Text = "";
            if (CmbTipoComprobante.Text == "Retención")
            {
                BtnReimprimirRide.Visible = true;
            }
            else
            {
                BtnReimprimirRide.Visible = false;
            }
        }
        string tipocomprobante = "";
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(rTxtVistaXML.Text);
                string RutaXML1 = ConfigurationManager.AppSettings["XmlServidor"];
                if (!Directory.Exists(RutaXML1 + @"\Generados\"))
                {
                    Directory.CreateDirectory(RutaXML1 + @"\Generados\");
                }
                
                xmldoc.Save(RutaXML1 + @"\Generados" + @"\" + nombrexml + ".xml");
                string xmlmane = xmldoc.GetElementsByTagName("claveAcceso")[0].InnerText;

                if (nombrexml != xmlmane)
                {
                    File.Copy(RutaXML1 + @"\Generados" + @"\" + nombrexml + ".xml", RutaXML1 + @"\Generados" + @"\" + xmlmane + ".xml");
                    File.Delete(RutaXML1 + @"\Generados" + @"\" + nombrexml + ".xml");

                    if (CmbTipoComprobante.Text == "Factura")
                    {
                        objconsul.EjecutarSQLFactElectronica("UPDATE [dbo].[TbDocumentosGeneradosFact] SET [NombreXML] = '" + xmlmane + "'  WHERE  NombreXML = '" + nombrexml + "'");
                    }
                    else
                    {
                        objconsul.EjecutarSQLFactElectronica("UPDATE [dbo].[TbDocumentosGeneradosRect] SET [NombreXML] = '" + xmlmane + "'  WHERE  NombreXML = '" + nombrexml + "'");
                    }
                    objconsul.EjecutarSQLFactElectronica("UPDATE [dbo].[TbErroresDocEnviados] SET [NombreXML] = '"+ xmlmane + "' WHERE  NombreXML = '" + nombrexml + "'");
                    nombrexml = xmlmane;
                }

                if (CmbTipoComprobante.Text == "Factura")
                {
                    tipocomprobante = "Factura";
                }
                else
                {
                    tipocomprobante = "Retención";
                }

                    //Creamos el delegado 
                    ThreadStart h1 = new ThreadStart(Procesar);
                //Creamos la instancia del hilo 
                Thread h2 = new Thread(h1);
                //Iniciamos el hilo 
                h2.Start();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se existe ningun XML Cargado para Procesar", "Aviso");
            }
        }


        private void Procesar()
        {
            try
            {
                if (tipocomprobante == "Factura")
                {
                    DtDocuemtosXML = objconsul.BoolDataTableFactElect("Select * from TbDocumentosGeneradosFact DocFact where DocFact.NombreXML='" + nombrexml + "'");
                }
                else
                {
                    DtDocuemtosXML = objconsul.BoolDataTableFactElect("Select * from TbDocumentosGeneradosRect DocRect where DocRect.NombreXML='" + nombrexml + "'");
                }
                int contadorAutorizado = 0, contadorEnviados = 0, contadorNoautorizados = 0, contadorDevuelta = 0, contadorRecibida = 0, contador = 0, estadoautorizacion = 0;
                string Recibida = "", AUT = "NO";
                if (DtDocuemtosXML.Rows.Count > 0)
                {
                    //btnEnviar.Enabled = false;
                    //lblTotalArchivos.Text = "Total de Archivos: " + DtDocuemtosXML.Rows.Count;
                    foreach (DataRow myRow in DtDocuemtosXML.Rows)
                    {
                        RutaXML = myRow["Ruta"].ToString();
                        NombreXML = myRow["NombreXML"].ToString();
                        FechaEmision = myRow["FechaEmision"].ToString();
                        contador++;
                        string RutaXML1 = ConfigurationManager.AppSettings["XmlServidor"];
                        string SRIRecepcion = ConfigurationManager.AppSettings["SRIRecepcion"];
                        string SRIAutorizacion = ConfigurationManager.AppSettings["SRIAutorizacion"];
                        //string pathXml = RutaXML1 + @"\sonna_judith_vega_solis.p12";
                        if (System.IO.File.Exists(RutaXML1 + @"\Generados" + @"\" + NombreXML + ".xml"))
                        {
                            //Firmar Documento
                            Firma.Firmalo(Program.RutaCertificado, Program.passwordCertificado, RutaXML1 + @"\Generados\" + NombreXML + ".xml", RutaXML1 + @"\Firmados\" + NombreXML + ".xml", RutaXML1);

                            SRIRecepcionComprobante sriRecepcion = new SRIRecepcionComprobante();
                            string respuestaRecepcion = sriRecepcion.RecepcionArchivos(RutaXML1 + @"\Firmados" + @"\" + NombreXML + ".xml", SRIRecepcion, NombreXML, RutaXML1);
                            //string respuestaRecepcion = "RECIBIDA";

                            string[] valoresrecepcion = respuestaRecepcion.Split(';');
                            //Fin RecepcionSRI

                            if (valoresrecepcion[0] == "RECIBIDA" || valoresrecepcion[1] == "CLAVE ACCESO REGISTRADA")
                            {
                                contadorRecibida++;
                                Recibida = "R";


                                SRIAutorizacionComprobante sriAutori = new SRIAutorizacionComprobante(SRIAutorizacion);
                                string estado = sriAutori.AutorizacionArchivos(NombreXML, RutaXML1, respuestaRecepcion);
                                string[] autorizado = estado.Split(';');
                                if (autorizado.Length > 1)
                                    fechaAutorizacion = autorizado[1];
                                if (autorizado[0] == "AUTORIZADO")
                                {
                                    contadorAutorizado++;
                                    estadoautorizacion = 1;
                                    AUT = "SI";
                                }
                                else
                                {
                                    contadorNoautorizados++;
                                    estadoautorizacion = 0;
                                    AUT = "NO";
                                }
                                contadorEnviados++;


                                //Thread.Sleep(500);

                                string contadoraenviar = contador + " de " + DtDocuemtosXML.Rows.Count + " Archivos.";
                                CambiarProgreso(NombreXML, FechaEmision, contadorDevuelta.ToString(), contadorRecibida.ToString(), contadorAutorizado.ToString(), contadorNoautorizados.ToString(), contadorEnviados.ToString(), contadoraenviar, "" + DtDocuemtosXML.Rows.Count);


                            }
                            else
                            {
                                contadorDevuelta++;
                                Recibida = "D";
                            }

                            Consultas Objconsul = new Consultas();
                            if (tipocomprobante == "Factura")
                            {
                                Objconsul.EjecutarSQLFactElectronica("UPDATE [dbo].[TbDocumentosGeneradosFact] SET [EstadoAutorizacion] = '" + estadoautorizacion + "',[RecepcionSRI] ='" + Recibida + "',[AutorizadoSRI]='" + AUT + "'  WHERE  NombreXML = '" + NombreXML + "'");
                            }
                            else
                            {
                                Objconsul.EjecutarSQLFactElectronica("UPDATE [dbo].[TbDocumentosGeneradosRect] SET [EstadoAutorizacion] = '" + estadoautorizacion + "',[RecepcionSRI] ='" + Recibida + "',[AutorizadoSRI]='" + AUT + "'  WHERE  NombreXML = '" + NombreXML + "'");
                            }

                            if (estadoautorizacion == 0)
                            {
                                Objconsul.EjecutarSQLFactElectronica("UPDATE [dbo].[TbErroresDocEnviados] SET [EstadoError] = '1' WHERE  NombreXML = '" + NombreXML + "'");
                            }
                            else
                            {
                                Objconsul.EjecutarSQLFactElectronica("UPDATE [dbo].[TbErroresDocEnviados] SET [EstadoError] = '0' WHERE  NombreXML = '" + NombreXML + "'");
                            }
                            
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningun archivo.");
                }

                //Thread.Sleep(1000);
                // MessageBox.Show("Proceso finalizado");
                //btnEnviar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en enviar al SRI: No responde\n Intentelo más tarde en el formulario Corregir Errores");
                //MessageBox.Show(ex.Message);
            }

        }

        private void CambiarProgreso(string nombreXml, string fecha, string contadorDevuelta, string contadorRecibida, string contadorautorizado, string contadornoautorizado, string contadorenviados, string contador, string archivosTotales)
        {
            if (this.InvokeRequired)
            {
                CambiarProgresoDelegado h1 = new CambiarProgresoDelegado(CambiarProgreso);
                object[] parametros = new object[] { nombreXml, fecha, contadorDevuelta, contadorRecibida, contadorautorizado, contadornoautorizado, contadorenviados, contador, archivosTotales };
                this.Invoke(h1, parametros);

            }
            else
            {
                //imprimirRetencion();
                if (fechaAutorizacion != null) //´solo se formara ride si la fecha de autorizacion esta, lo q significa si se autorizo o no
                {
                    //LLamar Reporte
                    string ambiente = "";
                    switch (Program.Ambiente)
                    {
                        case 1:
                            ambiente = "PRUEBA";
                            break;
                        case 2:
                            ambiente = "PRODUCCION";
                            break;
                        default:
                            break;
                    }

                    if (tipocomprobante == "Factura")
                    {

                        string rutaXMl = ConfigurationManager.AppSettings["XmlServidor"].ToString() + @"\Generados\" + nombreXml + ".xml";
                        XmlDocument docxml = new XmlDocument();
                        docxml.Load(rutaXMl);
                        string fechaemisionfactura = Convert.ToString(docxml.GetElementsByTagName("fechaEmision")[0].InnerText);
                        string[] partesfecha = fechaemisionfactura.Split('/');
                        string año = partesfecha[2];

                        Comisariato.Ride.Factura.ReporteFacturaRide ObjformularioRepoteFactura = null;
                        ObjformularioRepoteFactura = new Ride.Factura.ReporteFacturaRide(nombrexml, fechaAutorizacion, ambiente, año);
                        ObjformularioRepoteFactura.Show();


                    }
                    else
                    {
                        string rutaXMl = ConfigurationManager.AppSettings["XmlServidor"].ToString() + @"\Generados\" + nombreXml + ".xml";
                        XmlDocument docxml = new XmlDocument();
                        docxml.Load(rutaXMl);
                        int numeroRetencion2 = Convert.ToInt32(docxml.GetElementsByTagName("secuencial")[0].InnerText);
                        objconsul.EjecutarSQL("UPDATE [dbo].[TbEncabezadoOrdenGiro] SET [AUTORIZACIONSRICLAVEACCESO] = '" + nombreXml + "' ,[FECHAAUTORIZACIONSRI] = '" + fechaAutorizacion + "'	WHERE IDORDENGIRO =" + numeroRetencion2 + "; ");

                        string numeroOrdengiro = objconsul.ObtenerValorEntero("SELECT *  FROM [BDComiSuper2].[dbo].[TbEncabezadoOrdenGiro] where NUMERORETECION =" + numeroRetencion2 + "").ToString();
                        

                        string fechaemision = docxml.GetElementsByTagName("fechaEmision")[0].InnerText;
                        string[] fechaseparada = fechaemision.Split('/');
                        cmbAñoRetencionHechaVariable = fechaseparada[2];
                        //string numeroRetencion2 = "10";
                        ReporteRetencion objeformularioReporte = null;
                        objeformularioReporte = new ReporteRetencion(nombrexml, fechaAutorizacion, numeroOrdengiro.ToString(), ambiente, "NORMAL", cmbAñoRetencionHechaVariable);
                        objeformularioReporte.Show();
                        //Fin Llamar Reporte

                        //Eviar Correo
                        objconsul.enviarCorreoRideRetencion(numeroOrdengiro.ToString(), cmbAñoRetencionHechaVariable, nombrexml);
                        //Fin Eviar Correo

                        //nombrexml = "";
                        //BtnProcesarPendientes_Click(null, null);
                    }
                }
                nombrexml = "";
                rTxtVistaXML.Text = "";
                TxtMensajeError.Text = "";
                procesarComprobantesPendientes();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (dtComprobantes != null)
            //{
            //    string fieldName = string.Concat("[", dtComprobantes.Columns[2].ColumnName, "]");
            //    dtComprobantes.DefaultView.Sort = fieldName;
            //    DataView view = dtComprobantes.DefaultView;
            //    view.RowFilter = string.Empty;
            //    if (DtpFechaInicial.Value.ToShortDateString() != string.Empty)
            //        view.RowFilter = fieldName + " >=  '" + DtpFechaInicial.Value.ToShortDateString() + "' and  " + fieldName + " <=  '" + DtpFechaFinal.Value.ToShortDateString() + "'";
            //    dgvComprobantesErroneos.DataSource = view;
            //}
            TxtMensajeError.Text = "";

            if (CmbTipoComprobante.Text == "Factura")
            {
                //MessageBox.Show("factura");
                dtComprobantes = null;
                dtComprobantes = objconsul.BoolDataTable("");
                int cantidadComprobanrt = objconsul.ObtenerValorEntero("SELECT COUNT(*) as TotalComprobantes from VistaComprobantesFactura where fecha BETWEEN '" + DtpFechaInicial.Value.ToShortDateString() + "' AND '" + DtpFechaFinal.Value.ToShortDateString() + "'; ");
                TxtCantComprobantesPendientes.Text = cantidadComprobanrt.ToString();
                objconsul.BoolCrearDateTableComprobantesErroneos(dgvComprobantesErroneos, "SELECT *  FROM [BDFacturacionElectronica].[dbo].[VistaComprobantesFactura] where fecha BETWEEN '" + DtpFechaInicial.Value.ToShortDateString() + "' AND '" + DtpFechaFinal.Value.ToShortDateString() + "';");

                modificarDatagridviweDiseño();

                //dtComprobantes = Funcion.llenarDataTable_Datagriview(dgvComprobantesErroneos);

            }
            else
            {
                //MessageBox.Show("retención");
                dtComprobantes = null;
                int cantidadComprobanrt = objconsul.ObtenerValorEntero("SELECT COUNT(*) as TotalComprobantes from [BDFacturacionElectronica].[dbo].VistaComprobantesRetencion where fecha BETWEEN '" + DtpFechaInicial.Value.ToShortDateString() + "' AND '" + DtpFechaFinal.Value.ToShortDateString() + "';");
                TxtCantComprobantesPendientes.Text = cantidadComprobanrt.ToString();
                objconsul.BoolCrearDateTableComprobantesErroneos(dgvComprobantesErroneos, "SELECT *  FROM [BDFacturacionElectronica].[dbo].[VistaComprobantesRetencion] where fecha BETWEEN '" + DtpFechaInicial.Value.ToShortDateString() + "' AND '" + DtpFechaFinal.Value.ToShortDateString() + "';");

                modificarDatagridviweDiseño();

                //dtComprobantes = Funcion.llenarDataTable_Datagriview(dgvComprobantesErroneos);

            }
        }

        private void BtnReimprimirRide_Click(object sender, EventArgs e)
        {
            FrmReimprimirComprobante f = new FrmReimprimirComprobante();
            f.ShowDialog();
        }

        
    }
}
