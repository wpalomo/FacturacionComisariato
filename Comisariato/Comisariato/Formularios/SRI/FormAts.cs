using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace Comisariato.Formularios.SRI
{
    public partial class FormAts : Form
    {
        private string PathServer = ConfigurationManager.AppSettings["XmlServidor"];
        List<string> claveAcceso = new List<string>();
        Consultas ObjConsul = new Consultas();

        public FormAts()
        {
            InitializeComponent();
        }
        private void btnCrearAts_Click(object sender, EventArgs e)
        {
            claveAcceso = ObjConsul.ObtenerListaString("Select NombreXML from TbDocumentosGeneradosRect where EstadoAutorizacion = '1' and EstadodeBaja = '0' and FechaEmision  BETWEEN '" + Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToShortDateString())+"' AND '"+ Funcion.reemplazarcaracterFecha(dtpHasta.Value.ToShortDateString()) + "';");
            if (claveAcceso.Count>0)
                CrearAts(dtpHasta.Value.ToShortDateString());
            else
                MessageBox.Show("No se encontraron coincidencias.");
        }
        private bool CrearAts(string fecha)
        {
            try
            {
                string[] vectorFecha = fecha.Split('/');
                XmlAts objcXmlAts = new XmlAts();
                String rutaATS = PathServer + @"\ATS\"+ vectorFecha[2];
                if (!Directory.Exists(rutaATS))
                    Directory.CreateDirectory(rutaATS);
                objcXmlAts._crearXml(rutaATS + @"\Ats"+vectorFecha[1]+"-"+vectorFecha[2]+".xml","iva");
                //Llenar Emcabezado Ats
                EmcabezadoAts objEmcabezadoXml = new EmcabezadoAts();
                objEmcabezadoXml.TipoidInformante = "R";
                objEmcabezadoXml.Idinformante = Program.rucempresa;
                objEmcabezadoXml.Razonsocial = Program.nombreempresa;
                objEmcabezadoXml.Anio = vectorFecha[2];
                objEmcabezadoXml.Mes = vectorFecha[1];
                objEmcabezadoXml.Numestabruc = "001";
                objEmcabezadoXml.Totalventas = "0.00";
                objEmcabezadoXml.Codigooperativo = "IVA";
                //Fin datos Emcabezado ATS
                //crear Emacebzado Xml
                objcXmlAts.EmcabezadoAts(objEmcabezadoXml);
                // Nodo detalle Compras
                objcXmlAts.NodoCompras(claveAcceso,PathServer, Funcion.reemplazarcaracterFecha(dtpDesde.Value.ToShortDateString()), Funcion.reemplazarcaracterFecha(dtpHasta.Value.ToShortDateString()));
                MessageBox.Show("El ATS se ah generado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}