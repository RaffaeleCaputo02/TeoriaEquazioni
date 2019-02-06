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
        public void TestIsImpossible1()
        {
            double a = 0;
            double b = 0;
            bool response_attesa = true;
            bool response = Equazioni.IsImpossible(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsImpossible2()
        {
            double a = 6;
            double b = 6;
            bool response_attesa = false;
            bool response = Equazioni.IsImpossible(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsImpossible3()
        {
            double a = 0;
            double b = 6;
            bool response_attesa = false;
            bool response = Equazioni.IsImpossible(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsImpossible4()
        {
            double a = 6;
            double b = 0;
            bool response_attesa = false;
            bool response = Equazioni.IsImpossible(a, b);
            Assert.AreEqual(response_attesa, response);
        }
    }
}
