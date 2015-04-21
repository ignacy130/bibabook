using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contract;
using System.ComponentModel.DataAnnotations;

namespace Bibabook.Implementation.Models
{
    public class Notification : Entity, INotification
    {
    
        public Guid NotificationID { get; set; }
        [StringLength(3000)]
        public string Json { get; set; }
        public bool Receivied { get; set; }
    }
}
