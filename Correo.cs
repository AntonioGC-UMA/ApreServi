using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;


namespace ApreServi
{
    static class Correo
    {
        public static void Enviar(string direccion, string asunto, string cuerpo)
        {
            var fromAddress = new MailAddress("apreservi@gmail.com", "ApreServi");
            var toAddress = new MailAddress(direccion, "To User");
            
            const string fromPassword = "ApreServi1234";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };

            var message = new MailMessage(fromAddress, toAddress);
            message.Subject = asunto;
            message.Body = cuerpo;

            smtp.Send(message);
        }
    }
}
