using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract._DataInterfaces
{
    public interface IEmail
    {
        DateTime Date { get; set; }
        string RecipientEmail { get; set; }
        string SenderEmail { get; set; }
        string Subject { get; set; }
        string Content { get; set; }
    }
}
