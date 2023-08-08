using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace N16_T1
{
    internal class EmailService
    {
        public EmailService(string credentialaddress, string credentialpassword, string name)
        {
            CredentialAddress = credentialaddress;
            CredentialPassword = credentialpassword;
            Name = name;
        }
        public string CredentialAddress { get; init; }
        public string CredentialPassword { get; init; }
        public string Name { get; init; }

        public void SendEmail(string ToEmail, string name)
        {
            var senderEmail = "sultonbek.rakhimov.recovery@gmail.com";
            var senderPassword = "szabguksrhwsbtie";

            var mail = new MailMessage(senderEmail, ToEmail);
            mail.Subject = "Siz muvaffaqiyatli registratsiyadan o'tdingiz";
            mail.Body = $"Hurmatli {name}, siz sistemadan muvaffaqiyatli o'tdingiz";

            var smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.EnableSsl = true;

            smtpClient.Send(mail);
        }
    }
}
