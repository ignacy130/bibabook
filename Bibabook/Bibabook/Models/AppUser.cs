using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contract;

namespace Bibabook.Models
{
    public class AppUser : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public Credentials Credentials { get; set; } 
        public DateTime Birthday { get; set; }
        public enum Sex { Male, Female } 
        public virtual ICollection<AppUser> Friends { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<AppEvent> Events { get; set; }
        public virtual ICollection<IEventPost> Posts { get; set; }
    }
}