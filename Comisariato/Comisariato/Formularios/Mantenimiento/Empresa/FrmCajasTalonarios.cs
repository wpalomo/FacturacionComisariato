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

namespace Comisariato.Formularios.Mantenimiento
{
    public partial class FrmCajasTalonario : Form
    {
        public FrmCajasTalonario()
        {
            InitializeComponent();
        }
        Consultas consultas = new Consultas();
        String GlobalIDCajaTalonario = "";
        bool bandera_Estado = false;

        public void inicializarDatos()
        {
            tcCajaTalonario.SelectedIndex = 0; //Seleccion el tab a mostrarse

            txtConsultarCaja.Text = "";
            txtDocumentoInicialCaja.Text = "";
            txtDocumentoActualCaja.Text = "";
            txtDocumentoFinalCaja.Text = "";
            txtSerie1Caja.Text = "";
            txtSerie2Caja.Text = "";
            txtAutorizacionCaja.Text = "";
            txtEstacionCaja.Text = "";
            TxtIP.Text = "";

            ckbActivoCaja.Checked = true;
            //cbTipoDocumentoCaja.SelectedIndex = 0;

            consultas.BoolLlenarComboBox(cbSucursalCaja, "Select IDSUCURSAL as ID, NOMBRESUCURSAL as TEXTO from TbSucursal where ESTADO = 1;");
            consultas.BoolLlenarComboBox(cbBodegaCaja, "Select IDBODEGA as ID, NOMBRE as TEXTO from TbBodega where ESTADO = 1;");
            consultas.BoolLlenarComboBox(cbTipoDocumentoCaja, "Select CODIGO as ID, DOCUMENTOTALONARIO as TEXTO from TbDocumentoTalonario;");


            //// llenar datadrigview solo los activos
            cargarDatos("1");
        }

        private void cargarDatos(string condicion)
        {
            consultas.boolLlenarDataGridView(dgvDatosCaja, "Select IDCAJATALONARIO AS ID, TIPODOCUMENTO as 'Tipo Doc.', TbSucursal.NOMBRESUCURSAL as 'SUCURSAL', TbBodega.NOMBRE as 'BODEGA',TbCajasTalonario.SERIE1 as 'Serie1',TbCajasTalonario.SERIE2 as 'Serie2', TbCajasTalonario.FECHACADUCIDAD as 'Fecha Caducidad', TbCajasTalonario.AUTORIZACION as 'Autorizacion',TbCajasTalonario.DOCUMENTOINICIAL as 'Doc. I.',TbCajasTalonario.DOCUMENTOFINAL AS 'Doc. F.',TbCajasTalonario.DOCUMENTOACTUAL AS 'Doc. A.',TbCajasTalonario.ESTACION as 'Estacion', TbCajasTalonario.IPESTACION as 'IP' from TbCajasTalonario, TbBodega,TbSucursal  where TbBodega.IDBODEGA = TbCajasTalonario.IDBODEGA and TbSucursal.IDSUCURSAL = TbCajasTalonario.IDSUCURSAL  and TbCajasTalonario.ESTADO = '" + condicion+"'");
            dgvDatosCaja.Columns["ID"].Visible = false;
            dgvDatosCaja.Columns["SUCURSAL"].Visible = false;
            dgvDatosCaja.Columns["BODEGA"].Visible = false;
            //dgvDatosCaja.Columns["Serie1"].Width = 65;
            //dgvDatosCaja.Columns["Serie2"].Width = 65;

        }


        private void dgvDatosCaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                CajaTalonarioEmpresa ObjCajaTalonarioEmpresa = new CajaTalonarioEmpresa();

