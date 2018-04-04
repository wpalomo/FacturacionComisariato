using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Comisariato.Clases
{
    class SRIAutorizacionComprobante
    {
        /// <summary>
        /// The consultar autorizaciones.
        /// </summary>
        /// <param name="claveAcceso">The claveAcceso.</param>
        /// <returns>The <see cref="DatosTributarios"/>.</returns>
        public DatosTributarios ConsultarAutorizaciones(string claveAcceso)
        {
            return LlamarSri(claveAcceso);
        }

        /// <summary>
        /// The llamar sri.
        /// </summary>
        /// <param name="claveAcceso">The claveAcceso.</param>
        /// <returns>The <see cref="DatosTributarios"/>.</returns>

        private DatosTributarios LlamarSri(string claveAcceso)
        {
            try
            {
                var PathServer = @"C:\Users\Public\Documents\ArchivosXml";

                var resultado = string.Empty;
                DatosTributarios datosTributarios = null;
                string url = "https://celcer.sri.gob.ec/comprobantes-electronicos-ws/AutorizacionComprobantesOffline?wsdl";
                string xml = "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:ec=\"http://ec.gob.sri.ws.autorizacion\">";
                xml = xml + "<soapenv:Header/>";
                xml = xml + "<soapenv:Body>";
                xml = xml + "<ec:autorizacionComprobante>";
                xml = xml + "<claveAccesoComprobante>" + claveAcceso + "</claveAccesoComprobante>";
                xml = xml + "</ec:autorizacionComprobante>";
                xml = xml + "</soapenv:Body>";
                xml = xml + "</soapenv:Envelope>";

                byte[] bytes = Encoding.ASCII.GetBytes(xml);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                request.Method = "POST";
                request.ContentLength = bytes.Length;
                request.ContentType = "text/xml";

                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream);
                    resultado = reader.ReadToEnd();
                }
                resultado = WebUtility.HtmlDecode(resultado);

                response.Close();
                var caracterPrincipal = resultado.IndexOf('?') - 1;
                var caracterSecundario = resultado.LastIndexOf('?') + 2;
                resultado = resultado.Remove(caracterPrincipal, (caracterSecundario - caracterPrincipal));
                resultado = "<?xml version=" + "\"1.0\"" + " encoding=" + "\"UTF-8\"" + "?>" + resultado;
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.LoadXml(resultado);


                string fechaautorizacion = "", mensaje = "", infoadicional = "", tipo = "", claveconsultada = "", numeroAutorizacion = "";
                string estado = doc.GetElementsByTagName("estado")[0].InnerText;
                string ambiente = doc.GetElementsByTagName("ambiente")[0].InnerText;
                claveconsultada = doc.GetElementsByTagName("claveAccesoConsultada")[0].InnerText;

                if (estado == "AUTORIZADO")
                {
                    numeroAutorizacion = doc.GetElementsByTagName("numeroAutorizacion")[0].InnerText;
                    Console.WriteLine("AUTORIZADO");
                    Console.WriteLine("Nº Autorizacion: " + numeroAutorizacion);
                    Console.WriteLine("Clave Consultada: " + claveconsultada);
                    Console.WriteLine("Ambiente: " + ambiente);
                    fechaautorizacion = doc.GetElementsByTagName("fechaAutorizacion")[0].InnerText;
                    Console.WriteLine("Fecha de autorizacion: " + fechaautorizacion);
                    System.Xml.XmlNode element = doc.SelectSingleNode("numeroAutorizacion");
                    datosTributarios = new DatosTributarios
                    {
                        claveAcceso = doc.GetElementsByTagName("claveAcceso")[0].InnerText,
                        numeroAutorizacion = doc.GetElementsByTagName("numeroAutorizacion")[0].InnerText,
                        FechaAutorizacion = Convert.ToDateTime(doc.GetElementsByTagName("fechaAutorizacion")[0].InnerText),
                        Estado = doc.GetElementsByTagName("estado")[0].InnerText,
                    };

                    if (!Directory.Exists(PathServer + @"\Autorizados\"))
                    {
                        Directory.CreateDirectory(PathServer + @"\Autorizados\");
                    }

                    doc.Save(PathServer + @"\Autorizados\" + claveAcceso + ".xml");
                }
                else
                {
                    tipo = doc.GetElementsByTagName("tipo")[0].InnerText;
                    mensaje = doc.GetElementsByTagName("mensaje")[0].InnerText;
                    infoadicional = doc.GetElementsByTagName("informacionAdicional")[0].InnerText;
                    Console.WriteLine("Estado: NO AUTORIZADO");
                    Console.WriteLine("Clave Consultada: " + claveconsultada);
                    Console.WriteLine("Ambiente: " + ambiente);
                    Console.WriteLine("Mensaje: " + mensaje);
                    Console.WriteLine("Info. Adicional: " + infoadicional);
                    Console.WriteLine("Tipo: " + tipo);
                    if (!Directory.Exists(PathServer + @"\No Autorizados\"))
                    {
                        Directory.CreateDirectory(PathServer + @"\No Autorizados\");
                    }

                    doc.Save(PathServer + @"\No Autorizados\" + claveAcceso + ".xml");
                }

                return datosTributarios;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        string sUrl = "";
        string sSoapAction = "";
        public string xmlResultado = "";
        Consultas objConsultas = new Consultas();
        public SRIAutorizacionComprobante(string urlVerificacion)
        {
            //this.sUrl = "https://cel.sri.gob.ec/comprobantes-electronicos-ws/AutorizacionComprobantes";
            this.sUrl = urlVerificacion;
            this.sSoapAction = "AutorizacionComprobante";
        }

        public string AutorizacionArchivos(string sClaveAcceso, string PathServer, string estadorecepcion)
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
                    //Fecha para autorizar
                    FechaAutorizacion = Convert.ToDateTime(docxml.GetElementsByTagName("fechaAutorizacion")[0].InnerText).ToString();
                    estado += ";" + FechaAutorizacion;
                    if (!Directory.Exists(PathServer + @"\Autorizados\"))
                    {
                        Directory.CreateDirectory(PathServer + @"\Autorizados\");
                    }
                    docxmlSRI.Save(@PathServer + @"\Autorizados\" + @"\" + sClaveAcceso + ".xml");
                    MessageBox.Show("Estado: " + estadorecepcion + "\nAutorización: " + estado + "\nAmbiente: " + ambiente + "\nClave Acceso: " + claveAcceso + "\nNumero de Autorización: " + numeroAutorizacion + "\nFecha Autorización: " + FechaAutorizacion);
                }
                else
                {
                    string CodigoError = docxml.GetElementsByTagName("identificador")[0].InnerText;
                    tipo = docxml.GetElementsByTagName("tipo")[0].InnerText;
                    mensaje = docxml.GetElementsByTagName("mensaje")[1].InnerText;
                    try
                    {
                        infoadicional = docxml.GetElementsByTagName("informacionAdicional")[0].InnerText;
                        infoadicional = Funcion.reemplazarcaracterSignosNopermitidos(infoadicional);
                    }
                    catch (Exception ex)
                    {
                        infoadicional = "";
                    }
                    string fechaEmision = docxml.GetElementsByTagName("fechaEmision")[0].InnerText;
                    if (!Directory.Exists(PathServer + @"\No Autorizados\"))
                    {
                        Directory.CreateDirectory(PathServer + @"\No Autorizados\");
                    }
                    docxmlSRI.Save(@PathServer + @"\No Autorizados\" + @"\" + sClaveAcceso + ".xml");
                    string rutaNAT = @PathServer + @"\No Autorizados\";
                    string fechafinal = Funcion.reemplazarcaracterFecha(fechaEmision);


                    if (objConsultas.ExisteEnFacturaElectro("NombreXML", sClaveAcceso, "TbErroresDocEnviados"))
                    {
                        objConsultas.EjecutarSQLFactElectronica("UPDATE [dbo].[TbErroresDocEnviados] SET [Ruta] = '" + rutaNAT + "' ,[FechaEmision] ='" + fechafinal + "',[EstadoError] = '" + 1 + "',[MensajeError] = '" + mensaje + "' ,[CodigoError] ='" + CodigoError + "' ,[InformacionAdicional] = '" + infoadicional + "' WHERE  = '" + sClaveAcceso + "'" + "'");
                    }
                    else
                    {
                        objConsultas.EjecutarSQLFactElectronica("INSERT INTO [dbo].[TbErroresDocEnviados]([NombreXML],[Ruta],[FechaEmision] ,[EstadoError],[InformacionAdicional],[CodigoError],[MensajeError] )" +
                            "VALUES ('" + sClaveAcceso + "','" + rutaNAT + "','" + fechafinal + "','" + 1 + "','" + infoadicional + "','" + CodigoError + "','" + mensaje + "')");
                    }


                    MessageBox.Show("Estado: " + estadorecepcion + "\nAutorización: " + estado + "\nAmbiente: " + ambiente + "\nClave Acceso: " + claveAcceso + "\nError: " + mensaje + "\n:Info. Adicional: " + infoadicional);
                }

            }
            catch (Exception ex)
            {
                sResult = ex.Message;

            }

            return estado;
        }
    }
}
