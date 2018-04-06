using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class EncabezadoNotaDebito
    {
        string serie1, serie2, numero;
        int idEncabezadoVenta;
        float totalDevolucion;

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

        public int IdEncabezadoVenta
        {
            get
            {
                return idEncabezadoVenta;
            }

            set
            {
                idEncabezadoVenta = value;
            }
        }

        public EncabezadoNotaDebito(string serie1, string serie2, string numero, int idEncabezado, float totalDevolucion)
        {
            this.Serie1 = serie1;
            this.Serie2 = serie2;
            this.Numero = numero;
            this.IdEncabezadoVenta = idEncabezado;
            this.TotalDevolucion = totalDevolucion;
        }
        Consultas ObjConsulta;
        public string InsertarEncabezadoND(EncabezadoNotaDebito objEncabezadoNotaDebito)
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("IDENCABEZADOVENTA", IdEncabezadoVenta.ToString(), "TbEncabezadoNotaDebito"))
            {
                if (ObjConsulta.EjecutarPROCEDUREEncabezadoNotaDebito(objEncabezadoNotaDebito))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }
    }
}
