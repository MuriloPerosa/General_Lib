using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using General_Lib.Arquivos;
using System.Collections.Generic;

namespace TestLib
{
    [TestClass]
    public class ZipTest
    {
        [TestMethod]
        public void Zip()
        {
            List<string> arquivos = new List<string>();
            arquivos.Add(@"C:\Users\Ma3268\Desktop\teste");
            General_Lib.Arquivos.Zip.Compress(arquivos,@"C:\Users\Ma3268\Desktop\teste.zip", true);
            Arquivo.Move(@"C:\Users\Ma3268\Desktop\teste.zip", @"C:\Users\Ma3268\Desktop\teste\teste.zip");
        }
    }
}
