using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFacturacionElectronica.Class
{
    class PieFactura
    {
        private string subtotal;
        private string subtotal0;
        private string subtotal12;
        private string iva12;
        private string descuento;
        private string propina;
        private string valortotal;

        public PieFactura()
        {

        }

        public PieFactura(string subtotal,string subtotal0,string subtotal12,string iva12,string descuento,string propina,string valortotal)
        {
            this.subtotal = subtotal;
            this.subtotal0 = subtotal0;
            this.subtotal12 = subtotal12;
            this.iva12 = iva12;
            this.descuento = descuento;
            this.propina = propina;
            this.valortotal = valortotal;
        }

        public string Subtotal
        {
            get
            {
                return subtotal;
            }

            set
            {
                subtotal = value;
            }
        }

        public string Subtotal0
        {
            get
            {
                return subtotal0;
            }

            set
            {
                subtotal0 = value;
            }
        }

        public string Subtotal12
        {
            get
            {
                return subtotal12;
            }

            set
            {
                subtotal12 = value;
            }
        }

        public string Iva12
        {
            get
            {
                return iva12;
            }

            set
            {
                iva12 = value;
            }
        }

        public string Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
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

        public string Valortotal
        {
            get
            {
                return valortotal;
            }

            set
            {
                valortotal = value;
            }
        }
    }
}
