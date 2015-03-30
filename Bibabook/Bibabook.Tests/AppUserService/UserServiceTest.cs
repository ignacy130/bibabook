using System;
using Bibabook.Implementation.AppUserService;
using Bibabook.Models;
using Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bibabook.Tests.AppUserService
{
    [TestClass]
    public class UserServiceTest
    {

        private IAppUserService appUserService;
        private IAppUser appUser;
        public UserServiceTest()
        {
            appUserService = new UsersService();
            appUser = new AppUser();
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnego użytkownika.
        /// </summary>
        [TestMethod]
        public void CreateAccountPassesForGoodAppUser()
        {
            Boolean result = appUserService.CreateAccount(appUser);
            Assert.IsTrue(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego użytkownika.
        /// </summary>
        [TestMethod]
        public void CreateAccountFailsForNullAppUser()
        {
            Boolean result = appUserService.CreateAccount(null);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnego użytkownika.
        /// </summary>
        [TestMethod]
        public void VerifyAccountPassesForGoodAppUser()
        {
            Boolean result = appUserService.VerifyAccount(appUser);
            Assert.IsTrue(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego użytkownika.
        /// </summary>
        [TestMethod]
        public void VerifyAccountFailsForNullAppUser()
        {
            Boolean result = appUserService.VerifyAccount(null);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnego użytkownika.
        /// </summary>
        [TestMethod]
        public void CloseAccountPassesForGoodAppUser()
        {
            Boolean result = appUserService.CloseAccount(appUser);
            Assert.IsTrue(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego użytkownika.
        /// </summary>
        [TestMethod]
        public void CloseAccountFailsForNullAppUser()
        {
            Boolean result = appUserService.CloseAccount(null);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void BanUserPassesForCorrectData()
        {
            Boolean result = appUserService.BanUser(appUser, DateTime.Now);
            Assert.IsTrue(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego użytkownika.
        /// </summary>
        [TestMethod]
        public void BanUserFailsForNullAppUser()
        {
            Boolean result = appUserService.BanUser(null, DateTime.Now);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla przeszłej daty.
        /// </summary>
        [TestMethod]
        public void BanUserFailsForPastDate()
        {
            Boolean result = appUserService.BanUser(appUser, new DateTime(1550, 12, 10));
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void ChangeUserRolePassesForGoodAppUser()
        {
            Boolean result = appUserService.ChangeUserRole(appUser, Constants.CORRECT_USER_ROLE);
            Assert.IsTrue(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego użytkownika.
        /// </summary>
        [TestMethod]
        public void ChangeUserRoleFailsForNullAppUser()
        {
            Boolean result = appUserService.ChangeUserRole(null, Constants.CORRECT_USER_ROLE);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla niepoprawnej roli użytkownika.
        /// </summary>
        [TestMethod]
        public void ChangeUserRoleFailsForWrongRole()
        {
            Boolean result = appUserService.ChangeUserRole(appUser, Constants.WRONG_USER_ROLE);
            Assert.IsFalse(result);
        }         
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustej roli użytkownika.
        /// </summary>
        [TestMethod]
        public void ChangeUserRoleFailsForNullRole()
        {
            Boolean result = appUserService.ChangeUserRole(appUser, null);
            Assert.IsFalse(result);
        }          
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void ChangeUserEmailPassesForGoodAppUser()
        {
            Boolean result = appUserService.ChangeUserEmail(appUser, Constants.CORRECT_EMAIL);
            Assert.IsTrue(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego użytkownika.
        /// </summary>
        [TestMethod]
        public void ChangeUserEmailFailsForNullAppUser()
        {
            Boolean result = appUserService.ChangeUserEmail(null, Constants.CORRECT_EMAIL);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla niepoprawnego emaila.
        /// </summary>
        [TestMethod]
        public void ChangeUserEmailFailsForWrongEmail()
        {
            Boolean result = appUserService.ChangeUserEmail(appUser, Constants.WRONG_EMAIL);
            Assert.IsFalse(result);
        }         
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego emaila.
        /// </summary>
        [TestMethod]
        public void ChangeUserEmailFailsForNullEmail()
        {
            Boolean result = appUserService.ChangeUserEmail(appUser, null);
            Assert.IsFalse(result);
        }   

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void ChangeUserPasswordPassesForGoodData()
        {
            Boolean result = appUserService.ChangeUserPassword(appUser, Constants.CORRECT_PASSWORD);
            Assert.IsTrue(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego użytkownika.
        /// </summary>
        [TestMethod]
        public void ChangeUserPasswordFailsForNullAppUser()
        {
            Boolean result = appUserService.ChangeUserPassword(null, Constants.CORRECT_PASSWORD);
            Assert.IsFalse(result);
        }        

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego hasła.
        /// </summary>
        [TestMethod]
        public void ChangeUserPasswordFailsForNullEmail()
        {
            Boolean result = appUserService.ChangeUserPassword(appUser, null);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void ChangeUserAvatarPassesForGoodData()
        {
            Boolean result = appUserService.ChangeUserPassword(appUser, Constants.CORRECT_AVATAR_PATH);
            Assert.IsTrue(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego użytkownika.
        /// </summary>
        [TestMethod]
        public void ChangeUserAvatarFailsForNullAppUser()
        {
            Boolean result = appUserService.ChangeUserPassword(null, Constants.CORRECT_AVATAR_PATH);
            Assert.IsFalse(result);
        }        

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustej ścieżki do avatara.
        /// </summary>
        [TestMethod]
        public void ChangeUserAvatarFailsForNullAvatarPath()
        {
            Boolean result = appUserService.ChangeUserPassword(appUser, Constants.CORRECT_AVATAR_PATH);
            Assert.IsFalse(result);
        }         
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla niepoprawnej ścieżki do avatara.
        /// </summary>
        [TestMethod]
        public void ChangeUserAvatarFailsForWrongAvatarPath()
        {
            Boolean result = appUserService.ChangeUserPassword(appUser, Constants.WRONG_AVATAR_PATH);
            Assert.IsFalse(result);
        }      
    
        /// <summary>
        /// Testuje czy metoda zwraca false gdy przekazana ścieżka wskacuje na plik JavaScript.
        /// </summary>
        [TestMethod]
        public void ChangeUserAvatarFailsForPassedJavaScriptFile()
        {
            Boolean result = appUserService.ChangeUserPassword(appUser, Constants.WRONG_AVATAR_PATH_JS);
            Assert.IsFalse(result);
        }        
    
        /// <summary>
        /// Testuje czy metoda zwraca false gdy przekazana ścieżka wskazuje na plik html.
        /// </summary>
        [TestMethod]
        public void ChangeUserAvatarFailsForPassedHtmlFile()
        {
            Boolean result = appUserService.ChangeUserPassword(appUser, Constants.WRONG_AVATAR_PATH_HTML);
            Assert.IsFalse(result);
        }         
    
        /// <summary>
        /// Testuje czy metoda zwraca false dla ścieżki pliku posiadającej podwójne rozszerzenie.
        /// </summary>
        [TestMethod]
        public void ChangeUserAvatarFailsForPassedDoubleExtension()
        {
            Boolean result = appUserService.ChangeUserPassword(appUser, Constants.WRONG_AVATAR_PATH_JS_DOUBLE);
            Assert.IsFalse(result);
        }        
    }
}
