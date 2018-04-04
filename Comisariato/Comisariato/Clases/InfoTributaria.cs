using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    class InfoTributaria
    {
        private int ambiente;
        private int tipoEmision;
        private string RazonSocial;
        private string NombreComercial;
        private string Ruc;
        private string CodDoc;
        private string Estab;
        private string PtoEmi;
        private string Secuencial;
        private string dirMatriz;

        public InfoTributaria()
        {

        }

        public InfoTributaria(int ambiente, int tipoemision, string razonsocial,string nombrecomercial, string ruc, string coddoc,string estab,string ptoemi,string secuencial,string dirmatriz)
        {
            this.ambiente = ambiente;
            this.tipoEmision = tipoemision;
            this.RazonSocial = razonsocial;
            this.NombreComercial = nombrecomercial;
            this.Ruc = ruc;
            this.CodDoc = coddoc;
            this.Estab = estab;
            this.PtoEmi = ptoemi;
            this.Secuencial = secuencial;
            this.dirMatriz = dirmatriz;
        }

        public int Ambiente
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

        public int TipoEmision
        {
            get
            {
                return tipoEmision;
            }

            set
            {
                tipoEmision = value;
            }
        }

        public string RazonSociaL
        {
            get
            {
                return RazonSocial;
            }

            set
            {
                RazonSocial = value;
            }
        }

        public string NombreComerciaL
        {
            get
            {
                return NombreComercial;
            }

            set
            {
                NombreComercial = value;
            }
        }

        public string RuC
        {
            get
            {
                return Ruc;
            }

            set
            {
                Ruc = value;
            }
        }

        public string CodDoC
        {
            get
            {
                return CodDoc;
            }

            set
            {
                CodDoc = value;
            }
        }

        public string EstaB
        {
            get
            {
                return Estab;
            }

            set
            {
                Estab = value;
            }
        }

        public string PtoEmI
        {
            get
            {
                return PtoEmi;
            }

            set
            {
                PtoEmi = value;
            }
        }

        public string SecuenciaL
        {
            get
            {
                return Secuencial;
            }

            set
            {
                Secuencial = value;
            }
        }

        public string DirMatriz
        {
            get
            {
                return dirMatriz;
            }

            set
            {
                dirMatriz = value;
            }
        }

        public string GenerarClaveAcceso(string fecha,string tipoComprobante,string serie)
        {
            //16122017118021144290011001003000000064000000101
            string clave ="",NumCualquiera="00000010";
            string[] vector = fecha.Split('/');
            clave = vector[0] + vector[1] + vector[2] + "0"+tipoComprobante + Ruc + ambiente + serie + Secuencial + NumCualquiera + tipoEmision;
            ClaveAcceso ObjClave = new ClaveAcceso();
            string clave1 = ObjClave.invertirCadena(clave);
            int numeroVerificador = ObjClave.obtenerSumaPorDigitos(clave1);
            clave += "" + numeroVerificador;
            return clave;
        }

        public string GetCheckDigit(string number)
        {
            int sum = 0;
            for (int i = number.Length - 1, multiplier = 2; i >= 0; i--)
            {
                sum += (int)char.GetNumericValue(number[i]) * multiplier;
                if (++multiplier > 9) multiplier = 2;
            }
            int mod = (sum % 11);
            if (mod == 0 || mod == 1) return "0";
            return (11 - mod).ToString();
        }

    }
}
