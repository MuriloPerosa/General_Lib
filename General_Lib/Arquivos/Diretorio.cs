using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Lib.Arquivos
{
    public class Diretorio
    {
        public static void CreateIfNotExists(string diretoio)
        {
            if (!Directory.Exists(diretoio))
            {
                Directory.CreateDirectory(diretoio);
            }
        }

        public static void Delete(string diretorio, bool recursive = true)
        {
            if (Directory.Exists(diretorio))
            {
                Directory.Delete(diretorio, recursive);
            }
        }

        public static void Mover(string diretorio, string destino)
        {
            if (Directory.Exists(diretorio))
            {
                if (!Directory.Exists(destino))
                {
                    Directory.Move(diretorio, destino);
                }
            }
        }

        public static void Limpar(string diretorio)
        {
            if (Directory.Exists(diretorio))
            {
                Delete(diretorio, true);
                CreateIfNotExists(diretorio);
            }
        }

        public static List<string> GetSubPastas(string diretoio)
        {
            List<string> retorno = new List<string>();
            if (Directory.Exists(diretoio))
            {
                retorno = Directory.GetDirectories(diretoio).ToList();
            }

            return retorno;
        }

        public static List<string> GetSubPastas(string diretoio, string searchPattern)
        {
            List<string> retorno = new List<string>();
            if (Directory.Exists(diretoio))
            {
                retorno = Directory.GetDirectories(diretoio, searchPattern).ToList();
            }

            return retorno;
        }

        public static List<string> GetSubPastas(string diretoio, string searchPattern, SearchOption option)
        {
            List<string> retorno = new List<string>();
            if (Directory.Exists(diretoio))
            {
                retorno = Directory.GetDirectories(diretoio, searchPattern, option).ToList();
            }

            return retorno;
        }

        public static List<string> GetArquivos(string diretoio)
        {
            List<string> retorno = new List<string>();
            if (Directory.Exists(diretoio))
            {
                retorno = Directory.GetFiles(diretoio).ToList();
            }

            return retorno;
        }

        public static List<string> GetArquivos(string diretoio, string searchPattern)
        {
            List<string> retorno = new List<string>();
            if (Directory.Exists(diretoio))
            {
                retorno = Directory.GetFiles(diretoio, searchPattern).ToList();
            }

            return retorno;
        }

        public static List<string> GetArquivos(string diretoio, string searchPattern, SearchOption option)
        {
            List<string> retorno = new List<string>();
            if (Directory.Exists(diretoio))
            {
                retorno = Directory.GetFiles(diretoio, searchPattern, option).ToList();
            }

            return retorno;
        }

    }
}
