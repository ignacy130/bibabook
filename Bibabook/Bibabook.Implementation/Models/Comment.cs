﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contract;
using System.ComponentModel.DataAnnotations;

namespace Bibabook.Implementation.Models
{
    public class Comment : Entity, IEventPost, IPostComment
    {
        [StringLength(3000)]
        public string Content { get; set; }
    }
}