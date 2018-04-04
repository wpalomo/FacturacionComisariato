using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmDatosClientes : Form
    {

        Consultas ObjConsul;
        private bool verificar;
        public int comprobarvista;
        //804 * 576
        //pocision  
        //x=35 y=105
        public FrmDatosClientes()
        {
            InitializeComponent();
           
            //rbBuscar.Checked = true;

        }

        private void FrmDatosClientes_Load(object sender, EventArgs e)
        {
            ObjConsul = new Consultas();
            try
            {
                if (comprobarvista == 1)
                {
                    lbltitulo.Text = "Consulta de Datos.";
                    //gbDatosCliente.Visible = false;
                    gbBuscar.Visible = true;
                   
                    ObjConsul.BoolCrearDateTableConsultaCliente(dgvDatosUsuario, "Select tbCliente.IDENTIFICACION, tbCliente.NOMBRES, tbCliente.APELLIDOS, tbCliente.EMAIL,TbCliente.RAZONSOCIAL,tbcliente.DIRECCION,tbCliente.IDCLIENTE from tbCliente;");
                    dgvDatosUsuario.Columns[4].Visible = false;
                    dgvDatosUsuario.Columns[5].Visible = false;
                    dgvDatosUsuario.Columns[6].Visible = false;
                    //this.Size = new Size(804, 540);
                    lbltitulo.Left = (this.Width - lbltitulo.Width) / 2;
                    TxtConsulta.Focus();
                    btnSalir.Enabled = true;
                    verificar = true;
                }
                else
                {
                    gbBuscar.Visible = false;
                    //ObjConsul.BoolLlenarComboBox(cbPais, "Select TbPais.IDPAIS as ID, TbPais.NOMBRE AS Texto from TbPais");
                    //gbDatosCliente.Visible = true;
                    //gbDatosCliente.Location = new Point(35, 60);
                    this.Size = new Size(550, 620);
                    lbltitulo.Left = (this.Width - lbltitulo.Width) / 2;
                    //txtIdentificacion.Focus();
                    btnSalir.Enabled = false;
                    verificar = false;
                }
            }
            catch (Exception ex)
            {

               
            }
            
        }

        private void TxtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dgvDatosUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            LlenarListaCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlenarListaCliente();
        }


        public void LlenarListaCliente()
        {

            if (FrmFactura.DatosCliente.Count > 0)
            {
                FrmFactura.DatosCliente.Clear();
            }
            FrmFactura.verificadorfrm = 0;

            //Select tbCliente.IDENTIFICACION, tbCliente.NOMBRES, tbCliente.APELLIDOS, tbCliente.EMAIL, tbCliente.RAZONSOCIAL, tbCliente.DIRECCION,tbCliente.IDCLIENTE from tbCliente;
            
            FrmFactura.DatosCliente.Add(dgvDatosUsuario.CurrentRow.Cells[0].Value.ToString()); //Identificacion
            FrmFactura.DatosCliente.Add(dgvDatosUsuario.CurrentRow.Cells[1].Value.ToString() + " " + dgvDatosUsuario.CurrentRow.Cells[2].Value.ToString());//Nombre + Apellido
            FrmFactura.DatosCliente.Add(dgvDatosUsuario.CurrentRow.Cells[5].Value.ToString()); // Direccion
            FrmFactura.DatosCliente.Add(dgvDatosUsuario.CurrentRow.Cells[4].Value.ToString()); //RazonSocial
            FrmFactura.DatosCliente.Add(dgvDatosUsuario.CurrentRow.Cells[6].Value.ToString()); //IDcLIENTE
            this.Close();
        }

        private void FrmDatosClientes_KeyUp(object sender, KeyEventArgs e)
        {
            if (verificar)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        dgvDatosUsuario.Focus();

                        break;
                    case Keys.Down:
                        dgvDatosUsuario.Focus();

                        break;
                    case Keys.B:
                        TxtConsulta.Focus();

                        break;
                    case Keys.Escape:
                        try
                        {
                            LlenarListaCliente();
                        }
                        catch (Exception)
                        {

                            //throw;
                        }

                        break;

                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtConsulta.Focus();
            this.Close();
        }

        private void rbBuscar_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbBuscar.Checked)
            //{
            //    gbBuscar.Visible = true;
            //    this.Size = new Size(804, 576);
            //    lbltitulo.Left = (this.Width - lbltitulo.Width) / 2;
            //    TxtConsulta.Focus();
            //    btnSalir.Enabled = true;
            //    verificar = true;
            //}
            //else
            //{
            //    gbBuscar.Visible = false;
            //    btnSalir.Enabled = false;
            //    verificar = false;
            //}
        }

        private void rbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbAgregar.Checked)
            //{
            //    ObjConsul.BoolLlenarComboBox(cbPais, "Select TbPais.IDPAIS as ID, TbPais.NOMBRE AS Texto from TbPais");
            //    gbDatosCliente.Visible = true;
            //    gbDatosCliente.Location = new Point(35,105);
            //    this.Size = new Size(540, 550);
            //    lbltitulo.Left = (this.Width - lbltitulo.Width) / 2;
            //    txtIdentificacion.Focus();
            //    btnSalir.Enabled = false;
            //    verificar = false;
            //}
            //else
            //{
            //    gbDatosCliente.Visible = false;
            //    btnSalir.Enabled = true;
            //    verificar = true;
            //}
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtIdentificacion.Text != "")
            //{
            //    if (e.KeyChar == (char)Keys.Return)
            //    {
            //        SendKeys.Send("{TAB}");
            //    }
            //}
            //else
            //{
            //    txtIdentificacion.Focus();
            //}
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtNombres.Text != "")
            //{
            //    if (e.KeyChar == (char)Keys.Return)
            //    {
            //        SendKeys.Send("{TAB}");
            //    }
            //}
            //else
            //{
            //    txtNombres.Focus();
            //}
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtApellidos.Text != "")
            //{
            //    if (e.KeyChar == (char)Keys.Return)
            //    {
            //        SendKeys.Send("{TAB}");
            //    }
            //}
            //else
            //{
            //    txtApellidos.Focus();
            //}
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtEmail.Text != "")
            //{
                //if (e.KeyChar == (char)Keys.Return)
                //{
                //    SendKeys.Send("{TAB}");
                //}
            //}
            //else
            //{
            //    txtEmail.Focus();
            //}
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtTelefono.Text != "")
            //{
            //    if (e.KeyChar == (char)Keys.Return)
            //    {
            //        SendKeys.Send("{TAB}");
            //    }
            //}
            //else
            //{
            //    txtTelefono.Focus();
            //}
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtDireccion.Text != "")
            //{
            //    if (e.KeyChar == (char)Keys.Return)
            //    {
            //        SendKeys.Send("{TAB}");
            //    }
            //}
            //else
            //{
            //    txtDireccion.Focus();
            //}
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String ID = cbPais.SelectedValue.ToString();
            //ObjConsul = new Consultas();
            //ObjConsul.BoolLlenarComboBox(cbProvincia, "Select TbProvincia.IDPROVINCIA as ID, TbProvincia.NOMBRE AS Texto from TbProvincia where IDPAIS = " + ID + ";");
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String ID = cbProvincia.SelectedValue.ToString();
            //ObjConsul = new Consultas();
            //ObjConsul.BoolLlenarComboBox(cbCanton, "Select TbCanton.IDCANTON as ID, TbCanton.NOMBRE AS Texto from TbCanton where IDPROVINCIA = " + ID + ";");
        }

        private void cbCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String ID = cbCanton.SelectedValue.ToString();
            //ObjConsul = new Consultas();
            //ObjConsul.BoolLlenarComboBox(cbParroquia, "Select TbParroquia.IDPARROQUIA as ID, TbParroquia.NOMBRE AS Texto from TbParroquia where IDCANTON = " + ID + ";");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (txtIdentificacion.Text!="")
            //{
            //    if (txtNombres.Text!="")
            //    {
            //        if (txtApellidos.Text!="")
            //        {
            //            if (verificartelefonos())
            //            {
            //                if (txtDireccion.Text!="")
            //                {
            //                    bool result= ObjConsul.Insertar("INSERT INTO TbCliente (TIPOCLIENTE, IDENTIFICACION, NOMBRES, APELLIDOS, EMAIL, DIRECCION, ACTIVO, IDPARROQUIA, ESPECIFICACIONES_CATEGORIA, CONDICIONES_COMERC_CREDITOASIGNADO, CONDICIONES_COMERC_CUPOCREDITO, CONDICIONES_COMERC_DESCUENTO, ACTIVIDADECONOMICA) VALUES ( 'NORMAL','" + txtIdentificacion.Text+"','"+txtNombres.Text.ToUpper()+"','"+txtApellidos.Text.ToUpper() + "','"+txtEmail.Text+"','"+txtDireccion.Text.ToUpper() + "','1'"+",'"+ cbParroquia.SelectedValue.ToString()+"','A','0','0','0','si'" + ");");
            //                    if (result)
            //                    {
            //                        int idcliente = ObjConsul.ObtenerID("IDCLIENTE", "TbCliente","");

            //                        if (txtTelefono.Text != "" && txtCell.Text != "")
            //                        {
            //                            ObjConsul.Insertar("INSERT INTO TbTelefono (TELEFONO,IDRELACION,TIPO) VALUES ('" + txtTelefono.Text + "','" + idcliente + "','CLIENTE'" + ");");
            //                            ObjConsul.Insertar("INSERT INTO TbTelefono (TELEFONO,IDRELACION,TIPO) VALUES ('" + txtCell.Text + "','" + idcliente + "','CLIENTE'" + ");");
            //                        }
            //                        else
            //                        {
            //                            if (txtCell.Text != "")
            //                            {
            //                                ObjConsul.Insertar("INSERT INTO TbTelefono (TELEFONO,IDRELACION,TIPO) VALUES ('" + txtCell.Text + "','" + idcliente + "','CLIENTE'" + ");");
            //                            }
            //                            else
            //                            {
            //                                ObjConsul.Insertar("INSERT INTO TbTelefono (TELEFONO,IDRELACION,TIPO) VALUES ('" + txtTelefono.Text + "','" + idcliente + "','CLIENTE'" + ");");
            //                            }
            //                        }

            //                        if (FrmFactura.DatosCliente.Count > 0)
            //                        {
            //                            FrmFactura.DatosCliente.Clear();
            //                        }
            //                        FrmFactura.verificadorfrm = 0;
            //                        FrmFactura.DatosCliente.Add(txtIdentificacion.Text);
            //                        FrmFactura.DatosCliente.Add(txtNombres.Text.ToUpper()+" " + txtApellidos.Text.ToUpper());

            //                        this.Close();

            //                    }
                               
                                
            //                }
            //                else
            //                {
            //                    txtDireccion.Focus();
            //                }
            //            }
            //        }
            //        else
            //        {
            //            txtApellidos.Focus();
            //        }
            //    }
            //    else
            //    {
            //        txtNombres.Focus();
            //    }
            //}
            //else
            //{
            //    txtIdentificacion.Focus();
            //}
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        //private bool verificartelefonos()
        //{
            //if (txtTelefono.Text!="" && txtCell.Text!="")
            //{
            //    return true;
            //}
            //else
            //{
            //    if (txtCell.Text!="")
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        if (txtTelefono.Text!="")
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            txtTelefono.Focus();
            //            return false;
            //        }
            //    }
            //}
        //}

        private void TxtConsulta_TextChanged(object sender, EventArgs e)
        {
            //List<string> ListaClientes = ObjConsul.DatosCliente(TxtConsulta.Text);
            ObjConsul = new Consultas();
            ObjConsul.BoolCrearDateTableConsultaCliente(dgvDatosUsuario, "Select tbCliente.IDENTIFICACION, tbCliente.NOMBRES, tbCliente.APELLIDOS, tbCliente.EMAIL, tbCliente.RAZONSOCIAL, tbCliente.DIRECCION,tbCliente.IDCLIENTE from tbCliente where IDENTIFICACION like '%" + TxtConsulta.Text + "%' or NOMBRES like '%" + TxtConsulta.Text + "%' or APELLIDOS like '%" + TxtConsulta.Text + "%';");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDatosClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
        }
    }
}
