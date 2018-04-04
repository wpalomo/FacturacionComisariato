using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.Windows.Forms;
using System.Configuration;

namespace Comisariato.Clases
{
    public class SRIRecepcionComprobante
    {
        /// <summary>
        /// RecepcionSRI
        /// </summary>
        /// 

        //public string LlamarSRIRecepcion(string DocXML, string nombrexml)
        //{
        //    try
        //    {
        //        string a = "";

        //        XmlDocument xmlDoc = new XmlDocument();
        //        var PathServer = ConfigurationManager.AppSettings["XmlServidor"];
        //        //var PathServer = @"C:\Users\Public\Documents\ArchivosXml";
        //        xmlDoc.Load(DocXML);
        //        string claveAcceso = xmlDoc.GetElementsByTagName("claveAcceso")[0].InnerText;
        //        if (claveAcceso.Length == 49)
        //        {
        //            StringBuilder rawXml = new StringBuilder();
        //            rawXml.Append(GetXmlString(xmlDoc));
        //            string xml = rawXml.ToString();
        //            string xmlfinal = Base64_Encode(xml);
        //            var Output = Encoding.UTF8.GetBytes(xmlDoc.OuterXml);
        //            string myLXmlBase64 = Convert.ToBase64String(Output);
        //            byte[] bytes = Convert.FromBase64String(myLXmlBase64);

        //            ServiceRecepcion.RecepcionComprobantesOfflineClient Recep = new ServiceRecepcion.RecepcionComprobantesOfflineClient();
        //            ServiceRecepcion.respuestaSolicitud RptService = (ServiceRecepcion.respuestaSolicitud)Recep.validarComprobante(bytes);
        //            a = RptService.estado;
        //            Console.WriteLine(a);
        //            if (a == "DEVUELTA")
        //            {

        //                ServiceRecepcion.validarComprobante c = new ServiceRecepcion.validarComprobante();
        //                c.xml = bytes;
        //                //System.IO.File.WriteAllBytes(@"C:\Users\Galito\Desktop\valida1.xml", c.xml);
        //                //File.Copy(@"C:\Users\Galito\Desktop\valida1.xml", @"\\192.168..0.96\C$\ArchivosXml\Generados\valida1.xml", true);

        //            }
        //            else
        //            {
        //                //Preguntar sobre el directorio

        //                if (!Directory.Exists(PathServer + @"\Enviados\"))
        //                {
        //                    Directory.CreateDirectory(PathServer + @"\Enviados\");
        //                }


        //                xmlDoc.Save(@PathServer + @"\Enviados\" + @"\" + nombrexml + ".xml");
        //                //System.IO.File.WriteAllBytes(@"C:\Users\Galito\Desktop\valida1.xml", bytes);
        //            }
        //            return a + ";" + claveAcceso;
        //        }
        //        else
        //        {
        //            return "claveincorrecta";
        //        }



        //    }
        //    catch (Exception ex)
        //    {
        //        return "error";
        //    }

        //}

