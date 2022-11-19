using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ICMPTargetConcreteTests
    {
        [TestMethod()]
        public void testCheckTestTrue()
        {
            ICMPTargetConcrete icmpTarget = new ICMPTargetConcrete() { Address = "10.11.12.13",FailureMessage = "Kurwa!"};
            icmpTarget.getNotificationSenders().Add(new TelegramSenderConcrete() { Threshhold = 3 });

            for (int i = 0; i < 5; i++)
            {
                icmpTarget.check();
            }

            Assert.IsTrue(icmpTarget.testCheck(),"Threshhold behaivour is wrong");
        }

        [TestMethod()]
        public void testCheckTestFalse()
        {
            ICMPTargetConcrete icmpTarget2 = new ICMPTargetConcrete() { Address = "10.11.12.42", FailureMessage = "Kurwa!" };
            icmpTarget2.getNotificationSenders().Add(new TelegramSenderConcrete() { Threshhold = 3 });

            for (int i = 0; i < 5; i++)
            {
                icmpTarget2.check();
            }

            Assert.IsFalse(icmpTarget2.testCheck(), "Threshhold behaivour is wrong");
        }
    }
}