using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;

namespace Bibabook.Implementation.EmailService
{
    public class EmailService : IEmailService
    {
        public System.Net.Mail.SmtpClient Client
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IEmail CreateEmail(string receiverEmailAddress, string subject, string message)
        {
            throw new NotImplementedException();
        }

        public bool SendEmail(IEmail email)
        {
            throw new NotImplementedException();
        }

        public bool SendEmail(ICollection<string> receiversEmailAddresses, string subject, string message)
        {
            throw new NotImplementedException();
        }
    }
}
