using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Comisariato.Clases
{
    public class Producto
    {

        Consultas ObjConsulta;

        string nombreproducto;
        bool activo;
        string codigobarra;
        string tipoproducto;
        string unidamedida;
        string peso;
        int stockmaximo;
        int stockminimo;
        float caja;
        int unidad;
        int display;
        //int unidadProducto;

        float preciopublico_iva;
        float preciopublico_sin_iva;
        float precioalmayor_iva;
        float precioalmayor_sin_iva;
        float precioporcaja_iva;
        float precioporcaja_sin_iva;

        float precioCompra;

        byte[] imagenproducto;
        bool ivaestado;
        string observaciones;
        int idcategoria;

        float cantidad, cantidad1;
       
        int iva;

        float ice;
        float irbp;

        string stockActual;

        bool libreImpuesto;

        public Producto(string nombreproducto, bool activo, string codigobarra, string tipoproducto, string unidamedida, string peso, int stockmaximo, int stockminimo, int caja, int unidad, float preciopublico_iva, float preciopublico_sin_iva, float precioalmayor_iva, float precioalmayor_sin_iva, float precioporcaja_iva, float precioporcaja_sin_iva, byte[] imagenproducto, bool ivaestado, string observaciones, int idcategoria, float cantidad, int display, float ice, float irbp/*, int unidadProducto*/,bool libreImpuesto)
        {
            this.nombreproducto = nombreproducto;
            this.activo = activo;
            this.codigobarra = codigobarra;
            this.tipoproducto = tipoproducto;
            this.unidamedida = unidamedida;
            this.peso = peso;
            this.stockmaximo = stockmaximo;
            this.stockminimo = stockminimo;
            this.caja = caja;
            this.unidad = unidad;
            this.preciopublico_iva = preciopublico_iva;
            this.preciopublico_sin_iva = preciopublico_sin_iva;
            this.precioalmayor_iva = precioalmayor_iva;
            this.precioalmayor_sin_iva = precioalmayor_sin_iva;
            this.precioporcaja_iva = precioporcaja_iva;
            this.precioporcaja_sin_iva = precioporcaja_sin_iva;
            this.imagenproducto = imagenproducto;
            this.ivaestado = ivaestado;
            this.observaciones = observaciones;
            this.idcategoria = idcategoria;
            this.Cantidad = cantidad;
            this.display = display;
            this.Ice = ice;
            this.Irbp = irbp;
            this.LibreImpuesto = libreImpuesto;
            //this.unidadProducto = unidadProducto;
        }
        public Producto(int cantidad, string codigo) {
            this.Cantidad = cantidad;
            this.Codigobarra = codigo;
        }

        public Producto()
        { }

        public string Nombreproducto
        {
            get
            {
                return nombreproducto;
            }

            set
            {
                nombreproducto = value;
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

        public string Codigobarra
        {
            get
            {
                return codigobarra;
            }

            set
            {
                codigobarra = value;
            }
        }

        public string Tipoproducto
        {
            get
            {
                return tipoproducto;
            }

            set
            {
                tipoproducto = value;
            }
        }

        public string Unidamedida
        {
            get
            {
                return unidamedida;
            }

            set
            {
                unidamedida = value;
            }
        }

        public string Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public int Stockmaximo
        {
            get
            {
                return stockmaximo;
            }

            set
            {
                stockmaximo = value;
            }
        }

        public int Stockminimo
        {
            get
            {
                return stockminimo;
            }

            set
            {
                stockminimo = value;
            }
        }

        public float Caja
        {
            get
            {
                return caja;
            }

            set
            {
                caja = value;
            }
        }

        public int Unidad
        {
            get
            {
                return unidad;
            }

            set
            {
                unidad = value;
            }
        }

        public float Preciopublico_iva
        {
            get
            {
                return preciopublico_iva;
            }

            set
            {
                preciopublico_iva = value;
            }
        }

        public float Preciopublico_sin_iva
        {
            get
            {
                return preciopublico_sin_iva;
            }

            set
            {
                preciopublico_sin_iva = value;
            }
        }

        public float Precioalmayor_iva
        {
            get
            {
                return precioalmayor_iva;
            }

            set
            {
                precioalmayor_iva = value;
            }
        }

        public float Precioalmayor_sin_iva
        {
            get
            {
                return precioalmayor_sin_iva;
            }

            set
            {
                precioalmayor_sin_iva = value;
            }
        }

        public float Precioporcaja_iva
        {
            get
            {
                return precioporcaja_iva;
            }

            set
            {
                precioporcaja_iva = value;
            }
        }

        public float Precioporcaja_sin_iva
        {
            get
            {
                return precioporcaja_sin_iva;
            }

            set
            {
                precioporcaja_sin_iva = value;
            }
        }

        public byte[] Imagenproducto
        {
            get
            {
                return imagenproducto;
            }

            set
            {
                imagenproducto = value;
            }
        }

        public bool Ivaestado
        {
            get
            {
                return ivaestado;
            }

            set
            {
                ivaestado = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return observaciones;
            }

            set
            {
                observaciones = value;
            }
        }

        public int Idcategoria
        {
            get
            {
                return idcategoria;
            }

            set
            {
                idcategoria = value;
            }
        }

        public float Cantidad
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

        public float Cantidad1
        {
            get
            {
                return cantidad1;
            }

            set
            {
                cantidad1 = value;
            }
        }

        public int Iva
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

        public float PrecioCompra
        {
            get
            {
                return precioCompra;
            }

            set
            {
                precioCompra = value;
            }
        }

        public int Display
        {
            get
            {
                return display;
            }

            set
            {
                display = value;
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

        public bool LibreImpuesto
        {
            get
            {
                return libreImpuesto;
            }

            set
            {
                libreImpuesto = value;
            }
        }

        public string StockActual
        {
            get
            {
                return stockActual;
            }

            set
            {
                stockActual = value;
            }
        }

        //public int UnidadProducto
        //{
        //    get
        //    {
        //        return unidadProducto;
        //    }

        //    set
        //    {
        //        unidadProducto = value;
        //    }
        //}

        public string InsertarProducto(Producto ObjProducto)
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("CODIGOBARRA", Codigobarra, "TbProducto"))
            {
                if (ObjConsulta.EjecutarPROCEDUREProducto(ObjProducto))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }
        ConexionBD Objc = new ConexionBD();
        public bool sumaCantidadProducto(Producto ObjProducto)
        {
            ObjConsulta = new Consultas();
            Objc.conectar();
            SqlCommand Sentencia = new SqlCommand("select CANTIDAD FROM TbProducto where CODIGOBARRA = '" + ObjProducto.Codigobarra + "'");
            Sentencia.Connection = ConexionBD.connection;
            SqlDataReader dato = Sentencia.ExecuteReader();
            Objc.Cerrar();
            if (dato.Read() == true)
            {
                cantidad = ObjProducto.Cantidad + Convert.ToInt32(dato["CANTIDAD"]);
                return true;
            }
            else
                return false;
        }

        public string ModificarProducto(string CodigoBarra)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbProducto] SET[NOMBREPRODUCTO] = '"+nombreproducto+ "',[ACTIVO] = '"+activo+ "' ,[CODIGOBARRA] = '"+codigobarra+ "',[TIPOPRODUCTO] ='"+tipoproducto+"'"
                + " ,[UNIDAMEDIDA] = '"+unidamedida+ "'  ,[PESO] = '"+peso+ "' ,[STOCKMAXIMO] = "+stockmaximo+ " ,[STOCKMINIMO] = "+stockminimo+ " ,[CAJA] = "+caja+ " ,[UNIDAD] = "+unidad+ " ,[PRECIOPUBLICO_IVA] = "+ Funcion.reemplazarcaracter(preciopublico_iva.ToString()) +""
                + " ,[PRECIOPUBLICO_SIN_IVA] = "+ Funcion.reemplazarcaracter(preciopublico_sin_iva.ToString()) + " ,[PRECIOALMAYOR_IVA] = "+ Funcion.reemplazarcaracter(precioalmayor_iva.ToString()) + " ,[PRECIOALMAYOR_SIN_IVA] = "+ Funcion.reemplazarcaracter(precioalmayor_sin_iva.ToString()) + ",[PRECIOPORCAJA_IVA] = "+ Funcion.reemplazarcaracter(precioporcaja_iva.ToString()) +""
                + " ,[PRECIOPORCAJA_SIN_IVA] = "+ Funcion.reemplazarcaracter(precioporcaja_sin_iva.ToString()) + " ,[IVAESTADO] = '"+ivaestado+ "'"
                + " ,[OBSERVACIONES] = '"+observaciones+ "' ,[IDCATEGORIA] = "+idcategoria+ ",[DISPLAY] = "+display+ ", [ICE] = " + Funcion.reemplazarcaracter(ice.ToString()) + " , [IRBP] = " + Funcion.reemplazarcaracter(irbp.ToString()) +", [LIBREIMPUESTO] = '"+libreImpuesto+"',[CANTIDAD] = '"+cantidad+"' "
                + " WHERE CODIGOBARRA ='"+ CodigoBarra + "' "))
            {
                ObjConsulta.EditarFoto(Imagenproducto, CodigoBarra, "[TbProducto]", "IMAGENPRODUCTO", "CODIGOBARRA");
                return "Correcto";
            }
            else { return "Error al Modificar"; }
        }

        public string EstadoProducto(string Identificacion, int estado)
        {
            ObjConsulta = new Consultas();
            if (estado == 1)
                if (ObjConsulta.EjecutarSQL("UPDATE TbProducto SET ACTIVO = 1 WHERE CODIGOBARRA = '" + Identificacion + "'"))
                {
                    return "Habilitado";
                }
                else { return "Error"; }
            else if (estado == 2)
            {
                if (ObjConsulta.EjecutarSQL("UPDATE TbProducto SET ACTIVO = 0 WHERE CODIGOBARRA = '" + Identificacion + "'"))
                {
                    return "Desabilitado";
                }
                else { return "Error"; }
            }
            else { return "Sin Accion"; }
        }



        /// <summary>
        ///  CATEGORIA
        /// </summary>
        /// <param name="DESCRIPCION"></param>
        /// <param name="COMBO"></param>
        /// <param name="MANEJAINVENTARIO"></param>
        /// <returns></returns>
        public string InsertarCategoriaProducto(string DESCRIPCION, bool COMBO, bool MANEJAINVENTARIO)
        {
            try
            {
                ObjConsulta = new Consultas();

                if (!ObjConsulta.Existe("DESCRIPCION", DESCRIPCION, "TbCategoria"))
                {
                    if (ObjConsulta.EjecutarSQL("INSERT INTO [dbo].[TbCategoria] ([DESCRIPCION],[COMBO],[MANEJAINVENTARIO],[ESTADO])"
                       + " VALUES('"+DESCRIPCION+ "','"+COMBO+ "','"+MANEJAINVENTARIO+"','True')"))
                    {
                        return "Datos Guardados";
                    }
                    else { return "Error al Registrar"; }
                }
                else { return "Existe"; }
            }
            catch (Exception)
            {
                return "";
            }
        }


        public string EstadoCategoriaProducto(string DESCRIPCION, int estado)
        {
            ObjConsulta = new Consultas();
            if (estado == 1)
                if (ObjConsulta.EjecutarSQL("UPDATE TbCategoria SET ESTADO = 1 WHERE DESCRIPCION = '" + DESCRIPCION + "'"))
                {
                    return "Habilitado";
                }
                else { return "Error"; }
            else if (estado == 2)
            {
                if (ObjConsulta.EjecutarSQL("UPDATE TbCategoria SET ESTADO = 0 WHERE DESCRIPCION = '" + DESCRIPCION + "'"))
                {
                    return "Desabilitado";
                }
                else { return "Error"; }
            }
            else { return "Sin Accion"; }
        }

        public string ModificarCategoriaProducto(string DESCRIPCION, bool COMBO, bool MANEJAINVENTARIO, string condicionDESCRIPCION)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbCategoria] SET [DESCRIPCION] = '"+DESCRIPCION+"',[COMBO] ='" + COMBO+"' ,[MANEJAINVENTARIO] = '" + MANEJAINVENTARIO+ "' WHERE [DESCRIPCION] = '" + condicionDESCRIPCION + "'"))
            {
                return "Correcto";
            }
            else { return "Error al Modificar"; }
        }
    }
}
