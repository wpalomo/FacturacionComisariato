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

namespace Comisariato.Formularios.Mantenimiento.Empresa
{
    public partial class FrmSucursal : Form
    {
        public FrmSucursal()
        {
            InitializeComponent();
        }
        Consultas consultas;
        bool bandera_Estado = false;
        String GlovalRUC = "";
        String GlovalCodigoSucursal = "";
        int IDSucursal;
        private void cargarDatos(string condicion)
        {
            consultas = new Consultas();
            consultas.boolLlenarDataGridView(DgvDatosSucursal, "Select IDEMPRESA as ID, CODIGO, NOMBRESUCURSAL AS 'SUCURSAL',RUC,TELEFONO,JEFESUCURSAL,EMAIL,DIRECCION from TbSucursal WHERE ESTADO =" + condicion + ";");
            DgvDatosSucursal.Columns["ID"].Visible = false;
            consultas.BoolLlenarComboBox(CmbEmpresa, "Select IDEMPRESA as ID , NOMBRE as Texto  from TbEmpresa;");
        }

        public void inicializarDatos()
        {

            Funcion.Limpiarobjetos(gbDatosSucursal);

            if (CmbEmpresa.Items.Count > 0)
            {
                CmbEmpresa.SelectedIndex = 0;
            }
            ckbEstadoSucursal.Checked = true;

            // llenar datadrigview solo los activos
            cargarDatos("1");

            IDSucursal = consultas.ObtenerID("IDSUCURSAL", "TbSucursal", "");
            if (IDSucursal > 0)
            {
                GlovalCodigoSucursal = (IDSucursal + 1).ToString();
            }
            else { GlovalCodigoSucursal = "1"; }

            switch (GlovalCodigoSucursal.Length)
            {
                case 1:
                    GlovalCodigoSucursal = "00" + GlovalCodigoSucursal;
                    break;
                case 2:
                    GlovalCodigoSucursal = "0" + GlovalCodigoSucursal;
                    break;
                default:
                    GlovalCodigoSucursal = "0";
                    break;
            }
            txtCodigoSucursal.Text = GlovalCodigoSucursal;
        }

        private void FrmSucursal_Load(object sender, EventArgs e)
        {
            inicializarDatos();
        }

