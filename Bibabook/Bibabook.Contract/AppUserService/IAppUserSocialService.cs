using System;

namespace Contract
{
    /// <summary>
    /// Zapewnia funkcjonalność użytkownika związaną z funkcjami społecznościowymi.
    /// </summary>
    public interface IAppUserSocialService
    {
        /// <summary>
        /// Wysyła użytkownikowi zaproszenie do znajomych. Powinien dostać stosowne powiadomienie.
        /// </summary>
        /// <param name="sender">Użytkownik wysyłający zaproszenie</param>
        /// <param name="receiver">Adresat zaproszenia</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean SendFriendInvitation(IAppUser sender, IAppUser receiver);

        /// <summary>
        /// Dodaje znajomego firstUser do znajomych secondUser oraz secondUser do znajomych firstUser 
        /// w momencie akceptacji zaproszenia.
        /// </summary>
        /// <param name="firstUser">Pierwszy użytkownik</param>
        /// <param name="secondUser">Drugi użytkownik</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean FriendUsers(IAppUser firstUser, IAppUser secondUser);

        /// <summary>
        /// Kasuje firstUser ze znajomych secondUser oraz secondUser ze znajomych firstUser.
        /// </summary>
        /// <param name="firstUser">Pierwszy użytkownik</param>
        /// <param name="secondUser">Drugi użytkownik</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean UnfriendUsers(IAppUser firstUser, IAppUser secondUser);
    }
}