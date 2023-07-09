using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string full_Name = getName();
            Console.Clear();
            showName(full_Name);

        }

        static string getName()
        {
            Console.WriteLine("Please Enter Your Full Name :");
            var fullName = Console.ReadLine();
            if (string.IsNullOrEmpty(fullName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\tError : You Entered Nothing , Please Try Again !!!");
                Console.ResetColor();
                return getName();
            }
            else
            {
                return fullName;
            }

        }

        static void showName(string fullName)
        {
            var firstName = fullName.Substring(0, fullName.IndexOf(" "));
            var lastName = fullName.Substring(fullName.IndexOf(" ") + 1);
            Console.WriteLine("-------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nHi Dear {firstName} :)");
            Console.WriteLine($"\nYour first name is {firstName.ToUpper()} and your last name is {lastName.ToUpper()}\n\n");
            Console.ResetColor();
        }

    }
}
