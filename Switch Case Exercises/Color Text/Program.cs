using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get text & color
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\tThis Progarm gets a text , then you can choose its color ...");
            Console.ResetColor();
            Console.WriteLine("Please write something :");
            var text = Console.ReadLine();
            Console.WriteLine("Which color do you choose ? (blue - red - green - cyan - yellow)");
            var color = Console.ReadLine().ToLower();
            

            switch (color)
            {
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"[{text}]");
                    Console.ResetColor();
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[{text}]");
                    Console.ResetColor();
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"[{text}]");
                    Console.ResetColor();
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"[{text}]");
                    Console.ResetColor();
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"[{text}]");
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("Your Color Does Not Support !!!");
                    break;
                    
            }









        }
    }
}