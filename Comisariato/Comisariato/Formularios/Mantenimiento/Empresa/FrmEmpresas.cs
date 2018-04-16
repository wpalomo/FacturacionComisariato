using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Comisariato.Clases;

namespace Comisariato.Formularios
{
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        Consultas consultas;
        String GlobalRuc = "";
        bool bandera_Estado = false;
        public static String nameLogo = "";
        public static String nameFondo = "";
        byte[] AuxMyDataImagenLogo = new byte[0];
        byte[] AuxMyDataImagenFondo = new byte[0];
        public void inicializarDatos()
        {
            tcEmpresa.SelectedIndex = 0; //Seleccion el tab a mostrarse
            pbLogoEmpresa.Image = Comisariato.Properties.Resources.contact;
            pbfondoPantallaEmpresa.Image = Comisariato.Properties.Resources.contact;
            //limpiar los textbox
            txtRUCEmpresa.Text = "";
            txtNombreEmpresa.Text = "";
            txtNombreComercialEmpresa.Text = "";
            txtRazonSocialEmpresa.Text = "";
            txtGerenteEmpresa.Text = "";
            txtDireccionEmpresa.Text = "";
            txtEmailEmpresa.Text = "";
            txtCeluar1Empresa.Text = "";
            txtCelular2Empresa.Text = "";
            txtRUCContadorEmpresa.Text = "";
            txtNombreContadorempresa.Text = "";
            txtEmailContadorEmpresa.Text = "";
            txtCelular1ContadorEmpresa.Text = "";
            txtCelular2ContadorEmpresa.Text = "";
            txtClaveUsuario.Text = "";

            //// llenar datadrigview solo los activos
            cargarDatos();
        }

