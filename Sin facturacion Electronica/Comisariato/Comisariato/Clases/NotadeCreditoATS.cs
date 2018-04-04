using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class NotadeCreditoATS
    {
        String codSustento, tpIdProv, idProv, tipoComprobante, parteRel, fechaRegistro,establecimiento, puntoEmision, secuencial, fechaEmision, autorizacion, baseNoGraIva, baseImponible, baseImpGrav, baseImpExe, montoIce, montoIva, valRetBien10, valRetServ20, valorRetBienes,
            valRetServ50, valorRetServicios, valRetServ100, totbasesImpReemb, pagoLocExt, paisEfecPago, aplicConvDobTrib, pagExtSujRetNorLeg, docModificado, estabModificado, ptoEmiModificado,
            secModificado, autModificado;

        public NotadeCreditoATS(string codSustento, string tpIdProv, string idProv, string tipoComprobante, string parteRel, string fechaRegistro, string establecimiento, string puntoEmision, string secuencial, string fechaEmision, string autorizacion, string baseNoGraIva, string baseImponible, string baseImpGrav, string baseImpExe, string montoIce, string montoIva, string valRetBien10, string valRetServ20, string valorRetBienes, string valRetServ50, string valorRetServicios, string valRetServ100, string totbasesImpReemb, string pagoLocExt, string paisEfecPago, string aplicConvDobTrib, string pagExtSujRetNorLeg, string docModificado, string estabModificado, string ptoEmiModificado, string secModificado, string autModificado)
        {
            this.codSustento = codSustento;
            this.tpIdProv = tpIdProv;
            this.idProv = idProv;
            this.tipoComprobante = tipoComprobante;
            this.parteRel = parteRel;
            this.fechaRegistro = fechaRegistro;
            this.establecimiento = establecimiento;
            this.puntoEmision = puntoEmision;
            this.secuencial = secuencial;
            this.fechaEmision = fechaEmision;
            this.autorizacion = autorizacion;
            this.baseNoGraIva = baseNoGraIva;
            this.baseImponible = baseImponible;
            this.baseImpGrav = baseImpGrav;
            this.baseImpExe = baseImpExe;
            this.montoIce = montoIce;
            this.montoIva = montoIva;
            this.valRetBien10 = valRetBien10;
            this.valRetServ20 = valRetServ20;
            this.valorRetBienes = valorRetBienes;
            this.valRetServ50 = valRetServ50;
            this.valorRetServicios = valorRetServicios;
            this.valRetServ100 = valRetServ100;
            this.totbasesImpReemb = totbasesImpReemb;
            this.pagoLocExt = pagoLocExt;
            this.paisEfecPago = paisEfecPago;
            this.aplicConvDobTrib = aplicConvDobTrib;
            this.pagExtSujRetNorLeg = pagExtSujRetNorLeg;
            this.docModificado = docModificado;
            this.estabModificado = estabModificado;
            this.ptoEmiModificado = ptoEmiModificado;
            this.secModificado = secModificado;
            this.autModificado = autModificado;
        }

        public string AplicConvDobTrib
        {
            get
            {
                return aplicConvDobTrib;
            }

            set
            {
                aplicConvDobTrib = value;
            }
        }

        public string AutModificado
        {
            get
            {
                return autModificado;
            }

            set
            {
                autModificado = value;
            }
        }

        public string Autorizacion
        {
            get
            {
                return autorizacion;
            }

            set
            {
                autorizacion = value;
            }
        }

        public string BaseImpExe
        {
            get
            {
                return baseImpExe;
            }

            set
            {
                baseImpExe = value;
            }
        }

        public string BaseImpGrav
        {
            get
            {
                return baseImpGrav;
            }

            set
            {
                baseImpGrav = value;
            }
        }

        public string BaseImponible
        {
            get
            {
                return baseImponible;
            }

            set
            {
                baseImponible = value;
            }
        }

        public string BaseNoGraIva
        {
            get
            {
                return baseNoGraIva;
            }

            set
            {
                baseNoGraIva = value;
            }
        }

        public string CodSustento
        {
            get
            {
                return codSustento;
            }

            set
            {
                codSustento = value;
            }
        }

        public string DocModificado
        {
            get
            {
                return docModificado;
            }

            set
            {
                docModificado = value;
            }
        }

        public string Establecimiento
        {
            get
            {
                return establecimiento;
            }

            set
            {
                establecimiento = value;
            }
        }

        public string EstabModificado
        {
            get
            {
                return estabModificado;
            }

            set
            {
                estabModificado = value;
            }
        }

        public string FechaEmision
        {
            get
            {
                return fechaEmision;
            }

            set
            {
                fechaEmision = value;
            }
        }

        public string FechaRegistro
        {
            get
            {
                return fechaRegistro;
            }

            set
            {
                fechaRegistro = value;
            }
        }

        public string IdProv
        {
            get
            {
                return idProv;
            }

            set
            {
                idProv = value;
            }
        }

        public string MontoIce
        {
            get
            {
                return montoIce;
            }

            set
            {
                montoIce = value;
            }
        }

        public string MontoIva
        {
            get
            {
                return montoIva;
            }

            set
            {
                montoIva = value;
            }
        }

        public string PagExtSujRetNorLeg
        {
            get
            {
                return pagExtSujRetNorLeg;
            }

            set
            {
                pagExtSujRetNorLeg = value;
            }
        }

        public string PagoLocExt
        {
            get
            {
                return pagoLocExt;
            }

            set
            {
                pagoLocExt = value;
            }
        }

        public string PaisEfecPago
        {
            get
            {
                return paisEfecPago;
            }

            set
            {
                paisEfecPago = value;
            }
        }

        public string ParteRel
        {
            get
            {
                return parteRel;
            }

            set
            {
                parteRel = value;
            }
        }

        public string PtoEmiModificado
        {
            get
            {
                return ptoEmiModificado;
            }

            set
            {
                ptoEmiModificado = value;
            }
        }

        public string PuntoEmision
        {
            get
            {
                return puntoEmision;
            }

            set
            {
                puntoEmision = value;
            }
        }

        public string SecModificado
        {
            get
            {
                return secModificado;
            }

            set
            {
                secModificado = value;
            }
        }

        public string Secuencial
        {
            get
            {
                return secuencial;
            }

            set
            {
                secuencial = value;
            }
        }

        public string TipoComprobante
        {
            get
            {
                return tipoComprobante;
            }

            set
            {
                tipoComprobante = value;
            }
        }

        public string TotbasesImpReemb
        {
            get
            {
                return totbasesImpReemb;
            }

            set
            {
                totbasesImpReemb = value;
            }
        }

        public string TpIdProv
        {
            get
            {
                return tpIdProv;
            }

            set
            {
                tpIdProv = value;
            }
        }

        public string ValorRetBienes
        {
            get
            {
                return valorRetBienes;
            }

            set
            {
                valorRetBienes = value;
            }
        }

        public string ValorRetServicios
        {
            get
            {
                return valorRetServicios;
            }

            set
            {
                valorRetServicios = value;
            }
        }

        public string ValRetBien10
        {
            get
            {
                return valRetBien10;
            }

            set
            {
                valRetBien10 = value;
            }
        }

        public string ValRetServ100
        {
            get
            {
                return valRetServ100;
            }

            set
            {
                valRetServ100 = value;
            }
        }

        public string ValRetServ20
        {
            get
            {
                return valRetServ20;
            }

            set
            {
                valRetServ20 = value;
            }
        }

        public string ValRetServ50
        {
            get
            {
                return valRetServ50;
            }

            set
            {
                valRetServ50 = value;
            }
        }
    }
}
