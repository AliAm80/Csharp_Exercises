using System;

namespace T2_if
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Three Numbers
            Console.WriteLine("\t\t\t\tThis Progarm Show Max & Min ...");
            Console.WriteLine("Please Enter Number 1 :");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Number 2 :");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Number 3 :");
            var num3 = Convert.ToInt32(Console.ReadLine());
            // Find Min & Max
            var min = 0;
            var max = 0;
            if (num1 >= num2 && num1 >= num3)
            {
                max = num1;
                if (num2 <= num3)
                {
                    min = num2;
                }
                else if (num2 >= num3)
                {
                    min = num3;
                }

            }
            if (num2 >= num1 && num2 >= num3)
            {
                max = num2;
                if (num1 <= num3)
                {
                    min = num1;
                }
                else if (num1 >= num3)
                {
                    min = num3;
                }

            }
            if (num3 >= num2 && num3 >= num1)
            {
                max = num3;
                if (num2 <= num1)
                {
                    min = num2;
                }
                else if (num2 >= num1)
                {
                    min = num1;
                }

            }
            // Print Min & Max
            if (min != max)
            {  
            Console.WriteLine($"The Largest Number is [{max}]");
            Console.WriteLine($"The Smallest Number is [{min}]");
            }
            else 
            {
                Console.WriteLine($"All Of Three Numbers Are Equal => [{min}]");
                
            }







        }
    }
}