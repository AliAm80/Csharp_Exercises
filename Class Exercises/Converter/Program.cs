using System;

namespace Ex_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\tWelcome To Converter :)\n");
            Console.ResetColor();

            Console.WriteLine("1) Miles To Kilometers");
            Console.WriteLine("2) Kilometers To Miles\n");

            Console.Write("Enter the number -> ");
            var converter = Console.ReadLine();
            double number;
            double result;
            Console.Clear();
            if (converter == "1")
            {
                number = ShowInput.MilesShow();
                result = Converter.MilesToKilometers(number);
                Console.WriteLine($"\n{number} miles is equal to {result} kilometers\n");
                
            }
            else if (converter == "2")
            {
                number = ShowInput.KilometersShow();
                result = Converter.KilometersToMiles(number);
                Console.WriteLine($"\n{number} kilometers is equal to {result} miles\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nERROR : You entered Invalid !!!\n");
                Console.ResetColor();
            }

        }
    }
}