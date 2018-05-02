using ModuloFacturacionElectronica.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using BarcodeLib;
namespace ModuloFacturacionElectronica
{
    public partial class Form1 : Form
    {
        Consultas Objconsul = new Consultas();
        String NombreXML = "";
        String FechaEmision = "";
        string nombreEmpresa = "";
        string EmailEmpresa = "";
        string passEmail = "";
        private Thread h2 = null;

        string RutaImagenCargando = Application.StartupPath + @"\Imagenes\cargando.gif";
        string RutaImagenBase = Application.StartupPath + @"\Imagenes\base.jpg";
        //@"C:\ArchivosXml";
        //C:\Users\Public\Documents\ArchivosXml
        string RutaPathServer = @"C:\ArchivosXml";
        string ContraseñaCertificado = "Sonna1967";
        string LinkSRIrecepcion= "https://cel.sri.gob.ec/comprobantes-electronicos-ws/RecepcionComprobantesOffline?wsdl";
        string LinkSRIautorizacion= "https://cel.sri.gob.ec/comprobantes-electronicos-ws/AutorizacionComprobantesOffline?wsdl";

        DataTable DtDocuemtosXML;
        delegate void CambiarProgresoDelegado(string nombreXml, string fecha, string contadordevuelta, string contadorRecivida,string contadorautorizado,string contadornoautorizado,string contadorenviados,string contador,string contadorne,string contadorAr,bool termina);

