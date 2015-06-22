using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contract;
using Contract.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bibabook.Implementation.Models
{
    public class AppEvent : Entity, IAppEvent
    {
        public Guid AppEventID { get; set; }

        [DisplayName("Nazwa wydarzenia")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string Name { get; set; }

        [DisplayName("Opis")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string Description { get; set; }

        [DisplayName("Tylko dorośli")]
        public bool AdultsOnly { get; set; }

        [DisplayName("Data początku")]
        [DataType(DataType.DateTime,ErrorMessage="Zły format daty")]
        [DisplayFormat(DataFormatString="0:dd/MM/yyyy")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public DateTime TimeStart { get; set; }

        [DisplayName("Data końca")]
        [DataType(DataType.DateTime, ErrorMessage = "Zły format daty")]
        [DisplayFormat(DataFormatString = "0:dd/MM/yyyy")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public DateTime TimeEnd { get; set; }

        [DisplayName("Gospodarz")]
        public virtual AppUser Host { get; set; }
        public virtual List<AppUser> Guests { get; set; }
        public virtual List<EventPost> Posts { get; set; }

        [DisplayName("Cena za wejście")]
        public Decimal EntryFee { get; set; }
        public bool IsActive { get; set; }
        public Privacy Privacy { get; set; }

        [DisplayName("Tło")]
        public string Background { get; set; }
    }
}