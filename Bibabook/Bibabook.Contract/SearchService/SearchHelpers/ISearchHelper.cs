using System;

namespace Contract
{
    /// <summary>
    /// Zapewnia metody wyszukiwania rekordów o zadanych unikalnych identyfikatorach (GUID)
    /// </summary>
    public interface ISearchHelper
    {
        /// <summary>
        /// Metoda wyszukująca w bazie użytkownika o podanym identyfikatorze.
        /// </summary>
        /// <param name="appUserId">Unikalny identyfikator użytkownika (GUID)</param>
        /// <returns>Użytkownik o określonym identyfikatorze lub null, gdy takowy nie istnieje</returns>
        IAppUser SearchUser(Guid appUserId);

        /// <summary>
        /// Metoda wyszukująca w bazie wydarzenie o podanym identyfikatorze.
        /// </summary>
        /// <param name="appEventId">Unikalny identyfikator wydarzenia (GUID)</param>
        /// <returns>Wydarzenie o określonym identyfikatorze lub null, gdy takowe nie istnieje</returns>
        IAppEvent SearchEvent(Guid appEventId);

        /// <summary>
        /// Metoda wyszukująca w bazie powiadomienie o podanym identyfikatorze.
        /// </summary>
        /// <param name="notificationId">Unikalny identyfikator powiadomienia (GUID)</param>
        /// <returns>Powiadomienie o określonym identyfikatorze lub null, gdy takowe nie istnieje</returns>
        INotification SearchNotification(Guid notificationId);

        /// <summary>
        /// Metoda wyszukująca w bazie post o podanym identyfikatorze.
        /// </summary>
        /// <param name="eventPostId">Unikalny identyfikator posta (GUID)</param>
        /// <returns>Post o określonym identyfikatorze lub null, gdy takowy nie istnieje</returns>
        IEventPost SearchPost(Guid eventPostId);

        /// <summary>
        /// Metoda wyszukująca w bazie komentarzy o podanym identyfikatorze.
        /// </summary>
        /// <param name="postCommentId">Unikalny identyfikator komentarza (GUID)</param>
        /// <returns>Komentarz o określonym identyfikatorze lub null, gdy takowy nie istnieje</returns>
        IPostComment SearchComment(Guid postCommentId);
    }
}