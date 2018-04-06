using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    class DatosTributarios
    {
        /// <summary>
        /// Gets or sets the clave acceso.
        /// </summary>
        public string claveAcceso { get; set; }

        /// <summary>
        /// Gets or sets the numero autorizacion.
        /// </summary>
        public string numeroAutorizacion { get; set; }

        /// <summary>
        /// Gets or sets the fecha autorizacion.
        /// </summary>
        public DateTime FechaAutorizacion { get; set; }

        /// <summary>
        /// Gets or sets the estado.
        /// </summary>
        public string Estado { get; set; }
    }
}
