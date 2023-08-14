using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    static class Juice
    {
        public static async Task Prepare()
        {
            await Task.Run(() =>
          {
              Thread.Sleep(300);
              Console.WriteLine("Pouring orange juice");
              Console.WriteLine("Orange juice is ready!");
          });

        }
    }
}