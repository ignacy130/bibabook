using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bibabook.Implementation.Models
{
    public class Place : Entity
    {
        public string Name { get; set; }
        [StringLength(3000)]
        public string Description { get; set; }
        public AppUser Owner { get; set; }
        public GeoCoordinate Location { get; set; } 
        public int Capacity { get; set; }
        public virtual ICollection<AppEvent> Events { get; set; }
    }
}