using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibabook.Models
{
    public class Place : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public AppUser Owner { get; set; }
        public GeoCoordinate Location { get; set; } 
        public int Capacity { get; set; }
        public virtual ICollection<AppEvent> Events { get; set; }
    }
}