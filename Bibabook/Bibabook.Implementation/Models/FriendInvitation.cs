using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibabook.Implementation.Models
{
    public class FriendInvitation : Entity
    {
        public Guid FriendInvitationID { get; set; }
        public AppUser Sender { get; set; }
        public AppUser Recipient { get; set; }

    }
    
}