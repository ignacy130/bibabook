using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contract;

namespace Bibabook.Models
{
    public class Post : Entity, IEventPost
    {       
        public string Content{get;set;}
        public virtual ICollection<Comment> Comments { get; set; }

    }
}