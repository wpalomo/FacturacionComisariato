using Comisariato.Clases;
using System;
using System.Windows.Forms;

namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmFacturaGastos : Form
    {
        Consultas consultas = new Consultas();
        int ordenCompra = 0, idOrdenGasto;
        FacturaGastos objFactura;
        EmcabezadoCompra objEncabezado;
        public static int IDEncabezadoGasto = 0;
        public static string IVA = "";
        public static bool gasto = false;

        public FrmFacturaGastos()
        {
            InitializeComponent();
        }
        public void inicializar()
        {
            Funcion.Limpiarobjetos(gbEncabezadoCompra);
            txtIVA.Text = "0.00";
            txtSubtotal0.Text = "0.00";
            txtSubtutalIVA.Text = "0.00";
            txtTotal.Text = "0.00";
            txtDesceunto.Text = "0.00";
            consultas.BoolLlenarComboBox(cbCuentaContableProveedor, "Select IDPLANCUENTA as ID ,'[' +CUENTA +']' + ' - ' + DESCRIPCIONCUENTA AS Texto FROM dbo.TbPlanCuenta ");
            consultas.BoolLlenarComboBox(cbSucursal, "select IDSUCURSAL AS Id, NOMBRESUCURSAL as Texto from TbSucursal");
            consultas.BoolLlenarComboBox(cbProveedor, "select IDPROVEEDOR AS Id, NOMBRES AS Texto from TbProveedor");
            consultas.BoolLlenarComboBox(cbImpuesto, "select IDIVA AS ID, IVA + '%' as TEXTO from tbIva");
            idOrdenGasto = consultas.ObtenerID("IDFACTURAGASTOS", "TbGastos", "");
            ordenCompra = 1 + idOrdenGasto;
            txtOrdenCompra.Text = Convert.ToString(ordenCompra);
        }
        private void FrmFacturaGastos_Load(object sender, EventArgs e)
        {
            inicializar();
        }
        private void btnSalirCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtSerie1.Text != "" && txtSerie2.Text != "" && txtNumero.Text != "")
            {
                if (MessageBox.Show("¿Desea guardar la compra?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objFactura = new FacturaGastos(Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToInt32(cbImpuesto.SelectedValue), Convert.ToInt32(cbProveedor.SelectedValue), Convert.ToInt32(cbCuentaContableProveedor.SelectedValue), txtObservacion.Text, txtSerie1.Text,
                        txtSerie2.Text, txtNumero.Text, Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtSubtotal0.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtSubtutalIVA.Text)),
                        Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtDesceunto.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtIVA.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotal.Text)), dtpFechaOC.Value);
                    String resultado = objFactura.InsertarFacturaGasto(objFactura);
                    if (resultado == "Datos Guardados")
                    {
                        MessageBox.Show("Registrada Correctamente ", "Exito", MessageBoxButtons.OK);
                        if (MessageBox.Show("¿Desea ingresar la orden de giro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Program.FormularioLlamado = true;
                            IVA = cbImpuesto.Text;
                            string condicion = "where SERIE1 = " + Convert.ToInt32(txtSerie1.Text) + " AND SERIE2 = " + Convert.ToInt32(txtSerie2.Text) + " AND NUMERO = " + Convert.ToInt32(txtNumero.Text) + " AND IDPROVEEDOR = " + Convert.ToInt32(cbProveedor.SelectedValue);                            
                            string ordenCompra = (consultas.ObtenerID("IDEMCABEZADOCOMPRA", "TbEncabezadoyPieCompra", "") + 1).ToString();
                            objEncabezado = new EmcabezadoCompra(txtSerie1.Text, txtSerie2.Text, txtNumero.Text, Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtSubtutalIVA.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtSubtotal0.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtSubtutalIVA.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtSubtotal0.Text)), Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotal.Text)), ordenCompra, Convert.ToInt32(cbSucursal.SelectedValue), 0.00f, dtpFechaOC.Value, Convert.ToInt32(cbProveedor.SelectedValue), "", "", cbImpuesto.SelectedText, txtObservacion.Text, Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtIVA.Text)), 0.00f, 0.00f, "Gastos");
                            string resultadoCompra = objEncabezado.InsertarEncabezadoyPieCompra(objEncabezado);
                            if (resultadoCompra == "Datos Guardados")
                            {
                                gasto = true;
                                IDEncabezadoGasto = Convert.ToInt32(ordenCompra);
                                if (FrmPrincipal.FrmOrdenDeGiro == null || FrmPrincipal.FrmOrdenDeGiro.IsDisposed)
                                {
                                    FrmPrincipal.FrmOrdenDeGiro = new FrmOrdenDeGiro();
                                    FrmPrincipal.FrmOrdenDeGiro.MdiParent = Program.panelPrincipalVariable;
                                    FrmPrincipal.FrmOrdenDeGiro.BringToFront();
                                    FrmPrincipal.FrmOrdenDeGiro.Show();
                                }
                                else
                                {
                                    FrmPrincipal.FrmOrdenDeGiro.Close();
                                    if (FrmPrincipal.FrmOrdenDeGiro == null || FrmPrincipal.FrmOrdenDeGiro.IsDisposed)
                                    {
                                        FrmPrincipal.FrmOrdenDeGiro = new FrmOrdenDeGiro();
                                        FrmPrincipal.FrmOrdenDeGiro.MdiParent = Program.panelPrincipalVariable;
                                        FrmPrincipal.FrmOrdenDeGiro.BringToFront();
                                        FrmPrincipal.FrmOrdenDeGiro.Show();
                                    }
                                }
                                inicializar();
                            }
                        }
                        else
                            inicializar();
                    }
                    else if (resultado == "Error al Registrar")
                        MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (resultado == "Existe")
                        MessageBox.Show("Ya Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Ingrese todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void txtSubtutalIVA_Leave(object sender, EventArgs e)
        {
            txtIVA.Text = Funcion.reemplazarcaracter((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtSubtutalIVA.Text)) * 0.12).ToString("#0.######"));
            txtTotal.Text = Funcion.reemplazarcaracter(Convert.ToString((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtSubtotal0.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtSubtutalIVA.Text)) + 
                Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtIVA.Text))) - Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtDesceunto.Text))));            
        }
        private void txtSubtutalIVA_Enter(object sender, EventArgs e)
        {
            txtSubtutalIVA.SelectAll();
        }
        private void txtSubtotal0_Enter(object sender, EventArgs e)
        {
            txtSubtotal0.SelectAll();
        }
        private void txtDesceunto_Enter(object sender, EventArgs e)
        {
            txtDesceunto.SelectAll();
        }
        private void txtIVA_Enter(object sender, EventArgs e)
        {
            txtIVA.SelectAll();
        }
        private void txtSubtutalIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtSubtutalIVA.Text);
        }
        private void txtDesceunto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtDesceunto.Text);
        }
        private void txtSubtotal0_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, txtSubtotal0.Text);
        }
        private void txtSerie1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void txtObservacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                txtSubtutalIVA.Focus();
            }
        }
        private void txtDesceunto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                BtnGuardar.Focus();
            }
        }
        private void btnProveedor_Click(object sender, EventArgs e)
        {
            consultas.BoolLlenarComboBox(cbProveedor, "select IDPROVEEDOR AS Id, NOMBRES AS Texto from TbProveedor");
            Program.FormularioLlamado = true;
            if (FrmPrincipal.FrmProveedor == null || FrmPrincipal.FrmProveedor.IsDisposed)
            {
                FrmPrincipal.FrmProveedor = new FrmProveedores();
                FrmPrincipal.FrmProveedor.MdiParent = Program.panelPrincipalVariable;
                FrmPrincipal.FrmProveedor.BringToFront();
                FrmPrincipal.FrmProveedor.Show();
            }
            else { FrmPrincipal.FrmProveedor.BringToFront(); }
        }
    }
}
