using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Lib.Arquivos
{
    public class Zip
    {
        public static bool Compress(List<string> fileList, string zipName, bool isDirStruct)
        {
            try
            {
                using (var zip = new ZipFile(Encoding.Default))
                {
                    foreach (string path in fileList)
                    {
                        string fileName = Path.GetFileName(path);
                        if (Directory.Exists(path))
                        {
                            if (isDirStruct)
                            {
                                zip.AddDirectory(path, fileName);
                            }
                            else
                            {
                                zip.AddDirectory(path);
                            }
                        }
                        if (File.Exists(path))
                        {
                            zip.AddFile(path);
                        }
                    }
                    zip.Save(zipName);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
