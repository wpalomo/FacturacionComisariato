using Comisariato.Clases;
using Comisariato.Formularios.Transacciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios
{
    public partial class FrmClientes : Form
    {
        public int VerifiMetodo = 1;
        public FrmClientes()
        {
            InitializeComponent();
            StatusImgs = new Image[] { Comisariato.Properties.Resources.Habilitar, Comisariato.Properties.Resources.EliminarDgv, Comisariato.Properties.Resources.modificarDgv };
        }
        Consultas consultas;
        bool bandera_Estado = false;
        String identificacion = "";
        private Image[] StatusImgs;


        public void inicializarDatos()
        {

            tcDatosCliente.SelectedIndex = 0;
            cbTipoCliente.SelectedIndex = 0;
            cbIdentificacionCliente.SelectedIndex = 0;
            cbCategoriaCliente.SelectedIndex = 0;
            cbActividadEconomicaCliente.SelectedIndex = 0;

            //foreach (Control item in tpInformacionGeneralCliente.Controls)
            //{
            //    if (item is TextBox)
            //        item.Text = "";
            //    if (item is DataGridView)
            //        item.Controls.Clear();
            //}

            Funcion.Limpiarobjetos(gbDatosPersonalesClientes);
            Funcion.Limpiarobjetos(gbRepresentanteLegalCliente);
            Funcion.Limpiarobjetos(gbGerenteGeneralCliente);
            Funcion.Limpiarobjetos(gbGaranteCliente);

            txtConsultarCliente.Text = "";
            txtCreditoAsignadoCliente.Text = "0";
            txtCupoCreditoCliente.Text = "0";
            txtDescuentoCliente.Text = "0";
            //cargarDatos("1");
            cbProvinciaCliente.SelectedValue = 9;
            cbCantonCliente.SelectedValue = 80;
            cbParroquiaCliente.SelectedValue = 41;
            txtCasillaCliente.Text = "0";


            LblIdentificacion.ForeColor = Color.Teal;
            lblNombre.ForeColor = Color.Teal;
            LblApellidos.ForeColor = Color.Teal;
            LblRazonSocial.ForeColor = Color.Teal;

            consultas.BoolLlenarComboBox(cbCuentaContable, "Select IDPLANCUENTA as ID ,'[' +CUENTA +']' + ' - ' + DESCRIPCIONCUENTA AS Texto FROM dbo.TbPlanCuenta ");
            SendKeys.Send("{TAB}"); SendKeys.Send("{TAB}");
            cbTipoCliente.Focus();

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
                
            cbTipoCliente.SelectedIndex = 0;
            cbIdentificacionCliente.SelectedIndex = 0;
            cbCategoriaCliente.SelectedIndex = 0;
            cbActividadEconomicaCliente.SelectedIndex = 0;
            consultas = new Consultas();
            consultas.BoolLlenarComboBox(cbPaisCliente, "Select IDPAIS as ID, NOMBRE AS Texto from TbPais");

            // llenar datadrigview solo los activos
            //cargarDatos("1");




            // Dimensionar lista combo

            cbPaisCliente.DropDownHeight = cbPaisCliente.ItemHeight = 150;
            cbProvinciaCliente.DropDownHeight = cbProvinciaCliente.ItemHeight = 150;
            cbCantonCliente.DropDownHeight = cbCantonCliente.ItemHeight = 150;
            cbParroquiaCliente.DropDownHeight = cbParroquiaCliente.ItemHeight = 150;

            inicializarDatos();

        }


        private void txtIdentificacionCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtNombresCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////Funcion.Validar_Letras(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRazonSocialCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion.validar_Num_Letras(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion.validar_Num_Letras(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCreditoAsignadoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtCreditoAsignadoCliente.Text);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCupoCreditoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtCupoCreditoCliente.Text);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDescuentoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtDescuentoCliente.Text);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        public string obtenerCategoriaChequeada()
        {
            if (rbAmbasCliente.Checked) { return rbAmbasCliente.Text; }
            else if (rbContadoCliente.Checked) { return rbContadoCliente.Text; }
            else if (rbCreditoCliente.Checked) { return rbCreditoCliente.Text; }
            else return "";
        }

        public void InsertarOtraInfCliente(int idcliente)
        {
            Cliente Objcliente = new Cliente();

            if (txtIdentificacionRepresentanteLegalCliente.Text != "" && txtNombreRepresentanteLegalCliente.Text != "" && txtCelularRepresentanteLegalCliente.Text != "")
            {
                Objcliente.InsertarOtraInformacionCliente("Representante Legal", txtIdentificacionRepresentanteLegalCliente.Text, txtNombreRepresentanteLegalCliente.Text, txtEmailRepresentanteLegalCliente.Text, txtCelularRepresentanteLegalCliente.Text, idcliente);
            }
            if (txtIdentificacionGerenteGeneralCliente.Text != "" && txtNombreGerenteGeneralCliente.Text != "" && txtCelularGerenteGeneralCliente.Text != "")
            {
                Objcliente.InsertarOtraInformacionCliente("Gerente General", txtIdentificacionGerenteGeneralCliente.Text, txtNombreGerenteGeneralCliente.Text, txtEmailGerenteGeneralCliente.Text, txtCelularGerenteGeneralCliente.Text, idcliente);
            }
            if (txtIdentificacionGaranteCliente.Text != "" && txtNombreGaranteCliente.Text != "" && txtCelularGaranteCliente.Text != "")
            {
                Objcliente.InsertarOtraInformacionCliente("Garante", txtIdentificacionGaranteCliente.Text, txtNombreGaranteCliente.Text, txtEmailGaranteCliente.Text, txtCelularGaranteCliente.Text, idcliente);
            }
        }

        public void ModificarOtraInfCliente(int idcliente)
        {
            Cliente Objcliente = new Cliente();

            if (txtIdentificacionRepresentanteLegalCliente.Text != "" && txtNombreRepresentanteLegalCliente.Text != "" && txtCelularRepresentanteLegalCliente.Text != "" && txtIdentificacionRepresentanteLegalCliente.Text != "")
            {
                Objcliente.InsertarOtraInformacionCliente("Representante Legal", txtIdentificacionRepresentanteLegalCliente.Text, txtNombreRepresentanteLegalCliente.Text, txtEmailRepresentanteLegalCliente.Text, txtCelularRepresentanteLegalCliente.Text, idcliente);
            }
            else
            { Objcliente.InsertarOtraInformacionCliente("Representante Legal", txtIdentificacionRepresentanteLegalCliente.Text, txtNombreRepresentanteLegalCliente.Text, txtEmailRepresentanteLegalCliente.Text, txtCelularRepresentanteLegalCliente.Text, idcliente); }
            if (txtIdentificacionGerenteGeneralCliente.Text != "" && txtNombreGerenteGeneralCliente.Text != "" && txtCelularGerenteGeneralCliente.Text != "" && txtIdentificacionGerenteGeneralCliente.Text != "")
            {
                Objcliente.InsertarOtraInformacionCliente("Gerente General", txtIdentificacionGerenteGeneralCliente.Text, txtNombreGerenteGeneralCliente.Text, txtEmailGerenteGeneralCliente.Text, txtCelularGerenteGeneralCliente.Text, idcliente);
            }
            else { Objcliente.InsertarOtraInformacionCliente("Gerente General", txtIdentificacionGerenteGeneralCliente.Text, txtNombreGerenteGeneralCliente.Text, txtEmailGerenteGeneralCliente.Text, txtCelularGerenteGeneralCliente.Text, idcliente); }
            if (txtIdentificacionGaranteCliente.Text != "" && txtNombreGaranteCliente.Text != "" && txtCelularGaranteCliente.Text != "" && txtIdentificacionGaranteCliente.Text != "")
            {
                Objcliente.InsertarOtraInformacionCliente("Garante", txtIdentificacionGaranteCliente.Text, txtNombreGaranteCliente.Text, txtEmailGaranteCliente.Text, txtCelularGaranteCliente.Text, idcliente);
            }
            else { Objcliente.InsertarOtraInformacionCliente("Garante", txtIdentificacionGaranteCliente.Text, txtNombreGaranteCliente.Text, txtEmailGaranteCliente.Text, txtCelularGaranteCliente.Text, idcliente); }
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (txtIdentificacionCliente.Text != "" && txtNombresCliente.Text != "" && txtApellidosCliente.Text != "" && txtRazonSocialCliente.Text != "" && txtDireccion.Text!="")
            {
                String categoriaChequeada = obtenerCategoriaChequeada();
                Cliente Objcliente = new Cliente(cbTipoCliente.Text, cbIdentificacionCliente.Text, txtIdentificacionCliente.Text, ckClienteActivo.Checked, txtNombresCliente.Text, txtApellidosCliente.Text,
                    dtpFechaNacimientoCliente.Value, txtRazonSocialCliente.Text, txtEmailCliente.Text, txtDireccion.Text, cbActividadEconomicaCliente.Text,
                     Convert.ToInt32(cbParroquiaCliente.SelectedValue), Convert.ToInt32(txtCasillaCliente.Text.ToString()), txtFaxCliente.Text, txtCelular1Cliente.Text, txtCelular2Cliente.Text, txtObservacionCliente.Text,
                     cbCategoriaCliente.Text, categoriaChequeada, txtCreditoAsignadoCliente.Text, txtCupoCreditoCliente.Text, txtDescuentoCliente.Text, Convert.ToInt32(cbCuentaContable.SelectedValue));
                int idcliente = consultas.ObtenerID("IDCLIENTE", "TbCliente", "");
                if (!bandera_Estado) // Para identificar si se va ingresar
                {
                    String resultado = Objcliente.InsertarCliente(); // retorna true si esta correcto todo
                    if (VerifiMetodo == 1)
                    {
                        if (resultado == "Datos Guardados")
                        {
                            inicializarDatos();
                            //cargarDatos("1");
                            InsertarOtraInfCliente(idcliente);
                            MessageBox.Show("Cliente Registrado Correctamente ", "Exito", MessageBoxButtons.OK);
                            rbtActivosCliente.Checked = true;


                        }
                        else if (resultado == "Error al Registrar")
                        {
                            MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (resultado == "Existe") { MessageBox.Show("Ya Existe el Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    else
                    {
                        if (resultado == "Datos Guardados")
                        {
                            if (FrmFactura.DatosCliente.Count > 0)
                            {
                                FrmFactura.DatosCliente.Clear();
                            }

                            //FrmFactura.DatosCliente.Add(dgvDatosUsuario.CurrentRow.Cells[0].Value.ToString()); //Identificacion
                            //FrmFactura.DatosCliente.Add(dgvDatosUsuario.CurrentRow.Cells[1].Value.ToString() + " " + dgvDatosUsuario.CurrentRow.Cells[2].Value.ToString());//Nombre + Apellido
                            //FrmFactura.DatosCliente.Add(dgvDatosUsuario.CurrentRow.Cells[5].Value.ToString()); // Direccion
                            //FrmFactura.DatosCliente.Add(dgvDatosUsuario.CurrentRow.Cells[4].Value.ToString()); //RazonSocial
                            //FrmFactura.DatosCliente.Add(dgvDatosUsuario.CurrentRow.Cells[6].Value.ToString()); //IDcLIENTE

                            FrmFactura.verificadorfrm = 0;
                            FrmFactura.DatosCliente.Add(txtIdentificacionCliente.Text);
                            FrmFactura.DatosCliente.Add(txtNombresCliente.Text.ToUpper() + " " + txtApellidosCliente.Text.ToUpper());
                            FrmFactura.DatosCliente.Add(txtDireccion.Text);
                            FrmFactura.DatosCliente.Add(txtRazonSocialCliente.Text);
                            string condicion = " where IDENTIFICACION= '"+txtIdentificacionCliente.Text+"'";
                            Consultas c = new Consultas();
                            int numero = c.ObtenerID("IDCLIENTE", "TbCliente", condicion);
                            FrmFactura.DatosCliente.Add(""+numero);
                            this.Close();
                        }
                        else if (resultado == "Error al Registrar")
                        {
                            MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                else if (bandera_Estado) // Para identificar si se va modificar
                {
                    String Resultado = Objcliente.ModificarCliente(identificacion); // retorna true si esta correcto todo
                    ModificarOtraInfCliente(idcliente);
                    if (Resultado == "Correcto")
                    {
                        MessageBox.Show("Cliente Actualizado", "Exito");
                        //cargarDatos("1");
                        rbtActivosCliente.Checked = true;
                        identificacion = "";
                        inicializarDatos();
                    }
                    else { MessageBox.Show("Error al actualizar Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    inicializarDatos();
                    bandera_Estado = false;
                    btnGuardarCliente.Text = "&Guardar";
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos del Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblIdentificacion.ForeColor = Color.Red;
                lblNombre.ForeColor = Color.Red;
                LblApellidos.ForeColor = Color.Red;
                LblRazonSocial.ForeColor = Color.Red;
            }

        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            if (btnLimpiarCliente.Text == "&Cancelar")
            {
                inicializarDatos();
                btnLimpiarCliente.Text = "&Limpiar";
                btnGuardarCliente.Text = "&Guardar";
            }
            else { inicializarDatos(); }
            bandera_Estado = false;
        }

        private void dgvDatosCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cliente ObjCliente = new Cliente();
                if (Convert.ToString(dgvDatosCliente.CurrentRow.Cells[2].Value) != "")
                {
                    if (rbtActivosCliente.Checked)
                    {
                        if (this.dgvDatosCliente.Columns[e.ColumnIndex].Name == "DeshabilitarCliente")
                        {
                            ObjCliente.EstadoCliente(dgvDatosCliente.CurrentRow.Cells[2].Value.ToString(), 2);
                            cargarDatos("1");
                        }
                    }
                    else if (rbtInactivosCliente.Checked)
                    {
                        if (this.dgvDatosCliente.Columns[e.ColumnIndex].Name == "DeshabilitarCliente")
                        {
                            ObjCliente.EstadoCliente(dgvDatosCliente.CurrentRow.Cells[2].Value.ToString(), 1);
                            cargarDatos("0");
                        }
                    }

                    if (this.dgvDatosCliente.Columns[e.ColumnIndex].Name == "modificarCliente")
                    {
                        //este vale

                        //MessageBox.Show("modificar toca");
                        bandera_Estado = true;
                        tcCliente.SelectedIndex = 0;
                        btnGuardarCliente.Text = "&Modificar";
                        btnLimpiarCliente.Text = "&Cancelar";
                        identificacion = dgvDatosCliente.CurrentRow.Cells[2].Value.ToString();

                        //Llenar el DataTable
                        DataTable dt = consultas.BoolDataTable("Select * from TbCliente where IDENTIFICACION = '" + dgvDatosCliente.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                        if (dt.Rows.Count > 0)
                        {
                            DataRow myRow = dt.Rows[0];
                            cbTipoCliente.SelectedItem = myRow["TIPOCLIENTE"].ToString();
                            //llenar identificacion y seleccionar combobox tipodoc
                            txtIdentificacionCliente.Text = myRow["IDENTIFICACION"].ToString();
                            if (myRow["IDENTIFICACION"].ToString().Length == 10)
                                cbIdentificacionCliente.SelectedIndex = 0;
                            else if (myRow["IDENTIFICACION"].ToString().Length == 13)
                                cbIdentificacionCliente.SelectedIndex = 1;
                            else
                                cbIdentificacionCliente.SelectedIndex = 2;

                            ckClienteActivo.Checked = Convert.ToBoolean(myRow["ACTIVO"]);
                            txtNombresCliente.Text = myRow["NOMBRES"].ToString();
                            txtApellidosCliente.Text = myRow["APELLIDOS"].ToString();
                            dtpFechaNacimientoCliente.Value = Convert.ToDateTime(myRow["FECHANACIMIENTO"]);
                            txtRazonSocialCliente.Text = myRow["RAZONSOCIAL"].ToString();
                            txtEmailCliente.Text = myRow["EMAIL"].ToString();
                            txtDireccion.Text = myRow["DIRECCION"].ToString();
                            cbActividadEconomicaCliente.SelectedItem = myRow["ACTIVIDADECONOMICA"].ToString();
                            //// cargar los combo de pais canton provincia y parroquia
                            consultas.LLenarCombosUbicacion(Convert.ToInt32(myRow["IDPARROQUIA"]), ref cbPaisCliente, ref cbProvinciaCliente, ref cbCantonCliente, ref cbParroquiaCliente);

                            cbCategoriaCliente.SelectedItem = myRow["ESPECIFICACIONES_CATEGORIA"].ToString();

                            // marcar especificaciones TIPO CREDITO
                            String tipoCredito = myRow["ESPECIFICACIONES_TIPOCREDITO"].ToString();
                            if (tipoCredito == "Crédito")
                                rbCreditoCliente.Checked = true;
                            else if (tipoCredito == "Contado")
                                rbContadoCliente.Checked = true;
                            else
                                rbAmbasCliente.Checked = true;

                            if (myRow["CONDICIONES_COMERC_CREDITOASIGNADO"] != System.DBNull.Value)
                                txtCreditoAsignadoCliente.Text = myRow["CONDICIONES_COMERC_CREDITOASIGNADO"].ToString();
                            if (myRow["CONDICIONES_COMERC_CUPOCREDITO"] != System.DBNull.Value)
                                txtCupoCreditoCliente.Text = myRow["CONDICIONES_COMERC_CUPOCREDITO"].ToString();
                            if (myRow["CONDICIONES_COMERC_DESCUENTO"] != System.DBNull.Value)
                                txtDescuentoCliente.Text = myRow["CONDICIONES_COMERC_DESCUENTO"].ToString();
                            if (myRow["CASILLA"] != System.DBNull.Value)
                                txtCasillaCliente.Text = myRow["CASILLA"].ToString();
                            if (myRow["FAX"] != System.DBNull.Value)
                                txtFaxCliente.Text = myRow["FAX"].ToString();
                            if (myRow["CELULAR1"] != System.DBNull.Value)
                                txtCelular1Cliente.Text = myRow["CELULAR1"].ToString();
                            if (myRow["CELULAR2"] != System.DBNull.Value)
                                txtCelular2Cliente.Text = myRow["CELULAR2"].ToString();
                            txtObservacionCliente.Text = myRow["OBSERVACION"].ToString();

                            cbCuentaContable.SelectedValue = Convert.ToInt32(myRow["IDCuentaContable"]);
                            int indexcuenta = cbCuentaContable.SelectedIndex;
                            cbCuentaContable.SelectedIndex = indexcuenta;

                            int IdCliente = Convert.ToInt32(myRow["IDCLIENTE"]);


                            //cargar lista OTRA INFORMACION Cliente
                            DataTable DTOtrainformacion = consultas.BoolDataTable("Select * from TbOtraInformacionCliente where IDCLIENTE = " + IdCliente.ToString() + "");
                            int contador = 0;
                            if (DTOtrainformacion.Rows.Count > 0)
                            {

                                while (DTOtrainformacion.Rows.Count - 1 >= contador)
                                {
                                    DataRow row = DTOtrainformacion.Rows[contador];
                                    if (row["TIPO"].ToString() == "Representante Legal")
                                    {
                                        txtIdentificacionRepresentanteLegalCliente.Text = row["IDENTIFICACION"].ToString();
                                        txtNombreRepresentanteLegalCliente.Text = row["NOMBRE"].ToString();
                                        txtEmailRepresentanteLegalCliente.Text = row["EMAIL"].ToString();
                                        txtCelularRepresentanteLegalCliente.Text = row["CELULAR"].ToString();
                                    }
                                    else if (row["TIPO"].ToString() == "Gerente General")
                                    {
                                        txtIdentificacionGerenteGeneralCliente.Text = row["IDENTIFICACION"].ToString();
                                        txtNombreGerenteGeneralCliente.Text = row["NOMBRE"].ToString();
                                        txtEmailGerenteGeneralCliente.Text = row["EMAIL"].ToString();
                                        txtCelularGerenteGeneralCliente.Text = row["CELULAR"].ToString();
                                    }

                                    else if (row["TIPO"].ToString() == "Garante")
                                    {
                                        txtIdentificacionGaranteCliente.Text = row["IDENTIFICACION"].ToString();
                                        txtNombreGaranteCliente.Text = row["NOMBRE"].ToString();
                                        txtEmailGaranteCliente.Text = row["EMAIL"].ToString();
                                        txtCelularGaranteCliente.Text = row["CELULAR"].ToString();
                                    }
                                    contador++;
                                }
                            }

                        }

                    }

                }
            }
            catch (Exception)
            {

            }
            
        }

        private void cargarDatos(string condicion)
        {
            consultas = new Consultas();
            string consulta = "Select IDENTIFICACION AS 'CEDULA/RUC',NOMBRES, APELLIDOS, DIRECCION, CELULAR1, TIPOCLIENTE as 'TIPO', ESPECIFICACIONES_TIPOCREDITO AS 'CREDITO',ACTIVO from TbCliente WHERE ACTIVO=" + condicion + " and IDENTIFICACION != '9999999999999';";
            consultas.BoolCrearDateTableCliente(dgvDatosCliente, consulta);
            //dgvDatosCliente.Columns["ID"].Visible = false;
            //consultas.boolLlenarDataGrid(dgvDatosCliente, consulta, 15, 7, 2);
            //for (int i = 0; i < dgvDatosCliente.RowCount; i++)
            //    if (Convert.ToString(dgvDatosCliente.Rows[i].Cells[2].Value) == "")
            //        dgvDatosCliente.Rows[i].ReadOnly = true;
        }

        private void rbtActivosCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (txtConsultarCliente.Text != "")
            {
                if (rbtActivosCliente.Checked)
                {
                    cargarDatos("1");
                    //dgvDatosCliente.Columns[1].HeaderText = "Desabilitar";
                }
                else if (rbtInactivosCliente.Checked)
                {
                    cargarDatos("0");
                    //dgvDatosCliente.Columns[1].HeaderText = "Habilitar";
                }
            }
        }

        private void txtConsultarCliente_TextChanged(object sender, EventArgs e)
        {
            //if (rbtActivosCliente.Checked)
            //{
            //    consultas.boolLlenarDataGridView(dgvDatosCliente, "Select IDCLIENTE as ID,  RAZONSOCIAL as 'RAZON SOCIAL', TIPOCLIENTE as 'TIPO' , ESPECIFICACIONES_TIPOCREDITO AS 'CREDITO',DIRECCION, APELLIDOS,NOMBRES,IDENTIFICACION AS 'CEDULA/RUC' ,CELULAR1,CELULAR2 from TbCliente where ACTIVO = 1 and IDENTIFICACION like '%" + txtConsultarCliente.Text + "%' or NOMBRES like '%" + txtConsultarCliente.Text + "%' or APELLIDOS like '%" + txtConsultarCliente.Text + "%'");
            //    //dgvDatosCliente.Columns[1].HeaderText = "Desabilitar";
            //    dgvDatosCliente.Columns["ID"].Visible = false;
            //}
            //else if (rbtInactivosCliente.Checked)
            //{
            //    consultas.boolLlenarDataGridView(dgvDatosCliente, "Select IDCLIENTE as ID,  RAZONSOCIAL as 'RAZON SOCIAL', TIPOCLIENTE as 'TIPO' , ESPECIFICACIONES_TIPOCREDITO AS 'CREDITO',DIRECCION, APELLIDOS,NOMBRES,IDENTIFICACION AS 'CEDULA/RUC',CELULAR1,CELULAR2 from TbCliente where ACTIVO = 0 and IDENTIFICACION like '%" + txtConsultarCliente.Text + "%' or NOMBRES like '%" + txtConsultarCliente.Text + "%' or APELLIDOS like '%" + txtConsultarCliente.Text + "%'");
            //    //dgvDatosCliente.Columns[1].HeaderText = "Habilitar";
            //    dgvDatosCliente.Columns["ID"].Visible = false;
            //}
        }

        private void cbPaisCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaisCliente.SelectedValue.ToString() != null)
            {
                String ID = cbPaisCliente.SelectedValue.ToString();
                consultas = new Consultas();
                consultas.BoolLlenarComboBox(cbProvinciaCliente, "Select IDPROVINCIA as ID, NOMBRE AS Texto from TbProvincia where IDPAIS = " + ID + ";");
            }

        }

        private void cbProvinciaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvinciaCliente.SelectedValue.ToString() != null)
            {
                String ID = cbProvinciaCliente.SelectedValue.ToString();
                consultas = new Consultas();
                consultas.BoolLlenarComboBox(cbCantonCliente, "Select IDCANTON as ID, NOMBRE AS Texto from TbCanton where IDPROVINCIA = " + ID + ";");
            }
        }

        private void cbCantonCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCantonCliente.SelectedValue.ToString() != null)
            {
                String ID = cbCantonCliente.SelectedValue.ToString();
                consultas = new Consultas();
                consultas.BoolLlenarComboBox(cbParroquiaCliente, "Select IDPARROQUIA as ID, NOMBRE AS Texto from TbParroquia where IDCANTON = " + ID + ";");
            }
        }

        private void txtIdentificacionCliente_Leave(object sender, EventArgs e)
        {
            if (txtIdentificacionCliente.Text != "")
            {
                ////if (cbIdentificacionCliente.Focus())
                ////{
                    if (cbIdentificacionCliente.SelectedIndex == 0)
                    {
                        if (/*!Funcion.VerificarCedula(txtIdentificacionCliente.Text)*/ txtIdentificacionCliente.Text.Length != 10)
                        {
                            MessageBox.Show("Ingrese la Cédula Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            txtIdentificacionCliente.Focus();
                            txtIdentificacionCliente.Select(0, txtIdentificacionCliente.Text.Length);
                        }
                    }
                    if (cbIdentificacionCliente.SelectedIndex == 1)
                    {
                        if (txtIdentificacionCliente.Text.Length != 13)
                        {
                            //if (txtIdentificacionCliente.Text.Substring(10, 3) != "001")
                            //{
                                MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                txtIdentificacionCliente.Focus();
                                txtIdentificacionCliente.Select(0, txtIdentificacionCliente.Text.Length);
                            //}
                        }
                        //else
                        //{
                        //    MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); txtIdentificacionCliente.Focus();
                        //    txtIdentificacionCliente.Select(0, txtIdentificacionCliente.Text.Length);
                        //}
                    }
                ////}
            }
        }

        private void txtCasillaCliente_Enter(object sender, EventArgs e)
        {
            txtCasillaCliente.SelectAll();
        }

        //private Image[] StatusImgs;
        private void dgvDatosCliente_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //StatusImgs = new Image[] { Comisariato.Properties.Resources.inicio, Comisariato.Properties.Resources.inicio };
            if (e.ColumnIndex >= 0 && dgvDatosCliente.Columns[e.ColumnIndex].Name == "modificarCliente" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = dgvDatosCliente.Rows[e.RowIndex].Cells["modificarCliente"] as DataGridViewButtonCell;

                Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.modificarDgv);
                IntPtr Hicon = bitmap.GetHicon();
                Icon icoAtomico = Icon.FromHandle(Hicon);
                //bitmap.SetResolution(72, 72);


                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                dgvDatosCliente.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dgvDatosCliente.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;

            }

            if (rbtInactivosCliente.Checked)
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosCliente.Columns[e.ColumnIndex].Name == "DeshabilitarCliente" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosCliente.Rows[e.RowIndex].Cells["DeshabilitarCliente"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\Habilitar.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.Habilitar);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosCliente.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosCliente.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosCliente.Columns[e.ColumnIndex].Name == "DeshabilitarCliente" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosCliente.Rows[e.RowIndex].Cells["DeshabilitarCliente"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\EliminarDgv.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.EliminarDgv);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosCliente.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosCliente.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }

        private void dgvDatosCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTipoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cbIdentificacionCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtEmailCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cbPaisCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCasillaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtFaxCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCelular1Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtObservacionCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cbCategoriaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void rbCreditoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCreditoAsignadoCliente_Enter(object sender, EventArgs e)
        {
            txtCreditoAsignadoCliente.SelectAll();
        }

        private void txtCupoCreditoCliente_Enter(object sender, EventArgs e)
        {
            txtCupoCreditoCliente.SelectAll();
        }

        private void txtDescuentoCliente_Enter(object sender, EventArgs e)
        {
            txtDescuentoCliente.SelectAll();
        }

        private void txtIdentificacionRepresentanteLegalCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtEmailRepresentanteLegalCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dtpFechaNacimientoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void tcDatosCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCasillaCliente_Click(object sender, EventArgs e)
        {
            txtCasillaCliente.SelectAll();
        }

        private void dgvDatosCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            //if (e.ColumnIndex >= 0 && dgvDatosCliente.Columns[e.ColumnIndex].Name == "modificarCliente" && e.RowIndex >= 0)
            //{
            //    dgvDatosCliente.Rows[e.RowIndex].Cells["DeshabilitarCliente"].Value = StatusImgs[0];
            //}

            //if (rbtInactivosCliente.Checked)
            //{
            //    if (e.ColumnIndex >= 1 && this.dgvDatosCliente.Columns[e.ColumnIndex].Name == "DeshabilitarCliente" && e.RowIndex >= 0)
            //    {
            //        dgvDatosCliente.Rows[e.RowIndex].Cells["DeshabilitarCliente"].Value = StatusImgs[0];
            //    }
            //}
            //else
            //{
            //    if (e.ColumnIndex >= 1 && this.dgvDatosCliente.Columns[e.ColumnIndex].Name == "DeshabilitarCliente" && e.RowIndex >= 0)
            //    {
            //        dgvDatosCliente.Rows[e.RowIndex].Cells["DeshabilitarCliente"].Value = StatusImgs[1];
            //    }
            //}
        }

        private void rbtInactivosCliente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtConsultarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (rbtActivosCliente.Checked)
                {
                    if (txtConsultarCliente.Text != "")
                    {
                        consultas.BoolCrearDateTableCliente(dgvDatosCliente, "Select IDENTIFICACION AS 'CEDULA/RUC',NOMBRES, APELLIDOS, DIRECCION, CELULAR1, TIPOCLIENTE as 'TIPO', ESPECIFICACIONES_TIPOCREDITO AS 'CREDITO', ACTIVO from TbCliente WHERE ACTIVO = 1 and (IDENTIFICACION like '%" + txtConsultarCliente.Text + "%' or NOMBRES like '%" + txtConsultarCliente.Text + "%' or APELLIDOS like '%" + txtConsultarCliente.Text + "%')");
                        //dgvDatosCliente.Columns["ID"].Visible = false;
                    }
                }
                else if (rbtInactivosCliente.Checked)
                {
                    consultas.BoolCrearDateTableCliente(dgvDatosCliente, "Select IDENTIFICACION AS 'CEDULA/RUC',NOMBRES, APELLIDOS, DIRECCION, CELULAR1, TIPOCLIENTE as 'TIPO', ESPECIFICACIONES_TIPOCREDITO AS 'CREDITO',ACTIVO from TbCliente WHERE ACTIVO = 0 and (IDENTIFICACION like '%" + txtConsultarCliente.Text + "%' or NOMBRES like '%" + txtConsultarCliente.Text + "%' or APELLIDOS like '%" + txtConsultarCliente.Text + "%')");
                    //dgvDatosCliente.Columns["ID"].Visible = false;
                }
            }
        }

        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            inicializarDatos();
            this.Dispose(true);
        }

        private void txtIdentificacionCliente_Enter(object sender, EventArgs e)
        {

        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvDatosCliente.Rows.Count > 0)
            {
                if (Funcion.ExportarDataGridViewExcel(dgvDatosCliente,2))
                {
                    MessageBox.Show("Reporte creado con exito.");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al crear el reporte.");
                }

            }
        }
    }
}