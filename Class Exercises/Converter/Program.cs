using System;

namespace Ex_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\tWelcome To Converter :)\n");
            Console.ResetColor();
            try
            {
                while (true)
                {
                    var menu = ShowInput.Menu();
                    Console.Clear();
                    ShowInput.Choose(menu);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Console.ResetColor();

            }

        }
    }
}