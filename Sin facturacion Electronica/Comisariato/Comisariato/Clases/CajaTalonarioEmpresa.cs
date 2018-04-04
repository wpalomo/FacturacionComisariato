using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class CajaTalonarioEmpresa
    {
        Consultas ObjConsulta;

        int IDsucursal;
        int IDBodega;
        string tipoDocumento;
        string autorizacion;
        string documentoInicial;
        string documentoFinal;
        string documentoActual;
        string fechaCaducidad;
        bool estado;
        string Estacion;
        string ipEstacion;
        string serie1;
        string serie2;

        public CajaTalonarioEmpresa()
        { }

        public CajaTalonarioEmpresa(int dsucursal, int iDBodega, string tipoDocumento, string documentoInicial, string documentoFinal, string documentoActual, string fechaCaducidad, bool estado, string estacion, string ipEstacion, string serie1, string serie2, string autorizacion)
        {
            IDsucursal = dsucursal;
            IDBodega = iDBodega;
            this.tipoDocumento = tipoDocumento;
            this.documentoInicial = documentoInicial;
            this.documentoFinal = documentoFinal;
            this.documentoActual = documentoActual;
            this.fechaCaducidad = fechaCaducidad;
            this.estado = estado;
            this.Estacion = estacion;
            this.ipEstacion = ipEstacion;
            this.serie1 = serie1;
            this.serie2 = serie2;
            this.autorizacion = autorizacion;
        }

        public int IDsucursal1
        {
            get
            {
                return IDsucursal;
            }

            set
            {
                IDsucursal = value;
            }
        }

        public int IDBodega1
        {
            get
            {
                return IDBodega;
            }

            set
            {
                IDBodega = value;
            }
        }

        public string TipoDocumento
        {
            get
            {
                return tipoDocumento;
            }

            set
            {
                tipoDocumento = value;
            }
        }

        public string DocumentoInicial
        {
            get
            {
                return documentoInicial;
            }

            set
            {
                documentoInicial = value;
            }
        }

        public string DocumentoFinal
        {
            get
            {
                return documentoFinal;
            }

            set
            {
                documentoFinal = value;
            }
        }

        public string DocumentoActual
        {
            get
            {
                return documentoActual;
            }

            set
            {
                documentoActual = value;
            }
        }

        public string FechaCaducidad
        {
            get
            {
                return fechaCaducidad;
            }

            set
            {
                fechaCaducidad = value;
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

        public string Estacion1
        {
            get
            {
                return Estacion;
            }

            set
            {
                Estacion = value;
            }
        }

        public string IpEstacion
        {
            get
            {
                return ipEstacion;
            }

            set
            {
                ipEstacion = value;
            }
        }

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

        public string Insertar()
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("TIPODOCUMENTO = '"+ tipoDocumento +"' and SERIE2 = '" + serie2 + "' AND SERIE1", serie1, "TbCajasTalonario") )
            {
                if (ObjConsulta.EjecutarSQL("INSERT INTO [dbo].[TbCajasTalonario] ([TIPODOCUMENTO] ,[SERIE1],[SERIE2],[DOCUMENTOINICIAL],[DOCUMENTOFINAL],[DOCUMENTOACTUAL] ,[AUTORIZACION] ,[FECHACADUCIDAD] ,[ESTACION] ,[IPESTACION],[IDSUCURSAL] ,[IDBODEGA] ,[ESTADO])"
                    + " VALUES ('" + tipoDocumento + "','" + serie1 + "','" + serie2 + "','" + documentoInicial + "','" + documentoFinal + "','" + documentoActual + "','" + autorizacion + "','" + Funcion.reemplazarcaracterFecha(fechaCaducidad) + "','" + Estacion + "','" + ipEstacion + "'," + IDsucursal + "," + IDBodega + ",'" + estado + "')"))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }


        public string EstadoCajaTalo(string ID, int estado)
        {
            ObjConsulta = new Consultas();
            if (estado == 1)
                if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbCajasTalonario] SET ESTADO = 1 WHERE IDCAJATALONARIO = " + ID + ";"))
                {
                    return "Habilitado";
                }
                else { return "Error"; }
            else if (estado == 2)
            {
                if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbCajasTalonario] SET ESTADO = 0 WHERE IDCAJATALONARIO = " + ID + ";"))
                {
                    return "Correcto";
                }
                else { return "Error"; }
            }
            else { return "Sin Accion"; }
        }

        public string Modificar(string IDCajaTalonario)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbCajasTalonario] SET[TIPODOCUMENTO] = '" + tipoDocumento + "' ,[SERIE1] = '" + serie1 + "' ,[SERIE2] = '" + serie2 + "',[DOCUMENTOINICIAL] = '" + documentoInicial + "',[DOCUMENTOFINAL] = '" + documentoFinal + "'"
                + ",[DOCUMENTOACTUAL] = '" + documentoActual + "',[AUTORIZACION] ='" + autorizacion + "' ,[FECHACADUCIDAD] = '" + Funcion.reemplazarcaracterFecha(fechaCaducidad) + "' ,[ESTACION] = '" + Estacion + "' ,[IPESTACION] = '" + ipEstacion + "'  ,[IDSUCURSAL] = " + IDsucursal + ""
                + ",[IDBODEGA] = " + IDBodega + ",[ESTADO] = '" + estado + "' WHERE IDCAJATALONARIO = " + IDCajaTalonario + " ; "))
            {
                return "Correcto";
            }
            else { return "Error al Modificar"; }
        }

    }
}
