using Comisariato.Clases;
using Comisariato.Ride.Retencion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Comisariato.Formularios.SRI
{
    public partial class FrmReimprimirComprobante : Form
    {
        string tipodocumento;

        public FrmReimprimirComprobante(string tipodocumento)
        {
            this.tipodocumento = tipodocumento;
            InitializeComponent();
        }
        Consultas ObjConsul = new Consultas();
        private void BtnimprimirRide_Click(object sender, EventArgs e)
        {
            if (txtNAutorizacion.Text != "" && TxtNumeroComprobante.Text != "")
            {
                string ambiente = "";
                switch (Program.Ambiente)
                {
                    case 1:
                        ambiente = "PRUEBA";
                        break;
                    case 2:
                        ambiente = "PRODUCCION";
                        break;
                    default:
                        break;
                }
                if (tipodocumento == "Retencion")
                {
                    ReporteRetencion objeformularioReporte = null;
                    List<string> LISTA = ObjConsul.ObtenerListaStringReimprimirRide("Select IDORDENGIRO,AUTORIZACIONSRICLAVEACCESO,FECHAAUTORIZACIONSRI from TbEncabezadoOrdenGiro where AUTORIZACIONSRICLAVEACCESO = '" + txtNAutorizacion.Text + "' and IDORDENGIRO = " + TxtNumeroComprobante.Text + ";");
                    if (LISTA != null && LISTA.Count == 3)
                    {
                        objeformularioReporte = new ReporteRetencion(LISTA[1], LISTA[2], LISTA[0], ambiente, "NORMAL", "");
                        objeformularioReporte.Show();
                    }
                    else
                    {
                        MessageBox.Show("Los datos son incorrectos o el Comprobante no esta autorizado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (tipodocumento == "Factura")
                {
                    string rutaXMl = ConfigurationManager.AppSettings["XmlServidor"].ToString() + @"\Autorizados\" + txtNAutorizacion.Text + ".xml";
                    XmlDocument docxml = new XmlDocument();
                    docxml.Load(rutaXMl);
                    string fechaAutorizacion = Convert.ToString(docxml.GetElementsByTagName("fechaAutorizacion")[0].InnerText);

                    string rutaXM2 = ConfigurationManager.AppSettings["XmlServidor"].ToString() + @"\Generados\" + txtNAutorizacion.Text + ".xml";
                    XmlDocument docxml2 = new XmlDocument();
                    docxml.Load(rutaXM2);
                    string fechaemisionfactura = Convert.ToString(docxml.GetElementsByTagName("fechaEmision")[0].InnerText);
                    string[] partesfecha = fechaemisionfactura.Split('/');
                    string año = partesfecha[2];

                    Comisariato.Ride.Factura.ReporteFacturaRide ObjformularioRepoteFactura = null;
                    ObjformularioRepoteFactura = new Ride.Factura.ReporteFacturaRide(txtNAutorizacion.Text, fechaAutorizacion, ambiente, año);
                    ObjformularioRepoteFactura.Show();
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNumeroComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void FrmReimprimirComprobante_Load(object sender, EventArgs e)
        {
            if (tipodocumento == "Retencion")
            {
                TxtNumeroComprobante.Visible = true;
                label1.Visible = true;
            }
            else if (tipodocumento == "Factura")
            {
                TxtNumeroComprobante.Text = "0";
                TxtNumeroComprobante.Visible = false;
                label1.Visible = false;
            }
        }
    }
}
