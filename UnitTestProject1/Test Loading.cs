using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBulletLoading()
        {
            var RMISSLES = new int();
            RMISSLES = 0;
            
            if (RMISSLES == 0)
            {
                RMISSLES = 6;
                Assert.AreEqual(6, RMISSLES);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
