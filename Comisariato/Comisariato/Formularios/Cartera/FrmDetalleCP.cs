using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Formularios.Cartera
{
    public partial class FrmDetalleCP : Form
    {
        public FrmDetalleCP()
        {
            InitializeComponent();
        }

        private void FrmDetalleCP_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                dgvDetalleCP.Rows.Add();
            }
        }
    }
}
