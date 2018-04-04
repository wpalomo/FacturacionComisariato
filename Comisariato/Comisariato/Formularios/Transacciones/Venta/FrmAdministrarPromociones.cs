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

namespace Comisariato.Formularios.Transacciones.Venta
{
    public partial class FrmAdministrarPromociones : Form
    {
        public FrmAdministrarPromociones()
        {
            InitializeComponent();
        }

        bool bandera_Estado = false;
        Consultas Objconsul = new Consultas();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtMontoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, TxtMontoInicial.Text);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtMontoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, TxtMontoFinal.Text);
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtMontoInicial_Enter(object sender, EventArgs e)
        {
            TxtMontoInicial.SelectAll();
        }

        private void TxtMontoFinal_Enter(object sender, EventArgs e)
        {
            TxtMontoFinal.SelectAll();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (BtnLimpiar.Text == "&Cancelar")
            {
                inicializarDatos();
                BtnLimpiar.Text = "&Limpiar";
                BtnGuardar.Text = "&Guardar";
                IDPromocionDatagirdSelect = "";
            }
            else { inicializarDatos(); IDPromocionDatagirdSelect = ""; }
            bandera_Estado = false;
        }

        public void inicializarDatos()
        {

            Funcion.Limpiarobjetos(GrbDatosPromocion);
            Funcion.Limpiarobjetos(GrbDatosTicket);
            TxtMontoFinal.Text = "0.00";
            TxtMontoInicial.Text = "0.00";
            NudNumTickets.Value = 0;
            CmbTipoPromocion.SelectedIndex = 0;
            bandera_Estado = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCabecera.Text != "" && TxtLinea1.Text != "" && TxtLinea2.Text != "" && TxtLinea3.Text != "" && TxtLinea4.Text != "" && TxtLinea5.Text != "" && TxtMontoInicial.Text != "0.00" && TxtMontoFinal.Text != "0.00")
                {
                    Promocion ObjPromocion = new Promocion(Funcion.FormarFecha(DtpFechaInicio.Value.ToShortDateString()), Funcion.FormarFecha(DtpFechaFin.Value.ToShortDateString()),
                        Funcion.FormarFecha(DtpFechaVencimientoCupon.Value.ToShortDateString()), TxtCabecera.Text, TxtLinea1.Text, TxtLinea2.Text, TxtLinea3.Text, TxtLinea4.Text,
                        TxtLinea5.Text, CmbTipoPromocion.Text, true, Convert.ToInt32(NudNumTickets.Value), Convert.ToDouble(Funcion.reemplazarcaracterViceversa(TxtMontoInicial.Text)), Convert.ToDouble(Funcion.reemplazarcaracterViceversa(TxtMontoFinal.Text)));

                    if (!bandera_Estado) // Para identificar si se va ingresar
                    {
                        String resultado = ObjPromocion.InsertarPromocion();
                        if (resultado == "Datos Guardados")
                        {
                            MessageBox.Show(CmbTipoPromocion.Text + " Registrada Correctamente ", "Exito", MessageBoxButtons.OK);
                            inicializarDatos();
                        }
                        else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        else if (resultado == "Existe") { MessageBox.Show("Ya Existe esta Promoción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    else if (bandera_Estado) // Para identificar si se va modificar
                    {

                        String Resultado = ObjPromocion.ModificarPromocion(TxtIdPromocion.Text); // retorna true si esta correcto todo
                        if (Resultado == "Correcto")
                        {
                            MessageBox.Show("Promoción Actualizada", "Exito");
                            IDPromocionDatagirdSelect = "";
                            inicializarDatos();
                        }
                        else { MessageBox.Show("Error al actualizar Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        inicializarDatos();
                        bandera_Estado = false;
                        BtnGuardar.Text = "&Guardar";
                        BtnLimpiar.Text = "&Limpiar";
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese todos los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Resultado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAdministrarPromociones_Load(object sender, EventArgs e)
        {
            inicializarDatos();
        }

        private void NudNumTickets_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtCabecera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Objconsul.boolLlenarDataGridView(DgvPromociones, "Select IDPROMOCION, FECHAINICIO as 'F. Incial',FECHAFIN as 'F. Final',FECHAVENCIMIENTOCUPON as 'F. Vencimiento', CAST(ROUND(MONTOINCIAL, 2) AS NUMERIC(12,2)) as 'Monto Inicial',CAST(ROUND(MONTOFINAL, 2) AS NUMERIC(12,2)) as 'Monto Final',NUMEROTICKETS as 'Número de Ticket', CABECERATICKET as 'Nombre', TIPOPROMOCION as 'Tipo' from TbPromociones where   [ESTADO] = 1 and FECHAINICIO BETWEEN '" + dtpDesde.Value.ToShortDateString()+"' and '"+dtpHasta.Value.ToShortDateString() + "' ;");
            if (rbtActivos.Checked)
            {
                cargarDatos("1");
            }
            else if (rbtInactivos.Checked)
            {
                cargarDatos("0");
            }
            DgvPromociones.Columns["IDPROMOCION"].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvPromociones.Rows.Count > 0)
                {
                    if (IDPromocionDatagirdSelect != "")
                    {
                        BtnGuardar.Text = "&Modificar";
                        BtnLimpiar.Text = "&Cancelar";
                        tabControlPromociones.SelectedIndex = 0;
                        bandera_Estado = true;

                        DataTable datospromocion = Objconsul.BoolDataTable("Select IDPROMOCION,FECHAINICIO,FECHAFIN,FECHAVENCIMIENTOCUPON, CAST(ROUND(MONTOINCIAL, 2) AS NUMERIC(12,2)) as 'MONTOINCIAL',CAST(ROUND(MONTOFINAL, 2) AS NUMERIC(12,2)) as 'MONTOFINAL',NUMEROTICKETS, CABECERATICKET, TIPOPROMOCION, LINEA1,LINEA2,LINEA3,LINEA4,LINEA5 from TbPromociones  where IDPROMOCION = " + IDPromocionDatagirdSelect);
                        if (datospromocion.Rows.Count > 0)
                        {
                            DataRow myRow = datospromocion.Rows[0];

                            DtpFechaInicio.Value = Convert.ToDateTime(myRow["FECHAINICIO"]);
                            DtpFechaFin.Value = Convert.ToDateTime(myRow["FECHAFIN"]);
                            DtpFechaVencimientoCupon.Value = Convert.ToDateTime(myRow["FECHAVENCIMIENTOCUPON"]);
                            NudNumTickets.Value = Convert.ToInt32(myRow["NUMEROTICKETS"]);
                            TxtMontoInicial.Text = myRow["MONTOINCIAL"].ToString();
                            TxtMontoFinal.Text = myRow["MONTOFINAL"].ToString();
                            TxtLinea1.Text = myRow["LINEA1"].ToString();
                            TxtLinea2.Text = myRow["LINEA2"].ToString();
                            TxtLinea3.Text = myRow["LINEA3"].ToString();
                            TxtLinea4.Text = myRow["LINEA4"].ToString();
                            TxtLinea5.Text = myRow["LINEA5"].ToString();
                            CmbTipoPromocion.SelectedItem = myRow["TIPOPROMOCION"].ToString();
                            TxtCabecera.Text = myRow["CABECERATICKET"].ToString();
                            TxtIdPromocion.Text = myRow["IDPROMOCION"].ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        string IDPromocionDatagirdSelect = "";
        private void DgvPromociones_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            IDPromocionDatagirdSelect = DgvPromociones.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {

        }

        private void txtConsultarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConsultarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnActivarDescativar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvPromociones.Rows.Count > 0 && IDPromocionDatagirdSelect != "")
                {
                    Promocion ObjPromocion = new Promocion();
                    if (btnActivarDescativar.Text == "Activar")
                    {
                        ObjPromocion.EstadoPromocion(DgvPromociones.CurrentRow.Cells[7].Value.ToString(), 1);
                        if (rbtActivos.Checked)
                        {
                            cargarDatos("1");
                        }
                        else if (rbtInactivos.Checked)
                        {
                            cargarDatos("0");
                        }
                    }
                    else if (btnActivarDescativar.Text == "Desactivar")
                    {
                        ObjPromocion.EstadoPromocion(DgvPromociones.CurrentRow.Cells[7].Value.ToString(), 2);
                        if (rbtActivos.Checked)
                        {
                            cargarDatos("1");
                        }
                        else if (rbtInactivos.Checked)
                        {
                            cargarDatos("0");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Resultado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtActivos.Checked)
            {
                btnActivarDescativar.Text = "Desactivar";
            }
            else if (rbtInactivos.Checked)
            {
                btnActivarDescativar.Text = "Activar";
            }
        }


        private void cargarDatos(string condicion)
        {
            string consulta = "Select IDPROMOCION, FECHAINICIO as 'F. Incial',FECHAFIN as 'F. Final',FECHAVENCIMIENTOCUPON as 'F. Vencimiento', CAST(ROUND(MONTOINCIAL, 2) AS NUMERIC(12,2)) as 'Monto Inicial',CAST(ROUND(MONTOFINAL, 2) AS NUMERIC(12,2)) as 'Monto Final',NUMEROTICKETS as 'Número de Ticket', CABECERATICKET as 'Nombre', TIPOPROMOCION as 'Tipo' from TbPromociones where   [ESTADO] =" + condicion + " and FECHAINICIO BETWEEN '" + dtpDesde.Value.ToShortDateString() + "' and '" + dtpHasta.Value.ToShortDateString() + "'  ;";
            Objconsul.boolLlenarDataGridView(DgvPromociones, consulta);
            //dgvDatosCliente.Columns["ID"].Visible = false;
            //consultas.boolLlenarDataGrid(dgvDatosCliente, consulta, 15, 7, 2);
            //for (int i = 0; i < dgvDatosCliente.RowCount; i++)
            //    if (Convert.ToString(dgvDatosCliente.Rows[i].Cells[2].Value) == "")
            //        dgvDatosCliente.Rows[i].ReadOnly = true;
        }


    }
}
