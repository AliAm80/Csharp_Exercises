using System;

namespace Challange_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Caption
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t*This program works based on the Pythagoras relation !!!*");
            Console.ResetColor();
            // Enter Sides
            Console.WriteLine("Please Enter Side A :");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Side B :");
            int side2 = Convert.ToInt32(Console.ReadLine());
            // Calculations
            int pS1 = (int)Math.Pow(side1, 2);
            int pS2 = (int)Math.Pow(side2, 2);
            int sum = pS1 + pS2;
            // Result
            double result = Math.Sqrt(sum);
            Console.WriteLine($"The Result is : [{result}]");






        }
    }
}