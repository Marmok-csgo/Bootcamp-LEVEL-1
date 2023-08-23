using System.Net;
using System.Net.Mail;

namespace N29_HT2;

public class EmailService
{
    public SmtpClient SmtpClientInstance { get; set; }

    public EmailService()
    {
        SmtpClientInstance = new SmtpClient("smtp.gmail.com", 587);
        SmtpClientInstance.Credentials = new NetworkCredential("ferferrolaniajali@gmail.com", "ysfkcmkrjzefcxey");
        SmtpClientInstance.EnableSsl = true;
    }

    public Task<bool> SendAsync(string receiverEmailAddress, string subject, string body)
    {
        return Task.Run(async () =>
        {
            var result = true;
            try
            {
                var smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("ferferrolaniajali@gmail.com", "ysfkcmkrjzefcxey");
                smtp.EnableSsl = true;

                var mail = new MailMessage("ferferrolaniajali@gmail.com", receiverEmailAddress);
                mail.Subject = subject;
                mail.Body = body;
                await smtp.SendMailAsync(mail);
            }
            catch (Exception e)
            {
                return false;
            }

            return result;
        });
    }
}