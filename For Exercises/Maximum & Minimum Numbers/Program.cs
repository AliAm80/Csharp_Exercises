using System;

namespace T4_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\tThis program shows Maximum number & minimum number ...");
            Console.ResetColor();
            Console.WriteLine("How many numbers do you have ?");
            var number = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Enter Number[{i + 1}] : ");
                var num = Convert.ToInt32(Console.ReadLine());
                numbers[i] = num;
            }

            int min = numbers[0];
            int max = numbers[0];

            foreach (int n in numbers)
            {

                if (n > max)
                {
                    max = n;
                }
                if (n < min)
                {
                    min = n;
                }

            }
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            if (min == max)
            {
                Console.WriteLine($"{min} is minimum & Maximum number");

            }
            else
            {
                Console.WriteLine($"{min} is minimum number");
                Console.WriteLine($"{max} is Maximum number");

            }
            Console.ResetColor();


        }
    }
}