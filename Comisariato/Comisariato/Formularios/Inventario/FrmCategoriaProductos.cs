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

namespace Comisariato.Formularios.Mantenimiento.Inventario
{
    public partial class FrmCategoriaProductos : Form
    {
        public FrmCategoriaProductos()
        {
            InitializeComponent();
        }

        Consultas consultas;
        bool bandera_Estado = false;
        String GlovalDescripcion = "";
        private void FrmCategoriaProductos_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 14; i++)
            //{
            //    dgvDatosCategoriaProducto.Rows.Add();
            //}
            // llenar datadrigview solo los activos
            cargarDatos("1");
        }

        private void txtDescripcionCategoriaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.validar_Num_Letras(e);
        }

        private void cargarDatos(string condicion)
        {
            consultas = new Consultas();
            consultas.boolLlenarDataGridView(dgvDatosCategoriaProducto, "Select IDCATEGORIA as ID, DESCRIPCION, COMBO,MANEJAINVENTARIO AS 'MANEJA INVENTARIO' from TbCategoria WHERE ESTADO =" + condicion + ";");
            dgvDatosCategoriaProducto.Columns["ID"].Visible = false;
        }

        public void inicializarDatos()
        {

            txtDescripcionCategoriaUsuario.Text = "";
            ckbComboCategoriaProducto.Checked = false;
            ckbManejaInventarioCategoriaProducto.Checked = false;
            txtConsultarCategoriaProducto.Text = "";
            // llenar datadrigview solo los activos
            cargarDatos("1");
        }

        private void btnGuardarCategoriaProducto_Click(object sender, EventArgs e)
        {
            
            if (txtDescripcionCategoriaUsuario.Text != "")
            {
                Producto ObjProducto = new Producto();
                if (!bandera_Estado) // Para identificar si se va ingresar
                {
                    String resultado = ObjProducto.InsertarCategoriaProducto(txtDescripcionCategoriaUsuario.Text, ckbComboCategoriaProducto.Checked, ckbManejaInventarioCategoriaProducto.Checked); // retorna true si esta correcto todo
                    if (resultado == "Datos Guardados")
                    {
                        MessageBox.Show("Categoria Registrada Correctamente ", "Exito", MessageBoxButtons.OK);
                        rbtActivos.Checked = true;
                        inicializarDatos();
                        btnLimpiarCategoriaProducto.Text = "&Limpiar";
                    }
                    else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else if (resultado == "Existe") { MessageBox.Show("Ya Existe la Categoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else if (bandera_Estado) // Para identificar si se va modificar
                {
                    String Resultado = ObjProducto.ModificarCategoriaProducto(txtDescripcionCategoriaUsuario.Text, ckbComboCategoriaProducto.Checked, ckbManejaInventarioCategoriaProducto.Checked,GlovalDescripcion); // retorna true si esta correcto todo
                    if (Resultado == "Correcto")
                    {
                        MessageBox.Show("Categoria Actualizada", "Exito");
                        rbtActivos.Checked = true;
                        GlovalDescripcion = "";
                    }
                    else { MessageBox.Show("Error al actualizar Categoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    inicializarDatos();
                    bandera_Estado = false;
                    btnGuardarCategoriaProducto.Text = "&Guardar";
                }
                cargarDatos("1");
            }
            else { MessageBox.Show("Ingrese los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void rbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtActivos.Checked)
            {
                cargarDatos("1");
                //dgvDatosCategoriaProducto.Columns[1].HeaderText = "Desabilitar";
            }
            else if (rbtInactivos.Checked)
            {
                cargarDatos("0");
                //dgvDatosCategoriaProducto.Columns[1].HeaderText = "Habilitar";
            }
        }

        private void dgvDatosCategoriaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto ObjProducto = new Producto();
            if (rbtActivos.Checked)
            {
                if (this.dgvDatosCategoriaProducto.Columns[e.ColumnIndex].Name == "Deshabilitar")
                {
                    ObjProducto.EstadoCategoriaProducto(dgvDatosCategoriaProducto.CurrentRow.Cells[3].Value.ToString(), 2);
                    cargarDatos("1");
                }
            }
            else if (rbtInactivos.Checked)
            {
                if (this.dgvDatosCategoriaProducto.Columns[e.ColumnIndex].Name == "Deshabilitar")
                {
                    ObjProducto.EstadoCategoriaProducto(dgvDatosCategoriaProducto.CurrentRow.Cells[3].Value.ToString(), 1);
                    cargarDatos("0");
                }
            }

            if (this.dgvDatosCategoriaProducto.Columns[e.ColumnIndex].Name == "Modificar")
            {
                //MessageBox.Show("modificar toca " + DgvDatosEmpleado.CurrentRow.Cells[3].Value.ToString());
                GlovalDescripcion = dgvDatosCategoriaProducto.CurrentRow.Cells[3].Value.ToString();
                tabControl1.SelectedIndex = 0;
                bandera_Estado = true;
                //Llenar el DataTable
                DataTable dt = consultas.BoolDataTable("Select * from TbCategoria where [DESCRIPCION] = '" + GlovalDescripcion + "'");
                //Verificar si tiene Datos
                if (dt.Rows.Count > 0)
                {
                    DataRow myRow = dt.Rows[0];

                    //Cargar los demas Datos
                    ckbComboCategoriaProducto.Checked = Convert.ToBoolean(myRow["COMBO"]);
                    ckbManejaInventarioCategoriaProducto.Checked = Convert.ToBoolean(myRow["MANEJAINVENTARIO"]);
                    txtDescripcionCategoriaUsuario.Text = myRow["DESCRIPCION"].ToString();
                }
                
                btnGuardarCategoriaProducto.Text = "&Modificar";
                btnLimpiarCategoriaProducto.Text = "&Cancelar";

            }
        }

        private void btnLimpiarCategoriaProducto_Click(object sender, EventArgs e)
        {
            if (btnLimpiarCategoriaProducto.Text == "&Cancelar")
            {
                inicializarDatos();
                btnLimpiarCategoriaProducto.Text = "&Limpiar";
                btnGuardarCategoriaProducto.Text = "&Guardar";
            }
            else { inicializarDatos(); }
            bandera_Estado = false;
        }

        private void txtConsultarCategoriaProducto_TextChanged(object sender, EventArgs e)
        {
            if (rbtActivos.Checked)
            {
                consultas.boolLlenarDataGridView(dgvDatosCategoriaProducto, "Select IDCATEGORIA as ID, DESCRIPCION, COMBO,MANEJAINVENTARIO AS 'MANEJA INVENTARIO' from TbCategoria WHERE ESTADO  = 1 and DESCRIPCION like '%" + txtConsultarCategoriaProducto.Text + "%';");
                //dgvDatosCategoriaProducto.Columns[1].HeaderText = "Desabilitar";
                dgvDatosCategoriaProducto.Columns["ID"].Visible = false;
            }
            else if (rbtInactivos.Checked)
            {
                consultas.boolLlenarDataGridView(dgvDatosCategoriaProducto, "Select IDCATEGORIA as ID, DESCRIPCION, COMBO,MANEJAINVENTARIO AS 'MANEJA INVENTARIO' from TbCategoria WHERE ESTADO = 0 and DESCRIPCION like '%" + txtConsultarCategoriaProducto.Text + "%' ;");
                //dgvDatosCategoriaProducto.Columns[1].HeaderText = "Habilitar";
                dgvDatosCategoriaProducto.Columns["ID"].Visible = false;
            }
        }

        private void dgvDatosCategoriaProducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvDatosCategoriaProducto.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = dgvDatosCategoriaProducto.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.modificarDgv);
                IntPtr Hicon = bitmap.GetHicon();
                Icon icoAtomico = Icon.FromHandle(Hicon);
                //bitmap.SetResolution(72, 72);


                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                dgvDatosCategoriaProducto.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dgvDatosCategoriaProducto.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }

            if (rbtInactivos.Checked)
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosCategoriaProducto.Columns[e.ColumnIndex].Name == "Deshabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosCategoriaProducto.Rows[e.RowIndex].Cells["Deshabilitar"] as DataGridViewButtonCell;

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.Habilitar);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosCategoriaProducto.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosCategoriaProducto.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosCategoriaProducto.Columns[e.ColumnIndex].Name == "Deshabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosCategoriaProducto.Rows[e.RowIndex].Cells["Deshabilitar"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\EliminarDgv.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.EliminarDgv);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosCategoriaProducto.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosCategoriaProducto.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }
    }
}
