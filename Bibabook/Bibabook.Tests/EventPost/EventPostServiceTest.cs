using System;
using Bibabook.Implementation.EventPost;
using Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bibabook.Tests.EventPost
{
    [TestClass]
    public class EventPostServiceTest
    {
        private IEventPostService eventPostService;

        public EventPostServiceTest()
        {
            eventPostService = new EventPostService();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
