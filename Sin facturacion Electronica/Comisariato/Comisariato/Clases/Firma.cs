using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using es.mityc.javasign.trust;
using java.security;
using java.security.cert;
using es.mityc.javasign.xml.xades.policy;
using es.mityc.firmaJava.libreria.xades;
using es.mityc.javasign.xml.refs;
using java.io;
using es.mityc.firmaJava.libreria.utilidades;
using org.w3c.dom;
using javax.xml.parsers;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Comisariato.Clases
{
    class Firma
    {
        public static Document LoadXML(string path)
        {
            DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
            dbf.setNamespaceAware(true);
            return dbf.newDocumentBuilder().parse(new BufferedInputStream(new FileInputStream(path)));
        }


        public static string Firmalo(string pathCertificado, string password, string sRutaXml, string RutaXmlFirmado,string PathServer)
        {

            sRutaXml = sRutaXml.Trim();
            string result = "";
            if (sRutaXml.Length == 0)
            {
                result = "Por favor indique la ruta al XML";
                return result;
            }
            if (!System.IO.File.Exists(sRutaXml))
            {
                result = "No existe el archivo XML especificado";
                return result;
            }
            //My.Settings.Save()
            java.security.PrivateKey privateKey = null;
            Provider provider = null;
            //muestra el selector de Windows
            Certificado cer = new Certificado();
            java.security.cert.X509Certificate certificate = Certificado.LoadCertificate(pathCertificado, password, ref privateKey, ref provider);
            if (certificate == null)
            {
                result = "Seleccione un certificado";
                return result;
            }

            if (certificate != null)
            {
                //Política de firma (Con las librerías JAVA, esto se define en tiempo de ejecución)
                TrustFactory.instance = es.mityc.javasign.trust.TrustExtendFactory.newInstance();
                TrustFactory.truster = es.mityc.javasign.trust.MyPropsTruster.getInstance();
                PoliciesManager.POLICY_SIGN = new es.mityc.javasign.xml.xades.policy.facturae.Facturae31Manager();
                PoliciesManager.POLICY_VALIDATION = new es.mityc.javasign.xml.xades.policy.facturae.Facturae31Manager();

                //Crear datos a firmar
                DataToSign dataToSign = new DataToSign();
                dataToSign.setXadesFormat(EnumFormatoFirma.XAdES_BES);
                //XAdES-EPES
                dataToSign.setEsquema(XAdESSchemas.XAdES_132);
                dataToSign.setPolicyKey("facturae31");
                //Da igual lo que pongamos aquí, la política de firma se define arriba
                dataToSign.setAddPolicy(true);
                dataToSign.setXMLEncoding("UTF-8");
                dataToSign.setEnveloped(true);
                dataToSign.addObject(new ObjectToSign(new InternObjectToSign("comprobante"), "powered by Tech Link", null, "text/xml", null));
                dataToSign.setDocument(LoadXML(sRutaXml));

                //Firmar
                object[] res = new es.mityc.firmaJava.libreria.xades.FirmaXML().signFile(certificate, dataToSign, privateKey, provider);

                //var PathServer = @"C:\ArchivosXml";
                //Copiamos el archivo en la direccion correspondiente
                if (!Directory.Exists(PathServer + @"\Firmados\"))
                {
                    Directory.CreateDirectory(PathServer + @"\Firmados\");
                }


                System.IO.File.Copy(sRutaXml, RutaXmlFirmado, true);

                // Guardamos la firma a un fichero

                sRutaXml = RutaXmlFirmado;

                //Modificamos
                FileOutputStream fos = new FileOutputStream(sRutaXml);
                UtilidadTratarNodo.saveDocumentToOutputStream(((Document)res[0]), fos, true);
                fos.close();


            }
            return result;
        }
        static T DirectCast<T>(object o) where T : class
        {
            T value = o as T;
            if (value == null && o != null)
            {
                throw new InvalidCastException();
            }
            return value;
        }
    }
}
