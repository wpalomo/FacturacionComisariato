using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisariato.Clases
{
    public class Proveedor
    {
        Consultas ObjConsulta;

        string codigo;
        string nombres;
        string identificacion;
        string nacionalidad;
        string naturaleza;
        string direccion;
        string razosocial;
        string email;
        string telefono;
        string celular;
        string giracheque;
        string responsable;
        string tipogasto;
        string tiposervicio;
        int idparroquia;
        bool riseproveedor;
        string tipoIdentificacion;
        string plazo;
        string fax;
        bool estado;
        int IDCuentaContable;
        int credito, ice, codigo_101;
        string celularResponsable;
        public Proveedor()
        {
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }
        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }
        public string Nacionalidad
        {
            get
            {
                return nacionalidad;
            }

            set
            {
                nacionalidad = value;
            }
        }
        public string Naturaleza
        {
            get
            {
                return naturaleza;
            }

            set
            {
                naturaleza = value;
            }
        }
        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }
        public string Razosocial
        {
            get
            {
                return razosocial;
            }

            set
            {
                razosocial = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }
        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }
        public string Giracheque
        {
            get
            {
                return giracheque;
            }

            set
            {
                giracheque = value;
            }
        }
        public string Responsable
        {
            get
            {
                return responsable;
            }

            set
            {
                responsable = value;
            }
        }
        public string Tipogasto
        {
            get
            {
                return tipogasto;
            }

            set
            {
                tipogasto = value;
            }
        }
        public string Tiposervicio
        {
            get
            {
                return tiposervicio;
            }

            set
            {
                tiposervicio = value;
            }
        }
        public int Idparroquia
        {
            get
            {
                return idparroquia;
            }

            set
            {
                idparroquia = value;
            }
        }
        public bool Riseproveedor
        {
            get
            {
                return riseproveedor;
            }

            set
            {
                riseproveedor = value;
            }
        }
        public string TipoIdentificacion
        {
            get
            {
                return tipoIdentificacion;
            }

            set
            {
                tipoIdentificacion = value;
            }
        }
        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Plazo
        {
            get
            {
                return plazo;
            }

            set
            {
                plazo = value;
            }
        }

        public string Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }

        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public int IDCuentaContable1
        {
            get
            {
                return IDCuentaContable;
            }

            set
            {
                IDCuentaContable = value;
            }
        }

        public int Credito
        {
            get
            {
                return credito;
            }

            set
            {
                credito = value;
            }
        }

        public int Ice
        {
            get
            {
                return ice;
            }

            set
            {
                ice = value;
            }
        }

        public int Codigo_101
        {
            get
            {
                return codigo_101;
            }

            set
            {
                codigo_101 = value;
            }
        }

        public string CelularResponsable
        {
            get
            {
                return celularResponsable;
            }

            set
            {
                celularResponsable = value;
            }
        }

        public Proveedor(string fax, bool estado, string plazo, string codigo, string tipoIdentificacion,string nombres, string identificacion, string nacionalidad, string naturaleza, string direccion, string razosocial, string email, string telefono, string celular, string giracheque, string responsable, string tipogasto, string tiposervicio, int idparroquia, bool riseproveedor, int IDCuentaContable, int credito, int ice, int codigo_101, string celularResponsable)
        {
            this.Nombres = nombres;
            this.Identificacion = identificacion;
            this.Nacionalidad = nacionalidad;
            this.Naturaleza = naturaleza;
            this.Direccion = direccion;
            this.Razosocial = razosocial;
            this.Email = email;
            this.Telefono = telefono;
            this.Celular = celular;
            this.Giracheque = giracheque;
            this.Responsable = responsable;
            this.Tipogasto = tipogasto;
            this.Tiposervicio = tiposervicio;
            this.Idparroquia = idparroquia;
            this.Riseproveedor = riseproveedor;
            this.TipoIdentificacion = tipoIdentificacion;
            this.Codigo = codigo;
            this.Plazo = plazo;
            this.Fax = fax;
            this.Estado = estado;
            this.IDCuentaContable = IDCuentaContable;
            this.credito = credito;
            this.ice = ice;
            this.codigo_101 = codigo_101;
            this.celularResponsable = celularResponsable;
        }
        public string InsertarProveedor(Proveedor ObjProvee)
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("IDENTIFICACION", identificacion, "TbProveedor"))
            {
                if (ObjConsulta.EjecutarPROCEDUREProveedor(ObjProvee))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }

        public string ModificarProveedor(string Identificacion)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbProveedor] SET[NOMBRES] = '"+nombres.ToUpper()+ "',[IDENTIFICACION] = '"+this.identificacion+ "' ,[NACIONALIDAD] = '"+nacionalidad+"'," +
                "[NATURALEZA] = '"+naturaleza+ "',[DIRECCION] = '"+direccion.ToUpper() + "',[RAZONSOCIAL] = '"+razosocial.ToUpper() + "',[EMAIL] = '"+email+ "',[TELEFONO] = '"+telefono+ "',[CELULAR] = '"+celular+"' ," +
                "[GIRACHEQUEA] = '"+giracheque.ToUpper() + "',[RESPONSABLE] = '"+responsable.ToUpper() + "' ,[CELULAR_RESPONSABLE] = '"+celularResponsable+"',[TIPOGASTO] = '" + tipogasto+ "',[TIPOSERVICIO] = '"+tiposervicio+ "',[IDPARROQUIA] = "+idparroquia+ " , [PROVEEDORRISE] = '"+ riseproveedor + "' , [IDCuentaContable] = "+IDCuentaContable+ " ,[CREDITO] = "+credito+" ,[ICE] = "+ice+" ,[CODIGO_101] = "+codigo_101+" WHERE IDENTIFICACION = '" + Identificacion + "';"))
            {
                return "Correcto";
            }
            else { return "Error al Modificar"; }
        }

        public string EstadoProveedor(string Identificacion, int estado)
        {
            ObjConsulta = new Consultas();
            if (estado == 1)
                if (ObjConsulta.EjecutarSQL("UPDATE TbProveedor SET ESTADO = 1 WHERE IDENTIFICACION = '" + Identificacion + "'"))
                {
                    return "Habilitado";
                }
                else { return "Error"; }
            else if (estado == 2)
            {
                if (ObjConsulta.EjecutarSQL("UPDATE TbProveedor SET ESTADO = 0 WHERE IDENTIFICACION = '" + Identificacion + "'"))
                {
                    return "Correcto";
                }
                else { return "Error"; }
            }
            else { return "Sin Accion"; }
        }
        public string InsertarTablaAutorizacionProveedor(string serie1, string serie2, string AUTORIZACION,string VALIDO_HASTA,string FAC_INICIO, string FAC_FIN,int IDPROVEEDOR)
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("SERIE1", serie1 + "' and SERIE2 = '"+ serie2 , "TbAutorizacionProveedor"))
            {
                if (ObjConsulta.EjecutarSQL("INSERT INTO [dbo].[TbAutorizacionProveedor] ([SERIE1] ,[SERIE2] ,[AUTORIZACION] ,[VALIDO_HASTA] ,[FAC_INICIO] ,[FAC_FIN] ,[IDPROVEEDOR])"
                +" VALUES('"+serie1+"','"+serie2+ "','"+AUTORIZACION+ "','"+Funcion.reemplazarcaracterFecha(VALIDO_HASTA)+ "','"+FAC_INICIO+ "','"+FAC_FIN+"',"+IDPROVEEDOR+")"))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }
        public string InsertarTablaRetencion(int IDPROVEEDOR, int IDRETENCION)
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("IDRETENCION", IDRETENCION + "' and IDPROVEEDOR = '" + IDPROVEEDOR, "TbRetencionProveedor"))
            {
                if (ObjConsulta.EjecutarSQL("INSERT INTO [dbo].[TbRetencionProveedor] ([IDRETENCION], [IDPROVEEDOR])"
                + " VALUES(" + IDRETENCION + "," + IDPROVEEDOR + ")"))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }

        public void InsertarAutorizacionProveedor(DataGridView dgv, string identificacionProve)
        {
            try
            {
                String idproveedor = ObjConsulta.ObtenerValorCampo("IDPROVEEDOR", "TbProveedor", "where TbProveedor.IDENTIFICACION = '"+identificacionProve+"'");
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    if (dgv.Rows[i].Cells[0].Value != null && dgv.Rows[i].Cells[1].Value != null && dgv.Rows[i].Cells[2].Value != null && dgv.Rows[i].Cells[3].Value != null && dgv.Rows[i].Cells[4].Value != null && dgv.Rows[i].Cells[5] != null)
                    {
                        InsertarTablaAutorizacionProveedor(dgv.Rows[i].Cells[0].Value.ToString(), dgv.Rows[i].Cells[1].Value.ToString(), dgv.Rows[i].Cells[2].Value.ToString(), dgv.Rows[i].Cells[3].Value.ToString(), dgv.Rows[i].Cells[4].Value.ToString(), dgv.Rows[i].Cells[5].Value.ToString(), Convert.ToInt32(idproveedor));
                    }
                    else {
                        //MessageBox.Show("Ingrese los Datos de Autorizacion Completos");
                    }
                    
                }
            }
            catch (Exception ex)
            {

                //throw;
            }
        }
        public void InsertarRetencion(DataGridView dgv, string identificacionProve)
        {
            try
            {
                String idproveedor = ObjConsulta.ObtenerValorCampo("IDPROVEEDOR", "TbProveedor", "where TbProveedor.IDENTIFICACION = '" + identificacionProve + "'");
                ObjConsulta.EjecutarSQL("DELETE FROM [dbo].[TbRetencionProveedor] WHERE IDPROVEEDOR = "+ idproveedor);
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    if (dgv.Rows[i].Cells[0].Value.ToString() != "")
                    {
                        InsertarTablaRetencion(Convert.ToInt32(idproveedor), Convert.ToInt32(dgv.Rows[i].Cells[0].Value));
                    }
                    else
                    {
                        break;
                    }

                }
            }
            catch (Exception ex)
            {

                // throw;
            }
        }

    }

   
}