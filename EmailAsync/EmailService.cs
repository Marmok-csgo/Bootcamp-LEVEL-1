using System.Net;
using System.Net.Mail;

namespace EmailAsync;

public class EmailService
{
    public SmtpClient SmtpClientInstance { get; set; }

    public EmailService()
    {
        SmtpClientInstance = new SmtpClient("smtp.gmail.com", 587);
        SmtpClientInstance.Credentials = new NetworkCredential("ferferrolaniajali@gmail.com", "ysfkcmkrjzefcxey");
        SmtpClientInstance.EnableSsl = true;
    }

    public bool SendAsync(string receiverEmailAddress, string subject, string body)
    {
        var mail = new MailMessage("g'ishmat@gmail.com", receiverEmailAddress);
        mail.Subject = subject;
        mail.Body = body;
        
        // SmtpClientInstance.Send(mail);

        var test = File.ReadAllLinesAsync("");
        
        
        return true;
    }
}



































