using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_8
{
    static class Toast
    {
        public static async Task Prepare()
        {
            await Task.Run(() =>
        {
            Thread.Sleep(500);
            Console.WriteLine("Putting a slice of bread in the toaster");
            Console.WriteLine("Putting a slice of bread in the toaster");
            Console.WriteLine("Start toasting ...");
            Thread.Sleep(100);
            Console.WriteLine("Remove toast from toaster");
            Thread.Sleep(200);
            Console.WriteLine("Toast is ready!");

        });
        }
    }
}