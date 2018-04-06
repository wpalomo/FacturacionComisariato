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
    public partial class FrmComboProductos : Form
    {
        List<Producto> datos;
        Consultas objc;
        List<int> indezp = new List<int>();
        private int posindexp = 0,idcombo=0;
        int bandera=1;
        string codigobarra = "";



        //NOMBREPRODUCTO like '%" + txtconsultar.Text + "%' or CODIGOBARRA like '%" + txtconsultar.Text +"%'
        public FrmComboProductos()
        {
            InitializeComponent();
        }

        private void FrmComboProductos_Load(object sender, EventArgs e)
        {
            objc = new Consultas();
            objc.CargarProductoCombo("SELECT TbProducto.IDPRODUCTO, TbProducto.PRECIOPUBLICO_SIN_IVA, TbProducto.CANTIDAD, TbProducto.CODIGOBARRA, TbProducto.NOMBREPRODUCTO, TbBodega.NOMBRE, TbCategoria.DESCRIPCION from TbProducto  INNER JOIN TbAsignacionProductoBodega ON(TbProducto.IDPRODUCTO=TbAsignacionProductoBodega.IDPRODUCTO ) INNER JOIN TbBodega ON (TbAsignacionProductoBodega.IDBODEGA=TbBodega.IDBODEGA) INNER JOIN TbCategoria ON (TbProducto.IDCATEGORIA=TbCategoria.IDCATEGORIA);", dgvProductosParaCombo);
            


            objc.CargarCombos("SELECT TbCombo.IDCOMBO, TbCombo.PRECIO, TbCombo.CANTIDAD, TbCombo.CODIGO, TbCombo.NOMBRE from TbCombo where ESTADO=1", dgvDatosCombo);
            //dgvProductosParaCombo.Columns[0].Width = 150;
            AnchoColumna();
        }

        private void AnchoColumna()
        {

            dgvProductosParaCombo.Columns[7].Visible = false;
            dgvDatosCombo.Columns[6].Visible = false;
            dgvProductosParaCombo.Columns[6].Width = 20;
            dgvProductosParaCombo.Columns[1].Width = 181;
            dgvProductosParaCombo.Columns[0].Width = 150;

        }

        private void btnAgregarProductoACombo_Click(object sender, EventArgs e)
        {
            ObtenerCombo();
        }

        private void dgvProductosParaCombo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProductosParaCombo.CurrentCell != this.dgvProductosParaCombo.CurrentRow.Cells[6])
                {
                    dgvProductosParaCombo.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                    //txtCodigo.Focus();
                }
                else
                {
                    //dgvProductosParaCombo.Rows[e.RowIndex].Cells[6].Value = true;
                    //if (dgvProductosParaCombo.Rows[e.RowIndex].Cells[0].Value != null && dgvProductosParaCombo.Rows[e.RowIndex].Cells[1].Value != null)
                    //{
                        
                    //    if (verificarindex(e.RowIndex))
                    //    {
                            
                    //        indezp.RemoveAt(posindexp);
                    //    }
                    //    else
                    //    {
                    //        indezp.Add(e.RowIndex);
                    //    }
                    //}
                }
            }
            catch (Exception)
            {

                // txtCodigo.Focus();
            }
        }

        private void ObtenerCombo()
        {
            try
            {
                int cont=0;
                //if (indezp.Count>2)
                //{
                if (indezp.Count>0)
                {
                    indezp.Clear();
                }
                    dgvProductosEnCombo.Rows.Clear();
                    for (int i = 0; i < dgvProductosParaCombo.RowCount; i++)
                    {
                    if (Convert.ToBoolean(dgvProductosParaCombo.Rows[i].Cells[6].Value)==true)
                    {
                        dgvProductosEnCombo.Rows.Add();
                        dgvProductosEnCombo.Rows[cont].Cells[0].Value = dgvProductosParaCombo.Rows[i].Cells[0].Value;
                        dgvProductosEnCombo.Rows[cont].Cells[1].Value = dgvProductosParaCombo.Rows[i].Cells[2].Value;
                        dgvProductosEnCombo.Rows[cont].Cells[2].Value = dgvProductosParaCombo.Rows[i].Cells[1].Value;
                        dgvProductosEnCombo.Rows[cont].Cells[4].Value = dgvProductosParaCombo.Rows[i].Cells[3].Value;
                        dgvProductosEnCombo.Rows[cont].Cells[5].Value = dgvProductosParaCombo.Rows[i].Cells[4].Value;
                        dgvProductosEnCombo.Rows[cont].Cells[6].Value = dgvProductosParaCombo.Rows[i].Cells[5].Value;
                        dgvProductosEnCombo.Rows[cont].Cells[7].Value = dgvProductosParaCombo.Rows[i].Cells[7].Value;
                        cont++;
                        indezp.Add(i);

                    }

                    // dgvProductosParaCombo.Rows[indezp[i]].Cells[4].Value
                    //dgvProductosEnCombo.Rows[i].Cells[0].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[0].Value;
                    //dgvProductosEnCombo.Rows[i].Cells[1].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[2].Value;
                    //dgvProductosEnCombo.Rows[i].Cells[2].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[1].Value;
                    //dgvProductosEnCombo.Rows[i].Cells[4].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[3].Value;
                    //dgvProductosEnCombo.Rows[i].Cells[5].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[4].Value;
                    //dgvProductosEnCombo.Rows[i].Cells[6].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[5].Value;
                    //dgvProductosEnCombo.Rows[i].Cells[7].Value = dgvProductosParaCombo.Rows[indezp[i]].Cells[7].Value;
                    //dgvProductosParaCombo.Rows.RemoveAt(indezp[i]);
                    //dgvProductosParaCombo.Rows.Add(" ");

                }
                    dgvProductosEnCombo.CurrentCell = dgvProductosEnCombo.Rows[0].Cells[3];
                    dgvProductosEnCombo.BeginEdit(true);
                //}
                //else
                //{
                //    MessageBox.Show("Selecciona al menos tres productos para poder formar un combo");
                //}
                
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }

        }

        //private bool verificarindex(int inde)
        //{
        //    bool b = false;
        //    for (int i = 0; i < indezp.Count; i++)
        //    {
        //        if (indezp[i] == inde)
        //        {
        //            posindexp = i;
        //            b = true;
        //        }
        //    }
        //    return b;
        //}

        private void btnGuardarCombo_Click(object sender, EventArgs e)
        {
            try
            {
                objc = new Consultas();
                
                if (indezp.Count > 2)
                {
                    if (VerificarCantidades())
                    {
                        if (verificarCantidadeslimites())
                        {
                            if (txtCodigoCombo.Text != "")
                            {
                                bool b1 = false ;
                                if (bandera==1)
                                {
                                    b1 = objc.verificarRepetido("select * from TbCombo U where U.CODIGO='" + txtCodigoCombo.Text + "'");
                                }
                                
                                if (!b1)
                                {
                                    if (txtNombreCombo.Text != "")
                                    {
                                        if (txtCantCombo.Text != "")
                                        {
                                            if (txtPrecioCombo.Text != "")
                                            {
                                                //Consultas c = new Consultas();
                                                //int filas = indezp.Count;
                                               
                                                if (bandera==1)
                                                {
                                                    List<String> encabezadoCombo = new List<String>();
                                                    encabezadoCombo.Add(txtCodigoCombo.Text);
                                                    encabezadoCombo.Add(txtNombreCombo.Text);
                                                    encabezadoCombo.Add(txtCantCombo.Text);
                                                    encabezadoCombo.Add(txtPrecioCombo.Text);
                                                    bool b = objc.GrabarCombo(encabezadoCombo, dgvProductosEnCombo, bandera);
                                                    if (b)
                                                    {
                                                        MessageBox.Show("Registro realizado con exito.");
                                                        Limpiar();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Error al realizar el registro.");
                                                    }

                                                }
                                                else
                                                {
                                                    bool a = objc.EjecutarSQL("UPDATE TbCombo SET CODIGO ='" + txtCodigoCombo.Text+ "', NOMBRE='"+ txtNombreCombo.Text+ "', CANTIDAD='"+ txtCantCombo.Text+ "', PRECIO='"+ Funcion.reemplazarcaracter(txtPrecioCombo.Text)+"'  WHERE IDCOMBO = '"+idcombo+"'");
                                                    if (a)
                                                    {
                                                        objc.EjecutarSQL("UPDATE TbProducto SET NOMBREPRODUCTO = '"+ txtNombreCombo.Text+ "', CODIGOBARRA='" +txtCodigoCombo.Text +"', CANTIDAD= '"+ txtCantCombo.Text+ "', PRECIOPUBLICO_IVA='"+ Funcion.reemplazarcaracter(txtPrecioCombo.Text)+ "', PRECIOPUBLICO_SIN_IVA ='" + Funcion.reemplazarcaracter(txtPrecioCombo.Text) + "' ,PRECIOALMAYOR_IVA ='" + Funcion.reemplazarcaracter(txtPrecioCombo.Text) + "' ,PRECIOALMAYOR_SIN_IVA ='" + Funcion.reemplazarcaracter(txtPrecioCombo.Text) + "' ,PRECIOPORCAJA_IVA='" + Funcion.reemplazarcaracter(txtPrecioCombo.Text) + "' ,PRECIOPORCAJA_SIN_IVA='" + Funcion.reemplazarcaracter(txtPrecioCombo.Text) + "' where CODIGOBARRA='"+ codigobarra+"';");
                                                        MessageBox.Show("Actualizacion realizado con exito.");
                                                        Limpiar();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Error al realizar la actualizacion.");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ingresa el precio del combo.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ingresa la cantidad del combo.");
                                            txtCantCombo.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingresa el nombre del codigo.");
                                        txtNombreCombo.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ya existe un combo registrado con ese codigo");
                                    txtCodigoCombo.Focus();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Ingresa el código del combo.");
                                txtCodigoCombo.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La cantidad ingresada nunca debe ser mayor a la cantida en bodega\n Errror... Fila: "+posicion+"  Producto: "+producto);
                            dgvProductosEnCombo.Focus();
                            dgvProductosEnCombo.CurrentCell = dgvProductosEnCombo.Rows[posicion - 1].Cells[3];
                            dgvProductosEnCombo.BeginEdit(true);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingresa todas las cantidades de la tabla 'Combo de Productos'.");
                        dgvProductosEnCombo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona al menos tres productos diferentes\npara formar un combo.");
                }
            }
            catch (Exception)
            {

                //throw;
            }
           
        }

        private bool VerificarCantidades()
        {
            bool b=true;
            for (int i = 0; i < indezp.Count; i++)
            {
                if (dgvProductosEnCombo.Rows[i].Cells[0].Value!=null)
                {
                    if (dgvProductosEnCombo.Rows[i].Cells[3].Value == null)
                    {
                        b = false;
                        break;
                    }
                }
                else
                {
                    break;
                }
                
            }
            return b;
        }

        private int posicion = 0;
        private string producto;

        private bool verificarCantidadeslimites()
        {
            bool b = true;
            for (int i = 0; i < indezp.Count; i++)
            {
                int cantidadingresada = Convert.ToInt32(dgvProductosEnCombo.Rows[i].Cells[3].Value);
                int cantidadbodega= Convert.ToInt32(dgvProductosEnCombo.Rows[i].Cells[5].Value);
                if ( cantidadingresada>cantidadbodega)
                {
                    producto =Convert.ToString(dgvProductosEnCombo.Rows[i].Cells[2].Value);
                    posicion = i+1;
                    b = false;
                    break;
                }
            }
            return b;
        }

        private void txtBuscarProductosParaCombo_TextChanged(object sender, EventArgs e)
        {
            objc = new Consultas();
            objc.CargarProductoCombo("SELECT TbProducto.IDPRODUCTO, TbProducto.PRECIOPUBLICO_SIN_IVA, TbProducto.CANTIDAD, TbProducto.CODIGOBARRA, TbProducto.NOMBREPRODUCTO, TbBodega.NOMBRE, TbCategoria.DESCRIPCION from TbProducto  INNER JOIN TbAsignacionProductoBodega ON(TbProducto.IDPRODUCTO=TbAsignacionProductoBodega.IDPRODUCTO ) INNER JOIN TbBodega ON (TbAsignacionProductoBodega.IDBODEGA=TbBodega.IDBODEGA) INNER JOIN TbCategoria ON (TbProducto.IDCATEGORIA=TbCategoria.IDCATEGORIA) where TbProducto.NOMBREPRODUCTO like '%" + txtBuscarProductosParaCombo.Text + "%' or TbProducto.CODIGOBARRA like '%" + txtBuscarProductosParaCombo.Text + "%'", dgvProductosParaCombo);
            //datos = objc.CargarProductoCombo("SELECT TbProducto.PRECIOPUBLICO_SIN_IVA, TbProducto.CANTIDAD, TbProducto.CODIGOBARRA, TbProducto.NOMBREPRODUCTO, TbBodega.NOMBRE, TbCategoria.DESCRIPCION from TbProducto  INNER JOIN TbAsignacionProductoBodega ON(TbProducto.IDPRODUCTO=TbAsignacionProductoBodega.IDPRODUCTO ) INNER JOIN TbBodega ON (TbAsignacionProductoBodega.IDBODEGA=TbBodega.IDBODEGA) INNER JOIN TbCategoria ON (TbProducto.IDCATEGORIA=TbCategoria.IDCATEGORIA) where TbProducto.NOMBREPRODUCTO like '%" + txtBuscarProductosParaCombo.Text + "%' or TbProducto.CODIGOBARRA like '%" + txtBuscarProductosParaCombo.Text + "%'");
            dgvProductosParaCombo.Columns[7].Visible = false;
        }

        private void btnLimpiarCombo_Click(object sender, EventArgs e)
        {
            Limpiar();
            
        }

        private void Limpiar()
        {
            txtBuscarProductosParaCombo.Text = "";
            txtConsultarCombo.Text = "";
            txtNombreCombo.Text = "";
            txtCodigoCombo.Text = "";
            txtCantCombo.Text = "";
            txtPrecioCombo.Text = "";
            dgvProductosEnCombo.Rows.Clear();
            bandera = 1;
            objc = new Consultas();
            objc.CargarProductoCombo("SELECT TbProducto.IDPRODUCTO, TbProducto.PRECIOPUBLICO_SIN_IVA, TbProducto.CANTIDAD, TbProducto.CODIGOBARRA, TbProducto.NOMBREPRODUCTO, TbBodega.NOMBRE, TbCategoria.DESCRIPCION from TbProducto  INNER JOIN TbAsignacionProductoBodega ON(TbProducto.IDPRODUCTO=TbAsignacionProductoBodega.IDPRODUCTO ) INNER JOIN TbBodega ON (TbAsignacionProductoBodega.IDBODEGA=TbBodega.IDBODEGA) INNER JOIN TbCategoria ON (TbProducto.IDCATEGORIA=TbCategoria.IDCATEGORIA);", dgvProductosParaCombo);
            cargarDatos("1");
            //dgvProductosParaCombo.Columns[0].Width = 150;
            AnchoColumna();
            btnAgregarProductoACombo.Enabled = true;
            txtCodigoCombo.Focus();
        }

        private void txtCodigoCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCodigoCombo.Text!="")
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    objc = new Consultas();
                    bool b = objc.verificarRepetido("select * from TbCombo U where U.CODIGO='" + txtCodigoCombo.Text + "'");
                    if (b)
                    {
                        MessageBox.Show("Ya existe un combo registrado con ese codigo");
                        txtCodigoCombo.Focus();
                    }
                    else
                    {
                        txtNombreCombo.Focus();
                    }
                }
            }
            else
            {
                txtCodigoCombo.Focus();
            }
            
        }

        private void txtCantCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtCantCombo.Text!="")
                {
                    txtPrecioCombo.Focus();
                }
                else
                {
                    txtCantCombo.Focus();
                }
            }
            else
            {
                Funcion.Validar_Numeros(e);
            }
        }

        private void txtPrecioCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtPrecioCombo.Text != "")
                {
                    btnGuardarCombo.Focus();
                }
                else
                {
                    txtPrecioCombo.Focus();
                }
            }
            else
            {
                Funcion.SoloValores(e,txtPrecioCombo.Text);
            }
        }

        private void dgvProductosEnCombo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox txt = e.Control as TextBox;


                txt.KeyPress += OnlyNumbersdgvcheque_KeyPress;
                // Funcion.SoloValores(e,txt);
            }
        }

        private void OnlyNumbersdgvcheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvProductosEnCombo.CurrentCell == this.dgvProductosEnCombo.CurrentRow.Cells[3])
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // Si no es numerico y si no es espacio
                {
                    // Invalidar la accion
                    e.Handled = true;
                    // Enviar el sonido de beep de windows
                    System.Media.SystemSounds.Beep.Play();
                }

            }


        }

        private void txtConsultarCombo_TextChanged(object sender, EventArgs e)
        {
            objc = new Consultas();
            objc.CargarCombos("SELECT TbCombo.IDCOMBO, TbCombo.PRECIO, TbCombo.CANTIDAD, TbCombo.CODIGO, TbCombo.NOMBRE from TbCombo where TbCombo.NOMBRE like '%" + txtConsultarCombo.Text + "%' or TbCombo.CODIGO like '%" + txtConsultarCombo.Text + "%'", dgvDatosCombo);
            //datos = objc.CargarProductoCombo("SELECT TbProducto.PRECIOPUBLICO_SIN_IVA, TbProducto.CANTIDAD, TbProducto.CODIGOBARRA, TbProducto.NOMBREPRODUCTO, TbBodega.NOMBRE, TbCategoria.DESCRIPCION from TbProducto  INNER JOIN TbAsignacionProductoBodega ON(TbProducto.IDPRODUCTO=TbAsignacionProductoBodega.IDPRODUCTO ) INNER JOIN TbBodega ON (TbAsignacionProductoBodega.IDBODEGA=TbBodega.IDBODEGA) INNER JOIN TbCategoria ON (TbProducto.IDCATEGORIA=TbCategoria.IDCATEGORIA) where TbProducto.NOMBREPRODUCTO like '%" + txtBuscarProductosParaCombo.Text + "%' or TbProducto.CODIGOBARRA like '%" + txtBuscarProductosParaCombo.Text + "%'");
            dgvDatosCombo.Columns[6].Visible = false;
        }

        private void dgvDatosCombo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //objc = new Consultas();
                //objc.CargarProductosdelcombo(Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[4].Value), dgvDetalleCombo);

                objc = new Consultas();
                if (rdbCombosActivos.Checked)
                {

                    if (this.dgvDatosCombo.Columns[e.ColumnIndex].Name == "Desabilitar")
                    {
                        ///"UPDATE TbProveedor SET ESTADO = 1 WHERE IDENTIFICACION = '" + Identificacion + "'"
                        
                        objc.EjecutarSQL("UPDATE TbCombo SET ESTADO = 0 WHERE IDCOMBO = '" + Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[6].Value) + "'");
                        objc.EjecutarSQL("UPDATE TbProducto SET ACTIVO = 0 WHERE CODIGOBARRA = '" + Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[2].Value) + "'");
                        cargarDatos("1");
                        if (dgvDetalleCombo.RowCount>0)
                        {
                            dgvDetalleCombo.Rows.Clear();
                        }
                        
                    }
                }
                else if (rdbCombosInactivos.Checked)
                {
                    if (this.dgvDatosCombo.Columns[e.ColumnIndex].Name == "Desabilitar")
                    {
                        objc.EjecutarSQL("UPDATE TbCombo SET ESTADO = 1 WHERE IDCOMBO = '" +Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[6].Value) + "'");
                        objc.EjecutarSQL("UPDATE TbProducto SET ACTIVO = 1 WHERE CODIGOBARRA = '" + Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[2].Value) + "'");
                        cargarDatos("0");
                        if (dgvDetalleCombo.RowCount > 0)
                        {
                            dgvDetalleCombo.Rows.Clear();
                        }
                    }
                }

                if (this.dgvDatosCombo.Columns[e.ColumnIndex].Name == "Modificar")
                {
                    bandera = 2;
                    idcombo = Convert.ToInt32(dgvDatosCombo.Rows[e.RowIndex].Cells[6].Value);
                    btnAgregarProductoACombo.Enabled = false;
                    codigobarra = Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[2].Value);
                   //String identificacion = dgvDatosCombo.CurrentRow.Cells[3].Value.ToString();
                   tcComboProducto.SelectedIndex = 0;
                    //objc = new Consultas();
                    txtCodigoCombo.Text = Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[2].Value);
                    txtNombreCombo.Text= Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[3].Value);
                    txtCantCombo.Text= Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[4].Value);
                    txtPrecioCombo.Text= Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[5].Value);


                    objc.CargarProductosdelcombo(Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[6].Value), dgvDetalleCombo);
                    
                    for (int i = 0; i < dgvDetalleCombo.RowCount; i++)
                    {
                        indezp.Add(i);
                        dgvProductosEnCombo.Rows.Add("");
                        dgvProductosEnCombo.Rows[i].Cells[0].Value = dgvDetalleCombo.Rows[i].Cells[0].Value;
                        dgvProductosEnCombo.Rows[i].Cells[2].Value = dgvDetalleCombo.Rows[i].Cells[1].Value;
                        dgvProductosEnCombo.Rows[i].Cells[3].Value = dgvDetalleCombo.Rows[i].Cells[2].Value;
                        if (fila(Convert.ToString(dgvDetalleCombo.Rows[i].Cells[0].Value)))
                        {
                            
                            dgvProductosEnCombo.Rows[i].Cells[1].Value = dgvProductosParaCombo.Rows[n].Cells[2].Value;
                            dgvProductosEnCombo.Rows[i].Cells[4].Value = dgvProductosParaCombo.Rows[n].Cells[3].Value;
                            dgvProductosEnCombo.Rows[i].Cells[5].Value = dgvProductosParaCombo.Rows[n].Cells[4].Value;
                            dgvProductosEnCombo.Rows[i].Cells[6].Value = dgvProductosParaCombo.Rows[n].Cells[5].Value;
                            dgvProductosParaCombo.Rows[n].Cells[6].Value = true;
                            dgvProductosEnCombo.Rows[i].Cells[7].Value = dgvProductosParaCombo.Rows[n].Cells[6].Value;
                           
                        }
                    }


                }
                //btnLimpiarProveedor.Text = "&Cancelar";
                //btnGuardarProveedor.Text = "&Modificar";
            }
            catch (Exception)
            {

                //throw;
            }
        }
        int n = 0;
        private bool fila(String codigo)
        {
            bool b=false;
            for (int i = 0; i < dgvProductosParaCombo.RowCount; i++)
            {
               if (Convert.ToString(dgvProductosParaCombo.Rows[i].Cells[0].Value) == codigo)
               {
                    n = i;
                    b = true;
                    break;
               }
            }
            return b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDatosCombo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvDatosCombo.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = dgvDatosCombo.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\modificarDgv.ico");

                Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.modificarDgv);
                IntPtr Hicon = bitmap.GetHicon();
                Icon icoAtomico = Icon.FromHandle(Hicon);
                //bitmap.SetResolution(72, 72);


                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                dgvDatosCombo.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dgvDatosCombo.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }

            if (rdbCombosInactivos.Checked)
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosCombo.Columns[e.ColumnIndex].Name == "Desabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosCombo.Rows[e.RowIndex].Cells["Desabilitar"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\Habilitar.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.Habilitar);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosCombo.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosCombo.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
            else
            {
                if (e.ColumnIndex >= 1 && this.dgvDatosCombo.Columns[e.ColumnIndex].Name == "Desabilitar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celBoton = this.dgvDatosCombo.Rows[e.RowIndex].Cells["Desabilitar"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\EliminarDgv.ico");

                    Bitmap bitmap = new Bitmap(Comisariato.Properties.Resources.EliminarDgv);
                    IntPtr Hicon = bitmap.GetHicon();
                    Icon icoAtomico = Icon.FromHandle(Hicon);
                    //bitmap.SetResolution(72, 72);

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.dgvDatosCombo.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgvDatosCombo.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }

        private void rdbCombosActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCombosActivos.Checked)
            {
               cargarDatos("1");
               // dgvDatosCombo.Columns[1].Visible = true;
                //dgvDatosProveedor.Columns[1].HeaderText = "Desabilitar";
            }
            else if (rdbCombosInactivos.Checked)
            {
                cargarDatos("0");
                //dgvDatosCombo.Columns[1].Visible = false;
                //dgvDatosProveedor.Columns[1].HeaderText = "Habilitar";
            }
        }

        private void cargarDatos(string condicion)
        {
            objc = new Consultas();
            objc.CargarCombos("SELECT TbCombo.IDCOMBO, TbCombo.PRECIO, TbCombo.CANTIDAD, TbCombo.CODIGO, TbCombo.NOMBRE from TbCombo where ESTADO='"+condicion +"'", dgvDatosCombo);
            dgvDatosCombo.Columns[6].Visible = false;
        }

        private void dgvDatosCombo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            objc = new Consultas();
            objc.CargarProductosdelcombo(Convert.ToString(dgvDatosCombo.Rows[e.RowIndex].Cells[6].Value), dgvDetalleCombo);
        }

        private void rdbCombosInactivos_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
