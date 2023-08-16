using System;

namespace Challenge_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number : ");
            var number = Console.ReadLine();
            Console.WriteLine(ReverseAndNot(number));
        }

        static string ReverseAndNot(string number)
        {
            var temp = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                temp += number[i];
            }

            return temp + number;

        }
    }
}

