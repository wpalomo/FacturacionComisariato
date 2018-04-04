using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    class FacturaD
    {

        private string rucempresa;
        private string razonsocialempresa;
        private string numerodeautorizacion;
        private string fechahoraemision;
        private string ambiente;
        private string emision;
        private string claveacceso;
        private string direccionempresa;
        private string direccionsucursal;
        private string obligadollevarcontabilidad;

        //datos cliente

        private string razonsocialcliente;
        private string fechaemisioncliente;
        private string direccioncliente;
        private string identificacioncliente;





        //constructor  datos empresa
        public FacturaD(string rucempresa, string razonsocialempresa, string numeroautorizacion, string fechahoraemision, string ambiente, string emision, string claveacceso, string direccionempresa, string direccionsucursal, string obligadollevarcontabilidad)
        {
            this.rucempresa = rucempresa;
            this.razonsocialempresa = razonsocialempresa;
            this.numerodeautorizacion = numeroautorizacion;
            this.fechahoraemision = fechahoraemision;
            this.ambiente = ambiente;
            this.emision = emision;
            this.direccionempresa = direccionempresa;
            this.direccionsucursal = direccionsucursal;
            this.obligadollevarcontabilidad = obligadollevarcontabilidad;
        }

        //constructor datos cliente
        public FacturaD(string razonsocialcliente, string fechaemisioncliente, string direccioncliente, string identificacioncliente)
        {
            this.razonsocialcliente = razonsocialcliente;
            this.fechaemisioncliente = fechaemisioncliente;
            this.direccioncliente = direccioncliente;
            this.identificacioncliente = identificacioncliente;
        }


        public FacturaD()
        {

        }

        public string Rucempresa
        {
            get
            {
                return rucempresa;
            }

            set
            {
                rucempresa = value;
            }
        }

        public string Razonsocialempresa
        {
            get
            {
                return razonsocialempresa;
            }

            set
            {
                razonsocialempresa = value;
            }
        }

        public string Numerodeautorizacion
        {
            get
            {
                return numerodeautorizacion;
            }

            set
            {
                numerodeautorizacion = value;
            }
        }

        public string Fechahoraemision
        {
            get
            {
                return fechahoraemision;
            }

            set
            {
                fechahoraemision = value;
            }
        }

        public string Ambiente
        {
            get
            {
                return ambiente;
            }

            set
            {
                ambiente = value;
            }
        }

        public string Emision
        {
            get
            {
                return emision;
            }

            set
            {
                emision = value;
            }
        }

        public string Claveacceso
        {
            get
            {
                return claveacceso;
            }

            set
            {
                claveacceso = value;
            }
        }

        public string Direccionempresa
        {
            get
            {
                return direccionempresa;
            }

            set
            {
                direccionempresa = value;
            }
        }

        public string Direccionsucursal
        {
            get
            {
                return direccionsucursal;
            }

            set
            {
                direccionsucursal = value;
            }
        }

        public string Obligadollevarcontabilidad
        {
            get
            {
                return obligadollevarcontabilidad;
            }

            set
            {
                obligadollevarcontabilidad = value;
            }
        }

        public string Razonsocialcliente
        {
            get
            {
                return razonsocialcliente;
            }

            set
            {
                razonsocialcliente = value;
            }
        }

        public string Fechaemisioncliente
        {
            get
            {
                return fechaemisioncliente;
            }

            set
            {
                fechaemisioncliente = value;
            }
        }

        public string Direccioncliente
        {
            get
            {
                return direccioncliente;
            }

            set
            {
                direccioncliente = value;
            }
        }

        public string Identificacioncliente
        {
            get
            {
                return identificacioncliente;
            }

            set
            {
                identificacioncliente = value;
            }
        }
    }
}
