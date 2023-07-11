using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            validate(args);
        }

        static void validate(string[] args)
        {
            if (args.Length == 0 || args.Length == 1)
            {
                Console.WriteLine("\nInvalid Command !!!");
                Console.WriteLine("use --helps switch to show help\n");
            }
            else if (args[0] != "bmi")
            {
                Console.WriteLine("\nInvalid Command !!!");
                Console.WriteLine("use --helps switch to show help\n");
            }
              switch (args[1])
            {
                case "--helps":
                    helpCommand(args[0], args[1]);
                    break;
                case "--version":
                    versionCommand(args[0], args[1]);
                    break;
                case "--height":
                if (args.Length == 5)
                {
                    bmiCal(args[0], args[1], args[2], args[3], args[4]);
                }
                else
                {
                    Console.WriteLine("\nInvalid Command !!!");
                    Console.WriteLine("use --helps switch to show help\n");
                }
                    break;
                case "--weight":
                  if (args.Length == 5)
                {
                    bmiCal(args[0], args[1], args[2], args[3], args[4]);
                }
                else
                {
                    Console.WriteLine("\nInvalid Command !!!");
                    Console.WriteLine("use --helps switch to show help\n");
                }
                    break;
                default:
                    Console.WriteLine("\nInvalid Command !!!");
                    Console.WriteLine("use --helps switch to show help\n");
                    break;
            }

        }

        static void helpCommand(string bmi, string help)
        {
           

            if (bmi == "bmi" && help == "--helps")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nList Of Switches For Running Program :\n");
                Console.WriteLine("--helps                     show command list");
                Console.WriteLine("--version                   show current version");
                Console.WriteLine("--height                    Your height (centimeter)");
                Console.WriteLine("--weight                    Your weight (kilogram)");
                Console.ResetColor();
                Console.WriteLine("\n\n");
            }
            else
            {
                Console.WriteLine("\nInvalid Command !!!");
                Console.WriteLine("use --helps switch to show help\n");

            }

        }
        static void versionCommand(string bmi, string version)
        {

            if (bmi == "bmi" && version == "--version")
            {
                Console.WriteLine("\n Current version is -> 1.0\n");
            }
            else
            {
                Console.WriteLine("\nInvalid Command !!!");
                Console.WriteLine("use --helps switch to show help\n");
            }
        }

        static void bmiCal(string bmi, string model_1, string num1, string model_2, string num2)
        {

            double num_1 = Convert.ToDouble(num1);
            double num_2 = Convert.ToDouble(num2);
            if (num_1 == 0 || num_2 == 0)
            {
                Console.WriteLine("\nI can not calculate when you entered zero value ...");
                Console.WriteLine("use --helps switch to show help\n");
            }
            switch (model_1)
            {
                case "--height":
                    if (bmi == "bmi" && model_1 == "--height" && model_2 == "--weight")
                    {
                        num_1 /= 100;
                        var num = num_2 / (num_1 * num_1);
                        bmiShow(num);
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Command !!!");
                        Console.WriteLine("use --helps switch to show help\n");
                    }
                    break;
                case "--weight":
                    if (bmi == "bmi" && model_1 == "--weight" && num1 != null && model_2 == "--height" && num2 != null)
                    {
                        num_2 /= 100;
                        var num = num_1 / (num_2 * num_2);
                        bmiShow(num);
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Command !!!");
                        Console.WriteLine("use --helps switch to show help\n");
                    }
                    break;
            }

        }
        static void bmiShow(double num)
        {
            if (num <= 18.4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n[{num}] => Your Status is : Underweight\n");
                Console.ResetColor();
            }
            else if (num >= 18.5 && num <= 24.9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n[{num}] => Your Status is : Normal\n");
                Console.ResetColor();
            }
            else if (num >= 25 && num <= 39.9)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\n[{num}] => Your Status is : Overweight\n");
                Console.ResetColor();
            }
            else if (num >= 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n[{num}] => Your Status is : Obese \n");
                Console.ResetColor();
            }
        }
    }
}

