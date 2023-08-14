using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    static class Bacon
    {
        public static async Task Prepare()
        {
            await Task.Run(() =>
         {
             Thread.Sleep(100);
             Console.WriteLine("Cooking the first side of bacon ...");

             for (int i = 0; i < 3; i++)
             {
                 Console.WriteLine("Flipping a slice of bacon");
             }
             Thread.Sleep(300);
             Console.WriteLine("Cooking the second side of bacon ...");
             Console.WriteLine("Put bacon on plate");
             Thread.Sleep(200);
             Console.WriteLine("Bacon is ready!");
         });
        }
    }
}