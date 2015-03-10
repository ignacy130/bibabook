using System;
using System.Collections.Generic;

namespace Contract
{
    /// <summary>
    /// Zapewnia metody związane z obsługą powiadomień.
    /// </summary>
    public interface INotificationService
    {
        /// <summary>
        /// Dodaje powiadomienie do bazy.
        /// </summary>
        /// <param name="eventPost">Dodawane powiadomienie</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean Create(INotification notification);

        /// <summary>
        /// Ustala stan powiadomienia.
        /// </summary>
        /// <param name="notification">Powiadomienie</param>
        /// <param name="notificationStatus">Nowy stan powiadomienia</param>
        /// <returns>Prawda jeśli wszystko przebiegło bez problemów. Fałsz w przeciwnym przypadku.</returns>
        Boolean SetNotificationStatus(INotification notification, NotificationStatus notificationStatus);

        /// <summary>
        /// Wybiera powiadomienia użytkownika o jednym z zadanych statusów. Jeśli nie określono stanów, wybiera wszystkie.
        /// </summary>
        /// <param name="appUser">Użytkownik</param>
        /// <param name="acceptedStatuses">Kolekcja dopuszczlnych stanów powiadomienia</param>
        /// <returns>Kolekcja powiadomień</returns>
        ICollection<INotification> GetUserNotifications(IAppUser appUser, ICollection<NotificationStatus> acceptedStatuses = null);
    }
}