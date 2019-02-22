using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using General_Lib;
using General_Lib.UserInterface;

namespace TestLib
{
    [TestClass]
    public class SistemaTest
    {
        [TestMethod]
        public void Executar()
        {
            Assert.IsTrue(Sistema.Executar(@"C:\Users\Ma3268\Desktop\db.txt"));
            Assert.IsFalse(Sistema.Executar(@"C:\Users\Ma3268\Desktop\dbdsada.txt"));
        }

        [TestMethod]
        public void Teste()
        {
            MsgBox.Sucesso(Sistema.GetExecutingAssemblyCodeBase());
            MsgBox.Sucesso(Sistema.GetExecutingAssemblyLocation());
            MsgBox.Sucesso(Sistema.GetApplicationExecutablePath());
            MsgBox.Sucesso(Sistema.GetApplicationStartUpPath());
            MsgBox.Sucesso(Sistema.GetProductName());
            MsgBox.Sucesso(Sistema.GetProductVersion());
        }

        [TestMethod]
        public void Prompt()
        {
            string retornoPass = PromptDialog.Prompt("Label", "Título", inputType: PromptDialog.InputType.Password);
            string retornotext = PromptDialog.Prompt("Label", "Título", inputType: PromptDialog.InputType.Text);
        }
    }
}
