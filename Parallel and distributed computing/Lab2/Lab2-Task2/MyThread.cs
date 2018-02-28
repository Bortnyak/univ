using System;
using System.Threading;

namespace Lab2_Task2
{
    class MyThread
    {
        public Thread newThrd;
        public int Count;

        public MyThread(string name, int num)
        {
            Count = 0;
            newThrd = new Thread(this.Run);
            newThrd.Name = name;
            newThrd.Start(num);
        }

        //Точка входу у потік
        public void Run(object num)
        {
            Console.WriteLine("\n**********************************");
            Console.WriteLine("\t" + newThrd.Name + " starting...");
            Console.WriteLine("\n**********************************");

            do
            {
                Thread.Sleep(400);
                Console.WriteLine("\nIn the thread " + newThrd.Name + "\tCount = " + Count);
                Count++;
            } while (Count <= (int)num);
            Console.WriteLine("\n**********************************");
            Console.WriteLine("\n\t" + newThrd.Name + " is completed!");
            Console.WriteLine("\n**********************************");
        }
    }
}
