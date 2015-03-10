using Contract._DataInterfaces;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Contract
{
    /// <summary>
    /// Umożliwia wysłanie maila z konta systemu.
    /// </summary>
    public interface IEmailService
    {
        /// <summary>
        /// Wykorzystywany klient smtp
        /// </summary>
        SmtpClient Client { get; set; }

        /// <summary>
        /// Wysyła e-mail z konta systemu.
        /// </summary>
        /// <param name="email">Email to be sent.</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean SendEmail(IEmail email);

        /// <summary>
        /// Creates email.
        /// </summary>
        /// <param name="receiverEmailAddress">Recipient email address.</param>
        /// <param name="senderEmailAddress">Sender email address</param>
        /// <param name="subject">Subject of email</param>
        /// <param name="message">Content of email</param>
        /// <returns></returns>
        IEmail CreateEmail(String receiverEmailAddress, String senderEmailAddress, String subject, String message);

        /// <summary>
        /// Wysyła e-mail z konta systemu.
        /// </summary>
        /// <param name="receiverEmailAddress">Adresy odbiorców</param>
        /// <param name="subject">Temat wiadomości</param>
        /// <param name="message">Treść</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean SendEmail(ICollection<String> receiversEmailAddresses, String subject, String message);
    }
}