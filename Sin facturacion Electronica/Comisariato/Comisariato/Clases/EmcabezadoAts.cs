using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    class EmcabezadoAts
    {
        private string tipoidInformante;
        private string idinformante;
        private string razonsocial;
        private string anio;
        private string mes;
        private string numestabruc;
        private string totalventas;
        private string codigooperativo;

        public EmcabezadoAts()
        {

        }

        public EmcabezadoAts(string tipoidinformante,string idinformante, string razonsocial,string anio,string mes, string numestabruc,string totalventas, string codigooperativo)
        {
            this.tipoidInformante = tipoidinformante;
            this.idinformante = idinformante;
            this.razonsocial = razonsocial;
            this.anio = anio;
            this.mes = mes;
            this.numestabruc = numestabruc;
            this.totalventas = totalventas;
            this.codigooperativo = codigooperativo;
        }

        public string TipoidInformante
        {
            get
            {
                return tipoidInformante;
            }

            set
            {
                tipoidInformante = value;
            }
        }

        public string Idinformante
        {
            get
            {
                return idinformante;
            }

            set
            {
                idinformante = value;
            }
        }

        public string Razonsocial
        {
            get
            {
                return razonsocial;
            }

            set
            {
                razonsocial = value;
            }
        }

        public string Anio
        {
            get
            {
                return anio;
            }

            set
            {
                anio = value;
            }
        }

        public string Mes
        {
            get
            {
                return mes;
            }

            set
            {
                mes = value;
            }
        }

        public string Numestabruc
        {
            get
            {
                return numestabruc;
            }

            set
            {
                numestabruc = value;
            }
        }

        public string Totalventas
        {
            get
            {
                return totalventas;
            }

            set
            {
                totalventas = value;
            }
        }

        public string Codigooperativo
        {
            get
            {
                return codigooperativo;
            }

            set
            {
                codigooperativo = value;
            }
        }
    }
}
