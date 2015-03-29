using System;
using Bibabook.Implementation.AppUserService;
using Bibabook.Models;
using Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bibabook.Tests.AppUserService
{
    [TestClass]
    public class UserSocialServiceTest
    {
        private IAppUserSocialService userSocialService;
        private IAppUser firstUser;
        private IAppUser secondUser;
        public UserSocialServiceTest()
        {
            userSocialService = new SocialService();
            firstUser = new AppUser();
            secondUser = new AppUser();
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void SendFriendInvintationPassesForCorrectData()
        {
            Boolean result = userSocialService.SendFriendInvitation(firstUser, secondUser);
            Assert.IsTrue(result);
        }     
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego pierwszego użytkownika.
        /// </summary>
        [TestMethod]
        public void SendFriendInvintationFailsForNullFirstUser()
        {
            Boolean result = userSocialService.SendFriendInvitation(null, secondUser);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla pustego drugiego użytkownika.
        /// </summary>
        [TestMethod]
        public void SendFriendInvintationFailsForNullSecondUser()
        {
            Boolean result = userSocialService.SendFriendInvitation(firstUser, secondUser);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false gdy obaj użytkownicy są tym samym obiektem.
        /// </summary>
        [TestMethod]
        public void SendFriendInvintationFailsForSameUsers()
        {
            Boolean result = userSocialService.SendFriendInvitation(firstUser, firstUser);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void FriendUsersPassesForCorrectData()
        {
            Boolean result = userSocialService.FriendUsers(firstUser, secondUser);
            Assert.IsTrue(result);
        }     
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego pierwszego użytkownika.
        /// </summary>
        [TestMethod]
        public void FriendUsersFailsForNullFirstUser()
        {
            Boolean result = userSocialService.FriendUsers(null, secondUser);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla pustego drugiego użytkownika.
        /// </summary>
        [TestMethod]
        public void FriendUsersFailsForNullSecondUser()
        {
            Boolean result = userSocialService.FriendUsers(firstUser, secondUser);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false gdy obaj użytkownicy są tym samym obiektem.
        /// </summary>
        [TestMethod]
        public void FriendUsersFailsForSameUsers()
        {
            Boolean result = userSocialService.FriendUsers(firstUser, firstUser);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void UnfriendUsersPassesForCorrectData()
        {
            Boolean result = userSocialService.UnfriendUsers(firstUser, secondUser);
            Assert.IsTrue(result);
        }     
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego pierwszego użytkownika.
        /// </summary>
        [TestMethod]
        public void UnfriendUsersFailsForNullFirstUser()
        {
            Boolean result = userSocialService.UnfriendUsers(null, secondUser);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla pustego drugiego użytkownika.
        /// </summary>
        [TestMethod]
        public void UnfriendUsersFailsForNullSecondUser()
        {
            Boolean result = userSocialService.UnfriendUsers(firstUser, secondUser);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false gdy obaj użytkownicy są tym samym obiektem.
        /// </summary>
        [TestMethod]
        public void UnfriendUsersFailsForSameUsers()
        {
            Boolean result = userSocialService.UnfriendUsers(firstUser, firstUser);
            Assert.IsFalse(result);
        }
    }
}
