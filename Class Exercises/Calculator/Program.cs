using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var again = true;

            try
            {
                while (again)
                {
                    Console.WriteLine("\t\t\t\t\t------------------");
                    Console.WriteLine("\t\t\t\t\tCalculator Program");
                    Console.WriteLine("\t\t\t\t\t------------------");
                    Calculator cal = new Calculator();
                    Console.WriteLine("Would you like to continue ? (Y = yes, N = no)");
                    var answer = Console.ReadLine();
                    answer = answer.ToUpper();
                    Console.Clear();
                    if (answer == "Y")
                    {
                        again = true;
                    }
                    else if (answer == "N")
                    {
                        again = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR : You entered invalid !!!");
                        Console.ResetColor();
                        again = false;
                    }

                }
                Console.WriteLine("Bye :)\n");
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                Console.WriteLine("Please Enter Number :)\n");
                
            }


        }
    }
}