using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Lib.Arquivos
{
    public class Drive
    {
        public static List<DriveInfo> GetAll()
        {
            return DriveInfo.GetDrives().ToList();
        }

        public static List<DriveInfo> GetAllNetwork()
        {
            return DriveInfo.GetDrives().ToList().FindAll(x => x.DriveType == DriveType.Network);
        }

        public static List<DriveInfo> GetAllLocal()
        {
            return DriveInfo.GetDrives().ToList().FindAll(x => x.DriveType == DriveType.Fixed);
        }

        public static List<DriveInfo> GetAllRemovable()
        {
            return DriveInfo.GetDrives().ToList().FindAll(x => x.DriveType == DriveType.Removable);
        }

        public static List<DriveInfo> GetAllCDRom()
        {
            return DriveInfo.GetDrives().ToList().FindAll(x => x.DriveType == DriveType.CDRom);
        }

        public static List<DriveInfo> GetAllNoRoot()
        {
            return DriveInfo.GetDrives().ToList().FindAll(x => x.DriveType == DriveType.NoRootDirectory);
        }

        public static List<DriveInfo> GetAllRam()
        {
            return DriveInfo.GetDrives().ToList().FindAll(x => x.DriveType == DriveType.Ram);
        }

        public static List<DriveInfo> GetAllUnknown()
        {
            return DriveInfo.GetDrives().ToList().FindAll(x => x.DriveType == DriveType.Unknown);
        }
    }
}
