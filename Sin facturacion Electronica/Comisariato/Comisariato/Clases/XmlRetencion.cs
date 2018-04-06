using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Comisariato.Clases
{
    class XmlRetencion
    {
        XmlDocument doc;
        string rutaXml;

        public void _crearXml(string ruta, string nodoRaiz)
        {

            this.rutaXml = ruta;
            doc = new XmlDocument();

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");

            XmlNode root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);


            //XmlNode element1 = doc.CreateElement(nodoRaiz);

            XmlElement newCd = doc.CreateElement(nodoRaiz);
            newCd.SetAttribute("id", "comprobante");
            newCd.SetAttribute("version", "1.0.0");

            doc.AppendChild(newCd);
            doc.Save(ruta);

        }

        public void InfoTributaria(string nodoraiz, InfoTributaria objcinfotributaria, string serie,string claveacceso)
        {
            doc.Load(rutaXml);
            string fecha = DateTime.Now.Date.ToShortDateString();
            //tipocomprobante de acuedo a la tabla 4
            //string claveacceso = objcinfotributaria.GenerarClaveAcceso(fecha, "1", serie);
            XmlNode NodoInfoTributarios = CrearInfoTributarios(objcinfotributaria, serie, claveacceso);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(NodoInfoTributarios, nodoRaiz.LastChild);

            doc.Save(rutaXml);
        }

        private XmlNode CrearInfoTributarios(InfoTributaria objc,string serie, string claveacceso)
        {
            XmlNode SubNodototalConImpuestos = doc.CreateElement("infoTributaria");

            XmlElement nodoambiente = doc.CreateElement("ambiente");
            nodoambiente.InnerText =""+ objc.Ambiente;
            SubNodototalConImpuestos.AppendChild(nodoambiente);

            XmlElement nodotipoEmision = doc.CreateElement("tipoEmision");
            nodotipoEmision.InnerText = ""+objc.TipoEmision;
            SubNodototalConImpuestos.AppendChild(nodotipoEmision);

            XmlElement nodorazonSocial = doc.CreateElement("razonSocial");
            nodorazonSocial.InnerText = objc.RazonSociaL;
            SubNodototalConImpuestos.AppendChild(nodorazonSocial);

            XmlElement nodonombreComercial = doc.CreateElement("nombreComercial");
            nodonombreComercial.InnerText = objc.NombreComerciaL;
            SubNodototalConImpuestos.AppendChild(nodonombreComercial);

            XmlElement nodoruc = doc.CreateElement("ruc");
            nodoruc.InnerText = objc.RuC;
            SubNodototalConImpuestos.AppendChild(nodoruc);

            //string fecha = DateTime.Now.Date.ToShortDateString();
            //string claveacceso = objc.GenerarClaveAcceso(fecha, "1", serie);
            XmlElement nodoclaveacceso = doc.CreateElement("claveAcceso");
            nodoclaveacceso.InnerText = claveacceso;
            SubNodototalConImpuestos.AppendChild(nodoclaveacceso);

            XmlElement nodocodDoc = doc.CreateElement("codDoc");
            nodocodDoc.InnerText = objc.CodDoC;
            SubNodototalConImpuestos.AppendChild(nodocodDoc);

            XmlElement nodoestab = doc.CreateElement("estab");
            nodoestab.InnerText = objc.EstaB;
            SubNodototalConImpuestos.AppendChild(nodoestab);

            XmlElement nodoptoEmi = doc.CreateElement("ptoEmi");
            nodoptoEmi.InnerText = objc.PtoEmI;
            SubNodototalConImpuestos.AppendChild(nodoptoEmi);

            XmlElement nodosecuencial = doc.CreateElement("secuencial");
            nodosecuencial.InnerText = objc.SecuenciaL;
            SubNodototalConImpuestos.AppendChild(nodosecuencial);


            XmlElement nododirMatriz = doc.CreateElement("dirMatriz");
            nododirMatriz.InnerText = objc.DirMatriz;
            SubNodototalConImpuestos.AppendChild(nododirMatriz);

            return SubNodototalConImpuestos;

        }

        public void infoCompRetencion(InfoCompRetencion objciCompRetencion)
        {
            doc.Load(rutaXml);
            string fecha = DateTime.Now.Date.ToShortDateString();
          
            XmlNode NodoInfoTributarios = CrearInfoCompRetencion(objciCompRetencion.FechaEmision, objciCompRetencion.DirEstablecimiento, objciCompRetencion.ContribuyenteEspecial, objciCompRetencion.ObligadoContabilidad, objciCompRetencion.TipoIdentificacionSujetoRetenido, objciCompRetencion.RazonSocialSujetoRetenido, objciCompRetencion.IdentificacionSujetoRetenido, objciCompRetencion.PeriodoFiscal);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(NodoInfoTributarios, nodoRaiz.LastChild);

            doc.Save(rutaXml);
        }

        public void impuestos(DataGridView dgv,string serie,string fecha,string tipoDocumento)
        {
            doc.Load(rutaXml);
            //string fecha = DateTime.Now.Date.ToShortDateString();
            XmlNode impuestos = doc.CreateElement("impuestos");

            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (dgv.Rows[i].Cells[0].Value != null)
                {
                    XmlNode NodoDetalles = null;



                    string codigoRetencionIva = "";
                    string Codigo = "";
                    if (Convert.ToString(dgv.Rows[i].Cells[1].Value) == "FUENTE") //Si es impuesto a la renta
                    {
                        codigoRetencionIva = Convert.ToString(dgv.Rows[i].Cells[8].Value);
                        Codigo = "1";
                    }
                    else //Si es impuesto I.V.A
                    {
                        Codigo = "2";
                        switch (Convert.ToString(dgv.Rows[i].Cells[2].Value))
                        {
                            case "10":
                                codigoRetencionIva = "9";
                                break;
                            case "20":
                                codigoRetencionIva = "10";
                                break;
                            case "30":
                                codigoRetencionIva = "1";
                                break;
                            case "50":
                                codigoRetencionIva = "11";
                                break;
                            case "70":
                                codigoRetencionIva = "2";
                                break;
                            case "100":
                                codigoRetencionIva = "3";
                                break;
                            default:
                                break;
                        }
                    }


                    //NodoDetalles = nodototalConImpuestos(Convert.ToString(dgv.Rows[i].Cells[2].Value), Convert.ToString(dgv.Rows[i].Cells[9].Value), Convert.ToString(dgv.Rows[i].Cells[3].Value), Convert.ToString(dgv.Rows[i].Cells[2].Value), Convert.ToString(dgv.Rows[i].Cells[4].Value), "0"+ tipoDocumento, serie, Funcion.FormarFecha(fecha));
                    NodoDetalles = nodototalConImpuestos(Codigo, codigoRetencionIva, Funcion.reemplazarcaracter(Convert.ToDouble(Funcion.reemplazarcaracterViceversa(dgv.Rows[i].Cells[3].Value.ToString())).ToString("#####0.00")), Convert.ToString(dgv.Rows[i].Cells[2].Value), Funcion.reemplazarcaracter(Convert.ToDouble(Funcion.reemplazarcaracterViceversa(dgv.Rows[i].Cells[4].Value.ToString())).ToString("#####0.00")), /*"0" + tipoDocumento*/ tipoDocumento, serie, fecha);

                    impuestos.AppendChild(NodoDetalles);
                }
                else
                    break;
            }


            //XmlNode NodoInfoTributarios = CrearInfoCompRetencion(objciCompRetencion.FechaEmision, objciCompRetencion.DirEstablecimiento, objciCompRetencion.ContribuyenteEspecial, objciCompRetencion.ObligadoContabilidad, objciCompRetencion.TipoIdentificacionSujetoRetenido, objciCompRetencion.RazonSocialSujetoRetenido, objciCompRetencion.IdentificacionSujetoRetenido, objciCompRetencion.PeriodoFiscal);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(impuestos, nodoRaiz.LastChild);

            doc.Save(rutaXml);
        }

        public void infoAdicional(string correo)
        {
            doc.Load(rutaXml);
            XmlNode Subcampoadicinal = doc.CreateElement("infoAdicional");

            XmlElement nodocodigo = doc.CreateElement("campoAdicional");
            nodocodigo.InnerText = correo;
            Subcampoadicinal.AppendChild(nodocodigo);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(Subcampoadicinal, nodoRaiz.LastChild);

            doc.Save(rutaXml);
        }


        private XmlNode nodototalConImpuestos(string codigo, string codigoRetencion,string baseImponible,string porcentajeRetener,string valorRetenido,string codDocSustento,string numDocSustento,string fechaEmisionDocSustento)
        {
            //doc.Load(rutaXml);
            XmlNode SubNodototalConImpuestos = doc.CreateElement("impuesto");

            XmlElement nodocodigo = doc.CreateElement("codigo");
            nodocodigo.InnerText = codigo;
            SubNodototalConImpuestos.AppendChild(nodocodigo);

            XmlElement nodocodigoRetencion = doc.CreateElement("codigoRetencion");
            nodocodigoRetencion.InnerText = codigoRetencion;
            SubNodototalConImpuestos.AppendChild(nodocodigoRetencion);

            XmlElement nodobaseImponible = doc.CreateElement("baseImponible");
            nodobaseImponible.InnerText = baseImponible;
            SubNodototalConImpuestos.AppendChild(nodobaseImponible);

            XmlElement nodoporcentajeRetener = doc.CreateElement("porcentajeRetener");
            nodoporcentajeRetener.InnerText = porcentajeRetener;
            SubNodototalConImpuestos.AppendChild(nodoporcentajeRetener);

            XmlElement nodovalorRetenido = doc.CreateElement("valorRetenido");
            nodovalorRetenido.InnerText = valorRetenido;
            SubNodototalConImpuestos.AppendChild(nodovalorRetenido);


            XmlElement nodocodDocSustento = doc.CreateElement("codDocSustento");
            nodocodDocSustento.InnerText = codDocSustento;
            SubNodototalConImpuestos.AppendChild(nodocodDocSustento);

            XmlElement nodonumDocSustento = doc.CreateElement("numDocSustento");
            nodonumDocSustento.InnerText = numDocSustento;
            SubNodototalConImpuestos.AppendChild(nodonumDocSustento);

            XmlElement nodofechaEmisionDocSustento = doc.CreateElement("fechaEmisionDocSustento");
            nodofechaEmisionDocSustento.InnerText = fechaEmisionDocSustento;
            SubNodototalConImpuestos.AppendChild(nodofechaEmisionDocSustento);

            return SubNodototalConImpuestos;

        }


        private XmlNode CrearInfoCompRetencion(string fechaEmision, string dirEstablecimiento, string contribuyenteEspecial, string obligadoContabilidad, string tipoIdentificacionSujetoRetenido, string razonSocialSujetoRetenido, string identificacionSujetoRetenido, string periodoFiscal)
        {
            XmlNode Nodoraiz = doc.CreateElement("infoCompRetencion");

            fechaEmision = Convert.ToDateTime(fechaEmision).ToShortDateString();

            XmlElement nodofechaEmision = doc.CreateElement("fechaEmision");
            nodofechaEmision.InnerText = fechaEmision;
            Nodoraiz.AppendChild(nodofechaEmision);

            XmlElement nododirEstablecimiento = doc.CreateElement("dirEstablecimiento");
            nododirEstablecimiento.InnerText = dirEstablecimiento;
            Nodoraiz.AppendChild(nododirEstablecimiento);

            if (contribuyenteEspecial != "No")
            {
                XmlElement nodocontribuyenteEspecial = doc.CreateElement("contribuyenteEspecial");
                nodocontribuyenteEspecial.InnerText = contribuyenteEspecial;
                Nodoraiz.AppendChild(nodocontribuyenteEspecial);
            }

            XmlElement nodoobligadoContabilidad = doc.CreateElement("obligadoContabilidad");
            nodoobligadoContabilidad.InnerText = obligadoContabilidad;
            Nodoraiz.AppendChild(nodoobligadoContabilidad);

            XmlElement nodotipoIdentificacionSujetoRetenido = doc.CreateElement("tipoIdentificacionSujetoRetenido");
            nodotipoIdentificacionSujetoRetenido.InnerText = tipoIdentificacionSujetoRetenido;
            Nodoraiz.AppendChild(nodotipoIdentificacionSujetoRetenido);

            XmlElement nodorazonSocialSujetoRetenido = doc.CreateElement("razonSocialSujetoRetenido");
            nodorazonSocialSujetoRetenido.InnerText = razonSocialSujetoRetenido;
            Nodoraiz.AppendChild(nodorazonSocialSujetoRetenido);

            XmlElement nodoidentificacionSujetoRetenido = doc.CreateElement("identificacionSujetoRetenido");
            nodoidentificacionSujetoRetenido.InnerText = identificacionSujetoRetenido;
            Nodoraiz.AppendChild(nodoidentificacionSujetoRetenido);

            XmlElement nodoperiodoFiscal = doc.CreateElement("periodoFiscal");
            nodoperiodoFiscal.InnerText = periodoFiscal;
            Nodoraiz.AppendChild(nodoperiodoFiscal);


            return Nodoraiz;
        }



    }
}
