using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Comisariato.Formularios.Transacciones.Venta
{
    public partial class FrmConsultarPrecios : Form
    {
        internal static List<string> DatosProducto = new List<string>();

        public FrmConsultarPrecios()
        {
            InitializeComponent();
        }
        private void btnSalirCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        Consultas Objconsul = new Consultas();
                        DataTable dt = Objconsul.BoolDataTable("Select PRECIOPUBLICO_IVA,PRECIOALMAYOR_IVA,PRECIOPORCAJA_IVA, PRECIOPUBLICO_SIN_IVA,PRECIOALMAYOR_SIN_IVA,PRECIOPORCAJA_SIN_IVA, IVAESTADO from TbProducto where CODIGOBARRA = '" + txtCodigo.Text + "'");
                        if (dt.Rows.Count > 0)
                        {
                            DataRow myRow = dt.Rows[0];
                            if (Convert.ToBoolean(myRow["IVAESTADO"]))
                            {
                                if (myRow["PRECIOPUBLICO_IVA"] != System.DBNull.Value)
                                    TxtPrecioPVP.Text = (Convert.ToDouble(myRow["PRECIOPUBLICO_IVA"].ToString())).ToString("#####0.00");
                                if (myRow["PRECIOALMAYOR_IVA"] != System.DBNull.Value)
                                    TxtPrecioMayorista.Text = (Convert.ToDouble(myRow["PRECIOALMAYOR_IVA"].ToString())).ToString("#####0.00");
                                if (myRow["PRECIOPORCAJA_IVA"] != System.DBNull.Value)
                                    TxtPrecioCaja.Text = (Convert.ToDouble(myRow["PRECIOPORCAJA_IVA"].ToString())).ToString("#####0.00");
                            }
                            else
                            {
                                if (myRow["PRECIOPUBLICO_SIN_IVA"] != System.DBNull.Value)
                                    TxtPrecioPVP.Text = (Convert.ToDouble(myRow["PRECIOPUBLICO_SIN_IVA"].ToString())).ToString("#####0.00");
                                if (myRow["PRECIOALMAYOR_SIN_IVA"] != System.DBNull.Value)
                                    TxtPrecioMayorista.Text = (Convert.ToDouble(myRow["PRECIOALMAYOR_SIN_IVA"].ToString())).ToString("#####0.00");
                                if (myRow["PRECIOPORCAJA_SIN_IVA"] != System.DBNull.Value)
                                    TxtPrecioCaja.Text = (Convert.ToDouble(myRow["PRECIOPORCAJA_SIN_IVA"].ToString())).ToString("#####0.00");
                            }
                        }
                        txtCodigo.SelectAll();
                    }
                    catch (Exception) {}
                }
            }
        }
        private void FrmConsultarPrecios_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();

        }
        private void FrmConsultarPrecios_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F6:
                    Program.banderaProductosConsultarPrecio = true;
                    FrmConsultarProducto FrmConsultarProduct = new FrmConsultarProducto();
                    FrmConsultarProduct.ShowDialog();
                    if (DatosProducto.Count > 0)
                    {
                        txtCodigo.Text =  DatosProducto[0].ToString();
                        if (DatosProducto.Count > 0)
                        {
                            DatosProducto.Clear();
                            Program.banderaProductosConsultarPrecio = false;
                        }
                        SendKeys.Send("{ENTER}");
                    }
                    else
                        txtCodigo.Focus();
                    break;
            }
        }
        private void FrmConsultarPrecios_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose(true);
        }
    }
}