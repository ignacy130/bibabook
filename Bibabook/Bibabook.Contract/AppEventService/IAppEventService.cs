using System;
using System.Collections.Generic;

namespace Contract
{
    /// <summary>
    /// Zapewnia metody związane z obsługą wydarzenia.
    /// </summary>
    public interface IAppEventService
    {
        /// <summary>
        /// Creates an event in database.
        /// </summary>
        /// <param name="appEvent"></param>
        /// <returns></returns>
        Boolean Create(IAppEvent appEvent);

        /// <summary>
        /// Odwołuje wydarzenie. Powinno zostać oznaczone w bazie jako nieaktywne. Wszyscy przypisani 
        /// użytkownicy powinni otrzymać stosowne powiadomienie (notyfikację). Opcja ta dostępna powinna 
        /// być wyłącznie dla twórcy wydarzenia.
        /// </summary>
        /// <param name="appEvent">Instancja odwoływanego wydarzenia</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean Cancel(IAppEvent appEvent);

        /// <summary>
        /// Kasuje wydarzenie (np. z powodu naruszenia). Powinno zostać ono usunięte z bazy. Wszystkie 
        /// przypisane do niego posty powinny zostać skasowane. Wszyscy przypisani użytkownicy powinni 
        /// otrzymać stosowne powiadomienie (notyfikację). Opcja ta dostępna powinna być wyłącznie 
        /// dla moderatorów.
        /// </summary>
        /// <param name="appEvent">Instancja odwoływanego wydarzenia</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean Delete(IAppEvent appEvent);

        /// <summary>
        /// Invites user to an event. User should be notiifed.
        /// </summary>
        /// <param name="appEvent">Event</param>
        /// <param name="sender">User inviting</param>
        /// <param name="recipient">User invited</param>
        /// <returns>Returns True if operation was completed succesfully, else returns Falase.</returns>
        Boolean InviteUser(IAppEvent appEvent, IAppUser sender, IAppUser receiver);

        /// <summary>
        /// Invites users to an event. User should be notiifed.
        /// </summary>
        /// <param name="appEvent">Event</param>
        /// <param name="sender">User inviting</param>
        /// <param name="recipients">Users invited</param>
        /// <returns>Returns True if operation was completed succesfully, else returns Falase.</returns>
        Boolean InviteUser(IAppUser appEvent, IAppUser sender, ICollection<IAppUser> appUser);

        /// <summary>
        /// Adds user to an event.
        /// </summary>
        /// <param name="appEvent">Unikalny identyfikator wydarzenia</param>
        /// <param name="appUser">Unikalny identyfikator użytkownika</param>
        /// <returns>Returns True if operation was completed succesfully, else returns Falase.</returns>
        Boolean EnrollUser(IAppUser appEvent, IAppUser appUserInvited);


        /// <summary>
        /// Wypisuje użytkownika z wydarzenia. Użytkownik może wypisać się sam, może zostać wyproszony przez
        /// właściciela wydarzenia lub przez moderatorów.
        /// </summary>
        /// <param name="appEventId">Unikalny identyfikator wydarzenia (GUID)</param>
        /// <param name="appUserId">Unikalny identyfikator użytkownika (GUID)</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean RemoveUser(String appEventId, String appUserId);

        // Bardzo wątpliwe użycie metody grupowej.
        Boolean RemoveUser(String appEventId, ICollection<String> appUserIds);

        /// <summary>
        /// Nakłada zakaz partycypacji użytkownika w wydarzeniu. Dodaje użytkownika do listy użytkowników, 
        /// którzy nie mogą zapisać się na wydarzenie. Opcja ta dostępna powinna być wyłącznie dla twórcy 
        /// wydarzenia.
        /// </summary>
        /// <param name="appEventId">Unikalny identyfikator wydarzenia (GUID)</param>
        /// <param name="appUserId">Unikalny identyfikator użytkownika (GUID)</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean ForbidUser(String appEventId, String appUserId); 

        /// <summary>
        /// Anuluje zakaz partycypacji użytkownika w wydarzeniu. Opcja ta dostępna powinna być wyłącznie 
        /// dla twórcy wydarzenia.
        /// </summary>
        /// <param name="appEventId">Unikalny identyfikator wydarzenia (GUID)</param>
        /// <param name="appUserId">Unikalny identyfikator użytkownika (GUID)</param>
        /// <returns>Returns True if operation was completed successfully, else returns False.</returns>
        Boolean AllowUser(String appEventId, String appUserId);

        /// <summary>
        /// Przypisuje post do wydarzenia.
        /// </summary>
        /// <param name="appEventId">Unikalny identyfikator (GUID) wydarzenia</param>
        /// <param name="eventPostId">Unikalny identyfikator (GUID) posta</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w p.p.</returns>
        Boolean AddEventPost(String appEventId, String eventPostId);

        // + Dodać metody związane ze zmianą parametrów.
    }
}