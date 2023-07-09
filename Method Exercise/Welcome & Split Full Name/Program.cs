using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string full_Name ="";
            getName(full_Name);

        }

        static void getName(string fullName)
        {
            Console.WriteLine("Please Enter Your Full Name :");
            fullName = Console.ReadLine();
            validate(fullName);
            var firstName = fullName.Substring(0, fullName.IndexOf(" "));
            var lastName = fullName.Substring(fullName.IndexOf(" ") + 1);
            Console.WriteLine("-------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nHi Dear {firstName} :)");
            Console.WriteLine($"\nYour first name is {firstName.ToUpper()} and your last name is {lastName.ToUpper()}");
            Console.ResetColor();
            

        }
        static void validate(string fullName)
        {
            while (string.IsNullOrEmpty(fullName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\tError : You Entered Nothing , Please Try Again !!!");
                Console.ResetColor();
                getName(fullName);

            }

        }

    }
}
