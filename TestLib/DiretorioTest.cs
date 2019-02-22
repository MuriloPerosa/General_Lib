using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using General_Lib.Arquivos;
using System.IO;
using System.Collections.Generic;

namespace TestLib
{
    [TestClass]
    public class DiretorioTest
    {
        static string diretorio1 = @"C:\Users\Ma3268\Desktop\Teste1\";
        static string diretorio1IN = @"C:\Users\Ma3268\Desktop\Teste1\Internal\";
        static string diretorio1IN_In = @"C:\Users\Ma3268\Desktop\Teste1\Internal\In\";
        static string diretorio2IN = @"C:\Users\Ma3268\Desktop\Teste1\XX\";
        static string diretorio2 = @"C:\Users\Ma3268\Desktop\Teste2\";

        [TestMethod]
        public void CreateIfNotExists()
        {
            Diretorio.CreateIfNotExists(diretorio1);
            var myfile = File.Create(diretorio1 + "file.txt");
            myfile.Close();
            myfile = File.Create(diretorio1 + "file_2.pdf");
            myfile.Close();
            myfile = File.Create(diretorio1 + "file_3.txt");
            myfile.Close();

            Diretorio.CreateIfNotExists(diretorio1IN);
            myfile = File.Create(diretorio1IN + "file.txt");
            myfile.Close();
            myfile = File.Create(diretorio1IN + "file_2.pdf");
            myfile.Close();
            myfile = File.Create(diretorio1IN + "file_3.txt");
            myfile.Close();

            Assert.IsTrue(Directory.Exists(diretorio1IN));
            Diretorio.CreateIfNotExists(diretorio1IN_In);
            Diretorio.CreateIfNotExists(diretorio2IN);


            Assert.IsTrue(Directory.Exists(diretorio1));
            Assert.IsTrue(Directory.Exists(diretorio1IN));
            Assert.IsTrue(Directory.Exists(diretorio2IN));
        }

        [TestMethod]
        public void GetSubPastas()
        {
            List<string> SubPastas = Diretorio.GetSubPastas(diretorio1);
            Assert.IsTrue(SubPastas.Count == 2);

            List<string> SubPastas2 = Diretorio.GetSubPastas(diretorio1, "XX");
            Assert.IsTrue(SubPastas2.Count == 1);

            List<string> SubPastas3 = Diretorio.GetSubPastas(diretorio1, "*.*", SearchOption.AllDirectories);
            Assert.IsTrue(SubPastas3.Count == 3);
        }

        [TestMethod]
        public void GetArquivos()
        {
            List<string> arquivos = Diretorio.GetArquivos(diretorio1);
            Assert.IsTrue(arquivos.Count == 3);

            arquivos = Diretorio.GetArquivos(diretorio1, "*.pdf");
            Assert.IsTrue(arquivos.Count == 1);


            arquivos = Diretorio.GetArquivos(diretorio1, "*.pdf", SearchOption.AllDirectories);
            Assert.IsTrue(arquivos.Count == 2);
        }

        [TestMethod]
        public void Mover()
        {
            Diretorio.Mover(diretorio1IN, diretorio2);
            Assert.IsTrue(Directory.Exists(diretorio2));
            Assert.IsTrue(Directory.Exists(diretorio2 + @"\In"));
            Assert.IsTrue(Diretorio.GetArquivos(diretorio2).Count == 3);
            Assert.IsFalse(Directory.Exists(diretorio1IN));
        }

        [TestMethod]
        public void Limpar()
        {
            Diretorio.Limpar(diretorio2);
            Assert.IsTrue(Directory.Exists(diretorio2));
            Assert.IsFalse(Directory.Exists(diretorio2 + @"\In"));
            Assert.IsTrue(Diretorio.GetArquivos(diretorio2).Count == 0);
        }

        [TestMethod]
        public void Deletar()
        {
            Diretorio.Delete(diretorio1, true);
            Diretorio.Delete(diretorio1IN, true);
            Diretorio.Delete(diretorio2IN, true);
            Diretorio.Delete(diretorio2, true);

            Assert.IsFalse(Directory.Exists(diretorio1));
            Assert.IsFalse(Directory.Exists(diretorio1IN));
            Assert.IsFalse(Directory.Exists(diretorio2IN));
            Assert.IsFalse(Directory.Exists(diretorio2));
        }
    }
}
