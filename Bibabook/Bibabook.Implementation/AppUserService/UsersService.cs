using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;

namespace Bibabook.Implementation.AppUserService
{
    /// <summary>
    /// Odpowiedzialny za rejestracje, logowanie, role czy blokowanie uzytkowników
    /// </summary>
    public class UsersService : IAppUserService
    {
        public bool CreateAccount(IAppUser user)
        {
            throw new NotImplementedException();
        }

        public bool VerifyAccount(IAppUser appUser)
        {
            throw new NotImplementedException();
        }

        public bool CloseAccount(IAppUser appUser)
        {
            throw new NotImplementedException();
        }

        public bool BanUser(IAppUser appUser, DateTime expirationDate)
        {
            throw new NotImplementedException();
        }

        public bool ChangeUserRole(IAppUser appUser, string roleName)
        {
            throw new NotImplementedException();
        }

        public bool ChangeUserEmail(IAppUser appUser, string newEmail)
        {
            throw new NotImplementedException();
        }

        public bool ChangeUserPassword(IAppUser appUser, string newPassword)
        {
            throw new NotImplementedException();
        }

        public bool ChangeUserAvatar(IAppUser appUser, string newAvatarPath)
        {
            throw new NotImplementedException();
        }
    }
}
