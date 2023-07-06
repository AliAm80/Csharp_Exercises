using System;

namespace T2_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get opreator & operands
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t This Progarm is calculator ...");
            Console.ResetColor();
            Console.WriteLine("Please Enter Number 1 :");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Number 2 :");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter operator : (+, -, *, /)");
            var op = Console.ReadLine();
            // calculate
            string result;
            Console.ForegroundColor = ConsoleColor.Green;
            switch (op)
            {
                case "+":
                    var sum = num1 + num2;
                    result = $"The result is => [{sum}]";
                    break;
                case "-":
                    var minus = num1 - num2;
                    result = $"The result is => [{minus}]";
                    break;
                case "*":
                    var multiple = num1 + num2;
                    result = $"The result is => [{multiple}]";
                    break;
                case "/":
                    var divide = num1 / num2;
                    result = $"The result is => [{divide}]";
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    result = "Sorry! your opreator does not support :(";
                    break;
            }

            Console.WriteLine(result);
            Console.ResetColor();
      
        }
    }
}