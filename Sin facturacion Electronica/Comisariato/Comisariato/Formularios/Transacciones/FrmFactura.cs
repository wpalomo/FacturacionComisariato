using Comisariato.Clases;
using Comisariato.Formularios.Transacciones.Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmFactura : Form
    {
        internal static List<string> DatosCliente = new List<string>();
        internal static List<string> DatosProducto = new List<string>();
        internal static int  correcta=100;
        internal static int verificadorfrm=78;
        private int  posicion, ivaporcentaje, tipoprecio = 0, cantmayorita = 20, fila,contador=0,factenter, tipoprecio1 = 0, formapago = 0, fr, idcliente,idclienteespe;
        private string codactual = "",cantactual="";
        public string numcaja;
        public string sucursal,direccionComprador;
        public int numfact=0,IDCLIENTEINICIO;
        internal static int numfactnuevo = 0;
        private float cantidadanterior, cantcaja = 0;
        private string PrecioTodoslosDecimales;
        List<String> listatipo = new List<String>();
        List<String> pedidos = new List<String>();
        List<String> Ivas = new List<String>();
        List<String> Ivas1 = new List<String>();
        List<int> indezp = new List<int>();
        List<int> indezpfactespe = new List<int>();

        List<Producto> retencionfact;
        List<string> codigos;
        List<string> codigosfactespe = new List<string>();
        List<string> DatosClientefactespe = new List<string>();
        List<string> DatosClienteAUX = new List<string>();

        private bool estadoiva, pr, escribiendo = false;
        Producto Producto;
        FrmClaveSupervisor s;
        FrmCobrar frmcobrar;
        public bool comprobarmetodo,hayfactenespera;
        int factEspe = 0;
        private int posindexp = 0;

        public FrmFactura()
        {
            InitializeComponent();
            codigos = new List<string>();
            this.Height = Program.tamañoVentanaPrincipal - 75;

        }

        private void rdbFacturaDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFacturaDatos.Checked)
            {
                txtIdentidicacion.Text = "";
                btnGuardar.Enabled = true;
                txtIdentidicacion.Enabled = true;
                txtIdentidicacion.Focus();
                btnBuscar.Enabled = true;
            }
            else
            {
                rdbFacturaDatos.Checked = false;
                btnBuscar.Enabled = false;
                txtCodigo.Focus();
            }
            //txtCodigo.Focus();
        }
      
        private void rdbConsumidorFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbConsumidorFinal.Checked)
            {
                //idcliente =1;
                btnGuardar.Enabled = false;
                txtConsumidor.Enabled = false;
                txtIdentidicacion.Enabled = false;
                txtIdentidicacion.Text = "9999999999999";
                txtConsumidor.Text = "Consumidor Final";
                DatosCliente.Clear();
            }
            else
            {
                rdbConsumidorFinal.Checked = false;
            }
            txtCodigo.Focus();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            
            // this.dgvDetalleProductos.CellValidating += new DataGridViewCellValidatingEventHandler(dgv_validating);
            //propiedadesdgv();
            Program.FormularioVentaAbierto = true;
            Consultas consultas = new Consultas();
            DataTable dt = consultas.BoolDataTable("Select LOGO from TbEmpresa where IDEMPRESA = 1");
            //Arreglo de byte en donde se almacenara la foto en bytes
            byte[] MyData = new byte[0];
            //Verificar si tiene Datos
            if (dt.Rows.Count > 0)
            {
                DataRow myRow = dt.Rows[0];

                //Se almacena el campo foto de la tabla en el arreglo de bytes
                if (Convert.ToString(myRow["LOGO"]) != "")
                {
                    MyData = (byte[])myRow["LOGO"];
                    //Se inicializa un flujo en memoria del arreglo de bytes
                    MemoryStream stream = new MemoryStream(MyData);
                    //En el picture box se muestra la imagen que esta almacenada en el flujo en memoria 
                    //el cual contiene el arreglo de bytes
                    this.pictureBox1.BackgroundImage = Image.FromStream(stream);
                }
                else
                {
                    this.pictureBox1.BackgroundImage =Comisariato.Properties.Resources.no_logo;
                }
            }

            txtCodigo.Focus();
            idcliente = IDCLIENTEINICIO;
            txtNumFact.Text = numfact.ToString("D9");
            txtCaja.Text = numcaja;
            txtSucursal.Text = sucursal;
            lblCajero.Text = "Cajero:  " + Program.Usuario;
            dgvDetalleProductos.Columns[2].DefaultCellStyle.BackColor = Color.LightCyan;
            dgvDetalleProductos.Columns[3].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            dgvDetalleProductos.Columns[4].DefaultCellStyle.BackColor = Color.LightCyan;
            dgvDetalleProductos.Columns[6].DefaultCellStyle.BackColor = Color.LightGreen;
            rdbFacturaDatos.Checked = false;
            rdbConsumidorFinal.Checked = true;

            //dgvFormaPago.Enabled = false;
            //dgvFormaPago.DefaultCellStyle.BackColor = Color.Silver;
            btnActivarFact.Enabled = false;
            btnFactEspera.Enabled = false;
            btnEliminarFact.Enabled = false;

           // this.dgvDetalleProductos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //this.dgvDetalleProductos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvDetalleProductos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            //DataGridViewComboBoxColumn comboboxColumn = dgvFormaPago.Columns["Tipo"] as DataGridViewComboBoxColumn;

            // comboboxColumn.DataSource = listatipo;

            for (int i = 0; i < 27; i++)
            {
                dgvDetalleProductos.Rows.Add();
            }
           
        }

       

        private void dgvDetalleProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void factproducto(float iva, int n/*,bool libreimpuesto*/)
        {

            float total = 0.0f;
          
            if (n == 1)
            {
                    if (verificarcodigos(txtCodigo.Text))
                    {

                    if (rdbCaja.Checked)
                    {
                        if (Convert.ToSingle(txtBodega.Text) >=(Convert.ToSingle(txtCantidad.Text) + cantidadanterior))
                        {
                            dgvDetalleProductos.Rows[posicion].Cells[2].Value = Convert.ToSingle(txtCantidad.Text) + cantidadanterior;

                            float ivant = Convert.ToSingle(dgvDetalleProductos.Rows[posicion].Cells[5].Value.ToString()) + iva;
                            dgvDetalleProductos.Rows[posicion].Cells[5].Value = ivant.ToString("#####0.00");

                            total = (Convert.ToSingle(PrecioTodoslosDecimales) * Convert.ToSingle(dgvDetalleProductos.Rows[posicion].Cells[2].Value.ToString())) + ivant;
                            //dgvDetalleProductos.CurrentRow.Cells[2].Value = Convert.ToInt32(dgvDetalleProductos.CurrentRow.Cells[2].Value.ToString()) + cantidadanterior;
                            dgvDetalleProductos.Rows[posicion].Cells[6].Value = total.ToString("#####0.00");
                            //dgvDetalleProductos.Rows[posicion].Cells[6].Value = Math.Round(total,2);

                            // LimpiarTexbox();

                            cantidadanterior = 0;
                            posicion = 0;
                            Calcular();
                            pr = true;
                        }
                        else
                        {
                            MessageBox.Show("El Stock del Producto\n\rExistente es de " + Convert.ToInt32(dgvDetalleProductos.CurrentRow.Cells[3].Value.ToString()) + " unidades");
                            //SendKeys.Send("{up}");
                            txtCantidad.Focus();
                            pr = false;
                        }
                    }
                    else
                    {
                        if (Convert.ToSingle(txtBodega.Text) >= (Convert.ToSingle(txtCantidad.Text) + cantidadanterior))
                        {
                            dgvDetalleProductos.Rows[posicion].Cells[2].Value = Convert.ToSingle(txtCantidad.Text) + cantidadanterior;

                            float ivant = Convert.ToSingle(dgvDetalleProductos.Rows[posicion].Cells[5].Value.ToString()) + iva;
                            dgvDetalleProductos.Rows[posicion].Cells[5].Value = ivant.ToString("#####0.00");

                            total = (Convert.ToSingle(PrecioTodoslosDecimales) * Convert.ToSingle(dgvDetalleProductos.Rows[posicion].Cells[2].Value.ToString())) + ivant;
                            //dgvDetalleProductos.CurrentRow.Cells[2].Value = Convert.ToInt32(dgvDetalleProductos.CurrentRow.Cells[2].Value.ToString()) + cantidadanterior;
                            dgvDetalleProductos.Rows[posicion].Cells[6].Value = total.ToString("#####0.00");
                            //dgvDetalleProductos.Rows[posicion].Cells[6].Value = Math.Round(total, 2);

                            // LimpiarTexbox();

                            cantidadanterior = 0;
                            posicion = 0;
                            Calcular();
                            pr = true;

                        }
                        else
                        {
                            MessageBox.Show("El Stock del Producto\n\rExistente es de " + Convert.ToInt32(dgvDetalleProductos.CurrentRow.Cells[3].Value.ToString()) + " unidades");
                            //SendKeys.Send("{up}");
                            txtCantidad.Focus();
                            pr = false;
                        }
                    }    

                    }
                    else
                    {
                     
                        total = (Convert.ToSingle(PrecioTodoslosDecimales) * Convert.ToSingle(txtCantidad.Text)) + iva;
                        codigos.Add(txtCodigo.Text + ";" + tipoprecio);
                        AgregarFila(codigos.Count - 1, total, iva);
                        Calcular();
                        pr = true;
                    }
                //}

               
            }
            else
            {
                
                    if (verificarcodigos(txtCodigo.Text))
                    {
                    if (rdbCaja.Checked)
                    {
                        if (Convert.ToSingle(txtBodega.Text) >= (Convert.ToSingle(txtCantidad.Text) + cantidadanterior))
                        {
                            dgvDetalleProductos.Rows[posicion].Cells[2].Value = Convert.ToSingle(txtCantidad.Text) + cantidadanterior;
                            total = Convert.ToSingle(dgvDetalleProductos.Rows[posicion].Cells[2].Value.ToString()) * Convert.ToSingle(PrecioTodoslosDecimales);
                            //dgvDetalleProductos.CurrentRow.Cells[2].Value = Convert.ToInt32(dgvDetalleProductos.CurrentRow.Cells[2].Value.ToString()) + cantidadanterior;
                            dgvDetalleProductos.Rows[posicion].Cells[6].Value = total.ToString("#####0.00");
                            //dgvDetalleProductos.Rows[posicion].Cells[6].Value = Math.Round(total, 2);
                            //LimpiarTexbox();
                            Calcular();
                            pr = true;
                        }
                        else
                        {
                            MessageBox.Show("El Stock del Producto\n\rExistente es de " + Convert.ToSingle(txtBodega.Text) + " unidades");
                            txtCantidad.Focus();
                            pr = false;
                        }
                    }
                    else
                    {
                        if (Convert.ToSingle(txtBodega.Text) >= (Convert.ToSingle(txtCantidad.Text) + cantidadanterior))
                        {
                            dgvDetalleProductos.Rows[posicion].Cells[2].Value = Convert.ToSingle(txtCantidad.Text) + cantidadanterior;
                            total = Convert.ToSingle(dgvDetalleProductos.Rows[posicion].Cells[2].Value.ToString()) * Convert.ToSingle(PrecioTodoslosDecimales);
                            //dgvDetalleProductos.CurrentRow.Cells[2].Value = Convert.ToInt32(dgvDetalleProductos.CurrentRow.Cells[2].Value.ToString()) + cantidadanterior;
                            dgvDetalleProductos.Rows[posicion].Cells[6].Value = total.ToString("#####0.00");
                            //dgvDetalleProductos.Rows[posicion].Cells[6].Value = Math.Round(total, 2);
                            //LimpiarTexbox();
                            Calcular();
                            pr = true;
                        }
                        else
                        {
                            MessageBox.Show("El Stock del Producto\n\rExistente es de " + Convert.ToSingle(txtBodega.Text) + " unidades");
                            txtCantidad.Focus();
                            pr = false;
                        }
                    }
                       

                    }
                    else
                    {
                        total = Convert.ToSingle(txtCantidad.Text) * Convert.ToSingle(PrecioTodoslosDecimales);
                        codigos.Add(txtCodigo.Text + ";" + tipoprecio);
                        AgregarFila(codigos.Count - 1, total, iva);
                       
                        pr = true;
                        Calcular();
                    }
            }

            // }

            if (codigos.Count > 0 && contador == 0)
            {
                btnFactEspera.Enabled = true;
                btnEliminarFact.Enabled = true;
            }
           // Calcular();

        }
        bool li;
        private void AgregarFila(int fila, float total,float iva)
        {
           
            //if (Producto.LibreImpuesto)
            //    dgvDetalleProductos.Rows[fila].Cells[9].Value = 1;
            //else
            //    dgvDetalleProductos.Rows[fila].Cells[9].Value = 0;

            ////posible error
            //float totalfinal = (Convert.ToInt32(txtCantidad.Text)*Convert.ToSingle(txtPrecio.Text))+Convert.ToSingle(txtIvaPrecio.Text);
            
            dgvDetalleProductos.Rows[fila].Cells[0].Value = txtCodigo.Text;
            dgvDetalleProductos.Rows[fila].Cells[1].Value = txtDetalle.Text;
            dgvDetalleProductos.Rows[fila].Cells[2].Value = txtCantidad.Text;
            dgvDetalleProductos.Rows[fila].Cells[3].Value = txtBodega.Text;
            dgvDetalleProductos.Rows[fila].Cells[4].Value = txtPrecio.Text;
            dgvDetalleProductos.Rows[fila].Cells[5].Value = txtIvaPrecio.Text;
            
            //posible error
            float posibleerror = Convert.ToSingle(txtCantidad.Text) *Convert.ToSingle( PrecioTodoslosDecimales);
            float posibleerror1 = posibleerror + iva;
            dgvDetalleProductos.Rows[fila].Cells[6].Value = posibleerror1.ToString("#####0.00");
            //dgvDetalleProductos.Rows[fila].Cells[9].Value = Convert.ToInt32(Producto.LibreImpuesto);
            //if (rdbCaja.Checked)
            //{
            //    dgvDetalleProductos.Rows[fila].Cells[8].Value = cantcaja;
            //}
            //else
            //{
            //    dgvDetalleProductos.Rows[fila].Cells[8].Value = 0;
            //}
            dgvDetalleProductos.Rows[fila].Cells[10].Value = PrecioTodoslosDecimales;
            dgvDetalleProductos.CurrentCell = dgvDetalleProductos.Rows[fila].Cells[0];
            Ivas.Add("" + Producto.Iva);
            
            dgvDetalleProductos.Rows.Add();
            LimpiarTexbox();
        }

        private void LimpiarTexbox()
        {
            txtCodigo.Text = "";
            txtDetalle.Text = "";
            txtCantidad.Text = "";
            txtBodega.Text = "";
            txtPrecio.Text = "";
            txtIvaPrecio.Text = "";
            txtCodigo.Focus();
        }

        private void Calcular()
        {
            float sumasubiva = 0.0f, sumasubcero = 0.0f, totalpagar = 0.0f, ivatotal = 0.0f;
            try
            {
                for (int i = 0; i < codigos.Count; i++)
                {
                   
                    if (Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[5].Value) != 0)
                    {
                        //sumasubiva += Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[2].Value.ToString())* Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[4].Value.ToString());
                        sumasubiva+= Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[6].Value); 
                        ivatotal += Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[5].Value.ToString());

                    }
                    
                    if (Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[5].Value) == 0)
                    {
                        sumasubcero += Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[6].Value.ToString());
                    }

                    // totalpagar += Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[6].Value.ToString());
                    //posible error
                    //float multicantpre = Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[2].Value) * Convert.ToSingle(PrecioTodoslosDecimales);
                    // totalpagar += multicantpre + Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[5].Value);
                    totalpagar += Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[6].Value);

                }
                float prueba = 1.12f;
                txtSubTotalcero.Text = sumasubcero.ToString("#####0.00");
                txtSubTotal.Text = totalpagar.ToString("#####0.00");

                float subtotaivafinal = sumasubiva / prueba;

                txtSubTotalIva.Text = subtotaivafinal.ToString("#####0.00");

                //totalpagar = sumasub + ivatotal;
                txtIva.Text = ivatotal.ToString("#####0.00");
                lblTotalPagar.Text = "" + Funcion.reemplazarcaracter(totalpagar.ToString("#####0.00"));
                codactual = "";
                factenter = 0;
                LimpiarTexbox();
                if (codigos.Count>1)
                {
                    dgvDetalleProductos.Rows[codigos.Count - 2].Selected = false;
                }
               
                dgvDetalleProductos.Rows[codigos.Count-1].Selected = true;
                //float prueba = Convert.ToSingle(totalpagar.ToString("#####0.00"));
            }
            catch (Exception EX)
            {

                MessageBox.Show("" + EX.Message);
            }

        }

        private void btnEliminarFact_Click(object sender, EventArgs e)
        {
            if (codigos.Count>0)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar la factura?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (codigos.Count > 0)
                    {
                        FacturaenEspera();
                    }
                }
                else
                {
                    if (txtDetalle.Text != "")
                    {
                        txtCantidad.Focus();
                    }
                    else
                    {
                        txtCodigo.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay Items para eliminar");
                txtCodigo.Focus();
            }

            ChkTodoBodega.Checked = false;
           
        }

        private void ckbCredito_CheckedChanged(object sender, EventArgs e)
        {
            //if (ckbEfectivo.Checked)
            //{
            //    dgvFormaPago.Enabled = true;
            //    dgvFormaPago.DefaultCellStyle.BackColor = Color.White;
            //}
            //else
            //{
            //    //dgvFormaPago.DefaultCellStyle.BackColor = Color.Silver;
            //    dgvFormaPago.Enabled = false;

            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            FrmDatosClientes f = new FrmDatosClientes();
            f.comprobarvista = 1;
            f.ShowDialog();
            //FrmFactura_Activated(null, null);
            cogerDatosCliente();
            txtCodigo.Focus();
        }

        private void cogerDatosCliente()
        {
            try
            {
                if (DatosCliente.Count > 0)
                {
                    txtIdentidicacion.Text = DatosCliente[0];
                    txtConsumidor.Text = DatosCliente[1];
                    idcliente = Convert.ToInt32(DatosCliente[4]);
                    // rdbFacturaDatos.Checked = true;
                    txtCodigo.Focus();
                }
                else
                {
                    rdbConsumidorFinal.Checked = true;
                    txtCodigo.Focus();
                }
            }
            catch (Exception)
            {

                //throw;
            }
            
        }

        private void txtIdentidicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Consultas objCns = new Consultas();
                if (txtIdentidicacion.Focus())
                {
                    if (e.KeyChar == (char)Keys.Return)
                    {
                        bool cedu = false;
                        //int cor = 0;
                        if (txtIdentidicacion.Text.Length == 10)
                        {
                            cedu = Funcion.VerificarCedula(txtIdentidicacion.Text);
                        }
                        else
                        {
                            if (/*txtIdentidicacion.Text.Substring(10, 3)*/txtIdentidicacion.Text.Length == 13)
                            {
                                cedu = true;
                               // cor = 1;
                            }
                            else
                            {
                                cedu = false;
                                MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                        //bool cedu=Funcion.VerificarCedula(txtIdentidicacion.Text);
                        if (cedu)
                        {
                            Cliente cliente = objCns.buscarcliente(txtIdentidicacion.Text);
                            if (cliente != null)
                            {
                                //string[] vector = datoscliente.Split(';');
                                if (cliente.Activo)
                                {
                                    if (DatosCliente.Count>0)
                                    {
                                        DatosCliente.Clear();
                                    }
                                    DatosCliente.Add(cliente.Identificacion); //Identificacion
                                    DatosCliente.Add(cliente.Nombres + " " + cliente.Apellidos);//Nombre + Apellido
                                    DatosCliente.Add(cliente.Direccion); // Direccion
                                    DatosCliente.Add(cliente.RazonSocial); //RazonSocial
                                    DatosCliente.Add("" + cliente.Casilla); //IDcLIENTE

                                    txtConsumidor.Text = cliente.Nombres + " " + cliente.Apellidos;
                                    idcliente = cliente.Casilla;
                                    comprobarmetodo = true;
                                    txtCodigo.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("Este cliente está desabilitado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    comprobarmetodo = false;
                                    rdbConsumidorFinal.Checked = true;
                                    txtCodigo.Focus();

                                }
                                //rdbFacturaDatos.Checked = true;
                                //btnBuscar.Text = "Buscar";
                            }
                            else
                            {
                                txtIdentidicacion.Focus();
                                comprobarmetodo = false;
                                //idcliente = 1;
                                //btnBuscar.Text = "Registrar";
                                if (MessageBox.Show("No existe un cliente registrado con la identificacion: " + txtIdentidicacion.Text + "\n¿Quieres registrarlo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    FrmClientes f = new FrmClientes();
                                    f.VerifiMetodo = 2;
                                    f.ShowDialog();
                                    rdbFacturaDatos.Checked = true;
                                    //posible error
                                    cogerDatosCliente();
                                   // FrmFactura_Activated(null, null);
                                    txtCodigo.Focus();
                                }
                                else
                                {

                                    rdbConsumidorFinal.Checked = true;
                                    txtCodigo.Focus();
                                }
                            }
                        }
                        //else
                        //{
                        //    if (cor == 1)
                        //    {
                        //        MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Ingrese la Cedula Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //    }

                        //    txtIdentidicacion.Focus();
                        //    rdbFacturaDatos.Checked = true;
                        //    rdbConsumidorFinal.Checked = false;
                        //}

                    }
                }
            }
            catch (Exception)
            {

                //throw;
            }
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmClientes f = new FrmClientes();
            f.VerifiMetodo = 2;
            f.ShowDialog();
            rdbFacturaDatos.Checked = true;
            cogerDatosCliente();
            //FrmFactura_Activated(null, null);
            txtCodigo.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmClaveUsuario u = new FrmClaveUsuario();
            u.verificarMetodo = 2;
            u.numcajaAvance = txtCaja.Text;
            u.ShowDialog();
            txtCodigo.Focus();



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReimprimirFact_Click(object sender, EventArgs e)
        {
            FrmReimprimirFact r = new FrmReimprimirFact();
            r.ShowDialog();
            txtCodigo.Focus();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FrmConsultarProducto p = new FrmConsultarProducto();
            p.ShowDialog();
            txtCodigo.Focus();
            verificadorfrm = 2;
            CogerProductos();
            //FrmFactura_Activated(null, null);

        }

        private void CogerProductos()
        {
            if (DatosProducto.Count > 0)
            {
                Producto = new Producto();
                if (rdbPublico.Checked)
                {
                    txtPrecio.Text = Convert.ToDouble(DatosProducto[3]).ToString("#####0.00");
                    PrecioTodoslosDecimales = DatosProducto[3];
                }
                else
                {
                    if (rdbMayorista.Checked)
                    {
                        txtPrecio.Text = Convert.ToDouble(DatosProducto[4]).ToString("#####0.00");
                        PrecioTodoslosDecimales = DatosProducto[4];
                    }
                    else
                    {
                        txtPrecio.Text = Convert.ToDouble(DatosProducto[5]).ToString("#####0.00");
                        PrecioTodoslosDecimales = DatosProducto[5];
                    }
                }

                int verificariva = Convert.ToInt32(DatosProducto[6]);
                //estadoiva = verificariva;
                if (verificariva == 1)
                {
                    estadoiva = true;
                    //Producto.Iva = Convert.ToInt32(DatosCliente[7]);
                    ivaporcentaje = Convert.ToInt32(DatosProducto[7]);
                    Producto.Iva = ivaporcentaje;
                }
                else
                {
                    estadoiva = false;
                    float prueba = 0.0f;
                    txtIvaPrecio.Text = prueba.ToString("#####0.00");
                }
                //cantcaja = Convert.ToSingle(DatosProducto[8]);
                txtCodigo.Text = DatosProducto[0];
                txtDetalle.Text = DatosProducto[1];
                txtBodega.Text = DatosProducto[2];
                //Producto.LibreImpuesto = Convert.ToBoolean(Convert.ToInt32(DatosProducto[9]));
                txtCantidad.Text = "1";
                txtCantidad.Focus();

                DatosProducto.Clear();
            }
            else
            {
                txtCodigo.Focus();
            }
        }

        private void dgvDetalleProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (e.Control is TextBox)
            //{
            //    TextBox txt = e.Control as TextBox;
            //    if (dgvDetalleProductos.CurrentCell == dgvDetalleProductos.CurrentRow.Cells[2])
            //    {
            //        txt.KeyPress += OnlyNumbers_KeyPress;
            //    }
            //}
        }

        private void dgvDetalleProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Focus();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (e.KeyChar == (char)Keys.Return && txtCodigo.Text!="")
                {
                    Consultas objCns = new Consultas();
                    //Producto = new Producto();
                    Producto = new Producto();
                    codactual = txtCodigo.Text;
                    if (codactual != null)
                    {
                        Producto = objCns.Consultarproducto(txtCodigo.Text);
                        if (Producto != null)
                        {
                           
                            //cantcaja = Producto.Caja;
                            //li = Producto.LibreImpuesto;
                            if (Producto.Cantidad == 0)
                            {
                                MessageBox.Show("No hay unidades suficientes para vender.");
                                txtCodigo.Text = "";
                                txtCodigo.Focus();
                                pr = false;
                            }
                            else
                            {
                                //if (Producto.Cantidad == 10)
                                //{
                                //    MessageBox.Show("Unidades actuales al limite.");
                                //}

                                txtDetalle.Text = Producto.Nombreproducto;
                                txtBodega.Text = Producto.Cantidad.ToString();
                                if (tipoprecio == 0)
                                {
                                    txtPrecio.Text = Producto.Preciopublico_sin_iva.ToString("#####0.00");
                                    PrecioTodoslosDecimales = Producto.Preciopublico_sin_iva.ToString();

                                }
                                else
                                {
                                    if (tipoprecio == 1)
                                    {

                                        txtPrecio.Text = Producto.Precioalmayor_sin_iva.ToString("#####0.00");
                                        PrecioTodoslosDecimales = Producto.Precioalmayor_sin_iva.ToString();
                                    }
                                    else
                                    {
                                        if (tipoprecio == 2)
                                        {
                                            txtPrecio.Text = Producto.Precioporcaja_sin_iva.ToString("#####0.00");
                                            PrecioTodoslosDecimales = Producto.Precioporcaja_sin_iva.ToString();
                                        }

                                    }
                                }

                                bool verificariva = Convert.ToBoolean(Producto.Ivaestado);
                                estadoiva = verificariva;
                                if (verificariva)
                                {
                                    ivaporcentaje = Producto.Iva;
                                    

                                }
                                else
                                {
                                    float prueba = 0.0f;
                                    txtIvaPrecio.Text = prueba.ToString();
                                }

                                escribiendo = false;
                                pr = false;
                                txtCantidad.Text = "1";
                                txtCantidad.Focus();
                                
                            }
                            
                            

                        }
                        else
                        {
                            codactual = "";
                            txtCodigo.Text = "";
                            escribiendo = false;
                            //MessageBox.Show("No existe un producto registrado con ese codigo.");
                            Producto = null;
                            factenter = 0;

                        }
                    }
                }
                else
                {
                    factenter++;
                    if (codigos.Count > 0)
                    {
                        if (factenter==2 && !escribiendo)
                        {
                            verificadorfrm = 0;
                            if (MessageBox.Show("¿Deseas Grabar esta Factura?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                grabarfact();
                                factenter = 0;
                                escribiendo = false;
                            }
                            else
                            {
                                factenter = 0;
                                escribiendo =false;
                            }
                        }
                       
                    }
                    else
                    {
                        factenter = 0;
                    }
                   

                }
            }
            catch (Exception)
            {


            }
        }

        private bool VerificarPrecios(float precio)
        {
            bool Verifica = false;
            if (rdbCaja.Checked)
            {
                if (precio>0)
                {
                    Verifica =true;
                }
                
            }
            else
            {
                if (rdbMayorista.Checked)
                {
                    if (precio>0)
                    {
                        Verifica= true;
                    }
                    
                }
                else
                {
                    if (rdbPublico.Checked)
                    {
                        if (precio>0)
                        {
                            Verifica = true;
                        }
                        
                    }
                }
            }
            return Verifica;
        }
       
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text!="")
            {
                escribiendo = true;
                //ClicFila = false;
            }
            else
            {
                escribiendo = false;
                factenter = 0;
            }
            
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    txtCantidad.Text = Funcion.reemplazarcaracterViceversa(txtCantidad.Text);
                    if (Convert.ToSingle(txtCantidad.Text)>0)
                    {
                        cantactual = txtCantidad.Text;
                        float iva = 0.0f;
                        if (VerificarPrecios(Convert.ToSingle(txtPrecio.Text)))
                        {
                            if (estadoiva)
                            {
                                if (rdbCaja.Checked)
                                {
                                    if (Convert.ToSingle(txtBodega.Text) >= Convert.ToSingle(txtCantidad.Text))
                                    {
                                        iva = ((Convert.ToSingle(PrecioTodoslosDecimales) * Convert.ToSingle(txtCantidad.Text)) * ivaporcentaje) / 100;
                                        txtIvaPrecio.Text = iva.ToString("#####0.00");
                                        if (tipoprecio == 1)
                                        {
                                            factproducto(iva, 1);
                                        }
                                        else
                                        {
                                            if (tipoprecio == 0)
                                            {
                                                factproducto(iva, 1);
                                            }
                                            else
                                            {
                                                if (tipoprecio == 2)
                                                {
                                                    factproducto(iva, 1);
                                                }

                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El Stock del Producto\n\rExistente es de " + Convert.ToSingle(txtBodega.Text) + " unidades");
                                        txtCantidad.Focus();
                                        pr = false;
                                    }
                                }
                                else //////////// Iva O%
                                {
                                    if (Convert.ToSingle(txtBodega.Text) >= Convert.ToSingle(txtCantidad.Text))
                                    {
                                        iva = ((Convert.ToSingle(PrecioTodoslosDecimales) * Convert.ToSingle(txtCantidad.Text)) * ivaporcentaje) / 100;
                                        txtIvaPrecio.Text = iva.ToString("#####0.00");
                                        if (tipoprecio == 1)
                                        {
                                            factproducto(iva, 1);
                                        }
                                        else
                                        {
                                            if (tipoprecio == 0)
                                            {
                                                factproducto(iva, 1);
                                            }
                                            else
                                            {
                                                if (tipoprecio == 2)
                                                {
                                                    factproducto(iva, 1);
                                                }

                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El Stock del Producto\n\rExistente es de " + Convert.ToSingle(txtBodega.Text) + " unidades");
                                        txtCantidad.Focus();
                                        pr = false;
                                    }
                                }




                            }
                            else
                            {
                                Producto.Iva = 0;
                                if (rdbCaja.Checked)
                                {
                                    if (Convert.ToSingle(txtBodega.Text) >= Convert.ToSingle(txtCantidad.Text) )
                                    {
                                        if (tipoprecio == 1)
                                        {
                                            factproducto(iva, 2);
                                        }
                                        else
                                        {
                                            if (tipoprecio == 0)
                                            {
                                                factproducto(iva, 2);
                                                //txtCodigo.Focus();
                                            }
                                            else
                                            {
                                                if (tipoprecio == 2)
                                                {
                                                    factproducto(iva, 2);
                                                    //  txtCodigo.Focus();
                                                }

                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El Stock del Producto\n\rExistente es de " + Convert.ToSingle(txtBodega.Text) + " unidades");
                                        txtCantidad.Focus();
                                        pr = false;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToSingle(txtBodega.Text) >= Convert.ToSingle(txtCantidad.Text))
                                    {
                                        if (tipoprecio == 1)
                                        {
                                            factproducto(iva, 2);
                                        }
                                        else
                                        {
                                            if (tipoprecio == 0)
                                            {
                                                factproducto(iva, 2);
                                                //txtCodigo.Focus();
                                            }
                                            else
                                            {
                                                if (tipoprecio == 2)
                                                {
                                                    factproducto(iva, 2);
                                                    //  txtCodigo.Focus();
                                                }

                                            }
                                        }
                                        // Producto.Iva = 0;
                                    }
                                    else
                                    {
                                        MessageBox.Show("El Stock del Producto\n\rExistente es de " + txtBodega.Text + " unidades");
                                        //SendKeys.Send("{up}");
                                        txtCantidad.Focus();
                                        pr = false;
                                    }
                                }


                            }
                        }
                        else
                        {
                            MessageBox.Show("Este Producto no puede ser vendido el precio está en cero. ");
                            //txtCantidad.Focus();
                            LimpiarTexbox();
                            pr = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ingresa una cantidad diferente de cero.");
                        txtCantidad.Text = "";
                        txtCantidad.Focus();
                    }
                    // }
                }
                else
                {
                    Funcion.SoloValores(e,txtCantidad.Text);
                }
               // LimpiarTexbox();
            }
            catch (Exception EX)
            {

                //MessageBox.Show(EX.Message);
            }

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (txtCantidad.Text[0] != '0')
                {
                    
                    if (estadoiva)
                    {
                        float iva = ((Convert.ToSingle(PrecioTodoslosDecimales) * Convert.ToSingle(txtCantidad.Text)) * ivaporcentaje) / 100;
                        txtIvaPrecio.Text = iva.ToString("#####0.00");
                    }
                }
               
                
            }
            catch (Exception)
            {

                //throw;
            }
            
        }

        private void dgvDetalleProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDetalleProductos.CurrentCell != this.dgvDetalleProductos.CurrentRow.Cells[7])
                {
                    dgvDetalleProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                    txtCodigo.Focus();
                }
                else
                {
                    //if (dgvDetalleProductos.Rows[e.RowIndex].Cells[0].Value==null)
                    //{
                    //    dgvDetalleProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                    //}
                }
            }
            catch (Exception)
            {

                txtCodigo.Focus();
            }
          
        }

        private void FrmFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.FormularioVentaAbierto = false;
            this.Dispose(true);
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BtnConsultarPrecio_Click(object sender, EventArgs e)
        {
            FrmConsultarPrecios frmPrecios = new FrmConsultarPrecios();
            frmPrecios = new FrmConsultarPrecios();
            frmPrecios.ShowDialog();
        }

        private void ChkTodoBodega_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ChkTodoBodega.Checked)
                {
                    for (int i = 0; i < dgvDetalleProductos.Rows.Count; i++)
                    {
                        if (dgvDetalleProductos.Rows[i].Cells[0].Value != null)
                        {
                            dgvDetalleProductos.Rows[i].Cells[7].Value = true;
                        }

                    }
                }
                else
                {
                    for (int i = 0; i < dgvDetalleProductos.Rows.Count; i++)
                    {
                        if (dgvDetalleProductos.Rows[i].Cells[0].Value != null)
                        {
                            dgvDetalleProductos.Rows[i].Cells[7].Value = false;
                        }

                    }
                }

                //FrmFactura_Activated(null, null);
            }
            catch (Exception)
            {

            }
        }

        private void dgvDetalleProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvDetalleProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                txtCodigo.Focus();
            }
            catch (Exception)
            {

            }
            
        }

        private void dgvDetalleProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvDetalleProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                txtCodigo.Focus();
            }
            catch (Exception)
            {
            }
            

        }

        private void dgvDetalleProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (dgvDetalleProductos.Focus())
                {
                    if (codigos.Count>0)
                    {
                        if (MessageBox.Show("¿Deseas Grabar esta Factura?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            grabarfact();
                        }
                        else
                        {
                            txtCodigo.Focus();
                        }
                    }
                    
                }
            }
        }

        private bool verificarindex(int inde)
        {
            bool b = false;
            for (int i = 0; i < indezp.Count; i++)
            {
                if (indezp[i]==inde)
                {
                    posindexp = i;
                    b = true;
                }
            }
            return b;
        }

        private void ObtenerPedidos()
        {
            try
            {
                for (int i = 0; i < dgvDetalleProductos.RowCount; i++)
                {
                    if (dgvDetalleProductos.Rows[i].Cells[0].Value!=null && dgvDetalleProductos.Rows[i].Cells[1].Value!=null)
                    {
                        if (Convert.ToBoolean(dgvDetalleProductos.Rows[i].Cells[7].Value))
                        {
                            pedidos.Add("" + dgvDetalleProductos.Rows[i].Cells[1].Value + ";" + dgvDetalleProductos.Rows[i].Cells[2].Value);
                            indezp.Add(i);
                        }
                    }
                    else
                    {

                        break;
                    }
                   
                   
                }
            }
            catch (Exception)
            {

                //throw;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigos.Count==0)
                {
                    hayfactenespera = false;
                    for (int i = 0; i < retencionfact.Count; i++)
                    {
                        // codigos.Add(retencionfact[i].Codigobarra);
                        dgvDetalleProductos.Rows[i].Cells[0].Value = retencionfact[i].Codigobarra;
                        dgvDetalleProductos.Rows[i].Cells[1].Value = retencionfact[i].Nombreproducto;
                        dgvDetalleProductos.Rows[i].Cells[2].Value = retencionfact[i].Cantidad;
                        dgvDetalleProductos.Rows[i].Cells[3].Value = retencionfact[i].Cantidad1;
                        dgvDetalleProductos.Rows[i].Cells[4].Value = retencionfact[i].Preciopublico_sin_iva;
                        dgvDetalleProductos.Rows[i].Cells[5].Value = retencionfact[i].Precioporcaja_sin_iva;
                        dgvDetalleProductos.Rows[i].Cells[6].Value = retencionfact[i].Precioalmayor_sin_iva;
                        //dgvDetalleProductos.Rows[i].Cells[9].Value = Convert.ToInt32(retencionfact[i].LibreImpuesto);
                        //dgvDetalleProductos.Rows[i].Cells[8].Value = Convert.ToSingle(retencionfact[i].Caja);
                        dgvDetalleProductos.Rows[i].Cells[10].Value = retencionfact[i].Preciopublico_iva;
                        dgvDetalleProductos.Rows.Add();
                    }
                    if (tipoprecio1 == 0)
                    {
                        rdbPublico.Checked = true;
                    }
                    else
                    {
                        if (tipoprecio1 == 1)
                        {
                            rdbMayorista.Checked = true;
                        }
                        else
                        {
                            rdbCaja.Checked = true;
                        }
                    }

                    //Ivas = Ivas1;
                    for (int i = 0; i < Ivas1.Count; i++)
                    {
                        Ivas.Add(Ivas1[i]);
                    }
                    //codigos = codigosfactespe;

                    for (int i = 0; i < codigosfactespe.Count; i++)
                    {
                        codigos.Add(codigosfactespe[i]);
                    }

                    for (int i = 0; i < indezpfactespe.Count; i++)
                    {
                        indezp.Add(indezpfactespe[i]);
                    }
                    //indezp = indezpfactespe;
                    idcliente = idclienteespe;

                    for (int i = 0; i < DatosClientefactespe.Count; i++)
                    {
                        DatosCliente.Add(DatosClientefactespe[i]);
                    }
                   // DatosCliente = DatosClientefactespe;

                    //AQUI SALE MAL

                    if (DatosCliente[0] != "9999999999999")
                    {
                        rdbFacturaDatos.Checked = true;
                        txtIdentidicacion.Text = DatosCliente[0];
                        txtConsumidor.Text = DatosCliente[1];
                        txtCodigo.Focus();
                    }
                    else
                    {
                        rdbConsumidorFinal.Checked = true;
                    }

                    Calcular();
                    btnActivarFact.Enabled = false;
                    btnFactEspera.Enabled = true;
                    contador = 0;
                    txtCodigo.Focus();
                   

                    //Reiniciar datos
                    DatosClientefactespe.Clear();
                    codigosfactespe.Clear();
                    Ivas1.Clear();
                    indezpfactespe.Clear();
                    idclienteespe = 0;
                    DatosClientefactespe = new List<string>();
                    Ivas1 = new List<string>();
                    codigosfactespe = new List<string>();
                    indezpfactespe = new List<int>();
                    verificadorfrm = 78;
                }
                else
                {
                    MessageBox.Show("Estas creando una nueva factura. No se puede restaurar la factura anterior.");
                    txtCodigo.Focus();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(""+ex.Message);
            }
            
        }

        private void dgvDetalleProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (codigos.Count > 0)
            {
                if (dgvDetalleProductos.Rows[e.RowIndex].Cells[0].Value!=null)
                {
                    fila = e.RowIndex;
                    //dgvDetalleProductos.Rows[fila].Selected = true;
                    s = new FrmClaveSupervisor();
                    s.ShowDialog();
                    txtCodigo.Focus();
                    eliminarFilas();
                    //FrmFactura_Activated(null, null);
                }
            }
            else
            {
                txtCodigo.Focus();
            }
        }

        private void eliminarFilas()
        {
            try
            {
                if (correcta == 1)
                {
                    dgvDetalleProductos.Rows.RemoveAt(fila);
                    codigos.RemoveAt(fila);
                    Ivas.RemoveAt(fila);
                    if (codigos.Count > 0)
                    {
                        Calcular();
                    }
                   
                    LimpiarTexbox();
                    verificadorfrm = 0;
                    correcta = 100;

                }
                else
                {
                    correcta = 100;
                    dgvDetalleProductos.Rows[codigos.Count - 1].Selected = true;
                }
                txtCodigo.Focus();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private bool verificarcodigos(string codigo)
        {
            bool b = false;
            String[] vector;
            if (codigos.Count>0)
            {
                for (int i = 0; i <codigos.Count; i++)
                {
                    vector = codigos[i].Split(';');
                    if (vector[0].Equals(codigo) && vector[1].Equals(Convert.ToString(tipoprecio)))
                    {
                        cantidadanterior = Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[2].Value.ToString());
                        posicion = i;
                        b =true;
                        break;
                        
                    }
                }
            }
           
           return b;
        }
             
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigos.Count > 0)
                {
                    hayfactenespera = true;
                    retencionfact = new List<Producto>();
                    for (int i = 0; i < codigos.Count; i++)
                    {
                        if (dgvDetalleProductos.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            Producto p = new Producto();
                            p.Codigobarra = dgvDetalleProductos.Rows[i].Cells[0].Value.ToString();
                            p.Nombreproducto = dgvDetalleProductos.Rows[i].Cells[1].Value.ToString();
                            p.Cantidad = Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[2].Value.ToString());
                            p.Cantidad1 = Convert.ToInt32(dgvDetalleProductos.Rows[i].Cells[3].Value.ToString());
                            p.Preciopublico_sin_iva = Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[4].Value.ToString());
                            p.Precioporcaja_sin_iva = Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[5].Value.ToString());
                            p.Precioalmayor_sin_iva = Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[6].Value.ToString());
                            //p.LibreImpuesto = Convert.ToBoolean(Convert.ToInt32(dgvDetalleProductos.Rows[i].Cells[9].Value));
                            //p.Caja= Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[8].Value.ToString());
                            p.Preciopublico_iva= Convert.ToSingle(dgvDetalleProductos.Rows[i].Cells[10].Value.ToString()); 
                            
                            retencionfact.Add(p);
                        }

                    }

                    if (DatosClientefactespe.Count>0)
                    {
                        DatosClientefactespe.Clear();
                    }

                    if (rdbConsumidorFinal.Checked)
                    {
                        DatosClientefactespe.Add("9999999999999");
                       DatosClientefactespe.Add("Consumidor Final");
                    }
                    else
                    {
                        for (int i = 0; i < DatosCliente.Count; i++)
                        {
                            DatosClientefactespe.Add(DatosCliente[i]);
                        }
                        //DatosClientefactespe = DatosCliente;
                    }

                    RecogerDatosAnteriores();
                   
                    btnActivarFact.Enabled = true;
                    btnFactEspera.Enabled = false;
                    factEspe = 0;
                    //nuevafact();
                    //tipoprecio1 = tipoprecio;
                    contador=1;
                    idclienteespe = idcliente;
                    FacturaenEspera();
                }
                // FacturaenEspera();
                rdbConsumidorFinal.Focus();
                txtCodigo.Focus();
                
                //factEspe = 0;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }
        }

        private void RecogerDatosAnteriores()
        {
            if (Ivas.Count>0)
            {
                for (int i = 0; i < Ivas.Count; i++)
                {
                    Ivas1.Add(Ivas[i]);
                }
            }
            if (codigos.Count>0)
            {
                for (int i = 0; i < codigos.Count; i++)
                {
                    codigosfactespe.Add(codigos[i]);
                }
            }
            if (indezp.Count>0)
            {
                for (int i = 0; i < indezp.Count; i++)
                {
                    indezpfactespe.Add(indezp[i]);
                }
            }
           

        }

        private void FacturaenEspera()
        {
            txtNumFact.Text = numfact.ToString("D9");
            rdbPublico.Checked = true;
            rdbConsumidorFinal.Checked = true;
            //ckbEfectivo.Checked = true;
            //ckbCredito.Checked = false;
            dgvDetalleProductos.Rows.Clear();
            lblTotalPagar.Text = "0.00";
            txtSubTotalcero.Text = "0.00";
            txtSubTotalIva.Text = "0.00";
            txtSubTotal.Text = "0.00";
            txtIva.Text = "0.00";
            idcliente = IDCLIENTEINICIO;
            codigos.Clear();
            DatosCliente.Clear();
            Ivas.Clear();
            indezp.Clear();
            listatipo.Clear();


            for (int i = 0; i < 27; i++)
            {
                dgvDetalleProductos.Rows.Add();
            }
            txtCodigo.Focus();
        }

        private void rdbPublico_CheckedChanged(object sender, EventArgs e)
        {
            tipoprecio = 0;
        }

        private void rdbMayorista_CheckedChanged(object sender, EventArgs e)
        {
            tipoprecio = 1;
        }

        private void dgvDetalleProductos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            Funcion.ValidarNumerosStock(e, dgvDetalleProductos);
        }

        private void FrmFactura_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    if (codigos.Count>0)
                    {
                        verificadorfrm = 0;
                        if (MessageBox.Show("¿Deseas Grabar esta Factura?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            grabarfact();
                        }
                        else
                        {
                            txtCodigo.Focus();
                            LimpiarTexbox();
                        }
                    }
                    
                    break;
                case Keys.F3:
                    
                    if (rdbFacturaDatos.Checked)
                    {
                        rdbConsumidorFinal.Checked = true;
                        rdbFacturaDatos.Checked = false;
                    }
                    else 
                    {
                        rdbFacturaDatos.Checked = true;
                        rdbConsumidorFinal.Checked = false;
                    }
                   
                    break;
               
                case Keys.F5:
                    if (rdbMayorista.Checked)
                    {
                        rdbMayorista.Checked = false;
                        rdbPublico.Checked = false;
                        rdbCaja.Checked = true;
                    }
                    else
                    {
                        if (rdbPublico.Checked)
                        {
                            rdbMayorista.Checked = true;
                            rdbPublico.Checked = false;
                            rdbCaja.Checked = false;
                        }
                        else
                        {
                            rdbMayorista.Checked = false;
                            rdbPublico.Checked = true;
                            rdbCaja.Checked = false;
                        }
                        
                    }
                    break;
                case Keys.F6:
                    // DatosClienteAUX = DatosCliente;
                    FrmConsultarProducto FrmConsultarProduct = new FrmConsultarProducto();
                    //if (FrmConsultarProduct == null || FrmConsultarProduct.IsDisposed)
                    //{
                    //FrmConsultarProduct = new FrmConsultarProducto();
                    //FrmConsultarProduct.MdiParent = Program.panelPrincipalVariable;
                    //FrmConsultarProduct.BringToFront();
                    FrmConsultarProduct.ShowDialog();

                    //}
                   
                    if (DatosProducto.Count>0)
                    {
                        txtCantidad.Text = "1";
                        txtCantidad.Focus();
                        verificadorfrm = 2;
                       // FrmFactura_Activated(null, null);
                        if (DatosProducto.Count > 0)
                        {
                            CogerProductos();
                            //DatosProducto.Clear();
                           // DatosCliente = DatosClienteAUX;
                        }
                    }
                    else
                    {
                        txtCodigo.Focus();
                    }
                    
                    break;
                case Keys.F7:
                    break;
                case Keys.F8:
                    break;
                //case Keys.F9:
                //    nuevafact();
                //    break;
                case Keys.F10:
                    FrmCierreCaja FrmCierreCaja = new FrmCierreCaja();
                    FrmCierreCaja.ShowDialog();
                    break;
                case Keys.F11:
                    break;
                

            }
        }

        private void grabarfact()
        {
            Double tpagar = Convert.ToDouble(Funcion.reemplazarcaracterViceversa(lblTotalPagar.Text));
            if (tpagar >= 200 && txtIdentidicacion.Text == "9999999999999")
            {
                MessageBox.Show("Factura obligatoria con datos.");
                rdbFacturaDatos.Checked = true;
            }
            else
            {
            Program.em = new EmcabezadoFactura();
            Program.em.Sucursal = int.Parse(txtSucursal.Text);
            //Program.em.Descuento = Convert.ToSingle(txtDescuento.Text);
            Program.em.Caja = int.Parse(txtCaja.Text);
            Program.em.Fecha = DateTime.Now.Date.ToShortDateString();
            Program.em.Hora = DateTime.Now.TimeOfDay.ToString();
            //Program.em.Iva = Convert.ToSingle(txtIva.Text);
            Program.em.Idempleado = int.Parse(Program.IDUsuario);
            Program.em.Idcliente = idcliente;

            Program.em.Numfact = numfact;

            //Consultas objCns = new Consultas();
            // objCns.Insertar("INSERT INTO TbEncabezadoFactura (SUCURSAL,CAJA,NFACTURA,FECHA,HORA,DESCUENTO,IVA,IDEMPLEADO,IDCLIENTE) VALUES ('" + txtSucursal.Text + "','" + txtCaja.Text + "','"+txtNumFact.Text+"','"+Program.FecaInicio+"','"+ DateTime.Now.Date.ToShortDateString()+"','"+ DateTime.Now.TimeOfDay.ToString()+"','0','"+txtIva.Text+"','"+Program.IDUsuario+"','"+idcliente+"'"+ ");");
            //List<>
            frmcobrar = new FrmCobrar();
            frmcobrar.nombre = txtConsumidor.Text;
            frmcobrar.identificacion = txtIdentidicacion.Text;
            frmcobrar.descuentobd = txtDescuento.Text;
            frmcobrar.direccionComprador = direccionComprador;
            frmcobrar.ivabd = txtIva.Text;
            frmcobrar.subtotal = txtSubTotal.Text;
            frmcobrar.subtotalconiva = txtSubTotalIva.Text;
            frmcobrar.subtotalcero = txtSubTotalcero.Text;
            frmcobrar.descuento = txtDescuento.Text;
            frmcobrar.totalapagar = txtSubTotal.Text;
            frmcobrar.ivasuma = txtIva.Text;

            frmcobrar.total = Convert.ToSingle(txtSubTotal.Text);
            frmcobrar.dg = dgvDetalleProductos;
            frmcobrar.totalfilas = codigos.Count;
            ObtenerPedidos();
            frmcobrar.pedidos = pedidos;
            frmcobrar.ivas = Ivas;
            frmcobrar.DatosCliente = DatosCliente;
            frmcobrar.ShowDialog();
                facturaNueva();
            //FrmFactura_Activated(null, null);
            //    if (DatosCliente.Count>0)
            //    {
            //        DatosCliente.Clear();
            //    }

                //nuevafact();
            }
            ChkTodoBodega.Checked = false;
        }

        private void facturaNueva()
        {
            try
            {
                if (verificadorfrm == 3)
                {
                    //factEspe = 0;
                    //if (DatosCliente.Count>0)
                    //{
                    //    DatosCliente.Clear();
                    //}
                    nuevafact();

                }
                else
                {
                    //factEspe = 1;
                    //nuevafact();
                    escribiendo = false;
                    factenter = 0;
                }
                txtCodigo.Focus();
            }
            catch (Exception)
            {

                //throw;
            }
            
        }

        private void nuevafact()
        {
            verificadorfrm = 0;
            Consultas Objconsul = new Consultas();
            //String AUXNUMEROFACTURA = numfact.ToString("D8");
            //MessageBox.Show("" + codigos.Count);
            //if (factEspe == 1)
            //{
            //numfact += 1;
                //DatosCliente.Clear();
                //Ivas.Clear();
            //}

            

            txtNumFact.Text = numfactnuevo.ToString("D9");
            if (Objconsul.EjecutarSQL("UPDATE [dbo].[TbCajasTalonario] SET [DOCUMENTOACTUAL] = '" + txtNumFact.Text + "'  WHERE  SERIE2 = '" + txtCaja.Text + "' and SERIE1= '" + txtSucursal.Text + "';"))
            {
                numfact = numfactnuevo;
            }
            rdbPublico.Checked = true;
            rdbConsumidorFinal.Checked = true;
            //ckbEfectivo.Checked = true;
            //ckbCredito.Checked = false;
            dgvDetalleProductos.Rows.Clear();
            lblTotalPagar.Text = "0.00";
            txtSubTotalcero.Text = "0.00";
            txtSubTotalIva.Text = "0.00";
            txtSubTotal.Text = "0.00";
            txtIva.Text = "0.00";

           
            codigos.Clear();
            DatosCliente.Clear();
            Ivas.Clear();
            indezp.Clear();
            listatipo.Clear();
            //Posible error
            indezp = new List<int>();
            listatipo = new List<string>();
            //Fin posible error

            DatosCliente = new List<string>();
            Ivas = new List<string>();
            codigos= new List<string>();
            if (!hayfactenespera)
            {
                Ivas1.Clear();
                indezpfactespe.Clear();
                DatosClientefactespe.Clear();
                codigosfactespe.Clear();
                idcliente = IDCLIENTEINICIO;

                //posible error
                Ivas1 = new List<string>();
                indezpfactespe = new List<int>();
                DatosClientefactespe = new List<string>();
                codigosfactespe = new List<string>();
                //fin porsible error
            }
            
            

            btnFactEspera.Enabled = false;
            //btnEliminarFact.Enabled = false;
            factenter = 0;
            //MessageBox.Show(""+codigos.Count);
            for (int i = 0; i < 27; i++)
            {
                dgvDetalleProductos.Rows.Add();
            }
            if (DatosProducto.Count>=0)
            {
                DatosProducto.Clear();
                DatosProducto = new List<string>();
            }
            txtCodigo.Focus();
        }

        private void rdbCaja_CheckedChanged(object sender, EventArgs e)
        {
            tipoprecio = 2;
        }

    }
}
