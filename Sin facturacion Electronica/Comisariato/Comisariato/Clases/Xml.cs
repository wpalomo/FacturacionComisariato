using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Comisariato.Clases
{
    class Xml
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
            newCd.SetAttribute("version", "1.1.0");

            doc.AppendChild(newCd);
            doc.Save(ruta);

        }

        public void InfoTributaria(string nodoraiz, InfoTributaria objcinfotributaria, string serie,string claveacceso)
        {
            doc.Load(rutaXml);
            //string fecha = DateTime.Now.Date.ToShortDateString();
            //string claveacceso = objcinfotributaria.GenerarClaveAcceso(fecha,"1",serie);
            XmlNode NodoInfoTributarios = CrearInfoTributarios(""+objcinfotributaria.Ambiente,""+objcinfotributaria.TipoEmision,objcinfotributaria.RazonSociaL,objcinfotributaria.NombreComerciaL,objcinfotributaria.RuC, claveacceso,objcinfotributaria.CodDoC,objcinfotributaria.EstaB,objcinfotributaria.PtoEmI,objcinfotributaria.SecuenciaL,objcinfotributaria.DirMatriz);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(NodoInfoTributarios, nodoRaiz.LastChild);

            doc.Save(rutaXml);
        }

        public void infoFactura(string nodoraiz,InfoFactura objc, DataGridView dgvcheque,DataGridView dgvcredito, CheckBox chkefectivo, string valorefectivo, DataGridView dgvDetalleProductos)
        {
            doc.Load(rutaXml);

            XmlNode NodoInfoTributarios = CrearNodoInfoFactura(objc.FechaEmision,objc.DirEstablecimiento,objc.ContribuyenteEspecial,objc.ObligadoContabilidad,objc.TipoIdentificacionComprador,objc.RazonSocialComprador,objc.IdentificacionComprador,objc.TotalSinImpuestos,objc.TotalDescuento,objc.Codigo,objc.CodigoPorcentaje,objc.DescuentoAdicional,objc.BaseImponible,objc.Valor,objc.Propina,objc.ImporteTotal,objc.Moneda, objc.GuiaRemision, objc.DireccionComprador, dgvcheque, dgvcredito, chkefectivo,valorefectivo,dgvDetalleProductos);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(NodoInfoTributarios, nodoRaiz.LastChild);

            doc.Save(rutaXml);
        }

        public void detalleFactura(string nodoraiz, DataGridView dgv)
        {
            doc.Load(rutaXml);
            XmlNode detalles = doc.CreateElement("detalles");
            for (int i = 0; i < dgv.RowCount; i++)
            {
                XmlNode NodoDetalles=null;
                if (dgv.Rows[i].Cells[0].Value != null)
                {
                    // float preciototalsinimpuesto = Convert.ToSingle(Convert.ToString(dgv.Rows[i].Cells[2].Value))* Convert.ToSingle(Convert.ToString(dgv.Rows[i].Cells[10].Value));
                    //if (Convert.ToInt32(Convert.ToString(dgv.Rows[i].Cells[9].Value))==1)
                    //{
                    //    NodoDetalles = CrearNodoDetalle(Convert.ToString(dgv.Rows[i].Cells[0].Value), Convert.ToString(dgv.Rows[i].Cells[0].Value), Convert.ToString(dgv.Rows[i].Cells[1].Value), Funcion.reemplazarcaracter(Convert.ToString(dgv.Rows[i].Cells[2].Value)), Convert.ToString(dgv.Rows[i].Cells[4].Value), "0.00", "0.00", "2", "6", "0", "0.00", Convert.ToString(dgv.Rows[i].Cells[5].Value));
                    //}
                    //else
                    //{
                    //int valor = Convert.ToInt32(Convert.ToString(dgv.Rows[i].Cells[5].Value));
                    if (Convert.ToSingle(dgv.Rows[i].Cells[5].Value) == 0)
                    {
                        string valorUnitario = "0";
                        if (Convert.ToString(dgv.Rows[i].Cells[4].Value) == "0" || Convert.ToString(dgv.Rows[i].Cells[4].Value) == "0.00")
                        {
                            valorUnitario = Convert.ToString(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(Convert.ToString(dgv.Rows[i].Cells[10].Value))).ToString("#####0.00"));
                        }
                        else
                        {
                            valorUnitario = Convert.ToString(dgv.Rows[i].Cells[4].Value);
                        }
                        NodoDetalles = CrearNodoDetalle(Convert.ToString(dgv.Rows[i].Cells[0].Value), Convert.ToString(dgv.Rows[i].Cells[0].Value), Convert.ToString(dgv.Rows[i].Cells[1].Value), Funcion.reemplazarcaracter(Convert.ToString(dgv.Rows[i].Cells[2].Value)), valorUnitario, "0.00", "0.00", "2", "0", "0", "0.00", Convert.ToString(dgv.Rows[i].Cells[5].Value));
                    }
                    else
                    {
                        if (Program.IVA == "14")
                        {
                            NodoDetalles = CrearNodoDetalle(Convert.ToString(dgv.Rows[i].Cells[0].Value), Convert.ToString(dgv.Rows[i].Cells[0].Value), Convert.ToString(dgv.Rows[i].Cells[1].Value), Funcion.reemplazarcaracter(Convert.ToString(dgv.Rows[i].Cells[2].Value)), Convert.ToString(dgv.Rows[i].Cells[4].Value), "0.00", "0.00", "2", "3", "14.00", "0.00", Convert.ToString(dgv.Rows[i].Cells[5].Value));
                        }
                        else
                        {
                            NodoDetalles = CrearNodoDetalle(Convert.ToString(dgv.Rows[i].Cells[0].Value), Convert.ToString(dgv.Rows[i].Cells[0].Value), Convert.ToString(dgv.Rows[i].Cells[1].Value), Funcion.reemplazarcaracter(Convert.ToString(dgv.Rows[i].Cells[2].Value)), Convert.ToString(dgv.Rows[i].Cells[4].Value), "0.00", "0.00", "2", "2", "12.00", "0.00", Convert.ToString(dgv.Rows[i].Cells[5].Value));
                        }

                    }
                    //}
                    detalles.AppendChild(NodoDetalles);
                }
                else
                {
                    break;
                }
               
            }
            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(detalles, nodoRaiz.LastChild);

            doc.Save(rutaXml);
        }



        public XmlNode CrearNodoDetalle(string codigoPrincipal, string codigoAuxiliar, string descripcion, string cantidad, string precioUnitario, string descuento, string precioTotalSinImpuesto, string codigo, string codigoPorcentaje, string tarifa, string baseImponible, string valor)
        {
            XmlNode detalle = doc.CreateElement("detalle");


            XmlElement nodocodigoPrincipal = doc.CreateElement("codigoPrincipal");
            nodocodigoPrincipal.InnerText = codigoPrincipal;
            detalle.AppendChild(nodocodigoPrincipal);


            XmlElement nodocodigoAuxiliar = doc.CreateElement("codigoAuxiliar");
            nodocodigoAuxiliar.InnerText = codigoAuxiliar;
            detalle.AppendChild(nodocodigoAuxiliar);


            XmlElement nododescripcion = doc.CreateElement("descripcion");
            nododescripcion.InnerText = descripcion;
            detalle.AppendChild(nododescripcion);


            XmlElement nodocantidad = doc.CreateElement("cantidad");
            nodocantidad.InnerText = cantidad;
            detalle.AppendChild(nodocantidad);

            XmlElement nodoprecioUnitario = doc.CreateElement("precioUnitario");
            nodoprecioUnitario.InnerText = Funcion.reemplazarcaracter(precioUnitario);
            detalle.AppendChild(nodoprecioUnitario);

            XmlElement nododescuento = doc.CreateElement("descuento");
            nododescuento.InnerText = descuento;
            detalle.AppendChild(nododescuento);

            float ptsi = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(cantidad)) * Convert.ToSingle(Funcion.reemplazarcaracterViceversa(precioUnitario));

            XmlElement nodoprecioTotalSinImpuesto = doc.CreateElement("precioTotalSinImpuesto");
            nodoprecioTotalSinImpuesto.InnerText = Funcion.reemplazarcaracter(ptsi.ToString("#####0.00"));
            detalle.AppendChild(nodoprecioTotalSinImpuesto);

            //subnodo del nodo raiz totalConImpuestos
            XmlNode SubNodototalConImpuestos = doc.CreateElement("impuestos");

            detalle.AppendChild(SubNodototalConImpuestos);

            //subnodo del nodo totalConImpuestos
            XmlNode SubNodototalImpuesto = doc.CreateElement("impuesto");
            SubNodototalConImpuestos.AppendChild(SubNodototalImpuesto);

            XmlElement nodocodigo = doc.CreateElement("codigo");
            nodocodigo.InnerText = codigo;
            SubNodototalImpuesto.AppendChild(nodocodigo);

            XmlElement nodocodigoPorcentaje = doc.CreateElement("codigoPorcentaje");
            nodocodigoPorcentaje.InnerText = codigoPorcentaje;
            SubNodototalImpuesto.AppendChild(nodocodigoPorcentaje);

            XmlElement nodotarifa = doc.CreateElement("tarifa");
            nodotarifa.InnerText = tarifa;
            SubNodototalImpuesto.AppendChild(nodotarifa);

            XmlElement nodobaseImponible = doc.CreateElement("baseImponible");
            nodobaseImponible.InnerText = Funcion.reemplazarcaracter(ptsi.ToString("#####0.00"));
            SubNodototalImpuesto.AppendChild(nodobaseImponible);

            XmlElement nodovalor = doc.CreateElement("valor");
            nodovalor.InnerText = Funcion.reemplazarcaracter(valor);
            SubNodototalImpuesto.AppendChild(nodovalor);

            return detalle;
        }

        private XmlNode CrearNodoInfoFactura(string fechaEmision, string dirEstablecimiento, string contribuyenteEspecial, string obligadoContabilidad, string tipoIdentificacionComprador, string razonSocialComprador, string identificacionComprador, string totalSinImpuestos, string totalDescuento, string codigo, string codigoPorcentaje, string descuentoAdicional, string baseImponible, string valor, string propina, string importeTotal, string moneda,string guiaRemision,string direccionComprador,DataGridView dgvcheque,DataGridView dgvcredito,CheckBox chkefectivo,string valorefectivo,DataGridView dgvDetalle)
        {
            XmlNode Nodoraiz = doc.CreateElement("infoFactura");


            XmlElement nodofechaemision = doc.CreateElement("fechaEmision");
            nodofechaemision.InnerText = fechaEmision;
            Nodoraiz.AppendChild(nodofechaemision);

            //XmlElement nododirEstablecimiento = doc.CreateElement("dirEstablecimiento");
            //nododirEstablecimiento.InnerText = dirEstablecimiento;
            //Nodoraiz.AppendChild(nododirEstablecimiento);

            XmlElement nododirEstablecimiento = doc.CreateElement("dirEstablecimiento");
            nododirEstablecimiento.InnerText = dirEstablecimiento;
            Nodoraiz.AppendChild(nododirEstablecimiento);

            XmlElement nodoobligadoContabilidad = doc.CreateElement("obligadoContabilidad");
            nodoobligadoContabilidad.InnerText = obligadoContabilidad;
            Nodoraiz.AppendChild(nodoobligadoContabilidad);

            XmlElement nodotipoIdentificacionComprador = doc.CreateElement("tipoIdentificacionComprador");
            nodotipoIdentificacionComprador.InnerText = tipoIdentificacionComprador;
            Nodoraiz.AppendChild(nodotipoIdentificacionComprador);

            XmlElement nodoguiaremision = doc.CreateElement("guiaRemision");
            nodoguiaremision.InnerText = guiaRemision;
            Nodoraiz.AppendChild(nodoguiaremision);

            XmlElement nodorazonSocialComprador = doc.CreateElement("razonSocialComprador");
            nodorazonSocialComprador.InnerText = razonSocialComprador;
            Nodoraiz.AppendChild(nodorazonSocialComprador);

            XmlElement nodoidentificacionComprador = doc.CreateElement("identificacionComprador");
            nodoidentificacionComprador.InnerText = identificacionComprador;
            Nodoraiz.AppendChild(nodoidentificacionComprador);

            XmlElement nododireccioncomprador = doc.CreateElement("direccionComprador");
            nododireccioncomprador.InnerText = direccionComprador;
            Nodoraiz.AppendChild(nododireccioncomprador);

            XmlElement nodototalSinImpuestos = doc.CreateElement("totalSinImpuestos");
            nodototalSinImpuestos.InnerText = Funcion.reemplazarcaracter(totalSinImpuestos);
            Nodoraiz.AppendChild(nodototalSinImpuestos);

            XmlElement nodototalDescuento = doc.CreateElement("totalDescuento");
            string descuento = Convert.ToSingle(totalDescuento).ToString("#####0.00");
            nodototalDescuento.InnerText = Funcion.reemplazarcaracter(descuento);
            Nodoraiz.AppendChild(nodototalDescuento);

            
            ////subnodo del nodo raiz totalConImpuestos
            //XmlNode SubNodototalConImpuestos = doc.CreateElement("totalConImpuestos");
            //SubNodototalConImpuestos.AppendChild(nodototalConImpuestos(dgvDetalle));
            Nodoraiz.AppendChild(nodototalConImpuestos(dgvDetalle));

           
            XmlElement nodopropina = doc.CreateElement("propina");
            nodopropina.InnerText = propina;
            Nodoraiz.AppendChild(nodopropina);

            XmlElement nodoimporteTotal = doc.CreateElement("importeTotal");
            nodoimporteTotal.InnerText = importeTotal;
            Nodoraiz.AppendChild(nodoimporteTotal);

            XmlElement nodomoneda = doc.CreateElement("moneda");
            nodomoneda.InnerText = moneda;
            Nodoraiz.AppendChild(nodomoneda);


            //sub nodo pagos
            XmlNode SubNodopagos = doc.CreateElement("pagos");
            Nodoraiz.AppendChild(SubNodopagos);

            //if (chkefectivo.Checked)
            //{
                SubNodopagos.AppendChild(agregarformapago("01", importeTotal, "", "", 1));
            //}


            //for (int i = 0; i < dgvcheque.RowCount; i++)
            //{
            //    if (dgvcheque.Rows[i].Cells[0].Value!=null)
            //    {
            //        TimeSpan diferencia;
            //        diferencia = Convert.ToDateTime(dgvcheque.Rows[i].Cells[3].Value) - DateTime.Now.Date;
            //        SubNodopagos.AppendChild(agregarformapago("20",Convert.ToString(dgvcheque.Rows[i].Cells[5].Value),""+diferencia.Days, "dias",2));
            //    }
            //    else
            //    {
            //        break;
            //    }
               
            //}

            //for (int i = 0; i < dgvcredito.RowCount; i++)
            //{
            //    if (dgvcredito.Rows[i].Cells[0].Value!=null)
            //    {
            //        SubNodopagos.AppendChild(agregarformapago("19", Convert.ToString(dgvcheque.Rows[i].Cells[2].Value), "" , "", 1));
            //    }
            //}


            

            return Nodoraiz;
        }


        private XmlNode nodototalConImpuestos(DataGridView dgv)
        {
            //doc.Load(rutaXml);
            XmlNode SubNodototalConImpuestos = doc.CreateElement("totalConImpuestos");
            XmlNode NodoDetalles = null;
            double baseimponiblecero = 0;
            double baseimponibledoce = 0;
            double baseimponiblecatorce = 0;
            double baseimponibleLibreImpuesto = 0;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (dgv.Rows[i].Cells[0].Value != null)
                {
                    //if (Convert.ToInt32(Convert.ToString(dgv.Rows[i].Cells[9].Value)) == 1)
                    //{
                    //    baseimponibleLibreImpuesto += Convert.ToDouble(dgv.Rows[i].Cells[2].Value) * Convert.ToDouble(dgv.Rows[i].Cells[10].Value);
                    //}
                    //else
                    //{
                        //int valor = Convert.ToInt32(Convert.ToString(dgv.Rows[i].Cells[5].Value));
                        if (Convert.ToSingle(dgv.Rows[i].Cells[5].Value) == 0)
                        {
                            baseimponiblecero += Convert.ToDouble(dgv.Rows[i].Cells[2].Value) * Convert.ToDouble(dgv.Rows[i].Cells[10].Value);
                        }
                        else
                        {
                            if (Program.IVA == "14")
                            {
                                baseimponiblecatorce += Convert.ToDouble(dgv.Rows[i].Cells[2].Value) * Convert.ToDouble(dgv.Rows[i].Cells[10].Value);
                            }
                            else
                            {
                                baseimponibledoce += Convert.ToDouble(dgv.Rows[i].Cells[2].Value) * Convert.ToDouble(dgv.Rows[i].Cells[10].Value);
                            }

                        }
                    //}

                }
                else
                {
                    break;
                }

            }

            if (baseimponiblecero > 0)
            {
                NodoDetalles = CrearNodoTotalConImpuesto("2", "0", "0.00", Funcion.reemplazarcaracter(baseimponiblecero.ToString("#####0.00")), "0", "0.00");
                SubNodototalConImpuestos.AppendChild(NodoDetalles);
            }
            if (baseimponiblecatorce > 0)
            {
                double valorIva = (baseimponiblecatorce * 14) / 100;

                NodoDetalles = CrearNodoTotalConImpuesto("2", "3", "0.00", Funcion.reemplazarcaracter(baseimponiblecatorce.ToString("#####0.00")), "14", valorIva.ToString("#####0.00"));
                SubNodototalConImpuestos.AppendChild(NodoDetalles);
            }
            if (baseimponibledoce > 0)
            {
                double valorIva = (baseimponibledoce * 12) / 100;
                NodoDetalles = CrearNodoTotalConImpuesto("2", "2", "0.00", Funcion.reemplazarcaracter(baseimponibledoce.ToString("#####0.00")), "12", Funcion.reemplazarcaracter(valorIva.ToString("#####0.00")));
                SubNodototalConImpuestos.AppendChild(NodoDetalles);
            }
            //if (baseimponibleLibreImpuesto > 0)
            //{
            //    NodoDetalles = CrearNodoTotalConImpuesto("2", "6", "0.00", Funcion.reemplazarcaracter(baseimponibleLibreImpuesto.ToString("#####0.00")), "0", "0.00");
            //    SubNodototalConImpuestos.AppendChild(NodoDetalles);
            //}


            return SubNodototalConImpuestos;

        }


        public XmlNode CrearNodoTotalConImpuesto(string codigo, string codigoPorcentaje, string descuentoAdicional, string baseImponible, string tarifa, string valor)
        {

            //subnodo del nodo totalConImpuestos
            XmlNode SubNodototalImpuesto = doc.CreateElement("totalImpuesto");
            //SubNodototalConImpuestos.AppendChild(SubNodototalImpuesto);

            XmlElement nodocodigo = doc.CreateElement("codigo");
            nodocodigo.InnerText = codigo;
            SubNodototalImpuesto.AppendChild(nodocodigo);


            XmlElement nodocodigoPorcentaje = doc.CreateElement("codigoPorcentaje");
            nodocodigoPorcentaje.InnerText = codigoPorcentaje;
            SubNodototalImpuesto.AppendChild(nodocodigoPorcentaje);

            //XmlElement nododescuentoAdicional = doc.CreateElement("descuentoAdicional");
            //nododescuentoAdicional.InnerText = descuentoAdicional;
            //SubNodototalImpuesto.AppendChild(nododescuentoAdicional);

            XmlElement nodobaseImponible = doc.CreateElement("baseImponible");
            nodobaseImponible.InnerText = Funcion.reemplazarcaracter(baseImponible);
            SubNodototalImpuesto.AppendChild(nodobaseImponible);

            XmlElement nodotarifa = doc.CreateElement("tarifa");
            nodotarifa.InnerText = Funcion.reemplazarcaracter(tarifa);
            SubNodototalImpuesto.AppendChild(nodotarifa);

            XmlElement nodovalor = doc.CreateElement("valor");
            nodovalor.InnerText = valor;
            SubNodototalImpuesto.AppendChild(nodovalor);

            return SubNodototalImpuesto;
        }


        private XmlNode agregarformapago(string formapago,string total,string plazo,string unidadTiempo,int verificarnodos)
        {
            XmlNode SubNodopago = doc.CreateElement("pago");

            XmlElement Subnodoformapago = doc.CreateElement("formaPago");
            Subnodoformapago.InnerText = formapago;
            SubNodopago.AppendChild(Subnodoformapago);

            XmlElement Subnodototal = doc.CreateElement("total");
            Subnodototal.InnerText = total;
            SubNodopago.AppendChild(Subnodototal);

            //if (verificarnodos==2)
            //{
            //    //nodos cuando correspondan
            //    XmlElement Subplazo = doc.CreateElement("plazo");
            //    Subplazo.InnerText = plazo;
            //    SubNodopago.AppendChild(Subplazo);

            //    XmlElement SubunidadTiempo = doc.CreateElement("unidadTiempo");
            //    SubunidadTiempo.InnerText = unidadTiempo;
            //    SubNodopago.AppendChild(SubunidadTiempo);
            //}
            

            return SubNodopago;


        }

        private XmlNode CrearInfoTributarios(string ambiente, string tipodeemision, string razonsocial, string nombrecomercial, string ruc, string claveacceso, string coddoc, string estab, string ptoemision, string secuencial, string dirmatriz)
        {
            XmlNode Nodoraiz = doc.CreateElement("infoTributaria");


            XmlElement nodoambiente = doc.CreateElement("ambiente");
            nodoambiente.InnerText = ambiente;
            Nodoraiz.AppendChild(nodoambiente);

            XmlElement nodoemision = doc.CreateElement("tipoEmision");
            nodoemision.InnerText = tipodeemision;
            Nodoraiz.AppendChild(nodoemision);

            XmlElement nodorazonsocial = doc.CreateElement("razonSocial");
            nodorazonsocial.InnerText = razonsocial;
            Nodoraiz.AppendChild(nodorazonsocial);

            XmlElement nodonombreComercial = doc.CreateElement("nombreComercial");
            nodonombreComercial.InnerText = nombrecomercial;
            Nodoraiz.AppendChild(nodonombreComercial);

            XmlElement nodoruc = doc.CreateElement("ruc");
            nodoruc.InnerText = ruc;
            Nodoraiz.AppendChild(nodoruc);

            XmlElement nodoclaveAcceso = doc.CreateElement("claveAcceso");
            nodoclaveAcceso.InnerText = claveacceso;
            Nodoraiz.AppendChild(nodoclaveAcceso);

            XmlElement nodocodDoc = doc.CreateElement("codDoc");
            nodocodDoc.InnerText = coddoc;
            Nodoraiz.AppendChild(nodocodDoc);

            XmlElement nodoestab = doc.CreateElement("estab");
            nodoestab.InnerText = estab;
            Nodoraiz.AppendChild(nodoestab);

            XmlElement nodoptoEmi = doc.CreateElement("ptoEmi");
            nodoptoEmi.InnerText = ptoemision;
            Nodoraiz.AppendChild(nodoptoEmi);

            XmlElement nodosecuencial = doc.CreateElement("secuencial");
            nodosecuencial.InnerText = secuencial;
            Nodoraiz.AppendChild(nodosecuencial);


            XmlElement nododirMatriz = doc.CreateElement("dirMatriz");
            nododirMatriz.InnerText = dirmatriz;
            Nodoraiz.AppendChild(nododirMatriz);


            return Nodoraiz;
        }

    }
}
