using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace lab4_zavd_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<Task>();
            Task task1 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("somthing doig");
                Console.WriteLine(".");
            });

            Task task2 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("somthing doig 222222222");
                Console.WriteLine(".");
            });

            tasks.Add(task1);
            tasks.Add(task2);

            Task.WaitAll(tasks.ToArray());


            Console.WriteLine("Now, start one more task");

            Task task3 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(600);
                Console.WriteLine("somthing doig 33333333");
                Console.WriteLine(".");
            });

            Console.ReadLine();
        }
    }
}
