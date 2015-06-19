using Bibabook.Implementation.Models;
using Contract.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bibabook.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Zły adres e-mail")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Hasło")]
        [DataType(DataType.Password, ErrorMessage = "Hasło musi zawierać znak specjalny")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Potwierdź hasło")]
        [DataType(DataType.Password, ErrorMessage = "Hasło musi się zgadzać")]
        [Compare("Password", ErrorMessage = "Hasło musi się zgadzać")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Data urodzin")]
        [DataType(DataType.DateTime, ErrorMessage = "Zła data")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Płeć jest wymagana")]
        [Display(Name = "Płeć")]
        public Sex Sex { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Display(Name = "Zapamiętaj mnie")]
        public bool RememberMe { get; set; }
    }

    public class ResetPasswordProfileViewModel
    {
        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress,ErrorMessage="Zły adres email")]
        public string Email { get; set; }
    }

    //public class UserProfileViewModel
    //{
    //    public Guid AppUserID { get; set; }

    //    public bool IsSelf { get; set; }
    //    public bool IsFriend { get; set; }

    //    [Required(ErrorMessage = "Pole jest wymagane")]
    //    [Display(Name = "Imię")]
    //    public string Name { get; set; }

    //    [Required(ErrorMessage = "Pole jest wymagane")]
    //    [Display(Name = "Nazwisko")]
    //    public string Surname { get; set; }

    //    [Required(ErrorMessage = "Pole jest wymagane")]
    //    [Display(Name = "Hasło")]
    //    [DataType(DataType.Password, ErrorMessage = "Hasło musi zawierać znak specjalny")]
    //    public string Email { get; set; }

    //    [Required(ErrorMessage = "Pole jest wymagane")]
    //    [Display(Name = "Data urodzin")]
    //    [DataType(DataType.DateTime, ErrorMessage = "Zła data")]
    //    public DateTime Birthday { get; set; }

    //    [Required(ErrorMessage = "Płeć jest wymagana")]
    //    [Display(Name = "Płeć")]
    //    public Sex Sex { get; set; }
    //    public string Avatar { get; set; }
    //    public ICollection<UserSummaryModel> Friends { get; set; }
    //    public ICollection<EventSummaryModel> Events { get; set; }
    //}

    public class UserSummaryModel
    {
        public Guid AppUserID { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Imie")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        public string Avatar { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Hasło")]
        [DataType(DataType.Password, ErrorMessage = "Hasło musi zawierać znak specjalny")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Hasło")]
        [DataType(DataType.Password, ErrorMessage = "Hasło musi zawierać znak specjalny")]
        public string NewPassword { get; set; }
       
        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Hasło")]
        [DataType(DataType.Password, ErrorMessage = "Hasło musi zawierać znak specjalny")]
        [Compare("Password", ErrorMessage = "Hasło musi się zgadzać")]
        public string NewPasswordConfirm { get; set; }
    }

    public class EditProfileViewModel
    {
        public Guid AppUserID { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Data urodzin")]
        [DataType(DataType.DateTime, ErrorMessage = "Zła data")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Płeć jest wymagana")]
        [Display(Name = "Płeć")]
        public Sex Sex { get; set; }
    }
}