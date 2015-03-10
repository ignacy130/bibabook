using System;
using System.Collections.Generic;

namespace Contract
{
    /// <summary>
    /// Zapewnia metody wyszukiwania w bazie danych obiektów na podstawie ich unikalnych 
    /// identyfikatorów (GUID) oraz metody wyszukiwania na podstawie określonych parametrów.
    /// </summary>
    public interface ISearchService
    {
        /// <summary>
        /// Metoda wyszukująca w bazie użytkownika o podanym identyfikatorze.
        /// </summary>
        /// <param name="appUserId">Unikalny identyfikator użytkownika (GUID)</param>
        /// <returns>Użytkownik o określonym identyfikatorze lub null, gdy takowy nie istnieje</returns>
        IAppUser SearchUser(String appUserId);

        /// <summary>
        /// Metoda wyszukująca w bazie użytkowników przy użyciu specjalnych warunków wyszukiwania.
        /// </summary>
        /// <param name="searchParameters">Parametry wyszukiwania</param>
        /// <returns></returns>
        ICollection<IAppUser> SearchUsers(ISearchParameters searchParameters);

        /// <summary>
        /// Metoda wyszukująca w bazie wydarzenie o podanym identyfikatorze.
        /// </summary>
        /// <param name="appEventId">Unikalny identyfikator wydarzenia (GUID)</param>
        /// <returns>Wydarzenie o określonym identyfikatorze lub null, gdy takowe nie istnieje</returns>
        IAppEvent SearchEvent(String appEventId);

        /// <summary>
        /// Metoda wyszukująca w bazie wydarzeń przy użyciu specjalnych warunków wyszukiwania.
        /// </summary>
        /// <param name="searchParameters"></param>
        /// <returns></returns>
        ICollection<IAppEvent> SearchEvents(ISearchParameters searchParameters);

        /// <summary>
        /// Metoda wyszukująca w bazie powiadomienie o podanym identyfikatorze.
        /// </summary>
        /// <param name="appEventId">Unikalny identyfikator powiadomienia (GUID)</param>
        /// <returns>Powiadomienie o określonym identyfikatorze lub null, gdy takowe nie istnieje</returns>
        INotification SearchNotification(String notificationId);

        /// <summary>
        /// Metoda wyszukująca w bazie powiadomień przy użyciu specjalnych warunków wyszukiwania.
        /// </summary>
        /// <param name="searchParameters"></param>
        /// <returns></returns>
        ICollection<INotification> SearchNotifications(ISearchParameters searchParameters);

        /// <summary>
        /// Metoda wyszukująca w bazie post o podanym identyfikatorze.
        /// </summary>
        /// <param name="appEventId">Unikalny identyfikator posta (GUID)</param>
        /// <returns>Post o określonym identyfikatorze lub null, gdy takowy nie istnieje</returns>
        IEventPost SearchPost(String eventPostId);

        /// <summary>
        /// Metoda wyszukująca w bazie komentarzy o podanym identyfikatorze.
        /// </summary>
        /// <param name="appEventId">Unikalny identyfikator komentarza (GUID)</param>
        /// <returns>Komentarz o określonym identyfikatorze lub null, gdy takowy nie istnieje</returns>
        IPostComment SearchComment(String postCommentId);
    }
}