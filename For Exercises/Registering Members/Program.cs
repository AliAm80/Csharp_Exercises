using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many members do you have ?");
            var num = Convert.ToInt32(Console.ReadLine());
            string[] fullName = new string[num];
            string[] firstName = new string[num];
            string[] lastName = new string[num];
            for (int i = 0; i < num; i++)
            {
                while (string.IsNullOrEmpty(fullName[i]))
                {
                    Console.WriteLine($"Please Enter full name of member[{i + 1}] :");
                    fullName[i] = Console.ReadLine();
                }

                firstName[i] = fullName[i].Substring(0, fullName[i].IndexOf(" "));
                lastName[i] = fullName[i].Substring(fullName[i].IndexOf(" ") + 1);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------------------------------- List ----------------------------------------\n\n");
            Console.ResetColor();

            for (int i = 0; i < num; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Member {i + 1} -> First Name : {firstName[i].ToUpper()} / Last Name : {lastName[i].ToUpper()}");
                Console.WriteLine("\n");
                Console.ResetColor();
            }






        }
    }
}