using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Clases
{
    class AdmSql
    {
        ConexionBD Objc = new ConexionBD();

        public bool AutenticacionUsuario(String Usuario, String Contraseña)
        {
            try
            {
                Objc.conectar();
                SqlCommand Sentencia = new SqlCommand("select count(*)from TbUsuario U where U.Usuario='" + Usuario + "' and  U.Contraseña='" + Contraseña + "'");
                Sentencia.Connection = ConexionBD.connection;
                int valor = Convert.ToInt32(Sentencia.ExecuteScalar());
                if (valor == 0)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar la base de Datos " + ex.Message, "Comprobar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        //public List<Proveedor> consultar()
        //{
        //    List<Proveedor> lista = new List<Proveedor>();
        //    Proveedor pro;
        //    try
        //    {
        //        Objc.conectar();
        //        SqlCommand command = new SqlCommand("Select IDPROVEEDOR, NOMBRES from TbProveedor", ConexionBD.connection);


        //        int result = command.ExecuteNonQuery();


        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            pro = new Proveedor(String.Format("{0}", reader["IDPROVEEDOR"]), String.Format("{0}", reader["NOMBRES"]));
        //            Console.WriteLine(String.Format("{0}", reader["id"]));
        //            lista.Add(pro);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al conectar la base de Datos " + ex.Message, "Comprobar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        //        return false;
        //    }
        //    return true;
        //    return lista;
       // }

        public void BoolLlenarComboBox(ComboBox cb, String SQL, String campo)
        {
            Objc.conectar();
            SqlDataAdapter objDA;
            DataSet objDS = new DataSet();
            objDA = new SqlDataAdapter(SQL, ConexionBD.connection);
            //2. Llenar el DataSet
            objDA.Fill(objDS);
            //3. DataBiding de los datos en el ComboBox    DataBiding el enlace de los datos
            cb.DataSource = objDS.Tables[0];
            //3b. Especificar el Datavalue y el DisplayMember
            cb.DisplayMember = "Texto";
            cb.ValueMember = campo;
            //Liberar el DataApdater
            objDA.Dispose();
        }

    }
}
