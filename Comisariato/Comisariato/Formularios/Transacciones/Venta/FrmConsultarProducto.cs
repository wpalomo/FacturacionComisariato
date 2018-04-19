using Comisariato.Clases;
using Comisariato.Formularios.Mantenimiento.Inventario;
using Comisariato.Formularios.Transacciones.Venta;
using Comisariato.Formularios.Informes;
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
    public partial class FrmConsultarProducto : Form
    {
        Consultas ObjConsul;


        public FrmConsultarProducto()
        {
            InitializeComponent();
        }

        private void FrmConsultarProducto_Load(object sender, EventArgs e)
        {
            txtconsultar.Focus();
            ObjConsul = new Consultas();

            
            //ObjConsul.boolLlenarDataGridView(dgvProductos, "Select TbProducto.CODIGOBARRA AS CODIGO, TbProducto.DETALLE,TbProducto.CANTIDAD, TbProducto.PRECIOVENTAPUBLICO AS PRECIOPUBLICO, TbProducto.PRECIOVENTAMAYORISTA AS PRECIOMAY, TbProducto.PRECIOVENTACAJA AS PRECIOCAJA from TbProducto;");
            ObjConsul.BoolCrearDateTable(dgvProductos, "Select  P.IVA as IVA, TbProducto.CODIGOBARRA, TbProducto.ACTIVO, TbProducto.NOMBREPRODUCTO AS DETALLE,TbProducto.CANTIDAD, TbProducto.PRECIOPUBLICO_SIN_IVA AS PRECIOVENTAPUBLICO, TbProducto.PRECIOALMAYOR_SIN_IVA AS PRECIOVENTAMAYORISTA, TbProducto.PRECIOPORCAJA_SIN_IVA AS PRECIOVENTACAJA, TbProducto.IVAESTADO from TbProducto , TbParametrosFactura P; ");
            dgvProductos.Columns[0].Width = 150;
            dgvProductos.Columns[1].Width = 210;
        }

        private void txtconsultar_TextChanged(object sender, EventArgs e)
        {
            ObjConsul = new Consultas();
            ObjConsul.BoolCrearDateTable(dgvProductos, "Select  P.IVA as IVA, TbProducto.CODIGOBARRA, TbProducto.ACTIVO, TbProducto.NOMBREPRODUCTO AS DETALLE,TbProducto.CANTIDAD, TbProducto.PRECIOPUBLICO_SIN_IVA AS PRECIOVENTAPUBLICO, TbProducto.PRECIOALMAYOR_SIN_IVA AS PRECIOVENTAMAYORISTA, TbProducto.PRECIOPORCAJA_SIN_IVA AS PRECIOVENTACAJA, TbProducto.IVAESTADO from TbProducto , TbParametrosFactura P where NOMBREPRODUCTO like '%" + txtconsultar.Text + "%' or CODIGOBARRA like '%" + txtconsultar.Text +"%';");
            dgvProductos.Columns[0].Width = 150;
            dgvProductos.Columns[1].Width = 210;
        }

        private void FrmConsultarProducto_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    dgvProductos.Focus();
                    //dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
                case Keys.Down:
                    dgvProductos.Focus();
                    //dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
                case Keys.B:
                    txtconsultar.Focus();
                    //dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
                case Keys.Escape:
                    try
                    {
                        if (Program.banderaProductosCompras)
                        {
                            FrmCompra.CodigoBarraConsultaProducto = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                            Program.banderaProductosCompras = false;
                            this.Close();
                        }

                        else if (Program.banderaProductosConsultarKardex)
                        {
                            FrmKardex.CodigoBarraConsultaProducto = dgvProductos.CurrentRow.Cells[0].Value.ToString() + ";" + dgvProductos.CurrentRow.Cells[1].Value.ToString();
                            Program.banderaProductosConsultarKardex = false;
                            this.Close();
                        }
                        else if(Program.banderaProductosConsultarPrecio)
                        {
                            //FrmConsultarPrecios.DatosProducto.Cear();
                            FrmConsultarPrecios.DatosProducto.Add(dgvProductos.CurrentRow.Cells[0].Value.ToString());
                            this.Close();
                        }
                        else
                        {
                            if (Convert.ToSingle(dgvProductos.CurrentRow.Cells[2].Value) > 0)
                            {

                                    if (FrmFactura.DatosProducto.Count > 0)
                                    {
                                        FrmFactura.DatosProducto.Clear();
                                    }
                                    FrmFactura.verificadorfrm = 2;
                                    FrmFactura.DatosProducto.Add(dgvProductos.CurrentRow.Cells[0].Value.ToString());
                                    FrmFactura.DatosProducto.Add(dgvProductos.CurrentRow.Cells[1].Value.ToString());
                                    FrmFactura.DatosProducto.Add(dgvProductos.CurrentRow.Cells[2].Value.ToString());
                                    FrmFactura.DatosProducto.Add(dgvProductos.CurrentRow.Cells[3].Value.ToString());
                                    FrmFactura.DatosProducto.Add(dgvProductos.CurrentRow.Cells[4].Value.ToString());
                                    FrmFactura.DatosProducto.Add(dgvProductos.CurrentRow.Cells[5].Value.ToString());
                                    FrmFactura.DatosProducto.Add(dgvProductos.CurrentRow.Cells[6].Value.ToString());
                                    FrmFactura.DatosProducto.Add(dgvProductos.CurrentRow.Cells[7].Value.ToString());
                                    //FrmFactura.DatosProducto.Add(dgvProductos.CurrentRow.Cells[8].Value.ToString());
                                   // FrmFactura.DatosProducto.Add(dgvProductos.CurrentRow.Cells[9].Value.ToString());
                                    this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Producto agotado. Selecciona otro producto con cantidad diferente de cero.");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("error");
                        //throw;
                    }
                   
                    break;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtconsultar.Focus();
            this.Close();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (FrmFactura.DatosCliente.Count > 0)
                {
                    FrmFactura.DatosCliente.Clear();
                }
                FrmFactura.verificadorfrm = 2;
                FrmFactura.DatosCliente.Add(dgvProductos.CurrentRow.Cells[0].Value.ToString());
                FrmFactura.DatosCliente.Add(dgvProductos.CurrentRow.Cells[1].Value.ToString());
                FrmFactura.DatosCliente.Add(dgvProductos.CurrentRow.Cells[2].Value.ToString());
                FrmFactura.DatosCliente.Add(dgvProductos.CurrentRow.Cells[3].Value.ToString());
                FrmFactura.DatosCliente.Add(dgvProductos.CurrentRow.Cells[4].Value.ToString());
                FrmFactura.DatosCliente.Add(dgvProductos.CurrentRow.Cells[5].Value.ToString());
                FrmFactura.DatosCliente.Add(dgvProductos.CurrentRow.Cells[6].Value.ToString());
                FrmFactura.DatosCliente.Add(dgvProductos.CurrentRow.Cells[7].Value.ToString());
                FrmFactura.DatosCliente.Add(dgvProductos.CurrentRow.Cells[8].Value.ToString());
                FrmFactura.DatosCliente.Add(dgvProductos.CurrentRow.Cells[9].Value.ToString());
                this.Close();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void FrmConsultarProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
        }
    }
}
