using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class Cliente
    {
        string tipocliente;
        string tipoidentificacion;
        string identificacion;
        string nombres;
        string apellidos;
        DateTime fechaNacimiento;
        string razonSocial;
        string email;
        string direccion;
        string actividadEconimica;
        bool activo;
        int idParroquia;
        string especificacionesCategoria;
        string especificacionesTipoCredito;
        string condicionesComerCreditoAsignado;
        string condicionesComerCupoCredito;
        string condicionesComerDescuento;
        int casilla;
        string fax;
        string celular1;
        string celular2;
        string observacion;
        int IDCuentaContable;
        Consultas ObjConsulta;

        public string Tipocliente
        {
            get
            {
                return tipocliente;
            }

            set
            {
                tipocliente = value;
            }
        }
        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }
        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }
        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }
        public string RazonSocial
        {
            get
            {
                return razonSocial;
            }

            set
            {
                razonSocial = value;
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
        public string ActividadEconimica
        {
            get
            {
                return actividadEconimica;
            }

            set
            {
                actividadEconimica = value;
            }
        }
        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }
        public int IdParroquia
        {
            get
            {
                return idParroquia;
            }

            set
            {
                idParroquia = value;
            }
        }
        public string EspecificacionesCategoria
        {
            get
            {
                return especificacionesCategoria;
            }

            set
            {
                especificacionesCategoria = value;
            }
        }
        public string CondicionesComerCreditoAsignado
        {
            get
            {
                return condicionesComerCreditoAsignado;
            }

            set
            {
                condicionesComerCreditoAsignado = value;
            }
        }
        public string CondicionesComerCupoCredito
        {
            get
            {
                return condicionesComerCupoCredito;
            }

            set
            {
                condicionesComerCupoCredito = value;
            }
        }
        public string CondicionesComerDescuento
        {
            get
            {
                return condicionesComerDescuento;
            }

            set
            {
                condicionesComerDescuento = value;
            }
        }
        public string Tipoidentificacion
        {
            get
            {
                return tipoidentificacion;
            }

            set
            {
                tipoidentificacion = value;
            }
        }
        public int Casilla
        {
            get
            {
                return casilla;
            }

            set
            {
                casilla = value;
            }
        }
        public string Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }
        public string Celular1
        {
            get
            {
                return celular1;
            }

            set
            {
                celular1 = value;
            }
        }
        public string Celular2
        {
            get
            {
                return celular2;
            }

            set
            {
                celular2 = value;
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
        public string EspecificacionesTipoCredito
        {
            get
            {
                return especificacionesTipoCredito;
            }

            set
            {
                especificacionesTipoCredito = value;
            }
        }

        public int IDCuentaContable1
        {
            get
            {
                return IDCuentaContable;
            }

            set
            {
                IDCuentaContable = value;
            }
        }



        public Cliente(string tipocliente, string tipoidentificacion, string identificacion, bool activo, string nombres, string apellidos, DateTime fechaNacimiento, string razonSocial, string email, string direccion, string actividadEconimica, int idParroquia, int casilla, string fax, string celula1, string celular2, string observacion, string especificacionesCategoria, string especificacionesTipoCredito, string condicionesComerCreditoAsignado, string condicionesComerCupoCredito, string condicionesComerDescuento, int IDCuentaContable)
        {
            this.Tipocliente = tipocliente;
            this.Tipoidentificacion = tipoidentificacion;
            this.Identificacion = identificacion;
            this.Activo = activo;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.RazonSocial = razonSocial;
            this.Email = email;
            this.Direccion = direccion;
            this.ActividadEconimica = actividadEconimica;
            this.IdParroquia = idParroquia;
            this.Casilla = casilla;
            this.Fax = fax;
            this.Celular1 = celula1;
            this.Celular2 = celular2;
            this.Observacion = observacion;
            this.EspecificacionesCategoria = especificacionesCategoria;
            this.EspecificacionesTipoCredito = especificacionesTipoCredito;
            this.CondicionesComerCreditoAsignado = condicionesComerCreditoAsignado;
            this.CondicionesComerCupoCredito = condicionesComerCupoCredito;
            this.CondicionesComerDescuento = condicionesComerDescuento;
            this.IDCuentaContable = IDCuentaContable;
        }
        public Cliente()
        {

        }
        public string InsertarCliente()
        {
            ObjConsulta = new Consultas();
            if (!ObjConsulta.Existe("IDENTIFICACION", identificacion, "TbCliente"))
            {
                bool resultInsertCliente = ObjConsulta.EjecutarSQL("INSERT INTO[dbo].[TbCliente]" +
           "([TIPOCLIENTE],[TIPOIDENTIFICACION],[IDENTIFICACION],[ACTIVO],[NOMBRES],[APELLIDOS]" +
           ",[FECHANACIMIENTO],[RAZONSOCIAL],[EMAIL],[DIRECCION],[ACTIVIDADECONOMICA],[IDPARROQUIA]" +
           ",[CASILLA],[FAX],[CELULAR1],[CELULAR2],[OBSERVACION],[ESPECIFICACIONES_CATEGORIA]" +
           ",[ESPECIFICACIONES_TIPOCREDITO],[CONDICIONES_COMERC_CREDITOASIGNADO],[CONDICIONES_COMERC_CUPOCREDITO]" +
           ",[CONDICIONES_COMERC_DESCUENTO],[IDCuentaContable])" +
                    " VALUES " +
                    "('" + tipocliente.ToUpper() + "','" + tipoidentificacion.ToUpper() + "','" + identificacion + "','" + activo + "','" + nombres.ToUpper() + "','" + apellidos.ToUpper() +
                    "','" +Funcion.reemplazarcaracterFecha(fechaNacimiento.Date.ToShortDateString()) + "','" + razonSocial.ToUpper() + "','" + email + "','" + direccion.ToUpper() + "','" + actividadEconimica.ToUpper() + "'," + IdParroquia +
                    "," + casilla + ",'" + fax + "','" + celular1 + "','" + celular2 + "','" + observacion + "','" + especificacionesCategoria.ToUpper() +
                    "','" + especificacionesTipoCredito.ToUpper() + "'," + condicionesComerCreditoAsignado + "," + condicionesComerCupoCredito +
                    "," + condicionesComerDescuento + ","+IDCuentaContable+");");
                if (resultInsertCliente)
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }
        public string InsertarOtraInformacionCliente(string tipo, string identificacion, string nombre, string email, string celular, int idcliente)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("INSERT INTO [dbo].[TbOtraInformacionCliente]([TIPO] ,[IDENTIFICACION] ,[NOMBRE]" +
           ",[EMAIL],[CELULAR],[IDCLIENTE]) VALUES('" + tipo + "','" + identificacion + "','" + nombre + "','" + email + "','" + celular + "'," + idcliente + ")"))
            {
                return "Datos Guardados";
            }
            else { return "Error al Registrar"; }
        }

        public string ModificarrOtraInformacionCliente(string tipo, string identificacion, string nombre, string email, string celular, int idcliente)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbOtraInformacionCliente] SET [TIPO] ='"+ tipo + "' ,[IDENTIFICACION] = '"+ identificacion + "' ,[NOMBRE] ='"+ nombre + "' ,[EMAIL] = '"+ email + "' ,[CELULAR] =  '"+ celular + "'  WHERE [IDCLIENTE] = " + idcliente + " "))
            {
                return "Datos Guardados";
            }
            else { return "Error al Registrar"; }
        }

        //No eh trabajado desde aqui en adelante ANDRES
        public string ModificarCliente(string Identificacion)
        {
            ObjConsulta = new Consultas();
            //int IDClinte = ObjConsulta.ObtenerID("IDCLIENTE", "TbCliente where [IDENTIFICACION] = '" + Identificacion + "'");
            bool ModificarCliente = ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbCliente] SET[TIPOCLIENTE] = '" + tipocliente.ToUpper() + "',[TIPOIDENTIFICACION] = '" + tipoidentificacion + "' ,[IDENTIFICACION] = '" + identificacion + "' ,[ACTIVO] = '" + activo + "'" +
                ",[NOMBRES] = '" + nombres.ToUpper() + "',[APELLIDOS] = '" + apellidos.ToUpper() + "' ,[FECHANACIMIENTO] = '" + Funcion.reemplazarcaracterFecha(fechaNacimiento.ToShortDateString()) + "' ,[RAZONSOCIAL] = '" + razonSocial.ToUpper() + "' ,[EMAIL] = '" + email + "' ,[DIRECCION] = '" + direccion.ToUpper() + "' ,[ACTIVIDADECONOMICA] = '" + actividadEconimica + "'" +
                ",[IDPARROQUIA] = " + idParroquia + ",[CASILLA] = " + casilla + ",[FAX] = '" + fax + "' ,[CELULAR1] = '" + celular1 + "' ,[CELULAR2] = '" + celular2 + "' ,[OBSERVACION] = '" + observacion + "' ,[ESPECIFICACIONES_CATEGORIA] ='" + especificacionesCategoria + "'" +
                ",[ESPECIFICACIONES_TIPOCREDITO] = '"+especificacionesTipoCredito+"' ,[CONDICIONES_COMERC_CREDITOASIGNADO] = "+condicionesComerCreditoAsignado+ ",[CONDICIONES_COMERC_CUPOCREDITO] = "+condicionesComerCupoCredito+"" +
                ",[CONDICIONES_COMERC_DESCUENTO] = "+condicionesComerDescuento+ ", [IDCuentaContable]= "+IDCuentaContable+"  WHERE IDENTIFICACION = '" + Identificacion + "';");
            if (ModificarCliente)
            {
                return "Correcto";
            }
            else { return "Error al Modificar"; }
        }

        public string EstadoCliente(string Identificacion, int estado)
        {
            ObjConsulta = new Consultas();
            if (estado == 1)
                if (ObjConsulta.EjecutarSQL("UPDATE TbCliente SET ACTIVO = 1 WHERE IDENTIFICACION = '" + Identificacion + "'"))
                {
                    return "Habilitado";
                }
                else { return "Error"; }
            else if (estado == 2)
            {
                if (ObjConsulta.EjecutarSQL("UPDATE TbCliente SET ACTIVO = 0 WHERE IDENTIFICACION = '" + Identificacion + "'"))
                {
                    return "Correcto";
                }
                else { return "Error"; }
            }
            else { return "Sin Accion"; }
        }



        //private void CargarUnidadesEnCombo(DataGridViewRow fila)
        //{

        //    int idArticulo = 0;
        //    DataTable dt = new DataTable();

        //    idArticulo = fila.Cells("id_articulo").value;

        //    //Llamamos a una funcion que devuelve una Tabla con las unidades, dependiendo del codigo de producto
        //    dt = ObtenerDetalle(idArticulo);

        //    DataGridViewComboBoxCell Celda = (DataGridViewComboBoxCell)fila.Cells("Unidad").value;

        //    var _with1 = Celda;
        //    _with1.DataSource = dt;
        //    _with1.DisplayMember = "Unidad";
        //    _with1.ValueMember = "Código";
        //    if (dtContacto == null || dtContacto.Rows.Count <= 0)
        //    {
        //        _with1.ReadOnly = true;
        //    }
        //    else
        //    {
        //        _with1.ReadOnly = false;
        //    }
        //}

    }
}
