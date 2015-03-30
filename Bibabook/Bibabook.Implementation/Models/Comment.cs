using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contract;

namespace Bibabook.Models
{
    public class Comment : Entity, IEventPost, IPostComment
    {
        public string Content { get; set; }
    }
}