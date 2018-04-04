using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class Promocion
    {
        string fechainicio, fechafin, fechaVencimientoCupon, cabeceraTicket, linea1, linea2, linea3, linea4, linea5, tipoPromocion;
        bool estado;
        int numeroTickets;
        Double montoInicial, MontoFinal;

        public string Fechainicio
        {
            get
            {
                return fechainicio;
            }

            set
            {
                fechainicio = value;
            }
        }

        public string Fechafin
        {
            get
            {
                return fechafin;
            }

            set
            {
                fechafin = value;
            }
        }

        public string FechaVencimientoCupon
        {
            get
            {
                return fechaVencimientoCupon;
            }

            set
            {
                fechaVencimientoCupon = value;
            }
        }

        public string CabeceraTicket
        {
            get
            {
                return cabeceraTicket;
            }

            set
            {
                cabeceraTicket = value;
            }
        }

        public string Linea1
        {
            get
            {
                return linea1;
            }

            set
            {
                linea1 = value;
            }
        }

        public string Linea2
        {
            get
            {
                return linea2;
            }

            set
            {
                linea2 = value;
            }
        }

        public string Linea3
        {
            get
            {
                return linea3;
            }

            set
            {
                linea3 = value;
            }
        }

        public string Linea4
        {
            get
            {
                return linea4;
            }

            set
            {
                linea4 = value;
            }
        }

        public string Linea5
        {
            get
            {
                return linea5;
            }

            set
            {
                linea5 = value;
            }
        }

        public string TipoPromocion
        {
            get
            {
                return tipoPromocion;
            }

            set
            {
                tipoPromocion = value;
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

        public int NumeroTickets
        {
            get
            {
                return numeroTickets;
            }

            set
            {
                numeroTickets = value;
            }
        }

        public double MontoInicial
        {
            get
            {
                return montoInicial;
            }

            set
            {
                montoInicial = value;
            }
        }

        public double MontoFinal1
        {
            get
            {
                return MontoFinal;
            }

            set
            {
                MontoFinal = value;
            }
        }

        public Promocion(string fechainicio, string fechafin, string fechaVencimientoCupon, string cabeceraTicket, string linea1, string linea2, string linea3, string linea4, string linea5, string tipoPromocion, bool estado, int numeroTickets, double montoInicial, double montoFinal)
        {
            this.Fechainicio = fechainicio;
            this.Fechafin = fechafin;
            this.FechaVencimientoCupon = fechaVencimientoCupon;
            this.CabeceraTicket = cabeceraTicket;
            this.Linea1 = linea1;
            this.Linea2 = linea2;
            this.Linea3 = linea3;
            this.Linea4 = linea4;
            this.Linea5 = linea5;
            this.TipoPromocion = tipoPromocion;
            this.Estado = estado;
            this.NumeroTickets = numeroTickets;
            this.MontoInicial = montoInicial;
            MontoFinal1 = montoFinal;
        }

        public Promocion()
        {
            
        }

        Consultas ObjConsulta;
        public string InsertarPromocion()
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("CABECERATICKET", cabeceraTicket, "TbPromociones"))
            {
                string consulta = "INSERT INTO [dbo].[TbPromociones]([FECHAINICIO],[FECHAFIN],[FECHAVENCIMIENTOCUPON],[NUMEROTICKETS],"+
                    "[MONTOINCIAL],[MONTOFINAL],[CABECERATICKET],[LINEA1] ,[LINEA2] ,[LINEA3],[LINEA4],[LINEA5],[TIPOPROMOCION],[ESTADO]) "+
                    "VALUES ('"+fechainicio+ "','"+fechafin+ "','"+fechaVencimientoCupon+ "',"+numeroTickets+","+Funcion.reemplazarcaracter(montoInicial.ToString())+","+ Funcion.reemplazarcaracter(MontoFinal.ToString()) + ",'"+cabeceraTicket+ "','"+linea1+"',"+
                    "'"+linea2+ "','"+linea3+ "','"+linea4+ "','"+linea5+ "','"+tipoPromocion+ "','"+estado+"')";
                if (ObjConsulta.EjecutarSQL(consulta))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }

        public string ModificarPromocion(string condicion)
        {
            ObjConsulta = new Consultas();
            String consulta = "UPDATE [dbo].[TbPromociones] SET[FECHAINICIO] = '"+fechainicio+ "',[FECHAFIN] = '"+fechafin+ "',[FECHAVENCIMIENTOCUPON] = '"+fechaVencimientoCupon+"'"+
                ",[NUMEROTICKETS] = "+numeroTickets+ ",[MONTOINCIAL] = " + Funcion.reemplazarcaracter(montoInicial.ToString()) + ",[MONTOFINAL] = " + Funcion.reemplazarcaracter(MontoFinal.ToString()) + ""+
                ",[CABECERATICKET] = '"+cabeceraTicket+ "' ,[LINEA1] = '"+linea1+ "' ,[LINEA2] = '"+linea2+ "' ,[LINEA3] = '"+linea3+ "' ,[LINEA4] = '"+linea4+ "' ,[LINEA5] = '"+linea5+ "',[TIPOPROMOCION] = '"+tipoPromocion+ "' ,[ESTADO] = '"+estado+"' WHERE[IDPROMOCION] = "+ condicion + "";
            bool ModificarCliente = ObjConsulta.EjecutarSQL(consulta);
            if (ModificarCliente)
            {
                return "Correcto";
            }
            else { return "Error al Modificar"; }
        }

        public string EstadoPromocion(string CABECERATICKET, int estado)
        {
            ObjConsulta = new Consultas();
            if (estado == 1)
                if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbPromociones] SET [ESTADO] = 1 WHERE [CABECERATICKET] = '" + CABECERATICKET + "'"))
                {
                    return "Habilitado";
                }
                else { return "Error"; }
            else if (estado == 2)
            {
                if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbPromociones] SET [ESTADO] = 0 WHERE [CABECERATICKET] = '" + CABECERATICKET + "'"))
                {
                    return "Correcto";
                }
                else { return "Error"; }
            }
            else { return "Sin Accion"; }
        }

    }
}
