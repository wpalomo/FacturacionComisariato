using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class ValoresCompraAts
    {
        private String TOTALIVA, TOTALICE, TOTALIRBP, SUBTOTALIVA, SUBTOTAL0, SUBTOTAL, TOTAL, SERIE1, SERIE2, NUMERO,AUTORIZACION,FORMAPAGO,IDENTIFICACIONPROVEEDOR;


        public ValoresCompraAts(String TOTALIVA, String TOTALICE, String TOTALIRBP, String SUBTOTALIVA, String SUBTOTAL0, String SUBTOTAL, String TOTAL, String SERIE1, String SERIE2, String NUMERO,String AUTORIZACION,String FORMAPAGO, String IDENTIFICACIONPROVEEDOR)
        {
            this.TOTALIVA = TOTALIVA;
            this.TOTALICE = TOTALICE;
            this.TOTALIRBP = TOTALIRBP;
            this.SUBTOTALIVA = SUBTOTALIVA;
            this.SUBTOTAL0 = SUBTOTAL0;
            this.SUBTOTAL = SUBTOTAL;
            this.TOTAL = TOTAL;
            this.SERIE1 = SERIE1;
            this.SERIE2 = SERIE2;
            this.NUMERO = NUMERO;
            this.AUTORIZACION = AUTORIZACION;
            this.FORMAPAGO = FORMAPAGO;
            this.IDENTIFICACIONPROVEEDOR = IDENTIFICACIONPROVEEDOR;
        }


        public ValoresCompraAts()
        {
        }

        public string NUMERO1
        {
            get
            {
                return NUMERO;
            }

            set
            {
                NUMERO = value;
            }
        }

        public string SERIE11
        {
            get
            {
                return SERIE1;
            }

            set
            {
                SERIE1 = value;
            }
        }

        public string SERIE21
        {
            get
            {
                return SERIE2;
            }

            set
            {
                SERIE2 = value;
            }
        }

        public string SUBTOTAL01
        {
            get
            {
                return SUBTOTAL0;
            }

            set
            {
                SUBTOTAL0 = value;
            }
        }

        public string SUBTOTAL1
        {
            get
            {
                return SUBTOTAL;
            }

            set
            {
                SUBTOTAL = value;
            }
        }

        public string SUBTOTALIVA1
        {
            get
            {
                return SUBTOTALIVA;
            }

            set
            {
                SUBTOTALIVA = value;
            }
        }

        public string TOTAL1
        {
            get
            {
                return TOTAL;
            }

            set
            {
                TOTAL = value;
            }
        }

        public string TOTALICE1
        {
            get
            {
                return TOTALICE;
            }

            set
            {
                TOTALICE = value;
            }
        }

        public string TOTALIRBP1
        {
            get
            {
                return TOTALIRBP;
            }

            set
            {
                TOTALIRBP = value;
            }
        }

        public string TOTALIVA1
        {
            get
            {
                return TOTALIVA;
            }

            set
            {
                TOTALIVA = value;
            }
        }

        public string AUTORIZACION1
        {
            get
            {
                return AUTORIZACION;
            }

            set
            {
                AUTORIZACION = value;
            }
        }

        public string FORMAPAGO1
        {
            get
            {
                return FORMAPAGO;
            }

            set
            {
                FORMAPAGO = value;
            }
        }

        public string IDENTIFICACIONPROVEEDOR1
        {
            get
            {
                return IDENTIFICACIONPROVEEDOR;
            }

            set
            {
                IDENTIFICACIONPROVEEDOR = value;
            }
        }
    }
}
