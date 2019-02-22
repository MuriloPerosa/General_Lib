using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Lib.Arquivos
{
    public class Arquivo
    {
        public static void Create(string arquivo)
        {
            File.Create(arquivo);
        }

        public static void CreateAndClose(string arquivo)
        {
            var myFile = File.Create(arquivo);
            myFile.Close();
        }

        public static void CreateIfNotExists(string arquivo)
        {
            if (!File.Exists(arquivo))
            {
                File.Create(arquivo);
            }
        }

        public static void CreateIfNotExistsClose(string arquivo)
        {
            if (!File.Exists(arquivo))
            {
                var myFile = File.Create(arquivo);
                myFile.Close();
            }
        }

        public static void Copy(string arquivo, string destino, bool overwrite = true)
        {
            if (File.Exists(arquivo))
            {
                File.Copy(arquivo, destino, overwrite);
            }
        }

        public static void Delete(string arquivo)
        {
            if (File.Exists(arquivo))
            {
                File.Delete(arquivo);
            }
        }

        public static void Move(string arquivo, string destino)
        {
            if (File.Exists(arquivo))
            {
                if (!File.Exists(destino))
                {
                    File.Move(arquivo, destino);
                }
            }
        }

        public static byte[] GetBytes(string arquivo)
        {
            if (File.Exists(arquivo))
            {
                byte[] retorno;
                using (StreamReader sourceStream = new StreamReader(arquivo))
                {
                    retorno = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                }
                return retorno;
            }
            else
            {
                return null;
            }

        }
    }
}
