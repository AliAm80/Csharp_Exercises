using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Converter
{
    public static class ShowInput
    {
        public static double MilesShow()
        {
            Console.Write("Enter the distance in miles : ");
            var number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
        public static double KilometersShow()
        {
            Console.Write("Enter the distance in kilometers : ");
            var number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
        
    }
}