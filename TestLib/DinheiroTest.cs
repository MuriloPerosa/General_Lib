using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using General_Lib;
using General_Lib.Dados;

namespace TestLib
{
    [TestClass]
    public class DinheiroTest
    {
        [TestMethod]
        public void ConverterReal()
        {
            Assert.IsTrue(Dinheiro.ConverterReal(10) == "R$ 10,00");
            Assert.IsTrue(Dinheiro.ConverterReal(10.2M) == "R$ 10,20");
            Assert.IsTrue(Dinheiro.ConverterReal(564.52f) == "R$ 564,52");
            Assert.IsTrue(Dinheiro.ConverterReal(2000.10) == "R$ 2.000,10");
        }

        [TestMethod]
        public void ConverterDolar()
        {
            Assert.IsTrue(Dinheiro.ConverterDolar(10) == "$10.00");
            Assert.IsTrue(Dinheiro.ConverterDolar(10.2M) == "$10.20");
            Assert.IsTrue(Dinheiro.ConverterDolar(564.52f) == "$564.52");
            Assert.IsTrue(Dinheiro.ConverterDolar(2000.10) == "$2,000.10");
        }

        [TestMethod]
        public void ConverteEuro()
        {
            Assert.IsTrue(Dinheiro.ConverterEuro(10) == "10,00 €");
            Assert.IsTrue(Dinheiro.ConverterEuro(10.2M) == "10,20 €");
            Assert.IsTrue(Dinheiro.ConverterEuro(564.52f) == "564,52 €");

        }
    }
}
