using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Bankingsystem.Services
{
    public class EmailSender :IEmailSender
    {
        private string host;
        private int port;
        private bool enableSSL;
        private string userName;
        private string password;
        private string fromEmail;
        public EmailSender(string host, int port, bool enableSSL, string userName, string password, string fromEmail)
        {
            this.host = host;
            this.port = port;
            this.enableSSL = enableSSL;
            this.userName = userName;
            this.password = password;
            this.fromEmail = fromEmail;
        }
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(email, subject, message);
        }
        public Task Execute(string email, string subject, string message)
        {
            var client = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(userName, password),
                EnableSsl = enableSSL
            };

            return client.SendMailAsync(
                new MailMessage(fromEmail, email, subject, message) { IsBodyHtml = true }
            );
        }
    }
}
