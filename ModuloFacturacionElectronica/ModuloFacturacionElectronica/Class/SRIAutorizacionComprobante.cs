using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using Microsoft.Reporting.WinForms;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ModuloFacturacionElectronica.Class
{
    class SRIAutorizacionComprobante
    {
       
        private bool FormarRide = false;
        private string correoCliente = "";

        string sUrl = "";
        string sSoapAction = "";
        public string xmlResultado = "";
        private string NombreCliente = "";
        private string NombreEmpresa = "";
        private string EmailEmpresa = "";
        private string PassEmailEmpresa = "";
        private string PathCodigoBarra= @"file:\" + Application.StartupPath + @"\p.png";
        private string PathArchivoRide= Application.StartupPath + @"\Ride.rdlc";
        private string PathLogo = @"file:\" + Application.StartupPath + @"\Imagenes\logo.jpg";

        Consultas objConsultas = new Consultas();
        public SRIAutorizacionComprobante(string urlVerificacion,string NombreEmpresa,string EmailEmpresa, string PassEmailEmpresa)
        {
            //this.sUrl = "https://cel.sri.gob.ec/comprobantes-electronicos-ws/AutorizacionComprobantes";
            this.sUrl = urlVerificacion;
            this.sSoapAction = "AutorizacionComprobante";
            this.NombreEmpresa = NombreEmpresa;
            this.EmailEmpresa = EmailEmpresa;
            this.PassEmailEmpresa = PassEmailEmpresa;
        }

        public string AutorizacionArchivos(string sClaveAcceso, string PathServer)
        {
            string sResult = "";
            StringBuilder sSoap = new StringBuilder();
            XmlDocument oXmlDoc = new XmlDocument();
            HttpWebRequest oHttpRequest = null;
            StreamReader oReader = null;
            string estado = "";
            sSoap.Append("<soapenv:Envelope xmlns:soapenv=" + Convert.ToChar(34) + "http://schemas.xmlsoap.org/soap/envelope/" + Convert.ToChar(34) + " xmlns:ec=" + Convert.ToChar(34) + "http://ec.gob.sri.ws.autorizacion" + ((char)34) + "><soapenv:Header/>");
            sSoap.Append("\n	<soapenv:Body>");
            sSoap.Append("\n 		<ec:autorizacionComprobante>");
            sSoap.Append("\n 			<claveAccesoComprobante>" + sClaveAcceso.Trim() + "</claveAccesoComprobante>");
            sSoap.Append("\n		</ec:autorizacionComprobante>");
            sSoap.Append("\n	</soapenv:Body>");
            sSoap.Append("\n</soapenv:Envelope>");

            try
            {
                oHttpRequest = (HttpWebRequest)WebRequest.Create(this.sUrl);
                oHttpRequest.ContentType = "text/xml;action=\"" + this.sSoapAction;
                oHttpRequest.Method = "POST";

                oXmlDoc.LoadXml(sSoap.ToString());
                oXmlDoc.Save(oHttpRequest.GetRequestStream());

                oReader = new StreamReader(oHttpRequest.GetResponse().GetResponseStream());
                xmlResultado = oReader.ReadToEnd();

                XmlDocument docxmlSRI = new XmlDocument();
                docxmlSRI.LoadXml(xmlResultado);


                xmlResultado = WebUtility.HtmlDecode(xmlResultado);

                //Cargo a un XML
                XmlDocument docxml = new XmlDocument();

                var caracterPrincipal = xmlResultado.IndexOf('?') - 1;
                var caracterSecundario = xmlResultado.LastIndexOf('?') + 2;
                xmlResultado = xmlResultado.Remove(caracterPrincipal, (caracterSecundario - caracterPrincipal));
                xmlResultado = "<?xml version=" + "\"1.0\"" + " encoding=" + "\"UTF-8\"" + "?>" + xmlResultado;
                docxml.LoadXml(xmlResultado);

                //Preguntar sobre el directorio
                string FechaAutorizacion = "", mensaje = "", infoadicional = "", tipo = "", claveconsultada = "", numeroAutorizacion = "", claveAcceso = "";
                estado = docxml.GetElementsByTagName("estado")[0].InnerText;
                string ambiente = docxml.GetElementsByTagName("ambiente")[0].InnerText;
                claveconsultada = docxml.GetElementsByTagName("claveAccesoConsultada")[0].InnerText;

                if (estado == "AUTORIZADO")
                {
                    numeroAutorizacion = docxml.GetElementsByTagName("numeroAutorizacion")[0].InnerText;
                    claveAcceso = docxml.GetElementsByTagName("claveAcceso")[0].InnerText;
                    numeroAutorizacion = docxml.GetElementsByTagName("numeroAutorizacion")[0].InnerText;
                    FechaAutorizacion = Convert.ToDateTime(docxml.GetElementsByTagName("fechaAutorizacion")[0].InnerText).ToString();

                    //formar ride si no es consumidor final
                    List<Factura> objFactura = llenarDatosEmcabezadoyPie(PathServer + @"\Generados\"+ sClaveAcceso+".xml", FechaAutorizacion, ambiente);

                    if (FormarRide)
                    {
                        List<DetalleFactura> listaDetalle = llenarDetalleFactura(PathServer + @"\Generados\" + sClaveAcceso + ".xml");
                        List<PieFactura> listaPie = llenarPieFactura(PathServer + @"\Generados\" + sClaveAcceso + ".xml");




                        ReportViewer objreportview = new ReportViewer();


                        objreportview.ProcessingMode = ProcessingMode.Local;

                        objreportview.LocalReport.ReportPath = PathArchivoRide;
                        String ruta = PathLogo;
                        ReportParameter param = new ReportParameter("RutaImg", ruta, true);
                        objreportview.LocalReport.EnableExternalImages = true;
                        objreportview.LocalReport.SetParameters(param);
                        objreportview.RefreshReport();

                    BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                    Codigo.IncludeLabel = true;

                    Panel obp = new Panel();
                    obp.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, sClaveAcceso, Color.Black, Color.White, 1000, 300);
                    Image imgFinal = (Image)obp.BackgroundImage.Clone();

                  
                        imgFinal.Save("p.png", ImageFormat.Png);
                   
                    imgFinal.Dispose();
                        //file:\C:\Users\MaxDJ\Desktop\ModuloFacturacionElectronica\ModuloFacturacionElectronica\bin\Debug\p.png
                    String ruta1 = PathCodigoBarra;
                    ReportParameter param2 = new ReportParameter("CodigoBarra", ruta1, true);
                    objreportview.LocalReport.EnableExternalImages = true;
                    objreportview.LocalReport.SetParameters(param2);
                    objreportview.RefreshReport();

                    objreportview.LocalReport.DataSources.Clear();
                        objreportview.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", objFactura));
                        objreportview.LocalReport.DataSources.Add(new ReportDataSource("DetalleFactura", listaDetalle));
                        objreportview.LocalReport.DataSources.Add(new ReportDataSource("PieFactura", listaPie));
                        objreportview.RefreshReport();



                        string reportType = "PDF";
                        string mimeType;
                        string encoding;
                        string fileNameExtension;
                        Warning[] warnings;
                        string[] streams;




                        byte[] bytes = objreportview.LocalReport.Render(reportType,
                        //deviceInfo,
                        null,
                        out mimeType,
                        out encoding,
                        out fileNameExtension,
                        out streams,
                        out warnings);

                        string año = sClaveAcceso.Substring(4, 4);

                        if (!Directory.Exists(PathServer + @"\Ride\Factura\" + año + @"\"))
                        {
                            Directory.CreateDirectory(PathServer + @"\Ride\Factura\" + año + @"\");
                        }
                        FileStream fs = new FileStream(PathServer + @"\Ride\Factura\" + año + @"\" + sClaveAcceso + ".pdf", FileMode.Create);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();



                    }
                    //fin ride

                    if (!Directory.Exists(PathServer + @"\Autorizados\"))
                    {
                        Directory.CreateDirectory(PathServer + @"\Autorizados\");
                    }
                    docxmlSRI.Save(@PathServer + @"\Autorizados\" + @"\" + sClaveAcceso + ".xml");
                    //enviar correo cliente
                    if (FormarRide)
                    {
                        if (correoCliente != "" && correoCliente != "S/N")
                        {
                            enviarCorreo(@PathServer, sClaveAcceso);
                        }
                    }
                       
                }
                else
                {

                    tipo = docxml.GetElementsByTagName("tipo")[0].InnerText;
                    //mensaje = docxml.GetElementsByTagName("mensaje")[0].InnerText;
                    infoadicional = docxml.GetElementsByTagName("informacionAdicional")[0].InnerText;
                    string fechaEmision = docxml.GetElementsByTagName("fechaEmision")[0].InnerText;
                    if (!Directory.Exists(PathServer + @"\No Autorizados\"))
                    {
                        Directory.CreateDirectory(PathServer + @"\No Autorizados\");
                    }
                    docxmlSRI.Save(@PathServer + @"\No Autorizados\" + @"\" + sClaveAcceso + ".xml");
                    string rutaNAT = @PathServer + @"\No Autorizados\";
                    string fechafinal = Funcion.reemplazarcaracterFecha(fechaEmision);
                    //variable a guardar en la BD
                    string tipo2= docxmlSRI.GetElementsByTagName("identificador")[0].InnerText;
                    string msg= docxmlSRI.GetElementsByTagName("mensaje")[1].InnerText;
                    string infoAdicional= docxmlSRI.GetElementsByTagName("informacionAdicional")[0].InnerText;
                    infoAdicional = Funcion.verificarMensaje(infoAdicional);
                    objConsultas.EjecutarSQL("INSERT INTO [dbo].[TbErroresDocEnviados]([NombreXML],[Ruta],[FechaEmision] ,[EstadoError] ,[MensajeError] ,[CodigoError] ,[InformacionAdicional] )" +
                    "VALUES ('" + sClaveAcceso + "','" + rutaNAT + "','" + fechafinal + "','" + 1 +"','"+ msg +"','"+ tipo2 +"','"+ infoAdicional + "')");

                }

            }
            catch (Exception ex)
            {
                sResult = ex.Message;
            }
            if (estado == "")
            {
               estado= SegundoIntento(sClaveAcceso, PathServer);
            }
            return estado;
        }

       private void enviarCorreo(string @PathServer, string sClaveAcceso)
       {
            try
            {
                string rutaxml = @PathServer + @"\Autorizados\" + @"\" + sClaveAcceso + ".xml";
                string rutaride = PathServer + @"\Ride\Factura\" + sClaveAcceso + ".pdf";
                EnviarCorreo ObjcorreoRide = new EnviarCorreo();
                string mensaje = "";
               
            
                string Asunto = "";



                //correoCliente = "and261195@outlook.es";
                Asunto = "Su COMPROBANTE DE Factura " + sClaveAcceso + " de " + NombreEmpresa + "";
                mensaje = "Estimado(a), " + NombreCliente + "\n" + "Su Factura " + sClaveAcceso + " ha sido generada con exito y se encuentra disponible para su descarga y visualizacion." + "\n" +
                "Adjunto encontrara el archivo PDF y XML" + "\n" + "Saludos cordiales y gracias por su atencion." + "\n" + "Atentamente," + "\n" + NombreEmpresa;
                ObjcorreoRide.enviarCorreo(EmailEmpresa, PassEmailEmpresa, mensaje, Asunto, correoCliente, rutaxml, rutaride);
            }
            catch (Exception)
            {

                //throw;
            }
            
        }

        private List< Factura> llenarDatosEmcabezadoyPie(string pathArchivo,string fechahoraautorizacion,string ambiente)
        {
            try
            {
                Consultas objConsulta = new Consultas();
                List<Factura> listaFactura = new List<Factura>();
               Factura objFactura = new Factura();
                XmlDocument myXmlDocument = new XmlDocument();
                myXmlDocument.Load(pathArchivo);
                //datos emcabezado
                objFactura.Rucempresa = myXmlDocument.GetElementsByTagName("ruc")[0].InnerText;
                objFactura.Razonsocialempresa = myXmlDocument.GetElementsByTagName("razonSocial")[0].InnerText;
                objFactura.Numerodeautorizacion = myXmlDocument.GetElementsByTagName("claveAcceso")[0].InnerText;
                objFactura.Fechahoraemision = fechahoraautorizacion;
                objFactura.Ambiente = ambiente;
                objFactura.Emision= myXmlDocument.GetElementsByTagName("guiaRemision")[0].InnerText;//guiaRemision
                objFactura.Claveacceso= myXmlDocument.GetElementsByTagName("claveAcceso")[0].InnerText;
                objFactura.Direccionempresa= myXmlDocument.GetElementsByTagName("dirMatriz")[0].InnerText;
                objFactura.Direccionsucursal= myXmlDocument.GetElementsByTagName("dirMatriz")[0].InnerText;
                objFactura.Obligadollevarcontabilidad= myXmlDocument.GetElementsByTagName("obligadoContabilidad")[0].InnerText;

                //datos cliente
                objFactura.Razonsocialcliente= myXmlDocument.GetElementsByTagName("razonSocialComprador")[0].InnerText;
                objFactura.Fechaemisioncliente = myXmlDocument.GetElementsByTagName("fechaEmision")[0].InnerText;
                objFactura.Direccioncliente= myXmlDocument.GetElementsByTagName("direccionComprador")[0].InnerText;
                objFactura.Identificacioncliente= myXmlDocument.GetElementsByTagName("identificacionComprador")[0].InnerText;
                if (myXmlDocument.GetElementsByTagName("identificacionComprador")[0].InnerText!="9999999999999")
                {
                    string identificacion = myXmlDocument.GetElementsByTagName("identificacionComprador")[0].InnerText;
                    correoCliente= objConsulta.CorreoCliente(identificacion);
                    NombreCliente= myXmlDocument.GetElementsByTagName("razonSocialComprador")[0].InnerText;
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
                    if (node1.Name== "detalles")
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
                                       Iva="0.00",
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
                                    if (node3.Name== "totalImpuesto")
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

        private string SegundoIntento(string sClaveAcceso, string PathServer)
        {
            //string sResult = "";
            StringBuilder sSoap = new StringBuilder();
            XmlDocument oXmlDoc = new XmlDocument();
            HttpWebRequest oHttpRequest = null;
            StreamReader oReader = null;
            string estado = "";
            sSoap.Append("<soapenv:Envelope xmlns:soapenv=" + Convert.ToChar(34) + "http://schemas.xmlsoap.org/soap/envelope/" + Convert.ToChar(34) + " xmlns:ec=" + Convert.ToChar(34) + "http://ec.gob.sri.ws.autorizacion" + ((char)34) + "><soapenv:Header/>");
            sSoap.Append("\n	<soapenv:Body>");
            sSoap.Append("\n 		<ec:autorizacionComprobante>");
            sSoap.Append("\n 			<claveAccesoComprobante>" + sClaveAcceso.Trim() + "</claveAccesoComprobante>");
            sSoap.Append("\n		</ec:autorizacionComprobante>");
            sSoap.Append("\n	</soapenv:Body>");
            sSoap.Append("\n</soapenv:Envelope>");

            try
            {
                oHttpRequest = (HttpWebRequest)WebRequest.Create(this.sUrl);
                oHttpRequest.ContentType = "text/xml;action=\"" + this.sSoapAction;
                oHttpRequest.Method = "POST";

                oXmlDoc.LoadXml(sSoap.ToString());
                oXmlDoc.Save(oHttpRequest.GetRequestStream());

                oReader = new StreamReader(oHttpRequest.GetResponse().GetResponseStream());
                xmlResultado = oReader.ReadToEnd();

                XmlDocument docxmlSRI = new XmlDocument();
                docxmlSRI.LoadXml(xmlResultado);
                estado = docxmlSRI.GetElementsByTagName("estado")[0].InnerText;

                if (estado == "AUTORIZADO")
                {
                    if (!Directory.Exists(PathServer + @"\Autorizados\"))
                    {
                        Directory.CreateDirectory(PathServer + @"\Autorizados\");
                    }
                    docxmlSRI.Save(@PathServer + @"\Autorizados\" + @"\" + sClaveAcceso + ".xml");
                }
                else
                {

                    if (!Directory.Exists(PathServer + @"\No Autorizados\"))
                    {
                        Directory.CreateDirectory(PathServer + @"\No Autorizados\");
                    }
                    docxmlSRI.Save(@PathServer + @"\No Autorizados\" + @"\" + sClaveAcceso + ".xml");
                    string rutaNAT = @PathServer + @"\No Autorizados\";
                    string fecha= Funcion.reemplazarcaracterFecha(DateTime.Now.Date.ToShortDateString());
                    //string fechafinal = Funcion.reemplazarcaracterFecha(fechaEmision);
                    objConsultas.EjecutarSQL("INSERT INTO [dbo].[TbErroresDocEnviados]([NombreXML],[Ruta],[FechaEmision] ,[EstadoError] )" +
                    "VALUES ('" + sClaveAcceso + "','" + rutaNAT + "','" + fecha + "','" + 1 + "')");

                }

            }
            catch
            {

            }
            return estado;
        }
    }
}
