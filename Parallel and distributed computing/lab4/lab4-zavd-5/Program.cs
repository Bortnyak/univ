using System;
using System.Threading.Tasks;
using System.Diagnostics;


namespace lab4_zavd_5
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
        static void TransformPI(int i)
        {
            data[i] /= Math.PI;
            if (data[i] < 10000) data[i] = 0;
            if ((data[i] >= 10000) & (data[i] < 20000)) data[i] = 100;
            if ((data[i] >= 20000) & (data[i] < 30000)) data[i] = 200;
            if (data[i] > 30000) data[i] = 300;
        }
        static void TransofrmEXP(int i)
        {
            data[i] = Math.Exp(data[i]) / Math.Pow(data[i], Math.PI);
            if (data[i] < 10000) data[i] = 0;
            if ((data[i] >= 10000) & (data[i] < 20000)) data[i] = 100;
            if ((data[i] >= 20000) & (data[i] < 30000)) data[i] = 200;
            if (data[i] > 30000) data[i] = 300;
        }

        static void TransformEXP2(int i)
        {
            data[i] = Math.Exp(Math.PI * data[i]) / Math.Pow(data[i], Math.PI);
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

            ///////////////////////////////////////////////////////////////////////////////////////
            //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            timer.Start();
            Parallel.For(0, data.Length, MyTransform);
            timer.Stop();
            Console.WriteLine("\nParallel transformation MyTransofrm = {0} seconds", timer.Elapsed.TotalSeconds);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < data.Length; i++)
            {
                MyTransform(i);
            }
            timer.Stop();
            Console.WriteLine("Serial transformation MyTransofrm = {0} seconds", timer.Elapsed.TotalSeconds);

            timer.Start();
            Parallel.For(0, data.Length, TransformPI);
            timer.Stop();
            Console.WriteLine("\nParallel transformation TransformPI = {0} seconds", timer.Elapsed.TotalSeconds);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < data.Length; i++)
            {
                TransformPI(i);
            }
            timer.Stop();
            Console.WriteLine("Serial Transformation TransformPI = {0} seconds", timer.Elapsed.TotalSeconds);

            timer.Start();
            Parallel.For(0, data.Length, TransofrmEXP);
            timer.Stop();
            Console.WriteLine("\nParallel transformation TransofrmEXP = {0} seconds", timer.Elapsed.TotalSeconds);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < data.Length; i++)
            {
                TransofrmEXP(i);
            }
            timer.Stop();
            Console.WriteLine("Serial Transformation TransofrmEXP = {0} seconds", timer.Elapsed.TotalSeconds);

            timer.Start();
            Parallel.For(0, data.Length, TransformEXP2);
            timer.Stop();
            Console.WriteLine("\nParallel transformation TransformEXP2 = {0} seconds", timer.Elapsed.TotalSeconds);
            timer.Reset();

            timer.Start();
            for (int i = 0; i < data.Length; i++)
            {
                TransformEXP2(i);
            }
            timer.Stop();
            Console.WriteLine("Serial Transformation TransformEXP2 = {0} seconds", timer.Elapsed.TotalSeconds);

            Console.WriteLine("Main() is done.");
            Console.ReadLine();
        }
    }
}
