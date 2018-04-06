using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SysX509 = System.Security.Cryptography.X509Certificates;
using java.security.cert;
using java.security;
using java.io;
using java.util;
using es.mityc.javasign.pkstore;
using es.mityc.javasign.pkstore.keystore;
using sviudes.blogspot.com;

namespace Comisariato.Clases
{
    class Certificado
    {
        public String NameSujeto;
        public String Entidad;
        public SysX509.X509Certificate2 certificado;

        public List<string> CertificadoVerificar(string rutaCertificado, string claveDelCertificado = null)
        {


            SysX509.X509Certificate2 certificado = new SysX509.X509Certificate2(rutaCertificado, claveDelCertificado);

            List<string> datos = new List<string>();
            datos.Add(certificado.GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType.DnsName, true));


            String[] DatosSujeto = certificado.SubjectName.Decode(SysX509.X500DistinguishedNameFlags.None).Split('=');
            datos.Add(DatosSujeto[DatosSujeto.Length - 1]);

            return datos;

        }


        public SysX509.X509Certificate2 Certificadop12(string rutaCertificado, string claveDelCertificado = null)
        {


            SysX509.X509Certificate2 certificado = new SysX509.X509Certificate2(rutaCertificado, claveDelCertificado);
            Entidad = certificado.GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType.DnsName, true);


            String[] DatosSujeto = certificado.SubjectName.Decode(SysX509.X500DistinguishedNameFlags.None).Split('=');
            NameSujeto = DatosSujeto[DatosSujeto.Length - 1];
            this.certificado = certificado;
            return certificado;


        }


        public static X509Certificate LoadCertificate(string path, string password, ref PrivateKey privateKey, ref Provider provider)
        {
            //versión no usada que lee el certificado desde un archivo
            //ver siguiente método

            X509Certificate certificate = null;
            provider = null;
            privateKey = null;

            //Cargar certificado de fichero PFX
            KeyStore ks = KeyStore.getInstance("PKCS12");
            ks.load(new BufferedInputStream(new FileInputStream(path)), password.ToCharArray());

            IPKStoreManager storeManager = new KSStore(ks, new PassStoreKS(password));
            List certificates = storeManager.getSignCertificates();


            //Si encontramos el certificado...
            if (certificates.size() > 0)
            {
                certificate = ((X509Certificate)certificates.get(1));

                // Obtención de la clave privada asociada al certificado
                privateKey = storeManager.getPrivateKey(certificate);

                // Obtención del provider encargado de las labores criptográficas
                provider = storeManager.getProvider(certificate);
            }

            return certificate;
        }
    }
}
