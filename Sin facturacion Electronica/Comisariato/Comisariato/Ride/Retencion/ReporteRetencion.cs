using Comisariato.Clases;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Ride.Retencion
{
    public partial class ReporteRetencion : Form
    {
        string claveacceso = "";
        string idordengiro = "";
        string FechaAutorizacion = "";
        string Ambiente = "";
        string Emision = "";
        string año = "";

        SqlDataAdapter da;
        //SqlCommand cmd;
        RetencionEncabezado info;
        RetencionDetalle InfoRetencionDetalle;

        //private string PathCodigoBarra = @"file:\" + Application.StartupPath + @"\p.png";
        string PathCodigoBarra = ConfigurationManager.AppSettings["XmlServidor"];

        public ReporteRetencion(string claveacceso, string FechaAutorizacion, string idordengiro, string Ambiente,string Emision, string año)
        {
            InitializeComponent();
            this.claveacceso = claveacceso;
            this.FechaAutorizacion = FechaAutorizacion;
            this.idordengiro = idordengiro;
            this.Ambiente = Ambiente;
            this.Emision = Emision;
            this.año = año;
            da = new SqlDataAdapter();
            info = new RetencionEncabezado();
            InfoRetencionDetalle = new RetencionDetalle();
        }

        private void ReporteRetencion_Load(object sender, EventArgs e)
        {
            try
            {

                //Encabezado
                Consultas objconsul = new Consultas();
                da = objconsul.retornarSqlDataAdapter(idordengiro, "SELECT *   FROM [dbo].[VistaEncabezadoRetencionRide] where IDORDENGIRO = @IDORDENGIRO", "@IDORDENGIRO");
                da.Fill(info, "EncabezadoOrdenGiro");
                //Fin Encabezado

                ////DetalleOrdenGiro
                da.Dispose();
                da = objconsul.retornarSqlDataAdapter(idordengiro, "SELECT *   FROM [dbo].[VistaDetalleRetencioRide] where IDENCABEZADOORDENGIRO = @IDORDENGIRO", "@IDORDENGIRO");
                da.Fill(InfoRetencionDetalle, "DetalleOrdenGiro");
                //objconec.Cerrar();

                //FinDetalleOrdenGiro



                //Inicio Imgen CodigoBarra
                BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                Codigo.IncludeLabel = true;

                Panel obp = new Panel();
                obp.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, claveacceso, Color.Black, Color.White, 1000, 300);
                Image imgFinal = (Image)obp.BackgroundImage.Clone();


                imgFinal.Save("p.png", ImageFormat.Png);
                imgFinal.Dispose();


                String ruta1 = PathCodigoBarra;
                //Fin Imgen CodigoBarra


                //Array que contendra los parametros
                ReportParameter[] parameters = new ReportParameter[5];
                //Establecemos el valor de los parametros
                parameters[0] = new ReportParameter("ClaveAcceso", claveacceso);
                parameters[1] = new ReportParameter("FechaAutorizacion", FechaAutorizacion);
                parameters[2] = new ReportParameter("Ambiente", Ambiente);
                parameters[3] = new ReportParameter("Emision", Emision);
                parameters[4] = new ReportParameter("CodigoBarra", ruta1,true);
                this.reportViewerRetencion.LocalReport.EnableExternalImages = true;

                //Pasamos el array de los parametros al ReportViewer
                this.reportViewerRetencion.LocalReport.SetParameters(parameters);



                this.reportViewerRetencion.ProcessingMode = ProcessingMode.Local;
                //this.reportViewer1.LocalReport.ReportEmbeddedResource = @"ReporteRetencion.ReporteRideRetencion.rdlc";


                


                ReportDataSource rds = new ReportDataSource("RetencionEncabezado", info.Tables[0]);
                ReportDataSource rdsDetalle = new ReportDataSource("RetencionDetalle", InfoRetencionDetalle.Tables[0]);
                this.reportViewerRetencion.LocalReport.DataSources.Clear();

                //Envio el encabezado al reporte
                this.reportViewerRetencion.LocalReport.DataSources.Add(rds);
                this.reportViewerRetencion.LocalReport.DataSources.Add(rdsDetalle);

                //Poner Un nombre para guardar el Reporte
                this.reportViewerRetencion.LocalReport.DisplayName = claveacceso;
                
                this.reportViewerRetencion.RefreshReport();

                //INFORME EN VISTA DE IMPRESIÓN
                reportViewerRetencion.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewerRetencion.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewerRetencion.ZoomPercent = 100;
                //FIN INFORME EN VISTA DE IMPRESIÓN


                //Guardar pdf en servidor
                var PathServer = ConfigurationManager.AppSettings["RideServidor"];

                if (!Directory.Exists(PathServer + @"\Retencion\" + año  + @"\"))
                {
                    Directory.CreateDirectory(PathServer + @"\Retencion\"+ año + @"\");
                }

                byte[] pdfContent = reportViewerRetencion.LocalReport.Render("PDF");

                string pdfPath = PathServer+ @"\Retencion\" + año + @"\" + claveacceso + ".pdf";
                System.IO.FileStream pdfFile = new System.IO.FileStream(pdfPath, System.IO.FileMode.Create);
                pdfFile.Write(pdfContent, 0, pdfContent.Length);
                pdfFile.Close();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
