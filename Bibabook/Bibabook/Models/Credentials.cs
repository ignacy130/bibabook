﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibabook.Models
{
    public class Credentials
    {
        public string Hash { get; set; }
        public string Salt { get; set; }
    }
}