using Comisariato.Clases;
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

namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmAvanse : Form
    {
        public string fecha, caja = "", cajero, r = "";

        private void txtDinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
            else
            {
                Funcion.SoloValores(e, txtDinero.Text);
            }
        }

        private void FrmAvanse_Load(object sender, EventArgs e)
        {
            txtDinero.Focus();
        }

        private void FrmAvanse_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultas c = new Consultas();
            try
            {
                if (txtDinero.Text != "")
                {
                    //float n = Convert.ToSingle(r);
                    bool b = c.Insertar("INSERT INTO TbAvance (IDEMPLEADO, FECHA, CAJA, CANTIDAD) VALUES ( '" + Program.IDUsuario + "','" + Program.FecaInicio + "','" + caja + "','" + txtDinero.Text + "')");
                    if (b)
                    {
                        ImprimirAvances();
                        FrmFactura.verificadorfrm = 4;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el avance.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa la cantidad a guardar.");
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
        }
        public void ImprimirAvances()
        {
            try
            {
                //Creamos una instancia d ela clase CrearTicket
                CrearTicket ticket = new CrearTicket();
                //Ya podemos usar todos sus metodos
                //ticket.AbreCajon();//Para abrir el cajon de dinero.

                //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

                //Datos de la cabecera del Ticket.
                for (int i = 0; i < 2; i++)
                {
                    ticket.TextoCentro("COMISARIATO SUPER2");
                    ticket.TextoIzquierda("     ");
                    ticket.TextoCentro("AVANCE DE DINERO");
                    ticket.TextoIzquierda("         ");
                    ticket.TextoIzquierda("# Caja: " + caja);
                    ticket.TextoIzquierda("Cajero: " + cajero);
                    string[] h = DateTime.Now.TimeOfDay.ToString().Split('.');
                    ticket.TextoIzquierda("Fecha: " + Program.FecaInicio + "          " + h[0]);
                    ticket.lineasAsteriscos();
                    ticket.TextoIzquierda("Cantidad: $" + txtDinero.Text);
                    ticket.lineasAsteriscos();
                    ticket.TextoIzquierda("         ");






                    //Texto final del Ticket.
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                    ticket.TextoCentro("Firma");

                    ticket.CortaTicket();
                    var valor = ConfigurationManager.AppSettings["Local"];
                    ticket.ImprimirTicket(valor);
                }
                //Nombre de la impresora ticketera
            }
            catch (Exception ex)
            {

                //MessageBox.Show("" + ex.Message);
            }
        }
        public FrmAvanse()
        {
            InitializeComponent();
        }
    }
}
