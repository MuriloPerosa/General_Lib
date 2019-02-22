using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLib
{
    [TestClass]
    public class RecycleBinTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Shell shell = new Shell();
            Folder folder = shell.NameSpace(0x000a);

            foreach (FolderItem2 item in folder.Items())
                Console.WriteLine("FileName:{0}", item.Name);

            Marshal.FinalReleaseComObject(shell);
            Console.ReadLine();
        }
    }
}
