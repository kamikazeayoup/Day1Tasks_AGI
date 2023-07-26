using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempretureConvert
{
    public static class TempretureConverts
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fehrenheit = celsius * 9 / 5 + 32;
            return fehrenheit;
        }
    }
}

