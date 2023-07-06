using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\tThis Program choose a random number and you should guess it ...");
            Console.ResetColor();
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            do
            {
                int guess = 0;
                int round = 0;
                int randomNum = random.Next(min, max + 1);
                while (guess != randomNum)
                {
                    Console.WriteLine($"Guess a number between {min} - {max} :");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Guess Number : [{guess}]");

                    if (guess > max || guess < min)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your guess number is out of range !!!");
                        Console.ResetColor();
                    }
                    else if (guess > randomNum)
                    {
                        Console.WriteLine($"{guess} is too high");
                    }
                    else if (guess < randomNum)
                    {
                        Console.WriteLine($"{guess} is too low");
                    }
                    round++;
                }
                Console.Clear();
                Console.WriteLine("The random number is -> " + randomNum);
                Console.WriteLine("Round: " + round);
                Console.WriteLine("You Won :)");
                Console.WriteLine("Would you like to play again ? (yes/no)");
                var answer = Console.ReadLine().ToLower();
                //   playAgain = answer.ToLower() == "yes" ;
                if (answer == "yes")
                {
                    playAgain = true;
                }
                else if (answer == "no")
                {
                    playAgain = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\tE R R O R : Try Again !!!");
                    Console.ResetColor();
                    playAgain = false;
                    return;
                }

            } while (playAgain);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t\tThanks for playing :) ");
            Console.ResetColor();





        }
    }
}