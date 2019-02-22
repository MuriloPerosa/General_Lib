using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using General_Lib.Arquivos;
using System.Collections.Generic;
using General_Lib;

namespace TestLib
{
    [TestClass]
    public class LogTest
    {
        [TestMethod]
        public void Escrever()
        {
            List<string> linhas = new List<string>();
            linhas.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            Log.Escrever(@"C:\Users\Ma3268\Desktop\escrever.txt", linhas);
        }

        [TestMethod]
        public void EscreverCompletar()
        {
            List<string> linhas = new List<string>();
            linhas.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            Log.EscreverCompletar(@"C:\Users\Ma3268\Desktop\escrever_completar.txt", linhas);
        }

        [TestMethod]
        public void Ler()
        {
            List<string> linhas = Log.Ler(@"C:\Users\Ma3268\Desktop\escrever_completar.txt");
            Assert.IsTrue(linhas.Count > 0);
        }

    }
}
