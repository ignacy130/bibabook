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
        /// Tworzy wiadomość e-mail.
        /// </summary>
        /// <param name="receiverEmailAddress">Adres e-mail odbiorcy</param>
        /// <param name="subject">Temat wiadomości</param>
        /// <param name="message">Treść</param>
        /// <returns>Nowy e-mail</returns>
        IEmail CreateEmail(String receiverEmailAddress, String subject, String message);

        /// <summary>
        /// Wysyła e-mail z konta systemu.
        /// </summary>
        /// <param name="email">Wysyłany e-mail</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean SendEmail(IEmail email);

        /// <summary>
        /// Wysyła e-mail z konta systemu.
        /// </summary>
        /// <param name="receiversEmailAddresses">Adresy odbiorców</param>
        /// <param name="subject">Temat wiadomości</param>
        /// <param name="message">Treść</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean SendEmail(ICollection<String> receiversEmailAddresses, String subject, String message);
    }
}