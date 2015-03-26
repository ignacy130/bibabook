using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using Contract.Enums;

namespace Bibabook.Implementation.NotificationService
{
    /// <summary>
    /// odpowiedzialny za powiadamianie uzytkowników o zdarzeniach w aplikacji takich jak:
    /// zaproszenia na wydarzenie, zmiana parametrów wydarzenia,
    /// otrzymanie zaproszenia do grona znajomych
    /// </summary>
    public class NotificationService : INotificationService
    {
        public bool Create(INotification notification)
        {
            throw new NotImplementedException();
        }

        public bool SetNotificationStatus(INotification notification, NotificationStatus notificationStatus)
        {
            throw new NotImplementedException();
        }

        public ICollection<INotification> GetUserNotifications(IAppUser appUser, ICollection<NotificationStatus> acceptedStatuses = null)
        {
            throw new NotImplementedException();
        }
    }
}
