using System;
using Bibabook.Implementation.PostComment;
using Bibabook.Models;
using Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibabook.Implementation.Models;

namespace Bibabook.Tests.PostComment
{
    [TestClass]
    public class PostCommentServiceTest
    {

        private IPostCommentService postCommentService;
        private IPostComment comment;

        public PostCommentServiceTest()
        {
            postCommentService = new PostCommentService();
            comment = new Comment();
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnego komentarza.
        /// </summary>
        [TestMethod]
        public void CreatePassesForCorrectComment()
        {
            Boolean result = postCommentService.Create(comment);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego komentarza.
        /// </summary>
        [TestMethod]
        public void CreateFailsForNullComment()
        {
            Boolean result = postCommentService.Create(null);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnych danych.
        /// </summary>
        [TestMethod]
        public void EditPassesForCorrectComment()
        {
            Boolean result = postCommentService.Edit(comment, Constants.CORRECT_COMMENT);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego komentarza.
        /// </summary>
        [TestMethod]
        public void EditFailsForNullComment()
        {
            Boolean result = postCommentService.Edit(null, Constants.CORRECT_COMMENT);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustej wiadomości.
        /// </summary>
        [TestMethod]
        public void EditFailsForNullMessage()
        {
            Boolean result = postCommentService.Edit(comment, null);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca true dla poprawnego komentarza.
        /// </summary>
        [TestMethod]
        public void DeletePassesForCorrectComment()
        {
            Boolean result = postCommentService.Delete(comment);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Testuje czy metoda zwraca false dla pustego komentarza.
        /// </summary>
        [TestMethod]
        public void DeleteFailsForNullComment()
        {
            Boolean result = postCommentService.Delete(null);
            Assert.IsFalse(result);
        }
    }
}
