using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFacturacionElectronica.Class
{
    class Consultas
    {
        ConexionBD Objc = new ConexionBD();

        public DataTable BoolDataTableFactElect(String SQL)
        {
            try
            {
                Objc.conectar();
                SqlDataAdapter objDA;
                DataTable objDS = new DataTable();
                objDA = new SqlDataAdapter(SQL, ConexionBD.connection);
                //2. Llenar el DataSet
                objDA.Fill(objDS);
                Objc.Cerrar();
                objDA.Dispose();
                return objDS;

                //Objc.conectarComi();
                //SqlDataAdapter objDA;
                //DataTable objDS = new DataTable();
                //objDA = new SqlDataAdapter(SQL, ConexionBD.connection);
                ////2. Llenar el DataSet
                //objDA.Fill(objDS);
                //Objc.CerrarComi();
                //objDA.Dispose();
                //return objDS;
            }
            catch (Exception ex)
            {
                return null;
            }

        }


        public bool EjecutarSQL(string SQL)
        {
            try
            {
                SqlCommand Sentencia;
                Sentencia = new SqlCommand(SQL);
                Objc.conectar();
                Sentencia.Connection = ConexionBD.connection;
                Sentencia.ExecuteNonQuery();
                Objc.Cerrar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        //desde aqui conmienza la consulta a la bdComisariato
        public List<String> ConsutarFactura(string fecha , string claveacceso)
        {

            List<String> Facturas = new List<String>();
            try
            {

                Objc.conectarComi();
                //INNER JOIN TbCliente C ON( A.IDEMPLEADO= U.IDEMPLEADO and C.IDCLIENTE=U.IDCLIENTE)
                string sql = "SELECT U.SUCURSAL, U.CAJA, U.NFACTURA , U.CLAVEACCESO,C.IDENTIFICACION, C.RAZONSOCIAL, C.DIRECCION from TbEncabezadoFactura U INNER JOIN TbCliente C ON(C.IDCLIENTE=U.IDCLIENTE) where U.FECHA='" + fecha + "' and U.CLAVEACCESO='" + claveacceso +"'";
                SqlCommand Sentencia = new SqlCommand(sql);
                Sentencia.Connection = ConexionBD.connection;
                SqlDataReader dato = Sentencia.ExecuteReader();
                while (dato.Read() == true)
                {
                    string direccion = "S/N";
                    if (dato["DIRECCION"] != System.DBNull.Value)
                    {
                        direccion = Convert.ToString(dato["DIRECCION"]);
                    }
                    Facturas.Add("" + Convert.ToInt32(dato["SUCURSAL"]) + ";" + "" + Convert.ToInt32(dato["CAJA"]) + ";" + "" + Convert.ToInt32(dato["NFACTURA"]) + ";" + (String)dato["CLAVEACCESO"] + ";" + (String)dato["IDENTIFICACION"] + ";" + (String)dato["RAZONSOCIAL"] + ";" + direccion);

                }

            }
            catch (Exception ex)
            {

            }

            Objc.CerrarComi();
            return Facturas;
        }

        public List<Producto> DetalleFact(int nfact, int caja)
        {
            try
            {
                List<Producto> lista = new List<Producto>();
                Objc.conectarComi();
                //string sql = " SELECT U.PRECIO, U.CANTDEVUELTA, U.CANTIDAD, U.CODIGOBARRAPRODUCTO, U.ESTADO, U.IVA, P.NOMBREPRODUCTO, P.IVAESTADO from TbDetalleFactura U INNER JOIN TbProducto P  ON(U.NFACTURA = '" + nfact + "') AND(P.CODIGOBARRA = U.CODIGOBARRAPRODUCTO)";
                String sql = "SELECT        dbo.TbDetalleFactura.PRECIO, dbo.TbDetalleFactura.CANTDEVUELTA, dbo.TbDetalleFactura.CANTIDAD, dbo.TbDetalleFactura.CODIGOBARRAPRODUCTO, dbo.TbDetalleFactura.ESTADO, dbo.TbDetalleFactura.IVA, dbo.TbProducto.NOMBREPRODUCTO, dbo.TbProducto.IVAESTADO, dbo.TbEncabezadoFactura.NFACTURA FROM  dbo.TbDetalleFactura INNER JOIN" +
                         " dbo.TbProducto ON dbo.TbDetalleFactura.CODIGOBARRAPRODUCTO = dbo.TbProducto.CODIGOBARRA INNER JOIN dbo.TbEncabezadoFactura ON dbo.TbDetalleFactura.NFACTURA = dbo.TbEncabezadoFactura.IDFACTURA" +
                         " WHERE(dbo.TbEncabezadoFactura.NFACTURA = '" + nfact + "' and dbo.TbEncabezadoFactura.CAJA = '" + caja + "') order by ID asc";
                SqlCommand comando = new SqlCommand(sql);
                comando.Connection = ConexionBD.connection;
                SqlDataReader dato = comando.ExecuteReader();
                Objc.CerrarComi();
                while (dato.Read() == true)
                {
                    Producto p = new Producto();
                    // p.Observaciones = claveacceso;
                    p.Preciopublico_sin_iva = Convert.ToSingle(dato["PRECIO"].ToString());
                    p.Cantidad = Convert.ToSingle(dato["CANTIDAD"].ToString());
                    p.Codigobarra = (String)dato["CODIGOBARRAPRODUCTO"];
                    p.Nombreproducto = (String)dato["NOMBREPRODUCTO"];
                    p.Iva = Convert.ToInt32(dato["IVA"].ToString());

                    lista.Add(p);
                }
                return lista;
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error al buscar cliente: " + ex);
                return null;
            }
        }

        public String CorreoCliente(string identificacion)
        {
            try
            {
                string correo = "";
                Objc.conectarComi();
                //INNER JOIN TbCliente C ON( A.IDEMPLEADO= U.IDEMPLEADO and C.IDCLIENTE=U.IDCLIENTE)
                string sql = "SELECT U.EMAIL from TbCliente U where U.IDENTIFICACION='" + identificacion + "'";
                SqlCommand Sentencia = new SqlCommand(sql);
                Sentencia.Connection = ConexionBD.connection;
                SqlDataReader dato = Sentencia.ExecuteReader();
                Objc.CerrarComi();
                if (dato.Read() == true)
                {
                    string email = "S/N";
                    if (dato["EMAIL"] != System.DBNull.Value)
                    {
                        email = Convert.ToString(dato["EMAIL"]);
                    }
                    correo = email;
                  

                }

                return correo;
            }
            catch (Exception ex)
            {
                return "";
            }

           
        }

        public String NombreEmpresa()
        {
            try
            {
                string correo = "";
                string Nombrecomercil = "S/N";
                string Email = "S/N";
                string PassEmail = "S/N";
                Objc.conectarComi();
                //INNER JOIN TbCliente C ON( A.IDEMPLEADO= U.IDEMPLEADO and C.IDCLIENTE=U.IDCLIENTE)
                string sql = "SELECT U.NOMBRECOMERCIAL, U.EMAIL, U.PASSEMAIL from TbEmpresa U";
                SqlCommand Sentencia = new SqlCommand(sql);
                Sentencia.Connection = ConexionBD.connection;
                SqlDataReader dato = Sentencia.ExecuteReader();
                Objc.CerrarComi();
                while (dato.Read() == true)
                {
                    
                    if (dato["NOMBRECOMERCIAL"] != System.DBNull.Value)
                    {
                        Nombrecomercil = Convert.ToString(dato["NOMBRECOMERCIAL"]);
                    }
                    
                    if (dato["EMAIL"] != System.DBNull.Value)
                    {
                        Email = Convert.ToString(dato["EMAIL"]);
                    }

                    if (dato["PASSEMAIL"] != System.DBNull.Value)
                    {
                        PassEmail = Convert.ToString(dato["PASSEMAIL"]);
                    }



                }
                correo = Nombrecomercil + ";" + Email+";"+PassEmail;
                return correo;
            }
            catch (Exception ex)
            {
                return "";
            }


        }

        //FIN CONSULTA BDCOMISARIATO

    }
}
