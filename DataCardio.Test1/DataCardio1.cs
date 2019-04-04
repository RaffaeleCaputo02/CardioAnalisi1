using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio.Test1
{
    [TestClass]
    public class DataCardio1
    {
        [TestMethod]
        public void TestBattiti1()
        {
            int eta = 16;
            string asp ="142,8;183,6";
            string consigliato = CardioLibrary.DataCardio.Battiti(eta);
            Assert.AreEqual(asp, consigliato);
        }

        [TestMethod]
        public void TestBattiti2()
        {
            int eta = 0;
            string asp = "impossibile";
            string consigliato = CardioLibrary.DataCardio.Battiti(eta);
            Assert.AreEqual(asp, consigliato);
        }

        [TestMethod]
        public void TestBattiti3()
        {
            int eta = -17;
            string asp = "impossibile";
            string consigliato = CardioLibrary.DataCardio.Battiti(eta);
            Assert.AreEqual(asp, consigliato);
        }

    }
}
