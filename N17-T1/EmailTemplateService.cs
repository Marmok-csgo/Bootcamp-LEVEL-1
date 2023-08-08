using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_T1
{
    public class EmailTemplateService
    {
        List<EmailTemplate> TemplatesList = new List<EmailTemplate>();

        public void Add(EmailTemplate temp)
        {
            TemplatesList.Add(temp);
        }


        public void GetRegistrationTemplate(string name)
        {
            foreach (var template in TemplatesList)
            {
                if(template.Subject.Contains("Registration", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(template.Content.Replace("{{User}}", name));
                }
            }
        }

        public void GetAccountBlockedTemplate(string name)
        {
            foreach (var template in TemplatesList)
            {
                if(template.Subject.Contains("Blocked", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(template.Content.Replace("{{User}}", name));
                }
            }
        }
    }
}
