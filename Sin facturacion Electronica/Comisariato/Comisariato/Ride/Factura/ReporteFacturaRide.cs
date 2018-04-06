using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Xml;
using Comisariato.Clases;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Comisariato.Ride.Factura
{
    public partial class ReporteFacturaRide : Form
    {

        string nombreXml = "";
        string fechaAutorizacion = "";
        string ambiente = "";
        string año = "";
        SqlDataAdapter da;
        datosFactura info;

        public ReporteFacturaRide(string nombreXml,string fechaAutorizacion, string ambiente, string año)
        {
            InitializeComponent();
            this.nombreXml = nombreXml;
            this.fechaAutorizacion = fechaAutorizacion;
            this.ambiente = ambiente;
            this.año = año;
            info = new datosFactura();
            da = new SqlDataAdapter();
        }


        
        private string correoCliente = "";
        private string NombreCliente = "";
        private bool FormarRide = false;
        private string PathArchivoRide = Application.StartupPath + @"\Ride.rdlc";
        //private string PathCodigoBarra = @"file:\" + Application.StartupPath + @"\p.png";
        string PathCodigoBarra = ConfigurationManager.AppSettings["XmlServidor"];
        private void ReporteFacturaRide_Load(object sender, EventArgs e)
        {
            //formar ride si no es consumidor final
            Consultas objconsul = new Consultas();
            da = objconsul.retornarSqlDataAdapter("1", "Select LOGO from TbEmpresa where IDEMPRESA = @IDEMPRESA", "@IDEMPRESA");
            da.Fill(info, "Empresa");
            da.Dispose();

            string PathServer = ConfigurationManager.AppSettings["XmlServidor"];
            List<FacturaD> objFactura = llenarDatosEmcabezadoyPie(PathServer + @"\Generados\" + nombreXml + ".xml", fechaAutorizacion, ambiente);

            if (FormarRide)
            {
                List<DetalleFactura> listaDetalle = llenarDetalleFactura(PathServer + @"\Generados\" + nombreXml + ".xml");
                List<PieFactura> listaPie = llenarPieFactura(PathServer + @"\Generados\" + nombreXml + ".xml");



                BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                Codigo.IncludeLabel = true;

                Panel obp = new Panel();
                obp.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, nombreXml, Color.Black, Color.White, 1000, 300);
                Image imgFinal = (Image)obp.BackgroundImage.Clone();


                imgFinal.Save("p.png", ImageFormat.Png);
                imgFinal.Dispose();


                String ruta1 = PathCodigoBarra;
                ReportParameter param2 = new ReportParameter("CodigoBarra", ruta1, true);
                this.reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.LocalReport.SetParameters(param2);
                //this.reportViewer1.RefreshReport();

                this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                //this.reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rdDatosFact = new ReportDataSource("datosFactura", info.Tables[0]);
                ReportDataSource rdFact = new ReportDataSource("DataSet1", objFactura);
                ReportDataSource rdlistadetalle = new ReportDataSource("DetalleFactura", listaDetalle);
                ReportDataSource rdListapie = new ReportDataSource("PieFactura", listaPie);
                this.reportViewer1.LocalReport.DataSources.Clear();

                this.reportViewer1.LocalReport.DataSources.Add(rdDatosFact);
                this.reportViewer1.LocalReport.DataSources.Add(rdFact);
                this.reportViewer1.LocalReport.DataSources.Add(rdlistadetalle);
                this.reportViewer1.LocalReport.DataSources.Add(rdListapie);
                

                //Poner Un nombre para guardar el Reporte
                this.reportViewer1.LocalReport.DisplayName = nombreXml;


                this.reportViewer1.RefreshReport();


                //INFORME EN VISTA DE IMPRESIÓN
                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                this.reportViewer1.ZoomPercent = 100;
                //FIN INFORME EN VISTA DE IMPRESIÓN


                //Guardar pdf en servidor
                if (!Directory.Exists(PathServer + @"\Ride\Factura\" + año + @"\"))
                {
                    Directory.CreateDirectory(PathServer + @"\Ride\Factura\" + año + @"\");
                }

                byte[] pdfContent = reportViewer1.LocalReport.Render("PDF");

                string pdfPath = PathServer + @"\Ride\Factura\" + año + @"\" + nombreXml + ".pdf";
                System.IO.FileStream pdfFile = new System.IO.FileStream(pdfPath, System.IO.FileMode.Create);
                pdfFile.Write(pdfContent, 0, pdfContent.Length);
                pdfFile.Close();



            }
            //fin ride
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private List<DetalleFactura> llenarDetalleFactura(string pathArchivo)
        {

            List<DetalleFactura> listaDetalle = new List<DetalleFactura>();
            try
            {
                XmlDocument myXmlDocument = new XmlDocument();
                myXmlDocument.Load(pathArchivo);
                XmlNode node;
                node = myXmlDocument.DocumentElement;
                foreach (XmlNode node1 in node.ChildNodes)
                {
                    if (node1.Name == "detalles")
                    {

                        foreach (XmlNode node2 in node1.ChildNodes)
                        {

                            if (node2.Name == "detalle")
                            {
                                int Cantidad = CantidadeItems(myXmlDocument);
                                for (int i = 0; i < Cantidad; i++)
                                {

                                    DetalleFactura item = new DetalleFactura
                                    {
                                        //Establezca valores a cada una de las propiedades
                                        Codigo = myXmlDocument.GetElementsByTagName("codigoPrincipal")[i].InnerText,
                                        Detalle = myXmlDocument.GetElementsByTagName("descripcion")[i].InnerText,//descripcion
                                        Cantidad = myXmlDocument.GetElementsByTagName("cantidad")[i].InnerText,
                                        Punitario = myXmlDocument.GetElementsByTagName("precioUnitario")[i].InnerText,
                                        Valortota = myXmlDocument.GetElementsByTagName("precioTotalSinImpuesto")[i].InnerText,
                                        // Iva = myXmlDocument.GetElementsByTagName("valor")[i].InnerText,
                                        Iva = "0.00",
                                    };
                                    listaDetalle.Add(item);
                                }
                                break;

                            }

                        }
                    }

                    //totalConImpuestos
                }
                return listaDetalle;
            }
            catch (Exception e)
            {

                return null;
            }
        }

        private int CantidadeItems(XmlDocument myXmlDocument)
        {
            int contador = 0;
            XmlNode node;
            try
            {
                node = myXmlDocument.DocumentElement;
                foreach (XmlNode node1 in node.ChildNodes)
                {
                    if (node1.Name == "detalles")
                    {

                        foreach (XmlNode node2 in node1.ChildNodes)
                        {

                            if (node2.Name == "detalle")
                            {

                                contador++;

                            }
                        }
                    }
                }
                return contador;
            }
            catch (Exception)
            {

                return 0;
            }


        }

        private List<FacturaD> llenarDatosEmcabezadoyPie(string pathArchivo, string fechahoraautorizacion, string ambiente)
        {
            try
            {
                Consultas objConsulta = new Consultas();
                List<FacturaD> listaFactura = new List<FacturaD>();
                FacturaD objFactura = new FacturaD();
                XmlDocument myXmlDocument = new XmlDocument();
                myXmlDocument.Load(pathArchivo);
                //datos emcabezado
                objFactura.Rucempresa = myXmlDocument.GetElementsByTagName("ruc")[0].InnerText;
                objFactura.Razonsocialempresa = myXmlDocument.GetElementsByTagName("razonSocial")[0].InnerText;
                objFactura.Numerodeautorizacion = myXmlDocument.GetElementsByTagName("claveAcceso")[0].InnerText;
                objFactura.Fechahoraemision = fechahoraautorizacion;
                objFactura.Ambiente = ambiente;
                objFactura.Emision = myXmlDocument.GetElementsByTagName("guiaRemision")[0].InnerText;//guiaRemision
                objFactura.Claveacceso = myXmlDocument.GetElementsByTagName("claveAcceso")[0].InnerText;
                objFactura.Direccionempresa = myXmlDocument.GetElementsByTagName("dirMatriz")[0].InnerText;
                objFactura.Direccionsucursal = myXmlDocument.GetElementsByTagName("dirMatriz")[0].InnerText;
                objFactura.Obligadollevarcontabilidad = myXmlDocument.GetElementsByTagName("obligadoContabilidad")[0].InnerText;

                //datos cliente
                objFactura.Razonsocialcliente = myXmlDocument.GetElementsByTagName("razonSocialComprador")[0].InnerText;
                objFactura.Fechaemisioncliente = myXmlDocument.GetElementsByTagName("fechaEmision")[0].InnerText;
                objFactura.Direccioncliente = myXmlDocument.GetElementsByTagName("direccionComprador")[0].InnerText;
                objFactura.Identificacioncliente = myXmlDocument.GetElementsByTagName("identificacionComprador")[0].InnerText;
                if (myXmlDocument.GetElementsByTagName("identificacionComprador")[0].InnerText != "9999999999999")
                {
                    string identificacion = myXmlDocument.GetElementsByTagName("identificacionComprador")[0].InnerText;
                    correoCliente = objConsulta.CorreoCliente(identificacion);
                    NombreCliente = myXmlDocument.GetElementsByTagName("razonSocialComprador")[0].InnerText;
                    FormarRide = true;
                }

                listaFactura.Add(objFactura);
                return listaFactura;
            }
            catch (Exception e)
            {

                return null;
            }

        }

        private List<PieFactura> llenarPieFactura(string pathArchivo)
        {
            List<PieFactura> listaPieFactura = new List<PieFactura>();
            PieFactura objPieFactura = new PieFactura();
            try
            {
                XmlDocument myXmlDocument = new XmlDocument();
                myXmlDocument.Load(pathArchivo);

                //datos totales
                objPieFactura.Subtotal = myXmlDocument.GetElementsByTagName("totalSinImpuestos")[0].InnerText;

                XmlNode node;
                node = myXmlDocument.DocumentElement;
                objPieFactura.Subtotal0 = "0.00";
                objPieFactura.Subtotal12 = "0.00";
                objPieFactura.Iva12 = "0.00";
                // float subtotal0=0, subtotal12=0, iva12=0;
                foreach (XmlNode node1 in node.ChildNodes)
                {
                    foreach (XmlNode node2 in node1.ChildNodes)
                    {
                        if (node2.Name == "totalConImpuestos")
                        {
                            //totalImpuesto
                            foreach (XmlNode node3 in node2.ChildNodes)
                            {
                                if (node3.Name == "totalImpuesto")
                                {
                                    int Cantidad = CantidadNodoImpuesto(myXmlDocument);
                                    for (int i = 0; i < Cantidad; i++)
                                    {
                                        string codigoPorcentaje = myXmlDocument.GetElementsByTagName("codigoPorcentaje")[i].InnerText;
                                        if (codigoPorcentaje == "0")
                                        {
                                            //subtotal0+= Convert.ToSingle(Funcion.reemplazarcaracterViceversa(myXmlDocument.GetElementsByTagName("baseImponible")[i].InnerText));
                                            objPieFactura.Subtotal0 = myXmlDocument.GetElementsByTagName("baseImponible")[i].InnerText;
                                        }
                                        else if (codigoPorcentaje == "2")
                                        {
                                            //subtotal12 +=Convert.ToSingle(Funcion.reemplazarcaracterViceversa(myXmlDocument.GetElementsByTagName("baseImponible")[i].InnerText));
                                            //iva12+= Convert.ToSingle(Funcion.reemplazarcaracterViceversa(myXmlDocument.GetElementsByTagName("valor")[i].InnerText));
                                            objPieFactura.Subtotal12 = myXmlDocument.GetElementsByTagName("baseImponible")[i].InnerText;
                                            objPieFactura.Iva12 = myXmlDocument.GetElementsByTagName("valor")[i].InnerText;
                                        }
                                    }
                                    break;

                                }
                            }

                        }
                    }
                    //totalConImpuestos
                }
                //objPieFactura.Subtotal12 = subtotal12.ToString("#####");
                objPieFactura.Valortotal = myXmlDocument.GetElementsByTagName("importeTotal")[0].InnerText;
                objPieFactura.Descuento = "0.00";
                objPieFactura.Propina = "0.00";
                listaPieFactura.Add(objPieFactura);
                return listaPieFactura;
            }
            catch (Exception)
            {

                return null;
            }
        }
        private int CantidadNodoImpuesto(XmlDocument myXmlDocument)
        {
            int contador = 0;
            XmlNode node;
            try
            {
                node = myXmlDocument.DocumentElement;
                foreach (XmlNode node1 in node.ChildNodes)
                {
                    if (node1.Name == "infoFactura")
                    {

                        foreach (XmlNode node2 in node1.ChildNodes)
                        {

                            if (node2.Name == "totalConImpuestos")
                            {
                                foreach (XmlNode node3 in node2.ChildNodes)
                                {
                                    if (node3.Name == "totalImpuesto")
                                    {
                                        contador++;
                                    }
                                }

                            }
                        }
                    }
                }
                return contador;
            }
            catch (Exception)
            {

                return 0;
            }


        }
    }
}