        private void txtCodigoSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.validar_Num_Letras(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtJefeSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Letras(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SinEspaciosEmail(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtUbicacionSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion.validar_Num_Letras(e);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void rbtInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtActivos.Checked)
            {
                cargarDatos("1");
                //DgvDatosSucursal.Columns[1].HeaderText = "Desabilitar";
            }
            else if (rbtInactivos.Checked)
            {
                cargarDatos("0");
                //DgvDatosSucursal.Columns[1].HeaderText = "Habilitar";
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbtActivos.Checked)
            {
                consultas.boolLlenarDataGridView(DgvDatosSucursal, "Select IDEMPRESA as ID, CODIGO, NOMBRESUCURSAL AS 'SUCURSAL',RUC,TELEFONO,JEFESUCURSAL,EMAIL,DIRECCION from TbSucursal WHERE ESTADO  = 1 and RUC like '%" + TxtBuscar.Text + "%' or NOMBRESUCURSAL like '%" + TxtBuscar.Text + "%' or CODIGO like '%" + TxtBuscar.Text + "%' ;");
                //DgvDatosSucursal.Columns[1].HeaderText = "Desabilitar";
                DgvDatosSucursal.Columns["ID"].Visible = false;
            }
            else if (rbtInactivos.Checked)
            {
                consultas.boolLlenarDataGridView(DgvDatosSucursal, "Select IDEMPRESA as ID, CODIGO, NOMBRESUCURSAL AS 'SUCURSAL',RUC,TELEFONO,JEFESUCURSAL,EMAIL,DIRECCION from TbSucursal WHERE ESTADO  = 0 and RUC like '%" + TxtBuscar + "%' or NOMBRESUCURSAL like '%" + TxtBuscar.Text + "%' or CODIGO like '%" + TxtBuscar.Text + "%' ;");
                //DgvDatosSucursal.Columns[1].HeaderText = "Habilitar";
                DgvDatosSucursal.Columns["ID"].Visible = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigoSucursal.Text != "" && txtSucursal.Text != "" && txtRUCSucursal.Text != "" && txtCelular.Text != "" && txtJefeSucursal.Text != "" )
            {
                Sucursal ObjSucursal = new Sucursal(txtCodigoSucursal.Text, txtSucursal.Text, txtRUCSucursal.Text, txtTelefonoSucursal.Text, txtCelular.Text, txtJefeSucursal.Text, TxtEmail.Text, txtDireccionSucursal.Text, txtUbicacionSucursal.Text, Convert.ToInt32(CmbEmpresa.SelectedValue), ckbEstadoSucursal.Checked);
                if (!bandera_Estado) // Para identificar si se va ingresar
                {
                    String resultado = ObjSucursal.InsertarSucursal(); // retorna true si esta correcto todo
                    if (resultado == "Datos Guardados")
                    {
                        MessageBox.Show("Sucursal Registrada Correctamente ", "Exito", MessageBoxButtons.OK);
                        rbtActivos.Checked = true;
                        inicializarDatos();

                        btnLimpiar.Text = "&Limpiar";
                    }
                    else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else if (resultado == "Existe") { MessageBox.Show("Ya Existe la Sucursal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else if (bandera_Estado) // Para identificar si se va modificar
                {
                    String Resultado = ObjSucursal.ModificarSucursal(GlovalRUC); // retorna true si esta correcto todo
                    if (Resultado == "Correcto")
                    {
                        MessageBox.Show("Sucursal Actualizada", "Exito");
                        rbtActivos.Checked = true;
                        GlovalRUC = "";
                    }
                    else { MessageBox.Show("Error al actualizar Sucursal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    inicializarDatos();
                    bandera_Estado = false;
                    btnGuardar.Text = "&Guardar";
                }
                cargarDatos("1");
            }
            else { MessageBox.Show("Ingrese los datos de la Sucursal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void DgvDatosSucursal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Sucursal ObjSucursal = new Sucursal();
                if (rbtActivos.Checked)
                {
                    if (this.DgvDatosSucursal.Columns[e.ColumnIndex].Name == "Deshabilitar")
                    {
                        ObjSucursal.EstadoSucursal(DgvDatosSucursal.CurrentRow.Cells[5].Value.ToString(), 2);
                        cargarDatos("1");
                    }
                }
                else if (rbtInactivos.Checked)
                {
                    if (this.DgvDatosSucursal.Columns[e.ColumnIndex].Name == "Deshabilitar")
                    {
                        ObjSucursal.EstadoSucursal(DgvDatosSucursal.CurrentRow.Cells[5].Value.ToString(), 1);
                        cargarDatos("0");
                    }
                }

                if (this.DgvDatosSucursal.Columns[e.ColumnIndex].Name == "Modificar")
                {
                    //MessageBox.Show("modificar toca " + DgvDatosEmpleado.CurrentRow.Cells[3].Value.ToString());
                    GlovalRUC = DgvDatosSucursal.CurrentRow.Cells[5].Value.ToString();
                    tcSucursal.SelectedIndex = 0;
                    bandera_Estado = true;
                    //Llenar el DataTable
                    DataTable dt = consultas.BoolDataTable("Select * from TbSucursal where RUC = '" + GlovalRUC + "'");
                    //Arreglo de byte en donde se almacenara la foto en bytes
                    byte[] MyData = new byte[0];
                    //Verificar si tiene Datos
                    if (dt.Rows.Count > 0)
                    {
                        DataRow myRow = dt.Rows[0];

                        //Cargar los demas Datos
                        CmbEmpresa.SelectedValue = Convert.ToInt32(myRow["IDEMPRESA"]);
                        int codigo = Convert.ToInt32(myRow["CODIGO"].ToString());
                        txtCodigoSucursal.Text = codigo.ToString("D3");
                        txtSucursal.Text = myRow["NOMBRESUCURSAL"].ToString();
                        txtRUCSucursal.Text = myRow["RUC"].ToString();
                        txtTelefonoSucursal.Text = myRow["TELEFONO"].ToString();
                        //CmbParroquia
                        txtCelular.Text = myRow["CELULAR"].ToString();
                        txtJefeSucursal.Text = myRow["JEFESUCURSAL"].ToString();
                        TxtEmail.Text = myRow["EMAIL"].ToString();
                        txtDireccionSucursal.Text = myRow["DIRECCION"].ToString();
                        ckbEstadoSucursal.Checked = Convert.ToBoolean(myRow["ESTADO"]);
                        txtUbicacionSucursal.Text = myRow["UBICACION"].ToString();
                    }
                    btnLimpiar.Text = "&Cancelar";
                    btnGuardar.Text = "&Modificar";

                }

            }
            catch (Exception)
            {

            }
        }

        private void DgvDatosSucursal_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && DgvDatosSucursal.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = DgvDatosSucursal.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\modificarDgv.ico");

                Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.modificarDgv);
                IntPtr Hicon = bitmap.GetHicon();
                Icon icoAtomico = Icon.FromHandle(Hicon);
                //bitmap.SetResolution(72, 72);

                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                DgvDatosSucursal.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                DgvDatosSucursal.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }

            if (rbtInactivos.Checked)
            {
                if (e.ColumnIndex >= 1 && this.DgvDatosSucursal.Columns[e.ColumnIndex].Name == "Deshabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.DgvDatosSucursal.Rows[e.RowIndex].Cells["Deshabilitar"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\Habilitar.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.Habilitar);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.DgvDatosSucursal.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.DgvDatosSucursal.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.ColumnIndex >= 1 && this.DgvDatosSucursal.Columns[e.ColumnIndex].Name == "Deshabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.DgvDatosSucursal.Rows[e.RowIndex].Cells["Deshabilitar"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\EliminarDgv.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.EliminarDgv);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.DgvDatosSucursal.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.DgvDatosSucursal.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }

        private void txtRUCSucursal_Leave(object sender, EventArgs e)
        {
            if (txtRUCSucursal.Text != "")
            {
                if (txtRUCSucursal.Text.Length != 13 || txtRUCSucursal.Text.Substring(10, 3) != "001")
                {
                    MessageBox.Show("Ingrese el RUC Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtRUCSucursal.Focus();
                    txtRUCSucursal.Select(0, txtRUCSucursal.Text.Length);
                }
            }
        }

        private void CmbEmpresa_Enter(object sender, EventArgs e)
        {
            consultas.BoolLlenarComboBox(CmbEmpresa, "Select IDEMPRESA as ID , NOMBRE as Texto  from TbEmpresa;");
        }
    }
}
