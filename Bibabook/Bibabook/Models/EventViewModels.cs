using Bibabook.Implementation.Models;
using Contract;
using Contract.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bibabook.Models.ViewModels
{
    public class EventCreateViewModel
    {
        [DisplayName("Nazwa wydarzenia")]
        [Required(ErrorMessage="Pole jest wymagane")]
        public string Name { get; set; }

        [DisplayName("Opis")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string Description { get; set; }

        [DisplayName("Tylko dorośli")]
        public bool AdultsOnly { get; set; }

        [DisplayName("Data początku")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public DateTime TimeStart { get; set; }

        [DisplayName("Data końca")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public DateTime TimeEnd { get; set; }

        [DisplayName("Cena za wejście")]
        public Decimal EntryFee { get; set; }

        [DisplayName("Tło")]
        public string Background { get; set; }

        [DisplayName("Dostepnosc")]
        public Privacy Privacy { get; set; }

    }

    public class EventDetailsViewModel
    {
        public EventDetailsViewModel(AppEvent model)
        {
            AppEventID = model.AppEventID;
            Name = model.Name;
            Description = model.Description;
            AdultsOnly = model.AdultsOnly;
            TimeStart = model.TimeStart;
            TimeEnd = model.TimeEnd;
            Host = model.Host;
            Guests = model.Guests;
            Posts = model.Posts;
            EntryFee = model.EntryFee;
            IsActive = model.IsActive;
            Background = model.Background;
        }

        public bool Enrolled { get; set; }

        [DisplayName("Numer id wydarzenia")]
        public Guid AppEventID { get; set; }

        [DisplayName("Nazwa wydarzenia")]
        public string Name { get; set; }

        [DisplayName("Opis")]
        public string Description { get; set; }

        [DisplayName("Tylko dorośli")]
        public bool AdultsOnly { get; set; }

        [DisplayName("Data początku")]
        public DateTime TimeStart { get; set; }

        [DisplayName("Data końca")]
        public DateTime TimeEnd { get; set; }

        [DisplayName("Gospodarz")]
        public AppUser Host { get; set; }

        public virtual List<AppUser> Guests { get; set; }

        public virtual List<EventPost> Posts { get; set; }

        [DisplayName("Cena za wejście")]
        public Decimal EntryFee { get; set; }

        [DisplayName("Aktywne")]
        public bool IsActive { get; set; }

        [DisplayName("Tło")]
        public string Background { get; set; }

    }

    public class EventSummaryViewModel
    {
        public EventSummaryViewModel(AppEvent model)
        {
            AppEventID = model.AppEventID;
            Name = model.Name;
            AdultsOnly = model.AdultsOnly;
            TimeStart = model.TimeStart;
            TimeEnd = model.TimeEnd;
            IsActive = model.IsActive;
        }

        public Guid AppEventID { get; set; }

        [DisplayName("Nazwa wydarzenia")]
        public string Name { get; set; }

        [DisplayName("Tylko dorośli")]
        public bool AdultsOnly { get; set; }

        [DisplayName("Data początku")]
        public DateTime TimeStart { get; set; }

        [DisplayName("Data końca")]
        public DateTime TimeEnd { get; set; }

        [DisplayName("Aktywne")]
        public bool IsActive { get; set; }

    }

    public class EventEditViewModel
    {
        public Guid AppEventID { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [DisplayName("Imię")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [DisplayName("Opis")]
        public string Description { get; set; }

        [DisplayName("Tylko dorośli")]
        public bool AdultsOnly { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [DisplayName("Data początku")]
        [DataType(DataType.DateTime)]
        public DateTime TimeStart { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [DisplayName("Data końca")]
        [DataType(DataType.DateTime)]
        public DateTime TimeEnd { get; set; }

        [DisplayName("Cena za wejście")]
        public Decimal EntryFee { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [DisplayName("Gospodarz")]
        public AppUser Host { get; set; }

        [DisplayName("Tło")]
        public string Background { get; set; }
    }
}