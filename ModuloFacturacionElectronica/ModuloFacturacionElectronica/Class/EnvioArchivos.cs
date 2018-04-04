using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFacturacionElectronica.Class
{
    public class EnvioArchivos
    {
        
        public static void EnviarArchivos(string pathXml,string ContraseñaCertificado,string RutaXML1,string NombreXML,string LinkSRIrecepcion , string LinkSRIautorizacion,string nombreEmpresa,string EmailEmpresa,string passEmail,ref int contadorRecibida,ref int contadorAutorizado,ref int contadorNoautorizados,ref int contadorDevuelta)
        {
            try
            {
                Consultas Objconsul = new Consultas();
                int estadoautorizacion = 0;
                string Recibida = "D", AUT = "NO";
                //Firmar Documento
                Firma.Firmalo(pathXml, ContraseñaCertificado, RutaXML1 + @"\Generados\" + NombreXML + ".xml", RutaXML1 + @"\Firmados\" + NombreXML + ".xml", RutaXML1);

                SRIRecepcionComprobante sriRecepcion = new SRIRecepcionComprobante();
                string respuestaRecepcion = sriRecepcion.RecepcionArchivos(RutaXML1 + @"\Firmados" + @"\" + NombreXML + ".xml", LinkSRIrecepcion, NombreXML, RutaXML1);
                //Fin RecepcionSRI
                //RECIBIDA
                if (respuestaRecepcion == "RECIBIDA")
                {
                    contadorRecibida++;
                    Recibida = "R";
                    SRIAutorizacionComprobante sriAutori = new SRIAutorizacionComprobante(LinkSRIautorizacion, nombreEmpresa, EmailEmpresa, passEmail);
                    string estado = sriAutori.AutorizacionArchivos(NombreXML, RutaXML1);
                    if (estado != "")
                    {
                        if (estado == "AUTORIZADO")
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
                        Objconsul.EjecutarSQL("UPDATE [dbo].[TbDocumentosGeneradosFact] SET [EstadoAutorizacion] = '" + estadoautorizacion + "',[RecepcionSRI] ='" + Recibida + "',[AutorizadoSRI]='" + AUT + "'  WHERE  NombreXML = '" + NombreXML + "'");
                    }

                }
                else
                {

                    contadorDevuelta++;
                    Recibida = "D";
                    estadoautorizacion = 0;
                    AUT = "NO";
                    Objconsul.EjecutarSQL("UPDATE [dbo].[TbDocumentosGeneradosFact] SET [EstadoAutorizacion] = '" + estadoautorizacion + "',[RecepcionSRI] ='" + Recibida + "',[AutorizadoSRI]='" + AUT + "'  WHERE  NombreXML = '" + NombreXML + "'");

                }
            }
            catch (Exception ex)
            {

                //throw;
            }
           
        }
    }
}
