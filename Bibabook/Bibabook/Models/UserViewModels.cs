using Bibabook.Implementation.Models;
using Contract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibabook.Models.ViewModels
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
    }

    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserProfileViewModel
    {
        public Guid AppUserID { get; set; }
        public bool IsSelf { get; set; }
        public bool IsFriend { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
        public string Avatar { get; set; }
        public ICollection<AppUser> Friends { get; set; }
        public ICollection<AppEvent> Events { get; set; }
    }

    public class UserSummaryModel
    {
        public Guid AppUserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Avatar { get; set; }
    }

    public class ChangePasswordViewModel
    {
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirm { get; set; }
    }

    public class EditProfileViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
    }
}