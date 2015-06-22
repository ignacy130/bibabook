using Bibabook.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibabook.Models
{
    public class ProfileViewModel
    {
        public AppUser AppUser { get; set; }
        public List<AppEvent> EventsParticipating { get; set; }
    }
}