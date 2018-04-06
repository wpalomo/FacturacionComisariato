using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class ClaveAcceso
    {
        public String invertirCadena(String cadena)
        {
            String cadenaInvertida = "";
            for (int x = cadena.Length - 1; x >= 0; x--)
            {
                cadenaInvertida = cadenaInvertida + cadena.ToCharArray()[x].ToString();
            }
            return cadenaInvertida;
        }

        public int obtenerSumaPorDigitos(String cadena)
        {
            int pivote = 2;
            int longitudCadena = cadena.Length;
            int cantidadTotal = 0;
            int b = 1;
            for (int i = 0; i < longitudCadena; i++)
            {
                if (pivote == 8)
                {
                    pivote = 2;
                }
                int temporal = int.Parse("" + cadena.Substring(i, 1));
                b++;
                temporal *= pivote;
                pivote++;
                cantidadTotal += temporal;
            }
            cantidadTotal = 11 - cantidadTotal % 11;
            switch (cantidadTotal)
            {
                case 11:
                    cantidadTotal = 0;
                    break;
                case 10:
                    cantidadTotal = 1;
                    break;
            }
            return cantidadTotal;
        }
    }
}
