using System;

namespace Get_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\tThis program makes a list for the employed members ...\n");
            Console.ResetColor();
            try
            {
                Console.Write("Please Enter number of your member : ");
                var number = Convert.ToInt32(Console.ReadLine());
                var members = new Member[number];
                Console.Clear();

                for (int i = 0; i < number; i++)
                {
                    string fullName = "";
                    string age = "";
                    string job = "";
                    int id = 0;

                    while (fullName == "" || age == "" || job == "")
                    {
                        Console.Write($"\nEnter fullName of member [{i + 1}] : ");
                        // members[i]._fullName = Console.ReadLine();
                        fullName = Console.ReadLine();
                        Console.Write($"\nEnter age of member [{i + 1}] : ");
                        age = Console.ReadLine();
                        Console.Write($"\nEnter job of member [{i + 1}] : ");
                        job = Console.ReadLine();
                        Console.WriteLine("\n-----------------");
                    }

                    Console.WriteLine("\n-----------------");
                    Member person = new Member(fullName, Convert.ToInt32(age), job, id);
                    members[i] = person;
                }
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n-------------------------------- INFO ------------------------------\n");
                foreach (var member in members)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@$"Id : [{member._id}] Name : [{member._fullName}] Age : [{member._age}] Job : [{member._job}]");
                    Console.WriteLine("\n");
                    Console.ResetColor();
                }
            }

            catch (FormatException ex)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                Console.WriteLine("Please Enter The Correct Format .... \n");

            }


        }
    }
}