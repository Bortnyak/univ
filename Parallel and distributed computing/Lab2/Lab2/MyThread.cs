using System;
using System.Threading;

namespace Lab2
{
    class MyThread1
    {
        public Thread newThrd;
        public int Count;

        public MyThread1(string name)
        {
            Count = 0;
            newThrd = new Thread(this.Run);
            newThrd.Name = name;
            newThrd.Start();

        }

        //Точка входу у потік
        public void Run()
        {
            Console.WriteLine("\n**********************************");
            Console.WriteLine("\t" + newThrd.Name + " starting...");
            Console.WriteLine("\n**********************************");

            do
            {
                Thread.Sleep(400);
                Console.WriteLine("\nIn the thread " + newThrd.Name + "\tCount = " + Count);
                Count++;
            } while (Count < 15);
            Console.WriteLine("\n**********************************");
            Console.WriteLine("\n\t" + newThrd.Name + " is completed!");
            Console.WriteLine("\n**********************************");
        }
    }
}
