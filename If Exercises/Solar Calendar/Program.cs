using System;

namespace T4_if
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter The Number
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\tThis Program get number between 1 ~ 366 & shows month and day to Shamse ...");
            Console.ResetColor();
            Console.WriteLine("Please Enter Number : ");
            var num = Convert.ToInt32(Console.ReadLine());
            // Calculate Month & Day
            var day = 0;
            var month = 0;
            if (num < 1 || num > 366)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\tYour Number is Out Of Range , Please Try Again !!!");
                Console.ResetColor();

            }
            else
            {

                if (num <= 186)
                {
                    day = num % 31;
                    month = num / 31 + 1;
                    if (day == 0)
                    {
                        day = 31;
                        month--;
                    }
                }
                else
                {
                    num = num - 186;
                    day = num % 30;
                    month = num / 30 + 7;
                    if (day == 0)
                    {
                        day = 30;
                        month--;
                    }
                }
                // Result
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Month [{month}] / Day [{day}]");
                Console.ResetColor();

            }




        }
    }
}