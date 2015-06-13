using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contract;
using Contract.Enums;

namespace Bibabook.Implementation.Models
{

    public class AppUser : Entity, IAppUser
    {
        public Guid AppUserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public Credentials Credentials { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
        public bool IsVerified { get; set; }
        public bool IsActive { get; set; }
        public string Avatar { get; set; }
        public virtual ICollection<AppUser> Friends { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<AppEvent> Events { get; set; }
        public virtual ICollection<EventPost> Posts { get; set; }

        public AppUser()
        {
            this.Friends = new List<AppUser>();
            this.Events = new List<AppEvent>();
            this.Posts = new List<EventPost>();
        }

    }
}
