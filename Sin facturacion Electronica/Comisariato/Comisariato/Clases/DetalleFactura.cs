using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    class DetalleFactura
    {
        private string codigo;
        private string detalle;
        private string cantidad;
        private string punitario;
        private string valortota;
        private string iva;


        public DetalleFactura(string codigo, string detalle, string cantidad, string punitario, string valortotal, string iva)
        {
            this.codigo = codigo;
            this.detalle = detalle;
            this.cantidad = cantidad;
            this.punitario = punitario;
            this.valortota = valortotal;
            this.iva = iva;
        }


        public DetalleFactura()
        {

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

        public string Detalle
        {
            get
            {
                return detalle;
            }

            set
            {
                detalle = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public string Punitario
        {
            get
            {
                return punitario;
            }

            set
            {
                punitario = value;
            }
        }

        public string Valortota
        {
            get
            {
                return valortota;
            }

            set
            {
                valortota = value;
            }
        }

        public string Iva
        {
            get
            {
                return iva;
            }

            set
            {
                iva = value;
            }
        }
    }
}
