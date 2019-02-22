using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Lib.Dados
{
    public class Dinheiro
    {
        private static System.Globalization.CultureInfo US = new System.Globalization.CultureInfo("en-US");
        private static System.Globalization.CultureInfo BR = new System.Globalization.CultureInfo("pt-BR");
        private static System.Globalization.CultureInfo FR = new System.Globalization.CultureInfo("fr-FR");

        public static string ConverterReal(double valor)
        {
            return valor.ToString("C2", BR);
        }
        public static string ConverterReal(int valor)
        {
            return valor.ToString("C2", BR);
        }
        public static string ConverterReal(float valor)
        {
            return valor.ToString("C2", BR);
        }
        public static string ConverterReal(decimal valor)
        {
            return valor.ToString("C2", BR);
        }

        public static string ConverterDolar(double valor)
        {
            return valor.ToString("C2", US);
        }
        public static string ConverterDolar(int valor)
        {
            return valor.ToString("C2", US);
        }
        public static string ConverterDolar(float valor)
        {
            return valor.ToString("C2", US);
        }
        public static string ConverterDolar(decimal valor)
        {
            return valor.ToString("C2", US);
        }

        public static string ConverterEuro(double valor)
        {
            return valor.ToString("C2", FR);
        }
        public static string ConverterEuro(int valor)
        {
            return valor.ToString("C2", FR);
        }
        public static string ConverterEuro(float valor)
        {
            return valor.ToString("C2", FR);
        }
        public static string ConverterEuro(decimal valor)
        {
            return valor.ToString("C2", FR);
        }
    }
}
