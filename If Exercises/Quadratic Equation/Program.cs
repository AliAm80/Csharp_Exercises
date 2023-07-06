using System;

namespace T3_if
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Coefficients
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\tThis program is based on a quadratic equation(a(x^2) + bx + c = 0) to calculate delta ...");
            Console.ResetColor();
            Console.WriteLine("Please Enter Coefficient a : ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Coefficient b : ");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Coefficient c : ");
            var c = Convert.ToInt32(Console.ReadLine());
            // Calculate Delta 
            var delta = (b * b) - 4 * a * c;
            double x1, x2 = 0;
            if (a == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("This Equation is Linear Equation");
                Console.ResetColor();
            }
            else
            {
                if (delta > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine($"X1 = [{x1}] , X2 = [{x2}]");
                    Console.ResetColor();
                }
                else if (delta == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    x1 = -b / 2 * a;
                    Console.WriteLine($"X1 = [{x1}] ");
                    Console.ResetColor();
                }
                else if (delta < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Answer");
                    Console.ResetColor();
                }

            }





        }
    }
}