using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibabook.Models
{
    public class Notification : Entity
    {
        public string Json { get; set; }
        public bool Receivied { get; set; }
    }
}
