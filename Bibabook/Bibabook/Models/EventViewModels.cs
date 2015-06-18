using Bibabook.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibabook.Models
{
    public class EventCreateViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool AdultsOnly { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public Decimal EntryFee { get; set; }
        public string Background { get; set; }
    }

    public class EventDetailsViewModel
    {
        public bool Enrolled { get; set; }
        public Guid AppEventID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool AdultsOnly { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public AppUser Host { get; set; }
        public virtual List<AppUser> Guests { get; set; }
        public virtual List<EventPost> Posts { get; set; }
        public Decimal EntryFee { get; set; }
        public bool IsActive { get; set; }
        public string Background { get; set; }
    }

    public class EventSummaryModel
    {
        public Guid AppEventID { get; set; }
        public string Name { get; set; }
        public bool AdultsOnly { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public bool IsActive { get; set; }
    }

    public class EventEditViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool AdultsOnly { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public Decimal EntryFee { get; set; }
        public AppUser Host { get; set; }
        public string Background { get; set; }
    }
}