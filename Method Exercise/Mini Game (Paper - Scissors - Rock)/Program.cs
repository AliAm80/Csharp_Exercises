using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var playAgain = false;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t\t\tThis is a mini game, hope you enjoy it ... \n\n");
                Console.ResetColor();

                var player = Player();
                Validation(player);
                var computer = Computer();
    
                Console.WriteLine($"\nPlayer : [{player}]");
                Console.WriteLine($"Computer : [{computer}]");
                Console.Write($"Result -> ");
                Game(player, computer);

                Console.WriteLine("\n");
                Console.WriteLine("Would you like to play again ? (yes/no)");
                var answer = Console.ReadLine();
                if (answer == "yes")
                {
                    playAgain = true;
                }
                else if (answer == "no")
                {
                    Console.WriteLine("\nThanks For Playing This Game :)\n");
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\tE R R O R : Try Again !!!\n\n");
                    Console.ResetColor();
                    Environment.Exit(0);
                }

            } while (playAgain);

        }

        static string Player()
        {
            Console.WriteLine("\t\t\t\t------------------------ Start Game -----------------------\n");
            Console.Write("\nEnter Rock / Scissors / Paper : ");
            var player = Console.ReadLine();
            return player.ToLower();
        }
        static string Computer()
        {
            string[] game = { "paper", "scissors", "rock" };
            Random rand = new Random();
            var num = rand.Next(0, 3);
            var computer = game[num];
            return computer;
        }
        static void Game(string player, string computer)
        {
            switch (player)
            {
                case "paper":
                    if (computer == "paper")
                    {
                        Console.WriteLine("It's a draw !!!");
                    }
                    else if (computer == "scissors")
                    {
                        Console.WriteLine("You lose !!!");
                    }
                    else
                    {
                        Console.WriteLine("You Win !!!");
                    }
                    break;
                case "scissors":
                    if (computer == "paper")
                    {
                        Console.WriteLine("You Win !!!");
                    }
                    else if (computer == "scissors")
                    {
                        Console.WriteLine("It's a draw !!!");
                    }
                    else
                    {
                        Console.WriteLine("You lose !!!");
                    }
                    break;
                case "rock":
                    if (computer == "scissors")
                    {
                        Console.WriteLine("You Win !!!");
                    }
                    else if (computer == "rock")
                    {
                        Console.WriteLine("It's a draw !!!");
                    }
                    else
                    {
                        Console.WriteLine("You lose !!!");
                    }
                    break;
            }
        }
        static void Validation(string player)
        {
            if (player != "paper" && player != "scissors" && player != "rock")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nERROR : You Entered Invalid Keyword !!!\n");
                Console.ResetColor();
                Environment.Exit(0);
            }
        }
    }
}