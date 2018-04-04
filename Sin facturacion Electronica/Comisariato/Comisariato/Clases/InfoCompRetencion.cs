using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    class InfoCompRetencion
    {
        private string fechaEmision;
        private string dirEstablecimiento;
        private string contribuyenteEspecial;
        private string obligadoContabilidad;
        private string tipoIdentificacionSujetoRetenido;
        private string razonSocialSujetoRetenido;
        private string identificacionSujetoRetenido;
        private string periodoFiscal;

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

        public string TipoIdentificacionSujetoRetenido
        {
            get
            {
                return tipoIdentificacionSujetoRetenido;
            }

            set
            {
                tipoIdentificacionSujetoRetenido = value;
            }
        }

        public string RazonSocialSujetoRetenido
        {
            get
            {
                return razonSocialSujetoRetenido;
            }

            set
            {
                razonSocialSujetoRetenido = value;
            }
        }

        public string IdentificacionSujetoRetenido
        {
            get
            {
                return identificacionSujetoRetenido;
            }

            set
            {
                identificacionSujetoRetenido = value;
            }
        }

        public string PeriodoFiscal
        {
            get
            {
                return periodoFiscal;
            }

            set
            {
                periodoFiscal = value;
            }
        }

        public InfoCompRetencion()
        {

        }

        public InfoCompRetencion(string fechaEmision,string dirEstablecimiento,string contribuyenteEspecial,string obligadoContabilidad,string tipoIdentificacionSujetoRetenido,string razonSocialSujetoRetenido,string identificacionSujetoRetenido,string periodoFiscal)
        {
            this.FechaEmision = fechaEmision;
            this.DirEstablecimiento = dirEstablecimiento;
            this.ContribuyenteEspecial = contribuyenteEspecial;
            this.ObligadoContabilidad = obligadoContabilidad;
            this.TipoIdentificacionSujetoRetenido = tipoIdentificacionSujetoRetenido;
            this.RazonSocialSujetoRetenido = razonSocialSujetoRetenido;
            this.IdentificacionSujetoRetenido = identificacionSujetoRetenido;
            this.PeriodoFiscal = periodoFiscal;
        }

    }
}
