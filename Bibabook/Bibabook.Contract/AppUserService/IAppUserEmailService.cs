using System;

namespace Contract
{
    /// <summary>
    /// Zapewnia funkcjonalność użytkownika związaną z otrzymywaniem lub wysyłaniem e-maili.
    /// </summary>
    public interface IAppUserEmailService
    {
        /// <summary>
        /// Wykorzystywany serwis wysyłania wiadomości.
        /// </summary>
        IEmailService EmailService { get; set; }

        /// <summary>
        /// Wysyła e-mail z linkiem do aktywacji konta.
        /// </summary>
        /// <param name="receiverEmailAddress">Adres odbiorcy</param>
        /// <param name="userName">Nazwa aktywowanego konta</param>
        /// <param name="userAccountActivationLink">Link aktywacyjny</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean SendRegistrationVerificationEmail(String receiverEmailAddress, String userName, String userAccountActivationLink);

        /// <summary>
        /// Wysyła e-mail z hasłem użytkownika.
        /// </summary>
        /// <param name="receiverEmailAddress">Adres odbiorcy</param>
        /// <param name="userName">Nazwa konta</param>
        /// <param name="userPassword">Hasło użytkownika</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean RetrievePassword(String receiverEmailAddress, String userName, String userPassword);

        /// <summary>
        /// Wysyła e-mail zachęcający do wzięcia udziału w wydarzeniu na podany adres.
        /// </summary>
        /// <param name="receiverEmailAddress">Adres odbiorcy</param>
        /// <param name="userName">Nazwa zapraszającego</param>
        /// <param name="eventName">Nazwa wydarzenia</param>
        /// <returns></returns>
        Boolean SendInvitation(String receiverEmailAddress, String userName, String eventName);
    }
}
