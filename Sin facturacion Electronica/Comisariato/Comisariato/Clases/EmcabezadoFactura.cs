using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    class EmcabezadoFactura
    {
        private int sucursal;
        private int caja;
        private string fecha;
        private string hora;
        private int numfact;
        private int idempleado;
        private int idcliente;
        private string identificacio;

        private string nombrescliente;
        private string nombresusuario;
        private string claveacceso;

        public EmcabezadoFactura()
        {

        }

        public EmcabezadoFactura(int sucursal,int caja,string fecha, string hora,int nunfact,int idempleado,int idcliente,string claveacceso)
        {
            this.sucursal = sucursal;
            this.caja = caja;
            this.fecha = fecha;
            this.hora = hora;
            this.numfact = nunfact;
            this.idempleado = idempleado;
            this.idcliente = idcliente;
            this.Claveacceso = claveacceso;

        }

        public int Sucursal
        {
            get
            {
                return sucursal;
            }

            set
            {
                sucursal= value;
            }
        }

        public int Caja
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

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string NombresCliente
        {
            get
            {
                return nombrescliente;
            }

            set
            {
                nombrescliente = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return nombresusuario;
            }

            set
            {
                nombresusuario = value;
            }
        }

        public string Identificacion
        {
            get
            {
                return identificacio;
            }

            set
            {
                identificacio = value;
            }
        }

        public string Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        public int Numfact
        {
            get
            {
                return numfact;
            }

            set
            {
                numfact = value;
            }
        }


        public int Idempleado
        {
            get
            {
                return idempleado;
            }

            set
            {
                idempleado = value;
            }
        }

        public int Idcliente
        {
            get
            {
                return idcliente;
            }

            set
            {
                idcliente = value;
            }
        }

        public string Claveacceso
        {
            get
            {
                return claveacceso;
            }

            set
            {
                claveacceso = value;
            }
        }
    }
}
