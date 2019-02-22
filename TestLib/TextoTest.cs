using General_Lib;
using General_Lib.Dados;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    [TestClass]
    public class TextoTest
    {
        [TestMethod]
        public void ContemLetras()
        {
            Assert.IsTrue(Texto.ContemLetras("1321564aA"));
            Assert.IsFalse(Texto.ContemLetras("1321564"));
        }

        [TestMethod]
        public void ContemNumeros()
        {
            Assert.IsTrue(Texto.ContemNumeros("AAAAAAA1313"));
            Assert.IsFalse(Texto.ContemNumeros("AAAAAAAAAAAA"));
        }

        [TestMethod]
        public void EmailValido()
        {
            Assert.IsTrue(Texto.EmailValido("perosamurilo@gmail.com"));
            Assert.IsFalse(Texto.EmailValido("perosamurilogmailcom"));
        }

        [TestMethod]
        public void TextoRandon()
        {
            string txt1 = Texto.TextoRandon(10);
            string txt2 = Texto.TextoRandon(10);
            Assert.IsFalse(txt1 == txt2);
        }

        [TestMethod]
        public void ToDouble()
        {
            string txt = "2,5";
            double dbl = 2.5;
            Assert.IsTrue(Texto.ToDouble(txt) == dbl);
        }

        [TestMethod]
        public void ToInt()
        {
            string txt = "2";
            int integer = 2;
            Assert.IsTrue(Texto.ToInt(txt) == integer);
        }

        [TestMethod]
        public void ToFloat()
        {
            string txt = "2,5";
            float flt = 2.5F;
            Assert.IsTrue(Texto.ToFloat(txt) == flt);
        }

        [TestMethod]
        public void ToDatetime()
        {
            string txt = "11/09/2001";
            DateTime dt = new DateTime(2001, 09, 11);
            Assert.IsTrue(Texto.ToDateTime(txt) == dt);
        }
    }
}
