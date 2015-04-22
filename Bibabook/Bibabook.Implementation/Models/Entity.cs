using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bibabook.Implementation.Models
{
    public class Entity
    {
        
        public virtual Guid EntityID { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual DateTime Modified { get; set; }
        public virtual bool Deleted { get; set; }
    }
}