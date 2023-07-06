using System;

namespace T1_switch
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please Enter Your Number :");
            var num = Convert.ToInt32(Console.ReadLine());
            var cal = num % 2;
            switch (cal)
            {
                case 0:
                    Console.WriteLine("Your Number is Even");
                    break;
                case 1:
                    Console.WriteLine("Your Number is Odd");
                    break;
                default:
                    Console.WriteLine("E R R O R !");
                    break;
                    
            }



        }
    }
}