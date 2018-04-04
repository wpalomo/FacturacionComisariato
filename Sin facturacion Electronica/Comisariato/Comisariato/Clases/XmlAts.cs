using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Comisariato.Clases
{
    class XmlAts
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
            //newCd.SetAttribute("id", "comprobante");
            //newCd.SetAttribute("version", "1.1.0");

            doc.AppendChild(newCd);
            doc.Save(ruta);

        }

        public void EmcabezadoAts(EmcabezadoAts objcinfotributaria)
        {
            doc.Load(rutaXml);
           
            XmlNode nodoRaiz = doc.DocumentElement;
            // XmlNode NodoInfoTributarios = CrearInfoTributarios(objcinfotributaria, nodoRaiz);
            XmlElement nodoambiente = doc.CreateElement("TipoIDInformante");
            nodoambiente.InnerText = objcinfotributaria.TipoidInformante;
            nodoRaiz.AppendChild(nodoambiente);

            XmlElement nodoemision = doc.CreateElement("IdInformante");
            nodoemision.InnerText = objcinfotributaria.Idinformante;
            nodoRaiz.AppendChild(nodoemision);

            XmlElement nodorazonsocial = doc.CreateElement("razonSocial");
            nodorazonsocial.InnerText = objcinfotributaria.Razonsocial;
            nodoRaiz.AppendChild(nodorazonsocial);

            XmlElement nodonombreComercial = doc.CreateElement("Anio");
            nodonombreComercial.InnerText = objcinfotributaria.Anio;
            nodoRaiz.AppendChild(nodonombreComercial);

            XmlElement nodoruc = doc.CreateElement("Mes");
            nodoruc.InnerText = objcinfotributaria.Mes;
            nodoRaiz.AppendChild(nodoruc);

            XmlElement nodoclaveAcceso = doc.CreateElement("numEstabRuc");
            nodoclaveAcceso.InnerText = objcinfotributaria.Numestabruc;
            nodoRaiz.AppendChild(nodoclaveAcceso);

            XmlElement nodocodDoc = doc.CreateElement("totalVentas");
            nodocodDoc.InnerText = objcinfotributaria.Totalventas;
            nodoRaiz.AppendChild(nodocodDoc);

            XmlElement nodoestab = doc.CreateElement("codigoOperativo");
            nodoestab.InnerText = objcinfotributaria.Codigooperativo;
            nodoRaiz.AppendChild(nodoestab);



            //nodoRaiz.InsertAfter(NodoInfoTributarios, nodoRaiz.LastChild);

            doc.Save(rutaXml);
        }



        List<ValoresCompraAts> detalleCompraPieyEnca = new List<ValoresCompraAts>();
        List<NotadeCreditoATS> ValoresNotaCreditoATS = new List<NotadeCreditoATS>();
        Consultas ObjConsul = new Consultas();
        public void NodoCompras(List<string> claveAcceso, string PathServer, string fechainicio, string fechaFin)
        {
            doc.Load(rutaXml);
            XmlNode NodosCompras = doc.CreateElement("compras");
            //detalleCompraPieyEnca = ObjConsul.ObtenerListaStringdetalleCompra("select TOTALIVA,TOTALICE,TOTALIRBP,SUBTOTALIVA,SUBTOTAL0,SUBTOTAL,TOTAL from TbEncabezadoyPieCompra where SERIE1 = '" + objDetalleCompras.Establecimiento + "'and SERIE2 ='" + objDetalleCompras.PuntoEmision + "' and NUMERO = '" + objDetalleCompras.Secuencial + "'");
            detalleCompraPieyEnca = ObjConsul.ObtenerListaStringdetalleCompra("select Compra.TOTALIVA, Compra.TOTALICE, Compra.TOTALIRBP, Compra.SUBTOTALIVA, Compra.SUBTOTAL0, Compra.SUBTOTAL,Compra.TOTAL, EncaOrdenG.SERIE1PROVEEDOR as SERIE1, EncaOrdenG.SERIE2PROVEEDOR as SERIE2, EncaOrdenG.NUMERODOCUMENTOPROVEEDOR as NUMERO,EncaOrdenG.AUTORIZACIONPROVEEDOR, EncaOrdenG.FORMAPAGO, Provee.IDENTIFICACION from TbEncabezadoyPieCompra Compra, TbEncabezadoOrdenGiro EncaOrdenG, TbProveedor Provee where Provee.IDPROVEEDOR = EncaOrdenG.IDPROVEEDOR and Compra.IDEMCABEZADOCOMPRA = EncaOrdenG.IDEMCABEZADOCOMPRA AND EncaOrdenG.ESTADO = 1   and Convert(varchar(10),FECHAORDENGIRO,112) BETWEEN '" + Funcion.FormarFechaGuiones(fechainicio) + "' AND '" + Funcion.FormarFechaGuiones(fechaFin) + "'");
            
            ValoresNotaCreditoATS = ObjConsul.ObtenerListaStringNotaCreditoATS("Select P.IDENTIFICACION,P.TIPOIDENTIFICACION ,N.SERIE1,N.SERIE2,N.NUMERO,N.FECHA,N.AUTORIZACION, N.SUBTOTAL0,N.SUBTOTAL12,N.ICE,N.IVA,C.SERIE1 as serie1FactProvee,C.SERIE2 as serie2FactProvee,C.NUMERO as secuencialFactProvee, O.AUTORIZACIONPROVEEDOR,N.IRBP from TbEncabezadoNotaCredito N, TbEncabezadoyPieCompra C, TbProveedor P, TbEncabezadoOrdenGiro O where N.IDENCABEZADOCOMPRA = C.IDEMCABEZADOCOMPRA and C.IDPROVEEDOR = P.IDPROVEEDOR and O.IDEMCABEZADOCOMPRA = C.IDEMCABEZADOCOMPRA  AND N.ESTADO = '1' and N.FECHA BETWEEN '" + fechainicio + "' AND '" + fechaFin + "'");


            for (int i = 0; i <= claveAcceso.Count - 1; i++)
            {



                XmlNode NodoDetalles = null;
                string asds = PathServer + @"\Generados\" + claveAcceso[i] + ".xml";
                if (System.IO.File.Exists(PathServer + @"\Generados\" + claveAcceso[i] + ".xml"))
                {
                    if (i == 297)
                    {
                        string a = "dsad";
                    }
                    DetalleCompras objDetalleCompras = new DetalleCompras();
                    XmlDocument xDoc = new XmlDocument();

                    xDoc.Load(PathServer + @"\Generados\" + claveAcceso[i] + ".xml");
                    Console.WriteLine("Posible Error: " + i);
                    //codDocSustento
                    objDetalleCompras.CodSustento = xDoc.GetElementsByTagName("codDocSustento")[0].InnerText;

                    objDetalleCompras.IdProv = xDoc.GetElementsByTagName("identificacionSujetoRetenido")[0].InnerText;
                    if (xDoc.GetElementsByTagName("identificacionSujetoRetenido")[0].InnerText.Length == 10)
                    {
                        objDetalleCompras.TpIdProv = "02";
                    }
                    else if (xDoc.GetElementsByTagName("identificacionSujetoRetenido")[0].InnerText.Length == 13)
                    {
                        objDetalleCompras.TpIdProv = "01";
                    }
                    else
                    {
                        objDetalleCompras.TpIdProv = "03";
                    }
                    objDetalleCompras.TipoComprobante = "01";
                    objDetalleCompras.ParteRel = "NO";

                    objDetalleCompras.FechaRegistro = Funcion.fechaValida(xDoc.GetElementsByTagName("fechaEmision")[0].InnerText);//fechaEmision
                                                                                                                                  //objDetalleCompras.Establecimiento= xDoc.GetElementsByTagName("fechaEmision")[0].InnerText;
                    string SERIE = xDoc.GetElementsByTagName("numDocSustento")[0].InnerText;
                    objDetalleCompras.Establecimiento = SERIE.Substring(0, 3);
                    objDetalleCompras.PuntoEmision = SERIE.Substring(3, 3);
                    objDetalleCompras.Secuencial = SERIE.Substring(6, 9);
                    //objDetalleCompras.Establecimiento = detalleCompraPieyEnca[i].SERIE11;
                    //objDetalleCompras.PuntoEmision = detalleCompraPieyEnca[i].SERIE21;
                    //objDetalleCompras.Secuencial = detalleCompraPieyEnca[i].NUMERO1;
                    objDetalleCompras.FechaEmision = Funcion.FormarFecha(xDoc.GetElementsByTagName("fechaEmision")[0].InnerText);
                    //verificar posible error puede ser la autorizacion del proveedor
                    //objDetalleCompras.Autorizacion = xDoc.GetElementsByTagName("claveAcceso")[0].InnerText;

                    objDetalleCompras.Autorizacion = detalleCompraPieyEnca[i].AUTORIZACION1;
                    //detalleCompraPieyEnca = ObjConsul.ObtenerListaStringdetalleCompra("select TOTALIVA,TOTALICE,TOTALIRBP,SUBTOTALIVA,SUBTOTAL0,SUBTOTAL,TOTAL from TbEncabezadoyPieCompra where SERIE1 = '" + objDetalleCompras.Establecimiento + "'and SERIE2 ='" + objDetalleCompras.PuntoEmision + "' and NUMERO = '" + objDetalleCompras.Secuencial + "'");

                    //Thread.Sleep(500);
                    //detalleCompraPieyEnca = ObjConsul.ObtenerListaStringdetalleCompra("select TOTALIVA,TOTALICE,TOTALIRBP,SUBTOTALIVA,SUBTOTAL0,SUBTOTAL,TOTAL from TbEncabezadoyPieCompra where SERIE1 = '" + objDetalleCompras.Establecimiento + "'and SERIE2 ='" + objDetalleCompras.PuntoEmision + "' and NUMERO = '" + objDetalleCompras.Secuencial + "'");


                    string detalleCompra = ValoresAts(detalleCompraPieyEnca, objDetalleCompras.Establecimiento, objDetalleCompras.PuntoEmision, objDetalleCompras.Secuencial, objDetalleCompras.IdProv);

                    //if (detalleCompraPieyEnca[i].NUMERO1 == "000000802")
                    //{
                    //    MessageBox.Show("");
                    //}

                    string[] arregloDetalleCompra = detalleCompra.Split(';');


                    //verificar 
                    objDetalleCompras.BaseNoGraIva = Funcion.reemplazarcaracter(Convert.ToDouble(arregloDetalleCompra[5]).ToString("#####0.00"));
                    //objDetalleCompras.BaseNoGraIva = Funcion.reemplazarcaracter(Convert.ToDouble(detalleCompraPieyEnca[4]).ToString("#####0.00"));
                    //baseImponible
                    objDetalleCompras.BaseImponible = Funcion.reemplazarcaracter(Convert.ToDouble(arregloDetalleCompra[1]).ToString("#####0.00"));
                    //objDetalleCompras.BaseImponible = Funcion.reemplazarcaracter(Convert.ToDouble(detalleCompraPieyEnca[5]).ToString("#####0.00"));
                    //objDetalleCompras.BaseImpGrav = Funcion.reemplazarcaracter(Convert.ToDouble(detalleCompraPieyEnca[3]).ToString("#####0.00"));
                    objDetalleCompras.BaseImpGrav = Funcion.reemplazarcaracter(Convert.ToDouble(arregloDetalleCompra[2]).ToString("#####0.00"));
                    //verificar
                    objDetalleCompras.BaseImpExe = "0.00";
                    objDetalleCompras.MontoIce = Funcion.reemplazarcaracter(Convert.ToDouble(arregloDetalleCompra[4]).ToString("#####0.00"));
                    objDetalleCompras.MontoIva = Funcion.reemplazarcaracter(Convert.ToDouble(arregloDetalleCompra[3]).ToString("#####0.00"));
                    //objDetalleCompras.MontoIce = Funcion.reemplazarcaracter(Convert.ToDouble(detalleCompraPieyEnca[1]).ToString("#####0.00"));
                    //objDetalleCompras.MontoIva = Funcion.reemplazarcaracter(Convert.ToDouble(detalleCompraPieyEnca[0]).ToString("#####0.00"));

                    objDetalleCompras.ValRetBien10 = "0.00";
                    objDetalleCompras.ValRetServ20 = "0.00";
                    objDetalleCompras.ValorRetBienes = "0.00";
                    objDetalleCompras.ValRetServ50 = "0.00";
                    objDetalleCompras.ValorRetServicios = "0.00";
                    objDetalleCompras.ValRetServ100 = "0.00";
                    objDetalleCompras.TotbasesImpReemb = "0.00";
                    //DATOS NODO PAGO EXTERIOR
                    objDetalleCompras.PagoLocExt = "01";
                    objDetalleCompras.PaisEfecPago = "NA";
                    objDetalleCompras.AplicConvDobTrib = "NA";
                    objDetalleCompras.PagextsujRetNorLeg = "NA";


                    //DATOS METODO PAGOS

                    objDetalleCompras.FormaPago = detalleCompraPieyEnca[i].FORMAPAGO1;

                    //DATOS NODOS AIR
                    //baseImponible
                    objDetalleCompras.CodRetAir = xDoc.GetElementsByTagName("codigoRetencion")[0].InnerText;
                    objDetalleCompras.BaseImpAir = xDoc.GetElementsByTagName("baseImponible")[0].InnerText;
                    objDetalleCompras.PorcentajeAir = xDoc.GetElementsByTagName("porcentajeRetener")[0].InnerText;
                    objDetalleCompras.ValRetAir = xDoc.GetElementsByTagName("valorRetenido")[0].InnerText;


                    //DATOS NODOS DATOS RETENCION

                    objDetalleCompras.EstabRetencion1 = xDoc.GetElementsByTagName("estab")[0].InnerText;
                    objDetalleCompras.PtoEmiRetencion1 = xDoc.GetElementsByTagName("ptoEmi")[0].InnerText;
                    objDetalleCompras.SecRetencion1 = xDoc.GetElementsByTagName("secuencial")[0].InnerText;
                    objDetalleCompras.AutRetencion1 = xDoc.GetElementsByTagName("claveAcceso")[0].InnerText;
                    objDetalleCompras.FechaEmiRet1 = Funcion.FormarFecha(xDoc.GetElementsByTagName("fechaEmision")[0].InnerText);

                    NodoDetalles = CrearNodoInfoFactura(objDetalleCompras, true, xDoc);
                    NodosCompras.AppendChild(NodoDetalles);



                }
            }
            //Creamos los nodos de Nota de Credito
            CrearNodosNotadeCredito(ValoresNotaCreditoATS, ref NodosCompras);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(NodosCompras, nodoRaiz.LastChild);

            doc.Save(rutaXml);
        }


        private void CrearNodosNotadeCredito(List<NotadeCreditoATS> ValoresNotaCreditoATS ,ref XmlNode nodoCompras)
        {
            for (int i = 0; i < ValoresNotaCreditoATS.Count; i++)
            {
                XmlNode NodoDetalles = null;
                DetalleCompras objDetalleCompras = new DetalleCompras();
                objDetalleCompras.CodSustento = ValoresNotaCreditoATS[i].CodSustento;
                objDetalleCompras.TpIdProv = ValoresNotaCreditoATS[i].TpIdProv;
                objDetalleCompras.IdProv = ValoresNotaCreditoATS[i].IdProv;
                objDetalleCompras.TipoComprobante = ValoresNotaCreditoATS[i].TipoComprobante;
                objDetalleCompras.ParteRel = ValoresNotaCreditoATS[i].ParteRel;
                objDetalleCompras.FechaRegistro = Convert.ToDateTime(ValoresNotaCreditoATS[i].FechaRegistro).ToShortDateString();
                objDetalleCompras.Establecimiento = ValoresNotaCreditoATS[i].Establecimiento;
                objDetalleCompras.PuntoEmision = ValoresNotaCreditoATS[i].PuntoEmision;
                objDetalleCompras.Secuencial = ValoresNotaCreditoATS[i].Secuencial;
                objDetalleCompras.FechaEmision = Convert.ToDateTime(ValoresNotaCreditoATS[i].FechaEmision).ToShortDateString();
                objDetalleCompras.Autorizacion = ValoresNotaCreditoATS[i].Autorizacion;
                objDetalleCompras.BaseNoGraIva = Funcion.reemplazarcaracter(Convert.ToDouble(ValoresNotaCreditoATS[i].BaseNoGraIva).ToString("#####0.00"));
                objDetalleCompras.BaseImponible = Funcion.reemplazarcaracter(Convert.ToDouble(ValoresNotaCreditoATS[i].BaseImponible).ToString("#####0.00"));
                objDetalleCompras.BaseImpGrav = Funcion.reemplazarcaracter(Convert.ToDouble(ValoresNotaCreditoATS[i].BaseImpGrav).ToString("#####0.00"));
                objDetalleCompras.BaseImpExe = Funcion.reemplazarcaracter(Convert.ToDouble(ValoresNotaCreditoATS[i].BaseImpExe).ToString("#####0.00"));
                objDetalleCompras.MontoIce = Funcion.reemplazarcaracter(Convert.ToDouble(ValoresNotaCreditoATS[i].MontoIce).ToString("#####0.00"));
                objDetalleCompras.MontoIva = Funcion.reemplazarcaracter(Convert.ToDouble(ValoresNotaCreditoATS[i].MontoIva).ToString("#####0.00"));
                objDetalleCompras.ValorRetBienes = ValoresNotaCreditoATS[i].ValorRetBienes;
                objDetalleCompras.ValRetBien10 = ValoresNotaCreditoATS[i].ValRetBien10;
                objDetalleCompras.ValRetServ20 = ValoresNotaCreditoATS[i].ValRetServ20;
                objDetalleCompras.ValRetServ50 = ValoresNotaCreditoATS[i].ValRetServ50;
                objDetalleCompras.ValorRetServicios = ValoresNotaCreditoATS[i].ValorRetServicios;
                objDetalleCompras.ValRetServ100 = ValoresNotaCreditoATS[i].ValRetServ100;
                objDetalleCompras.TotbasesImpReemb = ValoresNotaCreditoATS[i].TotbasesImpReemb;
                objDetalleCompras.PagoLocExt = ValoresNotaCreditoATS[i].PagoLocExt;
                objDetalleCompras.PaisEfecPago = ValoresNotaCreditoATS[i].PaisEfecPago;
                objDetalleCompras.AplicConvDobTrib = ValoresNotaCreditoATS[i].AplicConvDobTrib;
                objDetalleCompras.PagextsujRetNorLeg = ValoresNotaCreditoATS[i].PagExtSujRetNorLeg;
                objDetalleCompras.DocModificado = ValoresNotaCreditoATS[i].DocModificado;
                objDetalleCompras.EstabModificado = ValoresNotaCreditoATS[i].EstabModificado;
                objDetalleCompras.PtoEmiModificado = ValoresNotaCreditoATS[i].PtoEmiModificado;
                objDetalleCompras.SecModificado = ValoresNotaCreditoATS[i].SecModificado;
                objDetalleCompras.AutModificado = ValoresNotaCreditoATS[i].AutModificado;
                //se crea el nodo
                NodoDetalles = CrearNodoInfoFactura(objDetalleCompras, false,null);
                nodoCompras.AppendChild(NodoDetalles);


            }
        }

        private String ValoresAts(List<ValoresCompraAts> ListaValoresCompras, string serie1, string serie2, string serie3, string identificacionProveedor)
        {
            string datos = "";
            try
            {
                for (int i = 0; i < ListaValoresCompras.Count; i++)
                {
                    
                    if (Convert.ToInt32(ListaValoresCompras[i].SERIE11).ToString("D3")==serie1 &&Convert.ToInt32( ListaValoresCompras[i].SERIE21).ToString("D3")==serie2 &&Convert.ToInt32(ListaValoresCompras[i].NUMERO1).ToString("D9")==serie3 
                        && ListaValoresCompras[i].IDENTIFICACIONPROVEEDOR1 == identificacionProveedor)
                    {
                        datos = ListaValoresCompras[i].SUBTOTAL1 + ";" 
                            + ListaValoresCompras[i].SUBTOTAL01 + ";" 
                            + ListaValoresCompras[i].SUBTOTALIVA1 + ";"
                            + ListaValoresCompras[i].TOTALIVA1 + ";" 
                            + ListaValoresCompras[i].TOTALICE1 + ";" 
                            + ListaValoresCompras[i].TOTALIRBP1 + ";" 
                            + ListaValoresCompras[i].TOTAL1;
                        break;
                    }
                }
                return datos;
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private XmlNode CrearNodoInfoFactura(DetalleCompras objcdetalleCompras, bool crearSubNodoAir, XmlDocument xDoc)
        {
           // XmlNode Nodoraiz = doc.CreateElement("compras");

            XmlNode SubNodoraiz= doc.CreateElement("detalleCompras");

            XmlElement nodofechaemision = doc.CreateElement("codSustento");
            nodofechaemision.InnerText = objcdetalleCompras.CodSustento;
            SubNodoraiz.AppendChild(nodofechaemision);

          
            XmlElement nododirEstablecimiento = doc.CreateElement("tpIdProv");
            nododirEstablecimiento.InnerText = objcdetalleCompras.TpIdProv;
            SubNodoraiz.AppendChild(nododirEstablecimiento);

            XmlElement nodoobligadoContabilidad = doc.CreateElement("idProv");
            nodoobligadoContabilidad.InnerText = objcdetalleCompras.IdProv;
            SubNodoraiz.AppendChild(nodoobligadoContabilidad);

            XmlElement nodotipoIdentificacionComprador = doc.CreateElement("tipoComprobante");
            if (objcdetalleCompras.CodSustento=="02")
            {
                nodotipoIdentificacionComprador.InnerText = "02";
            }
            else
            {
                nodotipoIdentificacionComprador.InnerText = objcdetalleCompras.TipoComprobante;
            }

            
            SubNodoraiz.AppendChild(nodotipoIdentificacionComprador);

            XmlElement nodoguiaremision = doc.CreateElement("parteRel");
            nodoguiaremision.InnerText = objcdetalleCompras.ParteRel;
            SubNodoraiz.AppendChild(nodoguiaremision);

            XmlElement nodorazonSocialComprador = doc.CreateElement("fechaRegistro");
            nodorazonSocialComprador.InnerText = objcdetalleCompras.FechaEmision;
            SubNodoraiz.AppendChild(nodorazonSocialComprador);

            XmlElement nodoidentificacionComprador = doc.CreateElement("establecimiento");
            nodoidentificacionComprador.InnerText = objcdetalleCompras.Establecimiento;
            SubNodoraiz.AppendChild(nodoidentificacionComprador);

            XmlElement nododireccioncomprador = doc.CreateElement("puntoEmision");
            nododireccioncomprador.InnerText = objcdetalleCompras.PuntoEmision;
            SubNodoraiz.AppendChild(nododireccioncomprador);

            XmlElement nodototalSinImpuestos = doc.CreateElement("secuencial");
            nodototalSinImpuestos.InnerText = objcdetalleCompras.Secuencial;
            SubNodoraiz.AppendChild(nodototalSinImpuestos);

            XmlElement nodofechaEmision = doc.CreateElement("fechaEmision");
            nodofechaEmision.InnerText = objcdetalleCompras.FechaEmision;
            SubNodoraiz.AppendChild(nodofechaEmision);

   

            XmlElement nodoimporteTotal = doc.CreateElement("autorizacion");
            nodoimporteTotal.InnerText = objcdetalleCompras.Autorizacion;
            SubNodoraiz.AppendChild(nodoimporteTotal);

            XmlElement nodomoneda = doc.CreateElement("baseNoGraIva");
            nodomoneda.InnerText = objcdetalleCompras.BaseNoGraIva;
            SubNodoraiz.AppendChild(nodomoneda);

            XmlElement nodobaseimponible = doc.CreateElement("baseImponible");
            nodobaseimponible.InnerText = objcdetalleCompras.BaseImponible;
            SubNodoraiz.AppendChild(nodobaseimponible);

            XmlElement nodobaseImpGrav = doc.CreateElement("baseImpGrav");
            nodobaseImpGrav.InnerText = objcdetalleCompras.BaseImpGrav;
            SubNodoraiz.AppendChild(nodobaseImpGrav);

            XmlElement nodobaseImpExe = doc.CreateElement("baseImpExe");
            nodobaseImpExe.InnerText = objcdetalleCompras.BaseImpExe;
            SubNodoraiz.AppendChild(nodobaseImpExe);

            XmlElement nodomontoIce = doc.CreateElement("montoIce");
            nodomontoIce.InnerText = objcdetalleCompras.MontoIce;
            SubNodoraiz.AppendChild(nodomontoIce);

            XmlElement nodomontoIva = doc.CreateElement("montoIva");
            nodomontoIva.InnerText = objcdetalleCompras.MontoIva;
            SubNodoraiz.AppendChild(nodomontoIva);

            string valor10 = "0.00", valor20 = "0.00", valor30="0.00", valor50="0.00", valor70="0.00", valor100="0.00";
            if (xDoc != null)
            {
                int cantidadnodos = CantidadNodoImpuesto(xDoc);
                if (cantidadnodos == 1)
                {
                    if (xDoc.GetElementsByTagName("codigo")[0].InnerText == "2")
                    {
                        Valores(xDoc, ref valor10, ref valor20, ref valor30, ref valor50, ref valor70, ref valor100);
                    }
                }
                else if (cantidadnodos == 2)
                {
                    if (xDoc.GetElementsByTagName("codigo")[0].InnerText == "2" || xDoc.GetElementsByTagName("codigo")[1].InnerText == "2")
                    {
                        Valores(xDoc, ref valor10, ref valor20, ref valor30, ref valor50, ref valor70, ref valor100);
                    }
                }
            }

            XmlElement nodovalRetBien10 = doc.CreateElement("valRetBien10");
            nodovalRetBien10.InnerText = valor10;
            SubNodoraiz.AppendChild(nodovalRetBien10);

            XmlElement nodovalRetServ20 = doc.CreateElement("valRetServ20");
            nodovalRetServ20.InnerText = valor20;
            SubNodoraiz.AppendChild(nodovalRetServ20);

            XmlElement nodovalorRetBienes = doc.CreateElement("valorRetBienes");
            nodovalorRetBienes.InnerText = valor30;
            SubNodoraiz.AppendChild(nodovalorRetBienes);

            XmlElement nodovalRetServ50 = doc.CreateElement("valRetServ50");
            nodovalRetServ50.InnerText = valor50;
            SubNodoraiz.AppendChild(nodovalRetServ50);

            XmlElement nodovalorRetServicios = doc.CreateElement("valorRetServicios");
            nodovalorRetServicios.InnerText = valor70;
            SubNodoraiz.AppendChild(nodovalorRetServicios);

            XmlElement nodovalRetServ100 = doc.CreateElement("valRetServ100");
            nodovalRetServ100.InnerText = valor100;
            SubNodoraiz.AppendChild(nodovalRetServ100);

            XmlElement nodototbasesImpReemb = doc.CreateElement("totbasesImpReemb");
            nodototbasesImpReemb.InnerText = objcdetalleCompras.TotbasesImpReemb;
            SubNodoraiz.AppendChild(nodototbasesImpReemb);

            //PAGO EXTERIOR
            XmlNode SubNodoPagoExterior = doc.CreateElement("pagoExterior");

            XmlElement nodopagoLocExt = doc.CreateElement("pagoLocExt");
            nodopagoLocExt.InnerText = objcdetalleCompras.PagoLocExt;
            SubNodoPagoExterior.AppendChild(nodopagoLocExt);

            XmlElement nodopaisEfecPago = doc.CreateElement("paisEfecPago");
            nodopaisEfecPago.InnerText = objcdetalleCompras.PaisEfecPago;
            SubNodoPagoExterior.AppendChild(nodopaisEfecPago);

            XmlElement nodoaplicConvDobTrib = doc.CreateElement("aplicConvDobTrib");
            nodoaplicConvDobTrib.InnerText = objcdetalleCompras.AplicConvDobTrib;
            SubNodoPagoExterior.AppendChild(nodoaplicConvDobTrib);

            XmlElement nodopagExtSujRetNorLeg = doc.CreateElement("pagExtSujRetNorLeg");
            nodopagExtSujRetNorLeg.InnerText = objcdetalleCompras.PagextsujRetNorLeg;
            SubNodoPagoExterior.AppendChild(nodopagExtSujRetNorLeg);
            //FIN NODO EXTERIOR



            SubNodoraiz.AppendChild(SubNodoPagoExterior);

            XmlElement nodoformasDePago = doc.CreateElement("formasDePago");
            XmlElement SubnodoformasDePago = doc.CreateElement("formaPago");
            if (objcdetalleCompras.FormaPago=="EFECTIVO")
            {

                SubnodoformasDePago.InnerText = "01";
               

            } //objcdetalleCompras.FormaPago
            else
            {
                SubnodoformasDePago.InnerText = "20";
            }
            nodoformasDePago.AppendChild(SubnodoformasDePago);
            SubNodoraiz.AppendChild(nodoformasDePago);

            //si se crea subnodo Air
            if (crearSubNodoAir)
            {
                //subnodo air
                // XmlNode SubNodoair = NodoAir(xDoc);

                XmlNode SubNodoair = doc.CreateElement("air");
                XmlNode SubNododetalleAir = doc.CreateElement("detalleAir");

                XmlElement nodocodRetAir = doc.CreateElement("codRetAir");
                nodocodRetAir.InnerText = objcdetalleCompras.CodRetAir;
                SubNododetalleAir.AppendChild(nodocodRetAir);

                XmlElement nodobaseImpAir = doc.CreateElement("baseImpAir");
                nodobaseImpAir.InnerText = objcdetalleCompras.BaseImpAir;
                SubNododetalleAir.AppendChild(nodobaseImpAir);

                XmlElement nodoporcentajeAir = doc.CreateElement("porcentajeAir");
                nodoporcentajeAir.InnerText = objcdetalleCompras.PorcentajeAir;
                SubNododetalleAir.AppendChild(nodoporcentajeAir);

                XmlElement nodovalRetAir = doc.CreateElement("valRetAir");
                nodovalRetAir.InnerText = objcdetalleCompras.ValRetAir;
                SubNododetalleAir.AppendChild(nodovalRetAir);

                SubNodoair.AppendChild(SubNododetalleAir);

                SubNodoraiz.AppendChild(SubNodoair);

                // DATOS DE LA RETENCION
                XmlElement nodoEstabRetencion1 = doc.CreateElement("estabRetencion1");
                nodoEstabRetencion1.InnerText = objcdetalleCompras.EstabRetencion1;
                SubNodoraiz.AppendChild(nodoEstabRetencion1);

                XmlElement nodoPtoEmiRetencion1 = doc.CreateElement("ptoEmiRetencion1");
                nodoPtoEmiRetencion1.InnerText = objcdetalleCompras.PtoEmiRetencion1;
                SubNodoraiz.AppendChild(nodoPtoEmiRetencion1);

                XmlElement nodoSecRetencion1 = doc.CreateElement("secRetencion1");
                nodoSecRetencion1.InnerText = objcdetalleCompras.SecRetencion1;
                SubNodoraiz.AppendChild(nodoSecRetencion1);

                XmlElement nodoAutRetencion1 = doc.CreateElement("autRetencion1");
                nodoAutRetencion1.InnerText = objcdetalleCompras.AutRetencion1;
                SubNodoraiz.AppendChild(nodoAutRetencion1);

                XmlElement nodoFechaEmiRet1 = doc.CreateElement("fechaEmiRet1");
                nodoFechaEmiRet1.InnerText = objcdetalleCompras.FechaEmiRet1;
                SubNodoraiz.AppendChild(nodoFechaEmiRet1);

            }
            else
            {
                XmlElement nododocModificado = doc.CreateElement("docModificado");
                nododocModificado.InnerText = objcdetalleCompras.DocModificado;
                SubNodoraiz.AppendChild(nododocModificado);

                XmlElement nodoestabModificado = doc.CreateElement("estabModificado");
                nodoestabModificado.InnerText = objcdetalleCompras.EstabModificado;
                SubNodoraiz.AppendChild(nodoestabModificado);

                XmlElement nodoptoEmiModificado = doc.CreateElement("ptoEmiModificado");
                nodoptoEmiModificado.InnerText = objcdetalleCompras.PtoEmiModificado;
                SubNodoraiz.AppendChild(nodoptoEmiModificado);

                XmlElement nodosecModificado = doc.CreateElement("secModificado");
                nodosecModificado.InnerText = objcdetalleCompras.SecModificado;
                SubNodoraiz.AppendChild(nodosecModificado);

                XmlElement nodoautModificado = doc.CreateElement("autModificado");
                nodoautModificado.InnerText = objcdetalleCompras.AutModificado;
                SubNodoraiz.AppendChild(nodoautModificado);
            }




            return SubNodoraiz;
        }

        private XmlNode NodoAir(XmlDocument xDoc)
        {
            try
            {
                XmlNode SubNodoair = doc.CreateElement("air");
                XmlNode node = xDoc.DocumentElement;
                foreach (XmlNode nodo in node.ChildNodes)
                {
                    if (nodo.Name == "impuestos")
                    {
                        foreach (XmlNode nodo1 in nodo.ChildNodes)
                        {
                            if (nodo1.Name == "impuesto")
                            {
                                int cantidadnodos = CantidadNodoImpuesto(xDoc);
                                for (int i = 0; i < cantidadnodos; i++)
                                {
                                    XmlNode SubNododetalleAir = doc.CreateElement("detalleAir");

                                    XmlElement nodocodRetAir = doc.CreateElement("codRetAir");
                                    nodocodRetAir.InnerText = xDoc.GetElementsByTagName("codigoRetencion")[i].InnerText; 
                                    SubNododetalleAir.AppendChild(nodocodRetAir);

                                    XmlElement nodobaseImpAir = doc.CreateElement("baseImpAir");
                                    nodobaseImpAir.InnerText = xDoc.GetElementsByTagName("baseImponible")[i].InnerText; 
                                    SubNododetalleAir.AppendChild(nodobaseImpAir);

                                    XmlElement nodoporcentajeAir = doc.CreateElement("porcentajeAir");
                                    nodoporcentajeAir.InnerText = xDoc.GetElementsByTagName("porcentajeRetener")[i].InnerText;
                                    SubNododetalleAir.AppendChild(nodoporcentajeAir);

                                    XmlElement nodovalRetAir = doc.CreateElement("valRetAir");
                                    nodovalRetAir.InnerText = xDoc.GetElementsByTagName("valorRetenido")[i].InnerText;
                                    SubNododetalleAir.AppendChild(nodovalRetAir);

                                    SubNodoair.AppendChild(SubNododetalleAir);
                                }
                                break;
                            }
                        }
                    }
                }
                return SubNodoair;
            }
            catch (Exception)
            {

               return null;
            }
        }

        private void  Valores(XmlDocument xDoc,ref string valor10, ref string valor20, ref string valor30, ref string valor50,ref string valor70, ref string valor100 )
        {
            try
            {
                XmlNode SubNodoair = doc.CreateElement("air");
                XmlNode node = xDoc.DocumentElement;
                foreach (XmlNode nodo in node.ChildNodes)
                {
                    if (nodo.Name == "impuestos")
                    {
                        foreach (XmlNode nodo1 in nodo.ChildNodes)
                        {
                            if (nodo1.Name == "impuesto")
                            {
                                int cantidadnodos = CantidadNodoImpuesto(xDoc);
                                for (int i = 0; i < cantidadnodos; i++)
                                {
                                    if (xDoc.GetElementsByTagName("porcentajeRetener")[i].InnerText=="10")
                                    {
                                        valor10 = xDoc.GetElementsByTagName("valorRetenido")[i].InnerText;
                                    }
                                    if (xDoc.GetElementsByTagName("porcentajeRetener")[i].InnerText == "20")
                                    {
                                        valor20 = xDoc.GetElementsByTagName("valorRetenido")[i].InnerText;
                                    }
                                    if (xDoc.GetElementsByTagName("porcentajeRetener")[i].InnerText == "30")
                                    {
                                        valor30 = xDoc.GetElementsByTagName("valorRetenido")[i].InnerText;
                                    }
                                    if (xDoc.GetElementsByTagName("porcentajeRetener")[i].InnerText == "50")
                                    {
                                        valor50 = xDoc.GetElementsByTagName("valorRetenido")[i].InnerText;
                                    }
                                    if (xDoc.GetElementsByTagName("porcentajeRetener")[i].InnerText == "70")
                                    {
                                        valor70 = xDoc.GetElementsByTagName("valorRetenido")[i].InnerText;
                                    }
                                    if (xDoc.GetElementsByTagName("porcentajeRetener")[i].InnerText == "100")
                                    {
                                        valor100 = xDoc.GetElementsByTagName("valorRetenido")[i].InnerText;
                                    }

                                }
                                break;
                            }
                        }
                    }
                }
               // return SubNodoair;
            }
            catch (Exception)
            {

              //  return null;
            }
        }




        private int CantidadNodoImpuesto(XmlDocument xDoc)
        {
            try
            {
                int contador = 0;
                XmlNode node;
                node = xDoc.DocumentElement;
                foreach (XmlNode nodo in node.ChildNodes)
                {
                    if (nodo.Name== "impuestos")
                    {
                        foreach (XmlNode nodo1 in nodo.ChildNodes)
                        {
                            if (nodo1.Name== "impuesto")
                            {
                                contador++;
                               
                            }
                        }
                        break;
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
