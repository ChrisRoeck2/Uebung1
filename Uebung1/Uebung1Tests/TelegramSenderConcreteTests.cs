using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class TelegramSenderConcreteTests
    {
        [TestMethod()]
        public void SendTest()
        {
            TelegramSenderConcrete ts = new TelegramSenderConcrete();

            Assert.IsTrue(ts.Send("Valid Message 1337"), "Valid message retuned false");
            Assert.IsFalse(ts.Send("Invalid Message"), "Invalid Message returned true");

        }
    }
}