using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Converter
{
    public static class Converter
    {
        public static void MilesToKilometers(double mile)
        {
            var result = mile * 1.60934;
            Console.WriteLine($"\n{mile} miles is equal to {result} kilometers\n");
        }
        public static void KilometersToMiles(double kilometer)
        {
            var result = kilometer / 1.60934;
            Console.WriteLine($"\n{kilometer} kilometers is equal to {result} miles\n");
        }
        public static void NumberToAlphabet(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine(" Result --> One ");
                    break;
                case 2:
                    Console.WriteLine(" Result --> Two ");
                    break;
                case 3:
                    Console.WriteLine(" Result --> Three ");
                    break;
                case 4:
                    Console.WriteLine(" Result --> Four ");
                    break;
                case 5:
                    Console.WriteLine(" Result --> Five ");
                    break;
                case 6:
                    Console.WriteLine(" Result --> Six ");
                    break;
                case 7:
                    Console.WriteLine(" Result --> Seven ");
                    break;
                case 8:
                    Console.WriteLine(" Result --> Eight ");
                    break;
                case 9:
                    Console.WriteLine(" Result --> Nine ");
                    break;
                case 10:
                    Console.WriteLine(" Result --> Ten ");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR : You entered out of range !!!");
                    Console.ResetColor();
                    break;

            }
        }

        public static void NumberToDayOfWeek(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Today is Saturday :)");
                    break;
                case 2:
                    Console.WriteLine("Today is Sunday :)");
                    break;
                case 3:
                    Console.WriteLine("Today is Monday :)");
                    break;
                case 4:
                    Console.WriteLine("Today is Tuesday :)");
                    break;
                case 5:
                    Console.WriteLine("Today is Wednesday :)");
                    break;
                case 6:
                    Console.WriteLine("Today is Thursday :)");
                    break;
                case 7:
                    Console.WriteLine("Today is Friday :)");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR : You entered out of range !!!");
                    Console.ResetColor();
                    break;
            }

        }
    }
}