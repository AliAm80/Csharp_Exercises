using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Shapes
    {
        public string name;
        public int sides;
        public string area;
        public string perimeter;

        public Shapes()
        {
            name = "";
            area = "";
            perimeter = "";
        }

        public void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nThe shape name is {name}");
            Console.WriteLine($"This has {sides} sides");
            Console.WriteLine($"The Area of {name} is -> [{area}]");
            Console.WriteLine($"The Perimeter of {name} is -> [{perimeter}]\n");
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