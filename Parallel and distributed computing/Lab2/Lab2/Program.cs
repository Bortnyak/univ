using System;
using System.Threading;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThread1 thread = new MyThread1("Potok №1");
            MyThread2 thread2 = new MyThread2("Potok №2");

            do
            {
                Console.Write(".");
                Thread.Sleep(11);
            } while (thread.Count < 15 || thread2.Count > 0);
        }
    }
}
