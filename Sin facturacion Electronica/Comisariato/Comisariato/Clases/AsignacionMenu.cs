using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class AsignacionMenu
    {
        int menu, empleado;

        public int Empleado
        {
            get
            {
                return empleado;
            }

            set
            {
                empleado = value;
            }
        }

        public int Menu
        {
            get
            {
                return menu;
            }

            set
            {
                menu = value;
            }
        }
        //public AsignacionMenu(int menu, int empleado)
        //{
        //    this.Empleado = empleado;
        //    this.Menu = menu;
        //}
        Consultas objConsulta;
        public string InsertarMenuAsignado(int menu, int empleado)
        {
            try
            {
                objConsulta = new Consultas();

                //if (!objConsulta.Existe("DESCRIPCION", DESCRIPCION, "TbCategoria"))
                //{
                if (objConsulta.EjecutarSQL("INSERT INTO [dbo].[TbAsignacionMenu]([IDUSUARIO],[IDMENU])VALUES(" + empleado + "," + menu + ")"))
                    {
                        return "Datos Guardados";
                    }
                    else { return "Error al Registrar"; }
                //}
                //else { return "Existe"; }
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
