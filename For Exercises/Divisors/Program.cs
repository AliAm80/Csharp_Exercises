using System;

namespace T1_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\tThis program shows the divisors of a number except itself ...");
            Console.ResetColor();
            Console.WriteLine("Please Enter a number : ");
            var num = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            Console.Clear();
            Console.WriteLine($"The divisors of {num} :");

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"-> {i}");
                    counter++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n The number of divisors => [{counter}] ");
            Console.ResetColor();





        }
    }
}