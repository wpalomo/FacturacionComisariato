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

namespace Comisariato.Formularios
{
    public partial class FrmCambioClave : Form
    {
        public FrmCambioClave()
        {
            InitializeComponent();
        }

        private void ckbActual_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtActual.Text;
            if (ckbActual.Checked)
            {
                txtActual.UseSystemPasswordChar = false;
                txtActual.Text = text;
            }
            else
            {
                txtActual.UseSystemPasswordChar = true;
                txtActual.Text = text;
            }
        }

        private void ckbNueva_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtNueva.Text;
            if (ckbNueva.Checked)
            {
                txtNueva.UseSystemPasswordChar = false;
                txtNueva.Text = text;
            }
            else
            {
                txtNueva.UseSystemPasswordChar = true;
                txtNueva.Text = text;
            }
        }

        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            Funcion.Limpiarobjetos(groupBox1);
            ckbActual.Checked = false;
            ckbNueva.Checked = false;
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (txtActual.Text != "" && txtNueva.Text != "" && txtConfirmar.Text != "")
            {
                if (txtNueva.Text == txtConfirmar.Text)
                {
                    Usuario objUser = new Usuario();
                    if (objUser.ChangePassword(txtNueva.Text, txtActual.Text, txtConfirmar.Text))
                    {
                        MessageBox.Show("Contraseña Actualizada", "Exito", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Contraseña actual incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña actual no coincide", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtActual.SelectAll();
                    txtConfirmar.SelectAll();
                }
            }
            else
                MessageBox.Show("Llene todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
