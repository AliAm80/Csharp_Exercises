using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_9
{
    public class Calculator
    {

        double Number1 { get; set; }
        double Number2 { get; set; }
        string Option { get; set; }
        double Result { get; set; }
        public Calculator()
        {
            Console.Write("Enter Number 1 : ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Option = Menu();
            SelectOption(Option);
        }

        static string Menu()
        {
            Console.WriteLine("Options : ");
            Console.WriteLine("\t + : Add ");
            Console.WriteLine("\t - : Substract ");
            Console.WriteLine("\t * : Multiply ");
            Console.WriteLine("\t / : Divide ");
            Console.Write("Enter an option :");
            var option = Console.ReadLine();
            return option;
        }
        void SelectOption(string option)
        {
            switch (option)
            {
                case "+":
                    Result = AddCal(Number1, Number2);
                    Console.WriteLine($"{Number1} + {Number2} = {Result}");
                    break;
                case "-":
                    Result = SubstractCal(Number1, Number2);
                    Console.WriteLine($"{Number1} - {Number2} = {Result}");
                    break;
                case "*":
                    Result = MultiplyCal(Number1, Number2);
                    Console.WriteLine($"{Number1} * {Number2} = {Result}");
                    break;
                case "/":
                    Result = DivideCal(Number1, Number2);
                    Console.WriteLine($"{Number1} / {Number2} = {Result}");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR : That was not a valid option !!!");
                    Console.ResetColor();
                    break;

            }

        }

        static double AddCal(double num1, double num2)
        {
            return num1 + num2;
        }
        static double SubstractCal(double num1, double num2)
        {
            return num1 - num2;
        }
        static double MultiplyCal(double num1, double num2)
        {
            return num1 * num2;
        }
        static double DivideCal(double num1, double num2)
        {
            return num1 / num2;
        }



    }
}