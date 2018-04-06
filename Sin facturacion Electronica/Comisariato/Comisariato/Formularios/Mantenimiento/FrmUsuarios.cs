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

namespace Comisariato.Formularios
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        Consultas objConsul = new Consultas();

        bool bandera_Estado = false;
        String GlovalIDUsuario = "";
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                dgvDatosUsuario.Rows.Add();
            }
            inicializarDatos();
        }



        private void ckMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtContraseñaUsuario.Text;
            if (ckMostrarContra.Checked)
            {
                txtContraseñaUsuario.UseSystemPasswordChar = false;
                txtContraseñaUsuario.Text = text;
            }
            else
            {
                txtContraseñaUsuario.UseSystemPasswordChar = true;
                txtContraseñaUsuario.Text = text;
            }
        }

        public void inicializarDatos()
        {
            for (int i = 0; i < CheckListBEmpresas.Items.Count; i++)
            {
                CheckListBEmpresas.SetItemChecked(i, false);
            }
            txtConsultarUsuario.Text = "";
            TxtConfirmarContraUsuario.Text = "";
            txtContraseñaUsuario.Text = "";
            txtUsuario.Text = "";
            if (cbPersonaUsuario.Items.Count > 0)
            {
                cbPersonaUsuario.SelectedIndex = 0;
            }
            objConsul.BoolLlenarCheckListBox(CheckListBEmpresas, "Select IDEMPRESA as ID, NOMBRE as 'Texto' from TbEmpresa;");
            objConsul.BoolLlenarComboBox(cbPersonaUsuario, "Select IDEMPLEADO as ID,(E.APELLIDOS +' '+ E.NOMBRES) as Texto from TbEmpleado E  WHERE (E.NOMBRES != 'ADMINISTRADOR');");
            objConsul.BoolLlenarComboBox(cbTipoUsuario, "Select IDTIPOUSUARIO as ID,TIPO as Texto from TbTipousuario;");
            ckbFacturaUsuario.Checked = false;
            ckMostrarContra.Checked = false;
            cbPersonaUsuario.DropDownHeight = cbPersonaUsuario.ItemHeight = 150;
            cbTipoUsuario.DropDownHeight = cbTipoUsuario.ItemHeight = 150;
            cargarDatos("1");


        }

        private void cargarDatos(string condicion)
        {
            string consulta = "Select USUARIO,CONTRASEÑA,FACTURA, E.NOMBRE, IDUSUARIO as ID from TbUsuario U, TbEmpresa E where U.IDEMPRESA= E.IDEMPRESA AND ACTIVO = '" + condicion + "';";
            //dgvDatosUsuario.Columns["ID"].Visible = false;
            objConsul.boolLlenarDataGrid(dgvDatosUsuario, consulta, 10, 4, 2);
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseñaUsuario.Text != "" && TxtConfirmarContraUsuario.Text != "")
            {
                if (txtContraseñaUsuario.Text == TxtConfirmarContraUsuario.Text)
                {
                    Usuario ObjUsuario = new Usuario(Convert.ToInt32(cbPersonaUsuario.SelectedValue), txtUsuario.Text, txtContraseñaUsuario.Text, Convert.ToInt32(cbTipoUsuario.SelectedValue), Convert.ToInt32(CheckListBEmpresas.SelectedValue), ckbFacturaUsuario.Checked);
                    if (!bandera_Estado)
                    {
                        String resultado = ObjUsuario.InsertarUsuario(); // retorna true si esta correcto todo
                        if (resultado == "Datos Guardados")
                        {
                            MessageBox.Show("Usuario Registrado Correctamente ", "Exito", MessageBoxButtons.OK);
                            rbtActivos.Checked = true;
                            inicializarDatos();
                        }
                        else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        else if (resultado == "Existe") { MessageBox.Show("Ya Existe el Nombre de Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    else if (bandera_Estado) // Para identificar si se va modificar
                    {

                        String Resultado = ObjUsuario.ModificarUsuario(GlovalIDUsuario); // retorna true si esta correcto todo
                        if (Resultado == "Correcto")
                        {
                            MessageBox.Show("Usuario Actualizado", "Exito");
                            rbtActivos.Checked = true;
                            GlovalIDUsuario = "";
                        }
                        else { MessageBox.Show("Error al actualizar Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        inicializarDatos();
                        bandera_Estado = false;
                        btnGuardarUsuario.Text = "&Guardar";
                    }
                }
                else
                { MessageBox.Show("Las contraseñas no Coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else { MessageBox.Show("Ingrese los datos del Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            if (btnLimpiarProveedor.Text == "&Cancelar")
            {
                inicializarDatos();
                btnLimpiarProveedor.Text = "&Limpiar";
                btnGuardarUsuario.Text = "&Guardar";
            }
            else { inicializarDatos(); }
        }

        private void dgvDatosUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex >= 0 && dgvDatosUsuario.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = dgvDatosUsuario.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\modificarDgv.ico");

                Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.modificarDgv);
                IntPtr Hicon = bitmap.GetHicon();
                Icon icoAtomico = Icon.FromHandle(Hicon);
                //bitmap.SetResolution(72, 72);

                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                dgvDatosUsuario.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dgvDatosUsuario.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }

            if (rbtInactivos.Checked)
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosUsuario.Columns[e.ColumnIndex].Name == "Deshabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosUsuario.Rows[e.RowIndex].Cells["Deshabilitar"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\Habilitar.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.Habilitar);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosUsuario.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosUsuario.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosUsuario.Columns[e.ColumnIndex].Name == "Deshabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosUsuario.Rows[e.RowIndex].Cells["Deshabilitar"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\EliminarDgv.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.EliminarDgv);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosUsuario.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosUsuario.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }

        private void dgvDatosUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                Usuario ObjUsuario = new Usuario();
                if (Convert.ToString(dgvDatosUsuario.CurrentRow.Cells[6].Value) != "")
                {
                    if (rbtActivos.Checked)
                    {
                        if (this.dgvDatosUsuario.Columns[e.ColumnIndex].Name == "Deshabilitar")
                        {
                            ObjUsuario.EstadoUsuario(dgvDatosUsuario.CurrentRow.Cells[6].Value.ToString(), 2);
                            cargarDatos("1");
                        }
                    }
                    else if (rbtInactivos.Checked)
                    {
                        if (this.dgvDatosUsuario.Columns[e.ColumnIndex].Name == "Deshabilitar")
                        {
                            ObjUsuario.EstadoUsuario(dgvDatosUsuario.CurrentRow.Cells[6].Value.ToString(), 1);
                            cargarDatos("0");
                        }
                    }

                    if (this.dgvDatosUsuario.Columns[e.ColumnIndex].Name == "Modificar")
                    {
                        GlovalIDUsuario = dgvDatosUsuario.CurrentRow.Cells[6].Value.ToString();
                        tcUsuario.SelectedIndex = 0;
                        bandera_Estado = true;
                        //Llenar el DataTable
                        DataTable dt = objConsul.BoolDataTable("Select * from TbUsuario where IDUSUARIO = " + GlovalIDUsuario + "");
                        //Verificar si tiene Datos
                        if (dt.Rows.Count > 0)
                        {
                            DataRow myRow = dt.Rows[0];


                            cbPersonaUsuario.SelectedValue = Convert.ToInt32(myRow["IDEMPLEADO"]);
                            int indexUSUARIO = cbPersonaUsuario.SelectedIndex;
                            cbPersonaUsuario.SelectedIndex = indexUSUARIO;

                            cbTipoUsuario.SelectedValue = Convert.ToInt32(myRow["IDTIPOUSUARIO"]);
                            int indexTIPOUSUARIO = cbTipoUsuario.SelectedIndex;
                            cbTipoUsuario.SelectedIndex = indexTIPOUSUARIO;

                            CheckListBEmpresas.SelectedValue = Convert.ToInt32(myRow["IDEMPRESA"]);
                            int indexIDEMPRESA = CheckListBEmpresas.SelectedIndex;
                            CheckListBEmpresas.SetItemChecked(indexIDEMPRESA, true);

                            txtUsuario.Text = myRow["USUARIO"].ToString();
                            txtContraseñaUsuario.Text = myRow["CONTRASEÑA"].ToString();
                            if (myRow["FACTURA"].ToString() != "")
                                ckbFacturaUsuario.Checked = Convert.ToBoolean(myRow["FACTURA"]);

                        }

                        btnLimpiarProveedor.Text = "&Cancelar";
                        btnGuardarUsuario.Text = "&Modificar";
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void rbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtActivos.Checked)
            {
                cargarDatos("1");
                //dgvDatosProveedor.Columns[1].HeaderText = "Desabilitar";
            }
            else if (rbtInactivos.Checked)
            {
                cargarDatos("0");
                //dgvDatosProveedor.Columns[1].HeaderText = "Habilitar";
            }
        }
    

        private void txtConsultarUsuario_TextChanged(object sender, EventArgs e)
        {
            if (rbtActivos.Checked)
            {
                string consulta = "Select USUARIO,CONTRASEÑA,FACTURA, E.NOMBRE, IDUSUARIO as ID from TbUsuario U, TbEmpresa E where U.IDEMPRESA= E.IDEMPRESA AND  ACTIVO = 1 and (USUARIO like '%" + txtConsultarUsuario.Text + "%' or E.NOMBRE like '%" + txtConsultarUsuario.Text + "%');";
                //dgvDatosProveedor.Columns[1].HeaderText = "Desabilitar";
                //dgvDatosUsuario.Columns["ID"].Visible = false;
                objConsul.boolLlenarDataGrid(dgvDatosUsuario, consulta, 10, 4, 2);
            }
            else if (rbtInactivos.Checked)
            {
                string consulta = "Select USUARIO,CONTRASEÑA,FACTURA, E.NOMBRE, IDUSUARIO as ID from TbUsuario U, TbEmpresa E where U.IDEMPRESA= E.IDEMPRESA AND  ACTIVO = 0 and (USUARIO like '%" + txtConsultarUsuario.Text + "%' or E.NOMBRE like '%" + txtConsultarUsuario.Text + "%');";
                //dgvDatosProveedor.Columns[1].HeaderText = "Habilitar";
                //dgvDatosUsuario.Columns["ID"].Visible = false;
                objConsul.boolLlenarDataGrid(dgvDatosUsuario, consulta, 10, 4, 2);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.validar_Num_Letras(e);
        }

        private void cbPersonaUsuario_Enter(object sender, EventArgs e)
        {            
           
            //CheckListBEmpresas.SelectedValue
            objConsul.BoolLlenarComboBox(cbPersonaUsuario, "Select IDEMPLEADO as ID,(E.APELLIDOS +' '+ E.NOMBRES) as Texto from TbEmpleado E  WHERE (E.NOMBRES != 'ADMINISTRADOR');");
            //objConsul.BoolLlenarComboBox(cbTipoUsuario, "Select IDTIPOUSUARIO as ID,TIPO as Texto from TbTipousuario;");
            //ckbFacturaUsuario.Checked = false;
            
        }

        private void CheckListBEmpresas_Enter(object sender, EventArgs e)
        {
            objConsul.BoolLlenarCheckListBox(CheckListBEmpresas, "Select IDEMPRESA as ID, NOMBRE as 'Texto' from TbEmpresa;");
            ckMostrarContra.Checked = false;
            cbPersonaUsuario.DropDownHeight = cbPersonaUsuario.ItemHeight = 150;
            cbTipoUsuario.DropDownHeight = cbTipoUsuario.ItemHeight = 150;
            cargarDatos("1");
        }
    }
}
