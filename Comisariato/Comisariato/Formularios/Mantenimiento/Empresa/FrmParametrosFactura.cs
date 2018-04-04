using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Mantenimiento.Empresa
{
    public partial class FrmParametrosFactura : Form
    {

        Consultas consultas = new Consultas();
        bool Estado_Existe = false;

        public FrmParametrosFactura()
        {
            InitializeComponent();
        }
        private void rbPreimpresa_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbPreimpresa.Checked == true)
            {
                gbAutorizadoImprimir.Visible = false;
                gbPreimpresa.Visible = true;
                BtnAgregarCertificado.Visible = false;
                LblEntidadCertificadora.Visible = false;
                LblUnidadCertificadora.Visible = false;
                LblEstadoCertificado.Visible = false;
                LblSujetoCertificado.Visible = false;
            }
        }
        private void rbAutorizadoImprimir_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbAutorizadoImprimir.Checked == true)
            {
                gbAutorizadoImprimir.Visible = true;
                gbPreimpresa.Visible = false;
                BtnAgregarCertificado.Visible = true;
                LblEntidadCertificadora.Visible = true;
                LblUnidadCertificadora.Visible = true;
                LblEstadoCertificado.Visible = true;
                LblSujetoCertificado.Visible = true;
            }
        }
        private void FrmParametrosFactura_Load(object sender, EventArgs e)
        {
            consultas.BoolLlenarComboBox(cbIVA, "select IDIVA as ID, IVA as Texto FROM [dbo].[TbIva]");


            //LLENAR LOS DATOS
            //Llenar el DataTable
            DataTable dt = consultas.BoolDataTable("Select * from View_ParametrosFactura where IDEMPRESA =" + Program.IDEMPRESA+";");
            //Verificar si tiene Datos
            if (dt.Rows.Count > 0)
            {
                Estado_Existe = true;
                btnGuardarEmpresa.Text = "Modificar";
                DataRow myRow = dt.Rows[0];
                ////Cargar los demas Datos
                txtMontoMinimoFacturaEmpresa.Text = myRow["MONTO_MINIMO_FACTURA"].ToString();
                cbIVA.SelectedItem = myRow["IVA"].ToString();
                ckbContribuyenteEspecial.Checked = Convert.ToBoolean(myRow["CONTRIBUYENTEESPECIAL"]);
                ckbObligadoContabilidad.Checked = Convert.ToBoolean(myRow["OBLIGADOLLEVARCONTABILIDAD"]);

                TxtPie1.Text = myRow["PIE1"].ToString();
                TxtPie2.Text = myRow["PIE2"].ToString();
                TxtPie3.Text = myRow["PIE3"].ToString();
                TxtPie4.Text = myRow["PIE4"].ToString();

                TxtAncho.Text = Funcion.reemplazarcaracter(myRow["ANCHO"].ToString());
                TxtLargo.Text = Funcion.reemplazarcaracter(myRow["LARGO"].ToString());
                TxtTamañoEncabezadoFact.Text = Funcion.reemplazarcaracter(myRow["TAMANOENCABEZADOFACTURA"].ToString());
                TxtTamañoPieFact.Text = Funcion.reemplazarcaracter(myRow["TAMANOPIEFACTURA"].ToString());
                TxtNumeroItemsFactura.Text = myRow["NUMEROITEMS"].ToString();

                rbAutorizadoImprimir.Checked = Convert.ToBoolean(myRow["AUTORIZADOIMPRIMIR"]);
                rbPreimpresa.Checked = Convert.ToBoolean(myRow["PREIMPRESA"]);
                txtNumeroResolucion.Text = myRow["NUMERORESOLUCION"].ToString();


                try
                {
                    DataTable dtFactElectCertificado = consultas.BoolDataTableFactElect("Select * from TbCertificado;");
                    if (dtFactElectCertificado.Rows.Count > 0)
                    {
                        DataRow Row = dtFactElectCertificado.Rows[0];
                        LblUnidadCertificadora.Text = Row["EntidadCertificadora"].ToString();
                        LblEstadoCertificado.Text = Row["Usuario"].ToString();
                    }
                }
                catch (Exception ex)
                {

                }
                
            }
            
        }

        private void cbIVA_Enter(object sender, EventArgs e)
        {
            consultas.BoolLlenarComboBox(cbIVA, "select IDIVA as ID, IVA as Texto FROM [dbo].[TbIva]");
        }
        Funcion objFuncion = new Funcion();
        private void btnRegistrarIVA_Click(object sender, EventArgs e)
        {
            FrmRegistrarIVA frmRegistrarIVA = new FrmRegistrarIVA();
            objFuncion.AddFormInPanel(frmRegistrarIVA/*, Program.panelPrincipalVariable*/);

            Program.FormularioLlamado = true;
            if (FrmPrincipal.FrmRegistrarIVA == null || FrmPrincipal.FrmRegistrarIVA.IsDisposed)
            {
                FrmPrincipal.FrmRegistrarIVA = new FrmRegistrarIVA();
                FrmPrincipal.FrmRegistrarIVA.MdiParent = Program.panelPrincipalVariable;
                FrmPrincipal.FrmRegistrarIVA.BringToFront();
                FrmPrincipal.FrmRegistrarIVA.Show();
            }
        }
        public void inicializarDatos()
        {

            Funcion.Limpiarobjetos(gbAutorizadoImprimir);
            Funcion.Limpiarobjetos(gbSRIEmpresa);
            if (cbIVA.Items.Count > 0)
            {
                cbIVA.SelectedIndex = 0;
            }
            ckbContribuyenteEspecial.Checked = false;
            ckbObligadoContabilidad.Checked = false;
            TxtAncho.Text = "";
            TxtLargo.Text = "";
            TxtNumeroItemsFactura.Text = "";
            TxtTamañoEncabezadoFact.Text = "";
            TxtTamañoPieFact.Text = "";
        }


        private void btnLimpiarEmpresa_Click(object sender, EventArgs e)
        {
            inicializarDatos();
        }

        private void btnGuardarEmpresa_Click(object sender, EventArgs e)
        {
            if (txtMontoMinimoFacturaEmpresa.Text!="" && cbIVA.SelectedIndex>=0 )
            {
                
                ParametrosFactura ObjParametrosFactura = new ParametrosFactura(txtMontoMinimoFacturaEmpresa.Text, Convert.ToInt32(cbIVA.Text), ckbContribuyenteEspecial.Checked, ckbObligadoContabilidad.Checked, TxtAncho.Text, TxtLargo.Text, Convert.ToInt32(TxtNumeroItemsFactura.Text), TxtPie1.Text, TxtPie2.Text, TxtPie3.Text, TxtPie4.Text, Convert.ToInt32(Program.IDEMPRESA),TxtTamañoEncabezadoFact.Text,TxtTamañoPieFact.Text,rbPreimpresa.Checked,rbAutorizadoImprimir.Checked,txtNumeroResolucion.Text);

                if (!Estado_Existe)
                {
                    String resultado = ObjParametrosFactura.InsertarParametrosFactura(); // retorna true si esta correcto todo
                    if (resultado == "Datos Guardados")
                    {
                        MessageBox.Show("Datos Registrado Correctamente ", "Exito", MessageBoxButtons.OK);
                        //rbtActivos.Checked = true;
                        inicializarDatos();
                        Estado_Existe = true;

                        if (rbAutorizadoImprimir.Checked)
                        {
                            Program.BoolPreimpresa = false;
                            Program.BoolAutorizadoImprimir = true;
                        }
                        if (rbPreimpresa.Checked)
                        {
                            Program.BoolPreimpresa = true;
                            Program.BoolAutorizadoImprimir = false;
                        }

                    }
                    else if (resultado == "Error al Registrar") { MessageBox.Show("Error al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else if (resultado == "Existe") { MessageBox.Show("Ya Exsiten estos Parametros de La factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else
                {
                    String resultado = ObjParametrosFactura.ModificarParametrosFactura(ObjParametrosFactura); // retorna true si esta correcto todo
                    if (resultado == "Datos Actualizados")
                    {
                        MessageBox.Show("Datos Actualizados Correctamente ", "Exito", MessageBoxButtons.OK);
                        //rbtActivos.Checked = true;
                        //inicializarDatos();

                    }
                    else if (resultado == "Error al Actualizar") { MessageBox.Show("Error al Actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }
            else { MessageBox.Show("Ingrese los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void TxtAncho_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, TxtAncho.Text);
        }

        private void TxtNumeroItemsFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void TxtLargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, TxtLargo.Text);
        }

        private void TxtAncho_Enter(object sender, EventArgs e)
        {
            TxtAncho.SelectAll();
        }

        private void TxtLargo_Enter(object sender, EventArgs e)
        {
            TxtLargo.SelectAll();
        }

        private void TxtNumeroItemsFactura_Enter(object sender, EventArgs e)
        {
            TxtNumeroItemsFactura.SelectAll();
        }

        private void txtMontoMinimoFacturaEmpresa_Enter(object sender, EventArgs e)
        {
            txtMontoMinimoFacturaEmpresa.SelectAll();
        }

        private void TxtTamañoEncabezadoFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, TxtTamañoEncabezadoFact.Text);
        }

        private void TxtTamañoPieFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.SoloValores(e, TxtTamañoPieFact.Text);
        }

        private void ckbContribuyenteEspecial_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbContribuyenteEspecial.Checked)
            {
                txtNumeroResolucion.Enabled = true;
            }
            else
            {
                txtNumeroResolucion.Enabled = false;
            }
        }


        internal static String claveCertificado = "";
        private String RutaCertificado = "";
        private void BtnAgregarCertificado_Click(object sender, EventArgs e)
        {
            //LblEstadoCertificado.Text = "";
            //TxtEntidadCertificadora.Text = "";
            //TxtSujeto.Text = "";
            try
            {
                string RutaDatosEmpresa = ConfigurationManager.AppSettings["XmlServidor"];
                OpenFileDialog File = new OpenFileDialog();
                File.Filter = "Documento Digital (*.p12,*.pfx)|*.p12;*.pfx";
                if (File.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    RutaCertificado = File.FileName;

                    FrmDatosCertificado formularioCertificado = new FrmDatosCertificado();
                    formularioCertificado.Activate();
                    formularioCertificado.ShowDialog();

                    Certificado cer = new Certificado();
                    List<string> datos = new List<string>();
                    datos = cer.CertificadoVerificar(RutaCertificado, claveCertificado);
                    LblEstadoCertificado.Text = datos[1];
                    LblUnidadCertificadora.Text = datos[0];

                    MessageBox.Show("Certificado Cargado Correctamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!System.IO.Directory.Exists(RutaDatosEmpresa))
                    {
                        System.IO.Directory.CreateDirectory(RutaDatosEmpresa);
                    }
                    string archivoDestino =System.IO.Path.Combine(RutaDatosEmpresa, File.SafeFileName);
                    System.IO.File.Copy(RutaCertificado, archivoDestino, true);
                    Program.RutaCertificado = RutaDatosEmpresa + @"\"+ Path.GetFileName(File.FileName) + ""; ;
                    Program.passwordCertificado = claveCertificado;

                    if (consultas.ExisteEnFacturaElectro("IDCertificado", "1","TbCertificado"))
                    {
                        consultas.EjecutarSQLFactElectronica("UPDATE [dbo].[TbCertificado] SET [Certificado] = '"+ claveCertificado + "' ,[RutaCertificado] = '"+ Program.RutaCertificado + "'  ,[Usuario] = '"+ LblEstadoCertificado.Text + "' , EntidadCertificadora = '"+ LblUnidadCertificadora.Text + "'  WHERE IDCertificado = 1");
                    }
                    else
                    {
                        consultas.EjecutarSQLFactElectronica("INSERT INTO [dbo].[TbCertificado] ([Certificado] ,[RutaCertificado] ,[Usuario],[EntidadCertificadora]) VALUES ('" + claveCertificado + "','" + Program.RutaCertificado + "','" + LblEstadoCertificado.Text + "','" + LblUnidadCertificadora.Text + "')");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Contraseña Incorrecta", "Contraseña Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblUnidadCertificadora.Text = "Estado";
                LblEstadoCertificado.Text = "Estado";
            }
        }
    }
}
