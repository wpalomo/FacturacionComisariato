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

namespace Comisariato.Formularios.Transacciones.Devolucion_Venta
{
    public partial class FrmDevolucionVenta : Form
    {
        EmcabezadoFactura em;
        Consultas c = new Consultas();
        List<Producto> product;
        private int posindexp = 0;
        List<int> indezp = new List<int>();
        List<String> pedidos = new List<String>();
        Bitacora bitacora = new Bitacora();
        public FrmDevolucionVenta()
        {
            InitializeComponent();
            c.seriesDocumentoRetencion(txtNumeroND, txtSerie1ND, txtSerie2ND, txtAutorizacionND, "NDEB", bitacora.LocalIPAddress());
            int i = 0;
            for (i = 0; i < 21; i++)
            {
                DgvDetalleFact.Rows.Add();
            }
            DgvDetalleFact.Rows[i-1].ReadOnly = true;
            DgvDetalleFact.Columns[6].ReadOnly = true;
            DgvDetalleFact.Columns[7].ReadOnly = true;
            lblUsuario.Text = "";
            txtTotalDevolucion.Text = "0.00";
            txtTotalFactura.Text = "0.00";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            c = new Consultas();
            try
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    
                    em = c.ConsutarFactura(int.Parse(txtSucursal.Text), int.Parse(txtCaja.Text), int.Parse(txtNumFact.Text),2);
                    if (em != null)
                    {
                        product = c.detalleFact;
                        if (product.Count > 0)
                        {
                            limpiarDGV();
                            llenarDgV();
                            lblUsuario.Text = "Usuario: " + em.NombreUsuario;
                            txtCliente.Text = em.NombresCliente;                            
                            DgvDetalleFact.CurrentCell = DgvDetalleFact.Rows[0].Cells[0];
                            DgvDetalleFact.BeginEdit(true);
                            
                        }
                        else
                        {
                            MessageBox.Show("Todos los Items de esta factura ya Fueron dados de baja.");
                            LimpiarTodo();
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(""+ex.Message);
            }
           
        }

        private void llenarDgV()
        {
            float total=0,iva=0,totalfactura=0;
            for (int i = 0; i < product.Count; i++)
            {
                DgvDetalleFact.Rows[i].Cells[0].Value=product[i].Codigobarra;
                DgvDetalleFact.Rows[i].Cells[1].Value = product[i].Nombreproducto;
                DgvDetalleFact.Rows[i].Cells[2].Value = product[i].Cantidad;
                DgvDetalleFact.Rows[i].Cells[3].Value = product[i].Preciopublico_sin_iva;
                // DgvDetalleFact.Rows[i].Cells[4].Value = product[i].Iva;
                iva = ((product[i].Cantidad * product[i].Preciopublico_sin_iva) * product[i].Iva) / 100;
                total = (product[i].Cantidad * product[i].Preciopublico_sin_iva) + iva;
                DgvDetalleFact.Rows[i].Cells[4].Value = iva;
                DgvDetalleFact.Rows[i].Cells[5].Value = total;
                DgvDetalleFact.Rows[i].Cells[6].ReadOnly = false;
                DgvDetalleFact.Rows[i].Cells[7].ReadOnly = false;
                totalfactura += total;
            }
            txtTotalFactura.Text = totalfactura.ToString("#####0.00");
        }

        private void txtCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtCaja.Text != "")
                {
                    txtNumFact.Focus();
                }

            }
            else
            {
                Funcion.Validar_Numeros(e);
            }
        }

        private void txtSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtSucursal.Text != "")
                {
                    txtCaja.Focus();
                }

            }
            else
            {
                Funcion.Validar_Numeros(e);
            }

        }
       
        private void DgvDetalleFact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvDetalleFact.CurrentCell != this.DgvDetalleFact.CurrentRow.Cells[6])
                {
                    DgvDetalleFact.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                    //txtCodigo.Focus();
                }
                else
                {
                    //if (DgvDetalleFact.Rows[e.RowIndex].Cells[0].Value != null && DgvDetalleFact.Rows[e.RowIndex].Cells[1].Value != null)
                    //{
                    //    if (Convert.ToBoolean(DgvDetalleFact.Rows[e.RowIndex].Cells[6].Value))
                    //    {
                    //        if (verificarindex(e.RowIndex))
                    //        {
                    //            indezp.RemoveAt(posindexp);
                    //        }
                    //        else
                    //        {
                    //            indezp.Add(e.RowIndex);
                    //        }
                    //    }
                        
                    //}
                }
            }
            catch (Exception)
            {

               // txtCodigo.Focus();
            }
        }

        private void CalcularDevolucion()
        {
            float totalDevo = 0;
            for (int i = 0; i < DgvDetalleFact.RowCount; i++)
            {
                if (DgvDetalleFact.Rows[i].Cells[0].Value != null && DgvDetalleFact.Rows[i].Cells[1].Value != null)
                {
                    if (Convert.ToBoolean(DgvDetalleFact.Rows[i].Cells[7].Value))
                    {
                        if (DgvDetalleFact.Rows[i].Cells[6].Value != null)
                        {
                            totalDevo += (Convert.ToSingle(DgvDetalleFact.Rows[i].Cells[3].Value)*Convert.ToInt32(DgvDetalleFact.Rows[i].Cells[6].Value))+ Convert.ToSingle(DgvDetalleFact.Rows[i].Cells[4].Value);
                        } 
                    }
                }
                else
                {
                    break;
                }
               
               
            }
            txtTotalDevolucion.Text = totalDevo.ToString("#####0.00");
        }

        private bool verificarindex(int inde)
        {
            bool b = false;
            for (int i = 0; i < indezp.Count; i++)
            {
                if (indezp[i] == inde)
                {
                    posindexp = i;
                    b = true;
                }
            }
            return b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    if (product.Count > 0)
                    {
                        if (indezp.Count > 0)
                        {
                            indezp.Clear();
                        }
                        for (int i = 0; i < DgvDetalleFact.RowCount; i++)
                        {
                            if (Convert.ToString(DgvDetalleFact.Rows[i].Cells[0].Value) != "")
                            {
                                DgvDetalleFact.Rows[i].Cells[7].Value = true;
                                //indezp.Add(i);
                            }
                            else
                            {
                                break;
                            }
                        }
                        CalcularDevolucion();
                        //MessageBox.Show("" + indezp.Count);
                    }
                      
                }
                else
                {
                    for (int i = 0; i < DgvDetalleFact.RowCount; i++)
                    {
                        if (Convert.ToString(DgvDetalleFact.Rows[i].Cells[0].Value) != "")
                        {
                            DgvDetalleFact.Rows[i].Cells[6].Value = false;
                        }
                        else
                        {
                            break;
                        }
                    }
                    indezp.Clear();
                    txtTotalDevolucion.Text = "0.00";
                    //MessageBox.Show(""+indezp.Count);
                }
               
            }
            catch (Exception ex)
            {
            }
        }

        private void ObtenerPedidos()
        {
            try
            {
                for (int i = 0; i < DgvDetalleFact.RowCount; i++)
                {
                    if (DgvDetalleFact.Rows[i].Cells[0].Value != null && DgvDetalleFact.Rows[i].Cells[1].Value != null)
                    {
                        if (Convert.ToBoolean(DgvDetalleFact.Rows[i].Cells[7].Value))
                        {
                            pedidos.Add("" + DgvDetalleFact.Rows[i].Cells[0].Value + ";" + DgvDetalleFact.Rows[i].Cells[6].Value);
                            indezp.Add(i);
                        }
                    }
                    else
                    {
                        break;
                    }
                    

                }
            }
            catch (Exception)
            {
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void LimpiarTodo()
        {
            txtCaja.Text = "";
            txtNumFact.Text = "";
            txtSucursal.Text = "";
            txtCliente.Text = "";
            DgvDetalleFact.Rows.Clear();
            pedidos.Clear();
            posindexp = 0;
            indezp.Clear();
            lblUsuario.Text = "";
            txtTotalDevolucion.Text = "0.00";
            txtTotalFactura.Text = "0.00";
            for (int i = 0; i < 21; i++)
            {
                DgvDetalleFact.Rows.Add("");
            }
            txtSucursal.Focus();
        }

        private void limpiarDGV()
        {
            DgvDetalleFact.Rows.Clear();
            for (int i = 0; i < 21; i++)
            {
                DgvDetalleFact.Rows.Add("");
            }
        }

        private int posicion = 0;
        private bool verificarNull()
        {
            bool verificarnull = false;
            for (int i = 0; i < DgvDetalleFact.RowCount; i++)
            {
                if (DgvDetalleFact.Rows[i].Cells[0].Value!=null && DgvDetalleFact.Rows[i].Cells[1].Value!=null)
                {
                    if (Convert.ToBoolean(DgvDetalleFact.Rows[i].Cells[7].Value))
                    {
                        if (DgvDetalleFact.Rows[i].Cells[6].Value==null)
                        {
                            posicion = i;
                            verificarnull = true;
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
                
            }
            return verificarnull;
        }

        private bool verificarLimites()
        {
            bool limite = false;
            for (int i = 0; i < DgvDetalleFact.RowCount; i++)
            {
                if (DgvDetalleFact.Rows[i].Cells[0].Value != null && DgvDetalleFact.Rows[i].Cells[1].Value != null)
                {
                    if (Convert.ToBoolean(DgvDetalleFact.Rows[i].Cells[7].Value))
                    {
                        if (Convert.ToInt32(DgvDetalleFact.Rows[i].Cells[6].Value)> Convert.ToInt32(DgvDetalleFact.Rows[i].Cells[2].Value))
                        {
                            posicion = i;
                            limite = true;
                            break;
                        }
                       
                        //verificarnull = true;
                        
                    }
                }
                else
                {
                    break;
                }
            }
            return limite;
        }

        private void DgvDetalleFact_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDetalleFact.CurrentCell==this.DgvDetalleFact.Rows[e.RowIndex].Cells[6])
            {
                CalcularDevolucion();
            }
        }
        EncabezadoNotaDebito objEND;
        DetalleNotaDebito objDND;
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                pedidos.Clear();
                ObtenerPedidos();
                
                if (indezp.Count > 0)
                {
                    //if (!verificarNull())
                    //{
                        if (!verificarLimites())
                        {
                            if (MessageBox.Show("¿Estas seguro de darle de baja a estos Items?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                            
                                bool b = c.DevolucionVenta(pedidos, Convert.ToInt32(txtNumFact.Text));
                                if (b)
                                {
                                    
                                    string idEncabezado = c.ObtenerValorCampo("IDFACTURA", "TbEncabezadoFactura", "where SUCURSAL = "+ Convert.ToInt32(txtSucursal.Text) + " AND CAJA = " + Convert.ToInt32(txtCaja.Text) + " and NFACTURA =" + Convert.ToInt32(txtNumFact.Text) + "");
                                    objEND = new EncabezadoNotaDebito(txtSerie1ND.Text, txtSerie2ND.Text, txtNumeroND.Text, Convert.ToInt32(idEncabezado), Convert.ToSingle(txtTotalDevolucion.Text));
                                    string resultado = objEND.InsertarEncabezadoND(objEND);
                                    if (resultado == "Datos Guardados") {
                                        string encabezadoND = c.ObtenerValorCampo("IDENCABEZADONOTADEBITO", "TbEncabezadoNotaDebito", "WHERE IDENCABEZADOVENTA =" + idEncabezado);
                                        bool banderaCorrecto = false;
                                        for (int i = 0; i < DgvDetalleFact.RowCount - 1; i++)
                                        {
                                            if (Convert.ToString(DgvDetalleFact.Rows[i].Cells[6].Value) != "")
                                            {
                                                objDND = new DetalleNotaDebito(Convert.ToInt32(encabezadoND), Convert.ToInt32(DgvDetalleFact.Rows[i].Cells[6].Value), Convert.ToString(DgvDetalleFact.Rows[i].Cells[0].Value));
                                                string resultado2 = objDND.InsertarDetalleND(objDND);
                                                if (resultado == "Datos Guardados")
                                                    banderaCorrecto = true;
                                                else
                                                    banderaCorrecto = false;
                                            }
                                            if (Convert.ToString(DgvDetalleFact.Rows[i + 1].Cells[0].Value) == "")
                                                break;
                                            
                                        }
                                        if (banderaCorrecto)
                                        {
                                            MessageBox.Show("Cambios realizados con exito.");
                                            string numeroND = (Convert.ToInt32(txtNumeroND.Text) + 1).ToString("D9");
                                            c.EjecutarSQL("UPDATE [dbo].[TbCajasTalonario] SET [DOCUMENTOACTUAL] = '" + numeroND + "' WHERE SERIE1 = '" + txtSerie1ND.Text + "' and SERIE2 = '" + txtSerie2ND.Text + "' and IPESTACION = '" + bitacora.LocalIPAddress() + "' and TIPODOCUMENTO = 'NDEB'");
                                        c.seriesDocumentoRetencion(txtNumeroND, txtSerie1ND, txtSerie2ND, txtAutorizacionND, "NDEB", bitacora.LocalIPAddress());
                                    }
                                        else 
                                        {
                                            MessageBox.Show("Error al guardar la Nota de Crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            c.EjecutarSQL("DELETE FROM [dbo].[TbDetalleNotaDebito] WHERE IDENCABEZADONOTADEBITO = " + encabezadoND + "");
                                            c.EjecutarSQL("DELETE FROM [dbo].[TbEncabezadoNotaDebito] WHERE IDENCABEZADOVENTA = " + idEncabezado + "");                                            
                                        }

                                    }
                                    else if (resultado == "Error al Registrar")
                                    {
                                        MessageBox.Show("Error al guardar la Nota de Crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        c.EjecutarSQL("DELETE FROM [dbo].[TbEncabezadoNotaDebito] WHERE IDENCABEZADOVENTA = " + idEncabezado + "");
                                    }
                                    else if (resultado == "Existe")
                                        MessageBox.Show("Ya existe la Nota de Crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    LimpiarTodo();
                                }
                                else
                                {
                                    MessageBox.Show("Error al realizar devolucion.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hay una cantidad que sobrepasa a la cantidad vendida.\nFila: " + posicion + 1);
                            DgvDetalleFact.CurrentCell = DgvDetalleFact.Rows[posicion].Cells[6];
                            //DgvDetalleFact.BeginEdit(true);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay un producto seleccionado sin cantidad.\nPor favor ingresa la cantidad. Fila: " + posicion + 1);
                        DgvDetalleFact.CurrentCell = DgvDetalleFact.Rows[posicion].Cells[6];
                        DgvDetalleFact.BeginEdit(true);
                }
                //}
                //else
                //{
                //    MessageBox.Show("Selecciona al menos un Item.");
                //}

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            c.seriesDocumentoRetencion(txtNumeroND, txtSerie1ND, txtSerie2ND, txtAutorizacionND, "NDEB", bitacora.LocalIPAddress());
            LimpiarTodo();
        }

        private void FrmDevolucionVenta_Load(object sender, EventArgs e)
        {
            
        }

        private void DgvDetalleFact_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbersdgvcheque_KeyPress;
            }
        }
        private void OnlyNumbersdgvcheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DgvDetalleFact.CurrentCell == DgvDetalleFact.CurrentRow.Cells[6])
            {
                Funcion.Validar_Numeros(e);
            }
        }

        private void btnSalirCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
