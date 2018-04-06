using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Mantenimiento.Empresa
{
    public partial class FrmDatosCertificado : Form
    {
        public FrmDatosCertificado()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FrmParametrosFactura.claveCertificado = TxtContraCertificado.Text;
            this.Close();
        }
    }
}
