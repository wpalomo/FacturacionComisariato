using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloFacturacionElectronica.Class
{
    class EnviarCorreo
    {
        MailMessage correos = new MailMessage();
        SmtpClient envios = new SmtpClient();

        public void enviarCorreo(string emisor, string password, string mensaje, string asunto, string destinatario, string rutaXML, string rutaRide)
        {
            try
            {
                //correos.To.Clear();
                //correos.Body = "";
                //correos.Subject = "";
                //correos.Body = mensaje;
                //correos.BodyEncoding = System.Text.Encoding.UTF8;

                //correos.Subject = asunto;
                //correos.SubjectEncoding = System.Text.Encoding.UTF8;
                ////correos.IsBodyHtml = true;
                //correos.IsBodyHtml = false;
                //correos.To.Add(destinatario.Trim());


                //if (rutaXML.Equals("") == false)
                //{
                //    System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(rutaXML);
                //    correos.Attachments.Add(archivo);
                //}
                //if (rutaRide.Equals("") == false)
                //{
                //    System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(rutaRide);
                //    correos.Attachments.Add(archivo);
                //}

                //correos.From = new MailAddress(emisor);
                //envios.Credentials = new NetworkCredential(emisor, password);

                ////Datos importantes no modificables para tener acceso a las cuentas

                ////envios.Host = "smtp.gmail.com";
                //envios.Host = "smtp.live.com";
                //envios.Port = 587;
                ////envios.Port = 587;
                //envios.EnableSsl = true;

                //envios.Send(correos);
                ////MessageBox.Show("Documentos enviados correctamente", "Notificación de Envió por Correo");
            }
            catch (Exception ex)
            {
               // MessageBox.Show("No se envio el correo correctamente \n" + ex.Message, "Notificación de Envió por Correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
