using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestFire()
        {
            Random rng = new Random();
            int RouletteMissles = rng.Next(0, 6);
                if (RouletteMissles > 0) 
                {
                RouletteMissles--;
                Assert.AreEqual(RouletteMissles, RouletteMissles);               
                }
            else if (RouletteMissles == 0)
            {
                Assert.AreEqual(0, RouletteMissles);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
