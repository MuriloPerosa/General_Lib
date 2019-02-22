using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Lib.Dados
{
    public class Texto
    {
        public static bool ContemLetras(string texto)
        {
            if (texto.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            else
                return false;
        }

        public static bool ContemNumeros(string texto)
        {
            if (texto.Where(c => char.IsNumber(c)).Count() > 0)
                return true;
            else
                return false;
        }

        public static bool EmailValido(string texto)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(texto);
                return addr.Address == texto;
            }
            catch
            {
                return false;
            }
        }

        private static Random random = new Random();
        public static string TextoRandon(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static double ToDouble(string texto)
        {
            double retorno;
            Double.TryParse(texto, out retorno);
            return retorno;
        }

        public static int ToInt(string texto)
        {
            int retorno;
            int.TryParse(texto, out retorno);
            return retorno;
        }

        public static float ToFloat(string texto)
        {
            float retorno;
            float.TryParse(texto, out retorno);
            return retorno;
        }

        public static DateTime ToDateTime(string texto)
        {
            DateTime retorno;
            DateTime.TryParse(texto, out retorno);
            return retorno;
        }

        public static DateTime ToDateTimeLocalToDate(string texto)
        {
            try
            {
                IFormatProvider culture = new CultureInfo("en-US", true);
                DateTime datetime = Convert.ToDateTime(DateTime.ParseExact(texto.Replace("T", " "), "yyyy-MM-dd HH:mm:ss", culture));
                return datetime;
            }
            catch (Exception)
            {
                try
                {
                    IFormatProvider culture = new CultureInfo("en-US", true);
                    DateTime datetime = Convert.ToDateTime(DateTime.ParseExact(texto.Replace("T", " "), "yyyy-MM-dd HH:mm", culture));
                    return datetime;
                }
                catch (Exception)
                {

                    return new DateTime();
                }
            }
        }

    }
}
