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
        /// <param name="sender">User inviting</param>
        /// <param name="receiver">User invited</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean SendFriendInvitation(IAppUser sender, IAppUser receiver);

        /// <summary>
        /// Dodaje znajomego firstUser do znajomych secondUser oraz secondUser do znajomych firstUser 
        /// w momencie akceptacji zaproszenia.
        /// </summary>
        /// <param name="firstUserId">Unikalny identyfikator pierwszego użytkownika</param>
        /// <param name="secondUserId">Unikalny identyfikator drugiego użytkownika</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean FriendUsers(String firstUserId, String secondUserId);

        /// <summary>
        /// Kasuje firstUser ze znajomych secondUser oraz secondUser ze znajomych firstUser.
        /// </summary>
        /// <param name="firstUserId">Unikalny identyfikator pierwszego użytkownika</param>
        /// <param name="secondUserId">Unikalny identyfikator drugiego użytkownika</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean UnfriendUsers(String firstUserId, String secondUserId);
    }
}