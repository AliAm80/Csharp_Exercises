using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tThis program calculate power of a number & minimum and maximum from a list of numbers");
            Console.ResetColor();
            var again = true;
            do
            {
                Console.WriteLine("\n\nPlease Choose Your Operation ...");
                Console.Write("[power - max - min] -> ");
                var operation = Console.ReadLine();
                operation = operation.ToLower();
                double result;
                Console.Clear();
                switch (operation)
                {
                    case "power":
                        Console.WriteLine("Enter Your Number :");
                        var num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nEnter Power :");
                        var power = Convert.ToInt32(Console.ReadLine());
                        result = Pow(num, power);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\n{num} to power of {power} is -> [{result}]");
                        Console.WriteLine("\n\n");
                        Console.ResetColor();
                        break;
                    case "min":
                        Console.WriteLine("How many numbers do you have ?");
                        var number = Convert.ToInt32(Console.ReadLine());
                        var numbers = new int[number];
                        for (int i = 0; i < number; i++)
                        {
                            Console.WriteLine($"\nEnter Number[{i + 1}] : ");
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        result = FindMin(numbers);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nThe Minimum list of your numbers is -> [{result}]");
                        Console.WriteLine("\n\n");
                        Console.ResetColor();
                        break;
                    case "max":
                        Console.WriteLine("How many numbers do you have ?");
                        number = Convert.ToInt32(Console.ReadLine());
                        numbers = new int[number];
                        for (int i = 0; i < number; i++)
                        {
                            Console.WriteLine($"\nEnter Number[{i + 1}] : ");
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        result = FindMax(numbers);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nThe Maximum list of your numbers is -> [{result}]");
                        Console.WriteLine("\n\n");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nERROR : The operation does not match !!!");
                        Console.WriteLine("\n\n");
                        Console.ResetColor();
                        break;

                }
                Console.WriteLine("Would you like to continue ? (yes/no)");
                var answer = Console.ReadLine();
                Console.WriteLine("\n");
                answer = answer.ToLower();
                if (answer == "yes")
                {
                    again = true;
                }
                else if (answer == "no")
                {
                    again = false;
                    Console.WriteLine("\nThanks for your attention :)\n");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    again = false;
                    Console.WriteLine("ERROR : Please Try Again !!!");
                    Console.WriteLine("\n");
                    Console.ResetColor();
                }

            } while (again);

        }

        static double Pow(double num, double power)
        {
            double result = num;

            for (int i = 1; i <= power - 1; i++)
            {
                result *= num;
            }

            return result;
        }

        static int FindMax(int[] numbers)
        {
            var max = numbers[0];
            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
        static int FindMin(int[] numbers)
        {
            var min = numbers[0];
            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }

    }
}
