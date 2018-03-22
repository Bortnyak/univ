using System;
using System.Diagnostics;

namespace lab4test
{
    class MyTask1
    {
        static int sum = 0;
        public static void Run()
        {

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 999999; i++)
            {
                sum += i;
                Console.WriteLine(sum);
                Console.WriteLine("HELOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO FROM METHOD RUN");
            }
            timer.Stop();
            Console.WriteLine("For cycle finished work with {0} ms", timer.ElapsedMilliseconds);
            Console.WriteLine("sum = {0}", sum);
            Console.ReadKey();
        }
    }
}
