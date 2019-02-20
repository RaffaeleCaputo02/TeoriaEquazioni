using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDetermined1()
        {
            double a = 3;
            bool response_attesa = true;
            bool response = Equazioni.IsDetermined(a);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsDetermined2()
        {
            double a = -3;
            bool response_attesa = true;
            bool response = Equazioni.IsDetermined(a);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsDetermined3()
        {
            double a = 0;
            bool response_attesa = false;
            bool response = Equazioni.IsDetermined(a);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsNotDetermined1()
        {
            double a = 5;
            double b = 6;
            bool response_attesa = false;
            bool response = Equazioni.IsNotDetermined(a,b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsNotDetermined2()
        {
            double a = 0;
            double b = 6;
            bool response_attesa = true;
            bool response = Equazioni.IsNotDetermined(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsNotDetermined3()
        {
            double a = 6;
            double b = 0;
            bool response_attesa = false;
            bool response = Equazioni.IsNotDetermined(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsNotDetermined4()
        {
            double a = 0;
            double b = 0;
            bool response_attesa = false;
            bool response = Equazioni.IsNotDetermined(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsInconsisted1()
        {
            double a = 0;
            double b = 0;
            bool response_attesa = true;
            bool response = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsInconsisted2()
        {
            double a = 6;
            double b = 6;
            bool response_attesa = false;
            bool response = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsInconsisted3()
        {
            double a = 0;
            double b = 6;
            bool response_attesa = false;
            bool response = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsInconsisted4()
        {
            double a = 6;
            double b = 0;
            bool response_attesa = false;
            bool response = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsDegree2_1()
        {
            double a = 6;
            bool response_attesa = false;
            bool response = Equazioni.IsDegree2(a);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsDegree2_2()
        {
            double a = 0;
            bool response_attesa = true;
            bool response = Equazioni.IsDegree2(a);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsDegree2_3()
        {
            double a = -5;
            bool response_attesa = false;
            bool response = Equazioni.IsDegree2(a);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestDelta1()
        {
            double a = 3;
            double b = 4;
            double c = 1;
            double aspettato = 0;
            double response = Equazioni.Delta(a,b,c);
            Assert.AreEqual(aspettato, response);
        }

        [TestMethod]
        public void TestDelta2()
        {
            double a = 0;
            double b = 4;
            double c = 1;
            double aspettato = 0;
            double response = Equazioni.Delta(a, b, c);
            Assert.AreEqual(aspettato, response);
        }

        [TestMethod]
        public void TestDelta3()
        {
            double a = 1;
            double b = 4;
            double c = 4;
            double aspettato = 10;
            double response = Equazioni.Delta(a, b, c);
            Assert.AreEqual(aspettato, response);
        }

    }
}
