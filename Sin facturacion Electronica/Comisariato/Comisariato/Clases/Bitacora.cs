using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace Comisariato.Clases
{
    public class Bitacora
    {
        Consultas ObjConsul = new Consultas();


        string horaFin;
        string descripcion;

        public Bitacora(string horaFin, string descripcion)
        {
            this.horaFin = horaFin;
            this.descripcion = descripcion;
        }

        public Bitacora()
        {
        }

        public string HoraFin
        {
            get
            {
                return horaFin;
            }

            set
            {
                horaFin = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string LocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }

        public void insertarBitacora()
        {
            String IP = LocalIPAddress();
            string usuario = Program.Usuario;
            string fechaInicio = Program.FecaInicio;
            string horainicio = Program.horainicio;
            //String FechaI = fechaInicio.Date.ToString();
            int IDUsuario = ObjConsul.ObtenerID("IDUSUARIO","TbUsuario","");

            string sentencia = "INSERT INTO [dbo].[TbBitacora] ([IP],[FECHA],[HORAINICIO],[HORAFIN],[DESCRIPCION],[IDUSUARIO])VALUES('" + IP + "','" + fechaInicio + "','" + horainicio + "','"+horaFin+"','" + descripcion + "'," + IDUsuario + ");"; 
            ObjConsul.Insertar(sentencia);
        }
    }
}
