using Comisariato.Clases;
using Comisariato.Ride.Retencion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.SRI
{
    public partial class FrmReimprimirComprobante : Form
    {
        public FrmReimprimirComprobante()
        {
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
            else
            {
                MessageBox.Show("Ingrese todos los datos", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void TxtNumeroComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }
    }
}
