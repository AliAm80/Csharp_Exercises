using System;
using System.Diagnostics;

namespace Exercise_8
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();
            await Coffee.Prepare();
            await Eggs.Prepare();
            await Bacon.Prepare();
            Task.WaitAll(Toast.Prepare(),
                        Jam.Prepare());
            await Juice.Prepare();
            await Breakfast.Ready();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds + " ms");
        }
    }
}