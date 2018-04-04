using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFacturacionElectronica.Class
{
    public class Producto
    {

        Consultas ObjConsulta;

        string nombreproducto;
        bool activo;
        string codigobarra;
        string tipoproducto;
        string unidamedida;
        string peso;
        int stockmaximo;
        int stockminimo;
        float caja;
        int unidad;
        int display;
        //int unidadProducto;

        float preciopublico_iva;
        float preciopublico_sin_iva;
        float precioalmayor_iva;
        float precioalmayor_sin_iva;
        float precioporcaja_iva;
        float precioporcaja_sin_iva;

        float precioCompra;

        byte[] imagenproducto;
        bool ivaestado;
        string observaciones;
        int idcategoria;

        float cantidad, cantidad1;

        int iva;

        float ice;
        float irbp;

        string stockActual;

        bool libreImpuesto;

        public Producto(string nombreproducto, bool activo, string codigobarra, string tipoproducto, string unidamedida, string peso, int stockmaximo, int stockminimo, int caja, int unidad, float preciopublico_iva, float preciopublico_sin_iva, float precioalmayor_iva, float precioalmayor_sin_iva, float precioporcaja_iva, float precioporcaja_sin_iva, byte[] imagenproducto, bool ivaestado, string observaciones, int idcategoria, float cantidad, int display, float ice, float irbp/*, int unidadProducto*/, bool libreImpuesto)
        {
            this.nombreproducto = nombreproducto;
            this.activo = activo;
            this.codigobarra = codigobarra;
            this.tipoproducto = tipoproducto;
            this.unidamedida = unidamedida;
            this.peso = peso;
            this.stockmaximo = stockmaximo;
            this.stockminimo = stockminimo;
            this.caja = caja;
            this.unidad = unidad;
            this.preciopublico_iva = preciopublico_iva;
            this.preciopublico_sin_iva = preciopublico_sin_iva;
            this.precioalmayor_iva = precioalmayor_iva;
            this.precioalmayor_sin_iva = precioalmayor_sin_iva;
            this.precioporcaja_iva = precioporcaja_iva;
            this.precioporcaja_sin_iva = precioporcaja_sin_iva;
            this.imagenproducto = imagenproducto;
            this.ivaestado = ivaestado;
            this.observaciones = observaciones;
            this.idcategoria = idcategoria;
            this.Cantidad = cantidad;
            this.display = display;
            this.Ice = ice;
            this.Irbp = irbp;
            this.LibreImpuesto = libreImpuesto;
            //this.unidadProducto = unidadProducto;
        }
        public Producto(int cantidad, string codigo)
        {
            this.Cantidad = cantidad;
            this.Codigobarra = codigo;
        }

        public Producto()
        { }

        public string Nombreproducto
        {
            get
            {
                return nombreproducto;
            }

            set
            {
                nombreproducto = value;
            }
        }

        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }

        public string Codigobarra
        {
            get
            {
                return codigobarra;
            }

            set
            {
                codigobarra = value;
            }
        }

        public string Tipoproducto
        {
            get
            {
                return tipoproducto;
            }

            set
            {
                tipoproducto = value;
            }
        }

        public string Unidamedida
        {
            get
            {
                return unidamedida;
            }

            set
            {
                unidamedida = value;
            }
        }

        public string Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public int Stockmaximo
        {
            get
            {
                return stockmaximo;
            }

            set
            {
                stockmaximo = value;
            }
        }

        public int Stockminimo
        {
            get
            {
                return stockminimo;
            }

            set
            {
                stockminimo = value;
            }
        }

        public float Caja
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

        public int Unidad
        {
            get
            {
                return unidad;
            }

            set
            {
                unidad = value;
            }
        }

        public float Preciopublico_iva
        {
            get
            {
                return preciopublico_iva;
            }

            set
            {
                preciopublico_iva = value;
            }
        }

        public float Preciopublico_sin_iva
        {
            get
            {
                return preciopublico_sin_iva;
            }

            set
            {
                preciopublico_sin_iva = value;
            }
        }

        public float Precioalmayor_iva
        {
            get
            {
                return precioalmayor_iva;
            }

            set
            {
                precioalmayor_iva = value;
            }
        }

        public float Precioalmayor_sin_iva
        {
            get
            {
                return precioalmayor_sin_iva;
            }

            set
            {
                precioalmayor_sin_iva = value;
            }
        }

        public float Precioporcaja_iva
        {
            get
            {
                return precioporcaja_iva;
            }

            set
            {
                precioporcaja_iva = value;
            }
        }

        public float Precioporcaja_sin_iva
        {
            get
            {
                return precioporcaja_sin_iva;
            }

            set
            {
                precioporcaja_sin_iva = value;
            }
        }

        public byte[] Imagenproducto
        {
            get
            {
                return imagenproducto;
            }

            set
            {
                imagenproducto = value;
            }
        }

        public bool Ivaestado
        {
            get
            {
                return ivaestado;
            }

            set
            {
                ivaestado = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return observaciones;
            }

            set
            {
                observaciones = value;
            }
        }

        public int Idcategoria
        {
            get
            {
                return idcategoria;
            }

            set
            {
                idcategoria = value;
            }
        }

        public float Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public float Cantidad1
        {
            get
            {
                return cantidad1;
            }

            set
            {
                cantidad1 = value;
            }
        }

        public int Iva
        {
            get
            {
                return iva;
            }

            set
            {
                iva = value;
            }
        }

        public float PrecioCompra
        {
            get
            {
                return precioCompra;
            }

            set
            {
                precioCompra = value;
            }
        }

        public int Display
        {
            get
            {
                return display;
            }

            set
            {
                display = value;
            }
        }

        public float Ice
        {
            get
            {
                return ice;
            }

            set
            {
                ice = value;
            }
        }

        public float Irbp
        {
            get
            {
                return irbp;
            }

            set
            {
                irbp = value;
            }
        }

        public bool LibreImpuesto
        {
            get
            {
                return libreImpuesto;
            }

            set
            {
                libreImpuesto = value;
            }
        }

        public string StockActual
        {
            get
            {
                return stockActual;
            }

            set
            {
                stockActual = value;
            }
        }

        //public int UnidadProducto
        //{
        //    get
        //    {
        //        return unidadProducto;
        //    }

        //    set
        //    {
        //        unidadProducto = value;
        //    }
        //}




    }
}