        private void cargarDatos(/*string condicion*/)
        {
            consultas = new Consultas();
            consultas.boolLlenarDataGridView(dgvDatosEmpresa, "Select IDEMPRESA as ID, NOMBRE as 'Nombre Empresa', GERENTE as 'Gerente', RUC, CELULAR1, CELULAR2,EMAIL,DIRECCION, NOMBRECONTADOR AS 'NOMBRE CONTADOR', RUCCONTADOR AS 'RUC CONTADOR', FECHAINICIOCONTABLE AS 'F. Inicio Cont.'  from TbEmpresa ;");
            dgvDatosEmpresa.Columns["ID"].Visible = false;
            dgvDatosEmpresa.Columns["CELULAR1"].Visible = false;
            dgvDatosEmpresa.Columns["DIRECCION"].Visible = false;
            dgvDatosEmpresa.Columns["CELULAR2"].Visible = false;
            dgvDatosEmpresa.Columns["NOMBRE CONTADOR"].Visible = false;
            dgvDatosEmpresa.Columns["CELULAR2"].Visible = false;
            dgvDatosEmpresa.Columns["RUC CONTADOR"].Visible = false;
        }
        private void FrmEmpresas_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        //--------------------------------------------BUSCAR IMAGEN--------------------------------------
        private void btnBuscarLogoEmpresa_Click(object sender, EventArgs e)
        {
            //Dimension de 247*176
            OpenFileDialog BuscarLogo = new OpenFileDialog();
            BuscarLogo.Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg";
            if (BuscarLogo.ShowDialog() == DialogResult.OK)
            {
                nameLogo = BuscarLogo.FileName;
                pbLogoEmpresa.Image = Image.FromFile(BuscarLogo.FileName);
                pbLogoEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btnBuscarFondoEmpresa_Click(object sender, EventArgs e)
        {
            //Dimension 1098x585
            OpenFileDialog BuscarFondoPantalla = new OpenFileDialog();
            BuscarFondoPantalla.Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg";
            // Aquí incluiremos los filtros que queramos.
            BuscarFondoPantalla.FileName = "";
            BuscarFondoPantalla.Title = "Titulo del Dialogo";
            //BuscarFondoPantalla.InitialDirectory = "C:\\";
            if (BuscarFondoPantalla.ShowDialog() == DialogResult.OK)
            {
                nameFondo = BuscarFondoPantalla.FileName;
                //this.pbfondoPantallaEmpresa.ImageLocation = Direccion;
                pbfondoPantallaEmpresa.Image = Image.FromFile(nameFondo);
                //Pueden usar tambien esta forma para cargar la Imagen solo activenla y comenten la linea donde se cargaba anteriormente 
                //this.pictureBox1.ImageLocation = textBox1.Text;
                pbfondoPantallaEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btnGuardarEmpresa_Click(object sender, EventArgs e)
        {
            byte[] bitDataLogo = null;
            byte[] bitDataFondo = null;


            if (txtNombreEmpresa.Text != "" && txtRUCEmpresa.Text != "" && txtNombreComercialEmpresa.Text != "" && txtRazonSocialEmpresa.Text != "" && txtGerenteEmpresa.Text != "" && txtEmailEmpresa.Text != "" && txtCeluar1Empresa.Text != "" && txtClaveUsuario.Text!="")
            {

                if (nameLogo != "")
                {
                    Image img1 = pbLogoEmpresa.Image;
                    bitDataLogo = Funcion.imgToByteArray(img1);
                }
                if (nameFondo != "")
                {
                    Image img2 = pbfondoPantallaEmpresa.Image;
                    bitDataFondo = Funcion.imgToByteArray(img2);
                }
                Empresa ObjEmpresa = new Empresa(txtNombreEmpresa.Text, txtRUCEmpresa.Text, txtNombreComercialEmpresa.Text, txtRazonSocialEmpresa.Text, txtGerenteEmpresa.Text, txtDireccionEmpresa.Text, txtEmailEmpresa.Text, dtpFechaInicioContableEmpresa.Value, txtCeluar1Empresa.Text, txtCelular2Empresa.Text, txtRUCContadorEmpresa.Text, txtNombreContadorempresa.Text, txtEmailContadorEmpresa.Text, txtCelular1ContadorEmpresa.Text, txtCelular2ContadorEmpresa.Text, bitDataLogo, bitDataFondo,txtClaveUsuario.Text);

                if (!bandera_Estado) // Para identificar si se va ingresar
                {
                    String resultado = ObjEmpresa.Insertarempresa(ObjEmpresa); // retorna true si esta correcto todo
                    if (resultado == "Datos Guardados")
                    {
                        MessageBox.Show("Empresa Registrada Correctamente ", "Exito", MessageBoxButtons.OK);
                        //rbtActivosEmpresa.Checked = true;
                        Program.razonsocialempresa = txtRazonSocialEmpresa.Text;
                        Program.rucempresa = txtRUCEmpresa.Text;
                        Program.direccionempresa = txtDireccionEmpresa.Text;

                        inicializarDatos();
                        cargarDatos();
                    }
                    else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else if (resultado == "Existe") { MessageBox.Show("Ya Existe el Empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else if (bandera_Estado) // Para identificar si se va modificar
                {
                    String Resultado = ObjEmpresa.ModificarEmpresa(GlobalRuc); // retorna true si esta correcto todo
                    if (Resultado == "Correcto")
                    {
                        MessageBox.Show("Empresa Actualizada", "Exito");
                        //rbtActivosEmpleado.Checked = true;
                        Program.razonsocialempresa = txtRazonSocialEmpresa.Text;
                        Program.rucempresa = txtRUCEmpresa.Text;
                        Program.direccionempresa = txtDireccionEmpresa.Text;
                        GlobalRuc = "";
                    }
                    else { MessageBox.Show("Error al actualizar la Empresa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    inicializarDatos();
                    bandera_Estado = false;
                    btnGuardarEmpresa.Text = "&Guardar";
                    btnLimpiarEmpresa.Text = "&Limpiar";
                }
            }
            else { MessageBox.Show("Ingrese los datos de la Empresa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnLimpiarEmpresa_Click(object sender, EventArgs e)
        {
            if (btnLimpiarEmpresa.Text == "&Cancelar")
            {
                inicializarDatos();
                btnLimpiarEmpresa.Text = "&Limpiar";
                btnGuardarEmpresa.Text = "&Guardar";
            }
            else { inicializarDatos(); }
            bandera_Estado = false;
        }


        private void txtConsultarEmpresa_TextChanged(object sender, EventArgs e)
        {
            //if (rbtActivosEmpresa.Checked)
            //{
                consultas.boolLlenarDataGridView(dgvDatosEmpresa, "Select IDEMPRESA as ID, NOMBRE as 'NOMBRE EMPRESA', GERENTE, RUC, CELULAR1, CELULAR2,EMAIL,DIRECCION, NOMBRECONTADOR AS 'NOMBRE CONTADOR', RUCCONTADOR AS 'RUC CONTADOR', FECHAINICIOCONTABLE AS 'FECHA INICIO CONTABLE'  from TbEmpresa where   RUC like '%" + txtConsultarEmpresa.Text + "%' or NOMBRE like '%" + txtConsultarEmpresa.Text + "%' or RAZONSOCIAL like '%" + txtConsultarEmpresa.Text + "%' or NOMBRECOMERCIAL like '%" + txtConsultarEmpresa.Text + "%' ;");
                //dgvDatosEmpresa.Columns[1].HeaderText = "Desabilitar";
                dgvDatosEmpresa.Columns["ID"].Visible = false;
            //}
            //else if (rbtInactivosEmpresa.Checked)
            //{
            //consultas.boolLlenarDataGridView(dgvDatosEmpresa, "Select * from TbEmpresa where ACTIVO = 0 and IDENTIFICACION like '%" + txtConsultarEmpresa + "%' or NOMBRES like '%" + txtConsultarEmpresa.Text + "%' or APELLIDOS like '%" + txtConsultarEmpresa.Text + "%';");
            //dgvDatosEmpresa.Columns[1].HeaderText = "Habilitar";
                //dgvDatosEmpresa.Columns["ID"].Visible = false;
            //}
        }

        private void dgvDatosEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Empleado ObjEmpleado = new Empleado();

                if (this.dgvDatosEmpresa.Columns[e.ColumnIndex].Name == "Modificar")
                {
                    //MessageBox.Show("modificar toca " + DgvDatosEmpleado.CurrentRow.Cells[3].Value.ToString());
                    GlobalRuc = dgvDatosEmpresa.CurrentRow.Cells[4].Value.ToString();
                    inicializarDatos();
                    tcEmpresa.SelectedIndex = 0;
                    bandera_Estado = true;
                    //Llenar el DataTable
                    DataTable dt = consultas.BoolDataTable("Select * from TbEmpresa where RUC = '" + GlobalRuc + "'");
                    //Arreglo de byte en donde se almacenara la foto en bytes
                    byte[] MyDataLogo = new byte[0];
                    byte[] MyDataFondo = new byte[0];
                    //Verificar si tiene Datos
                    if (dt.Rows.Count > 0)
                    {
                        DataRow myRow = dt.Rows[0];
                        MemoryStream stream;
                        //Se almacena el campo foto de la tabla en el arreglo de bytes

                        if (myRow["LOGO"] != System.DBNull.Value)
                        {
                            MyDataLogo = (byte[])myRow["LOGO"];
                            AuxMyDataImagenLogo = MyDataLogo;
                            //Se inicializa un flujo en memoria del arreglo de bytes
                            stream = new MemoryStream(MyDataLogo);
                            //En el picture box se muestra la imagen que esta almacenada en el flujo en memoria 
                            //el cual contiene el arreglo de bytes
                            pbLogoEmpresa.Image = Image.FromStream(stream);
                            stream.Dispose();
                        }
                        if (myRow["FONDOPANTALLA"] != System.DBNull.Value)
                        {
                            MyDataFondo = (byte[])myRow["FONDOPANTALLA"];
                            AuxMyDataImagenFondo = MyDataFondo;
                            stream = new MemoryStream(MyDataFondo);
                            pbfondoPantallaEmpresa.Image = Image.FromStream(stream);
                            stream.Dispose();
                        }

                        if (myRow["CLAVESUPERVISOR"] != System.DBNull.Value)
                        {
                            txtClaveUsuario.Text = myRow["CLAVESUPERVISOR"].ToString();
                        }

                        //Cargar los demas Datos
                        txtNombreEmpresa.Text = myRow["NOMBRE"].ToString();
                        txtRUCEmpresa.Text = myRow["RUC"].ToString();
                        txtNombreComercialEmpresa.Text = myRow["NOMBRECOMERCIAL"].ToString();
                        txtRazonSocialEmpresa.Text = myRow["RAZONSOCIAL"].ToString();
                        txtGerenteEmpresa.Text = myRow["GERENTE"].ToString();
                        txtDireccionEmpresa.Text = myRow["DIRECCION"].ToString();
                        txtEmailEmpresa.Text = myRow["EMAIL"].ToString();
                        if (myRow["FECHAINICIOCONTABLE"].ToString() != "")
                            dtpFechaInicioContableEmpresa.Value = Convert.ToDateTime(myRow["FECHAINICIOCONTABLE"]);
                        txtCeluar1Empresa.Text = myRow["CELULAR1"].ToString();
                        txtCelular2Empresa.Text = myRow["CELULAR2"].ToString();
                        txtRUCContadorEmpresa.Text = myRow["RUCCONTADOR"].ToString();
                        txtNombreContadorempresa.Text = myRow["NOMBRECONTADOR"].ToString();
                        txtEmailContadorEmpresa.Text = myRow["EMAILCONTADOR"].ToString();
                        txtCelular1ContadorEmpresa.Text = myRow["CELULAR1CONTADOR"].ToString();
                        txtCelular2ContadorEmpresa.Text = myRow["CELULAR2CONTADOR"].ToString();

                    }
                    btnLimpiarEmpresa.Text = "&Cancelar";
                    btnGuardarEmpresa.Text = "&Modificar";

                }

            }
            catch (Exception)
            {

            }

        }

        private void txtNombreEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtRUCEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void txtNombreComercialEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion.ValidarLetrasPuntoNumero(e, txtRazonSocialEmpresa.Text);
        }

        private void txtEmailEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SinEspaciosEmail(e);
        }

        private void txtNombreContadorempresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Letras(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pbLogoEmpresa.Image = Comisariato.Properties.Resources.contact;
        }

        private void txtRUCEmpresa_Leave(object sender, EventArgs e)
        {
            if (txtRUCEmpresa.Text != "")
            {
                if (txtRUCEmpresa.Text.Length == 13)
                {
                    if (txtRUCEmpresa.Text.Substring(10, 3) != "001" /*|| Funcion.VerificarCedula(txtRUCEmpresa.Text.Substring(0, 10)) == false*/)
                    {
                        MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtRUCEmpresa.Focus();
                        txtRUCEmpresa.Select(0, txtRUCEmpresa.Text.Length);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); txtRUCEmpresa.Focus();
                    txtRUCEmpresa.Select(0, txtRUCEmpresa.Text.Length);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pbfondoPantallaEmpresa.Image = Comisariato.Properties.Resources.contact;
        }

        private void dgvDatosEmpresa_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvDatosEmpresa.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = dgvDatosEmpresa.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\modificarDgv.ico");

                Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.modificarDgv);
                IntPtr Hicon = bitmap.GetHicon();
                Icon icoAtomico = Icon.FromHandle(Hicon);
                //bitmap.SetResolution(72, 72);

                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                dgvDatosEmpresa.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dgvDatosEmpresa.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }
        }

        private void txtRUCContadorEmpresa_Leave(object sender, EventArgs e)
        {
            if (txtRUCContadorEmpresa.Text != "")
            {
                if (txtRUCContadorEmpresa.Text.Length == 13)
                {
                    if (txtRUCContadorEmpresa.Text.Substring(10, 3) != "001" || Funcion.VerificarCedula(txtRUCContadorEmpresa.Text.Substring(0, 10)) == false)
                    {
                        MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtRUCContadorEmpresa.Focus();
                        txtRUCEmpresa.Select(0, txtRUCContadorEmpresa.Text.Length);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); txtRUCContadorEmpresa.Focus();
                    txtRUCContadorEmpresa.Select(0, txtRUCContadorEmpresa.Text.Length);
                }
            }
        }

        private void txtRazonSocialEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.ValidarLetrasPuntoNumero(e, txtRazonSocialEmpresa.Text);
        }
    }
}
