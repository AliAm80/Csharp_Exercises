using System;

namespace T2_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\tThis program shows perfect numbers ...");
            Console.ResetColor();
            Console.WriteLine("Please Enter a number :");
            var num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.Clear();
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }

            }
            if (sum == num)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{num} is a perfect Number :)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{num} is not a perfect Number !!!");
            }
            Console.ResetColor();





        }
    }
}