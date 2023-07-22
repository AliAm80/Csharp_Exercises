using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_3
{
    abstract class Shapes
    {
        public string Name { get; set; }
        public int Sides { get; set; }
        public string Area { get; set; }
        public string Perimeter { get; set; }

        public Shapes()
        {
            Name = "";
            Area = "";
            Perimeter = "";
        }

        public void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nThe shape name is {Name}");
            Console.WriteLine($"This has {Sides} sides");
            Console.WriteLine($"The Area of {Name} is -> [{Area}]");
            Console.WriteLine($"The Perimeter of {Name} is -> [{Perimeter}]\n");
            Console.ResetColor();
        }

        public string ShowMenu()
        {
            Console.WriteLine("1- Show Info of the shape");
            Console.WriteLine("2- Calculate Area of the shape");
            Console.WriteLine("3- Calculate Perimeter of the shape");
            Console.Write("\nEnter Number -> ");
            var answer = Console.ReadLine();
            if (answer != "1" && answer != "2" && answer != "3")
            {
                Error();
            }
            return answer;
        }

        public static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\tERROR : You Entered Invaild !!!\n");
            Console.ResetColor();
            Environment.Exit(0);
        }




    }
}