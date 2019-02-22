using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Lib.Dados
{
    public class Calculo
    {
        public static double Porcentagem(double Total, double Atual, int decimais = 2)
        {
            return Math.Round(((100 * Atual) / Total), 2);
        }

        public static double GrausParaRadianos(double angulo)
        {
            return Math.PI * angulo / 180.0;
        }

        public static double RadianosParaGraus(double angulo)
        {
            return angulo * (180.0 / Math.PI);
        }
    }
}
