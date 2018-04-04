using Comisariato.Clases;
using Comisariato.Formularios.Mantenimiento.Inventario;
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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }


        Consultas consultas;
        bool bandera_Estado = false;
        String identificacion = "";
        String GlobalCodigoProveedor = "0";
        int IDProveedor;
        DataGridViewComboBoxColumn columnaComboFI = new DataGridViewComboBoxColumn();

        public void inicializarDatos()
        {
            cbIdentificacionProveedor.SelectedIndex = 0;
            cbNacionalidadProveedor.SelectedIndex = 0;
            cbNaturalezaProveedor.SelectedIndex = 0;
            //CmbPais.SelectedIndex = 1;
            //CmbParroquia.SelectedIndex = 1;
            //cbProvinciaProveedor.SelectedIndex = 1;
            cbTipoGastoProveedor.SelectedIndex = 0;
            //CmbTipoServicio.SelectedIndex = 1;

            txtDireccionProveedor.Text = "";
            txtRazonSocialProveedor.Text = "";
            txtResponsableProveedor.Text = "";
            txtCelularProveedor.Text = "";
            txtTelefonoProveedor.Text = "";
            txtEmailProveedor.Text = "";
            txtGiraChequeProveedor.Text = "";
            txtPlazo.Text = "";
            txtFax.Text = "";
            TxtCelularResponsable.Text = "";
            ckbRISEProveedor.Checked = false;
            Funcion.Limpiarobjetos(gbDatosAutorizacionProveedor);
            Funcion.Limpiarobjetos(gbInformcionGeneralProveedor);
            dgvDatosAutorizacionProveedor.Controls.Clear();
            //dgvDatosProveedor.Controls.Clear();
            dgvCodigoRetencionProveedor.Controls.Clear();
            txtConsultarProveedor.Text = "";

            cargarDatos("1");

            //cbPaisProveedor.SelectedIndex = 0;
            cbProvinciaProveedor.SelectedValue = 9;
            cbCantonProveedor.SelectedValue = 80;
            cbParroquiaProveedor.SelectedValue = 41;


            consultas.BoolLlenarComboBox(cbCuentaContableProveedor, "Select IDPLANCUENTA as ID ,'[' +CUENTA +']' + ' - ' + DESCRIPCIONCUENTA AS Texto FROM dbo.TbPlanCuenta ");
            consultas.BoolLlenarComboBox(cbTipoServicioProveedor, "Select IDSERVICIO as ID, DESCRIPCION AS Texto from TbTipoServicio");


            IDProveedor = consultas.ObtenerID("IDProveedor", "TbProveedor", "");
            if (IDProveedor > 0)
            {
                GlobalCodigoProveedor = (IDProveedor + 1).ToString();
            }
            else { GlobalCodigoProveedor = "1"; }

            //switch (GlobalCodigoProveedor.Length)
            //{
            //    case 1:
            //        GlobalCodigoProveedor = "000" + GlobalCodigoProveedor;
            //        break;
            //    case 2:
            //        GlobalCodigoProveedor = "00" + GlobalCodigoProveedor;
            //        break;
            //    case 3:
            //        GlobalCodigoProveedor = "0" + GlobalCodigoProveedor;
            //        break;
            //    default:
            //        break;
            //}
            TxtCodigo2.Text = GlobalCodigoProveedor;

            cbCreditoProveedor.DataSource = null;
            cbICEProveedor.DataSource = null;
            cbCodigo101Proveedor.DataSource = null;

            dgvDatosAutorizacionProveedor.Rows.Clear();
            dgvCodigoRetencionProveedor.Rows.Clear();

            for (int i = 0; i < 3; i++)
            {
                dgvCodigoRetencionProveedor.Rows.Add();
                dgvDatosAutorizacionProveedor.Rows.Add();
            }
            tabControl1.SelectedIndex = 0;
            tcProveedor.SelectedIndex = 0;


        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            //this.StartPosition = FormStartPosition.Manual;
            SendKeys.Send("{TAB}"); SendKeys.Send("{TAB}"); SendKeys.Send("{TAB}");
            cbIdentificacionProveedor.SelectedIndex = 0;
            cbNacionalidadProveedor.SelectedIndex = 0;
            cbNaturalezaProveedor.SelectedIndex = 0;
            cbTipoGastoProveedor.SelectedIndex = 0;
            consultas = new Consultas();

            consultas.BoolLlenarComboBox(cbPaisProveedor, "Select IDPAIS as ID, NOMBRE AS Texto from TbPais");



            inicializarDatos();
            //consul.boolLlenarDataGridView(dgvDatosProveedor, "");
            //for (int i = dgvDatosProveedor.Rows.Count; i < 20; i++)
            //{
            //    dgvDatosProveedor.Rows.Add();
            //}
            dgvCodigoRetencionProveedor.Rows.Add();
            for (int i = 0; i < 3; i++)
            {
                //dgvCodigoRetencionProveedor.Rows.Add();
                dgvDatosAutorizacionProveedor.Rows.Add();
            }
            // Dimensionar lista combo

            cbPaisProveedor.DropDownHeight = cbPaisProveedor.ItemHeight = 150;
            cbProvinciaProveedor.DropDownHeight = cbProvinciaProveedor.ItemHeight = 150;
            cbCantonProveedor.DropDownHeight = cbCantonProveedor.ItemHeight = 150;
            cbParroquiaProveedor.DropDownHeight = cbParroquiaProveedor.ItemHeight = 150;

            cbCuentaContableProveedor.DropDownHeight = cbCuentaContableProveedor.ItemHeight = 150;
            cbTipoServicioProveedor.DropDownHeight = cbTipoServicioProveedor.ItemHeight = 150;


            /// Para poner del DATETIMEPICKER
            dtpOrder = new DateTimePicker();
            dtpOrder.Format = DateTimePickerFormat.Short;

            dtpOrder.Visible = false;
            dtpOrder.Width = 100;
            dgvDatosAutorizacionProveedor.Controls.Add(dtpOrder);
            dtpOrder.ValueChanged += this.dtpOrden_ValueChanged;
            dgvDatosAutorizacionProveedor.CellBeginEdit += this.dgvDatosAutorizacionProveedor_CellBeginEdit;
            dgvDatosAutorizacionProveedor.CellEndEdit += this.dgvDatosAutorizacionProveedor_CellEndEdit;

            //Combo en DATAGRIDVIEW FUENTE/IVA
            //ComboBox comboPrueba = new ComboBox();
            //consultas.BoolLlenarComboBoxDgv((DataGridViewComboBoxColumn)dgvCodigoRetencionProveedor.Columns[1].i, "select CS.IDCODIGOSRI as ID, '[' + CS.CODIGOSRI + '] - ' + CS.DESCRIPCION as Texto from TbCodigoSRI CS, TbTipoCodigoSRI TCS WHERE TCS.IDTIPOCODIGOSRI = CS.IDTIPOCODIGOSRI AND TCS.CODIGO = 'COD_RET_FUE' or TCS.CODIGO = 'COD_RET_IVA'");
            //dgvCodigoRetencionProveedor.Rows[0].Cells[1].Value = columnaComboFI;
            Program.FormularioProveedorCompra = true;
            //for (int i = 0; i < 15; i++)
            //    dgvDatosProveedor.Rows.Add();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text != "" && txtNumeroIdentificacionProveedor.Text != "" && txtDireccionProveedor.Text != "" && cbCreditoProveedor.Text != "" && cbICEProveedor.Text != "" && cbCodigo101Proveedor.Text != "")
            {
                ////
                bool erroresIdentificacion = false;

                if (txtNumeroIdentificacionProveedor.Text != "")
                {
                    if (cbIdentificacionProveedor.SelectedIndex == 0)
                    {
                        if (!Funcion.VerificarCedula(txtNumeroIdentificacionProveedor.Text))
                        {
                            erroresIdentificacion = true;
                            MessageBox.Show("Ingrese la Cédula Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            txtNumeroIdentificacionProveedor.Focus();
                            txtNumeroIdentificacionProveedor.Select(0, txtNumeroIdentificacionProveedor.Text.Length);
                        }
                    }
                    if (cbIdentificacionProveedor.SelectedIndex == 1 && cbNaturalezaProveedor.SelectedIndex == 0)
                    {
                        if (txtNumeroIdentificacionProveedor.Text.Length == 13)
                        {
                            if (txtNumeroIdentificacionProveedor.Text.Substring(10, 3) != "001" || Funcion.VerificarCedula(txtNumeroIdentificacionProveedor.Text.Substring(0, 10)) == false)
                            {
                                erroresIdentificacion = true;
                                MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                txtNumeroIdentificacionProveedor.Focus();
                                txtNumeroIdentificacionProveedor.Select(0, txtNumeroIdentificacionProveedor.Text.Length);
                            }
                        }
                        else
                        {
                            erroresIdentificacion = true;
                            MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); txtNumeroIdentificacionProveedor.Focus();
                            txtNumeroIdentificacionProveedor.Select(0, txtNumeroIdentificacionProveedor.Text.Length);
                        }
                    }
                    else if (cbIdentificacionProveedor.SelectedIndex == 1 && cbNaturalezaProveedor.SelectedIndex == 1)
                    {
                        if (txtNumeroIdentificacionProveedor.Text.Length != 13)
                        {
                            erroresIdentificacion = true;
                            MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); txtNumeroIdentificacionProveedor.Focus();
                            txtNumeroIdentificacionProveedor.Select(0, txtNumeroIdentificacionProveedor.Text.Length);
                        }
                    }
                }
                if(!erroresIdentificacion)
                {
                    Proveedor ObjProvee = new Proveedor(txtFax.Text, ckbEstado.Checked, txtPlazo.Text, txtCodigo.Text, cbIdentificacionProveedor.Text,
                        txtNombreProveedor.Text, txtNumeroIdentificacionProveedor.Text, cbNacionalidadProveedor.Text, cbNaturalezaProveedor.Text,
                        txtDireccionProveedor.Text, txtRazonSocialProveedor.Text, txtEmailProveedor.Text, txtTelefonoProveedor.Text, txtCelularProveedor.Text,
                        txtGiraChequeProveedor.Text, txtResponsableProveedor.Text, cbTipoGastoProveedor.Text, cbTipoServicioProveedor.Text,
                        Convert.ToInt32(cbParroquiaProveedor.SelectedValue), ckbRISEProveedor.Checked, Convert.ToInt32(cbCuentaContableProveedor.SelectedValue), Convert.ToInt32(cbCreditoProveedor.SelectedValue), Convert.ToInt32(cbICEProveedor.SelectedValue), Convert.ToInt32(cbCodigo101Proveedor.SelectedValue), TxtCelularResponsable.Text);
                    if (!bandera_Estado)
                    {
                        String resultado = ObjProvee.InsertarProveedor(ObjProvee);
                        if (resultado == "Datos Guardados")
                        {
                            //string res = ObjProvee.InsertarAutorizacionProveedor()
                            ObjProvee.InsertarAutorizacionProveedor(dgvDatosAutorizacionProveedor, txtNumeroIdentificacionProveedor.Text);
                            ObjProvee.InsertarRetencion(dgvCodigoRetencionProveedor, txtNumeroIdentificacionProveedor.Text);
                            MessageBox.Show("Proveedor Registrado Correctamente ", "Exito", MessageBoxButtons.OK);
                            cargarDatos("1");
                            rbtActivosProveedor.Checked = true;
                            inicializarDatos();
                            if (Program.FormularioLlamado)
                            {
                                Program.FormularioLlamado = false;
                                Program.FormularioProveedorCompra = true;
                                consultas.BoolLlenarComboBox(FrmCompra.datosProveedor, "select IDPROVEEDOR AS Id, NOMBRES AS Texto from TbProveedor");
                                FrmCompra.datosProveedor.SelectedValue = consultas.ObtenerID("IDPROVEEDOR", "TbProveedor", "");
                                this.Close();
                            }
                        }
                        else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        else if (resultado == "Existe") { MessageBox.Show("Ya Existe el Proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    else if (bandera_Estado)
                    {
                        String Resultado = ObjProvee.ModificarProveedor(identificacion);
                        if (Resultado == "Correcto")
                        {
                            consultas.EjecutarSQL("DELETE FROM [dbo].[TbAutorizacionProveedor] WHERE IDPROVEEDOR = " + Convert.ToInt32(txtCodigo.Text));
                            ObjProvee.InsertarAutorizacionProveedor(dgvDatosAutorizacionProveedor, txtNumeroIdentificacionProveedor.Text);
                            consultas.EjecutarSQL("DELETE FROM [dbo].[TbRetencionProveedor] WHERE IDPROVEEDOR = " + Convert.ToInt32(txtCodigo.Text));
                            ObjProvee.InsertarRetencion(dgvCodigoRetencionProveedor, txtNumeroIdentificacionProveedor.Text);
                            MessageBox.Show("Proveedor Actualizado", "Exito");
                            cargarDatos("1");
                            rbtActivosProveedor.Checked = true;
                            identificacion = "";
                        }
                        else { MessageBox.Show("Error al actualizar Proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        bandera_Estado = false;
                        btnGuardarProveedor.Text = "&Guardar";
                        btnLimpiarProveedor.Text = "&Limpiar";
                        //Funcion.Limpiarobjetos(gbDatosAutorizacionProveedor);
                        inicializarDatos();
                    }
                }
            }
            else { MessageBox.Show("Ingrese los datos del Proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //string dato = "";
        //private DateTimePicker oDateTimePicker;
        //void oDateTimePickerdgvtarjeta_CloseUp(object sender, EventArgs e)
        //{
        //    // Hiding the control after use   
        //    oDateTimePicker.Visible = false;
        //    dgvDatosAutorizacionProveedor.Focus();
        //    dgvDatosAutorizacionProveedor.CurrentCell = dgvDatosAutorizacionProveedor.CurrentRow.Cells[3];
        //    dgvDatosAutorizacionProveedor.BeginEdit(true);

        //}

        //private void dateTimePickerdgvtarjeta_OnTextChange(object sender, EventArgs e)
        //{
        //    // Saving the 'Selected Date on Calendar' into DataGridView current cell  
        //    dgvDatosAutorizacionProveedor.CurrentRow.Cells[2].Value = oDateTimePicker.Text.ToString();
        //    dato = oDateTimePicker.Text.ToString();
        //    dgvDatosAutorizacionProveedor.Focus();
        //    dgvDatosAutorizacionProveedor.CurrentCell = dgvDatosAutorizacionProveedor.CurrentRow.Cells[3];
        //    dgvDatosAutorizacionProveedor.BeginEdit(true);

        //}


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (btnLimpiarProveedor.Text == "&Cancelar")
            {
                inicializarDatos();
                btnLimpiarProveedor.Text = "&Limpiar";
                btnGuardarProveedor.Text = "&Guardar";
            }
            else { inicializarDatos(); }
            bandera_Estado = false;
        }




        private void TxtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.ValidarLetrasPuntoNumero(e, txtNombreProveedor.Text);

            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion.validar_Num_Letras(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }


        private void RbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtActivosProveedor.Checked)
            {
                cargarDatos("1");
                //dgvDatosProveedor.Columns[1].HeaderText = "Desabilitar";
            }
            else if (rbtInactivosProveedor.Checked)
            {
                cargarDatos("0");
                //dgvDatosProveedor.Columns[1].HeaderText = "Habilitar";
            }
        }


        private void cargarDatos(string condicion)
        {
            consultas = new Consultas();
            //consultas.boolLlenarDataGridView(dgvDatosProveedor, "Select Identificacion,NOMBRES AS 'Nombre Proveedor', Nacionalidad,RAZONSOCIAL as 'Razón Social', Naturaleza, DIRECCION,  IDProveedor AS ID from TbProveedor WHERE ESTADO = " + condicion + ";");
            string consulta = "Select Identificacion,NOMBRES AS 'Nombre Proveedor', CELULAR AS Celular, RESPONSABLE AS Responsable, Naturaleza, DIRECCION,  IDProveedor AS ID from TbProveedor WHERE ESTADO =" + condicion;
            consultas.boolLlenarDataGridView(dgvDatosProveedor, consulta);
            dgvDatosProveedor.Columns["ID"].Visible = false;
        }

        private void TxtConsultar_TextChanged(object sender, EventArgs e)
        {
            if (rbtActivosProveedor.Checked)
            {
                string consulta = "Select Identificacion,NOMBRES AS 'Nombre Proveedor', CELULAR AS Celular, RESPONSABLE AS Responsable, Naturaleza, DIRECCION,  IDProveedor AS ID from TbProveedor WHERE ESTADO = 1 and (IDENTIFICACION like '%" + txtConsultarProveedor.Text + "%' or NOMBRES like '%" + txtConsultarProveedor.Text + "%')";
                //dgvDatosProveedor.Columns[1].HeaderText = "Desabilitar";
                //dgvDatosProveedor.Columns["ID"].Visible = false;
                consultas.boolLlenarDataGridView(dgvDatosProveedor, consulta);
            }
            else if (rbtInactivosProveedor.Checked)
            {
                string consulta = "Select Identificacion,NOMBRES AS 'Nombre Proveedor', CELULAR AS Celular, RESPONSABLE AS Responsable, Naturaleza, DIRECCION,  IDProveedor AS ID from TbProveedor WHERE ESTADO = 0 and (IDENTIFICACION like '%" + txtConsultarProveedor.Text + "%' or NOMBRES like '%" + txtConsultarProveedor.Text + "%')";
                //dgvDatosProveedor.Columns[1].HeaderText = "Habilitar";
                //dgvDatosProveedor.Columns["ID"].Visible = false;
                consultas.boolLlenarDataGrid(dgvDatosProveedor, consulta, 15, 6, 2);
            }
        }

        private void dgvDatosProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                Proveedor ObjProvee = new Proveedor();
                if (Convert.ToString(dgvDatosProveedor.CurrentRow.Cells[2].Value) != "")
                {
                    if (rbtActivosProveedor.Checked)
                    {
                        if (this.dgvDatosProveedor.Columns[e.ColumnIndex].Name == "DeshabilitarProveedor")
                        {
                            ObjProvee.EstadoProveedor(dgvDatosProveedor.CurrentRow.Cells[2].Value.ToString(), 2);
                            cargarDatos("1");
                        }
                    }
                    else if (rbtInactivosProveedor.Checked)
                    {
                        if (this.dgvDatosProveedor.Columns[e.ColumnIndex].Name == "DeshabilitarProveedor")
                        {
                            ObjProvee.EstadoProveedor(dgvDatosProveedor.CurrentRow.Cells[2].Value.ToString(), 1);
                            cargarDatos("0");
                        }
                    }

                    if (this.dgvDatosProveedor.Columns[e.ColumnIndex].Name == "modificarProveedor")
                    {
                        identificacion = dgvDatosProveedor.CurrentRow.Cells[2].Value.ToString();
                        tcProveedor.SelectedIndex = 0;
                        bandera_Estado = true;
                        //Llenar el DataTable
                        DataTable dt = consultas.BoolDataTable("Select * from TbProveedor where IDENTIFICACION = '" + identificacion + "'");
                        //Arreglo de byte en donde se almacenara la foto en bytes
                        byte[] MyData = new byte[0];
                        //Verificar si tiene Datos
                        if (dt.Rows.Count > 0)
                        {
                            DataRow myRow = dt.Rows[0];
                            txtCodigo.Text = myRow["IDPROVEEDOR"].ToString();
                            if (myRow["CODIGO"] != System.DBNull.Value)
                                TxtCodigo2.Text = myRow["CODIGO"].ToString();
                            txtNombreProveedor.Text = myRow["NOMBRES"].ToString();
                            txtNumeroIdentificacionProveedor.Text = myRow["IDENTIFICACION"].ToString();
                            txtDireccionProveedor.Text = myRow["DIRECCION"].ToString();
                            txtRazonSocialProveedor.Text = myRow["RAZONSOCIAL"].ToString();
                            txtCelularProveedor.Text = myRow["CELULAR"].ToString();
                            txtTelefonoProveedor.Text = myRow["TELEFONO"].ToString();
                            txtResponsableProveedor.Text = myRow["RESPONSABLE"].ToString();
                            txtPlazo.Text = myRow["PLAZO"].ToString();
                            txtEmailProveedor.Text = myRow["EMAIL"].ToString();
                            txtGiraChequeProveedor.Text = myRow["GIRACHEQUEA"].ToString();
                            txtFax.Text = myRow["FAX"].ToString();

                            ckbEstado.Checked = Convert.ToBoolean(myRow["ESTADO"]);
                            ckbRISEProveedor.Checked = Convert.ToBoolean(myRow["PROVEEDORRISE"]);


                            string tipoidentificacion = myRow["TIPOIDENTIFICACION"].ToString();
                            string nacionalidad = myRow["NACIONALIDAD"].ToString();
                            string naturaleza = myRow["NATURALEZA"].ToString();
                            string tipogasto = myRow["TIPOGASTO"].ToString();


                            cbIdentificacionProveedor.SelectedItem = myRow["TIPOIDENTIFICACION"].ToString();
                            cbNacionalidadProveedor.SelectedItem = myRow["NACIONALIDAD"].ToString();
                            cbNaturalezaProveedor.SelectedItem = myRow["NATURALEZA"].ToString();
                            cbTipoGastoProveedor.SelectedItem = myRow["TIPOGASTO"].ToString();







                            int idservicion = consultas.ObtenerID("IDSERVICIO", "TbTipoServicio", " where DESCRIPCION = '" + myRow["TIPOSERVICIO"].ToString() + "' ");

                            cbTipoServicioProveedor.SelectedValue = idservicion;
                            int indexservicio = cbTipoServicioProveedor.SelectedIndex;
                            cbTipoServicioProveedor.SelectedIndex = indexservicio;


                            if (myRow["IDCuentaContable"] != System.DBNull.Value)
                            {
                                cbCuentaContableProveedor.SelectedValue = Convert.ToInt32(myRow["IDCuentaContable"]);

                            }

                            int indexcuenta = cbCuentaContableProveedor.SelectedIndex;
                            cbCuentaContableProveedor.SelectedIndex = indexcuenta;

                            //cbCreditoProveedor.SelectedValue = Convert.ToInt32(myRow["CREDITO"]);
                            //int indexcredito = cbCreditoProveedor.SelectedIndex;
                            //cbCreditoProveedor.SelectedIndex = indexcredito;
                            if (myRow["CREDITO"] != System.DBNull.Value)
                            {
                                consultas.BoolLlenarComboBox(cbCreditoProveedor, "Select IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as TEXTO from TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(myRow["CREDITO"]));
                            }
                            if (myRow["ICE"] != System.DBNull.Value)
                            {
                                consultas.BoolLlenarComboBox(cbICEProveedor, "Select IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as TEXTO from TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(myRow["ICE"]));
                            }
                            if (myRow["CODIGO_101"] != System.DBNull.Value)
                            {
                                consultas.BoolLlenarComboBox(cbCodigo101Proveedor, "Select IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as TEXTO from TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(myRow["CODIGO_101"]));
                            }

                            //cbICEProveedor.SelectedValue = Convert.ToInt32(myRow["ICE"]);
                            //int indexcIce = cbICEProveedor.SelectedIndex;
                            //cbICEProveedor.SelectedIndex = indexcIce;

                            //cbCodigo101Proveedor.SelectedValue = Convert.ToInt32(myRow["CODIGO_101"]);
                            //int indexCodigo101 = cbCodigo101Proveedor.SelectedIndex;
                            //cbCodigo101Proveedor.SelectedIndex = indexCodigo101;

                            string sqlRetencion = "select c.IDCODIGOSRI,  c.DESCRIPCION, tc.CODIGO, c.RETENCION,' ' , c.FECHAVALIDODESDE +''+ c.FECHAVALIDOHASTA as VALIDEZ " +
    " from TbRetencionProveedor rp, TbProveedor p, TbCodigoSRI C, TbTipoCodigoSRI tc" +
    " where p.IDPROVEEDOR = rp.IDPROVEEDOR and c.IDCODIGOSRI = rp.IDRETENCION and tc.IDTIPOCODIGOSRI = c.IDTIPOCODIGOSRI and p.IDENTIFICACION = '" + Convert.ToString(dgvDatosProveedor.CurrentRow.Cells[2].Value) + "'";
                            consultas.boolLlenarDataGrid(dgvCodigoRetencionProveedor, sqlRetencion, 5, 5, 0);

                            consultas.LLenarCombosUbicacion(Convert.ToInt32(myRow["IDPARROQUIA"]), ref cbPaisProveedor, ref cbProvinciaProveedor, ref cbCantonProveedor, ref cbParroquiaProveedor);

                            int IDPROVEEDOR = consultas.ObtenerID("IDPROVEEDOR", "TbProveedor", " where IDENTIFICACION = '" + myRow["IDENTIFICACION"].ToString() + "' ");

                            //llenar datagridview DatosAutorizacion
                            consultas.BoolCrearDateTableProveedoresAutorizacion(dgvDatosAutorizacionProveedor, "Select * from TbAutorizacionProveedor where IDPROVEEDOR = '" + IDPROVEEDOR + "'");


                            btnLimpiarProveedor.Text = "&Cancelar";
                            btnGuardarProveedor.Text = "&Modificar";
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbPaisProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaisProveedor.SelectedValue.ToString() != null)
            {
                String ID = cbPaisProveedor.SelectedValue.ToString();
                consultas = new Consultas();
                consultas.BoolLlenarComboBox(cbProvinciaProveedor, "Select IDPROVINCIA as ID, NOMBRE AS Texto from TbProvincia where IDPAIS = " + ID + ";");
            }
        }

        private void cbProvinciaProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvinciaProveedor.SelectedValue.ToString() != null)
            {
                String ID = cbProvinciaProveedor.SelectedValue.ToString();
                consultas = new Consultas();
                consultas.BoolLlenarComboBox(cbCantonProveedor, "Select IDCANTON as ID, NOMBRE AS Texto from TbCanton where IDPROVINCIA = " + ID + ";");
            }
        }

        private void cbCantonProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCantonProveedor.SelectedValue.ToString() != null)
            {
                String ID = cbCantonProveedor.SelectedValue.ToString();
                consultas = new Consultas();
                consultas.BoolLlenarComboBox(cbParroquiaProveedor, "Select IDPARROQUIA as ID, NOMBRE AS Texto from TbParroquia where IDCANTON = " + ID + ";");
            }
        }

        private void txtNumeroIdentificacionProveedor_Leave(object sender, EventArgs e)
        {
            //if (txtNumeroIdentificacionProveedor.Text != "")
            //{
            //    if (cbIdentificacionProveedor.SelectedIndex == 0)
            //    {
            //        if (!Funcion.VerificarCedula(txtNumeroIdentificacionProveedor.Text))
            //        {
            //            MessageBox.Show("Ingrese la Cédula Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //            txtNumeroIdentificacionProveedor.Focus();
            //            txtNumeroIdentificacionProveedor.Select(0, txtNumeroIdentificacionProveedor.Text.Length);
            //        }
            //    }
            //    if (cbIdentificacionProveedor.SelectedIndex == 1 && cbNaturalezaProveedor.SelectedIndex == 0)
            //    {
            //        if (txtNumeroIdentificacionProveedor.Text.Length == 13)
            //        {
            //            if (txtNumeroIdentificacionProveedor.Text.Substring(10, 3) != "001" || Funcion.VerificarCedula(txtNumeroIdentificacionProveedor.Text.Substring(0, 10)) == false)
            //            {
            //                MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //                txtNumeroIdentificacionProveedor.Focus();
            //                txtNumeroIdentificacionProveedor.Select(0, txtNumeroIdentificacionProveedor.Text.Length);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); txtNumeroIdentificacionProveedor.Focus();
            //            txtNumeroIdentificacionProveedor.Select(0, txtNumeroIdentificacionProveedor.Text.Length);
            //        }
            //    }
            //    else if (cbIdentificacionProveedor.SelectedIndex == 1 && cbNaturalezaProveedor.SelectedIndex == 1)
            //    {
            //        if (txtNumeroIdentificacionProveedor.Text.Length != 13)
            //        {
            //            MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); txtNumeroIdentificacionProveedor.Focus();
            //            txtNumeroIdentificacionProveedor.Select(0, txtNumeroIdentificacionProveedor.Text.Length);
            //        }
            //    }
            //}
        }

        private void dgvDatosProveedor_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvDatosProveedor.Columns[e.ColumnIndex].Name == "modificarProveedor" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = dgvDatosProveedor.Rows[e.RowIndex].Cells["modificarProveedor"] as DataGridViewButtonCell;
                //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\modificarDgv.ico");

                Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.modificarDgv);
                IntPtr Hicon = bitmap.GetHicon();
                Icon icoAtomico = Icon.FromHandle(Hicon);
                //bitmap.SetResolution(72, 72);

                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                dgvDatosProveedor.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dgvDatosProveedor.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }

            if (rbtInactivosProveedor.Checked)
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosProveedor.Columns[e.ColumnIndex].Name == "DeshabilitarProveedor" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosProveedor.Rows[e.RowIndex].Cells["DeshabilitarProveedor"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\Habilitar.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.Habilitar);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosProveedor.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosProveedor.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosProveedor.Columns[e.ColumnIndex].Name == "DeshabilitarProveedor" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosProveedor.Rows[e.RowIndex].Cells["DeshabilitarProveedor"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\EliminarDgv.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.EliminarDgv);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosProveedor.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosProveedor.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }

        private void dgvDatosProveedor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        //--------------------------------------------------------------COMBOMULTICOLUMN CREDITO--------------------------------------------------------------
        bool apareceDataDeCombos = true;
        private void dgvCredito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            consultas.BoolLlenarComboBox(cbCreditoProveedor, "SELECT IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as Texto FROM TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(dgvCredito.CurrentRow.Cells[0].Value));
            dgvCredito.Visible = false;
            apareceDataDeCombos = true;
            cbICEProveedor.Focus();

        }
        private void cbCreditoProveedor_Enter(object sender, EventArgs e)
        {
            if (apareceDataDeCombos)
            {
                dgvCredito.Visible = true;
                dgvICE.Visible = false;
                dgvCodigo101.Visible = false;
                consultas.boolLlenarDataGridView(dgvCredito, "select CS.IDCODIGOSRI, '[' + CS.CODIGOSRI + '] - ' + CS.DESCRIPCION as CODIGO_SRI, TCS.CODIGO AS TIPO, CS.RETENCION AS RETENCION, CS.FECHAVALIDODESDE AS DESDE, CS.FECHAVALIDOHASTA AS HASTA from TbCodigoSRI CS, TbTipoCodigoSRI TCS WHERE TCS.IDTIPOCODIGOSRI = CS.IDTIPOCODIGOSRI AND TCS.CODIGO = 'COD_IDCREDITO'");
                dgvCredito.Columns["IDCODIGOSRI"].Visible = false;
                dgvCredito.Columns["CODIGO_SRI"].Width = 400;
                dgvCredito.Columns["TIPO"].Width = 125;
                dgvCredito.Focus();
                dgvCredito.CurrentCell = dgvCredito.Rows[0].Cells[1];
            }
            else
            {
                dgvCredito.Visible = false;
                apareceDataDeCombos = true;
                if (cbCreditoProveedor.SelectedText != "")
                {
                    cbICEProveedor.Focus();
                }
                else
                    dgvCodigoRetencionProveedor.Focus();
            }
        }
        private void dgvCredito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                consultas.BoolLlenarComboBox(cbCreditoProveedor, "SELECT IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as Texto FROM TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(dgvCredito.CurrentRow.Cells[0].Value));
                dgvCredito.Visible = false;
                //----Si no funciona es esto
                apareceDataDeCombos = true;
                //-------------------------
                cbICEProveedor.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                dgvCredito.Visible = false;
                cbICEProveedor.Focus();
            }
        }

        private void dgvCredito_Enter(object sender, EventArgs e)
        {
            apareceDataDeCombos = false;
            dgvCredito.BringToFront();
        }
        //--------------------------------------------------------------COMBOMULTICOLUMN ICE--------------------------------------------------------------
        private void cbICEProveedor_Enter(object sender, EventArgs e)
        {
            if (apareceDataDeCombos)
            {
                dgvICE.Visible = true;
                dgvCredito.Visible = false;
                dgvCodigo101.Visible = false;
                consultas.boolLlenarDataGridView(dgvICE, "select CS.IDCODIGOSRI, '[' + CS.CODIGOSRI + '] - ' + CS.DESCRIPCION as CODIGO_SRI, TCS.CODIGO AS TIPO, CS.RETENCION AS RETENCION, CS.FECHAVALIDODESDE AS DESDE, CS.FECHAVALIDOHASTA AS HASTA from TbCodigoSRI CS, TbTipoCodigoSRI TCS WHERE TCS.IDTIPOCODIGOSRI = CS.IDTIPOCODIGOSRI AND TCS.CODIGO = 'COD_ICE'");
                dgvICE.Columns["IDCODIGOSRI"].Visible = false;
                dgvICE.Columns["CODIGO_SRI"].Width = 400;
                dgvICE.Columns["TIPO"].Width = 125;
                dgvICE.Focus();
                dgvICE.CurrentCell = dgvICE.Rows[0].Cells[1];
            }
            else
            {
                dgvICE.Visible = false;
                apareceDataDeCombos = true;
                if (cbICEProveedor.SelectedText != "")
                {
                    cbCodigo101Proveedor.Focus();
                }
                else
                    dgvCodigoRetencionProveedor.Focus();

            }

        }

        private void dgvICE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            consultas.BoolLlenarComboBox(cbICEProveedor, "SELECT IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as Texto FROM TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(dgvICE.CurrentRow.Cells[0].Value));
            dgvICE.Visible = false;
            apareceDataDeCombos = true;
            cbCodigo101Proveedor.Focus();
        }

        private void dgvICE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                consultas.BoolLlenarComboBox(cbICEProveedor, "SELECT IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as Texto FROM TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(dgvICE.CurrentRow.Cells[0].Value));
                dgvICE.Visible = false;
                //----Si no funciona es esto
                apareceDataDeCombos = true;
                //-------------------------
                cbCodigo101Proveedor.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                dgvICE.Visible = false;
                cbCodigo101Proveedor.Focus();
            }
        }

        private void dgvICE_Enter(object sender, EventArgs e)
        {
            apareceDataDeCombos = false;
            dgvICE.BringToFront();
        }
        //--------------------------------------------------------------COMBOMULTICOLUMN 101--------------------------------------------------------------
        private void cbCodigo101Proveedor_Enter(object sender, EventArgs e)
        {
            if (apareceDataDeCombos)
            {
                dgvCodigo101.Visible = true;
                dgvCredito.Visible = false;
                dgvICE.Visible = false;
                consultas.boolLlenarDataGridView(dgvCodigo101, "select CS.IDCODIGOSRI, '[' + CS.CODIGOSRI + '] - ' + CS.DESCRIPCION as CODIGO_SRI, TCS.CODIGO AS TIPO, CS.RETENCION AS RETENCION, CS.FECHAVALIDODESDE AS DESDE, CS.FECHAVALIDOHASTA AS HASTA from TbCodigoSRI CS, TbTipoCodigoSRI TCS WHERE TCS.IDTIPOCODIGOSRI = CS.IDTIPOCODIGOSRI AND TCS.CODIGO = 'COD_101'");
                dgvCodigo101.Columns["IDCODIGOSRI"].Visible = false;
                dgvCodigo101.Columns["CODIGO_SRI"].Width = 400;
                dgvCodigo101.Columns["TIPO"].Width = 125;
                dgvCodigo101.Focus();
                dgvCodigo101.CurrentCell = dgvCodigo101.Rows[0].Cells[1];
            }
            else
            {
                dgvCodigo101.Visible = false;
                apareceDataDeCombos = true;
                dgvDatosAutorizacionProveedor.Focus();

            }
        }

        private void dgvCodigo101_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            consultas.BoolLlenarComboBox(cbCodigo101Proveedor, "SELECT IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as Texto FROM TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(dgvCodigo101.CurrentRow.Cells[0].Value));
            dgvCodigo101.Visible = false;
            apareceDataDeCombos = true;
            dgvDatosAutorizacionProveedor.Focus();
        }

        private void dgvCodigo101_Enter(object sender, EventArgs e)
        {
            apareceDataDeCombos = false;
            dgvCodigo101.BringToFront();
        }

        private void dgvCodigo101_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                consultas.BoolLlenarComboBox(cbCodigo101Proveedor, "SELECT IDCODIGOSRI as ID, '[' + CODIGOSRI + '] - ' + DESCRIPCION as Texto FROM TbCodigoSRI where IDCODIGOSRI =" + Convert.ToInt32(dgvCodigo101.CurrentRow.Cells[0].Value));
                dgvCodigo101.Visible = false;
                //----Si no funciona es esto
                apareceDataDeCombos = true;
                //-------------------------
                dgvDatosAutorizacionProveedor.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                dgvCodigo101.Visible = false;
                dgvDatosAutorizacionProveedor.Focus();
            }
        }
        //--------------------------------------------------------------DataGridViewRetencion--------------------------------------------------------------
        private void dgvCodigoRetencionProveedor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView Grid = (DataGridView)sender;
            Rectangle Rec = default(Rectangle);
            // Si la coolumna es la que quiero
            if (e.ColumnIndex == 1)
            {
                Rec = Grid.GetCellDisplayRectangle(Grid.CurrentCell.ColumnIndex, Grid.CurrentCell.RowIndex, false);
                dgvRetencionFuenteIva.Visible = true;
                dgvRetencionFuenteIva.BringToFront();
                dgvRetencionFuenteIva.Location = new Point(Rec.X + 78, Rec.Y + 50);

                if (dgvRetencionFuenteIva.Visible)
                {
                    consultas.boolLlenarDataGridView(dgvRetencionFuenteIva, "select CS.IDCODIGOSRI, '[' + CS.CODIGOSRI + '] - ' + CS.DESCRIPCION as CODIGO_SRI, TCS.CODIGO AS TIPO, CS.RETENCION AS RETENCION, CS.FECHAVALIDODESDE AS DESDE, CS.FECHAVALIDOHASTA AS HASTA from TbCodigoSRI CS, TbTipoCodigoSRI TCS WHERE TCS.IDTIPOCODIGOSRI = CS.IDTIPOCODIGOSRI AND TCS.CODIGO = 'COD_RET_FUE' or TCS.CODIGO = 'COD_RET_IVA'");
                    dgvRetencionFuenteIva.Columns["IDCODIGOSRI"].Visible = false;
                    dgvRetencionFuenteIva.Columns["CODIGO_SRI"].Width = 400;
                    dgvRetencionFuenteIva.Columns["TIPO"].Width = 125;
                    dgvRetencionFuenteIva.Focus();
                    dgvRetencionFuenteIva.CurrentCell = dgvRetencionFuenteIva.Rows[0].Cells[1];
                }
            }
        }

        private void dgvRetencionFuenteIva_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvRetencionFuenteIva_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvRetencionFuenteIva.Columns[e.ColumnIndex].HeaderText == "CODIGO_SRI")
            {
                dgvCodigoRetencionProveedor.Rows.Add();
                dgvCodigoRetencionProveedor.CurrentRow.Cells[0].Value = dgvRetencionFuenteIva.CurrentRow.Cells[0].Value;
                dgvCodigoRetencionProveedor.CurrentRow.Cells[1].Value = dgvRetencionFuenteIva.CurrentRow.Cells[1].Value;
                if (Convert.ToString(dgvRetencionFuenteIva.CurrentRow.Cells[2].Value) == "COD_RET_IVA")
                {
                    tipoRetencion = "IVA";
                }
                else if (Convert.ToString(dgvRetencionFuenteIva.CurrentRow.Cells[2].Value) == "COD_RET_FUE")
                {
                    tipoRetencion = "FUENTE";
                }
                dgvCodigoRetencionProveedor.CurrentRow.Cells[2].Value = tipoRetencion;
                dgvCodigoRetencionProveedor.CurrentRow.Cells[3].Value = dgvRetencionFuenteIva.CurrentRow.Cells[3].Value;
                string[] s = dgvRetencionFuenteIva.CurrentRow.Cells[5].Value.ToString().Split(' ');
                dgvCodigoRetencionProveedor.CurrentRow.Cells[5].Value = s[0];
                dgvCodigoRetencionProveedor.CurrentCell = dgvCodigoRetencionProveedor.CurrentRow.Cells[2];
                dgvRetencionFuenteIva.Visible = false;
                dgvCodigoRetencionProveedor.Focus();
            }
        }
        string tipoRetencion;
        private void dgvRetencionFuenteIva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvCodigoRetencionProveedor.Rows.Add();
                dgvCodigoRetencionProveedor.CurrentRow.Cells[0].Value = dgvRetencionFuenteIva.CurrentRow.Cells[0].Value;
                dgvCodigoRetencionProveedor.CurrentRow.Cells[1].Value = dgvRetencionFuenteIva.CurrentRow.Cells[1].Value;
                if (Convert.ToString(dgvRetencionFuenteIva.CurrentRow.Cells[2].Value) == "COD_RET_IVA")
                {
                    tipoRetencion = "IVA";
                }
                else if (Convert.ToString(dgvRetencionFuenteIva.CurrentRow.Cells[2].Value) == "COD_RET_FUE")
                {
                    tipoRetencion = "FUENTE";
                }
                dgvCodigoRetencionProveedor.CurrentRow.Cells[2].Value = tipoRetencion;
                dgvCodigoRetencionProveedor.CurrentRow.Cells[3].Value = dgvRetencionFuenteIva.CurrentRow.Cells[3].Value;
                string[] s = dgvRetencionFuenteIva.CurrentRow.Cells[5].Value.ToString().Split(' ');
                dgvCodigoRetencionProveedor.CurrentRow.Cells[5].Value = s[0];
                dgvCodigoRetencionProveedor.CurrentCell = dgvCodigoRetencionProveedor.CurrentRow.Cells[2];
                dgvRetencionFuenteIva.Visible = false;
                dgvCodigoRetencionProveedor.Focus();
            }
            if (e.KeyCode == Keys.Escape && Convert.ToString(dgvCodigoRetencionProveedor.CurrentRow.Cells[1].Value) == "")
            {
                dgvCodigoRetencionProveedor.Focus();
                try
                {
                    dgvCodigoRetencionProveedor.CurrentCell = dgvCodigoRetencionProveedor.CurrentRow.Cells[2];
                }
                catch { }
                dgvRetencionFuenteIva.Visible = false;
            }
            else if (e.KeyCode == Keys.Escape && Convert.ToString(dgvCodigoRetencionProveedor.CurrentRow.Cells[1].Value) != "")
            {
                try
                {
                    dgvCodigoRetencionProveedor.CurrentCell = dgvCodigoRetencionProveedor.CurrentRow.Cells[2];
                    dgvRetencionFuenteIva.Visible = false;
                    dgvCodigoRetencionProveedor.Focus();
                }
                catch { }
            }
        }

        private void dgvRetencionFuenteIva_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(dgvCodigoRetencionProveedor.CurrentRow.Cells[1].Value) == "" && dgvCodigoRetencionProveedor.CurrentCell == dgvCodigoRetencionProveedor.Rows[dgvCodigoRetencionProveedor.RowCount - 1].Cells[1])
            {
                dgvCodigoRetencionProveedor.Rows.Add();
                dgvCodigoRetencionProveedor.CurrentCell = dgvCodigoRetencionProveedor.Rows[dgvCodigoRetencionProveedor.Rows.Count - 2].Cells[1];
                dgvCodigoRetencionProveedor.Focus();
            }
        }
        //----------------------------------Funcion para dar el foco en la pagina 2
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dgvCodigoRetencionProveedor.CurrentCell = dgvCodigoRetencionProveedor.CurrentRow.Cells[2];
                dgvRetencionFuenteIva.Visible = false;
                ckbContribuyenteEspecialProveedor.Focus();
            }
        }

        //--------------------------------------------------------------DATAGRIDVIEW CON DATETIMEPICKER--------------------------------------------------------------
        private void dgvDatosAutorizacionProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvDatosAutorizacionProveedor.CurrentCell == this.dgvDatosAutorizacionProveedor.CurrentRow.Cells[3] )
            //{
            //    //Initialized a new DateTimePicker Control  
            //    oDateTimePicker = new DateTimePicker();

            //    //Adding DateTimePicker control into DataGridView   
            //    dgvDatosAutorizacionProveedor.Controls.Add(oDateTimePicker);

            //    // Setting the format (i.e. 2014-10-10)  
            //    oDateTimePicker.Format = DateTimePickerFormat.Short;
        }
        DateTimePicker dtpOrder;

        private void dgvDatosAutorizacionProveedor_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if ((dgvDatosAutorizacionProveedor.Focused) && (dgvDatosAutorizacionProveedor.CurrentCell.ColumnIndex == 3))
                {
                    dtpOrder.Location = dgvDatosAutorizacionProveedor.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    dtpOrder.Visible = true;
                    if (dgvDatosAutorizacionProveedor.CurrentCell.Value != null)
                    {
                        dtpOrder.Value = (DateTime)dgvDatosAutorizacionProveedor.CurrentCell.Value;
                    }
                    else { dtpOrder.Value = DateTime.Today; }

                }
                else
                {
                    dtpOrder.Visible = false;
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
        }

        private void dgvDatosAutorizacionProveedor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((dgvDatosAutorizacionProveedor.Focused) && (dgvDatosAutorizacionProveedor.CurrentCell.ColumnIndex == 3))
                {
                    dgvDatosAutorizacionProveedor.CurrentCell.Value = dtpOrder.Value.Date.ToShortDateString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dtpOrden_ValueChanged(object sender, EventArgs e)
        {
            dgvDatosAutorizacionProveedor.CurrentCell.Value = dtpOrder.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmailProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }
        private void rbtInactivosProveedor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbIdentificacionProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void tabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dgvCredito_Leave(object sender, EventArgs e)
        {
            //if(cbCreditoProveedor.Focus() == false)
            //{
            //    dgvCredito.Visible = false;
            //}
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            switch(txtCodigo.Text.Length)
            {
                case 1:
                    txtCodigo.Text = "000" + txtCodigo.Text;
                break;
                case 2:
                    txtCodigo.Text = "00" + txtCodigo.Text;
                break;
                case 3:
                    txtCodigo.Text = "0" + txtCodigo.Text;
                break;
                default:
                    break;
            }
            //txtCodigo.Text = GlobalCodigoProveedor;
        }

        private void FrmProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FormularioProveedorCompra = false;
            inicializarDatos();
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvDatosProveedor.Rows.Count > 0)
            {
                if (Funcion.ExportarDataGridViewExcel(dgvDatosProveedor,2))
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