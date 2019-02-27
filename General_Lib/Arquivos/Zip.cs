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
        public static bool Zipar(List<string> arquivos, string arquivoZip, bool isDiretorio)
        {
            try
            {
                using (var zip = new ZipFile(Encoding.Default))
                {
                    foreach (string path in arquivos)
                    {
                        string fileName = Path.GetFileName(path);
                        if (Directory.Exists(path))
                        {
                            if (isDiretorio)
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
                    zip.Save(arquivoZip);
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