        private bool terminado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
            try
            {
 
                    //Select * from [TbEncabezadoFactura] DocFact where DocFact.[FECHA] = '" + FechaEmision + "'
                    //Select * from TbDocumentosGeneradosFact DocFact where DocFact.FechaEmision = '" + FechaEmision + "' and   EstadoAutorizacion = '0'"
                    FechaEmision = Funcion.reemplazarcaracterFecha(DtpFecha.Value.Date.ToShortDateString());
                    DtDocuemtosXML = Objconsul.BoolDataTableFactElect("Select * from TbDocumentosGeneradosFact DocFact where DocFact.FechaEmision = '" + FechaEmision + "' and   EstadoAutorizacion = '0'");
                    lblTotalArchivos.Text = "Cantidad Facturas: " + DtDocuemtosXML.Rows.Count;
                if (DtDocuemtosXML.Rows.Count>0)
                {
                    btnEnviar.Enabled = false;
                    //Creamos el delegado 
                    ThreadStart h1 = new ThreadStart(Procesar);
                    //Creamos la instancia del hilo 
                    h2 = new Thread(h1);
                    //Iniciamos el hilo 
                    h2.Start();
                    
                }
            }
            catch (Exception ex)
            {

            }
        }


       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            DialogResult Resul = MessageBox.Show("Esta Seguro que quieres salir", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resul == DialogResult.Yes)
            {
                this.Dispose(true);
            }
            

        }
        
        private void Procesar()
        {
            try
            {
                int contadorNE=0, contadorAutorizado = 0, contadorEnviados = 0, contadorNoautorizados = 0, contadorDevuelta = 0, contadorRecibida = 0, contador = 0,contadorAR=0;
                if (DtDocuemtosXML.Rows.Count > 0)
                {
                    pictureBox1.Load(RutaImagenCargando);
                   
                    foreach (DataRow myRow in DtDocuemtosXML.Rows)
                    {
                        
                       
                        NombreXML = myRow["NombreXML"].ToString();
                        FechaEmision = myRow["FechaEmision"].ToString();
                        contador++;
                        //Inicio menuInferior
                        if (contador == DtDocuemtosXML.Rows.Count)
                        {
                            terminado = true;
                        }


                        TollMenuLablelDocumento.Text = "Documento : " + NombreXML + ".xml";
                        TollMenuLablelFecha.Text = "Fecha : " + Funcion.reemplazarcaracterFecha(Convert.ToDateTime(FechaEmision).Date.ToShortDateString());
                        //Fin menuInferior
                        
                        string RutaXML1 = RutaPathServer;
                        string pathXml = RutaXML1 + @"\sonna_judith_vega_solis.p12";
                        string contadoraenviar = contador + " de " + DtDocuemtosXML.Rows.Count + " Archivos.";
                        //string cne="";
                        if (System.IO.File.Exists(RutaXML1 + @"\Generados" + @"\" + NombreXML + ".xml"))
                        {

                            EnvioArchivos.EnviarArchivos(pathXml,ContraseñaCertificado, RutaXML1, NombreXML, LinkSRIrecepcion, LinkSRIautorizacion, nombreEmpresa, EmailEmpresa, passEmail, ref contadorRecibida, ref contadorAutorizado, ref contadorNoautorizados, ref contadorDevuelta);
                            contadorEnviados++;
                            
                            Thread.Sleep(500);
                            
                            CambiarProgreso(NombreXML, FechaEmision, contadorDevuelta.ToString(), contadorRecibida.ToString(), contadorAutorizado.ToString(), contadorNoautorizados.ToString(), contadorEnviados.ToString(), contadoraenviar,contadorNE.ToString(),contadorAR.ToString(),terminado);

                        }
                        else
                        {
                            contadorNE++;
                            Objconsul.EjecutarSQL("INSERT INTO [dbo].[TbArchivosNoEncontrados]([NombreXML],[FECHA])" +
                             "VALUES ('" + NombreXML + "','" + Funcion.reemplazarcaracterFecha(DtpFecha.Value.Date.ToShortDateString()) + "')");
                            //CambiarProgreso(NombreXML, FechaEmision, contadorDevuelta.ToString(), contadorRecibida.ToString(), contadorAutorizado.ToString(), contadorNoautorizados.ToString(), contadorEnviados.ToString(), contadoraenviar, contadorNE.ToString(),contadorAR.ToString(),terminado);

                            RestaurarXml objcRestaurar = new RestaurarXml(NombreXML, DtpFecha.Value.Date.ToShortDateString(), RutaXML1, NombreXML);
                            bool confirmar= objcRestaurar.FormarXml();
                            Thread.Sleep(500);
                            if (confirmar)
                            {
                                contadorAR++;
                                if (System.IO.File.Exists(RutaXML1 + @"\Generados" + @"\" + NombreXML + ".xml"))
                                {

                                    EnvioArchivos.EnviarArchivos(pathXml, ContraseñaCertificado, RutaXML1, NombreXML, LinkSRIrecepcion, LinkSRIautorizacion, nombreEmpresa, EmailEmpresa, passEmail, ref contadorRecibida, ref contadorAutorizado, ref contadorNoautorizados, ref contadorDevuelta);
                                    contadorEnviados++;
                                   
                                    Thread.Sleep(200);

                                }
                            }
                            CambiarProgreso(NombreXML, FechaEmision, contadorDevuelta.ToString(), contadorRecibida.ToString(), contadorAutorizado.ToString(), contadorNoautorizados.ToString(), contadorEnviados.ToString(), contadoraenviar, contadorNE.ToString(), contadorAR.ToString(),terminado);

                        }
                       

                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningun archivo.");
                }

                Thread.Sleep(500);
                
                //btnEnviar.Enabled = true;
               
            }
            catch (Exception ex)
            {
                
            }
           
        }

        private void CambiarProgreso(string nombreXml,string fecha,string contadorDevuelta,string contadorRecibida,string contadorautorizado,string contadornoautorizado,string contadorenviados,string contador,string contadorne,string contadorAR,bool termina)
        {
            if (this.InvokeRequired)
            {
                CambiarProgresoDelegado h1 = new CambiarProgresoDelegado(CambiarProgreso);
                object[] parametros = new object[] { nombreXml, fecha, contadorDevuelta, contadorRecibida, contadorautorizado,contadornoautorizado,contadorenviados, contador,contadorne,contadorAR,termina};
                this.Invoke(h1, parametros);
            }
            else
            {
                TollMenuLablelDocumento.Text = "Documento : " + nombreXml + ".xml";
                TollMenuLablelFecha.Text = "Fecha : " + fecha;
                lblDevuelta.Text = "Devueltos: " + contadorDevuelta;
                lblRecibida.Text = "Recibidos: " + contadorRecibida;
                lblAutorizados.Text = "Autorizados: " + contadorautorizado;
                lblNoAutorizados.Text = "No autorizados: " + contadornoautorizado;
                lblEnviados.Text = "Enviados: "+contadorenviados;
                lblcontadorArchivos.Text = contador;
                //lblTotalArchivos.Text = "Total de Archivos: " + archivosTotales;
                lblNE.Text = "NE: "+contadorne;
                lblArchivosRestaurados.Text = "A.R: " + contadorAR;
                if (termina)
                {
                    btnEnviar.Enabled = true;
                    pictureBox1.Load(RutaImagenBase);
                    h2.Abort();

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblcontadorArchivos.Text = "";
            lblTotalArchivos.Text = "";
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

            Objconsul = new Consultas();
            string ResultadoConsulta= Objconsul.NombreEmpresa();
            if (ResultadoConsulta!="")
            {
                string[] vector = ResultadoConsulta.Split(';');
                if (vector[0]!="S/N"&& vector[1]!="S/N"&& vector[2] != "S/N")
                {
                    nombreEmpresa = vector[0];
                    EmailEmpresa = vector[1];
                    passEmail = vector[2];
                }
            }
           
            pictureBox1.Load(RutaImagenBase);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult Resul = MessageBox.Show("Esta Seguro que quieres salir", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resul == DialogResult.Yes)
                {
                    Dispose(true);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception)
            {

                //throw;
            }
            
        }

    }
}
