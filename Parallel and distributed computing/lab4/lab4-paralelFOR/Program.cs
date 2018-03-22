using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab4_paralelFOR
{
    class Program
    {
        static double[] data;
        static void MyTransform(int i)
        {
            data[i] /= 10;
            if (data[i] < 10000) data[i] = 0;
            if ((data[i] >= 10000) & (data[i] < 20000)) data[i] = 100;
            if ((data[i] >= 20000) & (data[i] < 30000)) data[i] = 200;
            if (data[i] > 30000) data[i] = 300;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread is starting.");

            Stopwatch timer = new Stopwatch();

            data = new double[100000000];

            timer.Start();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }
            timer.Stop();

            Console.WriteLine("Serial initialization of cycle = {0} seconds", timer.Elapsed.TotalSeconds);
            timer.Reset();

            timer.Start();
            Parallel.For(0, data.Length, MyTransform);
            timer.Stop();
            Console.WriteLine("Parallel transformation = {0} seconds", timer.Elapsed.TotalSeconds);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < data.Length; i++)
            {
                MyTransform(i);
            }
            timer.Stop();

            Console.WriteLine("Serial Transformation = {0} seconds", timer.Elapsed.TotalSeconds);

            Console.WriteLine("Main() is done.");
            Console.ReadLine();
        }
    }
}