        //>codificar
        public static string Base64_Encode(string str)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff);
        }
        //> Decodificar
        public static string Base64_Decode(string str)
        {
            try
            {
                byte[] decbuff = Convert.FromBase64String(str);
                return System.Text.Encoding.UTF8.GetString(decbuff);
            }
            catch
            {
                { return ""; }
            }
        }

        //Funcion para conversion
        static string GetXmlString(XmlDocument xmlDoc)
        {

            // Now create StringWriter object to get data from xml document.
            StringWriter sw = new StringWriter();
            XmlTextWriter xw = new XmlTextWriter(sw);
            xmlDoc.WriteTo(xw);
            return sw.ToString();
        }



        Consultas objConsultas = new Consultas();

        public string RecepcionArchivos(string pathDocumento, string urlDocumeto, string nombreArchivo,string PathServer)
        {
            //string PathServer = @"C:\ArchivosXml";
            _URLWS = urlDocumeto;
            byte[] bytes = File.ReadAllBytes(pathDocumento);
            object RESULTADO = "";
            //convertir el archivo en formato 64 bytes
            RESULTADO = Convert.ToBase64String(bytes);
            HttpWebRequest request = CreateWebRequest();
            XmlDocument soapEnvelopeXml = new XmlDocument();
            soapEnvelopeXml.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
                <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ec=""http://ec.gob.sri.ws.recepcion"">
                <soapenv:Header/>
                    <soapenv:Body>
                        <ec:validarComprobante>
                            <!--Optional:-->
                            <xml>" + RESULTADO + "</xml>" +
                        "</ec:validarComprobante>" +
                     "</soapenv:Body>" +
                    "</soapenv:Envelope>");
            string soapResult = "";
            try
            {
                using (Stream stream = request.GetRequestStream())
                {
                    soapEnvelopeXml.Save(stream);
                }
                try
                {
                    using (WebResponse response = request.GetResponse())
                    {
                        using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                        {
                            _xmlResutado = rd.ReadToEnd();
                        }
                    }
                }
                catch (Exception ex)
                {
                    soapResult = "Error en enviar al SRI" + ex.Message;

                    RecepcionArchivos(pathDocumento, urlDocumeto, nombreArchivo, PathServer);
                }
            }
            catch (Exception x)
            {
                soapResult = "Error en enviar al SRI" + x.Message;
            }


            XmlDocument docxml = new XmlDocument();
            docxml.Load(pathDocumento);

            XmlDocument docxml1 = new XmlDocument();
            docxml1.LoadXml(_xmlResutado);
            string estado = docxml1.GetElementsByTagName("estado")[0].InnerText;
            
            //Preguntar sobre el directorio

            if (estado == "RECIBIDA")
            {
                if (!Directory.Exists(PathServer + @"\Recibidos\"))
                {
                    Directory.CreateDirectory(PathServer + @"\Recibidos\");
                }
                docxml.Save(@PathServer + @"\Recibidos\" + @"\" + nombreArchivo + ".xml");

            }
            else
            {
                string CodigoError = docxml1.GetElementsByTagName("identificador")[0].InnerText;
                string mensaje = docxml1.GetElementsByTagName("mensaje")[1].InnerText;
                estado = estado + ";" + mensaje;
                string informacionAdicional = "";
                try
                {
                    informacionAdicional = docxml1.GetElementsByTagName("informacionAdicional")[0].InnerText;
                    informacionAdicional = Funcion.reemplazarcaracterSignosNopermitidos(informacionAdicional);
                }
                catch (Exception ex)
                {
                    informacionAdicional = "";
                }
                
                if (!Directory.Exists(PathServer + @"\Devueltos\"))
                {
                    Directory.CreateDirectory(PathServer + @"\Devueltos\");
                }
                
                docxml.Save(@PathServer + @"\Devueltos\" + @"\" + nombreArchivo + ".xml");

                string rutaNAT = @PathServer + @"\Devueltos\";

                string fechafinal = Funcion.reemplazarcaracterFecha(DateTime.Now.Date.ToShortDateString());
                

                if (objConsultas.ExisteEnFacturaElectro("NombreXML", nombreArchivo, "TbErroresDocEnviados"))
                {
                    objConsultas.EjecutarSQLFactElectronica("UPDATE [dbo].[TbErroresDocEnviados] SET [Ruta] = '" + rutaNAT + "' ,[FechaEmision] ='" + fechafinal + "',[EstadoError] = '" + 1 + "',[MensajeError] = '" + mensaje + "' ,[CodigoError] ='" + CodigoError + "' ,[InformacionAdicional] = '" + informacionAdicional + "' WHERE NombreXML = '" + nombreArchivo + "'");
                }
                else
                {
                    objConsultas.EjecutarSQLFactElectronica("INSERT INTO [dbo].[TbErroresDocEnviados]([NombreXML],[Ruta],[FechaEmision] ,[EstadoError],[CodigoError],[MensajeError],[InformacionAdicional] )" +
                    "VALUES ('" + nombreArchivo + "','" + rutaNAT + "','" + fechafinal + "','" + 1 + "','" + CodigoError + "','" + mensaje + "','" + informacionAdicional + "')");
                }

                MessageBox.Show("Estado: " + estado + "\nClave Acceso: " + nombreArchivo + "\nError: " + mensaje );

            }


            if (!Directory.Exists(PathServer + @"\Enviados\"))
            {
                Directory.CreateDirectory(PathServer + @"\Enviados\");
            }



            docxml.Save(@PathServer + @"\Enviados\" + @"\" + nombreArchivo + ".xml");




            return estado;
        }

        private string _URLWS;

        public string URLWS
        {
            get
            {
                return _URLWS;
            }

            set
            {
                _URLWS = value;
            }
        }

        public string XmlResutado
        {
            get
            {
                return _xmlResutado;
            }

            set
            {
                _xmlResutado = value;
            }
        }

        private string _xmlResutado;

        public HttpWebRequest CreateWebRequest()
        {
            //HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"https://celcer.sri.gob.ec/comprobantes-electronicos-ws/RecepcionComprobantes?wsdl");
            //HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"https://cel.sri.gob.ec/comprobantes-electronicos-ws/RecepcionComprobantes?wsdl");

            //OffLine
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(URLWS);

            webRequest.Headers.Add(@"SOAP:Action");
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }
    }
}

