using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contract;

namespace Bibabook.Models
{
    public class Notification : Entity, INotification
    {
        public string Json { get; set; }
        public bool Receivied { get; set; }
    }
}
