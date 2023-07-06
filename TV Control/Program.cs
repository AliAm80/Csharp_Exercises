using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t Info : Welcome to Channel switcher program ...");
            Console.ResetColor();
            var channel = 1;
            var answer = string.Empty;
            // var result = "";
            
            // check the channel
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\t\t\t---------------- TV shows Channel[{channel}] ---------------------");
                Console.ResetColor();
                Console.WriteLine("Do you like this Channel ? (yes / no)");
                answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer == "no")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Channel[{channel++}] changed to Channel[{channel}]");
                    Console.ResetColor();
                }

                // result = answer == "no" ? $"Channel[{channel++}] changed to Channel[{channel}]" : "Channel[{channel}] -> Enjoy your watching :)";
            } while (answer == "no");
            

            if (answer == "yes")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Channel[{channel}] -> Enjoy your watching :)");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\t\tE R R O R : your answer is not match , please try again !!!");
                Console.ResetColor();
            }
            // var counter = 0;
            // Console.WriteLine(counter++);
            // Console.WriteLine(counter);




        }
    }
}