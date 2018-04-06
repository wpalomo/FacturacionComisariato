using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Clases
{
    public class Empleado
    {
        string tipoidentificacion;
        string identificacion;
        string nombres;
        string apellidos;
        bool activo;
        string direccion;
        byte[] foto;
        int idParroquia;
        string email;
        DateTime fechaNacimiento;
        string tipolicencia;
        string tipoSangre;
        string libretamilitar;
        bool discapacidad;
        int porcentajediscapacidad;
        float movimientoQuincenal;
        string genero;
        string estadocivil;
        float sueldomensual;
        float sueldoextra;
        string celular1;
        string celular2;


        Consultas ObjConsulta;

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

        public byte[] Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
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

        public string Tipolicencia
        {
            get
            {
                return tipolicencia;
            }

            set
            {
                tipolicencia = value;
            }
        }

        public string TipoSangre
        {
            get
            {
                return tipoSangre;
            }

            set
            {
                tipoSangre = value;
            }
        }

        public string Libretamilitar
        {
            get
            {
                return libretamilitar;
            }

            set
            {
                libretamilitar = value;
            }
        }

        public bool Discapacidad
        {
            get
            {
                return discapacidad;
            }

            set
            {
                discapacidad = value;
            }
        }

        public int Porcentajediscapacidad
        {
            get
            {
                return porcentajediscapacidad;
            }

            set
            {
                porcentajediscapacidad = value;
            }
        }

        public float MovimientoQuincenal
        {
            get
            {
                return movimientoQuincenal;
            }

            set
            {
                movimientoQuincenal = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public string Estadocivil
        {
            get
            {
                return estadocivil;
            }

            set
            {
                estadocivil = value;
            }
        }

        public float Sueldomensual
        {
            get
            {
                return sueldomensual;
            }

            set
            {
                sueldomensual = value;
            }
        }

        public float Sueldoextra
        {
            get
            {
                return sueldoextra;
            }

            set
            {
                sueldoextra = value;
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

        public Empleado(string tipoidentificacion, string identificacion, string nombres, string apellidos, bool activo, string direccion, byte[] foto, int idParroquia, string email, DateTime fechaNacimiento, string tipolicencia, string tipoSangre, string libretamilitar, bool discapacidad, int porcentajediscapacidad, float movimientoQuincenal, string genero, string estadocivil, float sueldomensual, float sueldoextra, string celular1, string celular2)
        {
            this.Tipoidentificacion = tipoidentificacion;
            this.Identificacion = identificacion;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Activo = activo;
            this.Direccion = direccion;
            this.Foto = foto;
            this.IdParroquia = idParroquia;
            this.Email = email;
            this.FechaNacimiento = fechaNacimiento;
            this.Tipolicencia = tipolicencia;
            this.TipoSangre = tipoSangre;
            this.Libretamilitar = libretamilitar;
            this.Discapacidad = discapacidad;
            this.Porcentajediscapacidad = porcentajediscapacidad;
            this.MovimientoQuincenal = movimientoQuincenal;
            this.Genero = genero;
            this.Estadocivil = estadocivil;
            this.Sueldomensual = sueldomensual;
            this.Sueldoextra = sueldoextra;
            this.Celular1 = celular1;
            this.Celular2 = celular2;
        }

        public Empleado()
        { }



        public string InsertarEmpleado( Empleado objempleado )
        {
            ObjConsulta = new Consultas();
            

            if (!ObjConsulta.Existe("IDENTIFICACION", identificacion, "TbEmpleado"))
            {
                if (ObjConsulta.EjecutarPROCEDUREEmpleado(objempleado))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }








        //No eh trabajado desde aqui en adelante ANDRES
        public string ModificarEmpleado(string Identificacion, byte[] foto)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbEmpleado] SET[TIPOIDENTIFICACION] = '"+tipoidentificacion.ToUpper() + "' ,[IDENTIFICACION] = '"+identificacion+ "'  ,[NOMBRES] = '"+nombres.ToUpper() + "',[APELLIDOS] = '"+apellidos.ToUpper() + "'"
                + " ,[ACTIVO] = '"+activo+ "',[DIRECCION] = '"+direccion.ToUpper() + "',[IDPARROQUIA] ="+IdParroquia+ ",[EMAIL] ='"+email+ "' ,[FECHANACIMIENTO] ='"+Funcion.reemplazarcaracterFecha(fechaNacimiento.ToShortDateString())+ "',[TIPOLICENCIA] = '"+tipolicencia.ToUpper() + "'"
                + ",[TIPOSANGRE] = '"+tipoSangre.ToUpper() + "',[LIBRETAMILITAR] = '"+libretamilitar+ "',[DISCAPACIDAD] ='"+discapacidad+ "',[PORCENTAJEDISCAPACIDAD] = "+porcentajediscapacidad+ " ,[MOVIMIENTOQUINCENAL] = "+movimientoQuincenal+" "
                + ",[GENERO] = '"+genero.ToUpper() + "' ,[ESTADOCIVIL] = '"+estadocivil.ToUpper() + "' ,[SUELDOMENSUAL] = "+Sueldomensual+ " ,[SUELDOEXTRA] = "+sueldoextra+ ",[CELULAR1] = '"+celular1+ "',[CELULAR2] = '"+celular2+"' "
                +" WHERE IDENTIFICACION = '" + Identificacion + "';")  && ObjConsulta.EditarFoto(foto, Identificacion,"TbEmpleado", "[IMAGEN]","[IDENTIFICACION]"))
            {
                return "Correcto";
            }
            else { return "Error al Modificar"; }
        }

        public string EstadoEmpleado(string Identificacion, int estado)
        {
            ObjConsulta = new Consultas();
            if (estado == 1)
                if (ObjConsulta.EjecutarSQL("UPDATE TbEmpleado SET ACTIVO = 1 WHERE IDENTIFICACION = '" + Identificacion + "'"))
                {
                    return "Habilitado";
                }
                else { return "Error"; }
            else if (estado == 2)
            {
                if (ObjConsulta.EjecutarSQL("UPDATE TbEmpleado SET ACTIVO = 0 WHERE IDENTIFICACION = '" + Identificacion + "'"))
                {
                    return "Correcto";
                }
                else { return "Error"; }
            }
            else { return "Sin Accion"; }
        }
    }
}
