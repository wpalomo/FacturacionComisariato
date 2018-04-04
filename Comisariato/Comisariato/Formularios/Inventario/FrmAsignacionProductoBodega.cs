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
    public partial class FrmAsignacionProductoBodega : Form
    {
        public FrmAsignacionProductoBodega()
        {
            InitializeComponent();
        }
        Consultas objconsul = new Consultas();
        List<string> ListaAux = new List<string>();
        int GlobalfilasProductosAsignadosABodega = 0;
        private void FrmAsignacionProductoBodega_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 15; i++)
            //{
            //    dgvDatosProductoParaAsignacionBodega.Rows.Add();
            //    dgvDatosProductosAsignadosABodega.Rows.Add();
            //}
            inicializar();

            dgvDatosProductoParaAsignacionBodega.Columns["agregarProductosAbodega"].Width = 23;
            dgvDatosProductosAsignadosABodega.Columns["QuitarProductosAbodega"].Width = 23;
            for (int i = 1; i < dgvDatosProductoParaAsignacionBodega.ColumnCount; i++)
            {
                dgvDatosProductoParaAsignacionBodega.Columns[i].ReadOnly = true;
                dgvDatosProductosAsignadosABodega.Columns[i].ReadOnly = true;
            }

        }



        public void inicializar()
        {
            objconsul.BoolLlenarComboBox(cbEscogerBodega, "Select IDBODEGA as ID, NOMBRE as TEXTO from TbBodega");
            objconsul.boolLlenarDataGridView(dgvDatosProductosAsignadosABodega, "Select P.IDPRODUCTO, P.CODIGOBARRA as 'Código', P.NOMBREPRODUCTO as 'Nombre',P.CANTIDAD as Cantidad, C.DESCRIPCION as 'Categoria' from TbProducto P inner join TbAsignacionProductoBodega Asig on (Asig.IDPRODUCTO = P.IDPRODUCTO) inner join TbBodega B on ( Asig.IDBODEGA = B.IDBODEGA) inner join TbCategoria C on (P.IDCATEGORIA = C.IDCATEGORIA) where Asig.IDBODEGA = " + Convert.ToInt32(cbEscogerBodega.SelectedValue) + " and Asig.ESTADO = 1;");
            objconsul.boolLlenarDataGridView(dgvDatosProductoParaAsignacionBodega, "Select P.IDPRODUCTO, P.CODIGOBARRA as 'Código', P.NOMBREPRODUCTO as 'Nombre',P.CANTIDAD, C.DESCRIPCION as 'Categoria' from TbProducto P inner join TbCategoria C on (C.IDCATEGORIA= P.IDCATEGORIA) where  not exists (select * from TbAsignacionProductoBodega where TbAsignacionProductoBodega.IDPRODUCTO = P.IDPRODUCTO and TbAsignacionProductoBodega.ESTADO = 1) ");
            dgvDatosProductosAsignadosABodega.Columns["IDPRODUCTO"].Visible = false;
            dgvDatosProductoParaAsignacionBodega.Columns["IDPRODUCTO"].Visible = false;
            txtBuscarProducto.Text = "";
            txtUbicacionBodegaAsignacionProducto.Text = "";
            llenardatos();
            ListaAux.Clear();

            //objconsul.boolLlenarDataGridView(dgvDatosAsignacionProducto, "Select P.IDPRODUCTO, P.CODIGOBARRA as 'Código', P.NOMBREPRODUCTO as 'Nombre',P.CANTIDAD as 'Cantidad', C.DESCRIPCION as 'Categoria', B.NOMBRE as 'Bódega', B.UBICACION as 'Ubicación' from TbAsignacionProductoBodega Asig inner join TbProducto P on (Asig.IDPRODUCTO=P.IDPRODUCTO) inner join TbCategoria C on (C.IDCATEGORIA= P.IDCATEGORIA) inner join TbBodega B on (B.IDBODEGA=Asig.IDBODEGA)");

            //dgvDatosAsignacionProducto.Columns["IDPRODUCTO"].Visible = false;
        }

        public void llenardatos()
        {
            try
            {

                String ID = cbEscogerBodega.SelectedValue.ToString();
                objconsul = new Consultas();
                DataTable dt = objconsul.BoolDataTable("Select UBICACION from TbBodega where IDBODEGA = " + ID + ";");
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtUbicacionBodegaAsignacionProducto.Text = row["UBICACION"].ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbEscogerBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEscogerBodega.SelectedValue.ToString() != null)
            {
                llenardatos();
            }
            objconsul.boolLlenarDataGridView(dgvDatosProductosAsignadosABodega, "Select P.IDPRODUCTO, P.CODIGOBARRA as 'Código', P.NOMBREPRODUCTO as 'Nombre',P.CANTIDAD as Cantidad, C.DESCRIPCION as 'Categoria' from TbProducto P inner join TbAsignacionProductoBodega Asig on (Asig.IDPRODUCTO = P.IDPRODUCTO) inner join TbBodega B on ( Asig.IDBODEGA = B.IDBODEGA) inner join TbCategoria C on (P.IDCATEGORIA = C.IDCATEGORIA) where Asig.IDBODEGA = " + Convert.ToInt32(cbEscogerBodega.SelectedValue) + " and Asig.ESTADO = 1;");
            dgvDatosProductosAsignadosABodega.Columns["IDPRODUCTO"].Visible = false;
            GlobalfilasProductosAsignadosABodega = dgvDatosProductosAsignadosABodega.Rows.Count;
        }

        private void btnAsignarProducto_Click(object sender, EventArgs e)
        {

            DataTable dataTB = (DataTable)dgvDatosProductosAsignadosABodega.DataSource;
            //objconsul.BoolDataTable("Select P.CODIGOBARRA as 'Código', P.NOMBREPRODUCTO as 'Nombre',P.CANTIDAD as Cantidad, C.DESCRIPCION as 'Categoria' from TbProducto P inner join TbAsignacionProductoBodega Asig on (Asig.IDPRODUCTO = P.IDPRODUCTO) inner join TbBodega B on ( Asig.IDBODEGA = B.IDBODEGA) inner join TbCategoria C on (P.IDCATEGORIA = C.IDCATEGORIA) where Asig.IDBODEGA = " + Convert.ToInt32(cbEscogerBodega.SelectedValue) + ";");

            if (dgvDatosProductoParaAsignacionBodega.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDatosProductoParaAsignacionBodega.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvDatosProductoParaAsignacionBodega.Rows[i].Cells["agregarProductosAbodega"].Value) == true)
                    {
                        //MessageBox.Show(dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[1].Value.ToString());
                        // Creamos un array con los valores que vamos a insertar
                        // en el segundo control DataGridView.
                        //
                        object[] values = {
                                          dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[1].Value,
                                          dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[2].Value,
                                          dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[3].Value,
                                          dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[4].Value,
                                          dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[5].Value};

                        // Creamos un nuevo objeto DataGridViewRow.
                        //
                        DataGridViewRow row = new DataGridViewRow();

                        // Creamos las celdas y las rellenamos con los valores existentes
                        // en el array.
                        //
                        row.CreateCells(dgvDatosProductosAsignadosABodega, values);
                        // Creamos un array con los valores que vamos a insertar

                        // Añadimos la nueva fila al segundo control DataGridView.
                        string id = objconsul.ObtenerValorCampo("IDPRODUCTO", "TbProducto", " where CODIGOBARRA = '" + dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[2].Value.ToString() + "'");

                        if (objconsul.Existe("IDPRODUCTO", dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[1].Value.ToString(), "TbAsignacionProductoBodega"))
                        {
                            //objconsul.EjecutarSQL("UPDATE [dbo].[TbAsignacionProductoBodega] SET [ESTADO] = 1 WHERE IDPRODUCTO = " + id + "");
                            ListaAux.Add(id);
                            ListaAux.Add("1");
                        }


                        dataTB.Rows.Add(values);
                        dgvDatosProductosAsignadosABodega.DataSource = dataTB;

                    }

                }
                for (int i = 0; i < dgvDatosProductoParaAsignacionBodega.Rows.Count;)
                {
                    DataTable dt = (DataTable)dgvDatosProductoParaAsignacionBodega.DataSource;
                    if (Convert.ToBoolean(dgvDatosProductoParaAsignacionBodega.Rows[i].Cells["agregarProductosAbodega"].Value) == true)
                    {
                        dgvDatosProductoParaAsignacionBodega.Rows.Remove(dgvDatosProductoParaAsignacionBodega.Rows[i]);
                        //i = 0;
                    }
                    else { i++; }

                }
            }
            else
            {
                //no hay datos en el datagrid
            }
            GlobalfilasProductosAsignadosABodega = dgvDatosProductosAsignadosABodega.Rows.Count;
        }

        private void btnNoAsiganrProducto_Click(object sender, EventArgs e)
        {


            DataTable dataTB = (DataTable)dgvDatosProductoParaAsignacionBodega.DataSource;

            if (dgvDatosProductosAsignadosABodega.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDatosProductosAsignadosABodega.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvDatosProductosAsignadosABodega.Rows[i].Cells["QuitarProductosAbodega"].Value) == true)
                    {
                        //MessageBox.Show(dgvDatosProductoParaAsignacionBodega.Rows[i].Cells[1].Value.ToString());
                        // Creamos un array con los valores que vamos a insertar
                        // en el segundo control DataGridView.
                        //
                        object[] values = {
                                          dgvDatosProductosAsignadosABodega.Rows[i].Cells[1].Value,
                                          dgvDatosProductosAsignadosABodega.Rows[i].Cells[2].Value,
                                          dgvDatosProductosAsignadosABodega.Rows[i].Cells[3].Value,
                                          dgvDatosProductosAsignadosABodega.Rows[i].Cells[4].Value,
                                          dgvDatosProductosAsignadosABodega.Rows[i].Cells[5].Value};

                        // Creamos un nuevo objeto DataGridViewRow.
                        //
                        DataGridViewRow row = new DataGridViewRow();

                        // Creamos las celdas y las rellenamos con los valores existentes
                        // en el array.
                        //
                        row.CreateCells(dgvDatosProductosAsignadosABodega, values);
                        // Creamos un array con los valores que vamos a insertar

                        // Añadimos la nueva fila al segundo control DataGridView.
                        string id = objconsul.ObtenerValorCampo("IDPRODUCTO", "TbProducto", " where CODIGOBARRA = '" + dgvDatosProductosAsignadosABodega.Rows[i].Cells[2].Value.ToString() + "'");

                        if (objconsul.Existe("IDPRODUCTO", dgvDatosProductosAsignadosABodega.Rows[i].Cells[1].Value.ToString(), "TbAsignacionProductoBodega"))
                        {
                            //objconsul.EjecutarSQL("UPDATE [dbo].[TbAsignacionProductoBodega] SET [ESTADO] = 0 WHERE IDPRODUCTO = "+ id + "");
                            ListaAux.Add(id);
                            ListaAux.Add("0");
                        }

                        dataTB.Rows.Add(values);
                        dgvDatosProductoParaAsignacionBodega.DataSource = dataTB;

                    }

                }
                for (int i = 0; i < dgvDatosProductosAsignadosABodega.Rows.Count;)
                {
                    DataTable dt = (DataTable)dgvDatosProductosAsignadosABodega.DataSource;
                    if (Convert.ToBoolean(dgvDatosProductosAsignadosABodega.Rows[i].Cells["QuitarProductosAbodega"].Value) == true)
                    {
                        dgvDatosProductosAsignadosABodega.Rows.Remove(dgvDatosProductosAsignadosABodega.Rows[i]);
                        //i = 0;
                    }
                    else { i++; }

                }
            }
            else
            {
                //no hay datos en el datagrid
            }
            //GlobalfilasProductosAsignadosABodega = dgvDatosProductosAsignadosABodega.Rows.Count;
        }

        private void btnGuardarAsignacionProducto_Click(object sender, EventArgs e)
        {
            
            if (dgvDatosProductoParaAsignacionBodega.Rows.Count >= 0 && GlobalfilasProductosAsignadosABodega > 0)
            {
                bool result = true;
                for (int i = 0; i < dgvDatosProductosAsignadosABodega.Rows.Count; i++)
                {
                    string codigo = dgvDatosProductosAsignadosABodega.Rows[i].Cells[1].Value.ToString();
                    if (!objconsul.Existe("IDPRODUCTO", codigo, "TbAsignacionProductoBodega"))
                    {
                        result = objconsul.EjecutarPROCEDUREAsignarProductoBodega(Convert.ToInt32(codigo), Convert.ToInt32(cbEscogerBodega.SelectedValue));
                    }
                    if (!result)
                    {
                        MessageBox.Show("Error al Asignar el Producto: " + codigo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (ListaAux.Count > 0)
                {
                    for (int i = 1; i < ListaAux.Count; i++)
                    {
                        if (i == 1)
                        { objconsul.EjecutarSQL("UPDATE [dbo].[TbAsignacionProductoBodega] SET [ESTADO] = " + ListaAux[i] + " WHERE IDPRODUCTO = " + ListaAux[i - 1] + ""); }
                        else { objconsul.EjecutarSQL("UPDATE [dbo].[TbAsignacionProductoBodega] SET [ESTADO] = " + ListaAux[i + 1] + " WHERE IDPRODUCTO = " + ListaAux[i] + ""); i = i + 1; }
                    }
                }
                if (result) { MessageBox.Show("Productos Asignados Correctamente ", "Exito", MessageBoxButtons.OK); }
                ListaAux.Clear();
            }
            else { MessageBox.Show("Error debe Asignar al menos un Productoa la Bódega", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
        }

        private void btnLimpiarAsignacionProducto_Click(object sender, EventArgs e)
        {
            inicializar();            
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            objconsul.boolLlenarDataGridView(dgvDatosProductoParaAsignacionBodega, "Select * from VistaProductosSinAsignarBodega ViewP where ViewP.Codigo like '%" + txtBuscarProducto.Text + "%' or ViewP.Nombre like '%" + txtBuscarProducto.Text + "%' or ViewP.Categoria like '%" + txtBuscarProducto.Text + "%';");
            dgvDatosProductoParaAsignacionBodega.Columns["IDPRODUCTO"].Visible = false;
        }

        private void txtConsultarAsginacionProducto_TextChanged(object sender, EventArgs e)
        {
            //objconsul.boolLlenarDataGridView(dgvDatosAsignacionProducto, "Select P.IDPRODUCTO, P.CODIGOBARRA as 'Código', P.NOMBREPRODUCTO as 'Nombre',P.CANTIDAD as 'Cantidad', C.DESCRIPCION as 'Categoria', B.NOMBRE as 'Bódega', B.UBICACION as 'Ubicación' from TbAsignacionProductoBodega Asig inner join TbProducto P on (Asig.IDPRODUCTO=P.IDPRODUCTO) inner join TbCategoria C on (C.IDCATEGORIA= P.IDCATEGORIA) inner join TbBodega B on (B.IDBODEGA=Asig.IDBODEGA) where  P.CODIGOBARRA like '%" + txtConsultarAsginacionProducto.Text + "%' or P.NOMBREPRODUCTO like '%" + txtConsultarAsginacionProducto.Text + "%' or C.DESCRIPCION like '%" + txtConsultarAsginacionProducto.Text + "%' or B.NOMBRE like '%" + txtConsultarAsginacionProducto.Text + "%' ");
            //dgvDatosAsignacionProducto.Columns["IDPRODUCTO"].Visible = false;
        }

        private void txtConsultarAsginacionProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Consultas Objconsul = new Consultas();
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtConsultarAsginacionProducto.Text != "")
                {
                    if (Objconsul.boolLlenarDataGridView(dgvDatosAsignacionProducto, "Select P.IDPRODUCTO, P.CODIGOBARRA as 'Código', P.NOMBREPRODUCTO as 'Nombre',P.CANTIDAD as Cantidad, C.DESCRIPCION as 'Categoria',B.NOMBRE as 'Bodega' from TbProducto P inner join TbAsignacionProductoBodega Asig on (Asig.IDPRODUCTO = P.IDPRODUCTO) inner join TbBodega B on ( Asig.IDBODEGA = B.IDBODEGA) inner join TbCategoria C on (P.IDCATEGORIA = C.IDCATEGORIA) where Asig.ESTADO = 1 and (P.CODIGOBARRA like '%" + txtConsultarAsginacionProducto.Text + "%' or P.NOMBREPRODUCTO like '%" + txtConsultarAsginacionProducto.Text + "%' or B.NOMBRE like '%" + txtConsultarAsginacionProducto.Text + "%');"))
                        dgvDatosAsignacionProducto.Columns["IDPRODUCTO"].Visible = false;
                }
            }
        }
    }
}