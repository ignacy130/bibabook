using System;
using System.Collections.Generic;
using Bibabook.Models;
using Contract;
using Contract.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibabook.Implementation.Models;

namespace Bibabook.Tests.NotificationService
{
    [TestClass]
    public class NotificationServiceTest
    {

        private INotificationService notificationService;
        private INotification notification;
        private NotificationStatus firstStatus;
        private NotificationStatus secondStatus;
        private IAppUser appUser;

        public NotificationServiceTest()
        {
            notificationService = new Implementation.NotificationService.NotificationService();
            notification = new Notification();
            firstStatus = new NotificationStatus();
            secondStatus = new NotificationStatus();
            appUser = new AppUser();
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnego powiadomienia.
        /// </summary>
        [TestMethod]
        public void CreatePassesForCorrectNotification()
        {
            Boolean result = notificationService.Create(notification);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego powiadomienia.
        /// </summary>
        [TestMethod]
        public void CreateFailsForNullNotification()
        {
            Boolean result = notificationService.Create(null);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void SetNotificationStatusPassesForCorrectNotification()
        {
            Boolean result = notificationService.SetNotificationStatus(notification, firstStatus);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego powiadomienia.
        /// </summary>
        [TestMethod]
        public void SetNotificationStatusFailsForNullNotification()
        {
            Boolean result = notificationService.SetNotificationStatus(null, firstStatus);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void GetUserNotificationsPassesForCorrectNotification()
        {
            ICollection<NotificationStatus> collection = new List<NotificationStatus>();
            collection.Add(firstStatus);
            collection.Add(secondStatus);
            ICollection<INotification> result = notificationService.GetUserNotifications(appUser, collection);
            Assert.AreSame(result.Count, 2);
        }        

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void GetUserNotificationsPassesForNullCollection()
        {
            ICollection<NotificationStatus> collection = new List<NotificationStatus>();
            collection.Add(firstStatus);
            collection.Add(secondStatus);
            ICollection<INotification> result = notificationService.GetUserNotifications(appUser, null);
            Assert.AreSame(result.Count, 2);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego powiadomienia.
        /// </summary>
        [TestMethod]
        public void GetUserNotificationsFailsForNullNotification()
        {
            ICollection<INotification> result = notificationService.GetUserNotifications(null, null);
            Assert.IsNull(result);
        }

    }
}
