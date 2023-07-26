using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Converter
{
    public static class Converter
    {
        public static double MilesToKilometers(double mile)
        {
            return mile * 1.6;
        }
        public static double KilometersToMiles(double kilometer)
        {
            return kilometer / 1.6;
        }
    }
}