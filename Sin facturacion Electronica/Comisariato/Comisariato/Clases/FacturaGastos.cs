using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class FacturaGastos
    {
        int sucursal, impuesto, proveedor, cuentacontable;
        string observacion, serie1, serie2, numero;
        float subtotal0, subtotalIva, descuento, iva, totalPagar;
        DateTime fecha;

        public int Sucursal
        {
            get
            {
                return sucursal;
            }

            set
            {
                sucursal = value;
            }
        }

        public int Impuesto
        {
            get
            {
                return impuesto;
            }

            set
            {
                impuesto = value;
            }
        }

        public int Proveedor
        {
            get
            {
                return proveedor;
            }

            set
            {
                proveedor = value;
            }
        }

        public int Cuentacontable
        {
            get
            {
                return cuentacontable;
            }

            set
            {
                cuentacontable = value;
            }
        }

        public string Observacion
        {
            get
            {
                return observacion;
            }

            set
            {
                observacion = value;
            }
        }

        public string Serie1
        {
            get
            {
                return serie1;
            }

            set
            {
                serie1 = value;
            }
        }

        public string Serie2
        {
            get
            {
                return serie2;
            }

            set
            {
                serie2 = value;
            }
        }

        public string Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public float Subtotal0
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

        public float SubtotalIva
        {
            get
            {
                return subtotalIva;
            }

            set
            {
                subtotalIva = value;
            }
        }

        public float Descuento
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

        public float Iva
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

        public float TotalPagar
        {
            get
            {
                return totalPagar;
            }

            set
            {
                totalPagar = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public FacturaGastos(int sucursal, int impuesto, int proveedor, int cuentacontable, string observacion, string serie1, string serie2, string numero, float subtotal0, float subtotalIva, float descuento, float iva, float totalPagar, DateTime fecha)
        {
            this.sucursal = sucursal;
            this.impuesto = impuesto;
            this.proveedor = proveedor;
            this.cuentacontable = cuentacontable;
            this.observacion = observacion;
            this.serie1 = serie1;
            this.serie2 = serie2;
            this.numero = numero;
            this.subtotal0 = subtotal0;
            this.subtotalIva = subtotalIva;
            this.descuento = descuento;
            this.iva = iva;
            this.totalPagar = totalPagar;
            this.fecha = fecha;
        }
        Consultas ObjConsulta = new Consultas();
        public string InsertarFacturaGasto(FacturaGastos objFacturaGastos)
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("IDPROVEEDOR = " + proveedor + " AND NUMERO = " + numero + " AND SERIE1 = " + serie1 + " AND SERIE2", serie2, "TbEncabezadoyPieCompra"))
            {
                if (ObjConsulta.EjecutarPROCEDUREFacturaGasto(objFacturaGastos))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }
    }
}
