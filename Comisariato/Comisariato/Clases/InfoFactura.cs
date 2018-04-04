using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    class InfoFactura
    {
        private string fechaEmision;
        private string dirEstablecimiento;
        private string contribuyenteEspecial;
        private string obligadoContabilidad;
        private string tipoIdentificacionComprador;
        private string razonSocialComprador;
        private string identificacionComprador;
        private string totalSinImpuestos;
        private string totalDescuento;
        private string codigo;
        private string codigoPorcentaje;
        private string descuentoAdicional;
        private string baseImponible;
        private string valor;
        private string propina;
        private string importeTotal;
        private string moneda;
        private string guiaRemision;
        private string direccionComprador;


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

        public string DirEstablecimiento
        {
            get
            {
                return dirEstablecimiento;
            }

            set
            {
                dirEstablecimiento = value;
            }
        }

        public string ContribuyenteEspecial
        {
            get
            {
                return contribuyenteEspecial;
            }

            set
            {
                contribuyenteEspecial = value;
            }
        }

        public string ObligadoContabilidad
        {
            get
            {
                return obligadoContabilidad;
            }

            set
            {
                obligadoContabilidad = value;
            }
        }

        public string TipoIdentificacionComprador
        {
            get
            {
                return tipoIdentificacionComprador;
            }

            set
            {
                tipoIdentificacionComprador = value;
            }
        }

        public string RazonSocialComprador
        {
            get
            {
                return razonSocialComprador;
            }

            set
            {
                razonSocialComprador = value;
            }
        }

        public string IdentificacionComprador
        {
            get
            {
                return identificacionComprador;
            }

            set
            {
                identificacionComprador = value;
            }
        }

        public string TotalSinImpuestos
        {
            get
            {
                return totalSinImpuestos;
            }

            set
            {
                totalSinImpuestos = value;
            }
        }

        public string TotalDescuento
        {
            get
            {
                return totalDescuento;
            }

            set
            {
                totalDescuento = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string CodigoPorcentaje
        {
            get
            {
                return codigoPorcentaje;
            }

            set
            {
                codigoPorcentaje = value;
            }
        }

        public string DescuentoAdicional
        {
            get
            {
                return descuentoAdicional;
            }

            set
            {
                descuentoAdicional = value;
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

        public string Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public string Propina
        {
            get
            {
                return propina;
            }

            set
            {
                propina = value;
            }
        }

        public string ImporteTotal
        {
            get
            {
                return importeTotal;
            }

            set
            {
                importeTotal = value;
            }
        }

        public string Moneda
        {
            get
            {
                return moneda;
            }

            set
            {
                moneda = value;
            }
        }

        public string GuiaRemision
        {
            get
            {
                return guiaRemision;
            }

            set
            {
                guiaRemision = value;
            }
        }

        public string DireccionComprador
        {
            get
            {
                return direccionComprador;
            }

            set
            {
                direccionComprador = value;
            }
        }

        public InfoFactura()
        {

        }

        public InfoFactura(string fechaemision,string direstablecimiento,string contribuyenteespecial,string obligadocontabilidad,string tipoidentificacioncomprador,string razonsocialcomprador,string identificacioncomprador,string totalsinimpuesto,string totalDescuento,string codigo,string codigoPorcentaje,string descuentoAdicional,string baseImponible, string valor,string propina,string importeTotal,string moneda,string guiaRemision,string direccionComprador)
        {
            this.FechaEmision = fechaemision;
            this.DirEstablecimiento = direstablecimiento;
            this.ContribuyenteEspecial = contribuyenteespecial;
            this.ObligadoContabilidad = obligadocontabilidad;
            this.TipoIdentificacionComprador = tipoidentificacioncomprador;
            this.RazonSocialComprador = razonsocialcomprador;
            this.IdentificacionComprador = identificacioncomprador;
            this.TotalSinImpuestos = totalsinimpuesto;
            this.TotalDescuento = totalDescuento;
            this.Codigo = codigo;
            this.CodigoPorcentaje = codigoPorcentaje;
            this.DescuentoAdicional = descuentoAdicional;
            this.BaseImponible = baseImponible;
            this.Valor = valor;
            this.Propina = propina;
            this.ImporteTotal = importeTotal;
            this.Moneda = moneda;
            this.guiaRemision = guiaRemision;
            this.direccionComprador = direccionComprador;
        }
    }
}
