using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    static class Coffee
    {
        public static async Task Prepare()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(200);
                Console.WriteLine("Pouring Coffee");
                Console.WriteLine("coffee is ready!");
            });
        }
    }
}