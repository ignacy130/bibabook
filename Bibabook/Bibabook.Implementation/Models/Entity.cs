﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibabook.Implementation.Models
{
    public class Entity
    {
        //public Guid EntityID { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }
    }
}