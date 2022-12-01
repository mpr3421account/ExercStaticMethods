using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExercStaticMethods
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double Converter(double money, double cotation)
        {
            double total = money * cotation;
            return total + total * IOF / 100;
        }
    }
}
