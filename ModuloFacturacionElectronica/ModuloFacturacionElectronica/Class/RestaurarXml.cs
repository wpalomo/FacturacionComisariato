using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFacturacionElectronica.Class
{

    class RestaurarXml
    {
        Consultas objC;
        private string claveacceso;
        private string fecha;
        private string PathServer;
        private string NombreGuardar;
        List<String> ConsutarFactura;
        List<Producto> DetalleFactura;
        public RestaurarXml(string Pclaveacceso, string Pfecha, string PpathServer,string NombreGuardar)
        {
            this.claveacceso = Pclaveacceso;
            this.fecha = Pfecha;
            this.PathServer = PpathServer;
            this.NombreGuardar = NombreGuardar;
            objC = new Consultas();

        }

        public bool FormarXml()
        {
            try
            {
                fecha = Funcion.reemplazarcaracterFecha(fecha);
                ConsutarFactura = objC.ConsutarFactura(fecha, claveacceso);
                if (ConsutarFactura.Count > 0)
                {
                    Xml xml = new Xml();
                    string[] vector = ConsutarFactura[0].Split(';');
                    int sucursal = Convert.ToInt32(vector[0]);
                    int caja = Convert.ToInt32(vector[1]);
                    string claveacceso = vector[3].Trim();


                    //string claveacc = myXmlDocument.GetElementsByTagName("claveAcceso")[0].InnerText;
                    string Substr = claveacceso.Substring(0, 23);
                    string subStri2 = claveacceso.Substring(24, 24);
                    string claveAccesoNueva = Substr + "2" + subStri2;
                    claveacceso = Modulo11(claveAccesoNueva);

                    int NumeroFactura = Convert.ToInt32(vector[2]);

                    if (!Directory.Exists(PathServer+ @"\Generados\"))
                    {
                        Directory.CreateDirectory(PathServer + @"\Generados\");
                    }
                    xml._crearXml(PathServer + @"\Generados\" + NombreGuardar + ".xml", "factura");
                    InfoTributaria InfoTributaria = new InfoTributaria();
                    InfoTributaria.Ambiente = 2;
                    InfoTributaria.TipoEmision = 1;
                    InfoTributaria.RazonSociaL = "VEGA SOLIS SONNA JUDITH";
                    InfoTributaria.NombreComerciaL = "COMISARIATO SUPER 2";
                    InfoTributaria.RuC = "1802114429001";
                    InfoTributaria.CodDoC = "01";
                    InfoTributaria.EstaB = "001";
                    InfoTributaria.PtoEmI = caja.ToString("D3");
                    InfoTributaria.SecuenciaL = NumeroFactura.ToString("D9");
                    InfoTributaria.DirMatriz = "VIA GUAYAS Y ABDON CALDERON 207";
                    xml.InfoTributaria("infoTributaria", InfoTributaria, claveacceso);

                    InfoFactura infoFactura = new InfoFactura();
                    fecha = Funcion.reemplazarcaracterFechaViceversa(fecha);
                    infoFactura.FechaEmision = fecha;
                    infoFactura.DirEstablecimiento = "VIA GUAYAS Y ABDON CALDERON 207";
                    infoFactura.ObligadoContabilidad = "SI";
                    if (vector[4]!="9999999999999")
                    {
                        if (vector[4].Length==10)
                        {
                            infoFactura.TipoIdentificacionComprador = "05";
                        }
                        else
                        {
                            infoFactura.TipoIdentificacionComprador = "04";
                        }
                    }
                    else
                    {
                        infoFactura.TipoIdentificacionComprador = "07";
                    }
                   
                    infoFactura.GuiaRemision =sucursal.ToString("D3")+ "-" + caja.ToString("D3") + "-" + NumeroFactura.ToString("D9");
                    infoFactura.RazonSocialComprador = vector[5];
                    infoFactura.IdentificacionComprador = vector[4];
                    infoFactura.DireccionComprador = vector[6];
                    infoFactura.TotalDescuento = "0.00";
                    infoFactura.Propina = "0.00";

                    objC = new Consultas();
                    double totalSinImpuesto = 0, ivapreci = 0, to = 0;
                    DetalleFactura = objC.DetalleFact(NumeroFactura, caja);
                    for (int j = 0; j < DetalleFactura.Count; j++)
                    {
                        totalSinImpuesto += DetalleFactura[j].Cantidad * DetalleFactura[j].Preciopublico_sin_iva;
                        if (DetalleFactura[j].Iva == 12)
                        {
                            ivapreci += ((DetalleFactura[j].Cantidad * DetalleFactura[j].Preciopublico_sin_iva) * 12) / 100;
                        }

                    }
                    to = totalSinImpuesto + ivapreci;
                    //string importeTotal= docxml.GetElementsByTagName("importeTotal")[0].InnerText;
                    infoFactura.TotalSinImpuestos = "" + totalSinImpuesto.ToString("#####0.00");
                    infoFactura.ImporteTotal = to.ToString("#####0.00");/*totalpagar.ToString("#####0.00");*/

                    xml.infoFactura("infoFactura", infoFactura, to.ToString("#####0.00"), DetalleFactura);
                    xml.detalleFactura("detalles", DetalleFactura);
                    DetalleFactura = new List<Producto>();

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        private string Modulo11(string clave)
        {
            ClaveAcceso ObjClave = new ClaveAcceso();
            string clave1 = ObjClave.invertirCadena(clave);
            int numeroVerificador = ObjClave.obtenerSumaPorDigitos(clave1);
            clave += "" + numeroVerificador;
            return clave;
        }
    }
}
