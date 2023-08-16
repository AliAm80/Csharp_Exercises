using System;

namespace Challenge_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter items (startTime, endTime, hourlyRate, overTimeMultiplier ) : ");
            var inputs = Console.ReadLine();
            var inputs2 = inputs.Split(" ");
            var inputsList = new List<double>();
            foreach (var item in inputs2)
            {
                inputsList.Add(Convert.ToDouble(item));
            }

            Console.WriteLine("Your Salary is : " + Salary(inputsList));

        }

        static string Salary(List<double> times)
        {
            var startTime = times[0];
            var endTime = times[1];
            var hourlyRate = times[2];
            var overTimeMultiplier = times[3];

            double overTime = 0;
            double regular = 0;

            if (endTime >= 17)
            {
                overTime = endTime - 17;
                overTime = overTime * hourlyRate * overTimeMultiplier;
                regular = 17 - startTime;
            }
            else
            {
                regular = endTime - startTime;
            }

            regular *= hourlyRate;

            var salary = overTime + regular;

            return "$" + $"{salary:F2}";
        }
    }
}