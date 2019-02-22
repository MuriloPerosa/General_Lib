using General_Lib;
using General_Lib.Enviar;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod]
        public void EmailTextoSimples()
        {
            Email.SimpleText("murilo.perosa@medabil.com.br", "perosamurilo@gmail.com", "Teste de Classe", "Teste ... 1 ... 2 ... 3 ...", "perosamurilo@gmail.com", "MP060598mp");
        }
    }
}
