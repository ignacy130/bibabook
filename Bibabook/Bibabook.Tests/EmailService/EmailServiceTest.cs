using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Mail;
using Bibabook.Implementation.Models;
using Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bibabook.Tests.EmailService
{
    [TestClass]
    public class EmailServiceTest
    {

        private IEmailService emailService;
        private IEmail email;
 
        public EmailServiceTest() 
        {
            emailService = new Implementation.EmailService.EmailService();
            email = new Email();
        }

        /// <summary>
        /// Testuje czy metoda zwraca obiekt implementujący interfejs IEmail dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void CreateEmailPassesForCorrectData()
        {
            IEmail resultEmail = emailService.CreateEmail(Constants.CORRECT_EMAIL, Constants.CORRECT_SUBJECT, Constants.CORRECT_MESSAGE);
            Assert.IsNotNull(resultEmail);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca null dla niepoprawnego adresu email.
        /// </summary>
        [TestMethod]
        public void CreateEmailFailsForWrongEmail()
        {
            IEmail resultEmail = emailService.CreateEmail(Constants.WRONG_EMAIL, Constants.CORRECT_SUBJECT, Constants.CORRECT_MESSAGE);
            Assert.IsNull(resultEmail);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca null dla pustego adresu email.
        /// </summary>
        [TestMethod]
        public void CreateEmailFailsForNullEmail()
        {
            IEmail resultEmail = emailService.CreateEmail(null, Constants.CORRECT_SUBJECT, Constants.CORRECT_MESSAGE);
            Assert.IsNull(resultEmail);
        }   
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnego obiektu email.
        /// </summary>
        [TestMethod]
        public void SendEmailPassesForCorrectEmailObject()
        {
            Boolean result = emailService.SendEmail(email);
            Assert.IsTrue(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego adresu email.
        /// </summary>
        [TestMethod]
        public void CreateEmailFailsForWrongEmailObject()
        {
            Boolean result = emailService.SendEmail(null);
            Assert.IsFalse(result);
        }         
        
        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void SendEmailPassesForCorrectData()
        {
            ICollection<String> collection = new List<String>();
            collection.Add(Constants.CORRECT_EMAIL);
            collection.Add(Constants.CORRECT_EMAIL2);
            Boolean result = emailService.SendEmail(collection, Constants.CORRECT_SUBJECT, Constants.CORRECT_MESSAGE);
            Assert.IsTrue(result);
        }        
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla niepoprawnego adresu email w kolekcji.
        /// </summary>
        [TestMethod]
        public void CreateEmailFailsForWrongEmailInCollection()
        {
            ICollection<String> collection = new List<String>();
            collection.Add(Constants.CORRECT_EMAIL);
            collection.Add(Constants.CORRECT_EMAIL2);
            collection.Add(Constants.WRONG_EMAIL);
            Boolean result = emailService.SendEmail(collection, Constants.CORRECT_SUBJECT, Constants.CORRECT_MESSAGE);
            Assert.IsFalse(result);
        }          
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla powtarzających się adresów email w kolekcji.
        /// </summary>
        [TestMethod]
        public void CreateEmailFailsForRepeatedEmailsInCollection()
        {
            ICollection<String> collection = new List<String>();
            collection.Add(Constants.CORRECT_EMAIL);
            collection.Add(Constants.CORRECT_EMAIL);
            Boolean result = emailService.SendEmail(collection, Constants.CORRECT_SUBJECT, Constants.CORRECT_MESSAGE);
            Assert.IsFalse(result);
        }          
        
        /// <summary>
        /// Testuje czy metoda zwraca false dla kolekcji nie zawierającej żadnych elementów.
        /// </summary>
        [TestMethod]
        public void CreateEmailFailsWhenCollectionsEmpty()
        {
            ICollection<String> collection = new List<String>();
            Boolean result = emailService.SendEmail(collection, Constants.CORRECT_SUBJECT, Constants.CORRECT_MESSAGE);
            Assert.IsFalse(result);
        }   
      
        /// <summary>
        /// Testuje czy metoda zwraca false dla pustej(null) kolekcji.
        /// </summary>
        [TestMethod]
        public void CreateEmailFailsForNullCollection()
        {
            Boolean result = emailService.SendEmail(null, Constants.CORRECT_SUBJECT, Constants.CORRECT_MESSAGE);
            Assert.IsFalse(result);
        }        
    }
}
