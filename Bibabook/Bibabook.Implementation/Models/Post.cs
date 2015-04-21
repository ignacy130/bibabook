using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contract;
using System.ComponentModel.DataAnnotations;

namespace Bibabook.Implementation.Models
{
    public class Post : Entity, IPostComment
    {
        public Guid PostID { get; set; }
        [StringLength(3000)]
        public string Content{get;set;}
        public virtual ICollection<Comment> Comments { get; set; }
    }
}