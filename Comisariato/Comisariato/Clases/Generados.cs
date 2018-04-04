using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    class Generados
    {
        private string nombreArchivo;
        private string ruta;
        private string fechaEmision;
        private string estadoAutorizacion;
        private string recepcionSri;
        private string autorizacionSri;
        private string rutaRide;

        public string NombreArchivo
        {
            get
            {
                return nombreArchivo;
            }

            set
            {
                nombreArchivo = value;
            }
        }

        public string Ruta
        {
            get
            {
                return ruta;
            }

            set
            {
                ruta = value;
            }
        }

        public string FechaEmision
        {
            get
            {
                return fechaEmision;
            }

            set
            {
                fechaEmision = value;
            }
        }

        public string EstadoAutorizacion
        {
            get
            {
                return estadoAutorizacion;
            }

            set
            {
                estadoAutorizacion = value;
            }
        }

        public string RecepcionSri
        {
            get
            {
                return recepcionSri;
            }

            set
            {
                recepcionSri = value;
            }
        }

        public string AutorizacionSri
        {
            get
            {
                return autorizacionSri;
            }

            set
            {
                autorizacionSri = value;
            }
        }

        public string RutaRide
        {
            get
            {
                return rutaRide;
            }

            set
            {
                rutaRide = value;
            }
        }

        public Generados()
        {

        }

        public Generados(string nombrearchivo,string ruta,string fechaemision,string estadoaut,string recepcion,string autorizacionsri,string rutaride){

            this.NombreArchivo = nombrearchivo;
            this.Ruta = ruta;
            this.FechaEmision = fechaemision;
            this.EstadoAutorizacion = estadoaut;
            this.RecepcionSri = recepcion;
            this.AutorizacionSri = autorizacionsri;
            this.RutaRide = rutaride;

        }

    }
}
