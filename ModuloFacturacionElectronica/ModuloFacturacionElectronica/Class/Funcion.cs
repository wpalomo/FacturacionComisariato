using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFacturacionElectronica.Class
{
    class Funcion
    {
        public static String reemplazarcaracterFecha(String cadena)
        {
            string[] fecha = cadena.Split('/');

            string FinalFecha = fecha[2] + "-" + fecha[1] + "-" + fecha[0];

            return FinalFecha;
        }

        public static String reemplazarcaracterFechaViceversa(String cadena)
        {
            string FinalFecha = "";
            if (cadena.Contains('-'))
            {
                string[] fecha = cadena.Split('-');

                FinalFecha = fecha[2] + "/" + fecha[1] + "/" + fecha[0];
                return FinalFecha;
            }
            else
            {
                return cadena;
            }

           
        }

        public static String reemplazarcaracterViceversa(String cadena)
        {
            if (cadena.Contains("."))
            {
                return cadena.Replace(".", ",");
            }
            else
            {
                return cadena;
            }

        }
        public static String reemplazarcaracter(String cadena)
        {
            if (cadena.Contains(","))
            {
                return cadena.Replace(",", ".");
            }
            else
            {
                return cadena;
            }
        }

        public static String verificarMensaje(String cadena)
        {
            if (cadena.Contains("'"))
            {
                return cadena.Replace(",", "");
            }
            else
            {
                return cadena;
            }
        }

    }
}
