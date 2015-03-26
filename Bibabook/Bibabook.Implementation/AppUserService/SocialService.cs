using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;

namespace Bibabook.Implementation.AppUserService
{
    /// <summary>
    /// Odpowiedzialny za wysylanie zaproszen do grona znajomych oraz dodawanie i usuwanie znajomych
    /// </summary>
    public class SocialService : IAppUserSocialService
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
