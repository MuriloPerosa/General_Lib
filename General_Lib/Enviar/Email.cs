using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace General_Lib.Enviar
{
    public class Email
    {
        /// <summary>
        /// Envia e-mail com texto simples. Por default através do gmail.
        /// </summary>
        /// <param name="destinatario"></param>
        /// <param name="remetente"></param>
        /// <param name="assunto"></param>
        /// <param name="mensagem"></param>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <param name="host"></param>
        /// <param name="port"></param>
        public static void SimpleText(string destinatario, string remetente, string assunto,
            string mensagem, string usuario, string senha, string host = "smtp.gmail.com", int port = 587)
        {
            MailMessage mensagemEmail = new MailMessage(remetente, destinatario, assunto, mensagem);
            SmtpClient client = new SmtpClient(host, port);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            NetworkCredential cred = new NetworkCredential(usuario, senha);
            client.Credentials = cred;
            client.Send(mensagemEmail);
        }
    }
}
