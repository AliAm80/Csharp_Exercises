using System;

namespace T3_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\tThis program shows prime numbers ...");
            Console.ResetColor();
            Console.WriteLine("Please Enter a number :");
            var num = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            Console.Clear();
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{num} is a prime number :)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{num} is not a prime number !!!");
            }
            Console.ResetColor();



        }
    }
}