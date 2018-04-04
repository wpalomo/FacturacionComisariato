using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    class ImprimirPromocion
    {
        //DateTimePicker1.Value<DateTimePicker2.Value T
       
        public static void imprimirPromocion(float monto , string caja)
        {
            try
            {
                List<string> lista = new List<string>();
                Consultas objConsulta = new Consultas() ;
                if (objConsulta.ConsultarPromocion(monto, ref lista))
                {
                    Imprimir(lista, caja);
                } 
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private static void Imprimir(List<string> lista,string caja)
        {
            try
            {
                CrearTicket ticket = new CrearTicket();
                //int numcaja = Program.em.Caja;

                //int sucursal = Program.em.Sucursal;
                //int numfac = Program.em.Numfact;

                
                ticket.TextoCentro("" + Program.nombreempresa);
                ticket.TextoCentro("              ");
                ticket.TextoCentro(""+lista[0]);
                ticket.TextoCentro("              ");
                ticket.TextoIzquierda("USUARIO: " + Program.Usuario);
                ticket.TextoIzquierda("# CAJA: " + caja);
              
                ticket.TextoIzquierda("                 ");
                ticket.TextoIzquierda("");
                string[] h = DateTime.Now.TimeOfDay.ToString().Split('.');

                //ticket.TextoIzquierda("Factura #: " + sucursal.ToString("D3") + "-" + numcaja.ToString("D3") + "-" + numfac.ToString("D9"));
                ticket.TextoIzquierda("Fecha: " + Program.FecaInicio + "          " + h[0]);
                ticket.TextoCentro("" + lista[1]);
                ticket.TextoCentro("" + lista[2]);
                ticket.TextoCentro("" + lista[3]);
                ticket.TextoCentro("" + lista[4]);
                ticket.TextoCentro("" + lista[5]);
                ticket.TextoIzquierda("Fecha de Vencimiento: "+ lista[6]);

                ticket.CortaTicket();
                
                var valor = ConfigurationManager.AppSettings["Local"];
                ticket.ImprimirTicket(valor);
                
            }
            catch (Exception ex)
            {

                //throw;
            }

        }

    }
}
