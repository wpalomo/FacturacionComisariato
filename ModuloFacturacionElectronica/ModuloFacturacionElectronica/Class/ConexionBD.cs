using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloFacturacionElectronica.Class
{
    class ConexionBD
    {
        public static SqlConnection connection = null;

        public void conectar()
        {
            try
            {
                // BDFacturacionElectronica
                //"Data Source=DJSERATO\\SQLEXPRESS;Initial Catalog=BDFacturacionElectronica;Integrated Security=True"
                //"data source = SAIRCONTROL, 1433; initial catalog = BDFacturacionElectronica; user id = COMI; password = Server@aircontrol@1"
                connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDFacturacionElectronica; user id = COMI; password = server@1");
               
                connection.Open();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectarse a la Base De Datos " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

        }

        public void Cerrar()
        {
            connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDFacturacionElectronica; user id = COMI; password = server@1");
            
            connection.Close();
        }



        public void conectarComi()
        {
            try
            {
                //BDComiSuper2
                // BDFacturacionElectronica
                //"Data Source=DJSERATO\\SQLEXPRESS;Initial Catalog=BDComiSuper2;Integrated Security=True"
                //"data source = SAIRCONTROL, 1433; initial catalog = BDComiSuper2; user id = COMI; password = Server@aircontrol@1"
                //BDComiSuper2
                connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComiSuper2; user id = COMI; password = server@1");

                connection.Open();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectarse a la Base De Datos " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

        }

        public void CerrarComi()
        {
            connection = new SqlConnection("data source = AIRCONTROL, 1433; initial catalog = BDComiSuper2; user id = COMI; password = server@1");

            connection.Close();
        }


    }
}
