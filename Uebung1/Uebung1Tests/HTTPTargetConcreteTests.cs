using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class HTTPTargetConcreteTests
    {
        [TestMethod()]
        public void checkTestTrue()
        {
            HTTPTargetConcrete httpt1 = new HTTPTargetConcrete() { Address = "10.42.61.91" };
            Assert.IsTrue(httpt1.check(),"HTTP Check false negative");

        }

        [TestMethod()]
        public void checkTestFalse()
        {
            HTTPTargetConcrete httpt2 = new HTTPTargetConcrete() { Address = "10.24.61.91" };
            Assert.IsFalse(httpt2.check(), "HTTP Check false positive");
        }
    }
}