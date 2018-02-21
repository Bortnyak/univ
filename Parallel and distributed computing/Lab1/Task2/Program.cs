using System;
using System.Threading;

namespace Task2
{
    public delegate double BinaryOp(double x, double y);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
            BinaryOp b = new BinaryOp(Comparison);
            double answer = b(10.0, 10.0);    //Ці рядки не будуть виконуватися до тих пір, поки    //не завершить роботу метод Add()     
            Console.WriteLine("10.0 vs 10.0 -> {0}.", answer);

            Console.ReadLine();
        }


        static double Comparison(double x, double y)
        {
            Console.WriteLine("Add() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("******** Comparison ********");

            Thread.Sleep(2000);
            double bigger = 0;
            if (x > y)
            {
                bigger = x;
            }
            else if (x < y)
            {
                bigger = y;
            }
            else
            {
                Console.WriteLine("they are equal");
            }
            return bigger;
        }
    }
}
