using System;

namespace Contract
{
    public interface IEmail
    {
        DateTime Date { get; set; }
        String RecipientEmail { get; set; }
        String Subject { get; set; }
        String Content { get; set; }
    }
}