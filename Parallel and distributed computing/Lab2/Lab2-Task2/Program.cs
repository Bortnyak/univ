using System;
using System.Linq;
using System.Threading;


namespace Lab2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThread thread = new MyThread("Potok №1", 8);
            MyThread thread2 = new MyThread("Potok №2", 5);


            do
            {
                Console.Write(".");
                Thread.Sleep(100);
            } while (thread.newThrd.IsAlive | thread2.newThrd.IsAlive);
            Console.WriteLine("Main Thread is completed.");
            Console.ReadLine();
        }
    }
}
