using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class Sucursal
    {
        string codigo;
        string nombresucursal;
        string ruc;
        string telefono;
        string celular;
        string jefesucursal;
        string email;
        string direccion;
        string ubicacion;
        int idempresa;
        bool estado;
        private Consultas ObjConsulta;

       
        public Sucursal()
        { }

        public Sucursal(string codigo, string nombresucursal, string ruc, string telefono, string celular, string jefesucursal, string email, string direccion, string ubicacion, int idempresa, bool estado)
        {
            this.codigo = codigo;
            this.nombresucursal = nombresucursal;
            this.ruc = ruc;
            this.telefono = telefono;
            this.celular = celular;
            this.jefesucursal = jefesucursal;
            this.email = email;
            this.direccion = direccion;
            this.ubicacion = ubicacion;
            this.idempresa = idempresa;
            this.estado = estado;
        }

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

        public string Nombresucursal
        {
            get
            {
                return nombresucursal;
            }

            set
            {
                nombresucursal = value;
            }
        }

        public string Ruc
        {
            get
            {
                return ruc;
            }

            set
            {
                ruc = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Jefesucursal
        {
            get
            {
                return jefesucursal;
            }

            set
            {
                jefesucursal = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
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

        public int Idempresa
        {
            get
            {
                return idempresa;
            }

            set
            {
                idempresa = value;
            }
        }

        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public string InsertarSucursal()
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("RUC", ruc, "TbSucursal"))
            {
                if (ObjConsulta.EjecutarSQL("INSERT INTO [dbo].[TbSucursal] ([CODIGO] ,[NOMBRESUCURSAL] ,[RUC],[TELEFONO],"
                    +"[CELULAR],[JEFESUCURSAL] ,[EMAIL],[DIRECCION],[UBICACION],[ESTADO] ,[IDEMPRESA])"
                    + " VALUES ('"+codigo+ "','"+nombresucursal + "','"+ruc+ "', '"+telefono+ "','"+celular+ "','"+jefesucursal + "',"+
                    " '"+email+ "','"+direccion + "','"+ubicacion + "', '"+estado+ "', "+idempresa+" ) "))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }

        public string ModificarSucursal(string RUC)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbSucursal] SET [CODIGO] = '"+codigo+ "'  ,[NOMBRESUCURSAL] = '"+nombresucursal + "',"
                + "[RUC] = '"+ruc+ "',[TELEFONO] ='"+telefono+ "' ,[CELULAR] ='"+celular+ "' ,[JEFESUCURSAL] = '"+jefesucursal + "' "
                + " ,[EMAIL] = '"+email+ "',[DIRECCION] = '"+direccion + "' ,[UBICACION] = '"+ubicacion + "'  ,[ESTADO] = '"+estado+ "'  ,[IDEMPRESA] = "+idempresa+"  WHERE RUC = '" + RUC + "' "))
            {
                return "Correcto";
            }
            else { return "Error al Modificar"; }
        }

        public string EstadoSucursal(string RUC, int estado)
        {
            ObjConsulta = new Consultas();
            if (estado == 1)
                if (ObjConsulta.EjecutarSQL("UPDATE TbSucursal SET ESTADO = 1 WHERE RUC = '" + RUC + "'"))
                {
                    return "Habilitado";
                }
                else { return "Error"; }
            else if (estado == 2)
            {
                if (ObjConsulta.EjecutarSQL("UPDATE TbSucursal SET ESTADO = 0 WHERE RUC = '" + RUC + "'"))
                {
                    return "Correcto";
                }
                else { return "Error"; }
            }
            else { return "Sin Accion"; }
        }


    }
}
