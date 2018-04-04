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

namespace Comisariato.Formularios.Transacciones
{
    public partial class FrmClaveSupervisor : Form
    {
        Consultas c;
        public FrmClaveSupervisor()
        {
            InitializeComponent();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //c = new Consultas();  
            if (txtClave.Text!="")
            {
                if (txtClave.Text == Program.clavesupervisor)
                {
                    FrmFactura.correcta = 1;
                    FrmFactura.verificadorfrm = 1;
                    this.Close();
                }
                else
                {
                    //FrmFactura.correcta = 2;
                    lblerror.Text = "Clave incorrecta";
                }
                
            }
            else
            {
                lblerror.Text="Ingresa la clave.";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            FrmFactura.correcta = 0;
            FrmFactura.verificadorfrm = 1;
            this.Close();
        }

        private void FrmClaveSupervisor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
            //FrmFactura.correcta = 0;
            //FrmFactura.verificadorfrm = 1;
            //this.Close();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            lblerror.Text = "";
        }
    }
}
