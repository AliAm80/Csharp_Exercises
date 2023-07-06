using System;

namespace T3_switch
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
                // Result & Choose set for month and day
                var set = 0;
                string set_show;
                Console.WriteLine("Which set do you choose for the result ? ");
                Console.WriteLine("1) Month [{month}] / Day [{day}]");
                Console.WriteLine("2) {month}/{day}");
                Console.WriteLine("3) {month}m, {day}d");
                Console.WriteLine("\nEnter the set number :");
                set = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;
                switch (set)
                {
                    case 1:
                        set_show = $"Date : Month [{month}] / Day [{day}]";
                        Console.WriteLine(set_show);
                        break;
                    case 2:
                        set_show = $"Date : {month}/{day}";
                        Console.WriteLine(set_show);
                        break;
                    case 3:
                        set_show = $"Date : {month}m, {day}d";
                        Console.WriteLine(set_show);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("E R R O R");
                        break;


                }
                Console.ResetColor();

            }




        }
    }
}