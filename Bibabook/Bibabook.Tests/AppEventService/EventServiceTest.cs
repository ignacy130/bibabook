using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.UI;
using Bibabook.Implementation.AppEventService;
using Bibabook.Models;
using Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibabook.Implementation.Models;

namespace Bibabook.Tests.AppEventService
{
    [TestClass]
    public class EventServiceTest
    {

        private IAppEventService appEventService;
        private IAppEvent appEvent;
        private IAppUser firstUser;
        private IAppUser secondUser;
        private IAppUser thirdUser;
        private IEventPost eventPost;

        public EventServiceTest()
        {
            appEventService = new EventsService();
            appEvent = new AppEvent();
            firstUser = new AppUser();
            secondUser = new AppUser();
            thirdUser = new AppUser();
            eventPost = new Implementation.Models.EventPost();
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnego obiektu implementującego interfejs IAppEvent.
        /// </summary>
        [TestMethod]
        public void CreatePassesForCorrectAppEventObject()
        {
            Boolean result = appEventService.Create(appEvent);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego obiektu.
        /// </summary>
        [TestMethod]
        public void CreateFailsForNullAppEventObject()
        {
            Boolean result = appEventService.Create(null);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnego obiektu implementującego interfejs IAppEvent.
        /// </summary>
        [TestMethod]
        public void CancelPassesForCorrectAppEventObject()
        {
            Boolean result = appEventService.Cancel(appEvent);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego obiektu.
        /// </summary>
        [TestMethod]
        public void CancelFailsForNullAppEventObject()
        {
            Boolean result = appEventService.Cancel(null);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnego obiektu implementującego interfejs IAppEvent.
        /// </summary>
        [TestMethod]
        public void DeletePassesForCorrectAppEventObject()
        {
            Boolean result = appEventService.Delete(appEvent);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego obiektu.
        /// </summary>
        [TestMethod]
        public void DeletelFailsForNullAppEventObject()
        {
            Boolean result = appEventService.Delete(null);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void InviteUserPassesForCorrectAppEventObject()
        {
            Boolean result = appEventService.InviteUser(appEvent,  firstUser, secondUser);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego obiektu implementującego IAppEvent.
        /// </summary>
        [TestMethod]
        public void InviteUserFailsForNullAppEventObject()
        {
            Boolean result = appEventService.InviteUser(null, firstUser, secondUser);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego nadawcy.
        /// </summary>
        [TestMethod]
        public void InviteUserFailsForNullSender()
        {
            Boolean result = appEventService.InviteUser(appEvent, null, secondUser);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego odbiorcy.
        /// </summary>
        [TestMethod]
        public void InviteUserFailsForNullRecipient()
        {
            IAppUser appUser = null;
            Boolean result = appEventService.InviteUser(appEvent, firstUser, appUser);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false kiedy nadawca i odbiorca to ten sam obiekt.
        /// </summary>
        [TestMethod]
        public void InviteUserFailsForSenderSameAsRecipient()
        {
            Boolean result = appEventService.InviteUser(appEvent, firstUser, firstUser);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnej kolekcji danych.
        /// </summary>
        [TestMethod]
        public void InviteUserPassesForCorrectCollection()
        {
            ICollection<IAppUser> collection = new List<IAppUser>();
            collection.Add(secondUser);
            collection.Add(thirdUser);
            Boolean result = appEventService.InviteUser(appEvent, firstUser, collection);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla kolekcji nie zawierającej żadnych elementów.
        /// </summary>
        [TestMethod]
        public void InviteUserFailsForEmptyCollection()
        {
            ICollection<IAppUser> collection = new List<IAppUser>();
            Boolean result = appEventService.InviteUser(appEvent, firstUser, collection);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla kolekcji w której nadawca znajduje się na liście odbiorców.
        /// </summary>
        [TestMethod]
        public void InviteUserFailsForSenderInReciepentsCollection()
        {
            ICollection<IAppUser> collection = new List<IAppUser>();
            collection.Add(secondUser);
            collection.Add(firstUser);
            Boolean result = appEventService.InviteUser(appEvent, firstUser, collection);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla kolekcji zawierającej pusty element.
        /// </summary>
        [TestMethod]
        public void InviteUserFailsForNullObjectInReciepentsCollection()
        {
            ICollection<IAppUser> collection = new List<IAppUser>();
            collection.Add(secondUser);
            collection.Add(null);
            collection.Add(firstUser);
            Boolean result = appEventService.InviteUser(appEvent, firstUser, collection);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void EnrollUserPassesForCorrectData()
        {
            Boolean result = appEventService.EnrollUser(appEvent, firstUser);
            Assert.IsTrue(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego obiektu wydarzenia.
        /// </summary>
        [TestMethod]
        public void EnrollUserFailsForNullEvent()
        {
            Boolean result = appEventService.EnrollUser(null, firstUser);
            Assert.IsFalse(result);
        }       
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego obiektu użytkownika.
        /// </summary>
        [TestMethod]
        public void EnrollUserFailsForNullUser()
        {
            Boolean result = appEventService.EnrollUser(appEvent, null);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void RemoveUserPassesForCorrectData()
        {
            Boolean result = appEventService.RemoveUser(appEvent, firstUser);
            Assert.IsTrue(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego obiektu wydarzenia.
        /// </summary>
        [TestMethod]
        public void RemoveUserFailsForNullEvent()
        {
            Boolean result = appEventService.RemoveUser(null, firstUser);
            Assert.IsFalse(result);
        }       
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego obiektu użytkownika.
        /// </summary>
        [TestMethod]
        public void RemoveUserFailsForNullUser()
        {
            IAppUser user = null;
            Boolean result = appEventService.RemoveUser(appEvent, user);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnej kolekcji użytkowników.
        /// </summary>
        [TestMethod]
        public void RemoveUserPassesForCorrectCollection()
        {
            ICollection<IAppUser> collection = new List<IAppUser>();
            collection.Add(firstUser);
            collection.Add(secondUser);
            Boolean result = appEventService.RemoveUser(appEvent, collection);
            Assert.IsTrue(result);
        }        

        /// <summary>
        /// Testuje czy metoda zwraca false dla kolekcji nie zawierającej żadnego elementu.
        /// </summary>
        [TestMethod]
        public void RemoveUserFailsForEmptyCollection()
        {
            ICollection<IAppUser> collection = new List<IAppUser>();
            Boolean result = appEventService.RemoveUser(appEvent, collection);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla kolekcji zawierającej powtarzających się użytkowników.
        /// </summary>
        [TestMethod]
        public void RemoveUserFailsForRepeatedUsersInCollection()
        {
            ICollection<IAppUser> collection = new List<IAppUser>();
            collection.Add(firstUser);
            collection.Add(firstUser);
            collection.Add(secondUser);
            Boolean result = appEventService.RemoveUser(appEvent, collection);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnej kolekcji użytkowników.
        /// </summary>
        [TestMethod]
        public void ForbidUserPassesForCorrectCollection()
        {
            Boolean result = appEventService.ForbidUser(appEvent, firstUser);
            Assert.IsTrue(result);
        } 

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego wydarzenia.
        /// </summary>
        [TestMethod]
        public void ForbidUserFailsForNullEvent()
        {
            Boolean result = appEventService.ForbidUser(null, firstUser);
            Assert.IsFalse(result);
        } 

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego użytkownika.
        /// </summary>
        [TestMethod]
        public void ForbidUserFailsForNullUser()
        {
            Boolean result = appEventService.ForbidUser(appEvent, null);
            Assert.IsFalse(result);
        }   

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnej kolekcji użytkowników.
        /// </summary>
        [TestMethod]
        public void AllowUserPassesForCorrectCollection()
        {
            Boolean result = appEventService.AllowUser(appEvent, firstUser);
            Assert.IsTrue(result);
        } 

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego wydarzenia.
        /// </summary>
        [TestMethod]
        public void AllowUserFailsForNullEvent()
        {
            Boolean result = appEventService.AllowUser(null, firstUser);
            Assert.IsFalse(result);
        } 

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego użytkownika.
        /// </summary>
        [TestMethod]
        public void AllowUserFailsForNullUser()
        {
            Boolean result = appEventService.AllowUser(appEvent, null);
            Assert.IsFalse(result);
        }   

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnej kolekcji użytkowników.
        /// </summary>
        [TestMethod]
        public void AddEventPostPassesForCorrectCollection()
        {
            Boolean result = appEventService.AddEventPost(appEvent, eventPost);
            Assert.IsTrue(result);
        } 

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego wydarzenia.
        /// </summary>
        [TestMethod]
        public void AddEventPostFailsForNullEvent()
        {
            Boolean result = appEventService.AddEventPost(null, eventPost);
            Assert.IsFalse(result);
        } 

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego użytkownika.
        /// </summary>
        [TestMethod]
        public void AddEventPostFailsForNullUser()
        {
            Boolean result = appEventService.AddEventPost(appEvent, null);
            Assert.IsFalse(result);
        }   



    }
}
