using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using Bibabook.Implementation.Models;

namespace Bibabook.Implementation.EmailService
{
    public class EmailService : IEmailService
    {
        private System.Net.Mail.SmtpClient client;

        public System.Net.Mail.SmtpClient Client
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
            }
        }

        public EmailService() { }


        public IEmail CreateEmail(string receiverEmailAddress, string subject, string message)
        {
            IEmail email = new Email()
            {
                Content = message,
                Date = DateTime.Now,
                EmailID = Guid.NewGuid(),
                RecipientEmail = receiverEmailAddress,
                Subject = subject
            };
            return email;
        }

        public bool SendEmail(IEmail email)
        {
            try
            {
                Client.Send("Bibabook", email.RecipientEmail, email.Subject, email.Content);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SendEmail(ICollection<string> receiversEmailAddresses, string subject, string message)
        {
            List<string> receivers = receiversEmailAddresses.ToList();
            bool result = false;

            foreach (string receiver in receivers)
            {
                Email email = new Email()
                {
                    Content = message,
                    Subject = subject,
                    Date = DateTime.Now,
                    EmailID = Guid.NewGuid(),
                    RecipientEmail = receiver
                };
                result = SendEmail(email);
            }
            return result;
        }
    }
}
