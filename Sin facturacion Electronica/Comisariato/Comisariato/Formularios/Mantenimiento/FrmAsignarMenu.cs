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

namespace Comisariato.Formularios.Mantenimiento
{
    public partial class FrmAsignarMenu : Form
    {
        public FrmAsignarMenu()
        {
            InitializeComponent();
        }
        Consultas objConsul = new Consultas();
        private void FrmAsignarMenu_Load(object sender, EventArgs e)
        {

            objConsul.BoolLlenarTreeViewMenu(tvMenuAsignacion, "Select NODOPADRE, DESCRIPCION FROM TbMenu");
            objConsul.BoolLlenarComboBox(cbEmpresa, "select IDEMPRESA as ID, NOMBRE AS Texto from TbEmpresa");
        }

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            objConsul.BoolLlenarComboBox(cbUsuario, "SELECT  dbo.TbUsuario.IDUSUARIO as ID, dbo.TbUsuario.USUARIO As Texto FROM dbo.TbEmpresa INNER JOIN dbo.TbUsuario ON dbo.TbEmpresa.IDEMPRESA = dbo.TbUsuario.IDEMPRESA INNER JOIN dbo.TbEmpleado ON dbo.TbUsuario.IDEMPLEADO = dbo.TbEmpleado.IDEMPLEADO WHERE (dbo.TbEmpresa.IDEMPRESA = " + cbEmpresa.SelectedValue + ") and dbo.TbUsuario.IDEMPLEADO != 1");
        }

        private void cbUsuario_Enter(object sender, EventArgs e)
        {
            objConsul.BoolLlenarComboBox(cbUsuario, "SELECT  dbo.TbUsuario.IDUSUARIO as ID, dbo.TbUsuario.USUARIO As Texto FROM dbo.TbEmpresa INNER JOIN dbo.TbUsuario ON dbo.TbEmpresa.IDEMPRESA = dbo.TbUsuario.IDEMPRESA INNER JOIN dbo.TbEmpleado ON dbo.TbUsuario.IDEMPLEADO = dbo.TbEmpleado.IDEMPLEADO WHERE (dbo.TbEmpresa.IDEMPRESA = " + cbEmpresa.SelectedValue + ") and dbo.TbUsuario.IDEMPLEADO != 1");
        }

        private void tvMenuAsignacion_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Nodes.Count > 0)
                {
                    int cantidadNodosHijos = e.Node.GetNodeCount(true);
                    for (int i = 0; i < cantidadNodosHijos; i++)
                    {
                        if (e.Node.Checked == true)                        
                            e.Node.Nodes[i].Checked = true;
                        else
                            e.Node.Nodes[i].Checked = false;
                    }
                }
                else
                {
                    
                }
            }
            catch (Exception)
            {
            }
           
        }
        
        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                AsignacionMenu objAM = new AsignacionMenu();
                int contadorEntradaPadre = 0;
                for (int i = 0; i < 6; i++)
                {
                    contadorEntradaPadre = 0;
                    //int nodo = Convert.ToInt32(objConsul.ObtenerValorCampo("IDMENU", "TbMenu", "where DESCRIPCION = '" + tvMenuAsignacion.Nodes[i].Text +"'"));
                    int cantNodos = tvMenuAsignacion.Nodes[i].GetNodeCount(true);
                    for (int j = 0; j < cantNodos; j++)
                    {

                        int cantNodosHijos = tvMenuAsignacion.Nodes[i].Nodes[j].GetNodeCount(true);
                        if (cantNodosHijos > 0)
                        {
                            contadorEntradaPadre=0;
                            cantNodos = Math.Abs(cantNodosHijos - cantNodos);
                            for (int k = 0; k < cantNodosHijos; k++)
                            {
                                if (tvMenuAsignacion.Nodes[i].Nodes[j].Nodes[k].Checked == true)
                                {
                                    contadorEntradaPadre++;
                                    if (contadorEntradaPadre == 1)
                                    {
                                        int nodoPadre = Convert.ToInt32(objConsul.ObtenerValorCampo("IDMENU", "TbMenu", "where DESCRIPCION = '" + tvMenuAsignacion.Nodes[i].Text + "'"));
                                        objAM.InsertarMenuAsignado(nodoPadre, Convert.ToInt32(cbUsuario.SelectedValue));
                                        nodoPadre = Convert.ToInt32(objConsul.ObtenerValorCampo("IDMENU", "TbMenu", "where DESCRIPCION = '" + tvMenuAsignacion.Nodes[i].Nodes[j].Text + "'"));
                                        objAM.InsertarMenuAsignado(nodoPadre, Convert.ToInt32(cbUsuario.SelectedValue));
                                    }
                                    int nodo = Convert.ToInt32(objConsul.ObtenerValorCampo("IDMENU", "TbMenu", "where DESCRIPCION = '" + tvMenuAsignacion.Nodes[i].Nodes[j].Nodes[k].Text + "'"));
                                    objAM.InsertarMenuAsignado(nodo, Convert.ToInt32(cbUsuario.SelectedValue));                                    
                                }
                                
                            }
                            contadorEntradaPadre = 0;
                        }
                        if (tvMenuAsignacion.Nodes[i].Nodes[j].Checked == true)
                        {
                            contadorEntradaPadre++;
                            if (contadorEntradaPadre == 1)
                            {
                                int nodoPadre = Convert.ToInt32(objConsul.ObtenerValorCampo("IDMENU", "TbMenu", "where DESCRIPCION = '" + tvMenuAsignacion.Nodes[i].Text + "'"));
                                objAM.InsertarMenuAsignado(nodoPadre, Convert.ToInt32(cbUsuario.SelectedValue));
                            }
                            int nodo = Convert.ToInt32(objConsul.ObtenerValorCampo("IDMENU", "TbMenu", "where DESCRIPCION = '" + tvMenuAsignacion.Nodes[i].Nodes[j].Text + "'"));
                            objAM.InsertarMenuAsignado(nodo, Convert.ToInt32(cbUsuario.SelectedValue));
                            
                        }
                        
                    }
                }
                MessageBox.Show("Guardado Correctamente");
            }
            catch (Exception ex)
            {
            }
        }
    }
}
