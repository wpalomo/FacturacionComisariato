

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Comisariato.Properties;

namespace Comisariato.Clases
{
   public class ConexionBD
    {
        public static SqlConnection connection = null;
        //------------------------------Conexion Andres ----------------------------------------//
        //Data Source=DESKTOP-FUFA7EG\\ANDRES;Initial Catalog=BDComisariato;Integrated Security=True
        //Data Source=DESKTOP-G14ID1U;Initial Catalog=BDComisariato;Integrated Security=True
        //------------------------------Conexion Servidor----------------------------------------//
        //data source = AIRCONTROL, 1433; initial catalog = BDComisariato; user id = COMI; password = server@1;

        //------------------------------Conexion Byron ----------------------------------------//
        //Data Source = DESKTOP-SI5M9C5; Initial Catalog = BDComisariato; Integrated Security = True

        //DJSERATO\SQLEXPRESS



        public void conectar()
        {
            try
            {

                //string[] datosArchivoConfig = Funcion.leerArchivo(@"\\Aircontrol\c\Program Files (x86)\AIRCONTROL\Conexion.shc");
                //string[] servidorPuerto = datosArchivoConfig[0].Split(':');
                //connection = new SqlConnection("Data Source=DJSERATO\\SQLEXPRESS;Initial Catalog=BDComiSuper2;Integrated Security=True");
                //connection = new SqlConnection("Data Source=DESKTOP-FUFA7EG\\ANDRES;Initial Catalog=BDComiSuper2;Integrated Security=True");

                System.Configuration.ConnectionStringSettingsCollection connec = ConfigurationManager.ConnectionStrings;
                String con = connec[1].ToString();
                connection = new SqlConnection(con);

                //connection = new SqlConnection("data source = DESKTOP-GH9GHBJ, 1433; initial catalog = BDComiSuper2;Integrated Security=True");
                connection.Open();
               
            }
            catch (SqlException ex)
            {   
                MessageBox.Show("Error al conectarse a la Base De Datos " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

        }
        public void Cerrar()
        {
            //string[] datosArchivoConfig = Funcion.leerArchivo(@"\\Aircontrol\c\Program Files (x86)\AIRCONTROL\Conexion.shc");
            //string[] servidorPuerto = datosArchivoConfig[0].Split(':');
            //connection = new SqlConnection("Data Source=DESKTOP-FUFA7EG\\ANDRES;Initial Catalog=BDComiSuper2;Integrated Security=True");
            //connection = new SqlConnection("Data Source=DJSERATO\\SQLEXPRESS;Initial Catalog=BDComiSuper2;Integrated Security=True");


            System.Configuration.ConnectionStringSettingsCollection connec = ConfigurationManager.ConnectionStrings;
            String con = connec[1].ToString();
            connection = new SqlConnection(con);
            //connection = new SqlConnection("data source = DESKTOP-GH9GHBJ, 1433; initial catalog = BDComiSuper2;Integrated Security=True");
            connection.Close();
        }



        public void conectarBDFact()
        {
            try
            {

                //string[] datosArchivoConfig = Funcion.leerArchivo(@"\\Aircontrol\c\Program Files (x86)\AIRCONTROL\Conexion.shc");
                //string[] servidorPuerto = datosArchivoConfig[0].Split(':');
                //connection = new SqlConnection("Data Source=DJSERATO\\SQLEXPRESS;Initial Catalog=BDFacturacionElectronica;Integrated Security=True");
                System.Configuration.ConnectionStringSettingsCollection connec = ConfigurationManager.ConnectionStrings;
                String con = connec[2].ToString();
                connection = new SqlConnection(con);

                connection.Open();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectarse a la Base De Datos " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

        }
        public void CerrarBDFact()
        {
            //string[] datosArchivoConfig = Funcion.leerArchivo(@"\\Aircontrol\c\Program Files (x86)\AIRCONTROL\Conexion.shc");
            //string[] servidorPuerto = datosArchivoConfig[0].Split(':');
            //connection = new SqlConnection("Data Source=DJSERATO\\SQLEXPRESS;Initial Catalog=BDFacturacionElectronica;Integrated Security=True");
            System.Configuration.ConnectionStringSettingsCollection connec = ConfigurationManager.ConnectionStrings;
            String con = connec[2].ToString();
            connection = new SqlConnection(con);
            connection.Close();
        }
    }
}
