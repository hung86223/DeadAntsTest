using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeadAntsTest
{
    [TestClass]
    public class DeadAntTests
    {
        private readonly DeadAnts _deadAnts = new DeadAnts();

        [TestMethod]
        public void NoAnt()
        {
            var deadAntsCount = _deadAnts.DeadAntsCount("");

            Assert.AreEqual(0, deadAntsCount);
        }

        [TestMethod]
        public void OneAntDead()
        {
            var deadAntsCount = _deadAnts.DeadAntsCount("a nt");

            Assert.AreEqual(0, deadAntsCount);
        }
    }

    public class DeadAnts
    {
        public int DeadAntsCount(string antsString)
        {
            return 0;
        }
    }
}