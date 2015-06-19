using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contract;
using Contract.Enums;
using System.ComponentModel.DataAnnotations;

namespace Bibabook.Implementation.Models
{
    public class AppUser : Entity, IAppUser
    {
        public Guid AppUserID { get; set; }

        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }

        public string Hash { get; set; }

        public int Salt { get; set; }

        public Guid CredentialsID { get; set; }

        [Display(Name = "Data urodzenia")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Płeć")]
        public Sex Sex { get; set; }

        [Display(Name = "Zdjęcie profilowe")]
        public string Avatar { get; set; }

        [Display(Name = "Znajomi")]
        public virtual ICollection<AppUser> Friends { get; set; }

        [Display(Name = "Powiadomienia")]
        public virtual ICollection<Notification> Notifications { get; set; }

        [Display(Name = "Wydarzenia użytkownika")]
        public virtual ICollection<AppEvent> Events { get; set; }

        [Display(Name = "Komentarze")]
        public virtual ICollection<EventPost> Posts { get; set; }

        //public bool IsVerified { get; set; }
        //public bool IsActive { get; set; }
    }
}
