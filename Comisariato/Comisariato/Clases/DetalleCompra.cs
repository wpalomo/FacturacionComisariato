using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class DetalleCompra
    {
        //-------------detalle--------
        string codigo;
        int cantidad;
        float precioCompra;
        float descuento;
        float precioVentaPublico;
        float precioMayorista;
        float precioCajas;
        int idEncabezadoCompra;
        float ice;
        float irbp;
        int serie1;
        int serie2;
        int numero;
        int proveedor;
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

        public int Cantidad
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

        public float PrecioCompra
        {
            get
            {
                return precioCompra;
            }

            set
            {
                precioCompra = value;
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

        public float PrecioVentaPublico
        {
            get
            {
                return precioVentaPublico;
            }

            set
            {
                precioVentaPublico = value;
            }
        }

        public float PrecioMayorista
        {
            get
            {
                return precioMayorista;
            }

            set
            {
                precioMayorista = value;
            }
        }

        public float PrecioCajas
        {
            get
            {
                return precioCajas;
            }

            set
            {
                precioCajas = value;
            }
        }
        public int IdEncabezadoCompra
        {
            get
            {
                return idEncabezadoCompra;
            }

            set
            {
                idEncabezadoCompra = value;
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

        public int Serie1
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

        public int Serie2
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

        public int Numero
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

        Consultas ObjConsulta;
        public DetalleCompra()
        {

        }
        public DetalleCompra(float ice, float irbp, string codigo, int cantidad, float precioCompra, float descuento, float precioVentaPublico, float precioMayorista, float precioCajas, int serie1, int serie2, int numero, int proveedor)
        {
            //this.IdEncabezadoCompra = idEncabezadoCompra;
            this.Codigo = codigo;
            this.Cantidad = cantidad;
            this.PrecioCompra = precioCompra;
            this.Descuento = descuento;
            this.PrecioVentaPublico = precioVentaPublico;
            this.PrecioMayorista = precioMayorista;
            this.PrecioCajas = precioCajas;
            this.Ice = ice;
            this.Irbp = irbp;
            this.Serie1 = serie1;
            this.Serie2 = serie2;
            this.Numero = numero;
            this.Proveedor = proveedor;
        }
        public string InsertarDetalleCompra(DetalleCompra objDetalleCompra)
        {
            ObjConsulta = new Consultas();
            if (ObjConsulta.EjecutarPROCEDUREDetalleCompra(objDetalleCompra))
                return "Datos Guardados";
            else
                return "Error al Registrar";
        }
        public string ActualizarDetalleCompra(DetalleCompra objDetalleCompra, int idEncabezado, int idDetalleCompra)
        {
            string sql = "UPDATE [dbo].[TbDetalleCompra] " +
            "   SET [CODIGOBARRAPRODUCTO] = '"+ objDetalleCompra.Codigo +"' ,[CANTIDAD] = "+objDetalleCompra.Cantidad+" " +
      " ,[PRECIOCOMRPA] = " + Funcion.reemplazarcaracter(objDetalleCompra.PrecioCompra.ToString()) + " ,[DESCUENTO] = " + Funcion.reemplazarcaracter(objDetalleCompra.Descuento.ToString()) + " ,[PRECIOVENTAPUBLICO] = " + Funcion.reemplazarcaracter(objDetalleCompra.PrecioVentaPublico.ToString()) + " ,[PRECIOMAYORISTA] = " + Funcion.reemplazarcaracter(objDetalleCompra.PrecioMayorista.ToString()) + " " +
      " ,[PRECIOCAJAS] = " + Funcion.reemplazarcaracter(objDetalleCompra.PrecioCajas.ToString()) + " ,[ICE] = " + Funcion.reemplazarcaracter(objDetalleCompra.Ice.ToString()) + " ,[IRBP] = " + Funcion.reemplazarcaracter(objDetalleCompra.Irbp.ToString()) + " WHERE IDENCABEZADOCOMPRA = " + idEncabezado +" and IDDETALLECOMPRA = "+ idDetalleCompra;
            ObjConsulta = new Consultas();
            if (ObjConsulta.EjecutarSQL(sql))
                return "Datos Guardados";
            else
                return "Error al Registrar";
        }
    }
}
