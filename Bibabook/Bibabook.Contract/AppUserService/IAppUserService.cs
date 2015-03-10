using System;

namespace Contract
{
    /// <summary>
    /// Zawiera metody związane z obsługą kont użytkowników.
    /// </summary>
    public interface IAppUserService
    {
        /// <summary>
        /// Creates user in database.
        /// </summary>
        /// <param name="user">User to be created.</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean CreateAccount(IAppUser user);

        /// <summary>
        /// Ustawia konto jako aktywne w momencie jego aktywacji podczas rejestracji. Użytkownik
        /// aktywny będzie miał dostęp do odpowiednich funkcji serwisu.
        /// </summary>
        /// <param name="appUserId">Unikalny identyfikator użytkonika (GUID)</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w p.p.</returns>
        Boolean VerifyAccount(String appUserId);

        Boolean CloseAccount(String appUserId);

        /// <summary>
        /// Użytkownik stanie się nieaktywny do podanego terminu. Nie będzie mógł przez ten czas
        /// korzystać z funkcji serwisu. Funkcja ta powinna być dostępna tylko dla moderatorów.
        /// </summary>
        /// <param name="appUserId">Unikalny identyfikator użytkonika (GUID)</param>
        /// <param name="expirationDate">Czas wygaśnięcia blokady</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w p.p.</returns>
        Boolean BanUser(String appUserId, DateTime expirationDate);

        Boolean ChangeUserRole(String appUserId, String roleName);
        Boolean ChangeUserEmail(String appUserId, String newEmail);
        Boolean ChangeUserPassword(String appUserId, String newPassword);
        Boolean ChangeUserAvatar(String appUserId, String newAvatarPath);
    }
}
