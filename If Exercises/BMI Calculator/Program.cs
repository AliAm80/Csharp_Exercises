using System;

namespace T1_if
{
    class Program
    {
        static void Main(string[] args)
        {
            // BMI Calculator
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t\t\tHello,This Progarm (BMI) Has Been Created To Help With Your Health ...s");
            Console.ResetColor();
            // Get Weight & Height
            Console.WriteLine("Please Enter Your Weight (kg) : ");
            var weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Your Height (cm) : ");
            var height = Convert.ToDouble(Console.ReadLine());
            // Convert cm to m
            var height_new = height / 100;
            // Calculate BMI
            var bmi = weight / (height_new * height_new);
            // Analyze The Status
            if (bmi <= 18.4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[{bmi}] => Your Status is Underweight");
                Console.ResetColor();

            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[{bmi}] => Your Status is Normal");
                Console.ResetColor();

            }
            else if (bmi >= 25 && bmi <= 39.9)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"[{bmi}] => Your Status is Overweight");
                Console.ResetColor();
            }
            else if (bmi >= 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[{bmi}] => Your Status is Obese ");
                Console.ResetColor();
            }



        }
    }
}