                if (rbtActivos.Checked)
                {
                    if (this.dgvDatosCaja.Columns[e.ColumnIndex].Name == "Deshabilitar")
                    {
                        ObjCajaTalonarioEmpresa.EstadoCajaTalo(dgvDatosCaja.CurrentRow.Cells[2].Value.ToString(), 2);
                        cargarDatos("1");
                    }
                }
                else if (rbtInactivos.Checked)
                {
                    if (this.dgvDatosCaja.Columns[e.ColumnIndex].Name == "Deshabilitar")
                    {
                        ObjCajaTalonarioEmpresa.EstadoCajaTalo(dgvDatosCaja.CurrentRow.Cells[2].Value.ToString(), 1);
                        cargarDatos("0");
                    }
                }

                if (this.dgvDatosCaja.Columns[e.ColumnIndex].Name == "Modificar")
                {
                    //MessageBox.Show("modificar toca " + DgvDatosEmpleado.CurrentRow.Cells[3].Value.ToString());
                    GlobalIDCajaTalonario = dgvDatosCaja.CurrentRow.Cells[2].Value.ToString();
                    inicializarDatos();
                    tcCajaTalonario.SelectedIndex = 0;
                    bandera_Estado = true;
                    //Llenar el DataTable
                    DataTable dt = consultas.BoolDataTable("Select * from TbCajasTalonario where IDCAJATALONARIO = '" + GlobalIDCajaTalonario + "'");
                    //Verificar si tiene Datos
                    if (dt.Rows.Count > 0)
                    {
                        DataRow myRow = dt.Rows[0];
                        ////Cargar los demas Datos
                        txtSerie1Caja.Text = myRow["SERIE1"].ToString();
                        txtSerie2Caja.Text = myRow["SERIE2"].ToString();
                        txtDocumentoInicialCaja.Text = myRow["DOCUMENTOINICIAL"].ToString();
                        txtDocumentoFinalCaja.Text = myRow["DOCUMENTOFINAL"].ToString();
                        txtDocumentoActualCaja.Text = myRow["DOCUMENTOACTUAL"].ToString();
                        dtpFechaCaducidadCaja.Value = Convert.ToDateTime(myRow["FECHACADUCIDAD"].ToString());
                        ckbActivoCaja.Checked = Convert.ToBoolean(myRow["ESTADO"]);
                        txtEstacionCaja.Text = myRow["ESTACION"].ToString();
                        TxtIP.Text = myRow["IPESTACION"].ToString();
                        txtAutorizacionCaja.Text = myRow["AUTORIZACION"].ToString();




                        cbTipoDocumentoCaja.SelectedValue = myRow["TIPODOCUMENTO"].ToString();
                        int indexDocumentoCaja = cbTipoDocumentoCaja.SelectedIndex;
                        cbTipoDocumentoCaja.SelectedIndex = indexDocumentoCaja;

                        cbSucursalCaja.SelectedValue = Convert.ToInt32(myRow["IDSUCURSAL"]);
                        int indexSUCURSAL = cbSucursalCaja.SelectedIndex;
                        cbSucursalCaja.SelectedIndex = indexSUCURSAL;

                        cbBodegaCaja.SelectedValue = Convert.ToInt32(myRow["IDBODEGA"]);
                        int indexBODEGA = cbBodegaCaja.SelectedIndex;
                        cbBodegaCaja.SelectedIndex = indexBODEGA;

                    }
                    btnLimpiar.Text = "&Cancelar";
                    btnGuardar.Text = "&Modificar";

                }

            }
            catch (Exception)
            {

            }
        }

        private void dgvDatosCaja_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvDatosCaja.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = dgvDatosCaja.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\modificarDgv.ico");

                Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.modificarDgv);
                IntPtr Hicon = bitmap.GetHicon();
                Icon icoAtomico = Icon.FromHandle(Hicon);
                //bitmap.SetResolution(72, 72);

                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                dgvDatosCaja.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dgvDatosCaja.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }

            if (rbtInactivos.Checked)
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosCaja.Columns[e.ColumnIndex].Name == "Deshabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosCaja.Rows[e.RowIndex].Cells["Deshabilitar"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\Habilitar.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.Habilitar);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosCaja.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosCaja.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosCaja.Columns[e.ColumnIndex].Name == "Deshabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosCaja.Rows[e.RowIndex].Cells["Deshabilitar"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\EliminarDgv.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.EliminarDgv);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosCaja.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosCaja.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }

        private void FrmCajasTalonario_Load(object sender, EventArgs e)
        {
            inicializarDatos();
            cbTipoDocumentoCaja.DropDownHeight = cbTipoDocumentoCaja.ItemHeight = 150;
            cbBodegaCaja.DropDownHeight = cbBodegaCaja.ItemHeight = 150;
            cbSucursalCaja.DropDownHeight = cbSucursalCaja.ItemHeight = 150;
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (txtSerie1Caja.Text != "" && txtSerie2Caja.Text != "" && txtDocumentoActualCaja.Text != "" && txtDocumentoFinalCaja.Text != "" && txtDocumentoInicialCaja.Text != "" && txtAutorizacionCaja.Text != "" && txtEstacionCaja.Text != "" && TxtIP.Text != "")
            {

                CajaTalonarioEmpresa ObjCajaTalonarioEmpresa = new CajaTalonarioEmpresa(Convert.ToInt32(cbSucursalCaja.SelectedValue), Convert.ToInt32(cbBodegaCaja.SelectedValue), cbTipoDocumentoCaja.SelectedValue.ToString(), txtDocumentoInicialCaja.Text, txtDocumentoFinalCaja.Text, txtDocumentoActualCaja.Text, dtpFechaCaducidadCaja.Value.ToShortDateString().ToString(), ckbActivoCaja.Checked, txtEstacionCaja.Text, TxtIP.Text, txtSerie1Caja.Text, txtSerie2Caja.Text, txtAutorizacionCaja.Text);
                if (!bandera_Estado) // Para identificar si se va ingresar
                {
                    String resultado = ObjCajaTalonarioEmpresa.Insertar(); // retorna true si esta correcto todo
                    if (resultado == "Datos Guardados")
                    {
                        inicializarDatos();
                        cargarDatos("1");
                        MessageBox.Show("Registrado Correctamente ", "Exito", MessageBoxButtons.OK);
                        rbtActivos.Checked = true;
                    }
                    else if (resultado == "Error al Registrar")
                    {
                        MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (resultado == "Existe") { MessageBox.Show("Ya Existe la Serie", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else if (bandera_Estado) // Para identificar si se va modificar
                {
                    String Resultado = ObjCajaTalonarioEmpresa.Modificar(GlobalIDCajaTalonario); // retorna true si esta correcto todo
                    if (Resultado == "Correcto")
                    {
                        MessageBox.Show("Actualizado", "Exito");
                        rbtActivos.Checked = true;
                        GlobalIDCajaTalonario = "";
                    }
                    else { MessageBox.Show("Error al actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    inicializarDatos();
                    bandera_Estado = false;
                    btnGuardar.Text = "&Guardar";
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rbtInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtActivos.Checked)
            {
                cargarDatos("1");
            }
            else if (rbtInactivos.Checked)
            {
                cargarDatos("0");
            }
        }

        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            if (btnLimpiar.Text == "&Cancelar")
            {
                inicializarDatos();
                btnLimpiar.Text = "&Limpiar";
                btnGuardar.Text = "&Guardar";
            }
            else { inicializarDatos(); }
            bandera_Estado = false;
        }

        private void TxtIP_Leave(object sender, EventArgs e)
        {
            if (TxtIP.Text != "")
            {
                int ocurrenciasPunto = TxtIP.Text.Split('.').Length;
                if (!Funcion.ValidaIP(TxtIP.Text) || ocurrenciasPunto <= 3)
                {
                    MessageBox.Show("Ingrese una Dirección IP Correca", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    TxtIP.Focus();
                    TxtIP.SelectAll();
                }
            }
        }

        private void txtDocumentoInicialCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void txtEstacionCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.validar_Num_Letras(e);
        }

        private void TxtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros_Punto(e,TxtIP.Text);
        }

        private void txtConsultarCaja_TextChanged(object sender, EventArgs e)
        {
            if (rbtActivos.Checked)
            {
                consultas.boolLlenarDataGridView(dgvDatosCaja, "Select IDCAJATALONARIO AS ID, TIPODOCUMENTO as 'TIPO DOC.', TbSucursal.NOMBRESUCURSAL as 'SUCURSAL', TbBodega.NOMBRE,TbCajasTalonario.SERIE1,TbCajasTalonario.SERIE2, TbCajasTalonario.FECHACADUCIDAD as 'Fecha Caducidad', TbCajasTalonario.AUTORIZACION,TbCajasTalonario.DOCUMENTOINICIAL as 'DOC. I.',TbCajasTalonario.DOCUMENTOFINAL AS 'DOC. F.',TbCajasTalonario.DOCUMENTOACTUAL AS 'DOC. A.',TbCajasTalonario.ESTACION , TbCajasTalonario.IPESTACION from TbCajasTalonario INNER JOIN TbBodega ON (TbCajasTalonario.IDBODEGA = TbBodega.IDBODEGA) INNER JOIN  TbSucursal  ON (TbCajasTalonario.IDSUCURSAL = TbSucursal.IDSUCURSAL)  where   TbCajasTalonario.ESTADO = 1 and TIPODOCUMENTO like '%" + txtConsultarCaja.Text + "%' or AUTORIZACION like '%" + txtConsultarCaja.Text + "%'  or ESTACION like '%" + txtConsultarCaja.Text + "%';");
                //dgvDatosProveedor.Columns[1].HeaderText = "Desabilitar";
                dgvDatosCaja.Columns["ID"].Visible = false;
            }
            else if (rbtInactivos.Checked)
            {
                consultas.boolLlenarDataGridView(dgvDatosCaja, "Select IDCAJATALONARIO AS ID, TIPODOCUMENTO as 'TIPO DOC.', TbSucursal.NOMBRESUCURSAL as 'SUCURSAL', TbBodega.NOMBRE,TbCajasTalonario.SERIE1,TbCajasTalonario.SERIE2, TbCajasTalonario.FECHACADUCIDAD as 'Fecha Caducidad', TbCajasTalonario.AUTORIZACION,TbCajasTalonario.DOCUMENTOINICIAL as 'DOC. I.',TbCajasTalonario.DOCUMENTOFINAL AS 'DOC. F.',TbCajasTalonario.DOCUMENTOACTUAL AS 'DOC. A.',TbCajasTalonario.ESTACION , TbCajasTalonario.IPESTACION from TbCajasTalonario INNER JOIN TbBodega ON (TbCajasTalonario.IDBODEGA = TbBodega.IDBODEGA) INNER JOIN  TbSucursal  ON (TbCajasTalonario.IDSUCURSAL = TbSucursal.IDSUCURSAL)  where   TbCajasTalonario.ESTADO = 0 and TIPODOCUMENTO like '%" + txtConsultarCaja.Text + "%' or AUTORIZACION like '%" + txtConsultarCaja.Text + "%'  or ESTACION like '%" + txtConsultarCaja.Text + "%';");
                //dgvDatosProveedor.Columns[1].HeaderText = "Habilitar";
                dgvDatosCaja.Columns["ID"].Visible = false;
            }
        }

        private void TxtIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSerie1Caja_Leave(object sender, EventArgs e)
        {
            if (txtSerie1Caja.Text != "")
            {
                if (txtSerie1Caja.Text.Length < 3)
                {
                    MessageBox.Show("3 digitos por serie");
                    txtSerie1Caja.Focus();
                    txtSerie1Caja.SelectAll();
                }
            }
        }

        private void txtSerie2Caja_Leave(object sender, EventArgs e)
        {
            if (txtSerie2Caja.Text != "")
            {
                if (txtSerie2Caja.Text.Length < 3)
                {
                    MessageBox.Show("3 digitos por serie");
                    txtSerie2Caja.Focus();
                    txtSerie2Caja.SelectAll();
                }
            }
        }

        private void txtDocumentoInicialCaja_Leave(object sender, EventArgs e)
        {
            if (txtDocumentoInicialCaja.Text != "")
            {
                if (txtDocumentoInicialCaja.Text.Length < 9)
                {
                    MessageBox.Show("9 digitos");
                    txtDocumentoInicialCaja.Focus();
                    txtDocumentoInicialCaja.SelectAll();
                }
                if (txtDocumentoFinalCaja.Text != "")
                {
                    int inicial = 0, final = 0;
                    inicial = Convert.ToInt32(txtDocumentoInicialCaja.Text);
                    final = Convert.ToInt32(txtDocumentoFinalCaja.Text);
                    if (!(inicial < final))
                    {
                        MessageBox.Show("El Documento Inicial  deber ser Menor  al 'Documento Inicial'");
                        txtDocumentoActualCaja.SelectAll();
                    }
                }
            }

        }

        private void txtDocumentoFinalCaja_Leave(object sender, EventArgs e)
        {
            if (txtDocumentoFinalCaja.Text != "")
            {
                if (txtDocumentoFinalCaja.Text.Length < 9)
                {
                    MessageBox.Show("9 digitos");
                    txtDocumentoFinalCaja.Focus();
                    txtDocumentoFinalCaja.SelectAll();
                }
                if (txtDocumentoFinalCaja.Text != "")
                {
                    int inicial = 0, final = 0;
                    inicial = Convert.ToInt32(txtDocumentoInicialCaja.Text);
                    final = Convert.ToInt32(txtDocumentoFinalCaja.Text);

                    if (!(final > inicial))
                    {
                        MessageBox.Show("El Documento Final  deber ser Mayor al 'Documento Inicial'");
                        txtDocumentoActualCaja.SelectAll();
                    }
                }

            }
        }

        private void txtDocumentoActualCaja_Leave(object sender, EventArgs e)
        {
            if (txtDocumentoActualCaja.Text != "")
            {
                if (txtDocumentoActualCaja.Text.Length < 9)
                {
                    MessageBox.Show("9 digitos");
                    txtDocumentoActualCaja.Focus();
                    txtDocumentoActualCaja.SelectAll();
                }
                if (txtDocumentoFinalCaja.Text != "" && txtDocumentoInicialCaja.Text !="")
                {
                    int inicial = 0, final = 0, actual = 0;
                    inicial = Convert.ToInt32(txtDocumentoInicialCaja.Text);
                    final = Convert.ToInt32(txtDocumentoFinalCaja.Text);
                    actual = Convert.ToInt32(txtDocumentoActualCaja.Text);

                    if (!(actual >= inicial) && !(actual <= final))
                    {
                        MessageBox.Show("El Documento Actual debe ser Mayor o Igual al 'Documento Inicial' y deber ser Menor o Igual a 'Documento Final'");
                        txtDocumentoActualCaja.SelectAll();
                    }
                }
            }

        }

        private void cbSucursalCaja_Enter(object sender, EventArgs e)
        {
            consultas.BoolLlenarComboBox(cbSucursalCaja, "Select IDSUCURSAL as ID, NOMBRESUCURSAL as TEXTO from TbSucursal where ESTADO = 1;");
            consultas.BoolLlenarComboBox(cbBodegaCaja, "Select IDBODEGA as ID, NOMBRE as TEXTO from TbBodega where ESTADO = 1;");
            consultas.BoolLlenarComboBox(cbTipoDocumentoCaja, "Select CODIGO as ID, DOCUMENTOTALONARIO as TEXTO from TbDocumentoTalonario;");
        }
    }
}