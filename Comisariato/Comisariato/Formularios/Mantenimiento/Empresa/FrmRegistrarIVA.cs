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

namespace Comisariato.Formularios.Mantenimiento.Empresa
{
    public partial class FrmRegistrarIVA : Form
    {
        public FrmRegistrarIVA()
        {
            InitializeComponent();
        }
        Consultas consulta = new Consultas();

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (!consulta.Existe("IVA", txtIva.Text, "[dbo].[TbIva]")){
                if(consulta.Insertar("insert into [dbo].[TbIva] ([IVA],[IDEMPRESA])VALUES('" + txtIva.Text + "', 1)"))
                {
                    MessageBox.Show("Registrado correctamente.");
                        this.Close();
                }
                else
                    MessageBox.Show("Error al registrar.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Iva existente en la base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcion.Validar_Numeros(e);
        }

        private void btnLimpiarIva_Click(object sender, EventArgs e)
        {

        }
    }
}
