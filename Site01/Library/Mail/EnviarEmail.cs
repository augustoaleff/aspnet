using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Site01.Library.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagemContato(Contato contato)
        {

            string conteudo = string.Format("<br /> Nome: {0}<br /> Email: {1}<br />  Assunto: {2}<br />  Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

            //Configurar servidor SMTP
            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortaSMTP)
            {
                EnableSsl = true,

                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha)
            };

            //Mensagem de Email
            MailMessage mensagem = new MailMessage();
            mensagem.To.Add("augustoaleff@icloud.com");
            mensagem.From = new MailAddress("augustoaleff@gmail.com");
            mensagem.Subject = "Formulário de Contato";
            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulário de Contato</h1>" + conteudo;

            smtp.Send(mensagem);


        }
    }
}
