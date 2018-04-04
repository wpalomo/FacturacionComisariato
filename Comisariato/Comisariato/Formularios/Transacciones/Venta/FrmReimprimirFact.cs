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
    public partial class FrmReimprimirFact : Form
    {
        List<Producto> p;
        List<string> detapago;
        Consultas c;
        EmcabezadoFactura em;
        public FrmReimprimirFact()
        {
            InitializeComponent();
            p = new List<Producto>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                c = new Consultas();
                if (txtSucursal.Text != "" && txtCaja.Text != "" && txtNumFact.Text != "")
                {
                    em = c.ConsutarFactura(int.Parse(txtSucursal.Text), int.Parse(txtCaja.Text), int.Parse(txtNumFact.Text),1);
                    if (em != null)
                    {
                        p = c.detalleFact;
                        detapago = c.detallepagoreim;
                        if (p.Count>0)
                        {
                            Imprimirfact();
                            FrmFactura.verificadorfrm = 4;
                            this.Close();
                        }
                        //MessageBox.Show("Cantidad Productos: "+p.Count);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar una factura con esa serie.");
                    }

                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void Imprimirfact()
        {
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //Ya podemos usar todos sus metodos
            //ticket.AbreCajon();//Para abrir el cajon de dinero.


            DateTime FECHA = Convert.ToDateTime(em.Fecha);
            int tamañoencabezado = 0, tamañoPie = 0, cantItems = 0;

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.

            //c.DatosCliente()
            if (Program.BoolAutorizadoImprimir)
            {
                ticket.TextoCentro("EMPRESA: " + Program.nombreempresa);
                ticket.TextoCentro("RUC: " + Program.rucempresa);
                ticket.TextoIzquierda(Program.direccionempresa);
                ticket.TextoIzquierda("Valido: " + FECHA.ToShortDateString() + " Hasta: " + FECHA.Date.AddYears(1).ToShortDateString());
                ticket.TextoIzquierda("Clave: "+em.Claveacceso);
            }
            else if(Program.BoolPreimpresa)
            {
                //TAMANOENCABEZADOFACTURA-TAMANOPIEFACTURA-NUMEROITEMS
                String PreimpresaDatos = Program.DatosPreimpresa;
                string[] Preimpresa = PreimpresaDatos.Split('-');
                tamañoencabezado = Convert.ToInt32(Preimpresa[0]);
                tamañoPie = Convert.ToInt32(Preimpresa[1]);
                cantItems = Convert.ToInt32(Preimpresa[2]);
                //((tamañoencabezado * 2) + 1) ---> 2 = 1cm son dos lineas --- 1 = para completar el centimetro
                for (int i = 1; i <= ((tamañoencabezado*2)+1); i++)
                {
                    ticket.TextoCentro("");
                }
            }


            ticket.TextoIzquierda("        Factura: " + int.Parse(txtSucursal.Text).ToString("D3") + "-" + int.Parse(txtCaja.Text).ToString("D3") + "-" + int.Parse(txtNumFact.Text).ToString("D9"));
            ticket.TextoIzquierda("         Informacion del Consumidor");//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("RUC: " + em.Identificacion);
            ticket.TextoIzquierda("Cliente: " + em.NombresCliente);
            ticket.TextoIzquierda("Facturado: " + em.NombreUsuario + " # CAJA: "+int.Parse(txtCaja.Text).ToString("D3"));
            ticket.TextoIzquierda("Fecha: " + em.Fecha + "          " + em.Hora);

            if (detapago[0]!="0"&&detapago[1]!="0"&& detapago[2]!="0")
            {
                ticket.TextoIzquierda("Tipo de pago: Efectivo - Cheque - T. Credito");
            }
            else
            {
                if (detapago[1] != "0" && detapago[2] != "0")
                {
                    ticket.TextoIzquierda("Tipo de pago: Cheque - T. Credito");
                }
                else
                {
                    if (detapago[2]!="0"&&detapago[0]!="0")
                    {
                        ticket.TextoIzquierda("Tipo de pago: Efectivo - T. Credito");
                    }
                    else
                    {
                        if (detapago[0]!="0" && detapago[1]!="0")
                        {
                            ticket.TextoIzquierda("Tipo de pago: Efectivo - Cheque");
                        }
                        else
                        {
                            if (detapago[0]!="0")
                            {
                                ticket.TextoIzquierda("Tipo de pago: Efectivo");
                            }
                            else
                            {
                                if (detapago[1]!="0")
                                {
                                    ticket.TextoIzquierda("Tipo de pago: Cheque");
                                }
                                else
                                {
                                    if (detapago[2]!="0")
                                    {
                                        ticket.TextoIzquierda("Tipo de pago: T. Credito");
                                    }
                                }
                            }
                        }
                    }
                }

            }

            //ticket.TextoIzquierda("Forma de pago: " + pago);
            ticket.lineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();
            double ivasuma = 0.0f, subtotal = 0.0f, subtotaconiva = 0.0f,  totaapagar = 0.0f, Subtotaltotalpago = 0.0f;
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            for (int i = 0; i < p.Count; i++)//dgvLista es el nombre del datagridview
            {
                double total = 0.0f,iva=0.0f;
                total = p[i].Preciopublico_sin_iva * p[i].Cantidad;
                if (p[i].Iva == 12)
                {
                    iva = ((p[i].Preciopublico_sin_iva * p[i].Cantidad) * p[i].Iva)/100;
                    ivasuma = iva;
                    ticket.AgregaArticulo("*" + p[i].Nombreproducto, p[i].Cantidad,
                    Convert.ToSingle(p[i].Preciopublico_sin_iva).ToString("#####0.00"), total.ToString("#####0.00"));
                    //subtotaconiva += total + iva;
                    subtotaconiva += p[i].Preciopublico_sin_iva;
                }
                else
                {
                    ticket.AgregaArticulo(" "+p[i].Nombreproducto, p[i].Cantidad,
                    Convert.ToSingle(p[i].Preciopublico_sin_iva).ToString("#####0.00"), Convert.ToSingle(total).ToString("#####0.00"));
                    subtotal += total;
                }
                Subtotaltotalpago += total;
                totaapagar += total + iva;
               
            }
            
            ticket.lineasAsteriscos();
            //Resumen de la venta. Sólo son ejemplos
            //Resumen de la venta. Sólo son ejemplos
            //ticket.AgregarTotales("SUBTOTAL 0% ", subtotal);
            //ticket.AgregarTotales("SUBTOTAL 12% ", subtotaconiva);
            //ticket.AgregarTotales("Descuento", Convert.ToDouble(detapago[3]));
            //ticket.AgregarTotales("Iva 12%  ", Convert.ToDouble(detapago[4]));
            //ticket.AgregarTotales("Total a pagar", totaapagar);

            ticket.AgregarTotales("SUBTOTAL 0% ",Convert.ToDouble(detapago[9]));
            ticket.AgregarTotales("SUBTOTAL 12% ", Convert.ToDouble(detapago[8]));
            ticket.AgregarTotales("Descuento", Convert.ToDouble(detapago[3]));
            ticket.AgregarTotales("Iva 12%  ", Convert.ToDouble(detapago[4]));
            ticket.AgregarTotales("Total a pagar", Convert.ToDouble(detapago[7]));

            if (detapago[0] != "0" && detapago[1] != "0" && detapago[2] != "0")
            {
                ticket.TextoIzquierda("Efectivo:  $" + detapago[0]);
                ticket.TextoIzquierda("Cheque:    $" + detapago[1]);
                ticket.TextoIzquierda("T. Credito $: " + detapago[2]);
                ticket.TextoIzquierda("Recibido: $" + Convert.ToSingle(detapago[5]).ToString("#####0.00") + " Cambio: $" + Convert.ToSingle(detapago[6]).ToString("#####0.00"));
            }
            else
            {
                if (detapago[1] != "0" && detapago[2] != "0")
                {
                    //ticket.TextoIzquierda("Cheque:  $" + txtEfectivo.Text);
                    ticket.TextoIzquierda("Cheque:    $" + detapago[1]);
                    ticket.TextoIzquierda("T. Credito $: " + detapago[2]);
                    ticket.TextoIzquierda("Recibido: $" + Convert.ToSingle(detapago[5]).ToString("#####0.00") + " Cambio: $" + Convert.ToSingle(detapago[6]).ToString("#####0.00"));
                }
                else
                {
                    if (detapago[2] != "0" && detapago[0] != "0")
                    {
                        ticket.TextoIzquierda("Efectivo:  $" + detapago[0]);
                        //ticket.TextoIzquierda("Cheque:    $" + txtCheque.Text);
                        ticket.TextoIzquierda("T. Credito $: " + detapago[2]);
                        ticket.TextoIzquierda("Recibido: $" + Convert.ToSingle(detapago[5]).ToString("#####0.00") + " Cambio: $" + Convert.ToSingle(detapago[6]).ToString("#####0.00"));
                    }
                    else
                    {
                        if (detapago[0] != "0" && detapago[1] != "0")
                        {
                            ticket.TextoIzquierda("Efectivo:  $" + detapago[0]);
                            ticket.TextoIzquierda("Cheque:    $" + detapago[1]);
                            // ticket.TextoIzquierda("T. Credito $: " + txtCredito.Text);
                            ticket.TextoIzquierda("Recibido: $" + Convert.ToSingle(detapago[5]).ToString("#####0.00") + " Cambio: $" + Convert.ToSingle(detapago[6]).ToString("#####0.00"));
                        }
                        else
                        {
                            if (detapago[0]!="0")
                            {
                                ticket.TextoIzquierda("Efectivo:  $" +detapago[0]);
                                ticket.TextoIzquierda("Recibido: $" + Convert.ToSingle(detapago[5]).ToString("#####0.00") + " Cambio: $" + Convert.ToSingle(detapago[6]).ToString("#####0.00"));
                            }
                            else
                            {
                                if (detapago[1]!="0")
                                {
                                    ticket.TextoIzquierda("Cheque:    $" + detapago[1]);
                                    ticket.TextoIzquierda("Recibido: $" + Convert.ToSingle(detapago[5]).ToString("#####0.00") + " Cambio: $" + Convert.ToSingle(detapago[6]).ToString("#####0.00"));
                                }
                                else
                                {
                                    if (detapago[2]!="0")
                                    {
                                        ticket.TextoIzquierda("T. Credito $: " + detapago[2]);
                                        ticket.TextoIzquierda("Recibido: $" +Convert.ToSingle( detapago[5]).ToString("#####0.00") + " Cambio: $" +Convert.ToSingle(detapago[6]).ToString("#####0.00"));
                                    }
                                }
                            }
                        }
                    }

                }
            }

           

            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTICULOS VENDIDOS: " + p.Count);
            ticket.TextoIzquierda("");
            if (Program.BoolAutorizadoImprimir)
            {
                String PIEFA = Program.piefactura;
                string[] PIES = PIEFA.Split('\n');
                ticket.TextoCentro(PIES[0]);
                ticket.TextoCentro(PIES[1]);
                ticket.TextoCentro(PIES[2]);
                ticket.TextoCentro(PIES[3]);
            }
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.CortaTicket();
            var valor = ConfigurationManager.AppSettings["Local"];
            ticket.ImprimirTicket(valor);
            //ticket.ImprimirTicket("Generic / Text Only");//Nombre de la impresora ticketera




        }

        private void txtSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtSucursal.Text!="")
                {
                    txtCaja.Focus();
                }
                
            }
            else
            {
                Funcion.Validar_Numeros(e);
            }

           
        }

        private void txtCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtCaja.Text != "")
                {
                    txtNumFact.Focus();
                }

            }
            else
            {
                Funcion.Validar_Numeros(e);
            }
        }

        private void txtNumFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                c = new Consultas();
                if (e.KeyChar == (char)Keys.Return)
                {
                    if (txtNumFact.Text != "")
                    {
                        em = c.ConsutarFactura(int.Parse(txtSucursal.Text), int.Parse(txtCaja.Text), int.Parse(txtNumFact.Text),1);
                        if (em != null)
                        {
                            p = c.detalleFact;
                            detapago = c.detallepagoreim;
                            if (p.Count > 0)
                            {
                                Imprimirfact();
                                FrmFactura.verificadorfrm = 4;
                                this.Close();
                            }
                        }
                        else
                        {
                            //MessageBox.Show("No se pudo encontrar una factura con esa serie.");
                        }
                    }

                }
                else
                {
                    Funcion.Validar_Numeros(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void FrmReimprimirFact_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmReimprimirFact_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose(true);
        }
    }
}
