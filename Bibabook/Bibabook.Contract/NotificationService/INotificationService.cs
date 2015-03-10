using System;
using System.Collections.Generic;

namespace Contract
{
    /// <summary>
    /// Zapewnia metody związane z obsługą powiadomień.
    /// </summary>
    public interface INotificationService
    {
        Boolean Create(/* argumenty śliśle zależą od przyjętego modelu notyfikacji */);

        /// <summary>
        /// Ustala stan powiadomienia.
        /// </summary>
        /// <param name="notificationId">Unikalny identyfikator powiadomienia (GUID)</param>
        /// <param name="notificationStatus">Nowy stan powiadomienia</param>
        /// <returns></returns>
        Boolean SetNotificationStatus(Guid notificationId, NotificationStatus notificationStatus);

        /// <summary>
        /// Wybiera powiadomienia użytkownika o jednym z zadanych statusów. Jeśli nie określono stanów, wybiera wszystkie.
        /// </summary>
        /// <param name="appUserId">Unikalny identyfikator użytkownika (GUID)</param>
        /// <param name="acceptedStatuses">Kolekcja dopuszczlnych stanów powiadomienia</param>
        /// <returns>Kolekcja powiadomień</returns>
        ICollection<INotification> GetUserNotifications(String appUserId, ICollection<NotificationStatus> acceptedStatuses = null);
    }
}