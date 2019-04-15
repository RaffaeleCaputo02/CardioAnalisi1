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


        [TestMethod]
        public void TestCalorie1()
        {
            string sesso = "uomo";
            int F = 120;
            double P = 77;
            int A = 16;
            int T = 90;
            string asp = "842,38";
            string C = CardioLibrary.DataCardio.Calorie(sesso, F, P, A, T);
            Assert.AreEqual(asp, C);
        }

        [TestMethod]
        public void TestCalorie2()
        {
            string sesso = "donna";
            int F = 120;
            double P = 77;
            int A = 16;
            int T = 90;
            string asp = "532,25";
            string C = CardioLibrary.DataCardio.Calorie(sesso, F, P, A, T);
            Assert.AreEqual(asp, C);
        }

        [TestMethod]
        public void TestCalorie3()
        {
            string sesso = "donna";
            int F = 120;
            double P = 77;
            int A = -22;
            int T = 90;
            string asp = "impossibile";
            string C = CardioLibrary.DataCardio.Calorie(sesso, F, P, A, T);
            Assert.AreEqual(asp, C);
        }

        [TestMethod]
        public void TestCalorie4()
        {
            string sesso = "uomo";
            int F = 120;
            double P = 0;
            int A = -22;
            int T = 90;
            string asp = "impossibile";
            string C = CardioLibrary.DataCardio.Calorie(sesso, F, P, A, T);
            Assert.AreEqual(asp, C);
        }

        [TestMethod]
        public void TestSpesaEnergetica1()
        {
            string esercizio = "corsa";
            double kmPercorsi=3.5;
            double peso = 77;
            string asp = "242,55";
            string KCal = CardioLibrary.DataCardio.SpesaEnergetica(esercizio, kmPercorsi,peso);
            Assert.AreEqual(asp, KCal);
        }

        [TestMethod]
        public void TestSpesaEnergetica2()
        {
            string esercizio = "corsa";
            double kmPercorsi = 0;
            double peso = 77;
            string asp = "impossibile";
            string KCal = CardioLibrary.DataCardio.SpesaEnergetica(esercizio, kmPercorsi, peso);
            Assert.AreEqual(asp, KCal);
        }

        [TestMethod]
        public void TestSpesaEnergetica3()
        {
            string esercizio = "camminata";
            double kmPercorsi = 3.5;
            double peso = 0;
            string asp = "impossibile";
            string KCal = CardioLibrary.DataCardio.SpesaEnergetica(esercizio, kmPercorsi, peso);
            Assert.AreEqual(asp, KCal);
        }

        [TestMethod]
        public void TestSpesaEnergetica4()
        {
            string esercizio = "camminata";
            double kmPercorsi = 10;
            double peso = 120;
            string asp = "600";
            string KCal = CardioLibrary.DataCardio.SpesaEnergetica(esercizio, kmPercorsi, peso);
            Assert.AreEqual(asp, KCal);
        }
    }
}
