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

        [TestMethod]
        public void TestFreqCardiaca1()
        {
            int battiti=50;
            string asp = "Bradicardia";
            string freqCardiaca = CardioLibrary.DataCardio.ValoreFrequenza(battiti);
            Assert.AreEqual(asp, freqCardiaca);
        }

        [TestMethod]
        public void TestFreqCardiaca2()
        {
            int battiti = 78;
            string asp = "Normale";
            string freqCardiaca = CardioLibrary.DataCardio.ValoreFrequenza(battiti);
            Assert.AreEqual(asp, freqCardiaca);
        }

        [TestMethod]
        public void TestFreqCardiaca3()
        {
            int battiti = 120;
            string asp = "Tachicardia";
            string freqCardiaca = CardioLibrary.DataCardio.ValoreFrequenza(battiti);
            Assert.AreEqual(asp, freqCardiaca);
        }

        [TestMethod]
        public void TestFreqCardiaca4()
        {
            int battiti = 0;
            string asp = "Impossibile";
            string freqCardiaca = CardioLibrary.DataCardio.ValoreFrequenza(battiti);
            Assert.AreEqual(asp, freqCardiaca);
        }

        [TestMethod]
        public void TestFreqCardiaca5()
        {
            int battiti = -16;
            string asp = "Impossibile";
            string freqCardiaca = CardioLibrary.DataCardio.ValoreFrequenza(battiti);
            Assert.AreEqual(asp, freqCardiaca);
        }



    }
}
