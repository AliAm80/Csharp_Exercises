using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    static class Eggs
    {
        public static async Task Prepare()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(100);
                Console.WriteLine("Warmming the egg pan ...");
                Thread.Sleep(500);
                Console.WriteLine("Eggs are ready!");
            });
        }
    }
}