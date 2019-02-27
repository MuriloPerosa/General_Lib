using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Lib.Arquivos
{
    public class Log
    {
        public static void Escrever(string path, List<string> linhas)
        {
            if (!File.Exists(path))
            {
                Arquivo.CreateAndClose(path);
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, false))
            {
                foreach (var linha in linhas)
                {
                    file.WriteLine(linha);
                }

            }
        }

        public static void EscreverCompletar(string path, List<string> linhas)
        {

            if (!File.Exists(path))
            {
                File.Create(path);
            }


            List<string> textos = new List<string>();
            if (File.Exists(path))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    textos.Add(line);
                }
                file.Close();
            }

            textos.AddRange(linhas);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, false))
            {
                foreach (var linha in textos)
                {
                    file.WriteLine(linha);
                }
            }
        }

        public static List<string> Ler(string path)
        {
            List<string> retorno = new List<string>();
            if (File.Exists(path))
            {
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    retorno.Add(line);
                }
            }
            return retorno;
        }
    }
}
