using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;

namespace Bibabook.Implementation.AppUserService
{
    /// <summary>
    /// Odpowiedzialny za obsluge maili.
    /// </summary>
    public class EmailUsersService : IAppUserEmailService
    {
        public IEmailService EmailService
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

        public bool SendRegistrationVerificationEmail(string receiverEmailAddress, string userName, string userAccountActivationLink)
        {
            throw new NotImplementedException();
        }

        public bool RetrievePassword(string receiverEmailAddress, string userName, string userPassword)
        {
            throw new NotImplementedException();
        }

        public bool SendInvitation(string receiverEmailAddress, string userName, string eventName)
        {
            throw new NotImplementedException();
        }
    }
}
