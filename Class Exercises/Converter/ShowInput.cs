using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Converter
{
    public static class ShowInput
    {
        public static int Menu()
        {
            Console.WriteLine("1) Convert Miles To Kilometers");
            Console.WriteLine("2) Convert Kilometers To Miles");
            Console.WriteLine("3) Convert Number To Alphabet");
            Console.WriteLine("4) Convert Number To Day Of Week");
            Console.WriteLine("5) Exit");
            Console.Write("\nEnter a number to execute : ");
            var select = Convert.ToInt32(Console.ReadLine());
            return select;
        }

        public static void Choose(int select)
        {
            switch (select)
            {
                case 1:
                    var input = MilesShow();
                    Converter.MilesToKilometers(input);
                    break;
                case 2:
                    input = KilometersShow();
                    Converter.KilometersToMiles(input);
                    break;
                case 3:
                    input = AlphabetShow();
                    Converter.NumberToAlphabet((int)input);
                    break;
                case 4:
                    input = DayOfWeekShow();
                    Converter.NumberToDayOfWeek((int)input);
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Good Bye :)\n");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR : You entered wrong item !!!");
                    Console.ResetColor();
                    Console.WriteLine("Try again my friend :)");
                    break;

            }
        }
        static double MilesShow()
        {
            Console.Write("Enter the distance in miles : ");
            var number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
        static double KilometersShow()
        {
            Console.Write("Enter the distance in kilometers : ");
            var number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
        static int AlphabetShow()
        {
            Console.Write("Enter a number between 1 to 10 : ");
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        static int DayOfWeekShow()
        {
            Console.Write("Enter a number between 1 to 7 for day of the week : ");
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

    }
}