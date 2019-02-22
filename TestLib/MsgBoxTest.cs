using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using General_Lib;

namespace TestLib
{
    [TestClass]
    public class MsgBoxTest
    {
        [TestMethod]
        public void ATENCAO()
        {
            MsgBox.Atencao("Teste");
        }

        [TestMethod]
        public void SUCESSO()
        {
            MsgBox.Sucesso("Teste");
        }

        [TestMethod]
        public void ERRO()
        {
            MsgBox.Erro("Teste");
        }

        [TestMethod]
        public void PERGUNTA()
        {
            if (MsgBox.Pergunta("Sim ou Não?"))
            {
                MsgBox.Sucesso("Sim");
            }
            else
            {
                MsgBox.Sucesso("Não");
            }
        }
    }
}
