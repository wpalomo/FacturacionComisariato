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
    public partial class FrmCreacionBodega : Form
    {
        public FrmCreacionBodega()
        {
            InitializeComponent();
        }

        Consultas ObjConsul;
        bool bandera_Estado = false;
        String nombreBodega = "";

        private void cargarDatos( string condicion)
        {
            ObjConsul = new Consultas();
            ObjConsul.boolLlenarDataGridView(dgvDatosBodega, "SELECT TbBodega.NOMBRE as DESCRIPCION, TbBodega.UBICACION, (TbEmpleado.APELLIDOS +' '+ TbEmpleado.NOMBRES) as NOMBRE from TbBodega INNER JOIN TbEmpleado ON (TbEmpleado.IDEMPLEADO=TbBodega.IDEMPLEADO) AND (TbEmpleado.NOMBRES != 'ADMINISTRADOR')  AND (TbBodega.Estado= " + condicion+");");
        }
        private void FrmCreacionBodega_Load(object sender, EventArgs e)
        {
            ObjConsul = new Consultas();
            //ObjConsul.boolLlenarDataGridView(dgvDatosBodega, "SELECT TbBodega.NOMBRE as DESCRIPCION, TbBodega.UBICACION, (TbEmpleado.APELLIDOS +' '+ TbEmpleado.NOMBRES) as NOMBRE from TbBodega INNER JOIN TbEmpleado ON (TbEmpleado.IDEMPLEADO=TbBodega.IDEMPLEADO) AND (TbEmpleado.CARGO= 'BODEGUERO') AND (TbBodega.Estado= 1);");
            cargarDatos("1");
            ObjConsul.BoolLlenarComboBox(cbResponsableBodega, "Select IDEMPLEADO as ID,(E.APELLIDOS +' '+ E.NOMBRES) as Texto from TbEmpleado E  WHERE (E.NOMBRES != 'ADMINISTRADOR');");
            if (cbResponsableBodega.Items.Count > 0)
                cbResponsableBodega.SelectedIndex = 0;

        }

        private void RbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActivosBodega.Checked)
            {
                cargarDatos("1");
                //dgvDatosBodega.Columns[1].HeaderText = "Desabilitar";
            }
            else if (rbInactivoBodega.Checked)
            {
                cargarDatos("0");
                //dgvDatosBodega.Columns[1].HeaderText = "Habilitar";
            }
        }

        private void dgvDatosBodega_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            //if (e.ColumnIndex >= 0 && this.dgvDatosBodega.Columns[e.ColumnIndex].Name == "modificarDatosBodega" && e.RowIndex >= 0)
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //    DataGridViewButtonCell celBoton = this.dgvDatosBodega.Rows[e.RowIndex].Cells["modificarDatosBodega"] as DataGridViewButtonCell;
            //    Icon icoAtomico = new Icon(Environment.CurrentDirectory  + @"\\modificar.ico");
            //    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

            //    this.dgvDatosBodega.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
            //    this.dgvDatosBodega.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

            //    e.Handled = true;
            //}
        }

        private void dgvDatosBodega_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (rbActivosBodega.Checked)
                {
                    if (this.dgvDatosBodega.Columns[e.ColumnIndex].Name == "DeshabilitarDatosBodega")
                    {
                        //ObjConsul.EjecutarSQL("UPDATE TbBodega SET ESTADO = 0 WHERE NOMBRE = '" + dgvDatosBodega.CurrentRow.Cells[2].Value + "'");
                        Bodega ObjBodega = new Bodega();
                        ObjBodega.EstadoBodega(dgvDatosBodega.CurrentRow.Cells[2].Value.ToString(), 2);
                        cargarDatos("1");
                    }
                }
                else if (rbInactivoBodega.Checked)
                {
                    if (this.dgvDatosBodega.Columns[e.ColumnIndex].Name == "DeshabilitarDatosBodega")
                    {
                        //ObjConsul.EjecutarSQL("UPDATE TbBodega SET ESTADO = 1 WHERE NOMBRE = '" + dgvDatosBodega.CurrentRow.Cells[2].Value + "'");
                        Bodega ObjBodega = new Bodega();
                        ObjBodega.EstadoBodega(dgvDatosBodega.CurrentRow.Cells[2].Value.ToString(), 1);
                        cargarDatos("0");
                    }
                }

                if (this.dgvDatosBodega.Columns[e.ColumnIndex].Name == "modificarDatosBodega")
                {
                    tcbodega.SelectedIndex = 0;
                    txtDescripcionBodega.Text = dgvDatosBodega.CurrentRow.Cells[2].Value.ToString();
                    txtUbicacionBodega.Text = dgvDatosBodega.CurrentRow.Cells[3].Value.ToString();
                    cbResponsableBodega.Text = dgvDatosBodega.CurrentRow.Cells[4].Value.ToString();
                    nombreBodega = txtDescripcionBodega.Text;
                    bandera_Estado = true;
                    btnGuardarBodega.Text = "&Modificar";

                    btnLimpiarBodega.Text = "&Cancelar";
                }

            }
            catch (Exception)
            {

            }
        }

        private void TxtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TxtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (rbActivosBodega.Checked)
            {
                ObjConsul.boolLlenarDataGridView(dgvDatosBodega, "SELECT TbBodega.NOMBRE as DESCRIPCION, TbBodega.UBICACION, (TbEmpleado.APELLIDOS +' '+ TbEmpleado.NOMBRES) as NOMBRE from TbBodega INNER JOIN TbEmpleado ON (TbEmpleado.IDEMPLEADO=TbBodega.IDEMPLEADO) AND (TbEmpleado.NOMBRES != 'ADMINISTRADOR')  AND (TbBodega.Estado= 1) and TbBodega.NOMBRE like '%" + txtConsultarBodega.Text + "%';");
                //dgvDatosBodega.Columns[1].HeaderText = "Desabilitar";
            }
            else if (rbInactivoBodega.Checked)
            {
                ObjConsul.boolLlenarDataGridView(dgvDatosBodega, "SELECT TbBodega.NOMBRE as DESCRIPCION, TbBodega.UBICACION, (TbEmpleado.APELLIDOS +' '+ TbEmpleado.NOMBRES) as NOMBRE from TbBodega INNER JOIN TbEmpleado ON (TbEmpleado.IDEMPLEADO=TbBodega.IDEMPLEADO) AND (TbEmpleado.NOMBRES != 'ADMINISTRADOR') AND (TbBodega.Estado= 0) and TbBodega.NOMBRE like '%" + txtConsultarBodega.Text + "%' ;");
                //dgvDatosBodega.Columns[1].HeaderText = "Habilitar";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            //Funcion.Limpiarobjetos(gbNuevaBodega);
            //Funcion.Limpiarobjetos(gbConsultarModificarDeshabilitarBodega);
            inicializar();
            bandera_Estado = false;
        }

        public void inicializar()
        {
            txtConsultarBodega.Text = "";
            txtDescripcionBodega.Text = "";
            txtUbicacionBodega.Text = "";
            if (cbResponsableBodega.Items.Count > 0)
            {
                cbResponsableBodega.SelectedIndex = 0;
            }
            btnGuardarBodega.Text = "&Guardar";
            btnLimpiarBodega.Text = "&Limpiar";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcionBodega.Text != "" && txtUbicacionBodega.Text != "")
            {
                Bodega ObjBodega = new Bodega(txtDescripcionBodega.Text, txtUbicacionBodega.Text, Convert.ToInt32(cbResponsableBodega.SelectedValue));
                if (!bandera_Estado)
                {
                    String resultado = ObjBodega.InsertarBodega();
                    if (resultado == "Datos Guardados")
                    {
                        MessageBox.Show("Bodega Correctamente Registrada", "Exito");
                        cargarDatos("1");
                        rbActivosBodega.Checked = true;
                        inicializar();
                    }
                    else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar la Bodega", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else if (resultado == "Existe") { MessageBox.Show("Ya Existe la Bodega", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else if (bandera_Estado)
                {
                    String Resultado = ObjBodega.ModificarBodega(nombreBodega);
                    if (Resultado == "Correcto")
                    {
                        MessageBox.Show("Bodega Modificada", "Exito");
                        cargarDatos("1");
                        rbActivosBodega.Checked = true;
                        nombreBodega = "";
                        inicializar();
                    }
                    else { MessageBox.Show("Error al modificar la Bodega", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    bandera_Estado = false;
                    //Funcion.Limpiarobjetos(gbNuevaBodega);
                    //Funcion.Limpiarobjetos(gbConsultarModificarDeshabilitarBodega);
                }
                btnGuardarBodega.Text = "&Guardar";
                btnGuardarBodega.Text = "&Limpiar";
            }
            else { MessageBox.Show("Ingrese los Datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.validar_Num_Letras(e);
        }

        private void dgvDatosBodega_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvDatosBodega.Columns[e.ColumnIndex].Name == "modificarDatosBodega" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = dgvDatosBodega.Rows[e.RowIndex].Cells["modificarDatosBodega"] as DataGridViewButtonCell;
                //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\modificarDgv.ico");

                Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.modificarDgv);
                IntPtr Hicon = bitmap.GetHicon();
                Icon icoAtomico = Icon.FromHandle(Hicon);
                //bitmap.SetResolution(72, 72);

                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                dgvDatosBodega.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dgvDatosBodega.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }

            if (rbInactivoBodega.Checked)
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosBodega.Columns[e.ColumnIndex].Name == "DeshabilitarDatosBodega" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosBodega.Rows[e.RowIndex].Cells["DeshabilitarDatosBodega"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\Habilitar.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.Habilitar);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosBodega.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosBodega.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosBodega.Columns[e.ColumnIndex].Name == "DeshabilitarDatosBodega" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosBodega.Rows[e.RowIndex].Cells["DeshabilitarDatosBodega"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\EliminarDgv.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.EliminarDgv);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosBodega.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosBodega.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }
    }
}