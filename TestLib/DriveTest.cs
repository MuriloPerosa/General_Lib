using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using General_Lib.Arquivos;
using System.IO;

namespace TestLib
{
    [TestClass]
    public class DriveTest
    {
        [TestMethod]
        public void GetAll()
        {
            List<DriveInfo> drives = Drive.GetAll();
        }

        [TestMethod]
        public void GetAllNework()
        {
            List<DriveInfo> drives = Drive.GetAllNetwork();
        }

        [TestMethod]
        public void GetAllLocal()
        {
            List<DriveInfo> drives = Drive.GetAllLocal();
        }
        
        [TestMethod]
        public void GetAllRemovable()
        {
            List<DriveInfo> drives = Drive.GetAllRemovable();
        }

        [TestMethod]
        public void GetAllCDRom()
        {
            List<DriveInfo> drives = Drive.GetAllCDRom();
        }


        [TestMethod]
        public void GetAllNoRoot()
        {
            List<DriveInfo> drives = Drive.GetAllNoRoot();
        }

        [TestMethod]
        public void GetAllRam()
        {
            List<DriveInfo> drives = Drive.GetAllRam();
        }

        [TestMethod]
        public void GetAllUnknown()
        {
            List<DriveInfo> drives = Drive.GetAllUnknown();
        }

        [TestMethod]
        public void DriveInfo()
        {
            DriveInfo d = new DriveInfo("C");
        }
    }
}
