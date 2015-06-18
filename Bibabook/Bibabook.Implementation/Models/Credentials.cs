using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibabook.Implementation.Models
{
    public class Credentials
    {
        public Guid CredentialsID { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
        public Guid AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}