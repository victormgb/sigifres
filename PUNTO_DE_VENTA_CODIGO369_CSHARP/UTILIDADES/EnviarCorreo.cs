using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Drawing;

namespace PUNTO_DE_VENTA_CODIGO369_CSHARP.UTILIDADES
{
    class EnviarCorreo
    {
        private static string emisor = "victortesting3099@gmail.com";
        private static string password = "secretA\"";
        public static bool recuperarContrasena(string mensaje, string asunto, string destinatario)
        {
            try
            {
                

                MailMessage correos = new MailMessage();
                SmtpClient envios = new SmtpClient();
                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = mensaje;
                correos.Subject = asunto;
                correos.IsBodyHtml = true;
                correos.To.Add((destinatario));
                correos.From = new MailAddress(emisor);
                envios.Credentials = new NetworkCredential(emisor, password);
                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true;
                envios.Send(correos);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR, revisa tu correo Electronico", "Restauracion de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

        }
    }
}
