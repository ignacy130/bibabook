using System;
using System.Net.Http.Headers;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using Bibabook.Implementation.AppUserService;
using Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bibabook.Tests.AppUserService
{
    /// <summary>
    /// Klasa testująca IAppUserEmailService
    /// </summary>
    [TestClass]
    public class EmailUsersServiceTest
    {
        private IAppUserEmailService appUserEmail;

        public EmailUsersServiceTest()
        {
            appUserEmail = new EmailUsersService();
        }

        /// <summary>
        /// Test sprawdza czy dla poprawnych danych metoda zwraca true.
        /// </summary>
        [TestMethod]
        public void SendsRegistationVerificationForGoodDatas()
        {
            Boolean result = appUserEmail.SendRegistrationVerificationEmail(Constants.CORRECT_EMAIL, Constants.CORRECT_USER_NAME, Constants.CORRECT_ACTIVATION_LINK);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Sprawdza czy metoda zwraca false dla niepoprawnego adresu email.
        /// </summary>
        [TestMethod]
        public void RegistrationVerificationFailsForWrongEmail()
        {
            Boolean result = appUserEmail.SendRegistrationVerificationEmail(Constants.WRONG_EMAIL, Constants.CORRECT_USER_NAME, Constants.CORRECT_ACTIVATION_LINK);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Sprawdza czy metoda zwraca false dla pustego adresu email.
        /// </summary>
        [TestMethod]
        public void RegistrationVerificationFailsForNullEmail()
        {
            Boolean result = appUserEmail.SendRegistrationVerificationEmail(null, Constants.CORRECT_USER_NAME, Constants.CORRECT_ACTIVATION_LINK);
            Assert.IsFalse(result);
        }       
 
        /// <summary>
        /// Sprawdza czy metoda zwraca false dla pustej nazwy użytkownika.
        /// </summary>
        /// 
        [TestMethod]
        public void RegistrationVerificationFailsForNullUserName()
        {
            Boolean result = appUserEmail.SendRegistrationVerificationEmail(Constants.CORRECT_EMAIL, null, Constants.CORRECT_ACTIVATION_LINK);
            Assert.IsFalse(result);
        } 
       
        /// <summary>
        /// Sprawdza czy metoda zwraca false dla niepoprawnego linku potwierdzającego.
        /// </summary>
        [TestMethod]
        public void RegistrationVerificationFailsForWrongActivationLink()
        {
            Boolean result = appUserEmail.SendRegistrationVerificationEmail(Constants.CORRECT_EMAIL, Constants.CORRECT_USER_NAME, Constants.WRONG_ACTIVATION_LINK);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Sprawdza czy meteoda zwraca false dla pustego linku potwierdzającego.
        /// </summary>
        [TestMethod]
        public void RegistrationVerificationFailsForNullActivationLink()
        {
            Boolean result = appUserEmail.SendRegistrationVerificationEmail(Constants.CORRECT_EMAIL, Constants.CORRECT_USER_NAME, null);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test sprawdza czy dla poprawnych danych metoda zwraca true (przywraca hasło).
        /// </summary>
        [TestMethod]
        public void RetrievesPasswordForGoodDatas()
        {
            Boolean result = appUserEmail.RetrievePassword(Constants.CORRECT_EMAIL, Constants.CORRECT_USER_NAME, Constants.CORRECT_PASSWORD);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Sprawdza czy metoda zwraca false dla niepoprawnego adresu email.
        /// </summary>
        [TestMethod]
        public void RetrievePasswordFailsForWrongEmail()
        {
            Boolean result = appUserEmail.RetrievePassword(Constants.WRONG_EMAIL, Constants.CORRECT_USER_NAME, Constants.CORRECT_PASSWORD);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Sprawdza czy metoda zwraca false dla pustego adresu email.
        /// </summary>
        [TestMethod]
        public void RetrievePasswordFailsForNullEmail()
        {
            Boolean result = appUserEmail.RetrievePassword(null, Constants.CORRECT_USER_NAME, Constants.CORRECT_PASSWORD);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Sprawdza czy metoda zwraca false dla pustej nazwy użytkownika.
        /// </summary>
        [TestMethod]
        public void RetrievePasswordFailsForNullUserName()
        {
            Boolean result = appUserEmail.RetrievePassword(Constants.CORRECT_EMAIL, null, Constants.CORRECT_PASSWORD);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Sprawdza czy metoda zwraca false dla pustego hasła.
        /// </summary>
        [TestMethod]
        public void RetrievePasswordFailsForNullPassword()
        {
            Boolean result = appUserEmail.RetrievePassword(Constants.CORRECT_EMAIL, Constants.CORRECT_USER_NAME, null);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test sprawdza czy dla poprawnych danych dana metoda zwraca true.
        /// </summary>
        [TestMethod]
        public void SendsInvitationForGoodDatas()
        {
            Boolean result = appUserEmail.SendInvitation(Constants.CORRECT_EMAIL, Constants.CORRECT_USER_NAME, Constants.CORRECT_EVENT_NAME);
            Assert.IsTrue(result);
        }    

        /// <summary>
        /// Test sprawdza czy dla niepoprawnego adresu email metoda zwraca false.
        /// </summary>
        [TestMethod]
        public void SendsInvitationForWrongEmail()
        {
            Boolean result = appUserEmail.SendInvitation(Constants.WRONG_EMAIL, Constants.CORRECT_USER_NAME, Constants.CORRECT_EVENT_NAME);
            Assert.IsFalse(result);
        }        
        
        /// <summary>
        /// Test sprawdza czy metoda zwraca false dla pustego adresu email.
        /// </summary>
        [TestMethod]
        public void SendsInvitationForNullEmail()
        {
            Boolean result = appUserEmail.SendInvitation(null, Constants.CORRECT_USER_NAME, Constants.CORRECT_EVENT_NAME);
            Assert.IsFalse(result);
        }   
     
        /// <summary>
        /// Test sprawdza czy metoda zwraca false dla pustej nazwy użytkownika.
        /// </summary>
        [TestMethod]
        public void SendsInvitationForNullUserName()
        {
            Boolean result = appUserEmail.SendInvitation(Constants.CORRECT_EMAIL, null, Constants.CORRECT_EVENT_NAME);
            Assert.IsFalse(result);
        }
     
        /// <summary>
        /// Test sprawdza czy metoda zwraca false dla pustego adresu event name.
        /// </summary>
        [TestMethod]
        public void SendsInvitationForNullEventName()
        {
            Boolean result = appUserEmail.SendInvitation(Constants.CORRECT_EMAIL, Constants.CORRECT_USER_NAME, null);
            Assert.IsFalse(result);
        }
    }
}
