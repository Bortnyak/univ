using System;
using System.Threading.Tasks;
using System.Threading;

namespace lab4_zavd_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread is started.");

            Task task2 = new Task(CountMethod);
            Task task3 = new Task(MyClass.MyTask2);

            task2.Start();
            task3.Start();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("MAIN is working");
                Console.WriteLine(".");
                Thread.Sleep(200);
            }
            Console.WriteLine("Main() is done.");
            Console.ReadLine();
        }

        static void CountMethod()
        {
            Console.WriteLine("static CountMethod is started");
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine("In the method CountMethod, i = {0}", i);
            }
            Console.WriteLine("CountMethod DONE");
        }
    }
}
