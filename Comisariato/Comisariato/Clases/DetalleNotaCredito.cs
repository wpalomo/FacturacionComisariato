using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class DetalleNotaCredito
    {
        int idEncabezadoNotaCredito;
        float cantidad;
        string codigoBarra;
        float porcentaje;

        public int IdEncabezadoNotaCredito
        {
            get
            {
                return idEncabezadoNotaCredito;
            }

            set
            {
                idEncabezadoNotaCredito = value;
            }
        }

        public string CodigoBarra
        {
            get
            {
                return codigoBarra;
            }

            set
            {
                codigoBarra = value;
            }
        }

        public float Cantidad1
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

        public float Porcentaje
        {
            get
            {
                return porcentaje;
            }

            set
            {
                porcentaje = value;
            }
        }

        public DetalleNotaCredito(int idEncabezado, float cantidad, string codigoBarra, float porcentaje)
        {
            this.IdEncabezadoNotaCredito = idEncabezado;
            this.CodigoBarra = codigoBarra;
            this.Cantidad1 = cantidad;
            this.Porcentaje = porcentaje;
        }
        Consultas ObjConsulta;
        public string InsertarDetalleNC(DetalleNotaCredito objDetalleNotaCredito)
        {
            ObjConsulta = new Consultas();

            //if (!ObjConsulta.Existe("IDPROVEEDOR = " + proveedor + " AND NUMERODOCUMENTOPROVEEDOR = " + numeroProveedor + " AND SERIE1PROVEEDOR = " + serie1Proveedor + " AND SERIE2PROVEEDOR", serie2Proveedor.ToString(), "TbEncabezadoOrdenGiro"))
            //{
            if (ObjConsulta.EjecutarPROCEDUREDetalleNotaCredito(objDetalleNotaCredito))
            {
                return "Datos Guardados";
            }
            else { return "Error al Registrar"; }
            //}
            //else { return "Existe"; }
        }
        public string ActualizarDetalleNC()
        {
            ObjConsulta = new Consultas();

            //if (!ObjConsulta.Existe("IDPROVEEDOR = " + proveedor + " AND NUMERODOCUMENTOPROVEEDOR = " + numeroProveedor + " AND SERIE1PROVEEDOR = " + serie1Proveedor + " AND SERIE2PROVEEDOR", serie2Proveedor.ToString(), "TbEncabezadoOrdenGiro"))
            //{
            string sqlUpdate = "UPDATE [dbo].[TbDetalleNotaCredito] SET [IDENCABEZADONOTACREDITO] = "+ idEncabezadoNotaCredito + ",[CODIGOBARRA] = '" + CodigoBarra + "',[CANTIDAD] = " + Funcion.reemplazarcaracter(Cantidad1.ToString()) + ",[PORCENTAJE] = " + Funcion.reemplazarcaracter(Porcentaje.ToString()) + "" +
" WHERE IDENCABEZADONOTACREDITO = " + idEncabezadoNotaCredito + " and CODIGOBARRA = '" + CodigoBarra + "'";
            if (ObjConsulta.EjecutarSQL(sqlUpdate))
            {
                return "Datos Guardados";
            }
            else { return "Error al Registrar"; }
            //}
            //else { return "Existe"; }
        }
    }
}
