using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate(args);
            Excution(args);
        }

        static void Validate(string[] args)
        {
            if (args.Length == 0 || args[0] != "bmi"|| args.Length == 1)
            {
                ErrorCommand();
                Environment.Exit(0);
            }

            else if (args[1] == "--helps")
            {
                helpCommand();
                Environment.Exit(0);
            }
            else if (args[1] == "--version")
            {
                versionCommand();
                Environment.Exit(0);
            }

        }

        static void helpCommand()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nList Of Switches For Running Program :\n");
            Console.WriteLine("--helps\tshow command list");
            Console.WriteLine("--version\tshow current version");
            Console.WriteLine("--height\tYour height (centimeter)");
            Console.WriteLine("--weight\tYour weight (kilogram)");
            Console.ResetColor();
            Console.WriteLine("\n\n");
        }
        static void versionCommand()
        {
            Console.WriteLine("\n Current version is -> 1.0\n");
        }

        static void Excution(string[] args)
        {

            var firstSwitch = args[1];
            var firstArg = args[2];
            var secondSwitch = args[3];
            var secondArg = args[4];

            double height, weight;

            switch (firstSwitch)
            {
                case "--height":
                    if (secondSwitch != "--weight")
                    {
                        ErrorCommand();
                        break;
                    }
                    height = Convert.ToDouble(firstArg);
                    weight = Convert.ToDouble(secondArg);
                    BmiCal(height, weight);
                    break;
                case "--weight":
                    if (secondSwitch != "--height")
                    {
                        ErrorCommand();
                        break;
                    }
                    height = Convert.ToDouble(secondArg);
                    weight = Convert.ToDouble(firstArg);
                    BmiCal(height, weight);
                    break;
                default:
                    ErrorCommand();
                    break;


            }

        }

        static void BmiCal(double height, double weight)
        {
            height /= 100;
            var bmi = Math.Round(weight / (height * height));
            BmiShow(bmi);
        }
        static void BmiShow(double bmi)
        {
            if (bmi <= 18.4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n[{bmi}] => Your Status is : Underweight\n");
                Console.ResetColor();
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n[{bmi}] => Your Status is : Normal\n");
                Console.ResetColor();
            }
            else if (bmi >= 25 && bmi <= 39.9)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\n[{bmi}] => Your Status is : Overweight\n");
                Console.ResetColor();
            }
            else if (bmi >= 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n[{bmi}] => Your Status is : Obese \n");
                Console.ResetColor();
            }
        }
        static void ErrorCommand()
        {
            Console.WriteLine("\nInvalid Command !!!");
            Console.WriteLine("use --helps switch to show help\n");
        }

    }
}

