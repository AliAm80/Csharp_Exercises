using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    static class Jam
    {
        public static async Task Prepare()
        {
            await Task.Run(() =>
          {
              Thread.Sleep(700);
              Console.WriteLine("Putting butter on the toast");
              Console.WriteLine("Putting jam on the toast");
          });

        }
    }
}