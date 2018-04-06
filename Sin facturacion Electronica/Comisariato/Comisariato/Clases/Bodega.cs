using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class Bodega
    {
        Consultas ObjConsulta;

        string nombre;
        string ubicacion;
        int respondableEmpleado;

        public Bodega(string nombre, string ubicacion, int respondableEmpleado)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.respondableEmpleado = respondableEmpleado;
        }
        public Bodega()
        {
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Ubicacion
        {
            get
            {
                return ubicacion;
            }

            set
            {
                ubicacion = value;
            }
        }

        public int RespondableEmpleado
        {
            get
            {
                return respondableEmpleado;
            }

            set
            {
                respondableEmpleado = value;
            }
        }

        public string InsertarBodega()
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("NOMBRE", nombre.ToUpper(), "TbBodega"))
            {
                if (ObjConsulta.EjecutarSQL("INSERT INTO TbBodega ([NOMBRE],[UBICACION],[IDEMPLEADO],[ESTADO]) VALUES ('" + nombre.ToUpper() + "','" + ubicacion.ToUpper() + "'," + respondableEmpleado + ",1);"))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }

        public string ModificarBodega(string nombreBodega)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("UPDATE TbBodega SET [NOMBRE] = '" + nombre.ToUpper() + "',[UBICACION] = '" + ubicacion.ToUpper() + "',[IDEMPLEADO] = " + respondableEmpleado + " where  [NOMBRE] = '" + nombreBodega + "'"))
            {
                return "Correcto";
            }
            else { return "Error al Modificar"; }
        }

        public string EstadoBodega(string nombreBodega, int estado)
        {
            ObjConsulta = new Consultas();
            if (estado == 1)
                if (ObjConsulta.EjecutarSQL("UPDATE TbBodega SET ESTADO = 1 WHERE NOMBRE = '" + nombreBodega + "'"))
                {
                    return "Habilitado";
                }
                else { return "Error"; }
            else if (estado == 2)
            {
                if (ObjConsulta.EjecutarSQL("UPDATE TbBodega SET ESTADO = 0 WHERE NOMBRE = '" + nombreBodega + "'"))
                {
                    return "Correcto";
                }
                else { return "Error"; }
            }
            else { return "Sin Accion"; }
        }
    }
}