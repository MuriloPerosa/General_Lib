using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General_Lib
{
    public class Sistema
    {
        public static bool Executar(string caminho)
        {
            try
            {
                System.Diagnostics.Process.Start(caminho);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetExecutingAssemblyLocation()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().Location;
        }

        public static string GetExecutingAssemblyCodeBase()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
        }

        public static string GetApplicationExecutablePath()
        {
            return Application.ExecutablePath;
        }

        public static string GetApplicationStartUpPath()
        {
            return Application.StartupPath;
        }

        public static string GetProductName()
        {
            return Application.ProductName;
        }

        public static string GetProductVersion()
        {
            return Application.ProductVersion;
        }

        public static void Start()
        {
            Application.Run();
        }

        public static void Exit()
        {
            Application.Exit();
        }

        public static void Restart()
        {
            Application.Restart();
        }
    }
}
