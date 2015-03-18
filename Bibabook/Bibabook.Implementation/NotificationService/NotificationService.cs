using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;

namespace Bibabook.Implementation.NotificationService
{
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
