using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    static class Breakfast
    {
        public static async Task Ready()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(500);
                Console.WriteLine("Breakfast is ready!");
            });
        }
    }
}