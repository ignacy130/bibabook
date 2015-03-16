using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;

namespace Bibabook.Implementation.AppUserService
{
    public class AppUserSocialService : IAppUserSocialService
    {
        public bool SendFriendInvitation(IAppUser sender, IAppUser receiver)
        {
            throw new NotImplementedException();
        }

        public bool FriendUsers(IAppUser firstUser, IAppUser secondUser)
        {
            throw new NotImplementedException();
        }

        public bool UnfriendUsers(IAppUser firstUser, IAppUser secondUser)
        {
            throw new NotImplementedException();
        }
    }
}
