using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisariato.Clases
{
    public class Empresa
    {
        string nombreEmpresa;
        string rucEmpresa;
        string nombreComercial;
        string razonSocial;
        string gerente;
        string direccion;
        string emailEmpresa;
        DateTime fechaInicioContable;
        string celular1Empresa;
        string celular2Empresa;
        string rucContador;
        string nombreContador;
        string emailContador;
        string celular1Contador;
        string celular2Contador;
        string claveSupervisor;
        byte[] logoEmpresa;
        byte[] fondoPantallaEmpresa;

        Consultas ObjConsulta;

        public string NombreEmpresa
        {
            get
            {
                return nombreEmpresa;
            }

            set
            {
                nombreEmpresa = value;
            }
        }
        public string RucEmpresa
        {
            get
            {
                return rucEmpresa;
            }

            set
            {
                rucEmpresa = value;
            }
        }
        public string NombreComercial
        {
            get
            {
                return nombreComercial;
            }

            set
            {
                nombreComercial = value;
            }
        }
        public string RazonSocial
        {
            get
            {
                return razonSocial;
            }

            set
            {
                razonSocial = value;
            }
        }
        public string Gerente
        {
            get
            {
                return gerente;
            }

            set
            {
                gerente = value;
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
        public string EmailEmpresa
        {
            get
            {
                return emailEmpresa;
            }

            set
            {
                emailEmpresa = value;
            }
        }
        public DateTime FechaInicioContable
        {
            get
            {
                return fechaInicioContable;
            }

            set
            {
                fechaInicioContable = value;
            }
        }
        public string Celular1Empresa
        {
            get
            {
                return celular1Empresa;
            }

            set
            {
                celular1Empresa = value;
            }
        }
        public string Celular2Empresa
        {
            get
            {
                return celular2Empresa;
            }

            set
            {
                celular2Empresa = value;
            }
        }
        public string RucContador
        {
            get
            {
                return rucContador;
            }

            set
            {
                rucContador = value;
            }
        }
        public string NombreContador
        {
            get
            {
                return nombreContador;
            }

            set
            {
                nombreContador = value;
            }
        }
        public string EmailContador
        {
            get
            {
                return emailContador;
            }

            set
            {
                emailContador = value;
            }
        }
        public string Celular1Contador
        {
            get
            {
                return celular1Contador;
            }

            set
            {
                celular1Contador = value;
            }
        }
        public string Celular2Contador
        {
            get
            {
                return celular2Contador;
            }

            set
            {
                celular2Contador = value;
            }
        }
        public byte[] LogoEmpresa
        {
            get
            {
                return logoEmpresa;
            }

            set
            {
                logoEmpresa = value;
            }
        }
        public byte[] FondoPantallaEmpresa
        {
            get
            {
                return fondoPantallaEmpresa;
            }

            set
            {
                fondoPantallaEmpresa = value;
            }
        }

        public string ClaveSupervisor
        {
            get
            {
                return claveSupervisor;
            }

            set
            {
                claveSupervisor = value;
            }
        }

        public Empresa(string nombreEmpresa, string rucEmpresa, string nombreComercial, string razonSocial, string gerente, string direccion, string email, DateTime fechaInicioContable, string celular1Empresa, string celular2Empresa, string rucContador, string nombreContador, string emailContador, string celular1Contador, string celular2Contador, byte [] logoEmpresa, byte [] fondoPantallaEmpresa, string claveSupervisor)
        {
            this.NombreEmpresa = nombreEmpresa;
            this.RucEmpresa = rucEmpresa;
            this.NombreComercial = nombreComercial;
            this.RazonSocial = razonSocial;
            this.Gerente = gerente;
            this.Direccion = direccion;
            this.EmailEmpresa = email;
            this.FechaInicioContable = fechaInicioContable;
            this.Celular1Empresa = celular1Empresa;
            this.Celular2Empresa = celular2Empresa;
            this.RucContador = rucContador;
            this.NombreContador = nombreContador;
            this.EmailContador = emailContador;
            this.Celular1Contador = celular1Contador;
            this.Celular2Contador = celular2Contador;
            this.LogoEmpresa = logoEmpresa;
            this.FondoPantallaEmpresa = fondoPantallaEmpresa;
            this.claveSupervisor = claveSupervisor;
        }
        public Empresa() { }

        public string Insertarempresa(Empresa ObjEmpresa)
        {
            ObjConsulta = new Consultas();

            if (!ObjConsulta.Existe("RUC", rucEmpresa, "TbEmpresa"))
            {
                if (ObjConsulta.EjecutarPROCEDUREEmpresa(ObjEmpresa))
                {
                    return "Datos Guardados";
                }
                else { return "Error al Registrar"; }
            }
            else { return "Existe"; }
        }

        public string ModificarEmpresa(string RUC)
        {
            ObjConsulta = new Consultas();

            if (ObjConsulta.EjecutarSQL("UPDATE [dbo].[TbEmpresa] SET[NOMBRE] = '"+nombreEmpresa.ToUpper() + "' ,[RUC] = '"+rucEmpresa+ "',[NOMBRECOMERCIAL] = '"+nombreComercial.ToUpper() + "',[RAZONSOCIAL] = '"+razonSocial.ToUpper() + "',[GERENTE] = '"+gerente.ToUpper() + "'"
                + ",[DIRECCION] = '"+direccion.ToUpper() + "' ,[EMAIL] = '"+emailEmpresa+ "',[FECHAINICIOCONTABLE] = '"+Funcion.reemplazarcaracterFecha(fechaInicioContable.ToShortDateString())+ "',[CELULAR1] = '"+celular1Empresa+ "',[CELULAR2] = '"+Celular2Empresa+ "',[RUCCONTADOR] = '"+rucContador+ "',[NOMBRECONTADOR] = '"+nombreContador.ToUpper() + "'"
                + ",[EMAILCONTADOR] = '"+emailContador+ "' ,[CELULAR1CONTADOR] = '"+celular1Contador+ "',[CELULAR2CONTADOR] = '"+celular2Contador+ "',[CLAVESUPERVISOR] = '"+claveSupervisor+"'"
                + " WHERE  RUC = '" + RUC + "'"))
            {
                ObjConsulta.EditarFoto(logoEmpresa, RUC, "[TbEmpresa]", "LOGO", "RUC");
                ObjConsulta.EditarFoto(fondoPantallaEmpresa, RUC, "[TbEmpresa]", "FONDOPANTALLA", "RUC");
                return "Correcto";
            }
            else { return "Error al Modificar"; }
        }
    }
}
