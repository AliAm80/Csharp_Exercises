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
            var cup = ReadyCoffee();
            Console.WriteLine("Coffee is ready!");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);


            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);

                if (finishedTask == eggsTask)
                {
                    Console.WriteLine("Eggs are ready!");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("Bacon is ready!");
                }
                else if (finishedTask == toastTask)
                {
                    Console.WriteLine("Toast is ready!");
                }
                breakfastTasks.Remove(finishedTask);
            }

            var juice = ReadyJuice();
            Console.WriteLine("Juice is ready!");
            Console.WriteLine("Breakfast is ready!");




            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds + " ms");
        }

        private static Coffee ReadyCoffee()
        {
            Console.WriteLine("Pouring Coffee");
            return new Coffee();
        }
        private static Juice ReadyJuice()
        {
            Console.WriteLine("Pouring Juice");
            return new Juice();
        }
        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warmming the egg pan ...");
            await Task.Delay(3000);
            for (int egg = 0; egg < howMany; egg++)
            {
                 Console.WriteLine($"Egg {egg + 1} is ready!");
            }
            return new Egg();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine("Cooking the first side of bacon ...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Flipping a slice of bacon");
            }
            Console.WriteLine("Cooking the second side of bacon ...");
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }
        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting ...");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static void ApplyButter(Toast toast)
        {
            Console.WriteLine("Putting butter on the toast");
        }
        private static void ApplyJam(Toast toast) =>
         Console.WriteLine("Putting jam on the toast");

    }
}