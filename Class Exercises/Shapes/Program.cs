using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var restart = true;
            while (restart)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t\tThis program shows info of shapes & calculate area and premeter ...");
                Console.ResetColor();
                Console.WriteLine("\n");
                Console.WriteLine("\t\t\t\t\t-------------- Shapes ---------------\n");
                Console.WriteLine("1- Rectangle");
                Console.WriteLine("2- Circle");
                Console.WriteLine("3- Square");
                Console.WriteLine("4- Triangle");

                Console.Write("\nwhich shape do you choose [Enter number of shape] ? ");
                var shape = Console.ReadLine();
                Console.Clear();

                switch (shape)
                {
                    case "1":
                        Rectangle rectangle = new Rectangle();
                        var answer = rectangle.ShowMenu();

                        switch (answer)
                        {
                            case "1":
                                rectangle.ShowInfo();
                                break;
                            case "2":
                                var value = rectangle.GetValue();
                                Console.WriteLine($"The Area of Rectangle is -> [{rectangle.Area(value.Item1, value.Item2)}]");
                                break;
                            case "3":
                                value = rectangle.GetValue();
                                Console.WriteLine($"The Perimeter of Rectangle is -> [{rectangle.Perimeter(value.Item1, value.Item2)}]");
                                break;
                        }
                        break;
                    case "2":
                        Circle circle = new Circle();
                        answer = circle.ShowMenu();

                        switch (answer)
                        {
                            case "1":
                                circle.ShowInfo();
                                break;
                            case "2":
                                var value2 = circle.GetValue();
                                Console.WriteLine($"The Area of Circle is -> [{circle.Area(value2)}]");
                                break;
                            case "3":
                                value2 = circle.GetValue();
                                Console.WriteLine($"The Perimeter of Circle is -> [{circle.Perimeter(value2)}]");
                                break;
                        }
                        break;
                    case "3":
                        Square square = new Square();
                        answer = square.ShowMenu();

                        switch (answer)
                        {
                            case "1":
                                square.ShowInfo();
                                break;
                            case "2":
                                var value3 = square.GetValue();
                                Console.WriteLine($"The Area of Square is -> [{square.Area(value3)}]");
                                break;
                            case "3":
                                value3 = square.GetValue();
                                Console.WriteLine($"The Perimeter of Square is -> [{square.Perimeter(value3)}]");
                                break;
                        }
                        break;
                    case "4":
                        Triangle triangle = new Triangle();
                        answer = triangle.ShowMenu();

                        switch (answer)
                        {
                            case "1":
                                triangle.ShowInfo();
                                break;
                            case "2":
                                var value4 = triangle.GetValue();
                                Console.WriteLine($"The Area of Triangle is -> [{triangle.Area(value4.Item1, value4.Item2)}]");
                                break;
                            case "3":
                                var value5 = triangle.GetValue2();
                                Console.WriteLine($"The Perimeter of Triangle is -> [{triangle.Perimeter(value5.Item1, value5.Item2, value5.Item3)}]");
                                break;
                        }
                        break;
                    default:
                        Shapes.Error();
                        break;
                }

                Console.Write("\nWould you like to try again (yes/no) ? ");
                var result = Console.ReadLine();
                result = result.ToLower();
                restart = result == "yes";


            }

            Console.WriteLine("\n");
            Console.WriteLine("Thanks for using :)\n");










        }
    }
}