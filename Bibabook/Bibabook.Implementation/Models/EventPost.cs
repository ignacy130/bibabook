using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using System.ComponentModel.DataAnnotations;

namespace Bibabook.Implementation.Models
{
    public class EventPost : IEventPost
    {
        [StringLength(3000)]
        public string Content
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
