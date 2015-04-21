using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using System.ComponentModel.DataAnnotations;

namespace Bibabook.Implementation.Models
{
    public class Email : IEmail
    {
        public Guid EmailID { get; set; }
        public DateTime Date { get; set; }
        public string RecipientEmail { get; set; }
        public string Subject { get; set; }
        [StringLength(3000)]
        public string Content { get; set; }
    }
}
