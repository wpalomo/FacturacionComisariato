using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class EncabezadoNotaCredito
    {
        string serie1, serie2, numero;
        int idEncabezadoCompra;
        float totalDevolucion, sub0, sub12, iva, ice, irbp, sub;
        DateTime fecha;
        String autorizacion;

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

        public float TotalDevolucion
        {
            get
            {
                return totalDevolucion;
            }

            set
            {
                totalDevolucion = value;
            }
        }

        public float Sub0
        {
            get
            {
                return sub0;
            }

            set
            {
                sub0 = value;
            }
        }

        public float Sub12
        {
            get
            {
                return sub12;
            }

            set
            {
                sub12 = value;
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

        public string Autorizacion
        {
            get
            {
                return autorizacion;
            }

            set
            {
                autorizacion = value;
            }
        }

        public float Sub
        {
            get
            {
                return sub;
            }

            set
            {
                sub = value;
            }
        }

        public EncabezadoNotaCredito(string serie1, string serie2, string numero, int idEncabezado, float totalDevolucion,
            float sub0, float sub12, float iva, float ice, float irbp, DateTime fecha, string autorizacion, float subtotal)
        {
            this.Serie1 = serie1;
            this.Serie2 = serie2;
            this.Numero = numero;
            this.IdEncabezadoCompra = idEncabezado;
            this.TotalDevolucion = totalDevolucion;
            this.Sub0 = sub0;
            this.Sub12 = sub12;
            this.Iva = iva;
            this.Ice = ice;
            this.Irbp = irbp;
            this.Fecha = fecha;
            this.Autorizacion = autorizacion;
            this.Sub = subtotal;
        }
        Consultas ObjConsulta;
        public string InsertarEncabezadoNC(EncabezadoNotaCredito objEncabezadoNotaCredito)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.verificaCreditoCompra(IdEncabezadoCompra, TotalDevolucion))
            {
                if (ObjConsulta.EjecutarPROCEDUREEncabezadoNotaCredito(objEncabezadoNotaCredito))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }
        public string ActualizarEncabezadoNC(int encabezadoCredito)
        {
            ObjConsulta = new Consultas();

            //if (ObjConsulta.verificaCreditoCompra(IdEncabezadoCompra, TotalDevolucion))
            //{
            string sqlUpdate = "UPDATE [dbo].[TbEncabezadoNotaCredito] "+
                "   SET[SERIE1] = '"+ Serie1 + "' ,[SERIE2] = '" + Serie2 + "',[NUMERO] = '" + Numero + "' ,[IDENCABEZADOCOMPRA] = " + IdEncabezadoCompra + ",[TOTALDEVOLUCION] = " + Funcion.reemplazarcaracter(TotalDevolucion.ToString()) + ",[FECHA] = '" + Funcion.reemplazarcaracterFecha(Fecha.ToShortDateString()) + "',[SUBTOTAL0] =  " + Funcion.reemplazarcaracter(Sub0.ToString()) + "" +
"      ,[SUBTOTAL12] = " + Funcion.reemplazarcaracter(Sub12.ToString()) + ",[IVA] = " + Funcion.reemplazarcaracter(Iva.ToString()) + ",[ICE] = " + Funcion.reemplazarcaracter(Ice.ToString()) + ",[IRBP] = " + Funcion.reemplazarcaracter(Irbp.ToString()) + ",[AUTORIZACION] = '" + Autorizacion + "',[SUBTOTAL] = " + Funcion.reemplazarcaracter(Sub.ToString()) + "" +
" WHERE IDENCABEZADONOTACREDITO = "+ encabezadoCredito +"";
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
