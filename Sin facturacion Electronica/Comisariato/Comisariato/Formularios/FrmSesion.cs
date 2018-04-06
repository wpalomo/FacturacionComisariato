using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Runtime.InteropServices;
using Comisariato.Formularios;
using Comisariato.Clases;


namespace Comisariato
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Color mycolor = Color.FromArgb(100, 150, 75);
            lblError.Text = "";
        }

        //para mover el Form formborderstyle=none
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        ////FIN 

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        // Consultas objConsulta = new Consultas();


        bool PrimerIngresoSistemaLogin = false;

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Consultas c = new Consultas();
            if (!c.ConsultarPrimerRegisto("TbUsuario", ""))
            {

                String[] datosArchivoConfigPersona = Funcion.leerArchivo(@"C:\Program Files (x86)\Aircontrol\DatosAdmin.shc");
                String[] datosArchivoConfigEmpresa = Funcion.leerArchivo(@"C:\Program Files (x86)\Aircontrol\DatosEmpresa.shc");
                if (datosArchivoConfigPersona != null && datosArchivoConfigEmpresa != null)
                {
                    //if (datosArchivoConfigPersona[2] == txtUsuario.Text && datosArchivoConfigPersona[3] == txtContraseña.Text)
                    //{
                        c.InsertarDatosPrincipalesConfiguracionEmpresa(datosArchivoConfigEmpresa);
                        c.InsertarDatosPrincipalesConfiguracionUser(datosArchivoConfigPersona[0], datosArchivoConfigPersona[1], datosArchivoConfigPersona[2], datosArchivoConfigPersona[3]);
                    //BtnIniciar_Click(null, null);
                    PrimerIngresoSistemaLogin = true;

                    //}

                }
            }
            c.BoolLlenarComboBox(cbEmpresa, "select IDEMPRESA as ID, NOMBRE as Texto from TbEmpresa");
            PanelSesion.BackColor = Color.FromArgb(100, 0xFF, 0xFF, 0XFF);
            BtnIniciar.BackColor = Color.FromArgb(224, 224, 224);
            
        }

        private void PboxSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            //Program.EmpresaUsuario = Convert.ToInt32(cbEmpresa.SelectedValue);
            //Consultas c = new Consultas();
            //if (txtUsuario.Text != "")
            //{
            //    if (txtContraseña.Text != "")
            //    {
            //        bool b = c.AutenticacionUsuario(txtUsuario.Text, txtContraseña.Text);
            //        if (b)
            //        {
            //            if (Program.estado)
            //            {
            //                // Program.Usuario = txtUsuario.Text;
            //                //Program.IDUsuario=
            //                Program.FecaInicio = DateTime.Now.Date.ToShortDateString();
            //                Program.horainicio = DateTime.Now.TimeOfDay.ToString();
            //                FrmPrincipal p = new FrmPrincipal();
            //                Bitacora ObjBitacora = new Bitacora("00:00:00", "Inicio de Sessión");
            //                ObjBitacora.insertarBitacora();
            //                p.Show();
            //                this.Visible = false;
            //            }
            //            else
            //            {
            //                lblError.Text = "Su usuario por el momento se encuentra desabilitado.\nContactate con el administrador del sistema.";
            //            }

            //        }
            //        else
            //        {
            //            //if (c.ConsultarPrimerRegisto("TbUsuario", ""))
            //            //{
            //                lblError.Text = "Credenciales incorrectas.";
            //            //}
            //            //else
            //            //{
            //                //String[] datosArchivoConfigPersona = Funcion.leerArchivo(@"C:\Program Files (x86)\Aircontrol\DatosAdmin.shc");
            //                //String[] datosArchivoConfigEmpresa = Funcion.leerArchivo(@"C:\Program Files (x86)\Aircontrol\DatosEmpresa.shc");
            //                //if (datosArchivoConfigPersona != null && datosArchivoConfigEmpresa != null)
            //                //{
            //                    //if (datosArchivoConfigPersona[2] == txtUsuario.Text && datosArchivoConfigPersona[3] == txtContraseña.Text)
            //                    //{
            //                        //c.InsertarDatosPrincipalesConfiguracionEmpresa(datosArchivoConfigEmpresa);
            //                        //c.InsertarDatosPrincipalesConfiguracionUser(datosArchivoConfigPersona[0], datosArchivoConfigPersona[1], datosArchivoConfigPersona[2], datosArchivoConfigPersona[3]);
            //                        //BtnIniciar_Click(null, null);
            //                    //}

            //                //}
            //            //}
            //        }

            //    }
            //    else
            //    {
            //        lblError.Text = "Ingresa la contraseña.";
            //        txtContraseña.Focus();
            //    }

            //}
            //else
            //{
            //    lblError.Text = "Ingresa el usuario.";
            //    txtUsuario.Focus();
            // }
            //string impresora = ConfigurationManager.AppSettings["Impresoras"].ToString();
           // var valor = ConfigurationManager.AppSettings["Bodega"];
            //ticket.ImprimirTicket(impresora);
            loguearse();
       }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                loguearse();
                //Consultas c = new Consultas();
                //if (txtUsuario.Text != "")
                //{
                //    if (txtContraseña.Text != "")
                //    {
                //        bool b = c.AutenticacionUsuario(txtUsuario.Text, txtContraseña.Text);
                //        if (b)
                //        {
                //            FrmPrincipal p = new FrmPrincipal();
                //            p.Show();
                //            this.Visible = false;
                //        }
                //        else
                //        {
                //            lblError.Text = "Credenciales incorrectas.";
                //        }

                //    }
                //    else
                //    {
                //        lblError.Text = "Ingresa la contraseña.";
                //        txtContraseña.Focus();
                //    }

                //}
                //else
                //{
                //    lblError.Text = "Ingresa el usuario.";
                //    txtUsuario.Focus();
                //}

            }
        }

        private void loguearse()
        {
            Program.EmpresaUsuario = Convert.ToInt32(cbEmpresa.SelectedValue);
            Consultas c = new Consultas();
            if (txtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    bool b = c.AutenticacionUsuario(txtUsuario.Text, txtContraseña.Text);
                    if (b)
                    {
                        if (Program.estado)
                        {
                            // Program.Usuario = txtUsuario.Text;
                            //Program.IDUsuario=
                            Program.FecaInicio = Funcion.reemplazarcaracterFecha(DateTime.Now.Date.ToShortDateString());
                            Program.horainicio = DateTime.Now.TimeOfDay.ToString();
                            FrmPrincipal p = new FrmPrincipal();
                            p.primerIngresoSistema = this.PrimerIngresoSistemaLogin;
                            Bitacora ObjBitacora = new Bitacora("00:00:00", "Inicio de Sessión");
                            ObjBitacora.insertarBitacora();
                            p.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            lblError.Text = "Su usuario por el momento se encuentra desabilitado.\nContactate con el administrador del sistema.";
                        }

                    }
                    else
                    {
                        lblError.Text = "Credenciales incorrectas.";
                    }

                }
                else
                {
                    lblError.Text = "Ingresa la contraseña.";
                    txtContraseña.Focus();
                }

            }
            else
            {
                lblError.Text = "Ingresa el usuario.";
                txtUsuario.Focus();
            }
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }


    }
}
