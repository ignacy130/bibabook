using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contract;
using Contract.Enums;

namespace Bibabook.Implementation.Models
{
    public class AppEvent : Entity, IAppEvent
    {
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
        public Privacy Privacy { get; set; }
        public string Background { get; set; }
    }
}