using Comisariato.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmClaveUsuario : Form
    {

        Consultas c;
        Funcion objFuncion = new Funcion();
            public int verificarMetodo;
        public string numcajaAvance = "";

        public FrmClaveUsuario()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        Bitacora bitacora;

        private void button1_Click(object sender, EventArgs e)
        {
            Auntenticar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Auntenticar();
            }
        }
        public static FrmFactura f;
        private void Auntenticar()
        {
            try
            {
                f = null;
                if (txtClave.Text != "")
                {
                    c = new Consultas();
                    //bool b = c.VerificarClave("SELECT TbUsuario.CONTRASEÑA, TbUsuario.USUARIO, TbTipousuario.TIPO, TbUsuario.IDTIPOUSUARIO from TbUsuario INNER JOIN TbTipousuario ON(TbUsuario.USUARIO = '" + Program.Usuario + "' and TbUsuario.CONTRASEÑA= '" + txtClave.Text + "')" + " AND (TbTipousuario.IDTIPOUSUARIO = '" + Program.IDTIPOUSUARIO + "' and TbTipousuario.TIPO='CAJERO')");
                    if (verificarMetodo == 1)
                    {
                        bool b = c.VerificarClave(txtClave.Text);
                        if (b)
                        {
                            Program.contraseñausuarioactual = txtClave.Text;
                            
                            bitacora = new Bitacora("00:00:00", "Venta");
                            bitacora.insertarBitacora();

                            string numcaja = "", sucursal = "", documentoActual = "";
                            string IpMaquina = bitacora.LocalIPAddress();
                            //IPESTACION = '" + IpMaquina + "' and
                            DataTable Dt = c.BoolDataTable("Select TIPODOCUMENTO, SERIE1,SERIE2,DOCUMENTOACTUAL,DOCUMENTOINICIAL,DOCUMENTOFINAL,AUTORIZACION,ESTACION,IPESTACION from TbCajasTalonario where IPESTACION = '" + IpMaquina + "' and  ESTADO=1 ;");
                            if (Dt.Rows.Count > 0)
                            {
                                bool banderaCaja = false;
                                for (int i = 0; i < Dt.Rows.Count; i++)
                                {
                                    banderaCaja = true;
                                    DataRow myRows = Dt.Rows[i];
                                    if (myRows["TIPODOCUMENTO"].ToString() == "FAC")
                                    {
                                        sucursal = myRows["SERIE1"].ToString();
                                        numcaja = myRows["SERIE2"].ToString();
                                        documentoActual = myRows["DOCUMENTOACTUAL"].ToString();
                                        banderaCaja = false;
                                        Program.NumeroCaja = Convert.ToInt32(numcaja);
                                        break;
                                        //FrmPrincipal.menuMostrar.Visible = false;
                                    }                                    
                                }
                                if (banderaCaja)
                                {
                                    MessageBox.Show("Caja no registrada");
                                }                    
                            }
                            else
                            {
                                MessageBox.Show("Caja no registrada");
                            }

                            //DataTable Dtparametros = c.BoolDataTable("Select PIE1,PIE2,PIE3,PIE4 from TbParametrosFactura INNER JOIN TbAutorizadosImprimir ON( TbParametrosFactura.IDPARAMETROSFACTURA=TbAutorizadosImprimir.IDPARAMETROSFACTURA AND TbParametrosFactura.IDEMPRESA= '" + Program.IDEMPRESA + "');");
                            DataTable Dtparametros = c.BoolDataTable("Select* from View_ParametrosFactura where IDEMPRESA = " + Program.IDEMPRESA + ";");
                            if (Dtparametros.Rows.Count > 0)
                            {
                                DataRow myRows = Dtparametros.Rows[0];
                                Program.piefactura = myRows["PIE1"].ToString() + "\n" + myRows["PIE2"].ToString() + "\n" + myRows["PIE3"].ToString() + "\n" + myRows["PIE4"].ToString();
                                Program.BoolPreimpresa = Convert.ToBoolean(myRows["PREIMPRESA"]);
                                Program.BoolAutorizadoImprimir = Convert.ToBoolean(myRows["AUTORIZADOIMPRIMIR"]);
                                //TAMANOENCABEZADOFACTURA-TAMANOPIEFACTURA-NUMEROITEMS
                                Program.DatosPreimpresa = myRows["TAMANOENCABEZADOFACTURA"].ToString() + "-" + myRows["TAMANOPIEFACTURA"].ToString() + "-" + myRows["NUMEROITEMS"].ToString();
                                Program.IVA = myRows["IVA"].ToString();
                                if (Convert.ToBoolean(myRows["OBLIGADOLLEVARCONTABILIDAD"]))
                                    Program.obligadoContabilidad = "SI";
                                else
                                    Program.obligadoContabilidad = "NO";

                            }

                            string condicion = " where CAJA = '" + numcaja + "' and SUCURSAL= '" + sucursal + "';";
                            int numero = c.ObtenerID("DOCUMENTOACTUAL", "TbCajasTalonario", condicion);
                            condicion = " where IDENTIFICACION= 9999999999999";
                            //f.IDCLIENTEINICIO = c.ObtenerID("IDCLIENTE", "TbCliente", condicion);

                            //f.numfact = Convert.ToInt32(documentoActual);
                            //f.sucursal = sucursal;
                            //f.numcaja = numcaja;
                            this.Close();
                            //if (f == null || f.IsDisposed)
                            //{
                            //f.ShowDialog();
                            //f = new FrmFactura();
                            //                      SELECT[IDCIERRECAJA]
                            //,[TOTALBILLETES]
                            //,[TOTALMONEDAS]
                            //,[TOTALCHEQUES]
                            //,[TOTALAVANCES]
                            //,[TOTALRECAUDADO]
                            //,[TOTALENTREGADO]
                            //,[FECHA]
                            //,[IDUSUARIO]
                            //,[CAJA]
                            if (!Program.arqueo)
                            {
                                if (!c.Existe("CAJA = " + Program.NumeroCaja + " AND IDUSUARIO = " + Program.IDUsuarioMenu + " AND FECHA", Funcion.reemplazarcaracterFecha(DateTime.Now.Date.ToShortDateString()), "TbCierreCaja"))
                                {
                                    if (f == null || f.IsDisposed)
                                    {
                                        f = new FrmFactura();
                                        f.IDCLIENTEINICIO = c.ObtenerID("IDCLIENTE", "TbCliente", condicion);

                                        f.numfact = Convert.ToInt32(documentoActual);
                                        f.sucursal = sucursal;
                                        f.numcaja = numcaja;

                                        f.MdiParent = Program.panelPrincipalVariable;
                                        f.BringToFront();
                                        f.Show();

                                    }
                                    else { f.BringToFront(); }
                                    //f.verificarMetodo = 1;
                                    //objFuncion.AddFormInPanel(f, Program.panelPrincipalVariable);
                                    f.Dock = DockStyle.Top;
                                    //FrmPrincipal.menuMostrar.Visible = false; 
                                    //}
                                }
                                else
                                    MessageBox.Show("Este usuario ya cerro esta caja");
                            }
                            else
                                MessageBox.Show("Este usuario ya cerro esta caja");

                        }
                        else
                        {
                            MessageBox.Show("Clave incorrecta. O quizas no tenga permiso para ingresar a esta opcion.");
                            txtClave.Focus();
                            txtClave.SelectAll();
                        }
                    }
                    else
                    {
                        if (txtClave.Text == Program.contraseñausuarioactual)
                        {
                            FrmAvanse s = new FrmAvanse();
                            s.cajero = Program.NOMBRES + " " + Program.APELLIDOS;
                            s.fecha = Program.FecaInicio;
                            s.caja = "" + numcajaAvance;
                            s.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Clave incorrecta. O quizas no tenga permiso para ingresar a esta opcion.");
                        }

                    }



                }
            }
            catch (Exception ex)
            {

                // MessageBox.Show(""+ex.Message);
            }


        }

        private void FrmClaveUsuario_Load(object sender, EventArgs e)
        {
            txtClave.Focus();
            SendKeys.Send("{TAB}");

            txtClave.Focus();
        }

        private void FrmClaveUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose(true);
        }
    }
}
