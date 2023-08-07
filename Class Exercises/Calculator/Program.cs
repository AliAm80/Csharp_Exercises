using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t------------------");
                Console.WriteLine("\t\t\t\tCalculator Program");
                Console.WriteLine("\t\t\t\t------------------");
                GetNumbers(cal);
                cal.PrintOptions();
                cal.Operator = Console.ReadLine();


                try
                {
                    cal.Process();
                    Console.WriteLine(cal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Would you like to continue ? (Y = yes, N = no)");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye :)");



        }

        public static void GetNumbers(Calculator calculator)
        {
            try
            {
                Console.Write("Enter Number 1 : ");
                calculator.FirstOperand = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Number 2 : ");
                calculator.SecondOperand = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please Enter Number !");
                Environment.Exit(0);
            }

        }
    }
}