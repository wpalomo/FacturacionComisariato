using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class EmcabezadoCompra
    {
        //---------encabezado--------
        string ordenCompra;
        int sucursal;
        float flete;
        DateTime fechaOrdenCompra;
        int proveedor;
        string terminoPago;
        string plazo;
        string impuesto;
        string observacion;        
        float iva;
        float ice;
        float irbp;
        float subtotalIva;
        float subtotal0;
        float subtotal;
        float total;
        string serie1;
        string serie2;
        string numero;
        string gasto;

        public string OrdenCompra
        {
            get
            {
                return ordenCompra;
            }

            set
            {
                ordenCompra = value;
            }
        }
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
        public float Flete
        {
            get
            {
                return flete;
            }

            set
            {
                flete = value;
            }
        }
        public DateTime FechaOrdenCompra
        {
            get
            {
                return fechaOrdenCompra;
            }

            set
            {
                fechaOrdenCompra = value;
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
        public string TerminoPago
        {
            get
            {
                return terminoPago;
            }

            set
            {
                terminoPago = value;
            }
        }
        public string Plazo
        {
            get
            {
                return plazo;
            }

            set
            {
                plazo = value;
            }
        }
        public string Impuesto
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
        public float Ice
        {
            get
            {
                return ice;
            }

            set
            {
                ice = value;
            }
        }
        public float Irbp
        {
            get
            {
                return irbp;
            }

            set
            {
                irbp = value;
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

        public float Subtotal
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

        public float Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
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

        public string Gasto
        {
            get
            {
                return gasto;
            }

            set
            {
                gasto = value;
            }
        }

        Consultas ObjConsulta;
        public EmcabezadoCompra()
        {

        }
        public EmcabezadoCompra(string serie1, string serie2, string numero, float subtotalIva,float subtotal0,float subtotal,float total, string ordenCompra, int sucursal, float flete, DateTime fechaOrdenCompra, int proveedor, string terminoPago, string plazo, string impuesto, string observacion, float iva, float ice, float irbp, string gasto)
        {
            this.OrdenCompra = ordenCompra;
            this.Sucursal = sucursal;
            this.Flete = flete;
            this.FechaOrdenCompra = fechaOrdenCompra;
            this.Proveedor = proveedor;
            this.TerminoPago = terminoPago;
            this.Plazo = plazo;
            this.Impuesto = impuesto;
            this.Observacion = observacion;            
            this.Iva = iva;
            this.Ice = ice;
            this.Irbp = irbp;
            this.SubtotalIva = subtotalIva;
            this.Subtotal0 = subtotal0;
            this.Subtotal = subtotal;
            this.Total = total;
            this.Serie1 = serie1;
            this.Serie2 = serie2;
            this.Numero = numero;
            this.Gasto = gasto;
        }
        
        public string InsertarEncabezadoyPieCompra(EmcabezadoCompra objEncabezadoCompra)
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("IDPROVEEDOR = "+ proveedor +" AND NUMERO = "+ numero +" AND SERIE1 = "+ serie1 +" AND SERIE2", serie2, "TbEncabezadoyPieCompra"))
            {
                if (ObjConsulta.EjecutarPROCEDUREEncabezadoCompra(objEncabezadoCompra))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }
        public string ActualizarEncabezadoyPieCompra(EmcabezadoCompra objEncabezadoCompra, int idEncabezado)
        {
            ObjConsulta = new Consultas();
            string sql = "UPDATE[dbo].[TbEncabezadoyPieCompra] set " +
        " [IDSUCURSAL] = "+ objEncabezadoCompra.Sucursal +" ,[FLETE] = "+ objEncabezadoCompra.Flete +" " +
      " ,[FECHAORDENCOMPRA] = '" + Funcion.reemplazarcaracterFecha(objEncabezadoCompra.FechaOrdenCompra.ToShortDateString()) + "' ,[IDPROVEEDOR] = " + objEncabezadoCompra.Proveedor + " ,[TERMINOPAGO] = '"+ objEncabezadoCompra.TerminoPago + "' ,[PLAZOORDENCOMPRA] = '" + objEncabezadoCompra.Plazo + "' " +
      " ,[IMPUESTO] = '" + objEncabezadoCompra.Impuesto + "' ,[OBSERVACION] = '" + objEncabezadoCompra.Observacion + "' ,[TOTALIVA] = " + Funcion.reemplazarcaracter(objEncabezadoCompra.Iva.ToString()) + " ,[TOTALICE] = " + Funcion.reemplazarcaracter(objEncabezadoCompra.Ice.ToString()) + " ,[TOTALIRBP] = " + Funcion.reemplazarcaracter(objEncabezadoCompra.Irbp.ToString()) + " " +
      " ,[SUBTOTALIVA] = " + Funcion.reemplazarcaracter(objEncabezadoCompra.SubtotalIva.ToString()) + " ,[SUBTOTAL0] = " + Funcion.reemplazarcaracter(objEncabezadoCompra.Subtotal0.ToString()) + " ,[SUBTOTAL] = " + Funcion.reemplazarcaracter(objEncabezadoCompra.Subtotal.ToString()) + " ,[TOTAL] = " + Funcion.reemplazarcaracter(objEncabezadoCompra.Total.ToString()) + " " +
      " ,[SERIE1] = '" + objEncabezadoCompra.Serie1 + "' ,[SERIE2] = '" + objEncabezadoCompra.Serie2 + "' ,[NUMERO] = '" + objEncabezadoCompra.Numero + "' " +
 " WHERE IDEMCABEZADOCOMPRA = "+ idEncabezado;
            if (ObjConsulta.EjecutarSQL(sql))
            {
                return "Datos Guardados";
            }
            else { return "Error al Registrar"; }
        }
        

    }
}
