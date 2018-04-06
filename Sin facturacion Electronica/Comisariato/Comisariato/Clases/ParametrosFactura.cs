using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class ParametrosFactura
    {
        // Parametros Factura
        string MontoMinimoFactura;
        int iva;
        bool contribuyenteEspecial;
        bool obligadoContabilida;

        //Preimpresa Factura
        string ancho;
        string largo;
        string TamanoEncabezadoFact;
        string TamanoPieFact;
        int numeroItems;

        //Autorizados para Imprimir
        string pie1;
        string pie2;
        string pie3;
        string pie4;

        string numeroResolucion;


        //relacion 
        int idParametrosFactura;
        int idempresa;

        //Tipo Factura
        bool preimpresa;
        bool autorizadoParaImprimir;




        private Consultas ObjConsulta;


        public ParametrosFactura()
        { }

        public ParametrosFactura(string montoMinimoFactura, int iva, bool contribuyenteEspecial, bool obligadoContabilida, string ancho, string largo, int numeroItems, string pie1, string pie2, string pie3, string pie4, int idempresa, string TamanoEncabezadoFact, string TamanoPieFact,bool preimpresa, bool autorizadoParaImprimir,string numerodeResolucion)
        {
            MontoMinimoFactura = montoMinimoFactura;
            this.iva = iva;
            this.contribuyenteEspecial = contribuyenteEspecial;
            this.obligadoContabilida = obligadoContabilida;
            this.ancho = ancho;
            this.largo = largo;
            this.numeroItems = numeroItems;
            this.pie1 = pie1;
            this.pie2 = pie2;
            this.pie3 = pie3;
            this.pie4 = pie4;
            this.idempresa = idempresa;
            this.TamanoEncabezadoFact = TamanoEncabezadoFact;
            this.TamanoPieFact = TamanoPieFact;
            this.preimpresa = preimpresa;
            this.autorizadoParaImprimir = autorizadoParaImprimir;
            this.numeroResolucion = numerodeResolucion;
        }

        public string MontoMinimoFactura1
        {
            get
            {
                return MontoMinimoFactura;
            }

            set
            {
                MontoMinimoFactura = value;
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

        public bool ContribuyenteEspecial
        {
            get
            {
                return contribuyenteEspecial;
            }

            set
            {
                contribuyenteEspecial = value;
            }
        }

        public bool ObligadoContabilida
        {
            get
            {
                return obligadoContabilida;
            }

            set
            {
                obligadoContabilida = value;
            }
        }

        public string Ancho
        {
            get
            {
                return ancho;
            }

            set
            {
                ancho = value;
            }
        }

        public string Largo
        {
            get
            {
                return largo;
            }

            set
            {
                largo = value;
            }
        }

        public int NumeroItems
        {
            get
            {
                return numeroItems;
            }

            set
            {
                numeroItems = value;
            }
        }

        public string Pie1
        {
            get
            {
                return pie1;
            }

            set
            {
                pie1 = value;
            }
        }

        public string Pie2
        {
            get
            {
                return pie2;
            }

            set
            {
                pie2 = value;
            }
        }

        public string Pie3
        {
            get
            {
                return pie3;
            }

            set
            {
                pie3 = value;
            }
        }

        public string Pie4
        {
            get
            {
                return pie4;
            }

            set
            {
                pie4 = value;
            }
        }

        public int Idempresa
        {
            get
            {
                return idempresa;
            }

            set
            {
                idempresa = value;
            }
        }

        public string TamanoEncabezadoFact1
        {
            get
            {
                return TamanoEncabezadoFact;
            }

            set
            {
                TamanoEncabezadoFact = value;
            }
        }

        public string TamanoPieFact1
        {
            get
            {
                return TamanoPieFact;
            }

            set
            {
                TamanoPieFact = value;
            }
        }

        public bool Preimpresa
        {
            get
            {
                return preimpresa;
            }

            set
            {
                preimpresa = value;
            }
        }

        public bool AutorizadoParaImprimir
        {
            get
            {
                return autorizadoParaImprimir;
            }

            set
            {
                autorizadoParaImprimir = value;
            }
        }

        public string NumeroResolucion
        {
            get
            {
                return numeroResolucion;
            }

            set
            {
                numeroResolucion = value;
            }
        }

        public string InsertarParametrosFactura()
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("IVA", iva.ToString(), "TbParametrosFactura"))
            {
                if (ObjConsulta.EjecutarSQL("INSERT INTO [dbo].[TbParametrosFactura]  ([MONTO_MINIMO_FACTURA]  ,[IVA] ,[CONTRIBUYENTEESPECIAL]  ,[OBLIGADOLLEVARCONTABILIDAD], [IDEMPRESA],[PREIMPRESA],[AUTORIZADOIMPRIMIR],[NUMERORESOLUCION])"
                    + " VALUES(" + MontoMinimoFactura + ",'" + iva + "','" + contribuyenteEspecial + "','" + obligadoContabilida + "',"+ idempresa +",'"+preimpresa+"','"+autorizadoParaImprimir+"','"+NumeroResolucion+"')"))
                {
                    idParametrosFactura = ObjConsulta.ObtenerID("IDPARAMETROSFACTURA", "TbParametrosFactura","");
                    //if (preimpresa)
                    //{ InsertarPreimpresa(); }
                    InsertarPreimpresa();
                    //if (autorizadoParaImprimir)
                    //{ InsertarAutorizadosImprimir(); }
                    InsertarAutorizadosImprimir();
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }


        public string InsertarPreimpresa()
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("INSERT INTO [dbo].[TbPreimpresa] ([ANCHO] ,[LARGO] ,[NUMEROITEMS] ,[IDPARAMETROSFACTURA],[TAMANOENCABEZADOFACTURA],[TAMANOPIEFACTURA])"
                + " VALUES(" + ancho + "," + largo+","+numeroItems+","+idParametrosFactura+","+TamanoEncabezadoFact+","+TamanoPieFact+")"))
            {
                return "Datos Guardados";
            }
            else { return "Error al Registrar"; }
        }

        public string InsertarAutorizadosImprimir()
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("INSERT INTO [dbo].[TbAutorizadosImprimir] ([PIE1] ,[PIE2] ,[PIE3],[PIE4],[IDPARAMETROSFACTURA])"
                + " VALUES('"+pie1+"','"+pie2+ "','"+pie3+ "','"+pie4+"',"+idParametrosFactura+")"))
            {
                return "Datos Guardados";
            }
            else { return "Error al Registrar"; }
        }


        /// FUNCIONES PARA MODIFICAR LOS DATOS
        public string ModificarParametrosFactura(ParametrosFactura ObjParametrosFact)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarPROCEDUREMODIFICAR_PARAMETROSFACTURA(ObjParametrosFact))
            {
                return "Datos Actualizados";
            }
            else { return "Error al Actualizar"; }
        }
    }
}
