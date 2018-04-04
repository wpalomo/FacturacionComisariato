using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class DetalleOrdenGiro
    {
        int idEncabezadoOrdenGiro, idRetencion;
        float monto;

        public DetalleOrdenGiro(int idEncabezadoOrdenGiro, int idRetencion, float monto)
        {
            this.IdEncabezadoOrdenGiro = idEncabezadoOrdenGiro;
            this.IdRetencion = idRetencion;
            this.Monto = monto;
        }

        public int IdEncabezadoOrdenGiro
        {
            get
            {
                return idEncabezadoOrdenGiro;
            }

            set
            {
                idEncabezadoOrdenGiro = value;
            }
        }

        public int IdRetencion
        {
            get
            {
                return idRetencion;
            }

            set
            {
                idRetencion = value;
            }
        }

        public float Monto
        {
            get
            {
                return monto;
            }

            set
            {
                monto = value;
            }
        }

        Consultas ObjConsulta;
        public string InsertarDetalledoOrden(DetalleOrdenGiro objDetalleOrdenGiro)
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("IDRETENCION = " + idRetencion + " AND IDENCABEZADOORDENGIRO", idEncabezadoOrdenGiro.ToString(), "TbDetalleOrdenGiro"))
            {
                if (ObjConsulta.EjecutarPROCEDUREDetalleOrdenGiro(objDetalleOrdenGiro))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }
    }
}
