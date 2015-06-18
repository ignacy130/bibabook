using System;

namespace Contract
{
    /// <summary>
    /// Zawiera metody związane z obsługą kont użytkowników.
    /// </summary>
    public interface IAppUserService
    {
        /// <summary>
        /// Dodaje użytkownika do bazy danych.
        /// </summary>
        /// <param name="user">Dodawany użytkownik</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean CreateAccount(IAppUser user);

        /// <summary>
        /// Ustawia konto jako aktywne w momencie jego aktywacji podczas rejestracji. Użytkownik
        /// aktywny będzie miał dostęp do odpowiednich funkcji serwisu.
        /// </summary>
        /// <param name="appUser">Instancja użytkownika</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w p.p.</returns>
        Boolean VerifyAccount(IAppUser appUser);

        Boolean CloseAccount(IAppUser appUser);

        /// <summary>
        /// Użytkownik stanie się nieaktywny do podanego terminu. Nie będzie mógł przez ten czas
        /// korzystać z funkcji serwisu. Funkcja ta powinna być dostępna tylko dla moderatorów.
        /// </summary>
        /// <param name="appUser">Instancja użytkownika</param>
        /// <param name="expirationDate">Czas wygaśnięcia blokady</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w p.p.</returns>
        Boolean BanUser(IAppUser appUser, DateTime expirationDate);

        Boolean ChangeUserRole(IAppUser appUser, String roleName);
        Boolean ChangeUserEmail(IAppUser appUser, String newEmail);
        Boolean ChangeUserPassword(IAppUser appUser, String newPassword);
        Boolean ChangeUserAvatar(IAppUser appUser, String newAvatarPath);

        bool Login(string email, string passwordInserted);
    }
}
