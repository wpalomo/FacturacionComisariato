using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Transacciones.Venta
{
    public partial class FrmCierreCaja : Form
    {
        public FrmCierreCaja()
        {
            InitializeComponent();
        }

        float monedasTotal = 0.0f, totalCheque = 0.0f, totalRecaudado = 0.0f;
        int billetesTotal = 0;
        Consultas objConsulta = new Consultas();
        private void txtBillestes1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            string sqlInsert = " INSERT INTO[dbo].[TbCierreCaja]([TOTALBILLETES],[TOTALMONEDAS],[TOTALCHEQUES],[TOTALAVANCES],[TOTALRECAUDADO],[TOTALENTREGADO],[FECHA],[IDUSUARIO],[CAJA])" +
                                          " VALUES(" + Funcion.reemplazarcaracter(billetesTotal.ToString()) + ", "+ Funcion.reemplazarcaracter(monedasTotal.ToString()) + ","+ Funcion.reemplazarcaracter(totalCheque.ToString()) + ","+ Funcion.reemplazarcaracter(txtAvances.Text.ToString()) + ","+ Funcion.reemplazarcaracter(totalRecaudado.ToString()) + ",0,'"+ Funcion.reemplazarcaracterFecha(DateTime.Now.Date.ToShortDateString()) +"', "+ Program.IDUsuarioMenu +", "+ Program.NumeroCaja+")";
            bool correcto = objConsulta.EjecutarSQL(sqlInsert);
            if (correcto)
            { 
                MessageBox.Show("Registrado Correctamente");
                Imprimir();
                inicializar();
                Program.arqueo = true;
                FrmClaveUsuario.f.Close();
            }
            else
                MessageBox.Show("Error al Registrar");
        }

        private void Imprimir()
        {
            CrearTicket ticket = new CrearTicket();
            //int maximoCaracteres = 40;
            string espacios = "";
            string cajaImprimir = "CAJA #" + Program.NumeroCaja;
            string fecha = DateTime.Now.Date.ToString();
            string cantidadAvance = txtCantidadAvances.Text;
            string avances = Funcion.reemplazarcaracterViceversa(txtAvances.Text);
            string efectivo = Convert.ToString(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalBillestes.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalMonedas.Text)));
            string cheques = Funcion.reemplazarcaracterViceversa(txtTotalCheque.Text);
            string Empresa = objConsulta.ObtenerValorCampo("NOMBRE", "TbEmpresa", "where IDEMPRESA = " + Program.IDEMPRESA);
            ticket.TextoCentro(Empresa);
            ticket.TextoIzquierda("     ");
            ticket.TextoCentro("ARQUEO DE CAJA");
            ticket.TextoIzquierda("         ");
            ticket.TextoCentro(cajaImprimir);
            ticket.TextoCentro(Program.Usuario);
            ticket.TextoIzquierda("         ");
            ticket.TextoCentro(fecha);
            ticket.lineasAsteriscos();
            ticket.TextoExtremos(cantidadAvance + " Avances: ", "$" + Funcion.reemplazarcaracter(avances));
            ticket.lineasAsteriscos();
            ticket.TextoExtremos("Cheques: ", "$" + Funcion.reemplazarcaracter(cheques));
            ticket.lineasAsteriscos();
            ticket.TextoExtremos("Efectivo: ", "$" + Funcion.reemplazarcaracter(efectivo));
            ticket.lineasAsteriscos();
            ticket.TextoExtremos("V.Entregado: ", "$" + Funcion.reemplazarcaracter(Convert.ToString(Convert.ToSingle(efectivo) + Convert.ToSingle(cheques) + Convert.ToSingle(avances))));
            ticket.lineasAsteriscos();

            //}
            ticket.CortaTicket();

            //String ruta = @"\\AIRCONTROL\BodegaPedido";
            //ticket.ImprimirTicket(ruta);
            var valor = ConfigurationManager.AppSettings["Local"];
            ticket.ImprimirTicket(valor);//Nombre de la impresora ticketera
        }

        private void txtBillestes1_Enter(object sender, EventArgs e)
        {
            txtBillestes1.SelectAll();
            txtBillestes1.Focus();
        }        

        private void btnSalirCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCierreCaja_Load(object sender, EventArgs e)
        {
            string sqlCheque = "select * from VistaChequesCierreCaja where IDUSUARIO = "+ Program.IDUsuarioMenu +" AND FECHA = '"+ Funcion.reemplazarcaracterFecha(Convert.ToString(DateTime.Now.Date.ToShortDateString())) +"' and CAJA = " + Program.NumeroCaja + "";
            objConsulta.boolLlenarDataGrid(dgvCheque, sqlCheque, 4, 3, 0);
            for (int i = 0; i < dgvCheque.RowCount - 1; i++)
            {
                totalCheque = totalCheque + Convert.ToSingle(dgvCheque.Rows[i].Cells[3].Value);
                if (Convert.ToString(dgvCheque.Rows[i + 1].Cells[0].Value) == "")

                    break;
            }
            txtTotalCheque.Text = Funcion.reemplazarcaracter(totalCheque.ToString());
            string sqlAvance = "select COUNT(a.CANTIDAD) AS CATIDADADELANTO, sum(a.CANTIDAD) AS CANTIDADTOTAL from TbAvance a, TbUsuario u " +
" where a.IDEMPLEADO = u.IDEMPLEADO and u.IDUSUARIO = "+ Program.IDUsuarioMenu +"  and a.CAJA = "+ Program.NumeroCaja + " and a.FECHA = '"+ Funcion.reemplazarcaracterFecha(Convert.ToString(DateTime.Now.Date.ToShortDateString())) + "'";
            DataTable dt = objConsulta.BoolDataTable(sqlAvance);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtCantidadAvances.Text = row[0].ToString();
                if (row[1].ToString() != "")
                {
                    txtAvances.Text = Funcion.reemplazarcaracter(row[1].ToString());
                }
                else
                    txtAvances.Text = "0.00";


            }
        }

        public void calcularBilletes()
        {
            billetesTotal = (Convert.ToInt32(txtBillestes1.Text) * 1) + (Convert.ToInt32(txtBillestes5.Text) * 5) + (Convert.ToInt32(txtBillestes10.Text) * 10) + (Convert.ToInt32(txtBillestes20.Text) * 20) + (Convert.ToInt32(txtBillestes50.Text) * 50) + (Convert.ToInt32(txtBillestes100.Text) * 100);
            txtTotalBillestes.Text = Funcion.reemplazarcaracter(billetesTotal.ToString());
            txtTotalRecaudado.Text = Funcion.reemplazarcaracter((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalBillestes.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalMonedas.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalCheque.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtAvances.Text))).ToString());
            totalRecaudado = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalRecaudado.Text));
        }
        public void calcularMonedas()
        {
            monedasTotal = ((Convert.ToSingle(txtMonedas1.Text) * 1) / 100) + ((Convert.ToSingle(txtMonedas5.Text) * 5) / 100) + ((Convert.ToSingle(txtMonedas10.Text) * 10) / 100) + ((Convert.ToSingle(txtMonedas25.Text) * 25) / 100) + ((Convert.ToSingle(txtMonedas50.Text) * 50) / 100);
            monedasTotal = monedasTotal + Convert.ToSingle(txtMonedas1Dolar.Text);
            txtTotalMonedas.Text = Funcion.reemplazarcaracter(monedasTotal.ToString());
            txtTotalRecaudado.Text = Funcion.reemplazarcaracter((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalBillestes.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalMonedas.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalCheque.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtAvances.Text))).ToString());
            totalRecaudado = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalRecaudado.Text));
        }

        public void inicializar()
        {
            Funcion.Limpiarobjetos(gbEfectivo);
            dgvCheque.Rows.Clear();
            for (int i = 0; i < 4; i++)
            {
                dgvCheque.Rows.Add();
            }
            Funcion.Limpiarobjetos(gbAvance);
            txtAvances.Text = "0.00";
            txtTotalBillestes.Text = "0.00";
            txtTotalCheque.Text = "0.00";
            txtTotalMonedas.Text = "0.00";
            txtTotalRecaudado.Text = "0.00";
            txtMonedas1.Text = "0";
            txtMonedas5.Text = "0";
            txtMonedas10.Text = "0";
            txtMonedas25.Text = "0";
            txtMonedas50.Text = "0";
            txtMonedas1Dolar.Text = "0";

            txtBillestes1.Text = "0";
            txtBillestes5.Text = "0";
            txtBillestes10.Text = "0";
            txtBillestes20.Text = "0";
            txtBillestes50.Text = "0";
            txtBillestes100.Text = "0";

            txtCantidadAvances.Text = "0";
        }

        private void txtBillestes5_Enter(object sender, EventArgs e)
        {
            txtBillestes5.SelectAll();
            txtBillestes5.Focus();
        }

        private void txtBillestes10_Enter(object sender, EventArgs e)
        {
            txtBillestes10.SelectAll();
            txtBillestes10.Focus();
        }

        private void txtBillestes20_Enter(object sender, EventArgs e)
        {
            txtBillestes20.SelectAll();
            txtBillestes20.Focus();
        }

        private void txtBillestes50_Enter(object sender, EventArgs e)
        {
            txtBillestes50.SelectAll();
            txtBillestes50.Focus();
        }

        private void txtBillestes100_Enter(object sender, EventArgs e)
        {
            txtBillestes100.SelectAll();
            txtBillestes100.Focus();
        }

        private void txtMonedas1_Enter(object sender, EventArgs e)
        {
            txtMonedas1.SelectAll();
            txtMonedas1.Focus();
        }

        private void txtMonedas5_Enter(object sender, EventArgs e)
        {
            txtMonedas5.SelectAll();
            txtMonedas5.Focus();
        }

        private void txtMonedas10_Enter(object sender, EventArgs e)
        {
            txtMonedas10.SelectAll();
            txtMonedas10.Focus();
        }

        private void txtMonedas25_Enter(object sender, EventArgs e)
        {
            txtMonedas25.SelectAll();
            txtMonedas25.Focus();
        }        

        private void txtBillestes1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularBilletes();
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMonedas1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularMonedas();
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMonedas1Dolar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularMonedas();
                //txtTotalMonedas.Text = Funcion.reemplazarcaracter((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalMonedas.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtMonedas1Dolar.Text))).ToString());
                e.Handled = true;
                txtTotalRecaudado.Text = Funcion.reemplazarcaracter((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalBillestes.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalMonedas.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalCheque.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtAvances.Text))).ToString());
                totalRecaudado = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalRecaudado.Text));
                BtnGuardar.Focus();
            }
        }

        private void txtBillestes1_Click(object sender, EventArgs e)
        {
            txtBillestes1.SelectAll();
            txtBillestes1.Focus();
        }

        private void txtBillestes5_Click(object sender, EventArgs e)
        {
            txtBillestes5.SelectAll();
            txtBillestes5.Focus();
        }

        private void txtBillestes10_Click(object sender, EventArgs e)
        {
            txtBillestes10.SelectAll();
            txtBillestes10.Focus();
        }

        private void txtBillestes20_Click(object sender, EventArgs e)
        {
            txtBillestes20.SelectAll();
            txtBillestes20.Focus();
        }

        private void txtBillestes50_Click(object sender, EventArgs e)
        {
            txtBillestes50.SelectAll();
            txtBillestes50.Focus();
        }

        private void txtBillestes100_Click(object sender, EventArgs e)
        {
            txtBillestes100.SelectAll();
            txtBillestes100.Focus();
        }

        private void txtMonedas1_Click(object sender, EventArgs e)
        {
            txtMonedas1.SelectAll();
            txtMonedas1.Focus();
        }

        private void txtMonedas5_Click(object sender, EventArgs e)
        {
            txtMonedas5.SelectAll();
            txtMonedas5.Focus();
        }

        private void txtMonedas10_Click(object sender, EventArgs e)
        {
            txtMonedas10.SelectAll();
            txtMonedas10.Focus();
        }

        private void txtMonedas25_Click(object sender, EventArgs e)
        {
            txtMonedas25.SelectAll();
            txtMonedas25.Focus();
        }

        private void txtMonedas50_Click(object sender, EventArgs e)
        {
            txtMonedas50.SelectAll();
            txtMonedas50.Focus();
        }

        private void txtMonedas1Dolar_Click(object sender, EventArgs e)
        {
            txtMonedas1Dolar.SelectAll();
            txtMonedas1Dolar.Focus();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            inicializar();
        }

        private void txtMonedas1Dolar_Leave(object sender, EventArgs e)
        {
            calcularMonedas();
            //txtTotalMonedas.Text = Funcion.reemplazarcaracter((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalMonedas.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtMonedas1Dolar.Text))).ToString());
            //e.Handled = true;
            txtTotalRecaudado.Text = Funcion.reemplazarcaracter((Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalBillestes.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalMonedas.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalCheque.Text)) + Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtAvances.Text))).ToString());
            totalRecaudado = Convert.ToSingle(Funcion.reemplazarcaracterViceversa(txtTotalRecaudado.Text));
            BtnGuardar.Focus();
        }

        private void txtMonedas50_Enter(object sender, EventArgs e)
        {
            txtMonedas50.SelectAll();
            txtMonedas50.Focus();
        }

        private void txtMonedas1Dolar_Enter(object sender, EventArgs e)
        {
            txtMonedas1Dolar.SelectAll();
            txtMonedas1Dolar.Focus();            
        }
    }
}
