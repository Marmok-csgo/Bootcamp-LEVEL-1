using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_T1
{
    public class EmailTemplate
    {
        public string Subject {  get; set; }
        public string Content { get; set; }

        public EmailTemplate(string subject, string content)
        {
            if (string.IsNullOrWhiteSpace(subject))
            {
                throw new ArgumentNullException("Invalid subject");
            }

            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentNullException("Invalid content");
            }
            Subject = subject;
            Content = content;
        }
    }
}
